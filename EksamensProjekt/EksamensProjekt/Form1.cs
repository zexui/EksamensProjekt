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

        private void BtnOpskrifter_Click(object sender, EventArgs e)
        {
            PanelOpskrifter.BringToFront();
        }

        private void BtnIngredienser_Click(object sender, EventArgs e)
        {
            PanelIngrediens.BringToFront();
        }

        private void BtnRester_Click(object sender, EventArgs e)
        {
            PanelRester.BringToFront();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            PanelResterAdd.BringToFront();
        }
    }
}
