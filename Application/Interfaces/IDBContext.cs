using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDBContext
    {
        DbSet<Domain.Demo> Demos { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
