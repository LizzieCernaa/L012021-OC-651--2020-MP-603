using System.ComponentModel.DataAnnotations;

namespace LB1.models
{
    public class comentarios
    {
        [Key]
        public int cometarioId { get; set; }
        public int? publicacionId { get; set; }

        public string? comentario { get; set; }

        public int? usuarioId { get; set; }
    }
}
