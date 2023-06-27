using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FavBooks.Models;

namespace FavBooks.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FavBooks.Models.Book>? Book { get; set; }
        public DbSet<FavBooks.Models.Category>? Category { get; set; }
        public DbSet<FavBooks.Models.Liked> Likeds { get; set; }
    }
}