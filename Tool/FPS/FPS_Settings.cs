using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using INI;

namespace TCUN
{
     
    public partial class FPS_Settings : UserControl
    {

        private static FPS_Settings _instance;
        public static FPS_Settings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FPS_Settings();
                return _instance;
            }
        }
        public FPS_Settings()
        {
            InitializeComponent();
        }

        #region Save & Load configs
        private void Txtb_config_Click(object sender, EventArgs e)
        {
            if (txtb_config.Text == "Config Name...")
            {
                txtb_config.Clear();
            }
        }

        public static string config_folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TCUN\\";
        private void Btn_save_config_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(config_folder))
            { Directory.CreateDirectory(config_folder); }
            if ((txtb_config.Text.Length != 0 && !(txtb_config.Text.Contains("Config Name...")))) // if the textbox ins't empty or != to the default message
            {
                string filename = config_folder + txtb_config.Text + ".Ini";
                File.Delete(filename);
                using (StreamWriter sw = (File.Exists(filename)) ? File.AppendText(filename) : File.CreateText(filename))
                {
                    sw.WriteLine("[FOV&FPS]");
                    sw.WriteLine("FieldOfView=" + FPSUnlocker.fov_value);
                    sw.WriteLine("Max_FPS=" + FPSUnlocker.fps_value);
                    sw.WriteLine("[VISUALS]");
                    sw.WriteLine("Fullbright=" + FPS_Visuals.fullbright_value);
                    sw.WriteLine("Specular=" + FPS_Visuals.specular_value);
                    sw.WriteLine("Movie=" + FPS_Visuals.movie_value);
                    sw.WriteLine("[DISABLE]");
                    sw.WriteLine("NoFog=" + FPS_Disable.nofog_value);
                    sw.WriteLine("NoGlow=" + FPS_Disable.noglow_value);
                    sw.WriteLine("NoBullet=" + FPS_Disable.nobullet_value);
                    sw.WriteLine("NoSkins=" + FPS_Disable.noskins_value);
                    MessageBox.Show("Your config named : " + txtb_config.Text + " has been successfully saved", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Name for a config, or the Name is empty", "WRONG Name !" + "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Cmb_config_Click(object sender, EventArgs e)
        {
            cmb_config.Items.Clear();
            if (Directory.Exists(config_folder))
            {
                string[] config_files = Directory.GetFiles(config_folder); // Used to load your customs configs
                foreach (string Tfile in config_files)
                {
                    string WithoutEXT_Tfile = Path.GetFileNameWithoutExtension(Tfile);
                    cmb_config.Items.Add(WithoutEXT_Tfile);
                }
            }
        }

        private void Btn_load_config_Click(object sender, EventArgs e)
        {
            string i_load = config_folder + cmb_config.Text + ".Ini"; //Where the file is
            INIFile ini = new INIFile(i_load); // set this file as a new ini file
            FPSUnlocker.fov_value = (int.Parse(ini.IniReadValue("Fov&fps", "FieldOfView")));
            FPSUnlocker.fps_value = (int.Parse(ini.IniReadValue("Fov&fps", "Max_FPS")));
            FPS_Visuals.fullbright_value = (int.Parse(ini.IniReadValue("Visuals", "Fullbright")));
            FPS_Visuals.specular_value = (int.Parse(ini.IniReadValue("Visuals", "Specular")));
            FPS_Visuals.movie_value = (bool.Parse(ini.IniReadValue("Visuals", "Movie")));
            FPS_Disable.nofog_value = (bool.Parse(ini.IniReadValue("Disable", "NoFog")));
            FPS_Disable.noglow_value = (bool.Parse(ini.IniReadValue("Disable", "NoGlow")));
            FPS_Disable.nobullet_value = (bool.Parse(ini.IniReadValue("Disable", "NoBullet")));
            FPS_Disable.noskins_value = (bool.Parse(ini.IniReadValue("Disable", "NoSkins")));
 
        }
        #endregion
    }

}
