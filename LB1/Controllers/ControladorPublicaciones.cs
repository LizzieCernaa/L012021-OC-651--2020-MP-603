using LB1.models;
using Microsoft.AspNetCore.Mvc;

namespace LB1.Controllers
{
    public class ControladorPublicaciones
    {
        [ApiController]
        [Route("api/publicaciones")]
        public class PublicacionesController : ControllerBase
        {
            private readonly ApplicationDbContext _context;

            public PublicacionesController(ApplicationDbContext context)
            {
                _context = context;
            }

            [HttpGet]
            public ActionResult<IEnumerable<Publicacion>> Get()
            {
            }

            [HttpGet("filtrarPorUsuario")]
            public ActionResult<IEnumerable<Publicacion>> FiltrarPublicacionesPorUsuario(int usuarioId)
            {
            }

        }

    }
}
