using Microsoft.EntityFrameworkCore;
using EcomTask.Models;

namespace EcomTask.Models
{
    public class EcomDBContext : DbContext
    {
        public EcomDBContext(DbContextOptions options):base(options)
        { 
                
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        //public DbSet<EcomTask.Models.ProductReviewVM>? ProductReviewVM { get; set; }
    }
}
