using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Encuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int PacienteId { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual ICollection<PreguntaRespuesta> Preguntas { get; set; } = new HashSet<PreguntaRespuesta>();
    }
}
