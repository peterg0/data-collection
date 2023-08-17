using data_collection.Models;
using Microsoft.EntityFrameworkCore;

namespace data_collection.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Widget> Widgets { get; set; }
    
    }
}
