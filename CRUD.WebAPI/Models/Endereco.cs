using CRUD.WebAPI.Enum;

namespace CRUD.WebAPI.Models
{
    public class Endereco
    {
        public Endereco() { }
        public Endereco(int id, string nome, TipoEndereco tipo, int clienteId)
        {
            this.Id = id;
            this.Nome = nome;
            this.Tipo = tipo;
            this.ClienteId = clienteId;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoEndereco Tipo { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}