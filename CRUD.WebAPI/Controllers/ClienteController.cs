using System.Linq;
using CRUD.WebAPI.Data;
using CRUD.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        public readonly IRepository _repo;

        public ClienteController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllClientes(true, true);
            return Ok(result);
        }

        [HttpGet("ById")]
        public IActionResult GetById(int id)
        {
            var cliente = _repo.GetClienteById(id, true, true);
            if (cliente == null) return BadRequest("O Cliente não foi encontrado");

            return Ok(cliente);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome)
        {
            var cliente = _repo.GetClienteByName(nome, true, true);
            if (cliente == null) return BadRequest("O Cliente não foi encontrado");

            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            _repo.Add(cliente);
            if (_repo.SaveChanges())
            {
                return Ok(cliente);
            }

            return BadRequest("Cliente não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Cliente cliente)
        {
            var cli = _repo.GetClienteById(id);
            if (cli == null) return BadRequest("Cliente não encontrado!");

            _repo.Update(cliente);
            if (_repo.SaveChanges())
            {
                return Ok(cliente);
            }
            
            return BadRequest("Cliente não atualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Cliente cliente)
        {
            var cli = _repo.GetClienteById(id);
            if (cli == null) return BadRequest("Cliente não encontrado!");

            _repo.Update(cli);
            if (_repo.SaveChanges())
            {
                return Ok(cliente);
            }
            
            return BadRequest("Cliente não atualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cli = _repo.GetClienteById(id);
            if (cli == null) return BadRequest("Cliente não encontrado!");

            _repo.Delete(cli);
            if (_repo.SaveChanges())
            {
                return Ok("Cliente deletado");
            }
            
            return BadRequest("Cliente não deletado");
        }
    }
}