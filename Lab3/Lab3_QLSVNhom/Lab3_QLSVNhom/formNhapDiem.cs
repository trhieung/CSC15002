using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_QLSVNhom
{
    public partial class formNhapDiem : Form
    {
        public student mainForm { get; set; }
        private string tdn = null;
        public formNhapDiem(List<string> data = null)
        {
            InitializeComponent();
            if (data != null)
            {
                this.updateData(data);
            }

        }

        private void updateData(List<string> data)
        {
            this.label6.Text = data[0];
            this.label1.Text = data[1];
            this.textBox1.Text = data[2];
            this.tdn = data[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new SqlServer("localhost", "1433", "QLSVNhom");

            List<KeyValuePair<string, string>> para = new List<KeyValuePair<string, string>>();
            para.Add(new KeyValuePair<string, string>("@MASV", this.label6.Text));
            para.Add(new KeyValuePair<string, string>("@TDN", this.tdn));
            para.Add(new KeyValuePair<string, string>("@MAHP", this.label1.Text));
            para.Add(new KeyValuePair<string, string>("@DIEM", this.textBox1.Text));

            if (db.updateThroughProc("SP_INS_ENCRYPT_NHANVIEN", para))
            {
                MessageBox.Show("save success");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
