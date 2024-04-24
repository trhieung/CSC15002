namespace Lab4_QLSV
{
    partial class Form_manhinhdangnhap
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
            this.label_matkhau = new System.Windows.Forms.Label();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matkhau.Location = new System.Drawing.Point(73, 115);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(71, 19);
            this.label_matkhau.TabIndex = 1;
            this.label_matkhau.Text = "Mật khẩu";
            this.label_matkhau.Click += new System.EventHandler(this.label_matkhau_Click);
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matkhau.Location = new System.Drawing.Point(221, 112);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.Size = new System.Drawing.Size(200, 27);
            this.textBox_matkhau.TabIndex = 3;
            this.textBox_matkhau.TextChanged += new System.EventHandler(this.textBox_matkhau_TextChanged);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_dangnhap.FlatAppearance.BorderSize = 10;
            this.button_dangnhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangnhap.Location = new System.Drawing.Point(197, 178);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(86, 27);
            this.button_dangnhap.TabIndex = 4;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_thoat.FlatAppearance.BorderSize = 10;
            this.button_thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thoat.Location = new System.Drawing.Point(313, 178);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(86, 27);
            this.button_thoat.TabIndex = 5;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(63, 45);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(105, 19);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Tên đăng nhập";
            this.label_username.Click += new System.EventHandler(this.label_username_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(221, 42);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(200, 27);
            this.textBox_username.TabIndex = 2;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // Form_manhinhdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 265);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.textBox_matkhau);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_matkhau);
            this.Controls.Add(this.label_username);
            this.Name = "Form_manhinhdangnhap";
            this.Text = "Màn hình đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_username;
    }
}

