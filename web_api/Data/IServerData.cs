using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1WebApi.Data
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