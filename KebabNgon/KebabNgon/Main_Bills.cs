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
    public partial class Main_Bills : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HIEUDEPZAI;Initial Catalog=kebabngon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadHoaDonList()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Xuat";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridHoadon.DataSource = table;

        }
        public Main_Bills()
        {
            InitializeComponent();
        }

        private void GridHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaHD.ReadOnly = true;
            textChietkhau.ReadOnly = true;
            textTongTien.ReadOnly = true;
            if (GridHoadon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridHoadon.CurrentRow.Selected = true;
                textMaHD.Text = GridHoadon.Rows[e.RowIndex].Cells["MaHDX"].Value.ToString();
                textMaKH.Text = GridHoadon.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                textMaNV.Text = GridHoadon.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                textChietkhau.Text = GridHoadon.Rows[e.RowIndex].Cells["Chietkhau"].Value.ToString();
                textTime.Text = GridHoadon.Rows[e.RowIndex].Cells["NgayGio"].Value.ToString();
                textTongTien.Text = GridHoadon.Rows[e.RowIndex].Cells["TongTienHang"].Value.ToString();

            }
        }

        private void Main_Bills_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadHoaDonList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Xuat where MaHDX like N'%" + textSearch.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridHoadon.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Xuat values('" + textMaHD.Text + "','" + textMaKH.Text + "','" + textMaNV.Text + "','" + textTime.Text + "','" + textChietkhau.Text + "','" + textTongTien.Text + "')";
            command.ExecuteNonQuery();
            LoadHoaDonList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Xuat set MaKH = '" + textMaKH.Text + "',MaNV = '" + textMaNV.Text + "',NgayGio = '" + textTime.Text + "',Chietkhau = '" + textChietkhau.Text + "',TongTienHang = '" + textTongTien.Text + "' where MaHDX = '" + textMaHD.Text + "'";
            command.ExecuteNonQuery();
            LoadHoaDonList();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Xuat where MaHDX = ('" + textMaHD.Text + "')";
            command.ExecuteNonQuery();
            LoadHoaDonList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadHoaDonList();
            textMaHD.ReadOnly = false;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                string query = "select dbo.fADDExport()";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                string sal = Convert.ToString(cmd.ExecuteScalar());
                textMaHD.Text = sal;
                textMaKH.Text = "";
                textMaNV.Text = "";
                textTime.Text = "";
                textChietkhau.Text = "";
                textTongTien.Text = "";
            }
        }
    }
}
