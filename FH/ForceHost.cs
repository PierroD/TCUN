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
    public partial class ForceHost : Form
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
        public ForceHost()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
           
        }
        private void ForceHost_Load(object sender, EventArgs e)
        {
            btn_ForceHost.PerformClick();
        }


        #region Panel Top
        bool mouseDown;
        int mouseX, mouseY, mouseinX, mouseinY;

        private void Pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }



        private void Pnl_top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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


        private void Btn_close_Click(object sender, EventArgs e)
        {
            TCUN.windowState = false;
            this.Close();
        }
        #endregion


        #region Side panel
        private void Btn_ForceHost_Click(object sender, EventArgs e)
        {
            if (!pnl_form.Controls.Contains(FH_Host.Instance))
            {
                pnl_form.Controls.Add(FH_Host.Instance);
                FH_Host.Instance.Dock = DockStyle.Fill;
                FH_Host.Instance.BringToFront();
            }
            else
            {
                FH_Host.Instance.BringToFront();
            }
        }

        private void Btn_NotHost_Click(object sender, EventArgs e)
        {
            if (!pnl_form.Controls.Contains(FH_Not_Host_Settings.Instance))
            {
                pnl_form.Controls.Add(FH_Not_Host_Settings.Instance);
                FH_Not_Host_Settings.Instance.Dock = DockStyle.Fill;
                FH_Not_Host_Settings.Instance.BringToFront();
            }
            else
            {
                FH_Not_Host_Settings.Instance.BringToFront();
            }
        }

        #endregion
    }
}
