using Highlande.DAL.Repositories;

namespace Highlande.DAL.Interfaces
{
    public interface IRepositoryWorker
    {
        UserRepository UserRepository { get; }
    }
}