using LB1.models;
using Microsoft.AspNetCore.Mvc;

namespace LB1.Controllers
{
    public class ControladorComentarios
    {
        [ApiController]
        [Route("api/comentarios")]
        public class ComentariosController : ControllerBase
        {
            private readonly ApplicationDbContext _context;

            public ComentariosController(ApplicationDbContext context)
            {
                _context = context;
            }

            [HttpGet]
            public ActionResult<IEnumerable<Comentario>> Get()
            {
            }

            [HttpGet("filtrarPorPublicacion")]
            public ActionResult<IEnumerable<Comentario>> FiltrarComentariosPorPublicacion(int publicacionId)
            {
            }

        }

    }
}
