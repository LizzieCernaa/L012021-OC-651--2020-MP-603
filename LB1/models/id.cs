using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace LB1.models
{
    public class id
    {
        [Key]
        public int usuarioId { get; set; }

        public int? rolId { get; set; }

        public string nombreUsuario { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}
