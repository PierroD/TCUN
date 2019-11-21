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
    public partial class Login : UserControl
    {
        private static Login _instance;
        public static Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login();
                return _instance;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        #region BOUTON LOGIN

        #endregion

        private void Txtbox_password_Click(object sender, EventArgs e)
        {
            if (txtbox_password.Text == "Password...")
            {
                txtbox_password.Text = string.Empty;
                Pic_show_hide_Click(this.pic_show_hide, EventArgs.Empty);
            }
        }
        bool hide = false;
        private void Pic_show_hide_Click(object sender, EventArgs e)
        {
            hide = !hide;
            if (hide)
            {
                this.pic_show_hide.Image = Properties.Resources.show;
                txtbox_password.PasswordChar = '•';
                txtbox_password.ForeColor = Color.Black;
                txtbox_password.UseSystemPasswordChar = false;
            }
            else
            {
                this.pic_show_hide.Image = Properties.Resources.hide;
                txtbox_password.PasswordChar = '\0';
                txtbox_password.ForeColor = Color.Black;
                txtbox_password.UseSystemPasswordChar = true;
            }
        }

        private void Txtbox_Name_Click(object sender, EventArgs e)
        {
            if (txtbox_Name.Text == "Mail / Community Name....")
            {
                txtbox_Name.ForeColor = Color.FromArgb(30, 135, 240);
                txtbox_Name.Text = string.Empty;
            }
        }
    }
}
