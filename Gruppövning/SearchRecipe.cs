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
    public partial class SearchRecipe : Form
    {
        List<Recipe> recipes = FileManager.Read();
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

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            string searchtext = txtSearchText.Text;
            string combobox = this.cboRecipeType.GetItemText(this.cboRecipeType.SelectedItem);
           
            var matches = recipes.Where(a => a.Category == combobox); //bland de recept som matchar kategori

            lstRecipe.Items.Clear(); //töm listboxen

                foreach (Recipe recipe in matches)
                {
                    //För att hantera stor och liten bokstav görs allt om till små bokstäver
                    if (recipe.Title.ToLower().Contains(searchtext.ToLower()))
                    {
                        //Lägger ut en rad i listboxen
                        lstRecipe.Items.Add(recipe.Title);
                    }
                }
        }

        private void lstRecipe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //matchar recept titel i listboxen mot rätt titel i listan samt skickar till ShowRecipie formuläret.
            //kommer att generera fel om två recept med samma titel läggs till
            Classes.Recipe chosenrecipe = (Classes.Recipe)recipes.Where(recepie => recepie.Title == lstRecipe.SelectedItem.ToString()).SingleOrDefault();
            ShowRecipe showRecipie = new ShowRecipe(chosenrecipe);
            showRecipie.Show();

        }
    }
}
