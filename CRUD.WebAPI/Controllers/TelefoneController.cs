using Microsoft.AspNetCore.Mvc;

namespace CRUD.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TelefoneController : ControllerBase
    {
        public TelefoneController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Telefones: Renan, Silvio, Victor");
        }
    }
}