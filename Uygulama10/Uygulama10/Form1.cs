using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdo1_CheckedChanged(object sender, EventArgs e)
        {
            pbox1.Visible = true;
            pbox2.Visible = false;
            pbox3.Visible = false;
            pbox4.Visible = false;
        }

        private void rdo2_CheckedChanged(object sender, EventArgs e)
        {
            pbox1.Visible = false;
            pbox2.Visible = false;
            pbox3.Visible = false;
            pbox4.Visible = false;
        }

        private void rdo3_CheckedChanged(object sender, EventArgs e)
        {
            pbox1.Visible = false;
            pbox2.Visible = false;
            pbox3.Visible = true;
            pbox4.Visible = false;
        }

        private void rdo4_CheckedChanged(object sender, EventArgs e)
        {
            pbox1.Visible = false;
            pbox2.Visible = false;
            pbox3.Visible = false;
            pbox4.Visible = true;
        }
    }
}
