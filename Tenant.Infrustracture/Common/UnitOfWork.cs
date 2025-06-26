using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenant.Application.CommandInterfaces;
using Tenant.Infrustracture.Data;

namespace Tenant.Infrustracture.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TenantDBContext _databaseContext;

        public UnitOfWork(TenantDBContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void Commit()
        {
            _databaseContext.SaveChanges();
        }

        public async Task<int> CommitAsync(CancellationToken cancellationToken)
        {
            return await _databaseContext.SaveChangesAsync(cancellationToken);
        }

    }
}
