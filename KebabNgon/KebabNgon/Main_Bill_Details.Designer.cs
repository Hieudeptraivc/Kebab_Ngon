namespace KebabNgon
{
    partial class Main_Bill_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DSHoaDon_Chitiet = new GroupBox();
            GridBill_Details = new DataGridView();
            panel2 = new Panel();
            textTongtien = new TextBox();
            textSearch = new TextBox();
            btnSearch = new Button();
            textMaHD = new TextBox();
            lbMaHD = new Label();
            btnReset = new Button();
            label4 = new Label();
            btnDel = new Button();
            lbMaNV = new Label();
            btnAdd = new Button();
            Menu_DonGia = new Label();
            btnUpdate = new Button();
            textSoluong = new TextBox();
            textMaHang = new TextBox();
            DSHoaDon_Chitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridBill_Details).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DSHoaDon_Chitiet
            // 
            DSHoaDon_Chitiet.Controls.Add(GridBill_Details);
            DSHoaDon_Chitiet.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DSHoaDon_Chitiet.Location = new Point(0, 203);
            DSHoaDon_Chitiet.Name = "DSHoaDon_Chitiet";
            DSHoaDon_Chitiet.Size = new Size(956, 468);
            DSHoaDon_Chitiet.TabIndex = 8;
            DSHoaDon_Chitiet.TabStop = false;
            DSHoaDon_Chitiet.Text = "Danh sách chi tiết hóa đơn";
            // 
            // GridBill_Details
            // 
            GridBill_Details.BackgroundColor = SystemColors.ButtonHighlight;
            GridBill_Details.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridBill_Details.Dock = DockStyle.Fill;
            GridBill_Details.Location = new Point(3, 24);
            GridBill_Details.Name = "GridBill_Details";
            GridBill_Details.RowHeadersWidth = 51;
            GridBill_Details.RowTemplate.Height = 29;
            GridBill_Details.Size = new Size(950, 441);
            GridBill_Details.TabIndex = 0;
            GridBill_Details.CellClick += GridBill_Details_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(textTongtien);
            panel2.Controls.Add(textSearch);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(textMaHD);
            panel2.Controls.Add(lbMaHD);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(lbMaNV);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(Menu_DonGia);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(textSoluong);
            panel2.Controls.Add(textMaHang);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(956, 197);
            panel2.TabIndex = 7;
            // 
            // textTongtien
            // 
            textTongtien.Location = new Point(427, 135);
            textTongtien.Name = "textTongtien";
            textTongtien.ReadOnly = true;
            textTongtien.Size = new Size(172, 27);
            textTongtien.TabIndex = 15;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(22, 21);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Mời nhập mã hóa đơn ";
            textSearch.Size = new Size(259, 27);
            textSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGoldenrodYellow;
            btnSearch.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(292, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textMaHD
            // 
            textMaHD.Location = new Point(109, 87);
            textMaHD.Name = "textMaHD";
            textMaHD.Size = new Size(172, 27);
            textMaHD.TabIndex = 3;
            // 
            // lbMaHD
            // 
            lbMaHD.AutoSize = true;
            lbMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHD.Location = new Point(26, 90);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(77, 20);
            lbMaHD.TabIndex = 0;
            lbMaHD.Text = "Mã HĐ     ";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 128, 128);
            btnReset.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(826, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(79, 44);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset ";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(332, 138);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 12;
            label4.Text = "Tổng Tiền ";
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.LightGoldenrodYellow;
            btnDel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.Location = new Point(716, 12);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(79, 44);
            btnDel.TabIndex = 10;
            btnDel.Text = "Xóa ";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaNV.Location = new Point(26, 138);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(72, 20);
            lbMaNV.TabIndex = 1;
            lbMaNV.Text = "Mã Hàng";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGoldenrodYellow;
            btnAdd.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(496, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 44);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Menu_DonGia
            // 
            Menu_DonGia.AutoSize = true;
            Menu_DonGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Menu_DonGia.Location = new Point(332, 90);
            Menu_DonGia.Name = "Menu_DonGia";
            Menu_DonGia.Size = new Size(75, 20);
            Menu_DonGia.TabIndex = 2;
            Menu_DonGia.Text = "Số Lượng";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGoldenrodYellow;
            btnUpdate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(606, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 44);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Sửa ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textSoluong
            // 
            textSoluong.Location = new Point(427, 87);
            textSoluong.Name = "textSoluong";
            textSoluong.Size = new Size(172, 27);
            textSoluong.TabIndex = 5;
            // 
            // textMaHang
            // 
            textMaHang.Location = new Point(109, 135);
            textMaHang.Name = "textMaHang";
            textMaHang.Size = new Size(172, 27);
            textMaHang.TabIndex = 4;
            // 
            // Main_Bill_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 669);
            Controls.Add(DSHoaDon_Chitiet);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Bill_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Bill_Details";
            Load += Main_Bill_Details_Load;
            DSHoaDon_Chitiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridBill_Details).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DSHoaDon_Chitiet;
        private DataGridView GridBill_Details;
        private Panel panel2;
        private TextBox textTongtien;
        private Label label4;
        private TextBox textSoluong;
        private TextBox textMaHang;
        private TextBox textMaHD;
        private Label Menu_DonGia;
        private Label lbMaNV;
        private Label lbMaHD;
        private TextBox textSearch;
        private Button btnSearch;
        private Button btnReset;
        private Button btnDel;
        private Button btnAdd;
        private Button btnUpdate;
    }
}