using Microsoft.EntityFrameworkCore;

namespace Article_programm.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Models.Article> Articles { get; set; }
    }
}
