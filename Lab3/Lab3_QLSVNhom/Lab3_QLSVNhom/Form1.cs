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
    public partial class Form1 : Form
    {
        private SqlServer db;
        private string TDN = "nva";
        private string mk = "123456";
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add event handlers for textbox1
            this.textBox3.Enter += (s, ev) => {
                if (this.textBox3.Text == "Mã lớp")
                {
                    this.textBox3.Text = "";
                    this.textBox3.ForeColor = Color.Black;
                }
            };

            this.textBox3.Leave += (s, ev) => {
                if (string.IsNullOrWhiteSpace(this.textBox3.Text))
                {
                    this.textBox3.Text = "Mã lớp";
                    this.textBox3.ForeColor = Color.Gray;
                }
            };

            // tab1
            db = new SqlServer("localhost", "1433", "QLSVNhom");
            dataGridView1.DataSource = db.SelectFromTable("LOP");

            // Set auto-size mode to fill
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Auto-resize row heights to fit cell contents
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // tab2
            DataTable dt = db.readFromProc("SP_SEL_PUBLIC_LOP", null);

            this.comboBox1.Items.Clear();

            //// Iterate over the rows of the DataTable
            foreach (DataRow row in dt.Rows)
            {
                // Get the value of the first (and only) column in the row
                string value = row[0].ToString();

                // Add the value to the Items collection of the ComboBox
                this.comboBox1.Items.Add(value);
            }

            //
            List<KeyValuePair<string, string>>  para = new List<KeyValuePair<string, string>>();
            para.Add(new KeyValuePair<string, string>("@TDN", TDN));
            this.dataGridView2.DataSource = db.readFromProc("SP_SEL_PUBLIC_SV", para);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            SqlServer sv = new SqlServer("localhost", "1433", "QLSVNhom");
            if (sv.Connect(username, password))
            {
                //MessageBox.Show(this, "Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.panel2.BringToFront();
                this.TDN = username;
                this.mk = password;
            }
            else
            {
                MessageBox.Show(this, "Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var db = new SqlServer("localhost", "1433", "QLSVNhom");
            dataGridView1.DataSource = db.SelectFromTable("LOP");

            // Set auto-size mode to fill
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Auto-resize row heights to fit cell contents
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MALOP = this.comboBox1.SelectedItem.ToString();
            List<KeyValuePair<string, string>> para = new List<KeyValuePair<string, string>>();
            para.Add(new KeyValuePair<string, string>("@TDN", TDN));
            para.Add(new KeyValuePair<string, string>("@MALOP", MALOP));

            this.dataGridView2.DataSource = db.readFromProc("SP_SEL_PUBLIC_SV_IN_LOP", para);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the data from the clicked row and column
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                List<string> datas = new List<string>();

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    datas.Add(row.Cells[i].Value.ToString());
                }
                // Create a new form to display the data
                this.OpenStudentForm(datas);
            }
        }
        private void st_FormClosed(object sender, FormClosedEventArgs e)
        {
            // tab2
            DataTable dt = db.readFromProc("SP_SEL_PUBLIC_LOP", null);

            this.comboBox1.Items.Clear();

            //// Iterate over the rows of the DataTable
            foreach (DataRow row in dt.Rows)
            {
                // Get the value of the first (and only) column in the row
                string value = row[0].ToString();

                // Add the value to the Items collection of the ComboBox
                this.comboBox1.Items.Add(value);
            }

            //
            List<KeyValuePair<string, string>> para = new List<KeyValuePair<string, string>>();
            para.Add(new KeyValuePair<string, string>("@TDN", TDN));
            this.dataGridView2.DataSource = db.readFromProc("SP_SEL_PUBLIC_SV", para);
        }
        private void OpenStudentForm(List<string> datas)
        {
            datas.Add(TDN);
            datas.Add(mk);
            student st = new student(datas);
            st.mainForm = this;
            st.FormClosed += st_FormClosed;
            st.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
