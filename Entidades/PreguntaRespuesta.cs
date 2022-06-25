using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class PreguntaRespuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int EncuestaId { get; set; }
        public int PreguntaId { get; set; }
        public int RespuestaId { get; set; }

        public Encuesta Encuesta { get; set; }
        public Pregunta Pregunta { get; set; }
        public Respuesta Respuesta { get; set; }
    }
}