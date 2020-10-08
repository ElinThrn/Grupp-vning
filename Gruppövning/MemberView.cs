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
    public partial class MemberView : Form
    {
        public MemberView()
        {
            InitializeComponent();

            cboTypeRecipe.Items.Add("Kött");
            cboTypeRecipe.Items.Add("Fisk");
            cboTypeRecipe.Items.Add("Sallader");
            cboTypeRecipe.Items.Add("Soppor");
            cboTypeRecipe.Items.Add("Dessert");
            cboTypeRecipe.Items.Add("Kakor/Bakverk");

        }

    }
}
