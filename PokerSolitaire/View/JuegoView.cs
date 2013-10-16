using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerSolitaire
{
    public partial class JuegoView : Form
    {
        JuegoController juegoController;
        MenuDeInicioView menuDeInicioView;

        public JuegoView(MenuDeInicioView menuDeInicioView)
        {
            InitializeComponent();

            this.menuDeInicioView = menuDeInicioView;
            this.FormClosing += JuegoView_FormClosing;
        }

        public bool ActivarDesactivarMazo { set { this.mazo.Enabled = value; } }
        public bool ActivarDesactivarAdelante { set { this.adelante.Enabled = value; } }
        public bool ActivarDesactivarAtras { set { this.atras.Enabled = value; } }

        public string CambiarNumeroDeTurno { set { turno.Text = value; } }
        public string CambiarNombreCombinacion { set { nombreCombinacion.Text = "Combinación obtenida: " + value; } }
        public string CambiarPuntuacion { set { valorCombinacion.Text = "Valor de combinación: " + value; } }
        public string CambiarPuntuacionAcumulada { set { puntuacionAcumulada.Text = "Puntuación acumulada: " + value; } }

        public void CambiarImagenCarta1(string image) { carta1.BackgroundImage = DeterminarImagen(image); }
        public void CambiarImagenCarta2(string image) { carta2.BackgroundImage = DeterminarImagen(image); }
        public void CambiarImagenCarta3(string image) { carta3.BackgroundImage = DeterminarImagen(image); }
        public void CambiarImagenCarta4(string image) { carta4.BackgroundImage = DeterminarImagen(image); }


        public void CambiarImagenBotonAdelante(string image) { adelante.BackgroundImage = DeterminarImagen(image); }
        public void CambiarImagenBotonAtras(string image) { atras.BackgroundImage = DeterminarImagen(image); }

        
        
        private void JuegoView_Load(object sender, EventArgs e)
        {
        }

        internal void ReferenciaAControlador(JuegoController juegoController)
        {
            this.juegoController = juegoController;
        }

        private void mazo_Click(object sender, EventArgs e)
        {
            this.juegoController.TomarTurno();
        }

        private void adelante_Click(object sender, EventArgs e)
        {
            this.juegoController.MoverseEntreTurnos(1);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.juegoController.MoverseEntreTurnos(-1);
        }

        private void JuegoView_FormClosing(Object sender, FormClosingEventArgs e)
        {
            this.menuDeInicioView.Close();
        }

        /// <summary>
        /// Determina la imagen que corresponde en los Resources de un string dado
        /// </summary>
        /// <param name="image">string de imagen</param>
        /// <returns>Imagen que corresponde al string</returns>
        private Image DeterminarImagen(string image)
        {
            Image retorno = null;

            switch (image)
            {
                case "AC":
                    retorno = ((System.Drawing.Image)(Properties.Resources.AC));
                    break;

                case "AD":
                    retorno = ((System.Drawing.Image)(Properties.Resources.AD));
                    break;

                case "AH":
                    retorno = ((System.Drawing.Image)(Properties.Resources.AH));
                    break;

                case "AS":
                    retorno = ((System.Drawing.Image)(Properties.Resources.AS));
                    break;

                case "2C":
                    retorno = ((System.Drawing.Image)(Properties.Resources._2C));
                    break;

                case "2D":
                    retorno = ((System.Drawing.Image)(Properties.Resources._2D));
                    break;

                case "2H":
                    retorno = ((System.Drawing.Image)(Properties.Resources._2H));
                    break;

                case "2S":
                    retorno = ((System.Drawing.Image)(Properties.Resources._2S));
                    break;

                case "3C":
                    retorno = ((System.Drawing.Image)(Properties.Resources._3C));
                    break;

                case "3D":
                    retorno = ((System.Drawing.Image)(Properties.Resources._3D));
                    break;

                case "3H":
                    retorno = ((System.Drawing.Image)(Properties.Resources._3H));
                    break;

                case "3S":
                    retorno = ((System.Drawing.Image)(Properties.Resources._3S));
                    break;

                case "4C":
                    retorno = ((System.Drawing.Image)(Properties.Resources._4C));
                    break;


                case "4D":
                    retorno = ((System.Drawing.Image)(Properties.Resources._4D));
                    break;

                case "4H":
                    retorno = ((System.Drawing.Image)(Properties.Resources._4H));
                    break;

                case "4S":
                    retorno = ((System.Drawing.Image)(Properties.Resources._4S));
                    break;

                case "5C":
                    retorno = ((System.Drawing.Image)(Properties.Resources._5C));
                    break;


                case "5D":
                    retorno = ((System.Drawing.Image)(Properties.Resources._5D));
                    break;


                case "5H":
                    retorno = ((System.Drawing.Image)(Properties.Resources._5H));
                    break;


                case "5S":
                    retorno = ((System.Drawing.Image)(Properties.Resources._5S));
                    break;


                case "6C":
                    retorno = ((System.Drawing.Image)(Properties.Resources._6C));
                    break;


                case "6D":
                    retorno = ((System.Drawing.Image)(Properties.Resources._6D));
                    break;


                case "6H":
                    retorno = ((System.Drawing.Image)(Properties.Resources._6H));
                    break;


                case "6S":
                    retorno = ((System.Drawing.Image)(Properties.Resources._6S));
                    break;


                case "7C":
                    retorno = ((System.Drawing.Image)(Properties.Resources._7C));
                    break;


                case "7D":
                    retorno = ((System.Drawing.Image)(Properties.Resources._7D));
                    break;


                case "7H":
                    retorno = ((System.Drawing.Image)(Properties.Resources._7H));
                    break;


                case "7S":
                    retorno = ((System.Drawing.Image)(Properties.Resources._7S));
                    break;


                case "8C":
                    retorno = ((System.Drawing.Image)(Properties.Resources._8C));
                    break;


                case "8D":
                    retorno = ((System.Drawing.Image)(Properties.Resources._8D));
                    break;


                case "8H":
                    retorno = ((System.Drawing.Image)(Properties.Resources._8H));
                    break;


                case "8S":
                    retorno = ((System.Drawing.Image)(Properties.Resources._8S));
                    break;


                case "9C":
                    retorno = ((System.Drawing.Image)(Properties.Resources._9C));
                    break;


                case "9D":
                    retorno = ((System.Drawing.Image)(Properties.Resources._9D));
                    break;


                case "9H":
                    retorno = ((System.Drawing.Image)(Properties.Resources._9H));
                    break;


                case "9S":
                    retorno = ((System.Drawing.Image)(Properties.Resources._9S));
                    break;


                case "10C":
                    retorno = ((System.Drawing.Image)(Properties.Resources._10C));
                    break;


                case "10D":
                    retorno = ((System.Drawing.Image)(Properties.Resources._10D));
                    break;


                case "10H":
                    retorno = ((System.Drawing.Image)(Properties.Resources._10H));
                    break;


                case "10S":
                    retorno = ((System.Drawing.Image)(Properties.Resources._10S));
                    break;


                case "JC":
                    retorno = ((System.Drawing.Image)(Properties.Resources.JC));
                    break;


                case "JD":
                    retorno = ((System.Drawing.Image)(Properties.Resources.JD));
                    break;


                case "JH":
                    retorno = ((System.Drawing.Image)(Properties.Resources.JH));
                    break;


                case "JS":
                    retorno = ((System.Drawing.Image)(Properties.Resources.JS));
                    break;


                case "QC":
                    retorno = ((System.Drawing.Image)(Properties.Resources.QC));
                    break;


                case "QD":
                    retorno = ((System.Drawing.Image)(Properties.Resources.QD));
                    break;


                case "QH":
                    retorno = ((System.Drawing.Image)(Properties.Resources.QH));
                    break;


                case "QS":
                    retorno = ((System.Drawing.Image)(Properties.Resources.QS));
                    break;


                case "KC":
                    retorno = ((System.Drawing.Image)(Properties.Resources.KC));
                    break;


                case "KD":
                    retorno = ((System.Drawing.Image)(Properties.Resources.KD));
                    break;


                case "KH":
                    retorno = ((System.Drawing.Image)(Properties.Resources.KH));
                    break;


                case "KS":
                    retorno = ((System.Drawing.Image)(Properties.Resources.KS));
                    break;

                case "SiguienteActivado":
                    retorno = ((System.Drawing.Image)(Properties.Resources.SiguienteActivado));
                    break;

                case "AtrasActivado":
                    retorno = ((System.Drawing.Image)(Properties.Resources.AtrasActivado));
                    break;

                case "SiguienteDesactivado":
                    retorno = ((System.Drawing.Image)(Properties.Resources.SiguienteDesactivado));
                    break;

                case "AtrasDesactivado":
                    retorno = ((System.Drawing.Image)(Properties.Resources.AtrasDesactivado));
                    break;
            }

            return retorno;
        }
    }
}
