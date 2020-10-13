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
            cboCategory.Items.Add("Kött");
            cboCategory.Items.Add("Fisk");
            cboCategory.Items.Add("Sallader");
            cboCategory.Items.Add("Soppor");
            cboCategory.Items.Add("Dessert");
            cboCategory.Items.Add("Kakor/Bakverk");

            IngredientsByValue = new Dictionary<string, string>();
        }

        public EditRecipe(Recipe recipe)
        {
            InitializeComponent();

            cboCategory.Items.Add("Kött");
            cboCategory.Items.Add("Fisk");
            cboCategory.Items.Add("Sallader");
            cboCategory.Items.Add("Soppor");
            cboCategory.Items.Add("Dessert");
            cboCategory.Items.Add("Kakor/Bakverk");

            IngredientsByValue = new Dictionary<string, string>();

            PopulateTextBoxes(recipe);


        }

        private void cmdAddRecipe_Click(object sender, EventArgs e)
        {
            //TODO Anropa valideringar innan vi skapar recept
            string formatDescription = txtRecipeInfo.Text.Replace("\r\n", string.Empty);

            Recipe recipe = new Recipe(txtRecipeName.Text, formatDescription, cboCategory.SelectedItem.ToString(), IngredientsByValue);
            recipe.Save();
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

        private void cmdDeleteIngredient_Click(object sender, EventArgs e)
        {
            string keyAndValue = lstIngredients.SelectedItem.ToString();
            string toRemove = keyAndValue.Substring(keyAndValue.LastIndexOf(' ') + 1);
            IngredientsByValue.Remove(toRemove);

            lstIngredients.Items.RemoveAt(lstIngredients.SelectedIndex);
        }

        private void PopulateTextBoxes(Recipe rec)
        {
            txtRecipeName.Text = rec.Title;
            txtRecipeInfo.Text = rec.Description;
            cboCategory.SelectedIndex = cboCategory.FindStringExact(rec.Category);

            foreach (KeyValuePair<string, string> kvp in rec.IngredientsByAmount)
            {
                lstIngredients.Items.Add(kvp.Value + " - " + kvp.Key);
            }

        }
    }
}
