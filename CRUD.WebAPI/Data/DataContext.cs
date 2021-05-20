using System.Collections.Generic;
using CRUD.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.WebAPI.Data
{
    
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Cliente>()
                .HasData(new List<Cliente>(){
                    new Cliente(2, "Thais","29/12/2001","503.570.378-98", "50.661.998-9"),
                    new Cliente(1, "Renan","29/12/2001","503.570.378-98", "50.661.998-9"),
                    new Cliente(3, "Silvao","29/12/2001","503.570.378-98", "50.661.998-9"),
                    new Cliente(4, "Victor","29/12/2001","503.570.378-98", "50.661.998-9")
                });
            builder.Entity<Telefone>()
                .HasData(new List<Telefone>(){
                    new Telefone(1,"(11) 1273468",Enum.TipoTelefone.Residencial,2),
                    new Telefone(2,"(11) 1111111",Enum.TipoTelefone.Institucional,2),
                    new Telefone(3,"(11) 2222222",Enum.TipoTelefone.Comercial,3),
                    new Telefone(4,"(11) 4444444",Enum.TipoTelefone.Residencial,4),
                    new Telefone(5,"(11) 5555555",Enum.TipoTelefone.Comercial,1),
                    new Telefone(6,"(11) 9999999",Enum.TipoTelefone.Institucional,1),
                });
            builder.Entity<Endereco>()
                .HasData(new List<Endereco>(){
                    new Endereco(1,"Rua Chico Bento", Enum.TipoEndereco.Industrial,2),
                    new Endereco(2,"Rua Maisa", Enum.TipoEndereco.Comercial,1),
                    new Endereco(3,"Rua Luisinho", Enum.TipoEndereco.Residencial,3),
                    new Endereco(4,"Rua Lindoinha", Enum.TipoEndereco.Industrial,1),
                    new Endereco(5,"Rua Seila", Enum.TipoEndereco.Comercial,2),
                    new Endereco(6,"Rua Chico Bento", Enum.TipoEndereco.Industrial,4),
                });
        }
    }
}