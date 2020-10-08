using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppövning
{
    public partial class SearchRecipe : Form
    {
        public SearchRecipe()
        {
            InitializeComponent();

            cboRecipeType.Items.Add("Kött");
            cboRecipeType.Items.Add("Fisk");
            cboRecipeType.Items.Add("Sallader");
            cboRecipeType.Items.Add("Soppor");
            cboRecipeType.Items.Add("Dessert");
            cboRecipeType.Items.Add("Kakor/Bakverk");

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            login.SokVy = this;
           
        }
    }
}
