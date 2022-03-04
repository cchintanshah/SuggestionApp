using SuggestionAppLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuggestionAppLibrary.DataAccess
{
    public interface IUserData
    {
        Task CretaeUser(UserModel user);
        Task<UserModel> GetUser(string id);
        Task<UserModel> GetUserFromAuthentication(string objectId);
        Task<List<UserModel>> GetUsersAsync();
        Task UpdateUser(UserModel user);
    }
}