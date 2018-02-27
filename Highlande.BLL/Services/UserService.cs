using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Highlande.BLL.Interfaces;
using Highlande.DAL.Entities;
using MongoDB.Bson;

namespace Highlande.BLL.Services
{
    public class UserService : AppService, IUserService
    {
        public async Task<User> GetUser(string id)
        {
            return await Repo.UserRepository.Get(id);
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await Repo.UserRepository.GetAll();
        }

        public async Task InsertUser(User user)
        {
            await Repo.UserRepository.Insert(user);
        }

        public async Task DeleteUser(User user)
        {
            await Repo.UserRepository.Delete(user);
        }

        public async Task UpdateUser(User user)
        {
            await Repo.UserRepository.Update(user);
        }
    }
}
