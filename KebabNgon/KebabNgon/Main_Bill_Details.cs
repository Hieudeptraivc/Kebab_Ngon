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
    public partial class Main_Bill_Details : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HIEUDEPZAI;Initial Catalog=kebabngon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadBillDetailsList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from XuatChiTiet";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridBill_Details.DataSource = table;

        }
        public Main_Bill_Details()
        {
            InitializeComponent();
        }

        private void GridBill_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            textTongtien.ReadOnly = true;

            if (GridBill_Details.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridBill_Details.CurrentRow.Selected = true;
                textMaHD.Text = GridBill_Details.Rows[e.RowIndex].Cells["MaHDX"].Value.ToString();
                textMaHang.Text = GridBill_Details.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
                textSoluong.Text = GridBill_Details.Rows[e.RowIndex].Cells["Soluong"].Value.ToString();
                textTongtien.Text = GridBill_Details.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();

            }
        }

        private void Main_Bill_Details_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadBillDetailsList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from XuatChiTiet where MaHDX like N'%" + textSearch.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridBill_Details.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into XuatChiTiet values('" + textMaHD.Text + "','" + textMaHang.Text + "','" + textSoluong.Text + "','" + textTongtien.Text + "')";
            command.ExecuteNonQuery();
            LoadBillDetailsList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update XuatChiTiet set Soluong = '" + textSoluong.Text + "',MaHang = '" + textMaHang.Text + "' where  MaHDX = '" + textMaHD.Text + "' and MaHang = '" + textMaHang.Text + "'";
            command.ExecuteNonQuery();
            LoadBillDetailsList();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from XuatChiTiet where MaHDX = ('" + textMaHD.Text + "') and MaHang = '" + textMaHang.Text + "' ";
            command.ExecuteNonQuery();
            LoadBillDetailsList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadBillDetailsList();
            textMaHD.ReadOnly = false;
            textMaHang.ReadOnly = false;
            textMaHD.Text = "";
            textMaHang.Text = "";
            textSoluong.Text = "";
            textTongtien.Text = "";
        }
    }
}
