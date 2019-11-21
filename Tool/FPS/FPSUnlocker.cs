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
using System.IO;


namespace TCUN
{
    public partial class FPSUnlocker : Form
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
        public FPSUnlocker()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        private void FPSUnlocker_Load(object sender, EventArgs e)
        {
            btn_visual.PerformClick();
        }

        #region TRACKBARS 
        public static int fov_value =65;
        private void Tb_Fov_Scroll(object sender, EventArgs e)
        {
            lbl_fov.Text = tb_Fov.Value.ToString();
            fov_value = tb_Fov.Value;
        }

        public static int fps_value;
        private void Tb_FPS_Scroll(object sender, EventArgs e)
        {
            if (tb_FPS.Value.ToString().Length <= 3)
            {
                int Arround_Value = tb_FPS.Value % 10;
                if (Arround_Value == 6 || Arround_Value == 7 || Arround_Value == 8 || Arround_Value == 9)
                {
                    int Value_add = 10 - Arround_Value;
                    tb_FPS.Value = tb_FPS.Value + Value_add;
                }
            }
            lbl_fps.Text = tb_FPS.Value.ToString();
            fps_value = tb_FPS.Value;
        }
        #endregion

        #region PANEL TOP
        bool mouseDown;
        int mouseX, mouseY, mouseinX, mouseinY;

        private void Btn_close_Click(object sender, EventArgs e)
        {
            TCUN.windowState = false;
            this.Close();
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


        #endregion

        #region SIDE PANEL
        private void Btn_visual_Click(object sender, EventArgs e)
        {
            if (!pnl_form.Controls.Contains(FPS_Visuals.Instance))
            {
                pnl_form.Controls.Add(FPS_Visuals.Instance);
                FPS_Visuals.Instance.Dock = DockStyle.Fill;
                FPS_Visuals.Instance.BringToFront();
            }
            else
            {
                FPS_Visuals.Instance.BringToFront();
            }
        }
        private void Btn_disable_Click(object sender, EventArgs e)
        {
            if (!pnl_form.Controls.Contains(FPS_Disable.Instance))
            {
                pnl_form.Controls.Add(FPS_Disable.Instance);
                FPS_Disable.Instance.Dock = DockStyle.Fill;
                FPS_Disable.Instance.BringToFront();
            }
            else
            {
                FPS_Disable.Instance.BringToFront();
            }
        }
        private void Btn_settings_Click(object sender, EventArgs e)
        {
            if (!pnl_form.Controls.Contains(FPS_Settings.Instance))
            {
                pnl_form.Controls.Add(FPS_Settings.Instance);
                FPS_Settings.Instance.Dock = DockStyle.Fill;
                FPS_Settings.Instance.BringToFront();
            }
            else
            {
                FPS_Settings.Instance.BringToFront();
            }
        }

        #endregion

        #region MAIN TIMER
        private void Main_timer_Tick(object sender, EventArgs e)
        {
            if(tb_Fov.Value != fov_value)
            {
                tb_Fov.Value = fov_value;
                lbl_fov.Text = tb_Fov.Value.ToString();
            }
            if (tb_FPS.Value != fps_value)
            {
                tb_FPS.Value = fps_value;
                lbl_fps.Text = tb_FPS.Value.ToString();
            }

            if(COD.Process_Handle("iw3mp"))
            {
                lbl_Game.Text = "Call Of Duty 4 Modern-Warfare MP";
                pnl_tekno.Visible = false;
                COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[0, 1]) + Offsets.All_FPS_Offsets[0, 0], fov_value); //fov
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[0, 2]) + Offsets.All_FPS_Offsets[0, 0], fps_value); //fps
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[0, 3]) + Offsets.All_FPS_Offsets[0, 0], FPS_Visuals.fullbright_value); //fullbright
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[0, 4]) + Offsets.All_FPS_Offsets[0, 0], FPS_Visuals.specular_value); //fullbright
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[0, 5]) + Offsets.All_FPS_Offsets[0, 0], Convert.ToInt32(FPS_Visuals.movie_value)); //movie
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[0, 6]) + Offsets.All_FPS_Offsets[0, 0], Convert.ToInt32(FPS_Disable.nofog_value)); // nofog
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[0, 7]) + Offsets.All_FPS_Offsets[0, 0], Convert.ToInt32(FPS_Disable.noglow_value)); // noglow
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[0, 8]) + Offsets.All_FPS_Offsets[0, 0], Convert.ToInt32(FPS_Disable.nobullet_value)); // nobullet
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[0, 9]) + Offsets.All_FPS_Offsets[0, 0], Convert.ToInt32(FPS_Disable.noskins_value)); // noskins
            }
            if (COD.Process_Handle("iw4mp"))
            {
                lbl_Game.Text = "Call Of Duty Modern-Warfare 2 MP";
                pnl_tekno.Visible = false;
                COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[1, 1]) + Offsets.All_FPS_Offsets[1, 0], fov_value); //fov
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[1, 2]) + Offsets.All_FPS_Offsets[1, 0], fps_value); //fps
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[1, 3]) + Offsets.All_FPS_Offsets[1, 0], FPS_Visuals.fullbright_value); //fullbright
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[1, 4]) + Offsets.All_FPS_Offsets[1, 0], FPS_Visuals.specular_value); //fullbright
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[1, 5]) + Offsets.All_FPS_Offsets[1, 0], Convert.ToInt32(FPS_Visuals.movie_value)); //movie
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[1, 6]) + Offsets.All_FPS_Offsets[1, 0], Convert.ToInt32(FPS_Disable.nofog_value)); // nofog
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[1, 7]) + Offsets.All_FPS_Offsets[1, 0], Convert.ToInt32(FPS_Disable.noglow_value)); // noglow
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[1, 8]) + Offsets.All_FPS_Offsets[1, 0], Convert.ToInt32(FPS_Disable.nobullet_value)); // nobullet
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[1, 9]) + Offsets.All_FPS_Offsets[1, 0], Convert.ToInt32(FPS_Disable.noskins_value)); // noskins
            }
            if (COD.Process_Handle("iw5mp"))
            {
                lbl_Game.Text = "Call Of Duty Modern-Warfare 3 MP";
                pnl_tekno.Visible = true;
                if (sw_tekno.IsOn == false)
                {
                    COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[2, 1]) + Offsets.All_FPS_Offsets[2, 0], fov_value); //fov
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[2, 2]) + Offsets.All_FPS_Offsets[2, 0], fps_value); //fps
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[2, 3]) + Offsets.All_FPS_Offsets[2, 0], FPS_Visuals.fullbright_value); //fullbright
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[2, 4]) + Offsets.All_FPS_Offsets[2, 0], FPS_Visuals.specular_value); //fullbright
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[2, 5]) + Offsets.All_FPS_Offsets[2, 0], Convert.ToInt32(FPS_Visuals.movie_value)); //movie
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[2, 6]) + Offsets.All_FPS_Offsets[2, 0], Convert.ToInt32(FPS_Disable.nofog_value)); // nofog
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[2, 7]) + Offsets.All_FPS_Offsets[2, 0], Convert.ToInt32(FPS_Disable.noglow_value)); // noglow
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[2, 8]) + Offsets.All_FPS_Offsets[2, 0], Convert.ToInt32(FPS_Disable.nobullet_value)); // nobullet
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[2, 9]) + Offsets.All_FPS_Offsets[2, 0], Convert.ToInt32(FPS_Disable.noskins_value)); // noskins
                }
                else
                {
                    COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[3, 1]) + Offsets.All_FPS_Offsets[3, 0], fov_value); //fov
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[3, 2]) + Offsets.All_FPS_Offsets[3, 0], fps_value); //fps
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[3, 3]) + Offsets.All_FPS_Offsets[3, 0], FPS_Visuals.fullbright_value); //fullbright
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[3, 4]) + Offsets.All_FPS_Offsets[3, 0], FPS_Visuals.specular_value); //fullbright
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[3, 5]) + Offsets.All_FPS_Offsets[3, 0], Convert.ToInt32(FPS_Visuals.movie_value)); //movie
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[3, 6]) + Offsets.All_FPS_Offsets[3, 0], Convert.ToInt32(FPS_Disable.nofog_value)); // nofog
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[3, 7]) + Offsets.All_FPS_Offsets[3, 0], Convert.ToInt32(FPS_Disable.noglow_value)); // noglow
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[3, 8]) + Offsets.All_FPS_Offsets[3, 0], Convert.ToInt32(FPS_Disable.nobullet_value)); // nobullet
                    COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[3, 9]) + Offsets.All_FPS_Offsets[3, 0], Convert.ToInt32(FPS_Disable.noskins_value)); // noskins
                }
            }
            if(COD.Process_Handle("BlackOps1"))
            {
                lbl_Game.Text = "Call Of Duty Black-Ops 1 MP";
                pnl_tekno.Visible = false;
                COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[4, 1]) + Offsets.All_FPS_Offsets[4, 0], fov_value); //fov
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[4, 2]) + Offsets.All_FPS_Offsets[4, 0], fps_value); //fps
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[4, 3]) + Offsets.All_FPS_Offsets[4, 0], FPS_Visuals.fullbright_value); //fullbright
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[4, 4]) + Offsets.All_FPS_Offsets[4, 0], FPS_Visuals.specular_value); //fullbright
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[4, 5]) + Offsets.All_FPS_Offsets[4, 0], Convert.ToInt32(FPS_Visuals.movie_value)); //movie
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[4, 6]) + Offsets.All_FPS_Offsets[4, 0], Convert.ToInt32(FPS_Disable.nofog_value)); // nofog
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[4, 7]) + Offsets.All_FPS_Offsets[4, 0], Convert.ToInt32(FPS_Disable.noglow_value)); // noglow
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[4, 8]) + Offsets.All_FPS_Offsets[4, 0], Convert.ToInt32(FPS_Disable.nobullet_value)); // nobullet
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[4, 9]) + Offsets.All_FPS_Offsets[4, 0], Convert.ToInt32(FPS_Disable.noskins_value)); // noskins
            }
            if (COD.Process_Handle("t6mp"))
            {
                lbl_Game.Text = "Call Of Duty Black-Ops 2 MP ";
                pnl_tekno.Visible = false;
                COD.WriteFloat_Protected32(COD.ReadInteger32(Offsets.All_FPS_Offsets[5, 1]) + Offsets.All_FPS_Offsets[5, 0], fov_value); //fov
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[5, 2]) + Offsets.All_FPS_Offsets[5, 0], fps_value); //fps
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[5, 3]) + Offsets.All_FPS_Offsets[5, 0], FPS_Visuals.fullbright_value); //fullbright
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[5, 4]) + Offsets.All_FPS_Offsets[5, 0], FPS_Visuals.specular_value); //fullbright
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[5, 5]) + Offsets.All_FPS_Offsets[5, 0], Convert.ToInt32(FPS_Visuals.movie_value)); //movie
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[5, 6]) + Offsets.All_FPS_Offsets[5, 0], Convert.ToInt32(FPS_Disable.nofog_value)); // nofog
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[5, 7]) + Offsets.All_FPS_Offsets[5, 0], Convert.ToInt32(FPS_Disable.noglow_value)); // noglow
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[5, 8]) + Offsets.All_FPS_Offsets[5, 0], Convert.ToInt32(FPS_Disable.nobullet_value)); // nobullet
                COD.WriteInteger(COD.ReadInteger32(Offsets.All_FPS_Offsets[5, 9]) + Offsets.All_FPS_Offsets[5, 0], Convert.ToInt32(FPS_Disable.noskins_value)); // noskins            
            }


        }
        #endregion


    }
}
