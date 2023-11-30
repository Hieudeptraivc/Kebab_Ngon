namespace KebabNgon
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textusername = new TextBox();
            textpassword = new TextBox();
            butsign_in = new Button();
            butexit = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1134, 601);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 23.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(186, 21);
            label1.Name = "label1";
            label1.Size = new Size(142, 50);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 94);
            label2.Name = "label2";
            label2.Size = new Size(142, 32);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 170);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // textusername
            // 
            textusername.Location = new Point(204, 100);
            textusername.Name = "textusername";
            textusername.Size = new Size(222, 27);
            textusername.TabIndex = 0;
            // 
            // textpassword
            // 
            textpassword.Location = new Point(204, 176);
            textpassword.Name = "textpassword";
            textpassword.Size = new Size(222, 27);
            textpassword.TabIndex = 1;
            textpassword.UseSystemPasswordChar = true;
            // 
            // butsign_in
            // 
            butsign_in.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butsign_in.Location = new Point(204, 234);
            butsign_in.Name = "butsign_in";
            butsign_in.Size = new Size(96, 30);
            butsign_in.TabIndex = 2;
            butsign_in.Text = "Sign in ";
            butsign_in.UseVisualStyleBackColor = true;
            butsign_in.Click += butsign_in_Click;
            // 
            // butexit
            // 
            butexit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butexit.Location = new Point(330, 234);
            butexit.Name = "butexit";
            butexit.Size = new Size(96, 30);
            butexit.TabIndex = 4;
            butexit.Text = "Exit ";
            butexit.UseVisualStyleBackColor = true;
            butexit.Click += butexit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(butexit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(butsign_in);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textpassword);
            panel1.Controls.Add(textusername);
            panel1.Location = new Point(313, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 299);
            panel1.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1133, 596);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textusername;
        private TextBox textpassword;
        private Button butsign_in;
        public Button butexit;
        private Panel panel1;
    }
}