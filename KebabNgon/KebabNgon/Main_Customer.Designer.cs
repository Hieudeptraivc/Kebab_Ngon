namespace KebabNgon
{
    partial class Main_Customer
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
            DSKhachHang = new GroupBox();
            GridCustomer = new DataGridView();
            panel2 = new Panel();
            textSearch = new TextBox();
            btnSearch = new Button();
            btnReset = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            textDiachiKH = new TextBox();
            label4 = new Label();
            textTenKH = new TextBox();
            textMaKH = new TextBox();
            lbMaNV = new Label();
            lbMaHD = new Label();
            DSKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridCustomer).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DSKhachHang
            // 
            DSKhachHang.Controls.Add(GridCustomer);
            DSKhachHang.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DSKhachHang.Location = new Point(0, 203);
            DSKhachHang.Name = "DSKhachHang";
            DSKhachHang.Size = new Size(956, 468);
            DSKhachHang.TabIndex = 11;
            DSKhachHang.TabStop = false;
            DSKhachHang.Text = "Danh sách khách hàng";
            // 
            // GridCustomer
            // 
            GridCustomer.BackgroundColor = SystemColors.ButtonHighlight;
            GridCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCustomer.Dock = DockStyle.Fill;
            GridCustomer.Location = new Point(3, 24);
            GridCustomer.Name = "GridCustomer";
            GridCustomer.RowHeadersWidth = 51;
            GridCustomer.RowTemplate.Height = 29;
            GridCustomer.Size = new Size(950, 441);
            GridCustomer.TabIndex = 0;
            GridCustomer.CellClick += GridCustomer_CellClick;
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
            panel2.Controls.Add(textDiachiKH);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textTenKH);
            panel2.Controls.Add(textMaKH);
            panel2.Controls.Add(lbMaNV);
            panel2.Controls.Add(lbMaHD);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(956, 197);
            panel2.TabIndex = 10;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(22, 21);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Mời nhập tên khách hàng";
            textSearch.Size = new Size(259, 27);
            textSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGoldenrodYellow;
            btnSearch.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(292, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 29);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 128, 128);
            btnReset.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(826, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(79, 44);
            btnReset.TabIndex = 21;
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
            btnDel.TabIndex = 20;
            btnDel.Text = "Xóa ";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGoldenrodYellow;
            btnAdd.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(496, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 44);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGoldenrodYellow;
            btnUpdate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(606, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 44);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Sửa ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textDiachiKH
            // 
            textDiachiKH.Location = new Point(403, 87);
            textDiachiKH.Name = "textDiachiKH";
            textDiachiKH.Size = new Size(172, 27);
            textDiachiKH.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(332, 90);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 12;
            label4.Text = "Địa chỉ";
            // 
            // textTenKH
            // 
            textTenKH.Location = new Point(109, 138);
            textTenKH.Name = "textTenKH";
            textTenKH.Size = new Size(172, 27);
            textTenKH.TabIndex = 4;
            // 
            // textMaKH
            // 
            textMaKH.Location = new Point(109, 87);
            textMaKH.Name = "textMaKH";
            textMaKH.Size = new Size(172, 27);
            textMaKH.TabIndex = 3;
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaNV.Location = new Point(26, 138);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(59, 20);
            lbMaNV.TabIndex = 1;
            lbMaNV.Text = "Tên KH";
            // 
            // lbMaHD
            // 
            lbMaHD.AutoSize = true;
            lbMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHD.Location = new Point(26, 90);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(56, 20);
            lbMaHD.TabIndex = 0;
            lbMaHD.Text = "Mã KH";
            // 
            // Main_Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 669);
            Controls.Add(DSKhachHang);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Customer";
            Load += Main_Customer_Load;
            DSKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridCustomer).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DSKhachHang;
        private DataGridView GridCustomer;
        private Panel panel2;
        private TextBox textDiachiKH;
        private Label label4;
        private TextBox textTenKH;
        private TextBox textMaKH;
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