using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KebabNgon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void butsign_in_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection ql = new SqlConnection(@"Data Source=HIEUDEPZAI;Initial Catalog=kebabngon;Integrated Security=True");
                ql.Open();
                string sql = "SELECT * FROM Account WHERE username=@username AND CONVERT(char, CONVERT(varchar(100), DECRYPTBYPASSPHRASE('Pass', [Encrypted Pass]))) = @password";
                SqlCommand cmd = new SqlCommand(sql, ql);
                cmd.Parameters.AddWithValue("@username", textusername.Text);
                cmd.Parameters.AddWithValue("@password", textpassword.Text);
         
                string tk = textusername.Text;
                string mk = textpassword.Text;
                string sql1 = "select * from Account where username='" + tk + "' and CONVERT(char, CONVERT(varchar(100), DECRYPTBYPASSPHRASE('Pass', [Encrypted Pass]))) = '" + mk + "' ";
                SqlCommand cmd1 = new SqlCommand(sql1, ql);
                SqlDataReader dta = cmd1.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    New_Main_Manager f = new New_Main_Manager();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void butexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản Lý Quán Cafe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}





