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
        public Dictionary<string, string> IngredientsValue { get; set; }

        public Recipe(string title, string description, string category, Dictionary<string, string> ingredients)
        {
            Id = Guid.NewGuid();
            this.Title = title;
            this.Description = description;
            this.Category = category;
            this.IngredientsValue = ingredients;
        }

        public void Save()
        {
            //TODO: change to FileManager MethodCall
            //SaveFile(this.Id, this.Title, this.Description, this.Category, this.IngredientsValue);
        }

        public void SaveEdited()
        {
            //TODO: change to FileManager MethodCall
            //SaveEditedFile(this.Id, this.Title, this.Description, this.Category, this.IngredientsValue);
        }


    }
}
