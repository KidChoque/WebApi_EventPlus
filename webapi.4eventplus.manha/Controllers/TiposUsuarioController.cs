using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi._4eventplus.manha.Domains;
using webapi._4eventplus.manha.Interfaces;
using webapi._4eventplus.manha.Repositories;

namespace webapi._4eventplus.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposUsuarioController : ControllerBase
    {
        private ITiposUsuarioRepository _tiposUsuarioRepository;

        public TiposUsuarioController()
        {
            _tiposUsuarioRepository = new TiposUsuarioRepository();
        }


        [HttpPost]

        public IActionResult Post(TiposUsuario tiposUsuario)
        {
            try
            {
                _tiposUsuarioRepository.Cadastrar(tiposUsuario);

                return Ok(201);
            }
            catch (Exception Erro)
            {

                return BadRequest(Erro.Message);
            }
        }
    }
}
