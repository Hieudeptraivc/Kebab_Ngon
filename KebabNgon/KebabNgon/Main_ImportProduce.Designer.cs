namespace KebabNgon
{
    partial class Main_ImportProduce
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
            GridBill_Import = new DataGridView();
            panel2 = new Panel();
            textSearch = new TextBox();
            btnSearch = new Button();
            btnReset = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            textTongTien = new TextBox();
            textTime = new TextBox();
            textChietkhau = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textMaNV = new TextBox();
            textMaHD = new TextBox();
            lbMaNV = new Label();
            lbMaHD = new Label();
            DSHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridBill_Import).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DSHoaDon
            // 
            DSHoaDon.Controls.Add(GridBill_Import);
            DSHoaDon.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DSHoaDon.Location = new Point(0, 203);
            DSHoaDon.Name = "DSHoaDon";
            DSHoaDon.Size = new Size(957, 469);
            DSHoaDon.TabIndex = 8;
            DSHoaDon.TabStop = false;
            DSHoaDon.Text = "Danh sách hóa đơn nhập hàng";
            // 
            // GridBill_Import
            // 
            GridBill_Import.BackgroundColor = SystemColors.ButtonHighlight;
            GridBill_Import.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridBill_Import.Dock = DockStyle.Fill;
            GridBill_Import.Location = new Point(3, 24);
            GridBill_Import.Name = "GridBill_Import";
            GridBill_Import.RowHeadersWidth = 51;
            GridBill_Import.RowTemplate.Height = 29;
            GridBill_Import.Size = new Size(951, 442);
            GridBill_Import.TabIndex = 0;
            GridBill_Import.CellClick += GridBill_Import_CellClick;
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
            panel2.Controls.Add(textTongTien);
            panel2.Controls.Add(textTime);
            panel2.Controls.Add(textChietkhau);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textMaNV);
            panel2.Controls.Add(textMaHD);
            panel2.Controls.Add(lbMaNV);
            panel2.Controls.Add(lbMaHD);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 197);
            panel2.TabIndex = 7;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(33, 21);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Mời nhập mã hóa đơn";
            textSearch.Size = new Size(259, 27);
            textSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGoldenrodYellow;
            btnSearch.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(303, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 128, 128);
            btnReset.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(837, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(79, 44);
            btnReset.TabIndex = 23;
            btnReset.Text = "Reset ";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.LightGoldenrodYellow;
            btnDel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.Location = new Point(727, 12);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(79, 44);
            btnDel.TabIndex = 22;
            btnDel.Text = "Xóa ";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGoldenrodYellow;
            btnAdd.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(507, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 44);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGoldenrodYellow;
            btnUpdate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(617, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 44);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Sửa ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textTongTien
            // 
            textTongTien.Location = new Point(745, 89);
            textTongTien.Name = "textTongTien";
            textTongTien.ReadOnly = true;
            textTongTien.Size = new Size(172, 27);
            textTongTien.TabIndex = 17;
            // 
            // textTime
            // 
            textTime.Location = new Point(433, 137);
            textTime.Name = "textTime";
            textTime.Size = new Size(172, 27);
            textTime.TabIndex = 16;
            // 
            // textChietkhau
            // 
            textChietkhau.Location = new Point(433, 89);
            textChietkhau.Name = "textChietkhau";
            textChietkhau.ReadOnly = true;
            textChietkhau.Size = new Size(172, 27);
            textChietkhau.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(645, 92);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 14;
            label2.Text = "Tổng Tiền ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(333, 140);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 13;
            label3.Text = "Thời Gian";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(333, 92);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 12;
            label4.Text = "Chiết Khấu ";
            // 
            // textMaNV
            // 
            textMaNV.Location = new Point(120, 137);
            textMaNV.Name = "textMaNV";
            textMaNV.Size = new Size(172, 27);
            textMaNV.TabIndex = 4;
            // 
            // textMaHD
            // 
            textMaHD.Location = new Point(120, 89);
            textMaHD.Name = "textMaHD";
            textMaHD.Size = new Size(172, 27);
            textMaHD.TabIndex = 3;
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaNV.Location = new Point(20, 140);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(61, 20);
            lbMaNV.TabIndex = 1;
            lbMaNV.Text = "Mã NV ";
            // 
            // lbMaHD
            // 
            lbMaHD.AutoSize = true;
            lbMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHD.Location = new Point(20, 92);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(57, 20);
            lbMaHD.TabIndex = 0;
            lbMaHD.Text = "Mã HĐ";
            // 
            // Main_ImportProduce
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 669);
            Controls.Add(DSHoaDon);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_ImportProduce";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_ImportProduce";
            Load += Main_ImportProduce_Load;
            DSHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridBill_Import).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DSHoaDon;
        private DataGridView GridBill_Import;
        private Panel panel2;
        private TextBox textTongTien;
        private TextBox textTime;
        private TextBox textChietkhau;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textMaNV;
        private TextBox textMaHD;
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