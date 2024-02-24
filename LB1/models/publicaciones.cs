using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace LB1.models
{
    public class publicaciones
    {
        [Key]
        public int publicacionId { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }

        public int? usuarioId { get; set; }

    }
}
