using Highlande.DAL.Interfaces;
using Highlande.DAL.Repositories;

namespace Highlande.BLL.Services
{
    public class AppService
    {
        internal IRepositoryWorker Repo;

        public AppService()
        {
            Repo = new RepositoryWorker();
        }
    }
}