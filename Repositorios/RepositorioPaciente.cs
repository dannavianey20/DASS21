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
    public class RepositorioPaciente
    {
        DBDASS21Context _context = new DBDASS21Context();

        public int NewId()
        {
            int id = 1;
            try
            {
                id = _context.Pacientes.Max(x => x.Id) + 1;
            }
            catch (Exception)
            {
            }

            return id;
        }

        public Paciente ObtenerPaciente(int id)
        {
            return _context.Pacientes.Where(x => x.Id == id).FirstOrDefault();
        }

        public Paciente ObtenerPacientePorNumeroDoc(string numeroId)
        {
            return _context.Pacientes
                .Where(x => x.Numeroid == numeroId).FirstOrDefault();
        }

        public bool CrearPaciente(Paciente model)
        {
            _context.Pacientes.Add(model);
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
        
        public bool ActualizarPaciente(Paciente model)
        {
            var actualPaciente = _context.Pacientes
                .Where(x => x.Id == model.Id).FirstOrDefault();
            if (actualPaciente == null)
            {
                return false;
            }
            actualPaciente.Numeroid = model.Numeroid;
            actualPaciente.Apellido1 = model.Apellido1;
            actualPaciente.Apellido2 = model.Apellido2;
            actualPaciente.Nombre1 = model.Nombre1;
            actualPaciente.Nombre2 = model.Nombre2;
            actualPaciente.CiudadId = model.CiudadId;
            actualPaciente.TipoId = model.TipoId;
            actualPaciente.Ocupacion = model.Ocupacion;
            actualPaciente.ContactoEmergencia = model.ContactoEmergencia;
            actualPaciente.Direccion = model.Direccion;
            actualPaciente.Email = model.Email;
            actualPaciente.EpsId = model.EpsId;
            actualPaciente.EstadoCivilId = model.EstadoCivilId;
            actualPaciente.FechaNacimiento = model.FechaNacimiento;
            actualPaciente.GeneroId = model.GeneroId;
            actualPaciente.NivelescolaridadId = model.NivelescolaridadId;
            actualPaciente.RegimenId = model.RegimenId;
            actualPaciente.Telefono = model.Telefono;
            actualPaciente.TipoId = model.TipoId;

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

        public bool EliminarPaciente(int id)
        {
            var actualPaciente = _context.Pacientes
                .Where(x => x.Id == id).FirstOrDefault();
            if (actualPaciente == null)
            {
                return false;
            }

            _context.Pacientes.Remove(actualPaciente);
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
    }
}
