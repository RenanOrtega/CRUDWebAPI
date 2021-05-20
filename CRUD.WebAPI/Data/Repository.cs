using System.Linq;
using CRUD.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.WebAPI.Data
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

        public Cliente[] GetAllClientes(bool includeTelefone = false, bool includeEndereco = false)
        {
            IQueryable<Cliente> query = _context.Clientes;
            if(includeEndereco && includeTelefone){
                query = query.Include(c => c.Enderecos)
                            .Include(c => c.Telefones);
            }

            query = query.AsNoTracking().OrderBy(c => c.Id);

            return query.ToArray();
        }

        public Cliente GetClienteById(int clienteId, bool includeTelefone = false, bool includeEndereco = false)
        {
            IQueryable<Cliente> query = _context.Clientes;
            if(includeEndereco && includeTelefone){
                query = query.Include(c => c.Enderecos)
                            .Include(c => c.Telefones);
            }

            query = query.AsNoTracking()
                        .OrderBy(c => c.Id)
                        .Where(cliente => cliente.Id == clienteId);

            return query.FirstOrDefault();
        }
        public Cliente GetClienteByName(string Nome, bool includeTelefone = false, bool includeEndereco = false)
        {
            IQueryable<Cliente> query = _context.Clientes;
            if(includeEndereco && includeTelefone){
                query = query.Include(c => c.Enderecos)
                            .Include(c => c.Telefones);
            }

            query = query.AsNoTracking()
                        .OrderBy(c => c.Nome)
                        .Where(Cliente => Cliente.Nome == Nome);

            return query.FirstOrDefault();
        }

        public Telefone[] GetAllTelefonesByClienteId(int clienteId)
        {
            IQueryable<Telefone> query = _context.Telefones;
            query = query.Include(c => c.Cliente);

            query = query.AsNoTracking()
                        .OrderBy(cliente => cliente.Id)
                        .Where(cliente => cliente.Id == clienteId);

            return query.ToArray();
        }

        public Endereco[] GetAllEnderecosByClienteId(int clienteId)
        {
            IQueryable<Endereco> query = _context.Enderecos;
            query = query.Include(c => c.Cliente);
            
            query = query.AsNoTracking()
                        .OrderBy(cliente => cliente.Id)
                        .Where(cliente => cliente.Id == clienteId);

            return query.ToArray();
        }
    } 
}