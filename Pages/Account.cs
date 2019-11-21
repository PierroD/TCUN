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
    public partial class Account : UserControl
    {

        private static Account _instance;
        public static Account Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Account();
                return _instance;
            }
        }
        public Account()
        {
            InitializeComponent();
            lbl_Name.Location = new Point((this.Width - lbl_Name.Size.Width)/2, lbl_Name.Location.Y);
            lbl_Licence.Location = new Point((this.Width - lbl_Licence.Size.Width) / 2, lbl_Licence.Location.Y);
        }


    }
}
