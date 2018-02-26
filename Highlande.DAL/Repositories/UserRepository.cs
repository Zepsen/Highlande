using System.Threading.Tasks;
using Highlande.DAL.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Highlande.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private IMongoCollection<User> _users;
        public UserRepository(IMongoDatabase db)
        {
            _users = db.GetCollection<User>("Users");
        }
        public async Task<User> Get()
        {
            var builder = new FilterDefinitionBuilder<User>();
            return null;
        }
    }
}
