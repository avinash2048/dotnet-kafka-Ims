using IMSProducer.Models;
using Microsoft.EntityFrameworkCore;

namespace IMSProducer.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<ImsUpdateRequest> ImsUpdates { get; set; }
    }
}
