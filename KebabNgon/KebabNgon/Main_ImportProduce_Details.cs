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
    public partial class Main_ImportProduce_Details : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HIEUDEPZAI;Initial Catalog=kebabngon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadImportPro_Details_List()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from DatChiTiet";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridBill_Import_Details.DataSource = table;

        }
        public Main_ImportProduce_Details()
        {
            InitializeComponent();
        }

        private void Main_ImportProduce_Details_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadImportPro_Details_List();
        }

        private void GridBill_Import_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            textTongtien.ReadOnly = true;
            if (GridBill_Import_Details.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridBill_Import_Details.CurrentRow.Selected = true;
                textMaDDH.Text = GridBill_Import_Details.Rows[e.RowIndex].Cells["MaDDH"].Value.ToString();
                textMaHD.Text = GridBill_Import_Details.Rows[e.RowIndex].Cells["MaHangDat"].Value.ToString();
                textSoluong.Text = GridBill_Import_Details.Rows[e.RowIndex].Cells["Soluong"].Value.ToString();
                textTongtien.Text = GridBill_Import_Details.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from DatChiTiet where MaHangDat like N'%" + textSearch.Text.Trim() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GridBill_Import_Details.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into DatChiTiet(MaDDH,MaHangDat,Soluong) values('" + textMaDDH.Text + "','" + textMaHD.Text + "','" + textSoluong.Text + "')";
            command.ExecuteNonQuery();
            LoadImportPro_Details_List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update DatChiTiet set MaDDH = '" + textMaDDH.Text + "', Soluong = '" + textSoluong.Text + "'  where MaHangDat = '" + textMaHD.Text + "'";
            command.ExecuteNonQuery();
            LoadImportPro_Details_List();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from DatChiTiet where MaHangDat = ('" + textMaHD.Text + "')";
            command.ExecuteNonQuery();
            LoadImportPro_Details_List();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadImportPro_Details_List();
            textMaHD.ReadOnly = false;
            textMaDDH.Text = "";
            textMaHD.Text = "";
            textSoluong.Text = "";
            textTongtien.Text = "";





        }
    }
}
