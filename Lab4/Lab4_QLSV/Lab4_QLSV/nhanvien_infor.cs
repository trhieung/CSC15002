using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_QLSV
{
    public partial class nhanvien_infor : Form
    {
        public List<string> datas { get; set; }

        public nhanvien_infor()
        {
            InitializeComponent();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_xacnhan_Click(object sender, EventArgs e)
        {
            this.datas = new List<string>();
            this.datas.Add(textBox_manv.Text);
            this.datas.Add(textBox_email.Text);
            this.datas.Add(textBox_username.Text);
            this.datas.Add(textBox_hoten.Text);
            this.datas.Add(textBox_luong.Text);
            this.datas.Add(textBox_matkhau.Text);

            // need more handle about empty lable


            //
            MessageBox.Show(this, "Add data success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // close form
            this.Close();

        }
    }
}
