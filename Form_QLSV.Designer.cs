namespace QLSV
{
    partial class Form_QLSV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_detail = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.lb_lop = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.lb_hoten = new System.Windows.Forms.Label();
            this.lb_mssv = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.llb_QLLH = new System.Windows.Forms.LinkLabel();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lb_search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lb_title);
            this.splitContainer1.Panel1.Controls.Add(this.btn_detail);
            this.splitContainer1.Panel1.Controls.Add(this.btn_edit);
            this.splitContainer1.Panel1.Controls.Add(this.btn_delete);
            this.splitContainer1.Panel1.Controls.Add(this.btn_add);
            this.splitContainer1.Panel1.Controls.Add(this.txt_lop);
            this.splitContainer1.Panel1.Controls.Add(this.txt_ngaysinh);
            this.splitContainer1.Panel1.Controls.Add(this.txt_gioitinh);
            this.splitContainer1.Panel1.Controls.Add(this.txt_hoten);
            this.splitContainer1.Panel1.Controls.Add(this.txt_mssv);
            this.splitContainer1.Panel1.Controls.Add(this.lb_lop);
            this.splitContainer1.Panel1.Controls.Add(this.lb_ngaysinh);
            this.splitContainer1.Panel1.Controls.Add(this.lb_gioitinh);
            this.splitContainer1.Panel1.Controls.Add(this.lb_hoten);
            this.splitContainer1.Panel1.Controls.Add(this.lb_mssv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lb_search);
            this.splitContainer1.Panel2.Controls.Add(this.txt_search);
            this.splitContainer1.Panel2.Controls.Add(this.btn_search);
            this.splitContainer1.Panel2.Controls.Add(this.llb_QLLH);
            this.splitContainer1.Panel2.Controls.Add(this.lvSinhVien);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 700);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 0;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_title.Location = new System.Drawing.Point(50, 15);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(290, 37);
            this.lb_title.TabIndex = 10;
            this.lb_title.Text = "Quản Lý Sinh Viên";
            // 
            // lb_mssv
            // 
            this.lb_mssv.AutoSize = true;
            this.lb_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_mssv.Location = new System.Drawing.Point(20, 75);
            this.lb_mssv.Name = "lb_mssv";
            this.lb_mssv.Size = new System.Drawing.Size(71, 26);
            this.lb_mssv.TabIndex = 0;
            this.lb_mssv.Text = "MSSV";
            // 
            // txt_mssv
            // 
            this.txt_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_mssv.Location = new System.Drawing.Point(24, 104);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(320, 32);
            this.txt_mssv.TabIndex = 1;
            // 
            // lb_hoten
            // 
            this.lb_hoten.AutoSize = true;
            this.lb_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_hoten.Location = new System.Drawing.Point(20, 150);
            this.lb_hoten.Name = "lb_hoten";
            this.lb_hoten.Size = new System.Drawing.Size(82, 26);
            this.lb_hoten.TabIndex = 0;
            this.lb_hoten.Text = "Họ Tên";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_hoten.Location = new System.Drawing.Point(24, 179);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(320, 32);
            this.txt_hoten.TabIndex = 2;
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_gioitinh.Location = new System.Drawing.Point(20, 225);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(98, 26);
            this.lb_gioitinh.TabIndex = 0;
            this.lb_gioitinh.Text = "Giới Tính";
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_gioitinh.Location = new System.Drawing.Point(24, 254);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(320, 32);
            this.txt_gioitinh.TabIndex = 3;
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_ngaysinh.Location = new System.Drawing.Point(20, 300);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(109, 26);
            this.lb_ngaysinh.TabIndex = 0;
            this.lb_ngaysinh.Text = "Ngày Sinh";
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_ngaysinh.Location = new System.Drawing.Point(24, 329);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(320, 32);
            this.txt_ngaysinh.TabIndex = 4;
            // 
            // lb_lop
            // 
            this.lb_lop.AutoSize = true;
            this.lb_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_lop.Location = new System.Drawing.Point(20, 375);
            this.lb_lop.Name = "lb_lop";
            this.lb_lop.Size = new System.Drawing.Size(47, 26);
            this.lb_lop.TabIndex = 0;
            this.lb_lop.Text = "Lớp";
            // 
            // txt_lop
            // 
            this.txt_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_lop.Location = new System.Drawing.Point(24, 404);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(320, 32);
            this.txt_lop.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(24, 470);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(150, 45);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(194, 470);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(150, 45);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(24, 530);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 45);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_detail
            // 
            this.btn_detail.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btn_detail.ForeColor = System.Drawing.Color.White;
            this.btn_detail.Location = new System.Drawing.Point(194, 530);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(150, 45);
            this.btn_detail.TabIndex = 9;
            this.btn_detail.Text = "Chi Tiết";
            this.btn_detail.UseVisualStyleBackColor = false;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_search.Location = new System.Drawing.Point(20, 15);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(96, 26);
            this.lb_search.TabIndex = 5;
            this.lb_search.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_search.Location = new System.Drawing.Point(122, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(430, 32);
            this.txt_search.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_search.Location = new System.Drawing.Point(565, 10);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 36);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMSSV,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colLop});
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(20, 55);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(700, 580);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MSSV";
            this.colMSSV.Width = 100;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 180;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới Tính";
            this.colGioiTinh.Width = 100;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày Sinh";
            this.colNgaySinh.Width = 130;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 120;
            // 
            // llb_QLLH
            // 
            this.llb_QLLH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llb_QLLH.AutoSize = true;
            this.llb_QLLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_QLLH.Location = new System.Drawing.Point(250, 650);
            this.llb_QLLH.Name = "llb_QLLH";
            this.llb_QLLH.Size = new System.Drawing.Size(197, 29);
            this.llb_QLLH.TabIndex = 1;
            this.llb_QLLH.TabStop = true;
            this.llb_QLLH.Text = ">> Quản Lý Lớp Học";
            this.llb_QLLH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_QLLH_LinkClicked);
            // 
            // Form_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_QLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_mssv;
        private System.Windows.Forms.Label lb_hoten;
        private System.Windows.Forms.Label lb_gioitinh;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.Label lb_lop;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.TextBox txt_ngaysinh;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colMSSV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.LinkLabel llb_QLLH;
    }
}