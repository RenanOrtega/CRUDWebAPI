using System.Collections.Generic;
using System.Linq;
using CRUD.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        public List<Cliente> Clientes = new List<Cliente>(){
            new Cliente(){
                Id = 1,
                Nome = "Renan"
            },
            new Cliente(){
                Id = 2,
                Nome = "Silvao"
            },
            new Cliente(){
                Id = 3,
                Nome = "Victor"
            },
        };
        public ClienteController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Clientes);
        }

        [HttpGet("ById")]
        public IActionResult GetById(int id)
        {
            var cliente = Clientes.FirstOrDefault(c => c.Id == id);
            if(cliente == null) return BadRequest("O Cliente não foi encontrado");

            return Ok(cliente);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome)
        {
            var cliente = Clientes.FirstOrDefault(c => c.Nome.Contains(nome));
            if(cliente == null) return BadRequest("O Cliente não foi encontrado");

            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            return Ok(cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Cliente cliente)
        {
            return Ok(cliente);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Cliente cliente)
        {
            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}