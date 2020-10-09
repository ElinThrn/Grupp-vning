using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppövning.Classes
{
    public static class DisplayInfo
    {

        public static void AddCategory(ComboBox dropdown)
        {
            dropdown.Items.Clear();
            var category = FileManager.Read().Select(c => c.Category).ToArray();

            foreach (var item in category)
            {
                dropdown.Items.Add(item);
            }
        }
    }
}
