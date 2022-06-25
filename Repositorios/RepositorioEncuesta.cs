using ConexionDB;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class RepositorioEncuesta
    {
        DBDASS21Context _context = new DBDASS21Context();

        public int NewId()
        {
            int id = 1;
            try
            {
                id = _context.Encuesta.Max(x => x.Id) + 1;
            }
            catch (Exception)
            {
            }

            return id;
        }

        public int NewIdPreguntaRespuesta()
        {
            int id = 1;
            try
            {
                id = _context.PreguntaRespuestas.Max(x => x.Id) + 1;
            }
            catch (Exception)
            {
            }

            return id;
        }

        public Encuesta ObtenerEncuestaPorPaciente(int pacienteId)
        {
            return _context.Encuesta.Where(x => x.PacienteId == pacienteId).FirstOrDefault();
        }

        public Encuesta ObtenerEncuesta(int id)
        {
            return _context.Encuesta
                .Include(x => x.Preguntas)
                .Where(x => x.Id == id).FirstOrDefault();
        }

        public bool CrearEncuesta(int pacienteId)
        {
            _context.Encuesta.Add(new Encuesta()
            {
                Id = NewId(),
                PacienteId = pacienteId,
            });
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public bool RegistrarRespuestas(List<PreguntaRespuesta> preguntaRespuestas)
        {
            var encuestaId = preguntaRespuestas.FirstOrDefault().EncuestaId;

            var actualPreguntaRespuestas = _context.PreguntaRespuestas
                .Where(x => x.EncuestaId == encuestaId).ToList();

            if (actualPreguntaRespuestas.Count > 0)
            {
                return false;
            }

            _context.PreguntaRespuestas.AddRange(preguntaRespuestas);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public bool ActualizarRespuestas(List<PreguntaRespuesta> preguntaRespuestas)
        {
            var encuestaId = preguntaRespuestas.FirstOrDefault().EncuestaId;

            var actualPreguntaRespuestasList = _context.PreguntaRespuestas
                .Where(x => x.EncuestaId == encuestaId).ToList();

            if (actualPreguntaRespuestasList.Count == 0)
            {
                return false;
            }

            foreach (var item in preguntaRespuestas)
            {
                var actualPreguntaRespuest = actualPreguntaRespuestasList
                    .FirstOrDefault(x => x.EncuestaId == item.EncuestaId 
                    && x.PreguntaId == item.PreguntaId);
                if (actualPreguntaRespuest != null)
                {
                    actualPreguntaRespuest.RespuestaId = item.RespuestaId;
                }
            }


            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public List<PreguntaRespuesta> ListaPreguntaRespuestas(int encuestaId)
        {
            return _context.PreguntaRespuestas.Where(x => x.EncuestaId == encuestaId).ToList();
        }
    }
}
