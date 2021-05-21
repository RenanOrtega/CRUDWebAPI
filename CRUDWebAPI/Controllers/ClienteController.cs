using System.Threading.Tasks;
using CRUDWebAPI.Data;
using CRUDWebAPI.Helpers;
using CRUDWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDWebAPI.Controllers
{
    /// <summary>
    ///
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        public readonly IRepository _repo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        public ClienteController(IRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Método responsável por retornar todos os clientes
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PageParams pageParams)
        {
            var clientes = await _repo.GetAllClientesAsync(pageParams);
            return Ok(clientes);
        }

        /// <summary>
        /// Método responsável por retornar apenas um unico cliente pelo Código 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await _repo.GetClienteByIdAsync(id);
            if (cliente == null) return BadRequest("O Cliente não foi encontrado");

            return Ok(cliente);
        }

        /// <summary>
        /// Método responsável por retornar apenas um unico cliente pelo Nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpGet("ByName")]
        public async Task<IActionResult> GetByName([FromQuery] string nome)
        {
            var cliente = await _repo.GetClienteByNameAsync(nome);
            if (cliente == null) return BadRequest("O Cliente não foi encontrado");

            return Ok(cliente);
        }
        /// <summary>
        /// Método responsável por cadastrar clientes no banco de dados
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            _repo.Add(cliente);

            if (_repo.SaveChanges())
            {
                return Ok(cliente);
            }

            return BadRequest("Cliente não cadastrado");
        }
        /// <summary>
        /// Método responsável por atualizar o cliente por meio do Código Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Cliente cliente)
        {
            var cli = await _repo.GetClienteByIdAsync(id);
            if (cli == null) return BadRequest("Cliente não encontrado!");

            _repo.Update(cliente);
            if (_repo.SaveChanges())
            {
                return Ok(cliente);
            }

            return BadRequest("Cliente não atualizado");
        }
        /// <summary>
        /// Método responsável por atualizar o meu cliente por meio do código id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, [FromBody] Cliente cliente)
        {
            var cli = await _repo.GetClienteByIdAsync(id);
            if (cli == null) return BadRequest("Cliente não encontrado!");


            if (_repo.SaveChanges())
            {
                return Ok(cliente);
            }

            return BadRequest("Cliente não atualizado");
        }
        /// <summary>
        /// Método responsável por delete um cliente por meio do código Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cli = await _repo.GetClienteByIdAsync(id);
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