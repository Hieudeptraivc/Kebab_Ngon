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
    public partial class Main_Staff : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HIEUDEPZAI;Initial Catalog=kebabngon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadStaffList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhanVien ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridStaff.DataSource = table;

        }
        public Main_Staff()
        {
            InitializeComponent();
        }


        private void GridHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaNV.ReadOnly = true;
            if (GridStaff.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridStaff.CurrentRow.Selected = true;
                textMaNV.Text = GridStaff.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();

                textSDT.Text = GridStaff.Rows[e.RowIndex].Cells["SDT_NV"].Value.ToString();
                textTen.Text = GridStaff.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
                textDiachi.Text = GridStaff.Rows[e.RowIndex].Cells["DiachiNV"].Value.ToString();


            }
        }

        private void Main_Staff_Load_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadStaffList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhanVien where TenNV like N'%" + textSearch.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridStaff.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into NhanVien values('" + textMaNV.Text + "','" + textTen.Text + "','" + textSDT.Text + "','" + textDiachi.Text + "')";
            command.ExecuteNonQuery();
            LoadStaffList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NhanVien set TenNV = '" + textTen.Text + "', SDT_NV = '" + textSDT.Text + "',DiachiNV = '" + textDiachi.Text + "' where MaNV = '" + textMaNV.Text + "'";
            command.ExecuteNonQuery();
            LoadStaffList();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NhanVien where MaNV = ('" + textMaNV.Text + "')";
            command.ExecuteNonQuery();
            LoadStaffList();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadStaffList();
            textMaNV.ReadOnly = false;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                string query = "select dbo.fAddStaff()";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                string sal = Convert.ToString(cmd.ExecuteScalar());
                textMaNV.Text = sal;
                textTen.Text = "";
                textSDT.Text = "";
                textDiachi.Text = "";
            }

        }
    }
}
