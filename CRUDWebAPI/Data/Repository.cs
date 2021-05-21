using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDWebAPI.Helpers;
using CRUDWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public async Task<PageList<Cliente>> GetAllClientesAsync(PageParams pageParams)
        {
            IQueryable<Cliente> query = _context.Clientes;

            query = query.AsNoTracking()
                .Include(c => c.Telefones)
                .Include(c => c.Enderecos)
                .Include(c => c.RedesSociais)
                .OrderBy(c => c.Id);

            //return await query.ToListAsync();
            return await PageList<Cliente>.CreateAsync(query, pageParams.PageNumber, pageParams.PageSize);
        }
        public async Task<Cliente> GetClienteByIdAsync(int clienteId)
        {
            IQueryable<Cliente> query = _context.Clientes;

            query = query.AsNoTracking()
                .Include(c => c.Telefones)
                .Include(c => c.Enderecos)
                .Include(c => c.RedesSociais)
                .OrderBy(c => c.Id)
                .Where(cliente => cliente.Id == clienteId);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<Cliente> GetClienteByNameAsync(string Nome)
        {
            IQueryable<Cliente> query = _context.Clientes;

            query = query.AsNoTracking()
                .Include(c => c.Telefones)
                .Include(c => c.Enderecos)
                .Include(c => c.RedesSociais)
                .OrderBy(c => c.Id)
                .Where(Cliente => Cliente.Nome == Nome);

            return await query.FirstOrDefaultAsync();
        }
    }
}