using System.Threading.Tasks;

namespace Highlande.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get();
    }
}