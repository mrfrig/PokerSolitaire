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
            
        }

        private void NuevoJuego_Click(object sender, EventArgs e)
        {
            Hide();
            JuegoView juegoView = new JuegoView();
            JuegoController juegoController = new JuegoController(juegoView);
            juegoView.ReferenciaAControlador(juegoController);
            juegoView.Show();
        }
    }
}
