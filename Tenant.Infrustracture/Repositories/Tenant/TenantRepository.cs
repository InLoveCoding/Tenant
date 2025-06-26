using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenant.Domain.Tenant.DataBase;
using Tenant.Infrustracture.Data;

namespace Tenant.Infrustracture.Repositories.Tenant
{
    public class TenantRepository : ITenantRepository
    {
        private readonly TenantDBContext _context;

        public TenantRepository(TenantDBContext context)
        {
            _context = context;
        }

        public async Task Add(Domain.Tenant.Entities.Tenant tenant, CancellationToken cancellationToken)
        {
            //await _context.Tenants.AddAsync(tenant);
            //await _context.SaveChangesAsync();
        }
    }
}
