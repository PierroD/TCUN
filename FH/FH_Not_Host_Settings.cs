using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCUN
{
    public partial class FH_Not_Host_Settings : UserControl
    {
        public FH_Not_Host_Settings()
        {
            InitializeComponent();
            #region init comboboxes
            cmb_fullbright.Items.Add("InvertBright");
            cmb_fullbright.Items.Add("NormalBright");
            cmb_fullbright.Items.Add("FullBright");
            cmb_fullbright.Items.Add("ExxxtraBright");

            cmb_specular.Items.Add("Disable");
            cmb_specular.Items.Add("Enable");
            cmb_specular.Items.Add("Chrome");
            #endregion
        }
        private static FH_Not_Host_Settings _instance;
        public static FH_Not_Host_Settings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FH_Not_Host_Settings();
                return _instance;
            }
        }

        #region Checkbox and combobox
        public static bool movie_value;
        private void Sw_Movie_Click(object sender, EventArgs e)
        {
            if (sw_Movie.IsOn == true)
                movie_value = true;
            else
                movie_value = false;
        }

        public static bool nofog_value;
        private void Sw_NoFog_Click(object sender, EventArgs e)
        {
            if (sw_NoFog.IsOn == true)
                nofog_value = true;
            else
                nofog_value = false;
        }
        public static bool noglow_value;
        private void Sw_NoGlow_Click(object sender, EventArgs e)
        {
            if (sw_NoGlow.IsOn == true)
                noglow_value = true;
            else
                noglow_value = false;
        }
        public static bool nobullet_value;
        private void Sw_NoBullet_Click(object sender, EventArgs e)
        {
            if (sw_NoBullet.IsOn == true)
                nobullet_value = true;
            else
                nobullet_value = false;
        }
        public static bool noskins_value;
        private void Sw_NoSkins_Click(object sender, EventArgs e)
        {
            if (sw_NoSkins.IsOn == true)
                noskins_value = true;
            else
                noskins_value = false;
        }
        public static int fullbright_value = 1;
        private void Cmb_fullbright_TextChanged(object sender, EventArgs e)
        {
            fullbright_value = cmb_fullbright.SelectedIndex;
        }

        public static int specular_value = 1;
        private void Cmb_specular_TextChanged(object sender, EventArgs e)
        {
            specular_value = cmb_specular.SelectedIndex;
        }
        #endregion

       #region Timer
        private void Timer_Set_Value_Tick(object sender, EventArgs e)
        {
            if (cmb_fullbright.SelectedIndex != fullbright_value)
            {
                cmb_fullbright.SelectedIndex = fullbright_value;
            }
            if (cmb_specular.SelectedIndex != specular_value)
            {
                cmb_specular.SelectedIndex = specular_value;
            }
            if (sw_Movie.IsOn != movie_value)
            {
                sw_Movie.IsOn = movie_value;
            }
            if (sw_NoFog.IsOn != nofog_value)
            {
                sw_NoFog.IsOn = nofog_value;
            }
            if (sw_NoGlow.IsOn != noglow_value)
            {
                sw_NoGlow.IsOn = noglow_value;
            }
            if (sw_NoBullet.IsOn != nobullet_value)
            {
                sw_NoBullet.IsOn = nobullet_value;
            }
            if (sw_NoSkins.IsOn != noskins_value)
            {
                sw_NoSkins.IsOn = noskins_value;
            }
        }
        #endregion

        public static int fov_value = 65;
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
    }
}
