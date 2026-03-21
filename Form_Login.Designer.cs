namespace QLSV
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cb_remember = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_title.Location = new System.Drawing.Point(230, 30);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(280, 54);
            this.lb_title.TabIndex = 5;
            this.lb_title.Text = "ĐĂNG NHẬP";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(80, 140);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(148, 28);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Tên đăng nhập";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(80, 210);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(98, 28);
            this.lb_password.TabIndex = 0;
            this.lb_password.Text = "Mật khẩu";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(250, 137);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(430, 34);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "manhNV";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(250, 207);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(430, 34);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "0018168";
            // 
            // cb_remember
            // 
            this.cb_remember.AutoSize = true;
            this.cb_remember.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_remember.Location = new System.Drawing.Point(250, 260);
            this.cb_remember.Name = "cb_remember";
            this.cb_remember.Size = new System.Drawing.Size(155, 29);
            this.cb_remember.TabIndex = 2;
            this.cb_remember.Text = "Nhớ mật khẩu";
            this.cb_remember.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(250, 320);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(180, 50);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Đăng Nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(460, 320);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(180, 50);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Đăng Ký";
            this.btn_register.UseVisualStyleBackColor = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.cb_remember);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Hệ Thống";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.CheckBox cb_remember;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
    }
}

