using Highlande.DAL.Repositories;

namespace Highlande.BLL.Services
{
    public class AppService
    {
        internal RepositoryWorker Repo;

        public AppService()
        {
            Repo = new RepositoryWorker();
        }
    }
}