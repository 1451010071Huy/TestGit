﻿namespace RestaurantApp
{
    partial class FrmQuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyHoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.ltvTenSanPham = new System.Windows.Forms.ListBox();
            this.ltvThanhTien = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTienMat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTienTra = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMonAnVaban = new System.Windows.Forms.DataGridView();
            this.cbbMonAnVaBan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAnVaban)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Món Ăn";
            // 
            // ltvTenSanPham
            // 
            this.ltvTenSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltvTenSanPham.FormattingEnabled = true;
            this.ltvTenSanPham.ItemHeight = 16;
            this.ltvTenSanPham.Location = new System.Drawing.Point(16, 54);
            this.ltvTenSanPham.Name = "ltvTenSanPham";
            this.ltvTenSanPham.Size = new System.Drawing.Size(278, 276);
            this.ltvTenSanPham.TabIndex = 1;
            this.ltvTenSanPham.SelectedIndexChanged += new System.EventHandler(this.lsbTenSanPham_SelectedIndexChanged);
            // 
            // ltvThanhTien
            // 
            this.ltvThanhTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltvThanhTien.FormattingEnabled = true;
            this.ltvThanhTien.ItemHeight = 16;
            this.ltvThanhTien.Location = new System.Drawing.Point(300, 54);
            this.ltvThanhTien.Name = "ltvThanhTien";
            this.ltvThanhTien.Size = new System.Drawing.Size(246, 276);
            this.ltvThanhTien.TabIndex = 3;
            this.ltvThanhTien.SelectedIndexChanged += new System.EventHandler(this.lsbThanhTien_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thành Tiền";
            // 
            // nudTongTien
            // 
            this.nudTongTien.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTongTien.Location = new System.Drawing.Point(121, 356);
            this.nudTongTien.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.ReadOnly = true;
            this.nudTongTien.Size = new System.Drawing.Size(173, 23);
            this.nudTongTien.TabIndex = 9;
            this.nudTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTongTien.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng Tiền";
            // 
            // nudTienMat
            // 
            this.nudTienMat.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTienMat.Location = new System.Drawing.Point(121, 397);
            this.nudTienMat.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudTienMat.Name = "nudTienMat";
            this.nudTienMat.Size = new System.Drawing.Size(173, 23);
            this.nudTienMat.TabIndex = 11;
            this.nudTienMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTienMat.ThousandsSeparator = true;
            this.nudTienMat.ValueChanged += new System.EventHandler(this.nudTienMat_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tiền Mặt";
            // 
            // nudTienTra
            // 
            this.nudTienTra.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTienTra.Location = new System.Drawing.Point(121, 438);
            this.nudTienTra.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudTienTra.Name = "nudTienTra";
            this.nudTienTra.ReadOnly = true;
            this.nudTienTra.Size = new System.Drawing.Size(173, 23);
            this.nudTienTra.TabIndex = 13;
            this.nudTienTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTienTra.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tiền Trả";
            // 
            // dgvMonAnVaban
            // 
            this.dgvMonAnVaban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonAnVaban.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMonAnVaban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonAnVaban.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMonAnVaban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAnVaban.Location = new System.Drawing.Point(552, 54);
            this.dgvMonAnVaban.Name = "dgvMonAnVaban";
            this.dgvMonAnVaban.Size = new System.Drawing.Size(442, 276);
            this.dgvMonAnVaban.TabIndex = 17;
            // 
            // cbbMonAnVaBan
            // 
            this.cbbMonAnVaBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMonAnVaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonAnVaBan.FormattingEnabled = true;
            this.cbbMonAnVaBan.Location = new System.Drawing.Point(710, 388);
            this.cbbMonAnVaBan.Name = "cbbMonAnVaBan";
            this.cbbMonAnVaBan.Size = new System.Drawing.Size(121, 24);
            this.cbbMonAnVaBan.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mã bàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Danh sách món";
            // 
            // btnChon
            // 
            this.btnChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChon.Image = global::RestaurantApp.Properties.Resources.arrows;
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(837, 379);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(117, 33);
            this.btnChon.TabIndex = 19;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInHoaDon.Image = global::RestaurantApp.Properties.Resources.technology;
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(395, 428);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(117, 33);
            this.btnInHoaDon.TabIndex = 16;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Image = global::RestaurantApp.Properties.Resources._002_delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(395, 387);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 33);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Image = global::RestaurantApp.Properties.Resources._003_signs;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(395, 346);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 33);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(998, 476);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cbbMonAnVaBan);
            this.Controls.Add(this.dgvMonAnVaban);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.nudTienTra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudTienMat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ltvThanhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltvTenSanPham);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuanLyHoaDon";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý in hóa đơn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAnVaban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ltvTenSanPham;
        private System.Windows.Forms.ListBox ltvThanhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTienMat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudTienTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.DataGridView dgvMonAnVaban;
        private System.Windows.Forms.ComboBox cbbMonAnVaBan;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}

