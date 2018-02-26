using System.Threading.Tasks;
using Highlande.DAL;

namespace Highlande.BLL.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserAsync();
    }
}