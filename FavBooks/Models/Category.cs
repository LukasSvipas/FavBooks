using System.ComponentModel.DataAnnotations;

namespace FavBooks.Models
{
    public class Category
    {
        [Key] public int CategoryId { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

    }
}
