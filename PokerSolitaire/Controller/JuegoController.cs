using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokerSolitaire.Model;

namespace PokerSolitaire
{
    /**
    * Representa una clase encargada de manejar los datos y la interfaz grafica del juego
    */
    public class JuegoController
    {
        private List<Turno> turnos;

        private JuegoView juegoView;

        private int turnoEnVista;

        /**
         * Genera un controlador que empieza desde el primer turno del juego
         */
        public JuegoController(JuegoView juegoView)
        {
            this.juegoView = juegoView;
        }

        /**
	     *Genera un controlador que empieza desde el ultimo turno tomado desde un archivo. En caso de ser un archivo con todos los turnos solo permite al usuario navegar por los turnos del archivo.
	     */
        public JuegoController(JuegoView juegoView, List<string> turns)
        {
            this.juegoView = juegoView;
        }

        /**
         * Crea y registra un turno en la lista de turnos tomados
         */
        public void TomarTurno()
        {

        }

        /**
         * Genera y registra turnos desde una lista de strings provista.
         */
        private void GenerarTurnos(List<string> turns)
        {

        }

        /**
         * Actualiza la interfaz grafica del juego al turno que el usuario desee ver.
         */
        private void ActualizarView(int turno)
        {

        }

        /**
         * Actualiza la interfaz grafica del usuario cuando este se mueva de un turno a otro durante el juego.
         */
        public void ElegirTurno(int movimiento)
        {

        }
    }
}
