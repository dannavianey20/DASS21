using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    public class DBDASS21Context : DbContext
    {
        public DBDASS21Context():base("DefaultConnection")
        {

        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Tipo> TipoDocumentos { get; set; }
        public DbSet<Eps> Eps { get; set; }
        public DbSet<NivelEscolaridad> NivelEscolaridades { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<Regimen> Regimenes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Encuesta> Encuesta { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Respuesta> Respuestas { get; set; }
        public DbSet<PreguntaRespuesta> PreguntaRespuestas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Paciente>()
                .ToTable("Pacientes")
                .HasMany(x => x.Encuestas)
                .WithRequired(x => x.Paciente)
                .HasForeignKey(x => x.PacienteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tipo>()
                .ToTable("TipoDocumentos")
                .HasMany(x => x.Pacientes)
                .WithRequired(x => x.Tipo)
                .HasForeignKey(x => x.TipoId)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Eps>()
                .ToTable("Eps")
                .HasMany(x => x.Pacientes)
                .WithRequired(x => x.Eps)
                .HasForeignKey(x => x.EpsId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NivelEscolaridad>()
                .ToTable("NivelEscolaridad")
                .HasMany(x => x.Pacientes)
                .WithRequired(x => x.Nivelescolaridad)
                .HasForeignKey(x => x.NivelescolaridadId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ciudad>()
                .ToTable("Ciudades")
                .HasMany(x => x.Pacientes)
                .WithRequired(x => x.Ciudad)
                .HasForeignKey(x => x.CiudadId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstadoCivil>()
                .ToTable("EstadoCivil")
                .HasMany(x => x.Pacientes)
                .WithRequired(x => x.EstadoCivil)
                .HasForeignKey(x => x.EstadoCivilId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Regimen>()
                .ToTable("Regimenes")
                .HasMany(x => x.Pacientes)
                .WithRequired(x => x.Regimen)
                .HasForeignKey(x => x.RegimenId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genero>()
                .ToTable("Generos")
                .HasMany(x => x.Pacientes)
                .WithRequired(x => x.Genero)
                .HasForeignKey(x => x.GeneroId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Encuesta>()
                .ToTable("Encuesta")
                .HasMany(x => x.Preguntas)
                .WithRequired(x => x.Encuesta)
                .HasForeignKey(x => x.EncuestaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pregunta>()
                .ToTable("Preguntas")
                .HasMany(x => x.Preguntas)
                .WithRequired(x => x.Pregunta)
                .HasForeignKey(x => x.PreguntaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Respuesta>()
                .ToTable("Respuestas")
                .HasMany(x => x.Preguntas)
                .WithRequired(x => x.Respuesta)
                .HasForeignKey(x => x.RespuestaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PreguntaRespuesta>()
                .ToTable("PreguntaRespuestas");

        }
    }
}
