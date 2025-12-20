using Microsoft.EntityFrameworkCore;
using V0001_CURD.Models;

namespace V0001_CURD.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
                    base(options)
        { }

        public DbSet<Product> Products => Set<Product>();
    }
}
