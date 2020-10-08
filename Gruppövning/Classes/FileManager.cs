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
            using (StreamWriter writer  = new StreamWriter(SetPath(), true))
            {
                writer.WriteLine(FormatRecipe(recipe));
            }
        }

        public static void Update(Recipe oldRecipe, Recipe newRecipe)
        {
            string text = File.ReadAllText(SetPath(), true);
            text = text.Replace(FormatRecipe(oldRecipe), FormatRecipe(newRecipe));
            File.WriteAllText(SetPath(), text);
        }

        public static void Delete(Guid id)
        {
            var oldLines = File.ReadAllLines(SetPath());
            var newLines = oldLines.Where(line => !line.Contains(id.ToString()));
            File.WriteAllLines(SetPath(), newLines);
        }

        public static string FormatRecipe(Recipe recipe)
        {
            string recipeInput = string.Join(";", recipe.Id.ToString(), recipe.Title, recipe.Description, recipe.Category) + "%";

            foreach (var ingredient in recipe.IngredientsValue)
            {
                recipeInput += string.Join(";", ingredient.Value, ingredient.Key);
            }

            return recipeInput;
        }
    }
}
