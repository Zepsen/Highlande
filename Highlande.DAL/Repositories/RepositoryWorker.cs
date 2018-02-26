using System;
using Highlande.DAL.DbEntities;

namespace Highlande.DAL.Repositories
{
    public class RepositoryWorker 
    {
        private readonly DbContext context;
        private bool disposed = false;

        public RepositoryWorker()
        {
            context = new DbContext();
        }
        
        private UserRepository _userRepository { get; set; }

        public UserRepository UserRepository => _userRepository 
            ?? (_userRepository = new UserRepository());
        
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        
        ~RepositoryWorker()
        {
            Dispose(true);
            //GC.SuppressFinalize(this);
        }
    }
}
