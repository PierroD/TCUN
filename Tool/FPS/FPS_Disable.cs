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
    public partial class FPS_Disable : UserControl
    {
       

        private static FPS_Disable _instance;
        public static FPS_Disable Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FPS_Disable();
                return _instance;
            }
        }
        public FPS_Disable()
        {
            InitializeComponent();
        }

        #region COD Options
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
        #endregion

        private void Timer_Set_Value_Tick(object sender, EventArgs e)
        {
            if(sw_NoFog.IsOn != nofog_value)
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
    }
}
