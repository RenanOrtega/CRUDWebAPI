using CRUDWebAPI.Enum;

namespace CRUDWebAPI.Models
{
    public class Endereco
    {
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
    }
}