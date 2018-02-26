using System;
using System.Threading.Tasks;
using Highlande.BLL.Interfaces;
using Highlande.DAL;
using Highlande.DAL.Repositories;

namespace Highlande.BLL.Services
{
    public class UserService : AppService, IUserService
    {
        public async Task<User> GetUserAsync()
        {
            return await Repo.UserRepository.Get();
        }
    }
}
