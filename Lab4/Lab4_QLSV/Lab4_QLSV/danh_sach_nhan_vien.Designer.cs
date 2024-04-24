using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Lab4_QLSV
{
    partial class form_danhsachnhanvien
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
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox_thongtinnhanvien = new System.Windows.Forms.GroupBox();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.textBox_luong = new System.Windows.Forms.TextBox();
            this.label_luong = new System.Windows.Forms.Label();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.label_hoten = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_manv = new System.Windows.Forms.TextBox();
            this.label_manv = new System.Windows.Forms.Label();
            this.groupBox_danhsachnhanvien = new System.Windows.Forms.GroupBox();
            this.dataGridView_infor = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_button = new System.Windows.Forms.TableLayoutPanel();
            this.button_them = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_khong = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_ghi_luu = new System.Windows.Forms.Button();
            this.groupBox_thongtinnhanvien.SuspendLayout();
            this.groupBox_danhsachnhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_infor)).BeginInit();
            this.tableLayoutPanel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(262, 12);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(286, 26);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // groupBox_thongtinnhanvien
            // 
            this.groupBox_thongtinnhanvien.Controls.Add(this.textBox_matkhau);
            this.groupBox_thongtinnhanvien.Controls.Add(this.label_matkhau);
            this.groupBox_thongtinnhanvien.Controls.Add(this.textBox_luong);
            this.groupBox_thongtinnhanvien.Controls.Add(this.label_luong);
            this.groupBox_thongtinnhanvien.Controls.Add(this.textBox_hoten);
            this.groupBox_thongtinnhanvien.Controls.Add(this.label_hoten);
            this.groupBox_thongtinnhanvien.Controls.Add(this.textBox_username);
            this.groupBox_thongtinnhanvien.Controls.Add(this.label_username);
            this.groupBox_thongtinnhanvien.Controls.Add(this.textBox_email);
            this.groupBox_thongtinnhanvien.Controls.Add(this.label_email);
            this.groupBox_thongtinnhanvien.Controls.Add(this.textBox_manv);
            this.groupBox_thongtinnhanvien.Controls.Add(this.label_manv);
            this.groupBox_thongtinnhanvien.ForeColor = System.Drawing.Color.Blue;
            this.groupBox_thongtinnhanvien.Location = new System.Drawing.Point(26, 44);
            this.groupBox_thongtinnhanvien.Name = "groupBox_thongtinnhanvien";
            this.groupBox_thongtinnhanvien.Size = new System.Drawing.Size(749, 146);
            this.groupBox_thongtinnhanvien.TabIndex = 1;
            this.groupBox_thongtinnhanvien.TabStop = false;
            this.groupBox_thongtinnhanvien.Text = "Thông tin nhân viên";
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matkhau.Location = new System.Drawing.Point(505, 102);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.Size = new System.Drawing.Size(181, 22);
            this.textBox_matkhau.TabIndex = 14;
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matkhau.ForeColor = System.Drawing.Color.Black;
            this.label_matkhau.Location = new System.Drawing.Point(408, 102);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(79, 21);
            this.label_matkhau.TabIndex = 13;
            this.label_matkhau.Text = "Mật khẩu";
            // 
            // textBox_luong
            // 
            this.textBox_luong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_luong.Location = new System.Drawing.Point(505, 62);
            this.textBox_luong.Name = "textBox_luong";
            this.textBox_luong.Size = new System.Drawing.Size(181, 22);
            this.textBox_luong.TabIndex = 12;
            // 
            // label_luong
            // 
            this.label_luong.AutoSize = true;
            this.label_luong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_luong.ForeColor = System.Drawing.Color.Black;
            this.label_luong.Location = new System.Drawing.Point(408, 62);
            this.label_luong.Name = "label_luong";
            this.label_luong.Size = new System.Drawing.Size(59, 21);
            this.label_luong.TabIndex = 11;
            this.label_luong.Text = "Lương";
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hoten.Location = new System.Drawing.Point(505, 22);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(181, 22);
            this.textBox_hoten.TabIndex = 10;
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hoten.ForeColor = System.Drawing.Color.Black;
            this.label_hoten.Location = new System.Drawing.Point(408, 22);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(60, 21);
            this.label_hoten.TabIndex = 9;
            this.label_hoten.Text = "Họ tên";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(170, 102);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(181, 22);
            this.textBox_username.TabIndex = 8;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.Black;
            this.label_username.Location = new System.Drawing.Point(29, 102);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(121, 21);
            this.label_username.TabIndex = 7;
            this.label_username.Text = "Tên đăng nhập";
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(170, 62);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(181, 22);
            this.textBox_email.TabIndex = 6;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.Black;
            this.label_email.Location = new System.Drawing.Point(29, 62);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 21);
            this.label_email.TabIndex = 5;
            this.label_email.Text = "Email";
            // 
            // textBox_manv
            // 
            this.textBox_manv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_manv.Location = new System.Drawing.Point(170, 22);
            this.textBox_manv.Name = "textBox_manv";
            this.textBox_manv.Size = new System.Drawing.Size(181, 22);
            this.textBox_manv.TabIndex = 4;
            // 
            // label_manv
            // 
            this.label_manv.AutoSize = true;
            this.label_manv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manv.ForeColor = System.Drawing.Color.Black;
            this.label_manv.Location = new System.Drawing.Point(29, 22);
            this.label_manv.Name = "label_manv";
            this.label_manv.Size = new System.Drawing.Size(65, 21);
            this.label_manv.TabIndex = 3;
            this.label_manv.Text = "Mã NV";
            // 
            // groupBox_danhsachnhanvien
            // 
            this.groupBox_danhsachnhanvien.Controls.Add(this.dataGridView_infor);
            this.groupBox_danhsachnhanvien.Controls.Add(this.tableLayoutPanel_button);
            this.groupBox_danhsachnhanvien.Location = new System.Drawing.Point(26, 196);
            this.groupBox_danhsachnhanvien.Name = "groupBox_danhsachnhanvien";
            this.groupBox_danhsachnhanvien.Size = new System.Drawing.Size(749, 265);
            this.groupBox_danhsachnhanvien.TabIndex = 2;
            this.groupBox_danhsachnhanvien.TabStop = false;
            // 
            // dataGridView_infor
            // 
            this.dataGridView_infor.AllowUserToAddRows = false;
            this.dataGridView_infor.AllowUserToDeleteRows = false;
            this.dataGridView_infor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_infor.Location = new System.Drawing.Point(24, 19);
            this.dataGridView_infor.Name = "dataGridView_infor";
            this.dataGridView_infor.ReadOnly = true;
            this.dataGridView_infor.Size = new System.Drawing.Size(701, 167);
            this.dataGridView_infor.TabIndex = 13;
            this.dataGridView_infor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_infor_CellContentClick);
            // 
            // tableLayoutPanel_button
            // 
            this.tableLayoutPanel_button.AutoSize = true;
            this.tableLayoutPanel_button.ColumnCount = 6;
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_button.Controls.Add(this.button_them, 0, 0);
            this.tableLayoutPanel_button.Controls.Add(this.button_thoat, 5, 0);
            this.tableLayoutPanel_button.Controls.Add(this.button_xoa, 1, 0);
            this.tableLayoutPanel_button.Controls.Add(this.button_khong, 4, 0);
            this.tableLayoutPanel_button.Controls.Add(this.button_sua, 2, 0);
            this.tableLayoutPanel_button.Controls.Add(this.button_ghi_luu, 3, 0);
            this.tableLayoutPanel_button.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel_button.Location = new System.Drawing.Point(24, 206);
            this.tableLayoutPanel_button.Name = "tableLayoutPanel_button";
            this.tableLayoutPanel_button.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel_button.RowCount = 1;
            this.tableLayoutPanel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_button.Size = new System.Drawing.Size(701, 45);
            this.tableLayoutPanel_button.TabIndex = 12;
            this.tableLayoutPanel_button.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_button_Paint);
            // 
            // button_them
            // 
            this.button_them.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_them.AutoSize = true;
            this.button_them.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_them.FlatAppearance.BorderSize = 10;
            this.button_them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(8, 8);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(109, 29);
            this.button_them.TabIndex = 5;
            this.button_them.TabStop = false;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_thoat.AutoSize = true;
            this.button_thoat.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_thoat.FlatAppearance.BorderSize = 10;
            this.button_thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thoat.Location = new System.Drawing.Point(583, 8);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(110, 29);
            this.button_thoat.TabIndex = 10;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_xoa.AutoSize = true;
            this.button_xoa.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_xoa.FlatAppearance.BorderSize = 10;
            this.button_xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(123, 8);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(109, 29);
            this.button_xoa.TabIndex = 6;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            // 
            // button_khong
            // 
            this.button_khong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_khong.AutoSize = true;
            this.button_khong.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_khong.FlatAppearance.BorderSize = 10;
            this.button_khong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_khong.Location = new System.Drawing.Point(468, 8);
            this.button_khong.Name = "button_khong";
            this.button_khong.Size = new System.Drawing.Size(109, 29);
            this.button_khong.TabIndex = 9;
            this.button_khong.Text = "Không";
            this.button_khong.UseVisualStyleBackColor = true;
            // 
            // button_sua
            // 
            this.button_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sua.AutoSize = true;
            this.button_sua.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_sua.FlatAppearance.BorderSize = 10;
            this.button_sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Location = new System.Drawing.Point(238, 8);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(109, 29);
            this.button_sua.TabIndex = 7;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            // 
            // button_ghi_luu
            // 
            this.button_ghi_luu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ghi_luu.AutoSize = true;
            this.button_ghi_luu.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_ghi_luu.FlatAppearance.BorderSize = 10;
            this.button_ghi_luu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ghi_luu.Location = new System.Drawing.Point(353, 8);
            this.button_ghi_luu.Name = "button_ghi_luu";
            this.button_ghi_luu.Size = new System.Drawing.Size(109, 29);
            this.button_ghi_luu.TabIndex = 8;
            this.button_ghi_luu.Text = "Ghi/Lưu";
            this.button_ghi_luu.UseVisualStyleBackColor = true;
            this.button_ghi_luu.Click += new System.EventHandler(this.button_ghi_luu_Click);
            // 
            // form_danhsachnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 473);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.groupBox_danhsachnhanvien);
            this.Controls.Add(this.groupBox_thongtinnhanvien);
            this.Name = "form_danhsachnhanvien";
            this.Text = "Danh sách nhân viên";
            this.groupBox_thongtinnhanvien.ResumeLayout(false);
            this.groupBox_thongtinnhanvien.PerformLayout();
            this.groupBox_danhsachnhanvien.ResumeLayout(false);
            this.groupBox_danhsachnhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_infor)).EndInit();
            this.tableLayoutPanel_button.ResumeLayout(false);
            this.tableLayoutPanel_button.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DisplayComponent(string username, string password)
        {
            this.groupBox_thongtinnhanvienDisplay(username, password);
            this.dataGridView_inforDisplay();
        }

        private void groupBox_thongtinnhanvienDisplay(string username, string password)
        {
            // save to database
            var db = new database("localhost", "1433", "QLSV");

            List<KeyValuePair<string, string>> para = new List<KeyValuePair<string, string>>();
            para.Add(new KeyValuePair<string, string>("@USERNAME", username));
            para.Add(new KeyValuePair<string, string>("@MATKHAU", password));

            encrypt enc = new encrypt("20120083");
            DataTable dataTable = new DataTable();
            dataTable = db.readFromProc("SP_GET_ENCRYPT_NHANVIEN", para);

            foreach (DataRow row in dataTable.Rows)
            {
                this.textBox_manv.Text = row["MANV"].ToString();
                this.textBox_hoten.Text = row["HOTEN"].ToString();
                this.textBox_email.Text = row["EMAIL"].ToString();
                this.textBox_luong.Text = enc._dwithAES(row["LUONG"].ToString());
                this.textBox_username.Text = row["TENDN"].ToString();
                this.textBox_matkhau.Text = new string('*', 8);
            }
        }

        private void dataGridView_inforDisplay()
        {
            DataTable table = new DataTable();
            database db = new database();

            table.Columns.Add("MÃ NHÂN VIÊN", typeof(string));
            table.Columns.Add("HỌ TÊN", typeof(string));
            table.Columns.Add("EMAIL", typeof(string));
            table.Columns.Add("LƯƠNG", typeof(string));

            // input line
            int nRows = 9;
            int headerHeight = this.dataGridView_infor.ColumnHeadersHeight;
            int availableHeight = this.dataGridView_infor.Height - headerHeight;
            this.dataGridView_infor.RowTemplate.Height = availableHeight / nRows;

            for (int i = 0; i < nRows; i++)
            {
                table.Rows.Add("", "", "", "");
            }

            this.dataGridView_infor.DataSource = table;

            // set the default cell style for column headers to bold
            this.dataGridView_infor.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);

            // Set the DataSource property of the DataGridView control
            this.dataGridView_infor.RowHeadersVisible = false;

            // Customize the appearance and behavior of the DataGridView control
            this.dataGridView_infor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_infor.ReadOnly = true;
            this.dataGridView_infor.AllowUserToAddRows = false;

            // Center the column headers
            this.dataGridView_infor.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Set the column alignment to center
            foreach (DataGridViewColumn column in this.dataGridView_infor.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.GroupBox groupBox_thongtinnhanvien;
        private System.Windows.Forms.GroupBox groupBox_danhsachnhanvien;
        private System.Windows.Forms.TextBox textBox_manv;
        private System.Windows.Forms.Label label_manv;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.TextBox textBox_luong;
        private System.Windows.Forms.Label label_luong;
        private System.Windows.Forms.TextBox textBox_hoten;
        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_ghi_luu;
        private System.Windows.Forms.Button button_khong;
        private System.Windows.Forms.Button button_thoat;
        private TableLayoutPanel tableLayoutPanel_button;
        private DataGridView dataGridView_infor;
    }
}