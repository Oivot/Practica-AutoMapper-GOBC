using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AutoMapperGOBC.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoMapperGOBC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UsuariosController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<UsuarioDTO> ObtenerUsuario(int id)
        {
            // Simular la obtención de un usuario (en una aplicación real, obtener de la base de datos)
            var usuario = new Usuario { Id = id, Nombre = "Juan Pérez" };

            // Mapear a UsuarioDto
            var usuarioDto = _mapper.Map<UsuarioDTO>(usuario);

            return Ok(usuarioDto);
        }
    }
}
