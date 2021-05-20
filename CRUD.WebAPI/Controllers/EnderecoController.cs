using Microsoft.AspNetCore.Mvc;

namespace CRUD.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : ControllerBase
    {
        public EnderecoController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Endereços: Renan, Silvio, Victor");
        }
    }
}