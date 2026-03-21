using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form_QLSV : Form
    {
        // Danh sách lớp dùng để validate khi thêm/sửa sinh viên
        private List<string> dsMaLop = new List<string>();

        public Form_QLSV()
        {
            InitializeComponent();

            // ── Bước 1: Tắt AutoGenerateColumns vì Designer đã định nghĩa cột sẵn ──
            dataGridView1.AutoGenerateColumns = false;

            // ── Bước 2: Gán DataPropertyName cho từng cột khớp với tên property ──
            colMSSV.DataPropertyName = "id";
            colHoTen.DataPropertyName = "hoten";
            colGioitinh.DataPropertyName = "gioitinh";
            colNgaySinh.DataPropertyName = "ngaysinh";
            colLop.DataPropertyName = "malop";

            // ── Bước 3: Thiết lập các thuộc tính quan trọng ban đầu ──
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false; // Ẩn cột Row Header thừa bên trái

            // ── Bước 4: Bắt sự kiện CellClick (hướng dẫn mục 8) ──
            dataGridView1.CellClick += dataGridView1_CellClick;

            LoadDsMaLop();
            LoadDataGridView();
        }

        // ─── Load danh sách mã lớp để validate ───────────────────────────────
        private void LoadDsMaLop()
        {
            try
            {
                using (QLSVDataContext db = new QLSVDataContext())
                {
                    dsMaLop = db.tbl_lops.Select(l => l.malop.Trim()).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Load toàn bộ sinh viên lên DataGridView (hướng dẫn mục 5.2) ────
        private void LoadDataGridView()
        {
            try
            {
                using (QLSVDataContext db = new QLSVDataContext())
                {
                    var ds = db.tbl_sinhviens
                               .Select(sv => new
                               {
                                   id = sv.id,
                                   hoten = sv.hoten,
                                   gioitinh = sv.gioitinh,
                                   ngaysinh = sv.ngaysinh,
                                   malop = sv.malop
                               })
                               .ToList();

                    dataGridView1.DataSource = ds;
                }

                // Tùy chỉnh cột sau khi bind (hướng dẫn mục 7)
                dataGridView1.Columns["colNgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu sinh viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Xóa trắng các ô nhập liệu ───────────────────────────────────────
        private void ClearInputs()
        {
            txt_mssv.Text = "";
            txt_hoten.Text = "";
            txt_gioitinh.Text = "";
            txt_ngaysinh.Text = "";
            txt_lop.Text = "";
            txt_mssv.ReadOnly = false;
            txt_mssv.Focus();
        }

        // ─── CellClick vào dòng → điền vào ô nhập liệu (hướng dẫn mục 8) ────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua khi click vào header (RowIndex = -1)
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            txt_mssv.Text = row.Cells["colMSSV"].Value?.ToString();
            txt_hoten.Text = row.Cells["colHoTen"].Value?.ToString();
            txt_gioitinh.Text = row.Cells["colGioitinh"].Value?.ToString();

            // Ngày sinh: lấy từ Value kiểu DateTime rồi định dạng dd/MM/yyyy
            if (row.Cells["colNgaySinh"].Value != null &&
                row.Cells["colNgaySinh"].Value != DBNull.Value)
            {
                DateTime dt = Convert.ToDateTime(row.Cells["colNgaySinh"].Value);
                txt_ngaysinh.Text = dt.ToString("dd/MM/yyyy");
            }
            else
            {
                txt_ngaysinh.Text = "";
            }

            txt_lop.Text = row.Cells["colLop"].Value?.ToString();
            txt_mssv.ReadOnly = true;   // không cho sửa MSSV khi đã chọn
        }

        // ─── THÊM sinh viên ───────────────────────────────────────────────────
        private void btn_add_Click(object sender, EventArgs e)
        {
            string mssv = txt_mssv.Text.Trim();
            string hoten = txt_hoten.Text.Trim();
            string gioitinh = txt_gioitinh.Text.Trim();
            string ngaySinhStr = txt_ngaysinh.Text.Trim();
            string malop = txt_lop.Text.Trim();

            if (string.IsNullOrWhiteSpace(mssv) || string.IsNullOrWhiteSpace(hoten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ MSSV và Họ Tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate ngày sinh
            DateTime? ngaySinh = null;
            if (!string.IsNullOrWhiteSpace(ngaySinhStr))
            {
                if (!DateTime.TryParseExact(ngaySinhStr, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime dt))
                {
                    MessageBox.Show("Ngày sinh không đúng định dạng dd/MM/yyyy!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ngaySinh = dt;
            }

            // Validate mã lớp
            if (!string.IsNullOrWhiteSpace(malop) && !dsMaLop.Contains(malop))
            {
                MessageBox.Show($"Mã lớp '{malop}' không tồn tại trong hệ thống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (QLSVDataContext db = new QLSVDataContext())
                {
                    if (db.tbl_sinhviens.Any(s => s.id.Trim() == mssv))
                    {
                        MessageBox.Show("MSSV đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    tbl_sinhvien sv = new tbl_sinhvien
                    {
                        id = mssv,
                        hoten = hoten,
                        gioitinh = gioitinh,
                        ngaysinh = ngaySinh,
                        malop = string.IsNullOrWhiteSpace(malop) ? null : malop
                    };

                    db.tbl_sinhviens.InsertOnSubmit(sv);
                    db.SubmitChanges();
                }

                // Cập nhật sĩ số lớp sau khi thêm sinh viên
                if (!string.IsNullOrWhiteSpace(malop))
                    Form_QLLH.UpdateSiSo(malop);

                LoadDataGridView();
                ClearInputs();
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── SỬA sinh viên ────────────────────────────────────────────────────
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mssv = txt_mssv.Text.Trim();
            string hoten = txt_hoten.Text.Trim();
            string gioitinh = txt_gioitinh.Text.Trim();
            string ngaySinhStr = txt_ngaysinh.Text.Trim();
            string malop = txt_lop.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoten))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate ngày sinh
            DateTime? ngaySinh = null;
            if (!string.IsNullOrWhiteSpace(ngaySinhStr))
            {
                if (!DateTime.TryParseExact(ngaySinhStr, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime dt))
                {
                    MessageBox.Show("Ngày sinh không đúng định dạng dd/MM/yyyy!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ngaySinh = dt;
            }

            // Validate mã lớp
            if (!string.IsNullOrWhiteSpace(malop) && !dsMaLop.Contains(malop))
            {
                MessageBox.Show($"Mã lớp '{malop}' không tồn tại trong hệ thống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy mã lớp cũ từ DataGridView trước khi cập nhật (để update sĩ số)
                string malopCu = dataGridView1.CurrentRow.Cells["colLop"].Value?.ToString()?.Trim();

                using (QLSVDataContext db = new QLSVDataContext())
                {
                    var sv = db.tbl_sinhviens.FirstOrDefault(s => s.id.Trim() == mssv);
                    if (sv == null)
                    {
                        MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    sv.hoten = hoten;
                    sv.gioitinh = gioitinh;
                    sv.ngaysinh = ngaySinh;
                    sv.malop = string.IsNullOrWhiteSpace(malop) ? null : malop;

                    db.SubmitChanges();
                }

                // Cập nhật sĩ số: lớp cũ và lớp mới (nếu đổi lớp)
                if (!string.IsNullOrWhiteSpace(malopCu))
                    Form_QLLH.UpdateSiSo(malopCu);
                if (!string.IsNullOrWhiteSpace(malop) && malop != malopCu)
                    Form_QLLH.UpdateSiSo(malop);

                LoadDataGridView();
                ClearInputs();
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sinh viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── XÓA sinh viên ────────────────────────────────────────────────────
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mssv = txt_mssv.Text.Trim();

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sinh viên '{mssv}'?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (QLSVDataContext db = new QLSVDataContext())
                    {
                        var sv = db.tbl_sinhviens.FirstOrDefault(s => s.id.Trim() == mssv);
                        if (sv != null)
                        {
                            string malopXoa = sv.malop?.Trim();
                            db.tbl_sinhviens.DeleteOnSubmit(sv);
                            db.SubmitChanges();

                            // Cập nhật sĩ số sau khi xóa
                            if (!string.IsNullOrWhiteSpace(malopXoa))
                                Form_QLLH.UpdateSiSo(malopXoa);
                        }
                    }

                    LoadDataGridView();
                    ClearInputs();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ─── LÀM MỚI ─────────────────────────────────────────────────────────
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();   // tải lại toàn bộ dữ liệu
            dataGridView1.ClearSelection();
            ClearInputs();
        }

        // ─── TÌM KIẾM (dùng DataSource theo hướng dẫn mục 12) ───────────────
        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim().ToLower();

            // Nếu ô trống → load lại toàn bộ
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadDataGridView();
                return;
            }

            try
            {
                using (QLSVDataContext db = new QLSVDataContext())
                {
                    var ds = db.tbl_sinhviens
                               .Where(sv =>
                                   sv.id.ToLower().Contains(keyword) ||
                                   sv.hoten.ToLower().Contains(keyword) ||
                                   (sv.malop != null && sv.malop.ToLower().Contains(keyword)))
                               .Select(sv => new
                               {
                                   id = sv.id,
                                   hoten = sv.hoten,
                                   gioitinh = sv.gioitinh,
                                   ngaysinh = sv.ngaysinh,
                                   malop = sv.malop
                               })
                               .ToList();

                    // Gán lại DataSource — DataGridView tự cập nhật (không dùng Rows.Add)
                    dataGridView1.DataSource = ds;

                    if (ds.Count == 0)
                        MessageBox.Show("Không tìm thấy sinh viên phù hợp!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Chuyển sang Form Quản Lý Lớp Học ───────────────────────────────
        private void llb_QLLH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QLLH f_qllh = new Form_QLLH();
            f_qllh.Show();
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
    }
}