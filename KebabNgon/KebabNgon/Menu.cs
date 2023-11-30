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
    public partial class Menu : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HIEUDEPZAI;Initial Catalog=kebabngon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadMenuList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Menu";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridMenu.DataSource = table;

        }
        public Menu()
        {
            InitializeComponent();
        }

        private void GridMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaMon.ReadOnly = true;
            if (GridMenu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridMenu.CurrentRow.Selected = true;
                textMaMon.Text = GridMenu.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
                textTenMon.Text = GridMenu.Rows[e.RowIndex].Cells["TenHang"].Value.ToString();
                textDonGia.Text = GridMenu.Rows[e.RowIndex].Cells["Dongia"].Value.ToString();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadMenuList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Menu values('" + textMaMon.Text + "','" + textTenMon.Text + "','" + textDonGia.Text + "')";
            command.ExecuteNonQuery();
            LoadMenuList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Menu set TenHang = '" + textTenMon.Text + "',Dongia = '" + textDonGia.Text + "' where MaHang = '" + textMaMon.Text + "'";
            command.ExecuteNonQuery();
            LoadMenuList();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Menu where MaHang = ('" + textMaMon.Text + "')";
            command.ExecuteNonQuery();
            LoadMenuList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadMenuList();
            textMaMon.ReadOnly = false;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                string query = "select dbo.fADDProduct()";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                string sal = Convert.ToString(cmd.ExecuteScalar());
                textMaMon.Text = sal;
                textTenMon.Text = "";
                textDonGia.Text = "";
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Menu where TenHang  like N'%" + textSearch.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridMenu.DataSource = table;
        }
    }
}
