using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_QLSV
{
    public partial class form_danhsachnhanvien : Form
    {
        private string username;
        private string password;
        public List<string> stringList { get; set; }

        public form_danhsachnhanvien(string username, string password)
        {
            InitializeComponent();

            this.username = username;
            this.password = password;

            DisplayComponent(username, password);
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            nhanvien_infor nv_infor = new nhanvien_infor();

            // Show Form2 as a modal dialog and wait for it to be closed
            DialogResult result = nv_infor.ShowDialog();

            // Check if the dialog was closed with the OK button
            if (result == DialogResult.Cancel)
            {
                // Get the list of strings from Form2 and assign it to the private field
                stringList = nv_infor.datas;
                this.update_dataGridView(stringList);

            }
        }
        
        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel_button_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_infor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_ghi_luu_Click(object sender, EventArgs e)
        {
            encrypt enc = new encrypt("20120083");

            // sha1 mat khau -> list index 6
            stringList.Add(enc.ewithHASH1(stringList[5]));

            // aes256 luong -> list index 7
            string cipher = enc._ewithAES(stringList[4]);
            stringList.Add(cipher);

            // save to database
            var db = new database("localhost", "1433", "QLSV");

            List<KeyValuePair<string, string>> para = new List<KeyValuePair<string, string>>();
            para.Add(new KeyValuePair<string, string>("@manv", stringList[0]));
            para.Add(new KeyValuePair<string, string>("@hoten", stringList[3]));
            para.Add(new KeyValuePair<string, string>("@email", stringList[1]));
            para.Add(new KeyValuePair<string, string>("@luong", stringList[7]));
            para.Add(new KeyValuePair<string, string>("@tendn", stringList[2]));
            para.Add(new KeyValuePair<string, string>("@matkhau", stringList[6]));

            if (db.updateThroughProc("SP_INS_ENCRYPT_NHANVIEN", para))
            {
                MessageBox.Show("save success");
            }
        }

        private void update_dataGridView(List<string> ls)
        {
            foreach (DataGridViewRow row in dataGridView_infor.Rows)
            {
                bool emptyRow = true;

                // Check if all cells in the row are empty
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string x = cell.Value?.ToString();

                    if (!string.IsNullOrEmpty(x))
                    {
                        emptyRow = false;
                        break;
                    }
                }

                // If the row is empty, add the string list to it
                if (emptyRow)
                {                    
                    row.Cells[0].Value = ls[0];
                    row.Cells[1].Value = ls[3];
                    row.Cells[2].Value = ls[1];
                    row.Cells[3].Value = ls[4];

                    break; // exit the loop once the first empty row is found
                }
            }
        }
    
    }
}