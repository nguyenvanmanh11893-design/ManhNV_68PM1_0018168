using System;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (QLSVDataContext db = new QLSVDataContext())
                {
                    // Kiểm tra tài khoản trong bảng tbl_taikhoan
                    var taikhoan = db.tbl_taikhoans.FirstOrDefault(tk =>
                        tk.ten_dang_nhap.Trim() == username &&
                        tk.mat_khau.Trim() == password
                    );

                    if (taikhoan != null)
                    {
                        Form_QLSV f_qlsv = new Form_QLSV();
                        f_qlsv.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_password.Clear();
                        txt_username.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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