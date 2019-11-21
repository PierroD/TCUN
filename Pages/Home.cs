using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TCUN
{
    public partial class Home : UserControl
    {
        private static Home _instance;
        public static Home Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Home();
                return _instance;
            }
        }
        public Home()
        {
            InitializeComponent();
        }
        

        #region LAUNCH BUTTON
        private void Btn_fov_Click(object sender, EventArgs e)
        {
            if (IsFormAlreadyOpen(typeof(FPSUnlocker)) != null)
            {
                MessageBox.Show("FPS Unlocker is already launched !" + Environment.NewLine + "You can only launch one at the time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (IsFormAlreadyOpen(typeof(FOV)) == null)
                {
                    FOV my_fov = new FOV();
                    my_fov.Show();
                    TCUN.windowState = true;
                }
                else
                {
                    MessageBox.Show("Field Of View is already launched !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Btn_FpsUnlocker_Click(object sender, EventArgs e)
        {
            if (IsFormAlreadyOpen(typeof(FOV)) != null)
            {
                MessageBox.Show("Field Of View is already launched !" + Environment.NewLine + "You can only launch one at the time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (IsFormAlreadyOpen(typeof(FPSUnlocker)) == null)
                {
                    FPSUnlocker my_fpsUnlocker = new FPSUnlocker();
                    my_fpsUnlocker.Show();
                    TCUN.windowState = true;
                }
                else
                {
                    MessageBox.Show("FPS Unlocker is already launched !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }
            return null;
        }
        #endregion


    }
}
