namespace Lab4_QLSVNhom
{
    partial class getKey
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
            this.textBox_nhapkhoa = new System.Windows.Forms.TextBox();
            this.label_nhapkhoa = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_nhapkhoa
            // 
            this.textBox_nhapkhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nhapkhoa.Location = new System.Drawing.Point(158, 46);
            this.textBox_nhapkhoa.Name = "textBox_nhapkhoa";
            this.textBox_nhapkhoa.Size = new System.Drawing.Size(236, 22);
            this.textBox_nhapkhoa.TabIndex = 15;
            // 
            // label_nhapkhoa
            // 
            this.label_nhapkhoa.AutoSize = true;
            this.label_nhapkhoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nhapkhoa.ForeColor = System.Drawing.Color.Black;
            this.label_nhapkhoa.Location = new System.Drawing.Point(44, 47);
            this.label_nhapkhoa.Name = "label_nhapkhoa";
            this.label_nhapkhoa.Size = new System.Drawing.Size(91, 21);
            this.label_nhapkhoa.TabIndex = 14;
            this.label_nhapkhoa.Text = "Nhập khóa";
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.AutoSize = true;
            this.button_ok.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_ok.FlatAppearance.BorderSize = 10;
            this.button_ok.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.Location = new System.Drawing.Point(95, 102);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(103, 29);
            this.button_ok.TabIndex = 16;
            this.button_ok.TabStop = false;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.AutoSize = true;
            this.button_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_cancel.FlatAppearance.BorderSize = 10;
            this.button_cancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(250, 102);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(103, 29);
            this.button_cancel.TabIndex = 17;
            this.button_cancel.TabStop = false;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // getKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 177);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_nhapkhoa);
            this.Controls.Add(this.label_nhapkhoa);
            this.Name = "getKey";
            this.Text = "Mã hóa đối xứng Client - Nhập mã đối xứng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nhapkhoa;
        private System.Windows.Forms.Label label_nhapkhoa;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
    }
}