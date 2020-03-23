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

        string[] ComboxItems = { "kylling", "pasta", "pesto", "grønne Bønner" };

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            cbnIngredienser.Items.AddRange(ComboxItems);
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

        private void cbnIngredienser_TextUpdate(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/52068631/c-sharp-combobox-with-search-field
            string[] ChangedComboxItems = ComboxItems.Where(x => x.Contains(cbnIngredienser.Text)).OrderBy(x => x.IndexOf(cbnIngredienser.Text)).ToArray();
            foreach (string Elemenet in ComboxItems)
            {
                cbnIngredienser.Items.Remove(Elemenet);
            }
            cbnIngredienser.Items.AddRange(ChangedComboxItems);
        }

       
    }
}
