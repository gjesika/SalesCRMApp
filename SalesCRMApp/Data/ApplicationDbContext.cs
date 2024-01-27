using Microsoft.EntityFrameworkCore;
using SalesCRMApp.Models;

namespace SalesCRMApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Users> users { get; set; }


    }
}
