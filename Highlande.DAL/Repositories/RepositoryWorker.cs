using System;
using MongoDB.Driver;

namespace Highlande.DAL.Repositories
{
    public class RepositoryWorker
    {
        private readonly IMongoDatabase _db;
        private const string ConnectionString = "mongodb://localhost:27017/test";

        private bool disposed = false;

        public RepositoryWorker()
        {
            var connection = new MongoUrlBuilder(ConnectionString);
            var client = new MongoClient(ConnectionString);
            _db = client.GetDatabase(connection.DatabaseName);
        }
        
        private UserRepository _userRepository { get; set; }

        public UserRepository UserRepository => _userRepository 
            ?? (_userRepository = new UserRepository(_db));
        
        
    }
}
