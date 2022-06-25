
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Respuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        public virtual ICollection<PreguntaRespuesta> Preguntas { get; set; } = new HashSet<PreguntaRespuesta>();
    }
}