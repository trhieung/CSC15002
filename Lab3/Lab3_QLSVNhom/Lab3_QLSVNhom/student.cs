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
    public partial class student : Form
    {
        private SqlServer db;
        private string TDN = "nva";
        private string mk = "123456";
        public Form1 mainForm { get; set; }

        public student(List<string> data = null)
        {
            InitializeComponent();
            if(data != null)
            {
                this.updateData(data);
            }


            var db = new SqlServer("localhost", "1433", "QLSVNhom");

            List<KeyValuePair<string, string>> para = new List<KeyValuePair<string, string>>();
            para.Add(new KeyValuePair<string, string>("@TDN", TDN));
            para.Add(new KeyValuePair<string, string>("@MK", mk));

            this.dataGridView1.DataSource = db.readFromProc("SP_SEL_PUBLIC_BANDDIEM", para);
        }

        private void updateData(List<string> data)
        {
            this.label6.Text = data[0];
            this.textBox1.Text = data[1];
            this.textBox2.Text = data[2];
            this.textBox4.Text = data[3];
            this.textBox3.Text = data[4];
            this.TDN = data[6];
            this.mk = data[7];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new SqlServer("localhost", "1433", "QLSVNhom");

            List<KeyValuePair<string, string>> para = new List<KeyValuePair<string, string>>();
            para.Add(new KeyValuePair<string, string>("@MASV", this.label6.Text));
            para.Add(new KeyValuePair<string, string>("@HOTEN", this.textBox1.Text));
            para.Add(new KeyValuePair<string, string>("@NGAYSINH", this.textBox2.Text));
            para.Add(new KeyValuePair<string, string>("@DIACHI", this.textBox4.Text));
            para.Add(new KeyValuePair<string, string>("@MALOP", this.textBox3.Text));

            if (db.updateThroughProc("SP_UPD_PUBLIC_SINHVIEN", para))
            {
                MessageBox.Show("update success");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the data from the clicked row and column
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                List<string> datas = new List<string>();

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    datas.Add(row.Cells[i].Value.ToString());
                }
                // Create a new form to display the data
                this.OpenNhapDiemForm(datas);
            }
        }

        private void OpenNhapDiemForm(List<string> datas)
        {
            datas.Add(TDN);
            datas.Add(mk);
            formNhapDiem nd = new formNhapDiem(datas);
            nd.mainForm = this;
            nd.FormClosed += nd_FormClosed;
            nd.ShowDialog();
        }

        private void nd_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
            var db = new SqlServer("localhost", "1433", "QLSVNhom");
            List<KeyValuePair<string, string>> para = new List<KeyValuePair<string, string>>();
            para.Add(new KeyValuePair<string, string>("@TDN", TDN));
            para.Add(new KeyValuePair<string, string>("@MK", mk));

            this.dataGridView1.DataSource = db.readFromProc("SP_SEL_PUBLIC_BANDDIEM", para);
        }
    }
}
