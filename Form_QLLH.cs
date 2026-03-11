using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form_QLLH : Form
    {
        private List<LopHoc> dsLopHoc = new List<LopHoc>();

        public Form_QLLH()
        {
            InitializeComponent();
            LoadSampleData();
            LoadListView(dsLopHoc);
        }

        private void LoadSampleData()
        {
            dsLopHoc.Add(new LopHoc("PM1", "Phan mem 1", "Nguyen Van cuong", "40", "PM1"));
            dsLopHoc.Add(new LopHoc("PM2", "Phan mem 2", "Tran Thi Yen", "38", "PM2"));
            dsLopHoc.Add(new LopHoc("PM3", "Phan mem 4", "Le Van Cao", "42", "PM3"));
            dsLopHoc.Add(new LopHoc("PM2", "Phan mem 2", "Tran Thi En", "38", "PM2"));
            dsLopHoc.Add(new LopHoc("PM4", "Phan mem 3", "Hoang Van Nam", "45", "PM4"));
        }

        private void LoadListView(List<LopHoc> list)
        {
            lvLopHoc.Items.Clear();
            foreach (var lh in list)
            {
                ListViewItem item = new ListViewItem(lh.MaLop);
                item.SubItems.Add(lh.TenLop);
                item.SubItems.Add(lh.GVCN);
                item.SubItems.Add(lh.SiSo);
                item.SubItems.Add(lh.PhongHoc);
                item.Tag = lh;
                lvLopHoc.Items.Add(item);
            }
        }

        private void ClearInputs()
        {
            txt_malh.Text = "";
            txt_tenlop.Text = "";
            txt_gvcn.Text = "";
            txt_siso.Text = "";
            txt_phonghoc.Text = "";
            txt_malh.Focus();
        }

        private void lvLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLopHoc.SelectedItems.Count > 0)
            {
                LopHoc lh = (LopHoc)lvLopHoc.SelectedItems[0].Tag;
                txt_malh.Text = lh.MaLop;
                txt_tenlop.Text = lh.TenLop;
                txt_gvcn.Text = lh.GVCN;
                txt_siso.Text = lh.SiSo;
                txt_phonghoc.Text = lh.PhongHoc;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_malh.Text) || string.IsNullOrWhiteSpace(txt_tenlop.Text))
            {
                MessageBox.Show("Vui long nhap day du Ma Lop va Ten Lop!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dsLopHoc.Any(l => l.MaLop == txt_malh.Text.Trim()))
            {
                MessageBox.Show("Ma Lop da ton tai!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LopHoc lh = new LopHoc(
                txt_malh.Text.Trim(),
                txt_tenlop.Text.Trim(),
                txt_gvcn.Text.Trim(),
                txt_siso.Text.Trim(),
                txt_phonghoc.Text.Trim()
            );
            dsLopHoc.Add(lh);
            LoadListView(dsLopHoc);
            ClearInputs();
            MessageBox.Show("Them lop hoc thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lvLopHoc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui long chon lop hoc can sua!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LopHoc lh = (LopHoc)lvLopHoc.SelectedItems[0].Tag;
            lh.TenLop = txt_tenlop.Text.Trim();
            lh.GVCN = txt_gvcn.Text.Trim();
            lh.SiSo = txt_siso.Text.Trim();
            lh.PhongHoc = txt_phonghoc.Text.Trim();

            LoadListView(dsLopHoc);
            ClearInputs();
            MessageBox.Show("Cap nhat lop hoc thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lvLopHoc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui long chon lop hoc can xoa!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Ban co chac chan muon xoa lop hoc nay?", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LopHoc lh = (LopHoc)lvLopHoc.SelectedItems[0].Tag;
                dsLopHoc.Remove(lh);
                LoadListView(dsLopHoc);
                ClearInputs();
                MessageBox.Show("Xoa lop hoc thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            if (lvLopHoc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui long chon lop hoc can xem chi tiet!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LopHoc lh = (LopHoc)lvLopHoc.SelectedItems[0].Tag;
            string detail = "===== CHI TIET LOP HOC =====\n" +
                            "Ma Lop: " + lh.MaLop + "\n" +
                            "Ten Lop: " + lh.TenLop + "\n" +
                            "GVCN: " + lh.GVCN + "\n" +
                            "Si So: " + lh.SiSo + "\n" +
                            "Phong Hoc: " + lh.PhongHoc;
            MessageBox.Show(detail, "Chi Tiet Lop Hoc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadListView(dsLopHoc);
                return;
            }

            var result = dsLopHoc.Where(l =>
                l.MaLop.ToLower().Contains(keyword) ||
                l.TenLop.ToLower().Contains(keyword) ||
                l.GVCN.ToLower().Contains(keyword)
            ).ToList();

            LoadListView(result);

            if (result.Count == 0)
                MessageBox.Show("Khong tim thay lop hoc phu hop!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llb_qlsv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QLSV f_qlsv = new Form_QLSV();
            f_qlsv.Show();
            this.Close();
        }
    }

    public class LopHoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string GVCN { get; set; }
        public string SiSo { get; set; }
        public string PhongHoc { get; set; }

        public LopHoc(string maLop, string tenLop, string gvcn, string siSo, string phongHoc)
        {
            MaLop = maLop;
            TenLop = tenLop;
            GVCN = gvcn;
            SiSo = siSo;
            PhongHoc = phongHoc;
        }
    }
}
