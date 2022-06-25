using Entidades;
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
    public partial class Resultado : Form
    {
        public Encuesta Encuesta { get; set; }
        public Resultado()
        {
            InitializeComponent();
        }

        private void lblTPaciente_Click(object sender, EventArgs e)
        {

        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            if (Encuesta == null)
            {
                return;
            }
            var preguntaRespuesta = Encuesta.Preguntas.ToList();
            var contadorDepresion = 0;
            var contadorAnsiedad = 0;
            var contadorEstres = 0;

            var paciente = Encuesta.Paciente;
            lblNombre.Text = $"{paciente.Nombre1} {paciente.Nombre2} {paciente.Apellido1} {paciente.Apellido2}";
            //Depresion
            var itemsDepresion = new List<int> { 3, 5, 10, 13, 16, 17, 21 };
            contadorDepresion = preguntaRespuesta
                .Where(x => itemsDepresion.Contains(x.PreguntaId)).Sum(x => x.RespuestaId);

            if (contadorDepresion >= 0 && contadorDepresion < 5)
            {
                LblDepresion.Visible = false; 
                lblResDepresion.Visible = false;
            }
            if (contadorDepresion >= 5 && contadorDepresion <= 6)
            {
                lblResDepresion.Text = $"{contadorDepresion} depresión Leve";
            }
            if (contadorDepresion > 6 && contadorDepresion <= 10)
            {
                lblResDepresion.Text = $"{contadorDepresion} depresión moderada";
            }
            if (contadorDepresion > 10 && contadorDepresion <= 13)
            {
                lblResDepresion.Text = $"{contadorDepresion} depresión severa";
            }
            if (contadorDepresion > 13)
            {
                lblResDepresion.Text = $"{contadorDepresion} depresión extremadamente severa";
            }

            //Ansiedad
            var itemsAnsiedad = new List<int> { 2, 4, 7, 9, 15, 19, 20 };
            contadorAnsiedad = preguntaRespuesta
                .Where(x => itemsAnsiedad.Contains(x.PreguntaId)).Sum(x => x.RespuestaId);


            if (contadorAnsiedad >= 0 && contadorAnsiedad < 4)
            {
                lblAnsiedad.Visible = false;
                lblResAnsiedad.Visible = false;
            }
            if (contadorAnsiedad == 4)
            {
                lblResAnsiedad.Text = $"{contadorAnsiedad} ansiedad Leve";
            }
            if (contadorAnsiedad > 4 && contadorAnsiedad <= 7)
            {
                lblResAnsiedad.Text = $"{contadorAnsiedad} ansiedad moderada";
            }
            if (contadorAnsiedad > 7 && contadorAnsiedad <= 9)
            {
                lblResAnsiedad.Text = $"{contadorAnsiedad} ansiedad severa";
            }
            if (contadorAnsiedad > 9)
            {
                lblResAnsiedad.Text = $"{contadorAnsiedad} ansiedad extremadamente severa";
            }

            //Estres
            var itemsEstres = new List<int> { 1,6,8,11,12,14,18 };
            contadorEstres = preguntaRespuesta
                .Where(x => itemsEstres.Contains(x.PreguntaId)).Sum(x => x.RespuestaId);

            if (contadorEstres >= 0 && contadorEstres < 8)
            {
                lblEstres.Visible = false;
                lblResEstres.Visible = false;
            }
            if (contadorEstres >= 8 && contadorEstres <= 9)
            {
                lblResEstres.Text = $"{contadorEstres} estrés Leve";
            }
            if (contadorEstres > 9 && contadorEstres <= 12)
            {
                lblResEstres.Text = $"{contadorEstres} estrés moderado";
            }
            if (contadorEstres > 12 && contadorEstres <= 16)
            {
                lblResEstres.Text = $"{contadorEstres} estrés severo";
            }
            if (contadorEstres > 16)
            {
                lblResEstres.Text = $"{contadorEstres} estrés extremadamente severo";
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
