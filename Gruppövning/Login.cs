using System;
using System.Windows.Forms;

namespace Gruppövning
{
    public partial class Login : Form
    {
        public SearchRecipe toChange;
        public Login(SearchRecipe from)
        {
            InitializeComponent();
            toChange = from;

        }

        public SearchRecipe SokVy;

        private void cmdMemberLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUsername.Text;
                string pw = txtPassword.Text;

                if (userName == "admin" || pw == "password")
                {
                    toChange.isLoggedIn = true;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Login eller lösenord var fel. Prova igen.");
                }
            }
            catch (Exception exception)
            {
                ExceptionHelper exceptionHelper = new ExceptionHelper();
                exceptionHelper.WriteToLogFile(exception);
            }

        }
    }
}
