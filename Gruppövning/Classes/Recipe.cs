using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppövning.Classes
{
    public class Recipe
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Dictionary<string, string> AmountOfIngredients { get; set; }

        public Recipe(string title, string description, string category, Dictionary<string, string> ingredients)
        {
            this.Title = Title;
            this.Description = description;
        }

    }
}
