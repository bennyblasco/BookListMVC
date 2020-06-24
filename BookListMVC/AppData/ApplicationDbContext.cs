using Microsoft.EntityFrameworkCore;
using BookListMVC.Models;

namespace BookListMVC.AppData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

    }
}
 