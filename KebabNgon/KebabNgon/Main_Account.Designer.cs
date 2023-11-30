namespace KebabNgon
{
    partial class Main_Account
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
            GridAccount = new DataGridView();
            DSAccount = new GroupBox();
            lbMaHD = new Label();
            lbMaNV = new Label();
            panel2 = new Panel();
            textUsername = new TextBox();
            textPassword = new TextBox();
            textSearch = new TextBox();
            btnSearch = new Button();
            btnReset = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)GridAccount).BeginInit();
            DSAccount.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // GridAccount
            // 
            GridAccount.BackgroundColor = SystemColors.ButtonHighlight;
            GridAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridAccount.Dock = DockStyle.Fill;
            GridAccount.Location = new Point(3, 24);
            GridAccount.Name = "GridAccount";
            GridAccount.RowHeadersWidth = 51;
            GridAccount.RowTemplate.Height = 29;
            GridAccount.Size = new Size(951, 419);
            GridAccount.TabIndex = 0;
            GridAccount.CellClick += GridAccount_CellClick;
            GridAccount.DataError += GridAccount_DataError;
            // 
            // DSAccount
            // 
            DSAccount.Controls.Add(GridAccount);
            DSAccount.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DSAccount.Location = new Point(0, 224);
            DSAccount.Name = "DSAccount";
            DSAccount.Size = new Size(957, 446);
            DSAccount.TabIndex = 8;
            DSAccount.TabStop = false;
            DSAccount.Text = "Danh sách tài khoản";
            // 
            // lbMaHD
            // 
            lbMaHD.AutoSize = true;
            lbMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHD.Location = new Point(26, 90);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(100, 20);
            lbMaHD.TabIndex = 0;
            lbMaHD.Text = "Username     ";
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaNV.Location = new Point(26, 148);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(76, 20);
            lbMaNV.TabIndex = 1;
            lbMaNV.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(textUsername);
            panel2.Controls.Add(textPassword);
            panel2.Controls.Add(textSearch);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(lbMaNV);
            panel2.Controls.Add(lbMaHD);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 218);
            panel2.TabIndex = 7;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(126, 87);
            textUsername.Name = "textUsername";
            textUsername.ReadOnly = true;
            textUsername.Size = new Size(281, 27);
            textUsername.TabIndex = 22;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(126, 145);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(281, 27);
            textPassword.TabIndex = 23;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(22, 21);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Mời nhập tên tài khoản";
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
            btnSearch.Click += button5_Click;
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
            // Main_Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 669);
            Controls.Add(DSAccount);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            Load += Main_Account_Load;
            ((System.ComponentModel.ISupportInitialize)GridAccount).EndInit();
            DSAccount.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView GridAccount;
        private GroupBox DSAccount;
        private Label lbMaHD;
        private Label lbMaNV;
        private Panel panel2;
        private TextBox textSearch;
        private Button btnSearch;
        private Button btnReset;
        private Button btnDel;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox textUsername;
        private TextBox textPassword;
    }
}