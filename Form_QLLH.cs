using System;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form_QLLH : Form
    {
        public Form_QLLH()
        {
            InitializeComponent();

            // ── Bước 1: Tắt AutoGenerateColumns vì Designer đã định nghĩa cột sẵn ──
            dataGridView.AutoGenerateColumns = false;

            // ── Bước 2: Gán DataPropertyName cho từng cột khớp với tên property ──
            colMaLH.DataPropertyName = "malop";
            colTenLop.DataPropertyName = "tenlop";
            colGVCN.DataPropertyName = "tengvcn";
            colSiSo.DataPropertyName = "siso";

            // ── Bước 3: Thiết lập chọn cả dòng và bắt sự kiện ──
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false; // Ẩn cột Row Header thừa bên trái
            dataGridView.CellClick += dataGridView_CellClick;

            LoadDataGridView();
        }

        // ─── Tính sĩ số thực tế và cập nhật vào cột siso của tbl_lop ─────────
        public static void UpdateSiSo(string malop)
        {
            try
            {
                using (QLSVDataContext db = new QLSVDataContext())
                {
                    var lop = db.tbl_lops.FirstOrDefault(l => l.malop.Trim() == malop.Trim());
                    if (lop != null)
                    {
                        lop.siso = db.tbl_sinhviens.Count(s => s.malop.Trim() == malop.Trim());
                        db.SubmitChanges();
                    }
                }
            }
            catch { /* bỏ qua lỗi cập nhật sĩ số */ }
        }

        // ─── Load toàn bộ lớp học lên DataGridView (dùng DataSource) ─────────
        private void LoadDataGridView()
        {
            try
            {
                using (QLSVDataContext db = new QLSVDataContext())
                {
                    // Dùng DataSource theo hướng dẫn mục 5.2
                    // DataPropertyName ở trên đã khớp với tên property bên dưới
                    var ds = db.tbl_lops
                               .Select(l => new
                               {
                                   malop = l.malop,
                                   tenlop = l.tenlop,
                                   tengvcn = l.tengvcn,
                                   siso = l.siso.HasValue ? l.siso.Value : 0
                               })
                               .ToList();

                    dataGridView.DataSource = ds;
                }

                // Tùy chỉnh cột sau khi bind (hướng dẫn mục 7)
                dataGridView.Columns["colMaLH"].HeaderText = "Mã Lớp";
                dataGridView.Columns["colTenLop"].HeaderText = "Tên Lớp";
                dataGridView.Columns["colGVCN"].HeaderText = "Giáo Viên CN";
                dataGridView.Columns["colSiSo"].HeaderText = "Sĩ Số";
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu lớp học: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Xóa trắng các ô nhập liệu ───────────────────────────────────────
        private void ClearInputs()
        {
            txt_malh.Text = "";
            txt_tenlop.Text = "";
            txt_gvcn.Text = "";
            txt_siso.Text = "";
            txt_malh.ReadOnly = false;
            txt_siso.ReadOnly = true;   // siso luôn chỉ đọc
            txt_malh.Focus();
        }

        // ─── CellClick vào dòng → điền vào ô nhập liệu (hướng dẫn mục 8) ────
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua khi click vào header (RowIndex = -1)
            if (e.RowIndex < 0) return;

            txt_malh.Text = dataGridView.Rows[e.RowIndex].Cells["colMaLH"].Value?.ToString();
            txt_tenlop.Text = dataGridView.Rows[e.RowIndex].Cells["colTenLop"].Value?.ToString();
            txt_gvcn.Text = dataGridView.Rows[e.RowIndex].Cells["colGVCN"].Value?.ToString();
            txt_siso.Text = dataGridView.Rows[e.RowIndex].Cells["colSiSo"].Value?.ToString();

            txt_malh.ReadOnly = true;   // không cho sửa mã lớp khi đã chọn
            txt_siso.ReadOnly = true;   // siso tự tính, không cho sửa tay
        }

        // ─── THÊM lớp học ─────────────────────────────────────────────────────
        private void btn_add_Click(object sender, EventArgs e)
        {
            string malop = txt_malh.Text.Trim();
            string tenlop = txt_tenlop.Text.Trim();
            string tengvcn = txt_gvcn.Text.Trim();

            if (string.IsNullOrWhiteSpace(malop) || string.IsNullOrWhiteSpace(tenlop))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Lớp và Tên Lớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tengvcn))
            {
                MessageBox.Show("Vui lòng nhập Tên Giáo Viên Chủ Nhiệm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (QLSVDataContext db = new QLSVDataContext())
                {
                    if (db.tbl_lops.Any(l => l.malop.Trim() == malop))
                    {
                        MessageBox.Show("Mã Lớp đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    tbl_lop lop = new tbl_lop
                    {
                        malop = malop,
                        tenlop = tenlop,
                        tengvcn = tengvcn,
                        siso = 0   // lớp mới chưa có sinh viên
                    };

                    db.tbl_lops.InsertOnSubmit(lop);
                    db.SubmitChanges();
                }

                LoadDataGridView();
                ClearInputs();
                MessageBox.Show("Thêm lớp học thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lớp học: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── SỬA lớp học ──────────────────────────────────────────────────────
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string malop = txt_malh.Text.Trim();
            string tenlop = txt_tenlop.Text.Trim();
            string tengvcn = txt_gvcn.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenlop) || string.IsNullOrWhiteSpace(tengvcn))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên Lớp và Tên GVCN!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (QLSVDataContext db = new QLSVDataContext())
                {
                    var lop = db.tbl_lops.FirstOrDefault(l => l.malop.Trim() == malop);
                    if (lop == null)
                    {
                        MessageBox.Show("Không tìm thấy lớp học!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    lop.tenlop = tenlop;
                    lop.tengvcn = tengvcn;
                    // siso KHÔNG cập nhật ở đây — tự tính theo số sinh viên

                    db.SubmitChanges();
                }

                LoadDataGridView();
                ClearInputs();
                MessageBox.Show("Cập nhật lớp học thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật lớp học: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── XÓA lớp học ──────────────────────────────────────────────────────
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string malop = txt_malh.Text.Trim();
            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa lớp '{malop}'?\n(Các sinh viên thuộc lớp này sẽ bị mất liên kết)",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (QLSVDataContext db = new QLSVDataContext())
                    {
                        var lop = db.tbl_lops.FirstOrDefault(l => l.malop.Trim() == malop);
                        if (lop != null)
                        {
                            db.tbl_lops.DeleteOnSubmit(lop);
                            db.SubmitChanges();
                        }
                    }

                    LoadDataGridView();
                    ClearInputs();
                    MessageBox.Show("Xóa lớp học thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("FOREIGN KEY") || ex.Message.Contains("REFERENCE"))
                        MessageBox.Show(
                            $"Không thể xóa lớp '{malop}' vì còn sinh viên đang thuộc lớp này!\n" +
                            "Hãy chuyển hoặc xóa các sinh viên đó trước.",
                            "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Lỗi khi xóa lớp học: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ─── LÀM MỚI ─────────────────────────────────────────────────────────
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();   // tải lại toàn bộ dữ liệu
            dataGridView.ClearSelection();
            ClearInputs();
        }

        // ─── TÌM KIẾM (dùng DataSource, không dùng Rows.Add trộn lẫn) ───────
        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim().ToLower();

            // Nếu ô tìm kiếm trống → load lại toàn bộ
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadDataGridView();
                return;
            }

            try
            {
                using (QLSVDataContext db = new QLSVDataContext())
                {
                    // Lọc bằng LINQ rồi gán DataSource (hướng dẫn mục 12)
                    var ds = db.tbl_lops
                               .Where(l =>
                                   l.malop.ToLower().Contains(keyword) ||
                                   l.tenlop.ToLower().Contains(keyword) ||
                                   l.tengvcn.ToLower().Contains(keyword))
                               .Select(l => new
                               {
                                   malop = l.malop,
                                   tenlop = l.tenlop,
                                   tengvcn = l.tengvcn,
                                   siso = l.siso.HasValue ? l.siso.Value : 0
                               })
                               .ToList();

                    dataGridView.DataSource = ds;

                    if (ds.Count == 0)
                        MessageBox.Show("Không tìm thấy lớp học phù hợp!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Chuyển sang Form Quản Lý Sinh Viên ──────────────────────────────
        private void llb_qlsv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QLSV f_qlsv = new Form_QLSV();
            f_qlsv.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}