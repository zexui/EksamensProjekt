using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EksamensProjekt
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            button6.Visible = false;
            button5.Visible = false;
        }
    }
}
