using api_base.Models;
using Microsoft.EntityFrameworkCore;

namespace api_base.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            // dotnet ef migrations add .. 
            // dotnet ef database update
        }

        public DbSet<Model>? Models { get; set; }
    }
}