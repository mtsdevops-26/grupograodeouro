using System.Threading.Tasks;

namespace Gouro.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
