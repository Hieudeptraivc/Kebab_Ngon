namespace KebabNgon
{
    partial class Menu
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
            DanhsachMenu = new GroupBox();
            GridMenu = new DataGridView();
            panel2 = new Panel();
            btnReset = new Button();
            label2 = new Label();
            btnDel = new Button();
            Menu_TenMon = new Label();
            btnUpdate = new Button();
            Menu_DonGia = new Label();
            btnAdd = new Button();
            textMaMon = new TextBox();
            textTenMon = new TextBox();
            btnSearch = new Button();
            textDonGia = new TextBox();
            textSearch = new TextBox();
            DanhsachMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridMenu).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DanhsachMenu
            // 
            DanhsachMenu.Controls.Add(GridMenu);
            DanhsachMenu.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DanhsachMenu.Location = new Point(0, 203);
            DanhsachMenu.Name = "DanhsachMenu";
            DanhsachMenu.Size = new Size(957, 467);
            DanhsachMenu.TabIndex = 7;
            DanhsachMenu.TabStop = false;
            DanhsachMenu.Text = "Danh sách Menu ";
            // 
            // GridMenu
            // 
            GridMenu.BackgroundColor = SystemColors.ButtonHighlight;
            GridMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridMenu.Dock = DockStyle.Fill;
            GridMenu.Location = new Point(3, 24);
            GridMenu.Name = "GridMenu";
            GridMenu.RowHeadersWidth = 51;
            GridMenu.RowTemplate.Height = 29;
            GridMenu.Size = new Size(951, 440);
            GridMenu.TabIndex = 0;
            GridMenu.CellClick += GridMenu_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(Menu_TenMon);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(Menu_DonGia);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(textMaMon);
            panel2.Controls.Add(textTenMon);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(textDonGia);
            panel2.Controls.Add(textSearch);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 198);
            panel2.TabIndex = 6;
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
            label2.Location = new Point(26, 90);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Món ";
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
            Menu_TenMon.Location = new Point(26, 138);
            Menu_TenMon.Name = "Menu_TenMon";
            Menu_TenMon.Size = new Size(74, 20);
            Menu_TenMon.TabIndex = 1;
            Menu_TenMon.Text = "Tên Món ";
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
            Menu_DonGia.Size = new Size(65, 20);
            Menu_DonGia.TabIndex = 2;
            Menu_DonGia.Text = "Đơn Giá";
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
            // textMaMon
            // 
            textMaMon.Location = new Point(121, 87);
            textMaMon.Name = "textMaMon";
            textMaMon.Size = new Size(172, 27);
            textMaMon.TabIndex = 3;
            // 
            // textTenMon
            // 
            textTenMon.Location = new Point(121, 135);
            textTenMon.Name = "textTenMon";
            textTenMon.Size = new Size(172, 27);
            textTenMon.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGoldenrodYellow;
            btnSearch.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(299, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textDonGia
            // 
            textDonGia.Location = new Point(426, 90);
            textDonGia.Name = "textDonGia";
            textDonGia.Size = new Size(172, 27);
            textDonGia.TabIndex = 5;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(34, 21);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Mời nhập tên món";
            textSearch.Size = new Size(259, 27);
            textSearch.TabIndex = 6;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 669);
            Controls.Add(DanhsachMenu);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            DanhsachMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridMenu).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DanhsachMenu;
        private DataGridView GridMenu;
        private Panel panel2;
        private Button btnReset;
        private Button btnDel;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox textSearch;
        private TextBox textDonGia;
        private TextBox textTenMon;
        private TextBox textMaMon;
        private Label Menu_DonGia;
        private Label Menu_TenMon;
        private Label label2;
    }
}