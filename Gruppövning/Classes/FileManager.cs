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
        public static List<Recipe> Read()
        {
            string path = SetPath();

            List<Recipe> recipeList = new List<Recipe>();
            StreamReader sr = new StreamReader(path);

            using (sr)
            {
                string inputRead;
                while (( inputRead = sr.ReadLine()) != null )
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

                    tempRecipe = new Recipe(fieldsArr[0], fieldsArr[1], fieldsArr[2], ingredientsDict);

                    recipeList.Add(tempRecipe);
                }

            }

            return recipeList;
        }
        public static void Delete()
        {

        }

        private static string SetPath()
        {
            string path = Directory.GetCurrentDirectory() + @"\recipeFile.txt";
            return path;
        }
    }
}
