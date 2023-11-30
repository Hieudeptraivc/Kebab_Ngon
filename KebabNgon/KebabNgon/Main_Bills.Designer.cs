namespace KebabNgon
{
    partial class Main_Bills
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
            GridHoadon = new DataGridView();
            panel2 = new Panel();
            textTongTien = new TextBox();
            textSearch = new TextBox();
            textTime = new TextBox();
            btnSearch = new Button();
            textChietkhau = new TextBox();
            btnReset = new Button();
            label2 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            label3 = new Label();
            btnDel = new Button();
            label4 = new Label();
            textMaKH = new TextBox();
            textMaNV = new TextBox();
            textMaHD = new TextBox();
            Menu_DonGia = new Label();
            lbMaNV = new Label();
            lbMaHD = new Label();
            DSHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridHoadon).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DSHoaDon
            // 
            DSHoaDon.Controls.Add(GridHoadon);
            DSHoaDon.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DSHoaDon.Location = new Point(1, 203);
            DSHoaDon.Name = "DSHoaDon";
            DSHoaDon.Size = new Size(955, 467);
            DSHoaDon.TabIndex = 8;
            DSHoaDon.TabStop = false;
            DSHoaDon.Text = "Danh sách hóa đơn ";
            // 
            // GridHoadon
            // 
            GridHoadon.BackgroundColor = SystemColors.ButtonHighlight;
            GridHoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridHoadon.Dock = DockStyle.Fill;
            GridHoadon.Location = new Point(3, 24);
            GridHoadon.Name = "GridHoadon";
            GridHoadon.RowHeadersWidth = 51;
            GridHoadon.RowTemplate.Height = 29;
            GridHoadon.Size = new Size(949, 440);
            GridHoadon.TabIndex = 0;
            GridHoadon.CellClick += GridHoadon_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(textTongTien);
            panel2.Controls.Add(textSearch);
            panel2.Controls.Add(textTime);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(textChietkhau);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textMaKH);
            panel2.Controls.Add(textMaNV);
            panel2.Controls.Add(textMaHD);
            panel2.Controls.Add(Menu_DonGia);
            panel2.Controls.Add(lbMaNV);
            panel2.Controls.Add(lbMaHD);
            panel2.Location = new Point(0, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(956, 201);
            panel2.TabIndex = 7;
            // 
            // textTongTien
            // 
            textTongTien.Location = new Point(742, 140);
            textTongTien.Name = "textTongTien";
            textTongTien.ReadOnly = true;
            textTongTien.Size = new Size(172, 27);
            textTongTien.TabIndex = 17;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(33, 26);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Mời nhập mã hóa đơn";
            textSearch.Size = new Size(259, 27);
            textSearch.TabIndex = 6;
            // 
            // textTime
            // 
            textTime.Location = new Point(742, 88);
            textTime.Name = "textTime";
            textTime.Size = new Size(172, 27);
            textTime.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGoldenrodYellow;
            btnSearch.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(298, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textChietkhau
            // 
            textChietkhau.Location = new Point(432, 140);
            textChietkhau.Name = "textChietkhau";
            textChietkhau.ReadOnly = true;
            textChietkhau.Size = new Size(172, 27);
            textChietkhau.TabIndex = 15;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 128, 128);
            btnReset.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(834, 16);
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
            label2.Location = new Point(642, 143);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 14;
            label2.Text = "Tổng Tiền  ";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGoldenrodYellow;
            btnAdd.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(498, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 44);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGoldenrodYellow;
            btnUpdate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(609, 16);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 44);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Sửa ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(642, 91);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 13;
            label3.Text = "Thời Gian             ";
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.LightGoldenrodYellow;
            btnDel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.Location = new Point(725, 16);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(79, 44);
            btnDel.TabIndex = 10;
            btnDel.Text = "Xóa ";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(332, 143);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 12;
            label4.Text = "Chiết Khấu";
            // 
            // textMaKH
            // 
            textMaKH.Location = new Point(432, 92);
            textMaKH.Name = "textMaKH";
            textMaKH.Size = new Size(172, 27);
            textMaKH.TabIndex = 5;
            // 
            // textMaNV
            // 
            textMaNV.Location = new Point(120, 140);
            textMaNV.Name = "textMaNV";
            textMaNV.Size = new Size(172, 27);
            textMaNV.TabIndex = 4;
            // 
            // textMaHD
            // 
            textMaHD.Location = new Point(120, 92);
            textMaHD.Name = "textMaHD";
            textMaHD.Size = new Size(172, 27);
            textMaHD.TabIndex = 3;
            // 
            // Menu_DonGia
            // 
            Menu_DonGia.AutoSize = true;
            Menu_DonGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Menu_DonGia.Location = new Point(332, 95);
            Menu_DonGia.Name = "Menu_DonGia";
            Menu_DonGia.Size = new Size(64, 20);
            Menu_DonGia.TabIndex = 2;
            Menu_DonGia.Text = "Mã KH  ";
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaNV.Location = new Point(26, 143);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(65, 20);
            lbMaNV.TabIndex = 1;
            lbMaNV.Text = "Mã NV  ";
            // 
            // lbMaHD
            // 
            lbMaHD.AutoSize = true;
            lbMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHD.Location = new Point(26, 95);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(57, 20);
            lbMaHD.TabIndex = 0;
            lbMaHD.Text = "Mã HĐ";
            // 
            // Main_Bills
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 669);
            Controls.Add(DSHoaDon);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Bills";
            Text = "Main_Bills";
            Load += Main_Bills_Load;
            DSHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridHoadon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DSHoaDon;
        private DataGridView GridHoadon;
        private Panel panel2;
        private TextBox textTongTien;
        private TextBox textTime;
        private TextBox textChietkhau;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnReset;
        private Button btnDel;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox textSearch;
        private TextBox textMaKH;
        private TextBox textMaNV;
        private TextBox textMaHD;
        private Label Menu_DonGia;
        private Label lbMaNV;
        private Label lbMaHD;
    }
}