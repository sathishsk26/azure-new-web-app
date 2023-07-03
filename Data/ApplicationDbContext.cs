using Microsoft.EntityFrameworkCore;

namespace azure_new_web_app.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
