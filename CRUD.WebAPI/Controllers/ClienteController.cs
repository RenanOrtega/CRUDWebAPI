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
        private readonly DataContext _context;

        public ClienteController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Clientes);
        }

        [HttpGet("ById")]
        public IActionResult GetById(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if(cliente == null) return BadRequest("O Cliente não foi encontrado");

            return Ok(cliente);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Nome.Contains(nome));
            if(cliente == null) return BadRequest("O Cliente não foi encontrado");

            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Cliente cliente)
        {
            var cli = _context.Clientes.AsNoTracking().FirstOrDefault(c => c.Id == id);
            if (cli == null) return BadRequest("Cliente não encontrado!");

            _context.Update(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Cliente cliente)
        {
            var cli = _context.Clientes.AsNoTracking().FirstOrDefault(c => c.Id == id);
            if (cli == null) return BadRequest("Cliente não encontrado!");

            _context.Update(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null) return BadRequest("Cliente não encontrado!");

            _context.Remove(cliente);
            _context.SaveChanges();
            return Ok();
        }
    }
}