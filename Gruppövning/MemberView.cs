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
    public partial class MemberView : Form
    {
        public MemberView()
        {
            InitializeComponent();

            DisplayInfo.AddCategory(cboTypeRecipe);

        }

    }
}
