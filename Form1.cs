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

namespace TCUN
{
    public partial class TCUN : Form
    {
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


        #region Public values
        public static bool windowState = false;
        #endregion


        public TCUN()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void TCUN_Load(object sender, EventArgs e)
        {
            btn_home.PerformClick();
        }

        #region Panel TOP (Close / Minimized / Moove)
        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to close TCUN ?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing doesn't close the tool
            }
        }

        bool mouseDown;
        int mouseX, mouseY, mouseinX, mouseinY;

        private void Pnl_top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void Pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;

        }


        private void Pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        #endregion


        #region SIDE PANEL

        private void Btn_settings_Click(object sender, EventArgs e)
        {
            if (!Main_Panel.Controls.Contains(Settings.Instance))
            {
                Main_Panel.Controls.Add(Settings.Instance);
                Settings.Instance.Dock = DockStyle.Fill;
                Settings.Instance.BringToFront();
            }
            else
            {
                Settings.Instance.BringToFront();
            }
            pnl_select.Location = new Point(pnl_select.Location.X, 218);
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            if (!Main_Panel.Controls.Contains(Home.Instance))
            {
                Main_Panel.Controls.Add(Home.Instance);
                Home.Instance.Dock = DockStyle.Fill;
                Home.Instance.BringToFront();
            }
            else
            {
                Home.Instance.BringToFront();
            }
            pnl_select.Location = new Point(pnl_select.Location.X, 138);
        }

        bool iamlogin = false; 
        private void Btn_account_Click(object sender, EventArgs e)
        {
            if (!Main_Panel.Controls.Contains(Account.Instance) && iamlogin)
            {
                Main_Panel.Controls.Add(Account.Instance);
                Account.Instance.Dock = DockStyle.Fill;
                Account.Instance.BringToFront();
            }
            else if(!iamlogin)
            {
                Main_Panel.Controls.Add(Login.Instance);
                Login.Instance.Dock = DockStyle.Fill;
                Login.Instance.BringToFront();
            }
            else
            {
                Account.Instance.BringToFront();
            }
            pnl_select.Location = new Point(pnl_select.Location.X, 298);
        }

        #endregion

        #region WINDOW STATE
        private void Window_timer_Tick(object sender, EventArgs e)
        {
            if(windowState)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        #endregion

    }
}
