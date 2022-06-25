using Entidades;
using Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DASS21
{
    public partial class Paciente : Form
    {
        //Encuesta encuesta = new Encuesta() { Paciente = new Entidades.Paciente() };
        RepositorioMaestro repm = new RepositorioMaestro();
        RepositorioPaciente repoPac = new RepositorioPaciente();
        RepositorioEncuesta repEnc = new RepositorioEncuesta();
        public Paciente()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int pacienteId = int.Parse(IdLbl.Text);
            if (pacienteId == 0)
            {
                MessageBox.Show("Para poder Iniciar debe crear el paciente primero");
                return;
            }
            var encuesta = repEnc.ObtenerEncuestaPorPaciente(pacienteId);
            if (encuesta == null)
            {
                repEnc.CrearEncuesta(pacienteId);
                encuesta = repEnc.ObtenerEncuestaPorPaciente(pacienteId);
            }
            Encuesta2 encuesta2 = new Encuesta2();
            encuesta2.Encuesta = encuesta;
            encuesta2.Show();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Encuesta_Load(object sender, EventArgs e)
        {
            dtpFechanacimiento.Value = DateTime.Now.AddYears(-10);
            //Genereos
            var generos = repm.ListaGeneros();
            generos.Add(new Genero() { Id = 0, Nombre = "Seleccione un genero" });
            cboGenero.DataSource = generos.OrderBy(x => x.Id).ToList();
            cboGenero.DisplayMember = "Nombre";
            cboGenero.ValueMember = "Id";

            //Tipos de Documento
            var tipoDocs = repm.ListaTipoDocumentos();
            tipoDocs.Add(new Tipo() { Id = 0, Nombre = "Seleccione un tipo de Documento" });
            cboTipoId.DataSource = tipoDocs.OrderBy(x => x.Id).ToList();
            cboTipoId.DisplayMember = "Nombre";
            cboTipoId.ValueMember = "Id";

            //Estado Civil
            var estadoCiviles = repm.ListaEstadoCiviles();
            estadoCiviles.Add(new EstadoCivil() { Id = 0, Nombre = "Seleccione un Estado Civil" });
            cboEstadoCivil.DataSource = estadoCiviles.OrderBy(x => x.Id).ToList();
            cboEstadoCivil.DisplayMember = "Nombre";
            cboEstadoCivil.ValueMember = "Id";

            //Regimenes
            var regimenes = repm.ListaRegimenes();
            regimenes.Add(new Regimen() { Id = 0, Nombre = "Seleccione un regimen" });
            cboRegimen.DataSource = regimenes.OrderBy(x => x.Id).ToList();
            cboRegimen.DisplayMember = "Nombre";
            cboRegimen.ValueMember = "Id";

            //Eps
            var epsList = repm.ListaEps();
            epsList.Add(new Eps() { Id = 0, Nombre = "Seleccione una EPS" });
            cboEps.DataSource = epsList.OrderBy(x => x.Id).ToList();
            cboEps.DisplayMember = "Nombre";
            cboEps.ValueMember = "Id";

            //Nivel Escolaridad
            var nivelEsc = repm.ListaNivelEscolaridades();
            nivelEsc.Add(new NivelEscolaridad() { Id = 0, Nombre = "Seleccione un nivel de escolaridad" });
            cboNivelescolaridad.DataSource = nivelEsc.OrderBy(x => x.Id).ToList();
            cboNivelescolaridad.DisplayMember = "Nombre";
            cboNivelescolaridad.ValueMember = "Id";

            //Ciudades
            var ciudades = repm.ListaCiudades();
            ciudades.Add(new Ciudad() { Id = 0, Nombre = "Seleccione una ciudad" });
            cboCiudad.DataSource = ciudades.OrderBy(x => x.Id).ToList();
            cboCiudad.DisplayMember = "Nombre";
            cboCiudad.ValueMember = "Id";


            txtEdad.Text = ObtenerEdadPaciente(dtpFechanacimiento.Value).ToString();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validar los datos ingresados

            var paciente = new Entidades.Paciente();

            bool isvalid = ValidationFormControls();
            if (!isvalid)
            {
                return;
            }
            paciente.Id = int.Parse(IdLbl.Text);
            paciente.Nombre1 = txtNombre1.Text.Trim().ToUpper();
            paciente.Nombre2 = txtNombre2.Text.Trim().Length > 0 ? txtNombre2.Text.Trim().ToUpper() : null;
            paciente.Apellido1 = txtApellido1.Text.Trim().ToUpper();
            paciente.Apellido2 = txtApellido2.Text.Trim().Length > 0 ? txtApellido2.Text.Trim().ToUpper() : null;
            paciente.TipoId = (cboTipoId.SelectedItem as Tipo).Id;
            paciente.Numeroid = txtNumeroid.Text.Trim();
            paciente.FechaNacimiento = dtpFechanacimiento.Value;
            paciente.Telefono = txtTelefono.Text;
            paciente.ContactoEmergencia = txtContactoemergencia.Text;
            paciente.Direccion = txtDireccion.Text;
            paciente.Ocupacion = txtOcupacion.Text;
            paciente.Email = txtEmail.Text;
            paciente.CiudadId = (cboCiudad.SelectedItem as Ciudad).Id;
            paciente.GeneroId = (cboGenero.SelectedItem as Genero).Id;
            paciente.RegimenId = (cboRegimen.SelectedItem as Regimen).Id;
            paciente.EstadoCivilId = (cboEstadoCivil.SelectedItem as EstadoCivil).Id;
            paciente.EpsId = (cboEps.SelectedItem as Eps).Id;
            paciente.NivelescolaridadId = (cboNivelescolaridad.SelectedItem as NivelEscolaridad).Id;


            if (paciente.Id == 0)
            {
                paciente.Id = repoPac.NewId();
                var result = repoPac.CrearPaciente(paciente);
                if (!result)
                {
                    MessageBox.Show("La creación del paciente ha fallado");
                }
                IdLbl.Text = paciente.Id.ToString();
                repEnc.CrearEncuesta(paciente.Id);
                MessageBox.Show("Paciente creado correctamente");
            }
            else
            {
                var result = repoPac.ActualizarPaciente(paciente);
                if (!result)
                {
                    MessageBox.Show("La actualizacion del paciente ha fállado");
                }
                var encuesta = repEnc.ObtenerEncuestaPorPaciente(paciente.Id);
                if (encuesta == null)
                {
                    repEnc.CrearEncuesta(paciente.Id);
                }

                MessageBox.Show("Paciente actualizado correctamente");
            }
            


        }

        private bool ValidationFormControls()
        {

            if (string.IsNullOrEmpty(txtNombre1.Text) || string.IsNullOrWhiteSpace(txtNombre1.Text))
            {
                MessageBox.Show("Por favor escriba el primer nombre del paciente");
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido1.Text) || string.IsNullOrWhiteSpace(txtApellido1.Text)) 
            {
                MessageBox.Show("Por favor escriba el primer apellido del paciente");
                return false;
            }
            if ((cboTipoId.SelectedItem as Tipo).Id == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento");
                cboTipoId.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNumeroid.Text) || string.IsNullOrWhiteSpace(txtNumeroid.Text))
            {
                MessageBox.Show("Por favor escriba el número del documento de identificación");
                return false;
            }
            if (ObtenerEdadPaciente(dtpFechanacimiento.Value) <= 10)
            {
                MessageBox.Show("El paciente es menor de edad");
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor escriba el número de teléfono del paciente");
                return false;
            }
            if (string.IsNullOrEmpty(txtContactoemergencia.Text) || string.IsNullOrWhiteSpace(txtContactoemergencia.Text))
            {
                MessageBox.Show("Por favor escriba el número de telefono de contacto para emergencias");
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor escriba la dirección del paciente");
                return false;
            }
            if (string.IsNullOrEmpty(txtOcupacion.Text) || string.IsNullOrWhiteSpace(txtOcupacion.Text))
            {
                MessageBox.Show("Por favor escriba la ocupación del paciente");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor escriba correo del paciente");
                return false;
            }
            if ((cboCiudad.SelectedItem as Ciudad).Id == 0)
            {
                MessageBox.Show("Debe seleccionar la ciudad");
                return false;
            }
            if ((cboGenero.SelectedItem as Genero).Id == 0)
            {
                MessageBox.Show("Debe seleccionar el genero");
                return false;
            }
            if ((cboRegimen.SelectedItem as Regimen).Id == 0)
            {
                MessageBox.Show("Debe seleccionar el regimen");
                return false;
            }
            if ((cboEstadoCivil.SelectedItem as EstadoCivil).Id == 0)
            {
                MessageBox.Show("Debe seleccionar el estado civil");
                return false;
            }
            if ((cboEps.SelectedItem as Eps).Id == 0)
            {
                MessageBox.Show("Debe seleccionar la EPS");
                return false;
            }
            if ((cboNivelescolaridad.SelectedItem as NivelEscolaridad).Id == 0)
            {
                MessageBox.Show("Debe seleccionar el nivel de Escolaridad del paciente");
                return false;
            }

            return true;
        }

        private void dtpFechanacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = ObtenerEdadPaciente(dtpFechanacimiento.Value).ToString();
        }

        private int ObtenerEdadPaciente(DateTime fechaNacimiento)
        {
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - fechaNacimiento.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (fechaNacimiento.Date > today.AddYears(-age)) age--;
            return age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text) || string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Debe escribir un número de documento del paciente a buscar");
                return;
            }
            var paciente = repoPac.ObtenerPacientePorNumeroDoc(txtBuscar.Text);
            if (paciente == null)
            {
                MessageBox.Show("No se ha encontrado ningún paciente registrado con este número de documento");
                return;
            }

            IdLbl.Text = paciente.Id.ToString();
            txtApellido1.Text = paciente.Apellido1;
            txtApellido2.Text = paciente.Apellido2;
            txtNombre1.Text = paciente.Nombre1;
            txtNombre2.Text = paciente.Nombre2;
            txtContactoemergencia.Text = paciente.ContactoEmergencia;
            txtDireccion.Text = paciente.Direccion;
            dtpFechanacimiento.Value = paciente.FechaNacimiento;
            txtEdad.Text = ObtenerEdadPaciente(paciente.FechaNacimiento).ToString();
            txtEmail.Text = paciente.Email;
            txtNumeroid.Text = paciente.Numeroid;
            txtOcupacion.Text = paciente.Ocupacion;
            txtTelefono.Text = paciente.Telefono;
            //Combo
            cboCiudad.SelectedValue = paciente.CiudadId;
            cboEps.SelectedValue = paciente.EpsId;
            cboEstadoCivil.SelectedValue = paciente.EstadoCivilId;
            cboGenero.SelectedValue = paciente.GeneroId;
            cboNivelescolaridad.SelectedValue = paciente.NivelescolaridadId;
            cboRegimen.SelectedValue = paciente.RegimenId;
            cboTipoId.SelectedValue = paciente.TipoId;

            txtBuscar.Text = string.Empty;
        }

        //Crear usuario en la base de datos

    }
}



