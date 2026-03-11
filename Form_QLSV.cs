using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form_QLSV : Form
    {
        private List<SinhVien> dsSinhVien = new List<SinhVien>();

        public Form_QLSV()
        {
            InitializeComponent();
            LoadSampleData();
            LoadListView(dsSinhVien);
        }

        private void LoadSampleData()
        {
            dsSinhVien.Add(new SinhVien("SV001", "Nguyễn Văn An", "Nam", "01/01/2000", "68PM1"));
            dsSinhVien.Add(new SinhVien("SV002", "Trần Thị Binh", "Nữ", "15/03/2001", "68PM1"));
            dsSinhVien.Add(new SinhVien("SV003", "Lê Văn Cuong", "Nam", "20/07/2000", "68PM2"));
            dsSinhVien.Add(new SinhVien("SV004", "Phạm Thị Duyen", "Nữ", "10/11/1999", "68PM1"));
            dsSinhVien.Add(new SinhVien("SV005", "Hoàng Văn hung", "Nam", "05/05/2001", "68PM4"));
        }

        private void LoadListView(List<SinhVien> list)
        {
            lvSinhVien.Items.Clear();
            foreach (var sv in list)
            {
                ListViewItem item = new ListViewItem(sv.MSSV);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.GioiTinh);
                item.SubItems.Add(sv.NgaySinh);
                item.SubItems.Add(sv.Lop);
                item.Tag = sv;
                lvSinhVien.Items.Add(item);
            }
        }

        private void ClearInputs()
        {
            txt_mssv.Text = "";
            txt_hoten.Text = "";
            txt_gioitinh.Text = "";
            txt_ngaysinh.Text = "";
            txt_lop.Text = "";
            txt_mssv.Focus();
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                SinhVien sv = (SinhVien)lvSinhVien.SelectedItems[0].Tag;
                txt_mssv.Text = sv.MSSV;
                txt_hoten.Text = sv.HoTen;
                txt_gioitinh.Text = sv.GioiTinh;
                txt_ngaysinh.Text = sv.NgaySinh;
                txt_lop.Text = sv.Lop;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mssv.Text) || string.IsNullOrWhiteSpace(txt_hoten.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ MSSV và Họ Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dsSinhVien.Any(s => s.MSSV == txt_mssv.Text.Trim()))
            {
                MessageBox.Show("MSSV đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SinhVien sv = new SinhVien(
                txt_mssv.Text.Trim(),
                txt_hoten.Text.Trim(),
                txt_gioitinh.Text.Trim(),
                txt_ngaysinh.Text.Trim(),
                txt_lop.Text.Trim()
            );
            dsSinhVien.Add(sv);
            LoadListView(dsSinhVien);
            ClearInputs();
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SinhVien sv = (SinhVien)lvSinhVien.SelectedItems[0].Tag;
            sv.HoTen = txt_hoten.Text.Trim();
            sv.GioiTinh = txt_gioitinh.Text.Trim();
            sv.NgaySinh = txt_ngaysinh.Text.Trim();
            sv.Lop = txt_lop.Text.Trim();

            LoadListView(dsSinhVien);
            ClearInputs();
            MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SinhVien sv = (SinhVien)lvSinhVien.SelectedItems[0].Tag;
                dsSinhVien.Remove(sv);
                LoadListView(dsSinhVien);
                ClearInputs();
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SinhVien sv = (SinhVien)lvSinhVien.SelectedItems[0].Tag;
            string detail = $"===== CHI TIẾT SINH VIÊN =====\n" +
                            $"MSSV: {sv.MSSV}\n" +
                            $"Họ Tên: {sv.HoTen}\n" +
                            $"Giới Tính: {sv.GioiTinh}\n" +
                            $"Ngày Sinh: {sv.NgaySinh}\n" +
                            $"Lớp: {sv.Lop}";
            MessageBox.Show(detail, "Chi Tiết Sinh Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadListView(dsSinhVien);
                return;
            }

            var result = dsSinhVien.Where(s =>
                s.MSSV.ToLower().Contains(keyword) ||
                s.HoTen.ToLower().Contains(keyword) ||
                s.Lop.ToLower().Contains(keyword)
            ).ToList();

            LoadListView(result);

            if (result.Count == 0)
                MessageBox.Show("Không tìm thấy sinh viên phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llb_QLLH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QLLH f_qllh = new Form_QLLH();
            f_qllh.Show();
            this.Close();
        }
    }

    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string Lop { get; set; }

        public SinhVien(string mssv, string hoTen, string gioiTinh, string ngaySinh, string lop)
        {
            MSSV = mssv;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Lop = lop;
        }
    }
}
