using System.Threading.Tasks;
using Highlande.DAL.Interfaces;

namespace Highlande.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public async Task<User> Get()
        {
            return new User
            {
                _id = "1",
                Name = "Teasdfasest"
            };
        }
    }
}
