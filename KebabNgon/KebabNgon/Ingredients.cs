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
    public partial class Ingredients : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HIEUDEPZAI;Initial Catalog=kebabngon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadHangNV()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HangDat";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridHD.DataSource = table;

        }
        public Ingredients()
        {
            InitializeComponent();
        }

        private void GridHangDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaHD.ReadOnly = true;
            if (GridHD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridHD.CurrentRow.Selected = true;
                textMaHD.Text = GridHD.Rows[e.RowIndex].Cells["MaHangDat"].Value.ToString();
                textTenHD.Text = GridHD.Rows[e.RowIndex].Cells["TenHangDat"].Value.ToString();
                textDG.Text = GridHD.Rows[e.RowIndex].Cells["Dongia"].Value.ToString();
                textDC.Text = GridHD.Rows[e.RowIndex].Cells["DiachiNCC"].Value.ToString();
                textSDT.Text = GridHD.Rows[e.RowIndex].Cells["SDT_NCC"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HangDat where TenHangDat like N'%" + textSearch.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridHD.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HangDat values('" + textMaHD.Text + "','" + textTenHD.Text + "','" + textDC.Text + "','" + textSDT.Text + "','" + textDG.Text + "')";
            command.ExecuteNonQuery();
            LoadHangNV();
        }


        private void Ingredients_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadHangNV();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HangDat where MaHangDat = ('" + textMaHD.Text + "')";
            command.ExecuteNonQuery();
            LoadHangNV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HangDat set TenHangDat = '" + textTenHD.Text + "',DiachiNCC = '" + textDC.Text + "', SDT_NCC = '" + textSDT.Text + "',Dongia = '" + textDG.Text + "' where MaHangDat = '" + textMaHD.Text + "'";
            command.ExecuteNonQuery();
            LoadHangNV();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadHangNV();
            textMaHD.ReadOnly = false;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                string query = "select dbo.fADD_HangDat()";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                string sal = Convert.ToString(cmd.ExecuteScalar());
                textMaHD.Text = sal;
                textTenHD.Text = "";
                textDC.Text = "";
                textDG.Text = "";
                textSDT.Text = "";
            }
        }
    }
}
