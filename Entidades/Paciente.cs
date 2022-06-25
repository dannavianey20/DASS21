using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Nombre1 { get; set; }
        
        [StringLength(50)]
        public string Nombre2 { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Apellido1 { get; set; }
        
        [StringLength(50)]
        public string Apellido2 { get; set; }
        
        [Required]
        [Range(1,99)]
        public int TipoId { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Numeroid { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Telefono { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Direccion { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Ocupacion { get; set; }
        
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [StringLength(50)]
        public string ContactoEmergencia { get; set; }
        
        [Required]
        [Range(1, 99)]
        public int GeneroId { get; set; }
        
        [Required]
        [Range(1, 99)]
        public int EstadoCivilId { get; set; }
        
        [Required]
        [Range(1, 99)]
        public int RegimenId { get; set; }
        
        [Required]
        [Range(1, 99)]
        public int NivelescolaridadId { get; set; }
        
        [Required]
        [Range(1, 99)]
        public int EpsId { get; set; }
        
        [Required]
        [Range(1, 99)]
        public int CiudadId { get; set; }

        public virtual Tipo Tipo { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Regimen Regimen { get; set; }
        public virtual NivelEscolaridad Nivelescolaridad { get; set; }
        public virtual Eps Eps { get; set; }
        public virtual Ciudad Ciudad { get; set; }


        public virtual ICollection<Encuesta> Encuestas { get; set; } = new HashSet<Encuesta>();

    }
}
