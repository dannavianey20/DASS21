using ConexionDB;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class RepositorioMaestro
    {
        DBDASS21Context _context = new DBDASS21Context();

        public List<Eps> ListaEps()
        {
            return _context.Eps.ToList();
        }

        public List<Genero> ListaGeneros()
        {
            return _context.Generos.ToList();
        }

        public List<Tipo> ListaTipoDocumentos()
        {
            return _context.TipoDocumentos.ToList();
        }

        public List<EstadoCivil> ListaEstadoCiviles()
        {
            return _context.EstadoCivil.ToList();
        }

        public List<Regimen> ListaRegimenes()
        {
            return _context.Regimenes.ToList();
        }

        public List<NivelEscolaridad> ListaNivelEscolaridades()
        {
            return _context.NivelEscolaridades.ToList();
        }

        public List<Ciudad> ListaCiudades()
        {
            return _context.Ciudades.ToList();
        }

        public List<Respuesta> ListaRespuestas()
        {
            return _context.Respuestas.ToList();
        }
    }
}
