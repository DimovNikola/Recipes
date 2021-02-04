using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Recipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string ImageURL { get; set; }
        public int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}