namespace KebabNgon
{
    partial class Main_Staff
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
            DSNhanVien = new GroupBox();
            GridStaff = new DataGridView();
            panel2 = new Panel();
            textDiachi = new TextBox();
            label4 = new Label();
            btnReset = new Button();
            btnDel = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            textSearch = new TextBox();
            textSDT = new TextBox();
            textTen = new TextBox();
            textMaNV = new TextBox();
            Menu_DonGia = new Label();
            lbMaNV = new Label();
            lbMaHD = new Label();
            DSNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridStaff).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DSNhanVien
            // 
            DSNhanVien.Controls.Add(GridStaff);
            DSNhanVien.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DSNhanVien.Location = new Point(1, 218);
            DSNhanVien.Name = "DSNhanVien";
            DSNhanVien.Size = new Size(955, 452);
            DSNhanVien.TabIndex = 8;
            DSNhanVien.TabStop = false;
            DSNhanVien.Text = "Danh sách nhân viên";
            // 
            // GridStaff
            // 
            GridStaff.BackgroundColor = SystemColors.ButtonHighlight;
            GridStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridStaff.Dock = DockStyle.Fill;
            GridStaff.Location = new Point(3, 24);
            GridStaff.Name = "GridStaff";
            GridStaff.RowHeadersWidth = 51;
            GridStaff.RowTemplate.Height = 29;
            GridStaff.Size = new Size(949, 425);
            GridStaff.TabIndex = 0;
            GridStaff.CellClick += GridHoadon_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(textDiachi);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(textSearch);
            panel2.Controls.Add(textSDT);
            panel2.Controls.Add(textTen);
            panel2.Controls.Add(textMaNV);
            panel2.Controls.Add(Menu_DonGia);
            panel2.Controls.Add(lbMaNV);
            panel2.Controls.Add(lbMaHD);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(955, 212);
            panel2.TabIndex = 7;
            // 
            // textDiachi
            // 
            textDiachi.Location = new Point(427, 135);
            textDiachi.Name = "textDiachi";
            textDiachi.Size = new Size(368, 27);
            textDiachi.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(332, 138);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 12;
            label4.Text = "Địa Chỉ";
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
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGoldenrodYellow;
            btnSearch.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(287, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(22, 21);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Mời nhập tên nhân viên";
            textSearch.Size = new Size(259, 27);
            textSearch.TabIndex = 6;
            // 
            // textSDT
            // 
            textSDT.Location = new Point(427, 87);
            textSDT.Name = "textSDT";
            textSDT.Size = new Size(172, 27);
            textSDT.TabIndex = 5;
            // 
            // textTen
            // 
            textTen.Location = new Point(109, 135);
            textTen.Name = "textTen";
            textTen.Size = new Size(172, 27);
            textTen.TabIndex = 4;
            // 
            // textMaNV
            // 
            textMaNV.Location = new Point(109, 87);
            textMaNV.Name = "textMaNV";
            textMaNV.Size = new Size(172, 27);
            textMaNV.TabIndex = 3;
            // 
            // Menu_DonGia
            // 
            Menu_DonGia.AutoSize = true;
            Menu_DonGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Menu_DonGia.Location = new Point(332, 90);
            Menu_DonGia.Name = "Menu_DonGia";
            Menu_DonGia.Size = new Size(53, 20);
            Menu_DonGia.TabIndex = 2;
            Menu_DonGia.Text = "SĐT    ";
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaNV.Location = new Point(26, 138);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(46, 20);
            lbMaNV.TabIndex = 1;
            lbMaNV.Text = "Tên   ";
            // 
            // lbMaHD
            // 
            lbMaHD.AutoSize = true;
            lbMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHD.Location = new Point(26, 90);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(57, 20);
            lbMaHD.TabIndex = 0;
            lbMaHD.Text = "Mã NV";
            // 
            // Main_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 669);
            Controls.Add(DSNhanVien);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Staff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Staff";
            Load += Main_Staff_Load_1;
            DSNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridStaff).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DSNhanVien;
        private DataGridView GridStaff;
        private Panel panel2;
        private TextBox textDiachi;
        private Label label4;
        private Button btnReset;
        private Button btnDel;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox textSearch;
        private TextBox textSDT;
        private TextBox textTen;
        private TextBox textMaNV;
        private Label Menu_DonGia;
        private Label lbMaNV;
        private Label lbMaHD;
    }
}