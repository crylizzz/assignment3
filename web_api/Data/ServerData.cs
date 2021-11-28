using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1WebApi.Models;
using FileData;

namespace Assignment1WebApi.Data
{
    public class ServerData:IServerData
    {
        private FileContext fileContext;

        public ServerData()
        {
            fileContext = new FileContext();
        }
        public async Task AddNewAdult(int fId, Adult adult)
        {
            if (!first.Adults.Any())
            {
                adult.Id = 0;
            }
            else
            {
                adult.Id = first.Adults.Max(d => d.Id) + 1;
            }
            first.Adults.Add(adult);
            fileContext.SaveChanges();
        }
        public async Task UpdateAdult(Adult adult)
        {
            Adult adultf = first.Adults.First(d => d.Id == adult.Id);
            adultf.FirstName = adult.FirstName;
            adultf.LastName = adult.LastName;
            adultf.EyeColor = adult.EyeColor;
            adultf.HairColor = adult.HairColor;
            adultf.Weight = adult.Weight;
            adultf.Age = adult.Age;
            adultf.Height = adult.Height;
            adultf.Sex = adult.Sex;
            fileContext.SaveChanges();
        }
        public async Task<Adult> GetAdult(int id)
        {
            return first.Adults.First(a => a.Id == id);
        }

        public async Task RemoveAdult(int fId, int id)
        {
            Family first = families.First(family => family.Id == fId);
            if (first == null)
            {
                throw  new Exception("Family not found");    
            }

            Adult toRemove = first.Adults.First(a => a.Id == id);
            first.Adults.Remove(toRemove);
            fileContext.SaveChanges();
        }
        public async Task<User> ValidateUser(string userName, string password)
        {
            User first = fileContext.Users.First(user => user.Username.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }
            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }
            return first;
        }
    }
}