using System;
using System.Collections.Generic;

namespace Gruppövning.Classes
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Dictionary<string, string> IngredientsByAmount { get; set; }

        public Recipe(string title, string description, string category, Dictionary<string, string> ingredients)
        {
            this.Id = Guid.NewGuid();
            this.Title = title;
            this.Description = description;
            this.Category = category;
            this.IngredientsByAmount = ingredients;
        }

        public Recipe(Guid guid , string title, string description, string category, Dictionary<string, string> ingredients)
        {
            this.Id = guid;
            this.Title = title;
            this.Description = description;
            this.Category = category;
            this.IngredientsByAmount = ingredients;
        }
        public void Save()
        {
            FileManager.Write(this);
        }

        public void SaveEdited()
        {
            // TODO: change to FileManager MethodCall
            //SaveEditedFile(this.Id, this.Title, this.Description, this.Category, this.IngredientsByAmount);
        }

        public void Delete()
        {
            FileManager.Delete(this.Id);
        }


    }
}
