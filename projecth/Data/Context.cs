using Microsoft.EntityFrameworkCore;
using projecth.Models;

namespace projecth.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
