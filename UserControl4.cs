using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class About_UC : UserControl
    {
        private static About_UC _instance;

        public static About_UC Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new About_UC();
                }
                return _instance;
            }
        }
        public About_UC()
        {
            InitializeComponent();
        }
    }
}
