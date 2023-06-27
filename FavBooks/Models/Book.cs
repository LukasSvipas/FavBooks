using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FavBooks.Models
{
    public class Book
    {
        [Key] public int BookId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public long ISBN { get; set; }
        [Display(Name = "Cover")]
        public string ImageURL { get; set; }
        public int Pages { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        
        [ForeignKey(nameof(CategoryId))]
        
        public Category? Category { get; set; }
    }
}
