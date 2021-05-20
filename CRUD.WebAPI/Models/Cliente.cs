using System;
using System.Collections.Generic;

namespace CRUD.WebAPI.Models
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(int id, string nome, DateTime dataNascimento, string cpf, string rg)
        {
            this.Id = id;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Cpf = cpf;
            this.Rg = rg;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<Telefone> Telefones { get; set; }
        public IList<Endereco> Enderecos { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}