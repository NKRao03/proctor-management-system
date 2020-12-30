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
    public partial class Student : UserControl
    {
        private static Student _instance;

        public static Student Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Student();
                }
                return _instance;
            }
        }
        public Student()
        {
            InitializeComponent();
        }
    }
}
