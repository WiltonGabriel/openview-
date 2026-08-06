using Microsoft.EntityFrameworkCore;
using OpenView.Api.Models;

namespace OpenView.Api.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Content> Contents { get; set; }
    }
}