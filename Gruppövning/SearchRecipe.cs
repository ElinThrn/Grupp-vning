using Gruppövning.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gruppövning
{
    public partial class SearchRecipe : Form
    {
        List<Recipe> recipes;
        public bool isLoggedIn = false;
        public SearchRecipe()
        {
            InitializeComponent();

            cboRecipeType.Items.Add("Kött");
            cboRecipeType.Items.Add("Fisk");
            cboRecipeType.Items.Add("Sallader");
            cboRecipeType.Items.Add("Soppor");
            cboRecipeType.Items.Add("Dessert");
            cboRecipeType.Items.Add("Kakor/Bakverk");
            this.OnLoad();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                using (Login login = new Login(this))
                {

                    login.ShowDialog();
                    login.SokVy = this;
                }
                if (isLoggedIn == true)
                {
                    cmdAdd.Visible = true;
                    cmdEditRecipes.Visible = true;
                }
                this.Show();
            }
            catch (Exception exception)
            {
                ExceptionHelper exceptionhelper = new ExceptionHelper();
                exceptionhelper.WriteToLogFile(exception);
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exception)
            {
                ExceptionHelper exceptionhelper = new ExceptionHelper();
                exceptionhelper.WriteToLogFile(exception);
            }
        }

        private void lstRecipe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //matchar recept titel i listboxen mot rätt titel i listan samt skickar till ShowRecipie formuläret.
                //kommer att generera fel om två recept med samma titel läggs till
                if (lstRecipe.SelectedItem != null)
                {
                    Classes.Recipe chosenrecipe = (Classes.Recipe)recipes.Where(recepie => recepie.Title == lstRecipe.SelectedItem.ToString()).SingleOrDefault();
                    ShowRecipe showRecipie = new ShowRecipe(chosenrecipe);
                    showRecipie.Show();
                }
            }

            catch (Exception exception)
            {
                ExceptionHelper exceptionhelper = new ExceptionHelper();
                exceptionhelper.WriteToLogFile(exception);
            }
        }

        private void cmdEditRecipes_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Recipe toSend = recipes.Find(n => n.Title == lstRecipe.SelectedItem.ToString());

                using (Form editForm = new EditRecipe(toSend))
                {
                    editForm.ShowDialog();
                }
                this.OnLoad();
                this.Show();
            }
            catch (Exception exception)
            {
                ExceptionHelper exceptionhelper = new ExceptionHelper();
                exceptionhelper.WriteToLogFile(exception);
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                using (Form editForm = new EditRecipe())
                {
                    editForm.ShowDialog();
                }
                this.OnLoad();
                this.Show();
            }
            catch (Exception exception)
            {
                ExceptionHelper exceptionhelper = new ExceptionHelper();
                exceptionhelper.WriteToLogFile(exception);
            }
        }

        private void OnLoad()
        {
            try
            {
                lstRecipe.Items.Clear();
                List<Recipe> onLoad = FileManager.Read();

                foreach (var item in onLoad)
                {
                    lstRecipe.Items.Add(item.Title);
                }

                recipes = FileManager.Read();
            }
            catch (Exception exception)
            {
                ExceptionHelper exceptionhelper = new ExceptionHelper();
                exceptionhelper.WriteToLogFile(exception);
            }
        }
    }
}
