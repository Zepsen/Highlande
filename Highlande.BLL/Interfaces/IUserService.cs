using System.Collections.Generic;
using System.Threading.Tasks;
using Highlande.DAL.Entities;

namespace Highlande.BLL.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUser(string id);
        Task<IEnumerable<User>> GetAllUsers();
        Task InsertUser(User user);
        Task DeleteUser(User user);
        Task UpdateUser(User user);
    }
}