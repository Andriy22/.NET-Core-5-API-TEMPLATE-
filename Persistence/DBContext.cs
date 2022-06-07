using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityTypeConfigurations;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence
{

    public class DBContext : DbContext, IDBContext
    {
        public DbSet<Demo> Demos { get; set; }

        public DBContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DemoConfiguration());
            base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
