namespace Tenant.Application.CommandInterfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        Task<int> CommitAsync(CancellationToken cancellationToken);
    }
}
