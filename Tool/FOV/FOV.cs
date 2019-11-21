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
    public partial class FOV : Form
    {
        Trainer COD = new Trainer();

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
        public FOV()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        #region PANEL TOP
        bool mouseDown;
        int mouseX, mouseY, mouseinX, mouseinY;

        private void Btn_close_Click(object sender, EventArgs e)
        {
            TCUN.windowState = false;
            this.Close();
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

        private void Pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }
        #endregion

        #region COD Part
        private void Tb_Fov_Scroll(object sender, EventArgs e)
        {
            lbl_fov.Text = tb_Fov.Value.ToString();
        }

        private void Fov_timer_Tick(object sender, EventArgs e)
        {
            if (COD.Process_Handle("iw3mp"))
            {
                pnl_tekno.Visible = false;
                lbl_Game.Text = "Call Of Duty 4 Modern-Warfare MP";
                COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[0, 1]) + Offsets.All_FPS_Offsets[0, 0], tb_Fov.Value); // cod4
            }
            else if (COD.Process_Handle("iw4mp"))
            {
                pnl_tekno.Visible = false;
                lbl_Game.Text = "Call Of Duty Modern-Warfare 2 MP";
                COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[1, 1]) + Offsets.All_FPS_Offsets[1, 0], tb_Fov.Value); // mw2
            }
            else if (COD.Process_Handle("iw5mp"))
            {
                lbl_Game.Text = "Call Of Duty Modern-Warfare 3 MP";
                pnl_tekno.Visible = true;
                if (sw_tekno.IsOn == false)
                {
                    COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[2, 1]) + Offsets.All_FPS_Offsets[2, 0], tb_Fov.Value); // mw3 
                }
                else
                {
                    COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[3, 1]) + Offsets.All_FPS_Offsets[3, 0], tb_Fov.Value); // tekno
                }
            }
            else if (COD.Process_Handle("BlackOps1"))
            {
                pnl_tekno.Visible = false;
                lbl_Game.Text = "Call Of Duty Black-Ops 1 MP";
                COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[4, 1]) + Offsets.All_FPS_Offsets[4, 0], tb_Fov.Value); // bo1
            }
            else if (COD.Process_Handle("t6mp"))
            {
                pnl_tekno.Visible = false;
                lbl_Game.Text = "Call Of Duty Black-Ops 2 MP ";
                //COD.Process_Handle("t6mp");
                COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[5, 1]) + Offsets.All_FPS_Offsets[5, 0], tb_Fov.Value); // bo2
            }
            else
            {
                pnl_tekno.Visible = false;
                lbl_Game.Text = "No game detected" + 0x5C2C50;
            }
        }
        #endregion
    }
}
