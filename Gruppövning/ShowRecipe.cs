using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Gruppövning
{
    public partial class ShowRecipe : Form
    {
        public ShowRecipe(Classes.Recipe recipe)
        {
            InitializeComponent();

            lblCategory.Text = recipe.Category;
            

           // MessageBox.Show(combindedString.ToString());

        }
    }
}
