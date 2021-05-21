using System;
using System.Collections.Generic;
using CRUDWebAPI.Enum;
using CRUDWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebAPI.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<RedeSocial> RedeSocial { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>()
                .HasData(new List<Cliente>(){
                    new Cliente(1, "Thais",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(2, "Renan",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(3, "Silvao",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(4, "Victor",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(5, "Thais",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(6, "Renan",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(7, "Silvao",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(8, "Victor",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(9, "Silvao",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(10, "Victor",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(11, "Thais",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(12, "Renan",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(13, "Silvao",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9"),
                    new Cliente(14, "Victor",DateTime.Parse("29/12/2001"),"503.570.378-98", "50.661.998-9")
                });
            builder.Entity<Telefone>()
                .HasData(new List<Telefone>(){
                    new Telefone(1,"(11) 1273468",Enum.TipoTelefone.Residencial,2),
                    new Telefone(2,"(11) 1111111",Enum.TipoTelefone.Institucional,2),
                    new Telefone(3,"(11) 2222222",Enum.TipoTelefone.Comercial,3),
                    new Telefone(4,"(11) 4444444",Enum.TipoTelefone.Residencial,4),
                    new Telefone(5,"(11) 5555555",Enum.TipoTelefone.Comercial,6),
                    new Telefone(6,"(11) 9999999",Enum.TipoTelefone.Institucional,7),
                    new Telefone(7,"(11) 1273468",Enum.TipoTelefone.Residencial,5),
                    new Telefone(8,"(11) 1111111",Enum.TipoTelefone.Institucional,2),
                    new Telefone(9,"(11) 2222222",Enum.TipoTelefone.Comercial,9),
                    new Telefone(10,"(11) 100001010",Enum.TipoTelefone.Residencial,8),
                    new Telefone(11,"(11) 111111111",Enum.TipoTelefone.Comercial,7),
                    new Telefone(12,"(11) 121212121",Enum.TipoTelefone.Institucional,13),
                    new Telefone(13,"(11) 133131313",Enum.TipoTelefone.Residencial,14),
                    new Telefone(14,"(11) 14141414",Enum.TipoTelefone.Comercial,12),
                    new Telefone(15,"(11) 15151515",Enum.TipoTelefone.Institucional,11)
                });
            builder.Entity<Endereco>()
                .HasData(new List<Endereco>(){
                    new Endereco(1,"Rua II",TipoEndereco.Industrial,2),
                    new Endereco(2,"Rua HH",TipoEndereco.Comercial,1),
                    new Endereco(3,"Rua GG",TipoEndereco.Residencial,3),
                    new Endereco(4,"Rua FF",TipoEndereco.Industrial,4),
                    new Endereco(5,"Rua EE",TipoEndereco.Comercial,5),
                    new Endereco(6,"Rua DD",TipoEndereco.Industrial,7),
                    new Endereco(7,"Rua CC",TipoEndereco.Industrial,8),
                    new Endereco(8,"Rua BB",TipoEndereco.Comercial,10),
                    new Endereco(9,"Rua LAA",TipoEndereco.Residencial,11),
                    new Endereco(10,"Rua ZZ",TipoEndereco.Industrial,12),
                    new Endereco(11,"Rua YY",TipoEndereco.Comercial,13),
                    new Endereco(12,"Rua XX",TipoEndereco.Industrial,14)
                });
            builder.Entity<RedeSocial>()
                .HasData(new List<RedeSocial>(){
                    new RedeSocial(1, TipoRedeSocial.Facebook, "www.a.com", "@vitao",1),
                    new RedeSocial(2, TipoRedeSocial.Instagram, "www.a.com", "@vitao",2),
                    new RedeSocial(3, TipoRedeSocial.Youtube, "www.a.com", "@vitao",3),
                    new RedeSocial(4, TipoRedeSocial.Twitter, "www.a.com", "@vitao",4),
                    new RedeSocial(5, TipoRedeSocial.Linkedin, "www.a.com", "@vitao",5),
                    new RedeSocial(6, TipoRedeSocial.Facebook, "www.a.com", "@vitao",6)
                });
        }
    }
}