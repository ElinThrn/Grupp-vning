using Gruppövning.Classes;
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
    public partial class EditRecipe : Form
    {
        public Dictionary<string, string> IngredientsByValue { get; set; }

        public EditRecipe()
        {
            InitializeComponent();
            IngredientsByValue = new Dictionary<string, string>();
        }

        private void cmdAddRecipe_Click(object sender, EventArgs e)
        {
            //TODO Anropa valideringar innan vi skapar recept
            Recipe recept = new Recipe(txtRecipeName.Text, txtRecipeInfo.Text, cboCategory.SelectedItem.ToString(), IngredientsByValue);

        }

        private void cmdAddIngredient_Click(object sender, EventArgs e)
        {
            IngredientsByValue.Add(txtIngredient.Text, txtIngredientMeasure.Text);
            lstIngredients.Items.Clear();

            foreach (KeyValuePair<string, string> kvp in IngredientsByValue)
            {
                lstIngredients.Items.Add(kvp.Value + " - " + kvp.Key);
            }

            txtIngredient.Text = String.Empty;
            txtIngredientMeasure.Text = String.Empty;

        }

    }
}
