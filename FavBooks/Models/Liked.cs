using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace FavBooks.Models
{
    public class Liked
    {
        public int Id { get; set; }
        
        public int BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book? Book { get; set; }

        
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public IdentityUser? User { get; set; }
    }
}
