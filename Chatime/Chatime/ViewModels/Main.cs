using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Chatime
{
    public partial class Main : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitialiseDesign();
        }

        public void InitialiseDesign()
        {
            var BaseColour = Color.FromArgb(79, 26, 108);
            var SideBarColour = Color.FromArgb(118, 183, 41);
            var TransparentColor = Color.FromArgb(0, 255, 255, 255);

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.TopMenuBar.BackColor = BaseColour;
            this.SideBar.BackColor = BaseColour;

            this.CloseButton.BackColor = BaseColour;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.BorderColor = TransparentColor;

            this.MinimiseButton.BackColor = BaseColour;
            this.MinimiseButton.FlatAppearance.BorderSize = 0;
            this.MinimiseButton.FlatAppearance.BorderColor = TransparentColor;

            this.HomeButton.BackColor = BaseColour;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatAppearance.BorderColor = TransparentColor;

            this.TeaButton.BackColor = BaseColour;
            this.TeaButton.FlatAppearance.BorderSize = 0;
            this.TeaButton.FlatAppearance.BorderColor = TransparentColor;

            this.InfoButton.BackColor = BaseColour;
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatAppearance.BorderColor = TransparentColor;

            this.FacebookButton.BackColor = BaseColour;
            this.FacebookButton.FlatAppearance.BorderSize = 0;
            this.FacebookButton.FlatAppearance.BorderColor = TransparentColor;

            this.InstagramButton.BackColor = BaseColour;
            this.InstagramButton.FlatAppearance.BorderSize = 0;
            this.InstagramButton.FlatAppearance.BorderColor = TransparentColor;
            
            this.WebsiteButton.BackColor = BaseColour;
            this.WebsiteButton.FlatAppearance.BorderSize = 0;
            this.WebsiteButton.FlatAppearance.BorderColor = TransparentColor;
        }

        private void TopMenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void MinimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {

        }

        private void TeaButton_Click(object sender, EventArgs e)
        {
            teas1.BringToFront();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }
    }
}
