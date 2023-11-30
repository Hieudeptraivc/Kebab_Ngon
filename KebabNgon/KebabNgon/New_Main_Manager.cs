using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KebabNgon
{
    public partial class New_Main_Manager : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public New_Main_Manager()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(250, 128, 114);
                    currentButton.ForeColor = Color.WhiteSmoke;
                    currentButton.Font = new Font("Times New Roman", 12.6F, FontStyle.Bold, GraphicsUnit.Point);
                    panel3.BackColor = Color.FromArgb(250, 128, 114);
                    labelpanel.ForeColor = Color.Black;


                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void New_Main_Manager_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Menu(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main_Bills(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main_Bill_Details(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main_ImportProduce(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main_ImportProduce_Details(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main_Customer(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main_Staff(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main_Account(), sender);
        }



        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn đăng xuất không?", "Quản Lý Kebab Ngon", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ingredients(), sender);
        }
    }
}
