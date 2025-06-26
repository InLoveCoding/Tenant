using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Tenant.Infrustracture.Data
{
    public class TenantDBContextFactory : IDesignTimeDbContextFactory<TenantDBContext>
    {
        public TenantDBContext CreateDbContext(string[] args)
        {
            const string connectionString = "Server=.;Database=Tenant;Trusted_Connection=True;TrustServerCertificate=True";

            var optionsBuilder = new DbContextOptionsBuilder<TenantDBContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new TenantDBContext(optionsBuilder.Options);
        }
    }
}
