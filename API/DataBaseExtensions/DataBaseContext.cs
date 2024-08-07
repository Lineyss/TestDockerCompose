using Microsoft.EntityFrameworkCore;

namespace API.DataBaseExtensions
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<Test> tests { get; set; }
    }
}
