using System.Linq;
using System.Threading.Tasks;
using Highlande.DAL.Entities;
using Highlande.DAL.Interfaces;
using MongoDB.Driver;

namespace Highlande.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly IMongoCollection<User> _users;

        public UserRepository(IMongoDatabase db)
        {
            _users = db.GetCollection<User>("Users");
        }

        public async Task<User> Get()
        {
            var res = await _users.Find(i => i.Name == "Test2").ToListAsync();
            return res.FirstOrDefault();
        }
    }
}
