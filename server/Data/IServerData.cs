using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment_1.Models;

namespace Assignment_1.Data
{
    public interface IServerData
    {
        Task AddNewAdult(int fId, Adult adult);
        Task UpdateAdult(int fId, Adult adult);
        Task<Adult> GetAdult(int fId, int id);
        Task RemoveAdult(int fId, int id);
        Task<User> ValidateUser(string userName, string password);
    }
}