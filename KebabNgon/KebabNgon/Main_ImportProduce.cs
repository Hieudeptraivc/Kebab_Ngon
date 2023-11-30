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
    public partial class Main_ImportProduce : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HIEUDEPZAI;Initial Catalog=kebabngon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadImportProList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Dat";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridBill_Import.DataSource = table;

        }
        public Main_ImportProduce()
        {
            InitializeComponent();
        }

        private void GridBill_Import_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaHD.ReadOnly = true;
            textTongTien.ReadOnly = true;
            textChietkhau.ReadOnly = true;
            if (GridBill_Import.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridBill_Import.CurrentRow.Selected = true;
                textMaHD.Text = GridBill_Import.Rows[e.RowIndex].Cells["MaDDH"].Value.ToString();
                textMaNV.Text = GridBill_Import.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                textChietkhau.Text = GridBill_Import.Rows[e.RowIndex].Cells["Chietkhau"].Value.ToString();
                textTime.Text = GridBill_Import.Rows[e.RowIndex].Cells["NgayDat"].Value.ToString();
                textTongTien.Text = GridBill_Import.Rows[e.RowIndex].Cells["TongTienHang"].Value.ToString();

            }
        }

        private void Main_ImportProduce_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadImportProList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Dat where MaDDH like N'%" + textSearch.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridBill_Import.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Dat values('" + textMaHD.Text + "','" + textMaNV.Text + "','" + textTime.Text + "','" + textChietkhau.Text + "','" + textTongTien.Text + "')";
            command.ExecuteNonQuery();
            LoadImportProList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Dat set MaNV = '" + textMaNV.Text + "',NgayDat = '" + textTime.Text + "',Chietkhau = '" + textChietkhau.Text + "'  where MaDDH = '" + textMaHD.Text + "'";
            command.ExecuteNonQuery();
            LoadImportProList();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Dat where MaDDH = ('" + textMaHD.Text + "')";
            command.ExecuteNonQuery();
            LoadImportProList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadImportProList();
            textMaHD.ReadOnly = false;
            textTongTien.ReadOnly = true;
            textChietkhau.ReadOnly = true;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                string query = "select dbo.fADDImport()";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                string sal = Convert.ToString(cmd.ExecuteScalar());
                textMaHD.Text = sal;
                textMaNV.Text = "";
                textTime.Text = "";
                textChietkhau.Text = "";
                textTongTien.Text = "";
            }

        }
    }
}
