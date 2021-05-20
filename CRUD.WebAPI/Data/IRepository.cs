using CRUD.WebAPI.Models;

namespace CRUD.WebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        Cliente[] GetAllClientes(bool includeTelefone = false, bool includeEndereco = false);
        Cliente GetClienteById(int clienteId, bool includeTelefone = false, bool includeEndereco = false);
        Cliente GetClienteByName(string Nome, bool includeTelefone = false, bool includeEndereco = false);
        Telefone[] GetAllTelefonesByClienteId(int clienteId);
        Endereco[] GetAllEnderecosByClienteId(int clienteId);
    }
}