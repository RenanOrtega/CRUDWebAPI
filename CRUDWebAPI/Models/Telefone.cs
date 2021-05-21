using CRUDWebAPI.Enum;

namespace CRUDWebAPI.Models
{
    public class Telefone
    {
        public Telefone() { }
        public Telefone(int id, string numero, TipoTelefone tipo, int clienteId)
        {
            this.Id = id;
            this.Numero = numero;
            this.Tipo = tipo;
            this.ClienteId = clienteId;

        }
        public int Id { get; set; }
        public string Numero { get; set; }
        public TipoTelefone Tipo { get; set; }
        public int ClienteId { get; set; }
    }
}