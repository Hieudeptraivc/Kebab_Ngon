namespace KebabNgon
{
    partial class Main_ImportProduce_Details
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
            DSHoaDon = new GroupBox();
            GridBill_Import_Details = new DataGridView();
            panel2 = new Panel();
            textSearch = new TextBox();
            btnSearch = new Button();
            btnReset = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            textTongtien = new TextBox();
            label6 = new Label();
            textSoluong = new TextBox();
            label7 = new Label();
            textMaHD = new TextBox();
            textMaDDH = new TextBox();
            lbMaNV = new Label();
            lbMaHD = new Label();
            DSHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridBill_Import_Details).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DSHoaDon
            // 
            DSHoaDon.Controls.Add(GridBill_Import_Details);
            DSHoaDon.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DSHoaDon.Location = new Point(0, 244);
            DSHoaDon.Name = "DSHoaDon";
            DSHoaDon.Size = new Size(956, 425);
            DSHoaDon.TabIndex = 11;
            DSHoaDon.TabStop = false;
            DSHoaDon.Text = "Danh sách chi tiết hóa đơn nhập hàng";
            // 
            // GridBill_Import_Details
            // 
            GridBill_Import_Details.BackgroundColor = SystemColors.ButtonHighlight;
            GridBill_Import_Details.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridBill_Import_Details.Dock = DockStyle.Fill;
            GridBill_Import_Details.Location = new Point(3, 24);
            GridBill_Import_Details.Name = "GridBill_Import_Details";
            GridBill_Import_Details.RowHeadersWidth = 51;
            GridBill_Import_Details.RowTemplate.Height = 29;
            GridBill_Import_Details.Size = new Size(950, 398);
            GridBill_Import_Details.TabIndex = 0;
            GridBill_Import_Details.CellClick += GridBill_Import_Details_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(textSearch);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(textTongtien);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textSoluong);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textMaHD);
            panel2.Controls.Add(textMaDDH);
            panel2.Controls.Add(lbMaNV);
            panel2.Controls.Add(lbMaHD);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(956, 238);
            panel2.TabIndex = 10;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(40, 21);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Mời nhập mã hàng đặt ";
            textSearch.Size = new Size(259, 27);
            textSearch.TabIndex = 24;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGoldenrodYellow;
            btnSearch.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(310, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 29);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 128, 128);
            btnReset.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(844, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(79, 44);
            btnReset.TabIndex = 29;
            btnReset.Text = "Reset ";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.LightGoldenrodYellow;
            btnDel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.Location = new Point(734, 12);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(79, 44);
            btnDel.TabIndex = 28;
            btnDel.Text = "Xóa ";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGoldenrodYellow;
            btnAdd.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(514, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 44);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGoldenrodYellow;
            btnUpdate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(624, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 44);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Sửa ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textTongtien
            // 
            textTongtien.Location = new Point(410, 146);
            textTongtien.Name = "textTongtien";
            textTongtien.ReadOnly = true;
            textTongtien.Size = new Size(172, 27);
            textTongtien.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(310, 149);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 22;
            label6.Text = "Tổng TIền ";
            // 
            // textSoluong
            // 
            textSoluong.Location = new Point(410, 93);
            textSoluong.Name = "textSoluong";
            textSoluong.Size = new Size(172, 27);
            textSoluong.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(310, 96);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 20;
            label7.Text = "Số Lượng             ";
            // 
            // textMaHD
            // 
            textMaHD.Location = new Point(127, 145);
            textMaHD.Name = "textMaHD";
            textMaHD.Size = new Size(172, 27);
            textMaHD.TabIndex = 4;
            // 
            // textMaDDH
            // 
            textMaDDH.Location = new Point(127, 93);
            textMaDDH.Name = "textMaDDH";
            textMaDDH.Size = new Size(172, 27);
            textMaDDH.TabIndex = 3;
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaNV.Location = new Point(12, 148);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(101, 20);
            lbMaNV.TabIndex = 1;
            lbMaNV.Text = "Mã Hàng Đặt";
            // 
            // lbMaHD
            // 
            lbMaHD.AutoSize = true;
            lbMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHD.Location = new Point(12, 96);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(65, 20);
            lbMaHD.TabIndex = 0;
            lbMaHD.Text = "Mã HĐ  ";
            // 
            // Main_ImportProduce_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 669);
            Controls.Add(DSHoaDon);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_ImportProduce_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_ImportProduce_Details";
            Load += Main_ImportProduce_Details_Load;
            DSHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridBill_Import_Details).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DSHoaDon;
        private DataGridView GridBill_Import_Details;
        private Panel panel2;
        private TextBox textMaHD;
        private TextBox textMaDDH;
        private Label lbMaNV;
        private Label lbMaHD;
        private TextBox textTongtien;
        private Label label6;
        private TextBox textSoluong;
        private Label label7;
        private TextBox textSearch;
        private Button btnSearch;
        private Button btnReset;
        private Button btnDel;
        private Button btnAdd;
        private Button btnUpdate;
    }
}