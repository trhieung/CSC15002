using Lab4_QLSV;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lab4_QLSVNhom
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
            this.button_refresh = new System.Windows.Forms.Button();
            this.dataGridView_infor = new System.Windows.Forms.DataGridView();
            this.button_select = new System.Windows.Forms.Button();
            this.groupBox_danhsachnhanvien = new System.Windows.Forms.GroupBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.label_manv_ins = new System.Windows.Forms.Label();
            this.textBox_manv_ins = new System.Windows.Forms.TextBox();
            this.label_email_ins = new System.Windows.Forms.Label();
            this.textBox_hoten_ins = new System.Windows.Forms.TextBox();
            this.label_luong_ins = new System.Windows.Forms.Label();
            this.label_hoten_ins = new System.Windows.Forms.Label();
            this.label_matkhau_ins = new System.Windows.Forms.Label();
            this.label_usernam_ins = new System.Windows.Forms.Label();
            this.textBox_email_ins = new System.Windows.Forms.TextBox();
            this.textBox_luong_ins = new System.Windows.Forms.TextBox();
            this.textBox_username_ins = new System.Windows.Forms.TextBox();
            this.textBox_matkhau_ins = new System.Windows.Forms.TextBox();
            this.tabControl_nhanvien = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_hocsinh = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_matkhau_tab2 = new System.Windows.Forms.TextBox();
            this.label_matkhau_tab2 = new System.Windows.Forms.Label();
            this.textBox_luong_tab2 = new System.Windows.Forms.TextBox();
            this.labelluong_tab2 = new System.Windows.Forms.Label();
            this.textBox_hoten_tab2 = new System.Windows.Forms.TextBox();
            this.label_hoten_tab2 = new System.Windows.Forms.Label();
            this.textBox_username_tab2 = new System.Windows.Forms.TextBox();
            this.label_username_tab2 = new System.Windows.Forms.Label();
            this.textBox_email_tab2 = new System.Windows.Forms.TextBox();
            this.label_email_tab2 = new System.Windows.Forms.Label();
            this.textBox_manv_tab2 = new System.Windows.Forms.TextBox();
            this.label6_manv_tab2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_login = new System.Windows.Forms.GroupBox();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.textBox_matkhau_login = new System.Windows.Forms.TextBox();
            this.textBox_username_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_infor)).BeginInit();
            this.groupBox_danhsachnhanvien.SuspendLayout();
            this.tabControl_nhanvien.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_thongtinnhanvien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox_hocsinh.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.AutoSize = true;
            this.button_refresh.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_refresh.FlatAppearance.BorderSize = 10;
            this.button_refresh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.Location = new System.Drawing.Point(443, 359);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(109, 29);
            this.button_refresh.TabIndex = 8;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // dataGridView_infor
            // 
            this.dataGridView_infor.AllowUserToAddRows = false;
            this.dataGridView_infor.AllowUserToDeleteRows = false;
            this.dataGridView_infor.AllowUserToResizeRows = false;
            this.dataGridView_infor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_infor.Location = new System.Drawing.Point(24, 19);
            this.dataGridView_infor.Name = "dataGridView_infor";
            this.dataGridView_infor.ReadOnly = true;
            this.dataGridView_infor.Size = new System.Drawing.Size(728, 322);
            this.dataGridView_infor.TabIndex = 13;
            // 
            // button_select
            // 
            this.button_select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_select.AutoSize = true;
            this.button_select.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_select.FlatAppearance.BorderSize = 10;
            this.button_select.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select.Location = new System.Drawing.Point(234, 359);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(109, 29);
            this.button_select.TabIndex = 5;
            this.button_select.TabStop = false;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // groupBox_danhsachnhanvien
            // 
            this.groupBox_danhsachnhanvien.Controls.Add(this.button_select);
            this.groupBox_danhsachnhanvien.Controls.Add(this.dataGridView_infor);
            this.groupBox_danhsachnhanvien.Controls.Add(this.button_refresh);
            this.groupBox_danhsachnhanvien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_danhsachnhanvien.Location = new System.Drawing.Point(315, 211);
            this.groupBox_danhsachnhanvien.Name = "groupBox_danhsachnhanvien";
            this.groupBox_danhsachnhanvien.Size = new System.Drawing.Size(763, 402);
            this.groupBox_danhsachnhanvien.TabIndex = 2;
            this.groupBox_danhsachnhanvien.TabStop = false;
            this.groupBox_danhsachnhanvien.Text = "Giải mã (Thao tác select)";
            // 
            // button_insert
            // 
            this.button_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_insert.AutoSize = true;
            this.button_insert.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_insert.FlatAppearance.BorderSize = 10;
            this.button_insert.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.Location = new System.Drawing.Point(79, 350);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(125, 38);
            this.button_insert.TabIndex = 6;
            this.button_insert.TabStop = false;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // label_manv_ins
            // 
            this.label_manv_ins.AutoSize = true;
            this.label_manv_ins.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manv_ins.ForeColor = System.Drawing.Color.Black;
            this.label_manv_ins.Location = new System.Drawing.Point(13, 60);
            this.label_manv_ins.Name = "label_manv_ins";
            this.label_manv_ins.Size = new System.Drawing.Size(65, 21);
            this.label_manv_ins.TabIndex = 7;
            this.label_manv_ins.Text = "Mã NV";
            // 
            // textBox_manv_ins
            // 
            this.textBox_manv_ins.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_manv_ins.Location = new System.Drawing.Point(144, 59);
            this.textBox_manv_ins.Name = "textBox_manv_ins";
            this.textBox_manv_ins.Size = new System.Drawing.Size(108, 22);
            this.textBox_manv_ins.TabIndex = 8;
            // 
            // label_email_ins
            // 
            this.label_email_ins.AutoSize = true;
            this.label_email_ins.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_ins.ForeColor = System.Drawing.Color.Black;
            this.label_email_ins.Location = new System.Drawing.Point(13, 150);
            this.label_email_ins.Name = "label_email_ins";
            this.label_email_ins.Size = new System.Drawing.Size(51, 21);
            this.label_email_ins.TabIndex = 9;
            this.label_email_ins.Text = "Email";
            // 
            // textBox_hoten_ins
            // 
            this.textBox_hoten_ins.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hoten_ins.Location = new System.Drawing.Point(144, 104);
            this.textBox_hoten_ins.Name = "textBox_hoten_ins";
            this.textBox_hoten_ins.Size = new System.Drawing.Size(108, 22);
            this.textBox_hoten_ins.TabIndex = 10;
            // 
            // label_luong_ins
            // 
            this.label_luong_ins.AutoSize = true;
            this.label_luong_ins.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_luong_ins.ForeColor = System.Drawing.Color.Black;
            this.label_luong_ins.Location = new System.Drawing.Point(13, 195);
            this.label_luong_ins.Name = "label_luong_ins";
            this.label_luong_ins.Size = new System.Drawing.Size(59, 21);
            this.label_luong_ins.TabIndex = 12;
            this.label_luong_ins.Text = "Lương";
            // 
            // label_hoten_ins
            // 
            this.label_hoten_ins.AutoSize = true;
            this.label_hoten_ins.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hoten_ins.ForeColor = System.Drawing.Color.Black;
            this.label_hoten_ins.Location = new System.Drawing.Point(13, 105);
            this.label_hoten_ins.Name = "label_hoten_ins";
            this.label_hoten_ins.Size = new System.Drawing.Size(60, 21);
            this.label_hoten_ins.TabIndex = 14;
            this.label_hoten_ins.Text = "Họ tên";
            // 
            // label_matkhau_ins
            // 
            this.label_matkhau_ins.AutoSize = true;
            this.label_matkhau_ins.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matkhau_ins.ForeColor = System.Drawing.Color.Black;
            this.label_matkhau_ins.Location = new System.Drawing.Point(13, 285);
            this.label_matkhau_ins.Name = "label_matkhau_ins";
            this.label_matkhau_ins.Size = new System.Drawing.Size(79, 21);
            this.label_matkhau_ins.TabIndex = 15;
            this.label_matkhau_ins.Text = "Mật khẩu";
            // 
            // label_usernam_ins
            // 
            this.label_usernam_ins.AutoSize = true;
            this.label_usernam_ins.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usernam_ins.ForeColor = System.Drawing.Color.Black;
            this.label_usernam_ins.Location = new System.Drawing.Point(13, 240);
            this.label_usernam_ins.Name = "label_usernam_ins";
            this.label_usernam_ins.Size = new System.Drawing.Size(121, 21);
            this.label_usernam_ins.TabIndex = 16;
            this.label_usernam_ins.Text = "Tên đăng nhập";
            // 
            // textBox_email_ins
            // 
            this.textBox_email_ins.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email_ins.Location = new System.Drawing.Point(144, 149);
            this.textBox_email_ins.Name = "textBox_email_ins";
            this.textBox_email_ins.Size = new System.Drawing.Size(108, 22);
            this.textBox_email_ins.TabIndex = 17;
            // 
            // textBox_luong_ins
            // 
            this.textBox_luong_ins.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_luong_ins.Location = new System.Drawing.Point(144, 194);
            this.textBox_luong_ins.Name = "textBox_luong_ins";
            this.textBox_luong_ins.Size = new System.Drawing.Size(108, 22);
            this.textBox_luong_ins.TabIndex = 18;
            // 
            // textBox_username_ins
            // 
            this.textBox_username_ins.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username_ins.Location = new System.Drawing.Point(144, 239);
            this.textBox_username_ins.Name = "textBox_username_ins";
            this.textBox_username_ins.Size = new System.Drawing.Size(108, 22);
            this.textBox_username_ins.TabIndex = 19;
            // 
            // textBox_matkhau_ins
            // 
            this.textBox_matkhau_ins.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matkhau_ins.Location = new System.Drawing.Point(144, 284);
            this.textBox_matkhau_ins.Name = "textBox_matkhau_ins";
            this.textBox_matkhau_ins.Size = new System.Drawing.Size(108, 22);
            this.textBox_matkhau_ins.TabIndex = 20;
            // 
            // tabControl_nhanvien
            // 
            this.tabControl_nhanvien.Controls.Add(this.tabPage1);
            this.tabControl_nhanvien.Controls.Add(this.tabPage2);
            this.tabControl_nhanvien.Location = new System.Drawing.Point(1, 2);
            this.tabControl_nhanvien.Name = "tabControl_nhanvien";
            this.tabControl_nhanvien.SelectedIndex = 0;
            this.tabControl_nhanvien.Size = new System.Drawing.Size(1126, 655);
            this.tabControl_nhanvien.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_title);
            this.tabPage1.Controls.Add(this.groupBox_thongtinnhanvien);
            this.tabPage1.Controls.Add(this.groupBox_danhsachnhanvien);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(395, 14);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(286, 26);
            this.label_title.TabIndex = 4;
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
            this.groupBox_thongtinnhanvien.Location = new System.Drawing.Point(24, 49);
            this.groupBox_thongtinnhanvien.Name = "groupBox_thongtinnhanvien";
            this.groupBox_thongtinnhanvien.Size = new System.Drawing.Size(1044, 146);
            this.groupBox_thongtinnhanvien.TabIndex = 5;
            this.groupBox_thongtinnhanvien.TabStop = false;
            this.groupBox_thongtinnhanvien.Text = "Thông tin nhân viên";
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matkhau.Location = new System.Drawing.Point(675, 103);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.Size = new System.Drawing.Size(230, 22);
            this.textBox_matkhau.TabIndex = 14;
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matkhau.ForeColor = System.Drawing.Color.Black;
            this.label_matkhau.Location = new System.Drawing.Point(578, 103);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(79, 21);
            this.label_matkhau.TabIndex = 13;
            this.label_matkhau.Text = "Mật khẩu";
            // 
            // textBox_luong
            // 
            this.textBox_luong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_luong.Location = new System.Drawing.Point(675, 63);
            this.textBox_luong.Name = "textBox_luong";
            this.textBox_luong.Size = new System.Drawing.Size(230, 22);
            this.textBox_luong.TabIndex = 12;
            // 
            // label_luong
            // 
            this.label_luong.AutoSize = true;
            this.label_luong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_luong.ForeColor = System.Drawing.Color.Black;
            this.label_luong.Location = new System.Drawing.Point(578, 63);
            this.label_luong.Name = "label_luong";
            this.label_luong.Size = new System.Drawing.Size(59, 21);
            this.label_luong.TabIndex = 11;
            this.label_luong.Text = "Lương";
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hoten.Location = new System.Drawing.Point(675, 23);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(230, 22);
            this.textBox_hoten.TabIndex = 10;
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hoten.ForeColor = System.Drawing.Color.Black;
            this.label_hoten.Location = new System.Drawing.Point(578, 23);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(60, 21);
            this.label_hoten.TabIndex = 9;
            this.label_hoten.Text = "Họ tên";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(255, 103);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(197, 22);
            this.textBox_username.TabIndex = 8;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.Black;
            this.label_username.Location = new System.Drawing.Point(114, 103);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(121, 21);
            this.label_username.TabIndex = 7;
            this.label_username.Text = "Tên đăng nhập";
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(255, 63);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(197, 22);
            this.textBox_email.TabIndex = 6;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.Black;
            this.label_email.Location = new System.Drawing.Point(114, 63);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 21);
            this.label_email.TabIndex = 5;
            this.label_email.Text = "Email";
            // 
            // textBox_manv
            // 
            this.textBox_manv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_manv.Location = new System.Drawing.Point(255, 23);
            this.textBox_manv.Name = "textBox_manv";
            this.textBox_manv.Size = new System.Drawing.Size(197, 22);
            this.textBox_manv.TabIndex = 4;
            // 
            // label_manv
            // 
            this.label_manv.AutoSize = true;
            this.label_manv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manv.ForeColor = System.Drawing.Color.Black;
            this.label_manv.Location = new System.Drawing.Point(114, 23);
            this.label_manv.Name = "label_manv";
            this.label_manv.Size = new System.Drawing.Size(65, 21);
            this.label_manv.TabIndex = 3;
            this.label_manv.Text = "Mã NV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_matkhau_ins);
            this.groupBox1.Controls.Add(this.textBox_username_ins);
            this.groupBox1.Controls.Add(this.textBox_luong_ins);
            this.groupBox1.Controls.Add(this.textBox_email_ins);
            this.groupBox1.Controls.Add(this.label_usernam_ins);
            this.groupBox1.Controls.Add(this.label_matkhau_ins);
            this.groupBox1.Controls.Add(this.label_hoten_ins);
            this.groupBox1.Controls.Add(this.label_luong_ins);
            this.groupBox1.Controls.Add(this.textBox_hoten_ins);
            this.groupBox1.Controls.Add(this.label_email_ins);
            this.groupBox1.Controls.Add(this.textBox_manv_ins);
            this.groupBox1.Controls.Add(this.label_manv_ins);
            this.groupBox1.Controls.Add(this.button_insert);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 402);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã hóa (Thao tác Insert)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox_login);
            this.tabPage2.Controls.Add(this.groupBox_hocsinh);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QUẢN LÝ HỌC SINH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox_hocsinh
            // 
            this.groupBox_hocsinh.Controls.Add(this.groupBox2);
            this.groupBox_hocsinh.Controls.Add(this.groupBox3);
            this.groupBox_hocsinh.Location = new System.Drawing.Point(18, 3);
            this.groupBox_hocsinh.Name = "groupBox_hocsinh";
            this.groupBox_hocsinh.Size = new System.Drawing.Size(1065, 626);
            this.groupBox_hocsinh.TabIndex = 11;
            this.groupBox_hocsinh.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_matkhau_tab2);
            this.groupBox2.Controls.Add(this.label_matkhau_tab2);
            this.groupBox2.Controls.Add(this.textBox_luong_tab2);
            this.groupBox2.Controls.Add(this.labelluong_tab2);
            this.groupBox2.Controls.Add(this.textBox_hoten_tab2);
            this.groupBox2.Controls.Add(this.label_hoten_tab2);
            this.groupBox2.Controls.Add(this.textBox_username_tab2);
            this.groupBox2.Controls.Add(this.label_username_tab2);
            this.groupBox2.Controls.Add(this.textBox_email_tab2);
            this.groupBox2.Controls.Add(this.label_email_tab2);
            this.groupBox2.Controls.Add(this.textBox_manv_tab2);
            this.groupBox2.Controls.Add(this.label6_manv_tab2);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(25, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1023, 146);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // textBox_matkhau_tab2
            // 
            this.textBox_matkhau_tab2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matkhau_tab2.Location = new System.Drawing.Point(675, 104);
            this.textBox_matkhau_tab2.Name = "textBox_matkhau_tab2";
            this.textBox_matkhau_tab2.Size = new System.Drawing.Size(230, 22);
            this.textBox_matkhau_tab2.TabIndex = 14;
            // 
            // label_matkhau_tab2
            // 
            this.label_matkhau_tab2.AutoSize = true;
            this.label_matkhau_tab2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matkhau_tab2.ForeColor = System.Drawing.Color.Black;
            this.label_matkhau_tab2.Location = new System.Drawing.Point(578, 104);
            this.label_matkhau_tab2.Name = "label_matkhau_tab2";
            this.label_matkhau_tab2.Size = new System.Drawing.Size(79, 21);
            this.label_matkhau_tab2.TabIndex = 13;
            this.label_matkhau_tab2.Text = "Mật khẩu";
            // 
            // textBox_luong_tab2
            // 
            this.textBox_luong_tab2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_luong_tab2.Location = new System.Drawing.Point(675, 64);
            this.textBox_luong_tab2.Name = "textBox_luong_tab2";
            this.textBox_luong_tab2.Size = new System.Drawing.Size(230, 22);
            this.textBox_luong_tab2.TabIndex = 12;
            // 
            // labelluong_tab2
            // 
            this.labelluong_tab2.AutoSize = true;
            this.labelluong_tab2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelluong_tab2.ForeColor = System.Drawing.Color.Black;
            this.labelluong_tab2.Location = new System.Drawing.Point(578, 64);
            this.labelluong_tab2.Name = "labelluong_tab2";
            this.labelluong_tab2.Size = new System.Drawing.Size(59, 21);
            this.labelluong_tab2.TabIndex = 11;
            this.labelluong_tab2.Text = "Lương";
            // 
            // textBox_hoten_tab2
            // 
            this.textBox_hoten_tab2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hoten_tab2.Location = new System.Drawing.Point(675, 24);
            this.textBox_hoten_tab2.Name = "textBox_hoten_tab2";
            this.textBox_hoten_tab2.Size = new System.Drawing.Size(230, 22);
            this.textBox_hoten_tab2.TabIndex = 10;
            // 
            // label_hoten_tab2
            // 
            this.label_hoten_tab2.AutoSize = true;
            this.label_hoten_tab2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hoten_tab2.ForeColor = System.Drawing.Color.Black;
            this.label_hoten_tab2.Location = new System.Drawing.Point(578, 24);
            this.label_hoten_tab2.Name = "label_hoten_tab2";
            this.label_hoten_tab2.Size = new System.Drawing.Size(60, 21);
            this.label_hoten_tab2.TabIndex = 9;
            this.label_hoten_tab2.Text = "Họ tên";
            // 
            // textBox_username_tab2
            // 
            this.textBox_username_tab2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username_tab2.Location = new System.Drawing.Point(213, 103);
            this.textBox_username_tab2.Name = "textBox_username_tab2";
            this.textBox_username_tab2.Size = new System.Drawing.Size(197, 22);
            this.textBox_username_tab2.TabIndex = 8;
            // 
            // label_username_tab2
            // 
            this.label_username_tab2.AutoSize = true;
            this.label_username_tab2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username_tab2.ForeColor = System.Drawing.Color.Black;
            this.label_username_tab2.Location = new System.Drawing.Point(72, 103);
            this.label_username_tab2.Name = "label_username_tab2";
            this.label_username_tab2.Size = new System.Drawing.Size(121, 21);
            this.label_username_tab2.TabIndex = 7;
            this.label_username_tab2.Text = "Tên đăng nhập";
            // 
            // textBox_email_tab2
            // 
            this.textBox_email_tab2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email_tab2.Location = new System.Drawing.Point(213, 63);
            this.textBox_email_tab2.Name = "textBox_email_tab2";
            this.textBox_email_tab2.Size = new System.Drawing.Size(197, 22);
            this.textBox_email_tab2.TabIndex = 6;
            // 
            // label_email_tab2
            // 
            this.label_email_tab2.AutoSize = true;
            this.label_email_tab2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_tab2.ForeColor = System.Drawing.Color.Black;
            this.label_email_tab2.Location = new System.Drawing.Point(72, 63);
            this.label_email_tab2.Name = "label_email_tab2";
            this.label_email_tab2.Size = new System.Drawing.Size(51, 21);
            this.label_email_tab2.TabIndex = 5;
            this.label_email_tab2.Text = "Email";
            // 
            // textBox_manv_tab2
            // 
            this.textBox_manv_tab2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_manv_tab2.Location = new System.Drawing.Point(213, 23);
            this.textBox_manv_tab2.Name = "textBox_manv_tab2";
            this.textBox_manv_tab2.Size = new System.Drawing.Size(197, 22);
            this.textBox_manv_tab2.TabIndex = 4;
            // 
            // label6_manv_tab2
            // 
            this.label6_manv_tab2.AutoSize = true;
            this.label6_manv_tab2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_manv_tab2.ForeColor = System.Drawing.Color.Black;
            this.label6_manv_tab2.Location = new System.Drawing.Point(72, 23);
            this.label6_manv_tab2.Name = "label6_manv_tab2";
            this.label6_manv_tab2.Size = new System.Drawing.Size(65, 21);
            this.label6_manv_tab2.TabIndex = 3;
            this.label6_manv_tab2.Text = "Mã NV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1023, 422);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giải mã (Thao tác select)";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(326, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.BorderSize = 10;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(535, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(974, 329);
            this.dataGridView1.TabIndex = 13;
            // 
            // groupBox_login
            // 
            this.groupBox_login.Controls.Add(this.button_thoat);
            this.groupBox_login.Controls.Add(this.button_dangnhap);
            this.groupBox_login.Controls.Add(this.textBox_matkhau_login);
            this.groupBox_login.Controls.Add(this.textBox_username_login);
            this.groupBox_login.Controls.Add(this.label1);
            this.groupBox_login.Controls.Add(this.label2);
            this.groupBox_login.Location = new System.Drawing.Point(18, 9);
            this.groupBox_login.Name = "groupBox_login";
            this.groupBox_login.Size = new System.Drawing.Size(1065, 617);
            this.groupBox_login.TabIndex = 10;
            this.groupBox_login.TabStop = false;
            // 
            // button_thoat
            // 
            this.button_thoat.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_thoat.FlatAppearance.BorderSize = 10;
            this.button_thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thoat.Location = new System.Drawing.Point(575, 315);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(86, 27);
            this.button_thoat.TabIndex = 11;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_dangnhap.FlatAppearance.BorderSize = 10;
            this.button_dangnhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangnhap.Location = new System.Drawing.Point(459, 315);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(86, 27);
            this.button_dangnhap.TabIndex = 10;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // textBox_matkhau_login
            // 
            this.textBox_matkhau_login.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matkhau_login.Location = new System.Drawing.Point(483, 249);
            this.textBox_matkhau_login.Name = "textBox_matkhau_login";
            this.textBox_matkhau_login.Size = new System.Drawing.Size(200, 27);
            this.textBox_matkhau_login.TabIndex = 9;
            // 
            // textBox_username_login
            // 
            this.textBox_username_login.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username_login.Location = new System.Drawing.Point(483, 179);
            this.textBox_username_login.Name = "textBox_username_login";
            this.textBox_username_login.Size = new System.Drawing.Size(200, 27);
            this.textBox_username_login.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên đăng nhập";
            // 
            // form_danhsachnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 659);
            this.Controls.Add(this.tabControl_nhanvien);
            this.Name = "form_danhsachnhanvien";
            this.Text = "Danh sách nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_infor)).EndInit();
            this.groupBox_danhsachnhanvien.ResumeLayout(false);
            this.groupBox_danhsachnhanvien.PerformLayout();
            this.tabControl_nhanvien.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox_thongtinnhanvien.ResumeLayout(false);
            this.groupBox_thongtinnhanvien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox_hocsinh.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_login.ResumeLayout(false);
            this.groupBox_login.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private Button button_refresh;
        private DataGridView dataGridView_infor;
        private Button button_select;
        private GroupBox groupBox_danhsachnhanvien;
        private Button button_insert;
        private Label label_manv_ins;
        private TextBox textBox_manv_ins;
        private Label label_email_ins;
        private TextBox textBox_hoten_ins;
        private Label label_luong_ins;
        private Label label_hoten_ins;
        private Label label_matkhau_ins;
        private Label label_usernam_ins;
        private TextBox textBox_email_ins;
        private TextBox textBox_luong_ins;
        private TextBox textBox_username_ins;
        private TextBox textBox_matkhau_ins;
        private TabControl tabControl_nhanvien;
        private TabPage tabPage1;
        private Label label_title;
        private GroupBox groupBox_thongtinnhanvien;
        private TextBox textBox_matkhau;
        private Label label_matkhau;
        private TextBox textBox_luong;
        private Label label_luong;
        private TextBox textBox_hoten;
        private Label label_hoten;
        private TextBox textBox_username;
        private Label label_username;
        private TextBox textBox_email;
        private Label label_email;
        private TextBox textBox_manv;
        private Label label_manv;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox_login;
        private GroupBox groupBox2;
        private TextBox textBox_matkhau_tab2;
        private Label label_matkhau_tab2;
        private TextBox textBox_luong_tab2;
        private Label labelluong_tab2;
        private TextBox textBox_hoten_tab2;
        private Label label_hoten_tab2;
        private TextBox textBox_username_tab2;
        private Label label_username_tab2;
        private TextBox textBox_email_tab2;
        private Label label_email_tab2;
        private TextBox textBox_manv_tab2;
        private Label label6_manv_tab2;
        private Button button_thoat;
        private Button button_dangnhap;
        private TextBox textBox_matkhau_login;
        private TextBox textBox_username_login;
        private Label label1;
        private Label label2;
        private GroupBox groupBox_hocsinh;
    }
}