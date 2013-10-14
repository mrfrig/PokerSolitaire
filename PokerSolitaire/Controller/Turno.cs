using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerSolitaire.Controller
{
    /**
     * Representa un turno del juego, posee un arreglo de 4 cartas, un nombre y una puntuacion segun la combinacion de cartas obtenida, y una puntuacion acumulada hasta ese turno en el juego.
     */
    public class Turno
    {
        private Carta[] cartas;

        private readonly string nombreCombinacion;

        private int puntuacion;

        private int puntuacionAcumulada;

        public string NombreCombinacion
        {
            get
            {
                return nombreCombinacion;

            }

        }

        public int Puntuacion
        {
            get
            {
                return puntuacion;

            }

        }

        public int PuntuacionAcumulada
        {
            get
            {
                return puntuacionAcumulada;

            }

        }

        public static string[] _cartas;

        public static string[] Cartas
        {
            get
            {
                return _cartas;

            }

        }

        /**
         * Genera un turno tomando cartas del mazo
         */
        public Turno(int puntuacionAcumulada)
        {

        }

        /**
         * Genera un turno creando cartas desde un arreglo de strings y eliminando dichas cartas del mazo
         */
        public Turno(string[] cartas, int puntuacionAcumulada)
        {

        }

        /**
         * Determina la combinacion obtenida en un arreglo de 4 cartas.
         */
        private void DeterminarCombinacion()
        {

        }
    }
}
