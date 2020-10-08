using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Gruppövning.Classes
{
    public class FileManager
    {
        public static void Write(Recipe recipe)
        {
            string recipeInput = string.Join(";", recipe.Id, recipe.Title, recipe.Description, recipe.Category) + "%";

            foreach (var ingredient in recipe.IngredientsValue)
            {
                string.Join(";", ingredient.Value, ingredient.Key);
                recipeInput += string.Join(";", ingredient.Value, ingredient.Key);
            }

            using (StreamWriter writer  = new StreamWriter(ConfigurationManager.AppSettings["recipeFile"], true))
            {
                writer.WriteLine(recipeInput);
            }
        }

        public static void Update(Recipe recipe)
        {
            
        }
        public static void Read()
        {

        }
        public static void Delete()
        {

        }
    }
}
