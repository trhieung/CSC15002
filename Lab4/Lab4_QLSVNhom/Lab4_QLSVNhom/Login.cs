using Lab4_QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab4_QLSVNhom
{
    public partial class Login : Form
    {
        private string username;
        private string matkhau;
        public Login()
        {
            InitializeComponent();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            encrypt enc = new encrypt("20120083");

            username = textBox_username.Text;
            matkhau = textBox_matkhau.Text;
            string enc_mk = enc.ewithHASH1(textBox_matkhau.Text);


            database db = new database("localhost", "1433", "QLSV");
            if (db.Connect(username, enc_mk))
            {
                //MessageBox.Show(this, "Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                form_danhsachnhanvien form_dssv = new form_danhsachnhanvien(username, enc_mk);
                //form_dssv.FormClosed = form_dssv_FormClosed();
                //this.Hide();
                form_dssv.ShowDialog();
                form_dssv.FormClosed += button_thoat_Click;
            }
            else
            {
                MessageBox.Show(this, "Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
