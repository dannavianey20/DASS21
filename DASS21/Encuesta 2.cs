using Entidades;
using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DASS21
{
    public partial class Encuesta2 : Form
    {
        RepositorioMaestro repm = new RepositorioMaestro();
        RepositorioEncuesta repEnc = new RepositorioEncuesta();
        public Entidades.Encuesta Encuesta { get; set; }

        public Encuesta2()
        {

            InitializeComponent();
        }

        private void Encuesta2_Load(object sender, EventArgs e)
        {
            if (Encuesta != null)
            {
                PacienteIdLbl.Text = Encuesta.PacienteId.ToString();
                EncuestaIdLbl.Text = Encuesta.Id.ToString();
            }
            else
            {
                return;
            }

            var respuestas = repm.ListaRespuestas();

            cboRespuesta1.DataSource = respuestas;
            cboRespuesta1.DisplayMember = "Nombre";
            cboRespuesta1.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta1.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 1)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta2.DataSource = respuestas.ToList();
            cboRespuesta2.DisplayMember = "Nombre";
            cboRespuesta2.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta2.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 2)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta3.DataSource = respuestas.ToList();
            cboRespuesta3.DisplayMember = "Nombre";
            cboRespuesta3.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta3.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 3)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta4.DataSource = respuestas.ToList();
            cboRespuesta4.DisplayMember = "Nombre";
            cboRespuesta4.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta4.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 4)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta5.DataSource = respuestas.ToList();
            cboRespuesta5.DisplayMember = "Nombre";
            cboRespuesta5.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta5.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 5)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta6.DataSource = respuestas.ToList();
            cboRespuesta6.DisplayMember = "Nombre";
            cboRespuesta6.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta6.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 6)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta7.DataSource = respuestas.ToList();
            cboRespuesta7.DisplayMember = "Nombre";
            cboRespuesta7.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta7.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 7)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta8.DataSource = respuestas.ToList();
            cboRespuesta8.DisplayMember = "Nombre";
            cboRespuesta8.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta8.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 8)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta9.DataSource = respuestas.ToList();
            cboRespuesta9.DisplayMember = "Nombre";
            cboRespuesta9.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta9.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 9)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta10.DataSource = respuestas.ToList();
            cboRespuesta10.DisplayMember = "Nombre";
            cboRespuesta10.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta10.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 10)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta11.DataSource = respuestas.ToList();
            cboRespuesta11.DisplayMember = "Nombre";
            cboRespuesta11.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta11.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 11)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta12.DataSource = respuestas.ToList();
            cboRespuesta12.DisplayMember = "Nombre";
            cboRespuesta12.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta12.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 12)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta13.DataSource = respuestas.ToList();
            cboRespuesta13.DisplayMember = "Nombre";
            cboRespuesta13.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta13.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 13)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta14.DataSource = respuestas.ToList();
            cboRespuesta14.DisplayMember = "Nombre";
            cboRespuesta14.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta14.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 14)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta15.DataSource = respuestas.ToList();
            cboRespuesta15.DisplayMember = "Nombre";
            cboRespuesta15.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta15.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 15)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta16.DataSource = respuestas.ToList();
            cboRespuesta16.DisplayMember = "Nombre";
            cboRespuesta16.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta16.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 16)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta17.DataSource = respuestas.ToList();
            cboRespuesta17.DisplayMember = "Nombre";
            cboRespuesta17.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta17.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 17)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta18.DataSource = respuestas.ToList();
            cboRespuesta18.DisplayMember = "Nombre";
            cboRespuesta18.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta18.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 18)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta19.DataSource = respuestas.ToList();
            cboRespuesta19.DisplayMember = "Nombre";
            cboRespuesta19.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta19.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 19)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta20.DataSource = respuestas.ToList();
            cboRespuesta20.DisplayMember = "Nombre";
            cboRespuesta20.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta20.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 20)
                .FirstOrDefault().RespuestaId;
            }


            cboRespuesta21.DataSource = respuestas.ToList();
            cboRespuesta21.DisplayMember = "Nombre";
            cboRespuesta21.ValueMember = "Id";
            if (Encuesta.Preguntas.Count > 0)
            {
                cboRespuesta21.SelectedValue = Encuesta.Preguntas
                .Where(x => x.PreguntaId == 21)
                .FirstOrDefault().RespuestaId;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar1_Click(object sender, EventArgs e)
        {
            //int pacienteId = int.Parse(PacienteIdLbl.Text);
            int encuestaId = int.Parse(EncuestaIdLbl.Text);
            int id = repEnc.NewIdPreguntaRespuesta();

            var preguntaRespuesta = new List<PreguntaRespuesta>()
            {
                new PreguntaRespuesta() {Id = id++, EncuestaId =  encuestaId, PreguntaId = 1, RespuestaId = (int)cboRespuesta1.SelectedValue },
                new PreguntaRespuesta() {Id = id++, EncuestaId =  encuestaId, PreguntaId = 2, RespuestaId = (int)cboRespuesta2.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 3, RespuestaId = (int)cboRespuesta3.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 4, RespuestaId = (int)cboRespuesta4.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 5, RespuestaId = (int)cboRespuesta5.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 6, RespuestaId = (int)cboRespuesta6.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 7, RespuestaId = (int)cboRespuesta7.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 8, RespuestaId = (int)cboRespuesta8.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 9, RespuestaId = (int)cboRespuesta9.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 10, RespuestaId = (int)cboRespuesta10.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 11, RespuestaId = (int)cboRespuesta11.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 12, RespuestaId = (int)cboRespuesta12.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 13, RespuestaId = (int)cboRespuesta13.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 14, RespuestaId = (int)cboRespuesta14.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 15, RespuestaId = (int)cboRespuesta15.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 16, RespuestaId = (int)cboRespuesta16.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 17, RespuestaId = (int)cboRespuesta17.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 18, RespuestaId = (int)cboRespuesta18.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 19, RespuestaId = (int)cboRespuesta19.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 20, RespuestaId = (int)cboRespuesta20.SelectedValue },
                new PreguntaRespuesta() {Id = id++,  EncuestaId =  encuestaId, PreguntaId = 21, RespuestaId = (int)cboRespuesta21.SelectedValue },
            };

            var encuesta = repEnc.ObtenerEncuesta(encuestaId);
            if (encuesta.Preguntas.Count == 0)
            {
                var result = repEnc.RegistrarRespuestas(preguntaRespuesta);
                if (!result)
                {
                    MessageBox.Show("El registro ha fallado por favor intentelo nuevamente");
                }
            }
            else
            {
                var result = repEnc.ActualizarRespuestas(preguntaRespuesta);
                if (!result)
                {
                    MessageBox.Show("El registro ha fallado por favor intentelo nuevamente");
                }
            }

            encuesta = repEnc.ObtenerEncuesta(encuestaId);
            Resultado resultado = new Resultado();
            resultado.Encuesta = encuesta;
            resultado.Show();


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnterior1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
