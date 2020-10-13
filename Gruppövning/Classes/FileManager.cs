using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gruppövning.Classes
{
    public class FileManager
    {
        public static void Write(Recipe recipe)
        {
            using (StreamWriter writer = new StreamWriter(SetPath(), true))
            {
                writer.WriteLine(FormatRecipe(recipe));
            }
        }

        public static void Update(Recipe oldRecipe, Recipe newRecipe)
        {
            string text = File.ReadAllText(SetPath());
            text = text.Replace(FormatRecipe(oldRecipe), FormatRecipe(newRecipe));
            File.WriteAllText(SetPath(), text);
        }
        public static List<Recipe> Read()
        {
            string path = SetPath();

            List<Recipe> recipeList = new List<Recipe>();
            StreamReader sr = new StreamReader(path);

            using (sr)
            {
                string inputRead;
                while ((inputRead = sr.ReadLine()) != null)
                {
                    Recipe tempRecipe;


                    string fields = inputRead.Substring(0, inputRead.IndexOf('%'));
                    string ingredients = inputRead.Substring(inputRead.IndexOf('%') + 1);

                    string[] fieldsArr = fields.Split(';');
                    string[] ingredientsArr = ingredients.Split(';');
                    Dictionary<string, string> ingredientsDict = new Dictionary<string, string>();

                    for (int i = 0; i < ingredientsArr.Length; i += 2)
                    {
                        ingredientsDict.Add(ingredientsArr[i], ingredientsArr[i + 1]);
                    }

                    Guid newGuid = Guid.Parse(fieldsArr[0]);

                    tempRecipe = new Recipe(newGuid, fieldsArr[1], fieldsArr[2], fieldsArr[3], ingredientsDict);

                    recipeList.Add(tempRecipe);
                }

            }

            return recipeList;
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

            foreach (var ingredient in recipe.IngredientsByAmount)
            {
                recipeInput += string.Join(";", ingredient.Key, ingredient.Value);
                recipeInput += ";";
            }
            string output = recipeInput.Remove(recipeInput.Length - 1, 1);

            return output;
        }

        private static string SetPath()
        {
            string path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + @"\recipeFile.txt";
            return path;
        }
    }
}
