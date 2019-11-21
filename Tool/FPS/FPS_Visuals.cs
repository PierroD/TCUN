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
    public partial class FPS_Visuals : UserControl
    {
       
        private static FPS_Visuals _instance;
        public static FPS_Visuals Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FPS_Visuals();
                return _instance;
            }
        }
        public FPS_Visuals()
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

        #region COD Options
        public static bool movie_value;
        private void Sw_Movie_Click(object sender, EventArgs e)
        {
            if (sw_Movie.IsOn == true)
                movie_value = true;
            else
                movie_value = false;
        }

        public static int fullbright_value=1;
        private void Cmb_fullbright_TextChanged(object sender, EventArgs e)
        {
            fullbright_value = cmb_fullbright.SelectedIndex;
        }

        public static int specular_value=1;
        private void Cmb_specular_TextChanged(object sender, EventArgs e)
        {
           specular_value = cmb_specular.SelectedIndex;
        }
        #endregion

        private void Timer_Set_Value_Tick(object sender, EventArgs e)
        {
            if(cmb_fullbright.SelectedIndex != fullbright_value)
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
        }
    }
}
