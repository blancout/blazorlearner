using BlazorLearner.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorLearner.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Developer> Developers { get; set; }
    }
}
