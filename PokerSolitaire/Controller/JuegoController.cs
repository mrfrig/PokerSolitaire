using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokerSolitaire.Model;

namespace PokerSolitaire
{
    /// <summary>
    /// Representa una clase encargada de manejar los datos y la interfaz grafica del juego
    /// </summary>
    public class JuegoController
    {
        private List<Turno> turnos;

        private JuegoView juegoView;

        private int turnoEnView;

        /// <summary>
        /// Genera un controlador que empieza desde el primer turno del juego
        /// </summary>
        /// <param name="juegoView">referencia al view del juego</param>
        public JuegoController(JuegoView juegoView)
        {
            Carta.GenerarMazoDeCartas();

            this.juegoView = juegoView;

            this.turnos = new List<Turno>();

            this.turnoEnView = 0;
        }

        /// <summary>
        /// Genera un controlador que empieza desde el ultimo turno tomado 
        /// desde un archivo. En caso de ser un archivo con todos los turnos 
        /// solo permite al usuario navegar por los turnos del archivo.
        /// </summary>
        /// <param name="juegoView">referencia al view del juego</param>
        /// <param name="turns">Lista para generar turnos de juego</param>
        public JuegoController(JuegoView juegoView, List<string> turns)
        {
            Carta.GenerarMazoDeCartas();

            this.juegoView = juegoView;

            this.turnos = new List<Turno>();

            GenerarTurnos(turns);

            this.turnoEnView = turnos.Count;

            ActualizarView(turnoEnView);
        }

        /// <summary>
        /// Crea y registra un turno en la lista de turnos tomados
        /// </summary>
        public void TomarTurno()
        {
            if (this.turnos.Count < 13)
            {
                // si es el primer turno, la puntuacion acumulada es igual a 0
                if (this.turnos.Count == 0)
                {
                    this.turnos.Add(new Turno(0));
                }

                // si es otro turno, la puntuacion acumulada es igual al turno anterior
                else
                {
                    this.turnos.Add(new Turno(this.turnos[this.turnos.Count - 1].PuntuacionAcumulada));
                }

                this.turnoEnView = turnos.Count;

                ActualizarView(turnoEnView);

                if (this.turnos.Count == 13)
                {
                    juegoView.ActivarDesactivarMazo = false;
                }
            }
        }

        /// <summary>
        /// Genera y registra turnos cada 4 cartas desde una lista de strings provista.
        /// </summary>
        /// <param name="turns">Lista para generar turnos</param>
        private void GenerarTurnos(List<string> turns)
        {
            string[] cartas = new string[4];
            int i = 0;

            while (i < turns.Count)
            {
                for (int j = 0; j < cartas.Length; j++)
                {
                    cartas[j] = turns[i];
                    i++;
                }

                // si es el primer turno, la puntuacion acumulada es igual a 0
                if (this.turnos.Count == 0)
                {
                    this.turnos.Add(new Turno(cartas, 0));
                }

                // si es otro turno, la puntuacion acumulada es igual al turno anterior
                else
                {
                    this.turnos.Add(new Turno(cartas, this.turnos[this.turnos.Count - 1].PuntuacionAcumulada));
                }
            }
        }

        /// <summary>
        /// Actualiza la interfaz grafica del juego al turno que el usuario desee ver.
        /// </summary>
        /// <param name="turno">Turno del [1, 13] que se desea ver</param>
        private void ActualizarView(int turno)
        {
            juegoView.CambiarNumeroDeTurno = turno.ToString();

            string[] cartas = this.turnos[--turno].Cartas;

            juegoView.CambiarImagenCarta1(cartas[0]);
            juegoView.CambiarImagenCarta2(cartas[1]);
            juegoView.CambiarImagenCarta3(cartas[2]);
            juegoView.CambiarImagenCarta4(cartas[3]);

            juegoView.CambiarNombreCombinacion = this.turnos[turno].NombreCombinacion;
            juegoView.CambiarPuntuacion = this.turnos[turno].Puntuacion.ToString();
            juegoView.CambiarPuntuacionAcumulada = this.turnos[turno].PuntuacionAcumulada.ToString();


            if ( (turno == 0) && (this.turnos.Count == 1) )
            {
                juegoView.CambiarImagenBotonAdelante("SiguienteDesactivado");
                juegoView.ActivarDesactivarAdelante = false;
                juegoView.CambiarImagenBotonAtras("AtrasDesactivado");
                juegoView.ActivarDesactivarAtras = false;
            }

            else if (turno == (this.turnos.Count - 1))
            {
                juegoView.CambiarImagenBotonAdelante("SiguienteDesactivado");
                juegoView.ActivarDesactivarAdelante = false;
                juegoView.CambiarImagenBotonAtras("AtrasActivado");
                juegoView.ActivarDesactivarAtras = true;
            }

            else if (turno == 0)
            {
                juegoView.CambiarImagenBotonAtras("AtrasDesactivado");
                juegoView.ActivarDesactivarAtras = false;
                juegoView.CambiarImagenBotonAdelante("SiguienteActivado");
                juegoView.ActivarDesactivarAdelante = true;
            }

            else
            {
                juegoView.CambiarImagenBotonAdelante("SiguienteActivado");
                juegoView.CambiarImagenBotonAtras("AtrasActivado");
                juegoView.ActivarDesactivarAdelante = true;
                juegoView.ActivarDesactivarAtras = true;
            }            
        }

        /// <summary>
        /// Actualiza la interfaz grafica del usuario cuando este se mueva de un turno a otro durante el juego.
        /// </summary>
        /// <param name="movimiento">Representa el movimiento hacia un turno adelante (1) o atras (-1)</param>
        public void MoverseEntreTurnos(int movimiento)
        {
            if (((turnoEnView + movimiento) <= turnos.Count) && ((turnoEnView + movimiento) >= 1))
            {
                turnoEnView += movimiento;
                ActualizarView(turnoEnView);
            }
            
        }
    }
}
