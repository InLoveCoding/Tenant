using Microsoft.EntityFrameworkCore;

namespace Tenant.Infrustracture.Data
{
    public class TenantDBContext : DbContext
    {

        public TenantDBContext(DbContextOptions<TenantDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Domain.Tenant.Entities.Tenant> Tenants { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //todo
        }
    }
}
