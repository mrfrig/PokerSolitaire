using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerSolitaire.Model
{
    /// <summary>
    /// Representa un turno del juego, posee un arreglo de 4 cartas, 
    /// un nombre y una puntuacion segun la combinacion de cartas obtenida, 
    /// y una puntuacion acumulada hasta ese turno en el juego.
    /// </summary>
    public class Turno
    {
        private Carta[] cartas;

        private string nombreCombinacion;

        private int puntuacion;

        private int puntuacionAcumulada;

        /// <summary>
        /// Retorna el nombre de la combinacion obtenida segun las cartas que tiene el turno
        /// </summary>
        public string NombreCombinacion
        {
            get
            {
                return nombreCombinacion;
            }

        }

        /// <summary>
        /// Retorna la puntuacion obtenida segun la combinacion de cartas del turno
        /// </summary>
        public int Puntuacion
        {
            get
            {
                return puntuacion;

            }

        }

        /// <summary>
        /// Retorna la puntuacion acumulada hasta este turno
        /// </summary>
        public int PuntuacionAcumulada
        {
            get
            {
                return puntuacionAcumulada;

            }

        }

        /// <summary>
        /// Retorna un arreglo de cartas representadas como strings
        /// </summary>
        public string[] Cartas
        {
            get
            {
                return new string[]{cartas[0].CartaString, cartas[1].CartaString, cartas[2].CartaString, cartas[3].CartaString};
            }
        }

        /// <summary>
        /// Genera un turno tomando 4 cartas del mazo en clase Carta
        /// </summary>
        /// <param name="puntuacionAcumulada">Puntuacion Acumulada en el turno anterior al turno a registrar</param>
        public Turno(int puntuacionAcumulada)
        {
            cartas = new Carta[4];
            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i] = Carta.ObtenerCartaDeMazo();
            }

            DeterminarCombinacion();

            this.puntuacionAcumulada = puntuacionAcumulada + this.puntuacion;
        }

        /// <summary>
        /// Genera un turno creando cartas desde un arreglo de strings y eliminando dichas cartas del mazo
        /// </summary>
        /// <param name="cartas">Arreglo de strings que representa las 4 cartas a registrar en turno</param>
        /// <param name="puntuacionAcumulada">Puntuacion Acumulada en el turno anterior al turno a registrar</param>
        public Turno(string[] cartas, int puntuacionAcumulada)
        {
            this.cartas = new Carta[cartas.Length];

            for (int i = 0; i < cartas.Length; i++)
			{
			    for (int j = 0; j < Carta.VALORES.Length; j++)
			    {
                    for (int k = 0; k < Carta.PALOS.Length; k++)
                    {
                        if ( (cartas[i]) == (Carta.VALORES[j] + Carta.PALOS[k]) )
                        {
                            this.cartas[i] = new Carta(Carta.VALORES[j], Carta.PALOS[k]);

                            Carta.RemoverCartaDeMazo(this.cartas[i]);
                        }
                    }
			    }
			}

            DeterminarCombinacion();

            this.puntuacionAcumulada = puntuacionAcumulada + this.puntuacion;
        }

        /// <summary>
        /// Determina la combinacion obtenida del arreglo de cartas del turno
        /// </summary>
        private void DeterminarCombinacion()
        {
            if (Carta.DeterminarSiConsecutiva(this.cartas) && Carta.DeterminarSiMismoPalo(this.cartas))
            {
                this.puntuacion = 500;
                this.nombreCombinacion = "Straight Flush";
            }

            else if (Carta.DeterminarSiConsecutiva(this.cartas))
            {
                this.puntuacion = 300;
                this.nombreCombinacion = "Straight";
            }

            else if (Carta.DeterminarSiMismoValor(this.cartas))
            {
                this.puntuacion = 100;
                this.nombreCombinacion = "Full House";
            }

            else if (Carta.DeterminarSiMismoPalo(this.cartas))
            {
                this.puntuacion = 10;
                this.nombreCombinacion = "Flush";
            }

            else
            {
                this.puntuacion = -10;
                this.nombreCombinacion = "Ninguna";
            }
        }
    }
}
