//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCookbook
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingredient
    {
        public Ingredient()
        {
            this.RecipeIngredients = new HashSet<RecipeIngredient>();
        }
    
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public string IngredientType { get; set; }
        public int RecipeIngredientId { get; set; }
        public System.Guid image2 { get; set; }
        public byte[] image3 { get; set; }
        public string image { get; set; }
    
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
