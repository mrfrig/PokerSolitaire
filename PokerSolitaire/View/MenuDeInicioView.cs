using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerSolitaire
{
    public partial class MenuDeInicioView : Form
    {
        public MenuDeInicioView()
        {
            InitializeComponent();
        }

        private void MenuDeInicioView_Load(object sender, EventArgs e)
        {

        }

        private void CargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> cartas = ArchivoController.CargarArchivo(ArchivoController.AbrirArchivo());

                Hide();
                JuegoView juegoView = new JuegoView(this);
                JuegoController juegoController = new JuegoController(juegoView, cartas);
                juegoView.ReferenciaAControlador(juegoController);
                juegoView.Show();
            }
            catch (InvalidDataException)
            {
                MessageBox.Show("Error en lectura de archivo");
            }
            
        }

        private void NuevoJuego_Click(object sender, EventArgs e)
        {
            Hide();
            JuegoView juegoView = new JuegoView(this);
            JuegoController juegoController = new JuegoController(juegoView);
            juegoView.ReferenciaAControlador(juegoController);
            juegoView.Show();
        }
    }
}
