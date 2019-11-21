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
    public partial class FH_Host : UserControl
    {
        public FH_Host()
        {
            InitializeComponent();
            
        }
        private static FH_Host _instance;
        public static FH_Host Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FH_Host();
                return _instance;
            }
        }
    }
}
