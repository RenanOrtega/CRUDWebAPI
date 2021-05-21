using System.Collections.Generic;
using System.Threading.Tasks;
using CRUDWebAPI.Helpers;
using CRUDWebAPI.Models;

namespace CRUDWebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        Task<PageList<Cliente>> GetAllClientesAsync(PageParams pageParams);
        Task<Cliente> GetClienteByIdAsync(int clienteId);
        Task<Cliente> GetClienteByNameAsync(string Nome);

    }
}