using System.Threading.Tasks;
using Highlande.DAL.Entities;

namespace Highlande.BLL.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUser();
    }
}