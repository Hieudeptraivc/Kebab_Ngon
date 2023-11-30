namespace KebabNgon
{
    partial class Ingredients
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
            panel2 = new Panel();
            label3 = new Label();
            textDG = new TextBox();
            label1 = new Label();
            textSDT = new TextBox();
            btnReset = new Button();
            label2 = new Label();
            btnDel = new Button();
            Menu_TenMon = new Label();
            btnUpdate = new Button();
            Menu_DonGia = new Label();
            btnAdd = new Button();
            textMaHD = new TextBox();
            textTenHD = new TextBox();
            btnSearch = new Button();
            textDC = new TextBox();
            textSearch = new TextBox();
            DanhsachNguyenlieu = new GroupBox();
            GridHD = new DataGridView();
            panel2.SuspendLayout();
            DanhsachNguyenlieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridHD).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textDG);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textSDT);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(Menu_TenMon);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(Menu_DonGia);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(textMaHD);
            panel2.Controls.Add(textTenHD);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(textDC);
            panel2.Controls.Add(textSearch);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 198);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(623, 93);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 14;
            label3.Text = "Đơn Giá";
            // 
            // textDG
            // 
            textDG.Location = new Point(714, 90);
            textDG.Name = "textDG";
            textDG.Size = new Size(172, 27);
            textDG.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(332, 141);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 12;
            label1.Text = "SĐT";
            // 
            // textSDT
            // 
            textSDT.Location = new Point(426, 138);
            textSDT.Name = "textSDT";
            textSDT.Size = new Size(172, 27);
            textSDT.TabIndex = 13;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 128, 128);
            btnReset.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(826, 11);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(79, 44);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset ";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Hàng Nhập";
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.LightGoldenrodYellow;
            btnDel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.Location = new Point(716, 11);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(79, 44);
            btnDel.TabIndex = 10;
            btnDel.Text = "Xóa ";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // Menu_TenMon
            // 
            Menu_TenMon.AutoSize = true;
            Menu_TenMon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Menu_TenMon.Location = new Point(26, 141);
            Menu_TenMon.Name = "Menu_TenMon";
            Menu_TenMon.Size = new Size(75, 20);
            Menu_TenMon.TabIndex = 1;
            Menu_TenMon.Text = "Tên Hàng";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGoldenrodYellow;
            btnUpdate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(606, 11);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 44);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Sửa ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Menu_DonGia
            // 
            Menu_DonGia.AutoSize = true;
            Menu_DonGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Menu_DonGia.Location = new Point(332, 93);
            Menu_DonGia.Name = "Menu_DonGia";
            Menu_DonGia.Size = new Size(90, 20);
            Menu_DonGia.TabIndex = 2;
            Menu_DonGia.Text = "Địa chỉ NCC";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGoldenrodYellow;
            btnAdd.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(496, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 44);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textMaHD
            // 
            textMaHD.Location = new Point(139, 90);
            textMaHD.Name = "textMaHD";
            textMaHD.Size = new Size(172, 27);
            textMaHD.TabIndex = 3;
            // 
            // textTenHD
            // 
            textTenHD.Location = new Point(139, 138);
            textTenHD.Name = "textTenHD";
            textTenHD.Size = new Size(172, 27);
            textTenHD.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGoldenrodYellow;
            btnSearch.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(325, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textDC
            // 
            textDC.Location = new Point(426, 90);
            textDC.Name = "textDC";
            textDC.Size = new Size(172, 27);
            textDC.TabIndex = 5;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(52, 19);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Mời nhập tên món";
            textSearch.Size = new Size(259, 27);
            textSearch.TabIndex = 6;
            // 
            // DanhsachNguyenlieu
            // 
            DanhsachNguyenlieu.Controls.Add(GridHD);
            DanhsachNguyenlieu.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DanhsachNguyenlieu.Location = new Point(-1, 205);
            DanhsachNguyenlieu.Name = "DanhsachNguyenlieu";
            DanhsachNguyenlieu.Size = new Size(958, 465);
            DanhsachNguyenlieu.TabIndex = 8;
            DanhsachNguyenlieu.TabStop = false;
            DanhsachNguyenlieu.Text = "Danh sách nguyên liệu";
            // 
            // GridHD
            // 
            GridHD.BackgroundColor = SystemColors.ButtonHighlight;
            GridHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridHD.Dock = DockStyle.Fill;
            GridHD.Location = new Point(3, 24);
            GridHD.Name = "GridHD";
            GridHD.RowHeadersWidth = 51;
            GridHD.RowTemplate.Height = 29;
            GridHD.Size = new Size(952, 438);
            GridHD.TabIndex = 0;
            GridHD.CellClick += GridHangDat_CellClick;
            // 
            // Ingredients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 669);
            Controls.Add(DanhsachNguyenlieu);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ingredients";
            Text = "Ingredients";
            Load += Ingredients_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            DanhsachNguyenlieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridHD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnReset;
        private Label label2;
        private Button btnDel;
        private Label Menu_TenMon;
        private Button btnUpdate;
        private Label Menu_DonGia;
        private Button btnAdd;
        private TextBox textMaHD;
        private TextBox textTenHD;
        private Button btnSearch;
        private TextBox textDC;
        private TextBox textSearch;
        private GroupBox DanhsachNguyenlieu;
        private DataGridView GridHD;
        private Label label3;
        private TextBox textDG;
        private Label label1;
        private TextBox textSDT;
    }
}