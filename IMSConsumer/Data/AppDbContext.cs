using IMSConsumer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IMSConsumer.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<ImsUpdateRequest> ImsUpdates { get; set; }
    }
}
