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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KebabNgon
{
    public partial class Main_Customer : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HIEUDEPZAI;Initial Catalog=kebabngon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadCustomerList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridCustomer.DataSource = table;

        }
        public Main_Customer()
        {
            InitializeComponent();
        }

        private void Main_Customer_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadCustomerList();
        }

        private void GridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaKH.ReadOnly = true;
            if (GridCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridCustomer.CurrentRow.Selected = true;
                textMaKH.Text = GridCustomer.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                textTenKH.Text = GridCustomer.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
                textDiachiKH.Text = GridCustomer.Rows[e.RowIndex].Cells["DiachiKH"].Value.ToString();


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang where MaKH like N'%" + textSearch.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridCustomer.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into KhachHang values('" + textMaKH.Text + "','" + textTenKH.Text + "','" + textDiachiKH.Text + "')";
            command.ExecuteNonQuery();
            LoadCustomerList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KhachHang set TenKH = '" + textTenKH.Text + "',DiachiKH = '" + textDiachiKH.Text + "' where MaKH = '" + textMaKH.Text + "'";
            command.ExecuteNonQuery();
            LoadCustomerList();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from KhachHang where MaKH = ('" + textMaKH.Text + "')";
            command.ExecuteNonQuery();
            LoadCustomerList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
            textMaKH.ReadOnly = false;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                string query = "select dbo.fADDCus()";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                string sal = Convert.ToString(cmd.ExecuteScalar());
                textMaKH.Text = sal;
                textTenKH.Text = "";
                textDiachiKH.Text = "";
            }

        }
    }
}
