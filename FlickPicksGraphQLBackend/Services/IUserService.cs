using System.Collections.Generic;
using System.Threading.Tasks;
using FlickPicksGraphQLBackend.Models;

namespace FlickPicksGraphQLBackend.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(int id, User updatedUser);
        Task<bool> DeleteUser(int id);
    }
}
