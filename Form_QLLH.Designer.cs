namespace QLSV
{
    partial class Form_QLLH
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
            this.txt_phonghoc = new System.Windows.Forms.TextBox();
            this.txt_siso = new System.Windows.Forms.TextBox();
            this.txt_gvcn = new System.Windows.Forms.TextBox();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.txt_malh = new System.Windows.Forms.TextBox();
            this.lb_phonghoc = new System.Windows.Forms.Label();
            this.lb_siso = new System.Windows.Forms.Label();
            this.lb_gvcn = new System.Windows.Forms.Label();
            this.lb_tenlop = new System.Windows.Forms.Label();
            this.lb_malh = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.llb_qlsv = new System.Windows.Forms.LinkLabel();
            this.lvLopHoc = new System.Windows.Forms.ListView();
            this.colMaLH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGVCN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSiSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhongHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.splitContainer1.Panel1.Controls.Add(this.txt_phonghoc);
            this.splitContainer1.Panel1.Controls.Add(this.txt_siso);
            this.splitContainer1.Panel1.Controls.Add(this.txt_gvcn);
            this.splitContainer1.Panel1.Controls.Add(this.txt_tenlop);
            this.splitContainer1.Panel1.Controls.Add(this.txt_malh);
            this.splitContainer1.Panel1.Controls.Add(this.lb_phonghoc);
            this.splitContainer1.Panel1.Controls.Add(this.lb_siso);
            this.splitContainer1.Panel1.Controls.Add(this.lb_gvcn);
            this.splitContainer1.Panel1.Controls.Add(this.lb_tenlop);
            this.splitContainer1.Panel1.Controls.Add(this.lb_malh);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lb_search);
            this.splitContainer1.Panel2.Controls.Add(this.txt_search);
            this.splitContainer1.Panel2.Controls.Add(this.btn_search);
            this.splitContainer1.Panel2.Controls.Add(this.llb_qlsv);
            this.splitContainer1.Panel2.Controls.Add(this.lvLopHoc);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 700);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 0;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_title.Location = new System.Drawing.Point(60, 15);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(270, 37);
            this.lb_title.TabIndex = 10;
            this.lb_title.Text = "Quan Ly Lop Hoc";
            // 
            // lb_malh
            // 
            this.lb_malh.AutoSize = true;
            this.lb_malh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_malh.Location = new System.Drawing.Point(20, 75);
            this.lb_malh.Name = "lb_malh";
            this.lb_malh.Size = new System.Drawing.Size(90, 26);
            this.lb_malh.TabIndex = 0;
            this.lb_malh.Text = "Ma Lop";
            // 
            // txt_malh
            // 
            this.txt_malh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_malh.Location = new System.Drawing.Point(24, 104);
            this.txt_malh.Name = "txt_malh";
            this.txt_malh.Size = new System.Drawing.Size(320, 32);
            this.txt_malh.TabIndex = 1;
            // 
            // lb_tenlop
            // 
            this.lb_tenlop.AutoSize = true;
            this.lb_tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_tenlop.Location = new System.Drawing.Point(20, 150);
            this.lb_tenlop.Name = "lb_tenlop";
            this.lb_tenlop.Size = new System.Drawing.Size(93, 26);
            this.lb_tenlop.TabIndex = 0;
            this.lb_tenlop.Text = "Ten Lop";
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_tenlop.Location = new System.Drawing.Point(24, 179);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(320, 32);
            this.txt_tenlop.TabIndex = 2;
            // 
            // lb_gvcn
            // 
            this.lb_gvcn.AutoSize = true;
            this.lb_gvcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_gvcn.Location = new System.Drawing.Point(20, 225);
            this.lb_gvcn.Name = "lb_gvcn";
            this.lb_gvcn.Size = new System.Drawing.Size(76, 26);
            this.lb_gvcn.TabIndex = 0;
            this.lb_gvcn.Text = "GVCN";
            // 
            // txt_gvcn
            // 
            this.txt_gvcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_gvcn.Location = new System.Drawing.Point(24, 254);
            this.txt_gvcn.Name = "txt_gvcn";
            this.txt_gvcn.Size = new System.Drawing.Size(320, 32);
            this.txt_gvcn.TabIndex = 3;
            // 
            // lb_siso
            // 
            this.lb_siso.AutoSize = true;
            this.lb_siso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_siso.Location = new System.Drawing.Point(20, 300);
            this.lb_siso.Name = "lb_siso";
            this.lb_siso.Size = new System.Drawing.Size(74, 26);
            this.lb_siso.TabIndex = 0;
            this.lb_siso.Text = "Si So";
            // 
            // txt_siso
            // 
            this.txt_siso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_siso.Location = new System.Drawing.Point(24, 329);
            this.txt_siso.Name = "txt_siso";
            this.txt_siso.Size = new System.Drawing.Size(320, 32);
            this.txt_siso.TabIndex = 4;
            // 
            // lb_phonghoc
            // 
            this.lb_phonghoc.AutoSize = true;
            this.lb_phonghoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_phonghoc.Location = new System.Drawing.Point(20, 375);
            this.lb_phonghoc.Name = "lb_phonghoc";
            this.lb_phonghoc.Size = new System.Drawing.Size(112, 26);
            this.lb_phonghoc.TabIndex = 0;
            this.lb_phonghoc.Text = "Phong Hoc";
            // 
            // txt_phonghoc
            // 
            this.txt_phonghoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_phonghoc.Location = new System.Drawing.Point(24, 404);
            this.txt_phonghoc.Name = "txt_phonghoc";
            this.txt_phonghoc.Size = new System.Drawing.Size(320, 32);
            this.txt_phonghoc.TabIndex = 5;
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
            this.btn_add.Text = "Them";
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
            this.btn_edit.Text = "Sua";
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
            this.btn_delete.Text = "Xoa";
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
            this.btn_detail.Text = "Chi Tiet";
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
            this.lb_search.Text = "Tim kiem";
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
            this.btn_search.Text = "Tim";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lvLopHoc
            // 
            this.lvLopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLopHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaLH,
            this.colTenLop,
            this.colGVCN,
            this.colSiSo,
            this.colPhongHoc});
            this.lvLopHoc.FullRowSelect = true;
            this.lvLopHoc.GridLines = true;
            this.lvLopHoc.HideSelection = false;
            this.lvLopHoc.Location = new System.Drawing.Point(20, 55);
            this.lvLopHoc.Name = "lvLopHoc";
            this.lvLopHoc.Size = new System.Drawing.Size(700, 580);
            this.lvLopHoc.TabIndex = 0;
            this.lvLopHoc.UseCompatibleStateImageBehavior = false;
            this.lvLopHoc.View = System.Windows.Forms.View.Details;
            this.lvLopHoc.SelectedIndexChanged += new System.EventHandler(this.lvLopHoc_SelectedIndexChanged);
            // 
            // colMaLH
            // 
            this.colMaLH.Text = "Ma Lop";
            this.colMaLH.Width = 100;
            // 
            // colTenLop
            // 
            this.colTenLop.Text = "Ten Lop";
            this.colTenLop.Width = 180;
            // 
            // colGVCN
            // 
            this.colGVCN.Text = "GVCN";
            this.colGVCN.Width = 160;
            // 
            // colSiSo
            // 
            this.colSiSo.Text = "Si So";
            this.colSiSo.Width = 80;
            // 
            // colPhongHoc
            // 
            this.colPhongHoc.Text = "Phong Hoc";
            this.colPhongHoc.Width = 120;
            // 
            // llb_qlsv
            // 
            this.llb_qlsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llb_qlsv.AutoSize = true;
            this.llb_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_qlsv.Location = new System.Drawing.Point(250, 650);
            this.llb_qlsv.Name = "llb_qlsv";
            this.llb_qlsv.Size = new System.Drawing.Size(209, 29);
            this.llb_qlsv.TabIndex = 1;
            this.llb_qlsv.TabStop = true;
            this.llb_qlsv.Text = ">> Quan Ly Sinh Vien";
            this.llb_qlsv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_qlsv_LinkClicked);
            // 
            // Form_QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_QLLH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Lop Hoc";
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
        private System.Windows.Forms.Label lb_malh;
        private System.Windows.Forms.Label lb_tenlop;
        private System.Windows.Forms.Label lb_gvcn;
        private System.Windows.Forms.Label lb_siso;
        private System.Windows.Forms.Label lb_phonghoc;
        private System.Windows.Forms.TextBox txt_malh;
        private System.Windows.Forms.TextBox txt_tenlop;
        private System.Windows.Forms.TextBox txt_gvcn;
        private System.Windows.Forms.TextBox txt_siso;
        private System.Windows.Forms.TextBox txt_phonghoc;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ListView lvLopHoc;
        private System.Windows.Forms.ColumnHeader colMaLH;
        private System.Windows.Forms.ColumnHeader colTenLop;
        private System.Windows.Forms.ColumnHeader colGVCN;
        private System.Windows.Forms.ColumnHeader colSiSo;
        private System.Windows.Forms.ColumnHeader colPhongHoc;
        private System.Windows.Forms.LinkLabel llb_qlsv;
    }
}