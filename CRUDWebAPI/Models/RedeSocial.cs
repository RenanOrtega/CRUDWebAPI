using CRUDWebAPI.Enum;

namespace CRUDWebAPI.Models
{
    public class RedeSocial
    {
        public RedeSocial(int id, TipoRedeSocial tipo, string link, string username, int clienteId)
        {
            this.Id = id;
            this.Tipo = tipo;
            this.Link = link;
            this.Username = username;
            this.ClienteId = clienteId;
        }
        public int Id { get; set; }
        public TipoRedeSocial Tipo { get; set; }
        public string Link { get; set; }
        public string Username { get; set; }
        public int ClienteId { get; set; }
    }
}