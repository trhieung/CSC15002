using Lab4_QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lab4_QLSVNhom
{
    public partial class form_danhsachnhanvien : Form
    {
        private string username;
        private string password;
        //private int RSA_KeySize = 2048;
        //private RSACryptoServiceProvider rsa;
        private DataTable displayTable;
        public List<string> stringList { get; set; }

        public form_danhsachnhanvien(string username, string password)
        {
            InitializeComponent();

            this.username = username;
            this.password = password;

            DisplayComponent(username, password);
        }

        private void DisplayComponent(string username, string password)
        {
            //this.groupBox_thongtinnhanvienDisplay(username, password);
            this.refresh_dataGridView();
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

            this.textBox_hoten.ReadOnly = true;
            this.textBox_email.ReadOnly = true;
            this.textBox_luong.ReadOnly = true;
            this.textBox_manv.ReadOnly = true;
            this.textBox_matkhau.ReadOnly = true;
            this.textBox_username.ReadOnly = true;
        }

        private void refresh_dataGridView()
        {

            DataTable table = new DataTable();
            database db = new database();

            table.Columns.Add("MÃ NHÂN VIÊN", typeof(string));
            table.Columns.Add("HỌ TÊN", typeof(string));
            table.Columns.Add("EMAIL", typeof(string));
            table.Columns.Add("LƯƠNG", typeof(string));

            // input line
            int nRows = 13;
            int hRow = 23;
            int headerHeight = this.dataGridView_infor.ColumnHeadersHeight;
            this.dataGridView_infor.Size = new System.Drawing.Size(728, nRows * hRow + headerHeight);
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

        //private void button_ghi_luu_Click(object sender, EventArgs e)
        //{
        //    encrypt enc = new encrypt("20120083");

        //    // sha1 mat khau -> list index 6
        //    stringList.Add(enc.ewithHASH1(stringList[5]));

        //    // aes256 luong -> list index 7
        //    string cipher = enc._ewithAES(stringList[4]);
        //    stringList.Add(cipher);

        //    // save to database
        //    var db = new database("localhost", "1433", "QLSV");

        //    List<KeyValuePair<string, string>> para = new List<KeyValuePair<string, string>>();
        //    para.Add(new KeyValuePair<string, string>("@manv", stringList[0]));
        //    para.Add(new KeyValuePair<string, string>("@hoten", stringList[3]));
        //    para.Add(new KeyValuePair<string, string>("@email", stringList[1]));
        //    para.Add(new KeyValuePair<string, string>("@luong", stringList[7]));
        //    para.Add(new KeyValuePair<string, string>("@tendn", stringList[2]));
        //    para.Add(new KeyValuePair<string, string>("@matkhau", stringList[6]));

        //    if (db.updateThroughProc("SP_INS_ENCRYPT_NHANVIEN", para))
        //    {
        //        MessageBox.Show("save success");
        //    }
        //}

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

        private void button_select_Click(object sender, EventArgs e)
        {
            var db = new database("localhost", "1433", "QLSVNhomLab4");
            DataTable dt = db.readFromProc("SP_SEL_PUBLIC_ENCRYPT_ALL_NHANVIEN", null);
            displayTable = new DataTable();

            displayTable.Columns.Add("MÃ NHÂN VIÊN", typeof(string));
            displayTable.Columns.Add("HỌ TÊN", typeof(string));
            displayTable.Columns.Add("EMAIL", typeof(string));
            displayTable.Columns.Add("LƯƠNG", typeof(string));

            // Set the DataGridView's DataSource to null to allow rows to be cleared
            dataGridView_infor.DataSource = null;

            foreach (DataRow row in dt.Rows)
            {
                string x = row[0].ToString();
                // Add the row to the DataGridView
                displayTable.Rows.Add(row[0].ToString(), row[1].ToString(), row[3].ToString(), "");
            }

            this.dataGridView_infor.DataSource = displayTable;

            // decrypt role
            encrypt enc = new encrypt();

            // Open a OpenFileDialog to select the private key file
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = Path.GetFileName(openFileDialog.FileName);
                int startIndex = "privatekey".Length; // the index of the first character of manv
                int length = filename.LastIndexOf(".xml") - startIndex; // the length of manv
                string manv = filename.Substring(startIndex, length); // extract the manv substring

                // Load the private key from the XML file
                string privateKeyXml = File.ReadAllText(openFileDialog.FileName);
                enc.rsa.FromXmlString(privateKeyXml);

                // get ciphertext and row display
                int rowidx = 0;
                string ciphertext = "hello";
                foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == manv)
                    {
                        ciphertext = row[2].ToString();
                        break;
                    }
                    rowidx++;
                }

                // if rowidx out rang-> handle it :v

                // Get the encrypted text from the textbox
                string encryptedText = ciphertext;

                // Convert the encrypted text back to bytes
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

                // Decrypt the bytes using the private key
                byte[] decryptedBytes = enc.rsa.Decrypt(encryptedBytes, false);

                // Convert the decrypted bytes to a string
                string decryptedText = System.Text.Encoding.UTF8.GetString(decryptedBytes);

                // display
                dataGridView_infor.Rows[rowidx].Cells[3].Value = decryptedText;
            }

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.refresh_dataGridView();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> ls = new List<KeyValuePair<string, string>>();

            //generateRSAKey(manv);
            ls = getDataThenEncFromInsGroupbox();

            // save to database
            var db = new database("localhost", "1433", "QLSVNhomLab4");

            if (db.updateThroughProc("SP_INS_PUBLIC_ENCRYPT_NHANVIEN", ls))
            {
                MessageBox.Show("save success");
            }
        }

        private List<KeyValuePair<string, string>> getDataThenEncFromInsGroupbox()
        {
            List<KeyValuePair<string, string>> ls = new List<KeyValuePair<string, string>>();
            encrypt enc = new encrypt();
            string pub = enc.generateRSAKey(this.textBox_manv_ins.Text);
            string enc_luong = enc.encryptLuong(this.textBox_luong_ins.Text);

            ls.Add(new KeyValuePair<string, string>("@manv", this.textBox_manv_ins.Text));
            ls.Add(new KeyValuePair<string, string>("@hoten", this.textBox_hoten_ins.Text));
            ls.Add(new KeyValuePair<string, string>("@email", this.textBox_email_ins.Text));
            ls.Add(new KeyValuePair<string, string>("@luong", enc_luong));
            ls.Add(new KeyValuePair<string, string>("@tendn", this.textBox_username_ins.Text));
            ls.Add(new KeyValuePair<string, string>("@mk", enc.ewithHASH1(this.textBox_matkhau_ins.Text)));
            ls.Add(new KeyValuePair<string, string>("@pub", pub));

            //string dec = enc.decryptLuong(enc_luong);

            return ls;
        }

        private void button_login_Click(object sender, EventArgs e)
        {

        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            encrypt enc = new encrypt();

            username = textBox_username_login.Text;
            password = textBox_matkhau_login.Text;


            database db = new database("localhost", "1433", "QLSVNhomLab4");
            if (db.Connect(username, enc.ewithHASH1(password)))
            {
                MessageBox.Show(this, "Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.groupBox_login.SendToBack();
                this.groupBox2Display(username, enc.ewithHASH1(password));
            }
            else
            {
                MessageBox.Show(this, "Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void groupBox2Display(string username, string password)
        {
            // save to database
            var db = new database("localhost", "1433", "QLSVNhomLab4");

            List<KeyValuePair<string, string>> para = new List<KeyValuePair<string, string>>();
            para.Add(new KeyValuePair<string, string>("@TENDN", username));
            para.Add(new KeyValuePair<string, string>("@MK", password));

            encrypt enc = new encrypt();
            DataTable dataTable = new DataTable();
            dataTable = db.readFromProc("SP_SEL_PUBLIC_ENCRYPT_NHANVIEN", para);

            foreach (DataRow row in dataTable.Rows)
            {
                this.textBox_luong_tab2.Text = enc.decryptLuong(row["LUONG"].ToString());
                this.textBox_manv_tab2.Text = row["MANV"].ToString();
                this.textBox_hoten_tab2.Text = row["HOTEN"].ToString();
                this.textBox_email_tab2.Text = row["EMAIL"].ToString();
                this.textBox_username_tab2.Text = username;
                this.textBox_matkhau_tab2.Text = new string('*', 8);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            encrypt enc = new encrypt();
            this.groupBox2Display("NV06", enc.ewithHASH1("NV06"));
        }
    }
}

