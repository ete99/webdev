using System.Collections.Generic;
using System.Threading.Tasks;
using EApp.API.Models;

namespace EApp.API.Data
{
    public interface IFullRepository
    {
         void Add<T> (T entity) where T: class;
         void Delete<T> (T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}