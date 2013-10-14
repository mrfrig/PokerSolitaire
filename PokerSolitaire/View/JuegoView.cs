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

        public JuegoView()
        {
            InitializeComponent();
        }

        private void JuegoView_Load(object sender, EventArgs e)
        {
        }

        internal void ReferenciaAControlador(JuegoController juegoController)
        {
            this.juegoController = juegoController;
        }
    }
}
