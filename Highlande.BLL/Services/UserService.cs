using System.Threading.Tasks;
using Highlande.BLL.Interfaces;
using Highlande.DAL.Entities;

namespace Highlande.BLL.Services
{
    public class UserService : AppService, IUserService
    {
        public async Task<User> GetUser()
        {
            return await Repo.UserRepository.Get();
        }
    }
}
