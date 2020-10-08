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
    public partial class MedlemsVy : Form
    {
        public MedlemsVy()
        {
            InitializeComponent();

            cboTypeRecipe.Items.Add("Kött");
            cboTypeRecipe.Items.Add("Fisk");

        }

    }
}
