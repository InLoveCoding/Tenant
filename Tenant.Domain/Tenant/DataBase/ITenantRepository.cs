namespace Tenant.Domain.Tenant.DataBase
{
    public interface ITenantRepository
    {
        Task Add(Entities.Tenant tenant, CancellationToken cancellationToken);
    }
}
