using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KebabNgon
{
    public partial class Main_Account : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HIEUDEPZAI;Initial Catalog=kebabngon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadAccountList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select username, CONVERT(char, CONVERT(varchar(100), DECRYPTBYPASSPHRASE('Pass', [Encrypted Pass]))) as Pass from Account";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridAccount.DataSource = table;
        }
        public Main_Account()
        {
            InitializeComponent();
            this.GridAccount.DataError += this.GridAccount_DataError;
        }


        private void Main_Account_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadAccountList();
        }

        private void GridAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textUsername.ReadOnly = true;
            if (GridAccount.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridAccount.CurrentRow.Selected = true;
                textUsername.Text = GridAccount.Rows[e.RowIndex].Cells["username"].Value.ToString();
                textPassword.Text = GridAccount.Rows[e.RowIndex].Cells["pass"].Value.ToString();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Insert into Account (username, [Encrypted Pass]) values ('" + textUsername.Text + "', ENCRYPTBYPASSPHRASE('Pass', '" + textPassword.Text + "'))";
            command.ExecuteNonQuery();
            LoadAccountList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE Account SET [Encrypted Pass] = ENCRYPTBYPASSPHRASE('Pass', '" + textPassword.Text + "') WHERE username = '" + textUsername.Text + "' ";
            command.ExecuteNonQuery();
            LoadAccountList();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Account where username = '" + textUsername.Text + "'";
            command.ExecuteNonQuery();
            LoadAccountList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadAccountList();
            textUsername.ReadOnly = false;
            textUsername.Text = "";
            textPassword.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Account where username like N'%" + textSearch.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridAccount.DataSource = table;
        }

        private void GridAccount_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
