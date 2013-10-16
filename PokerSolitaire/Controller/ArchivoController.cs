using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using PokerSolitaire.Model;

namespace PokerSolitaire
{
    /// <summary>
    /// Representa una clase encargada de manejar archivos de texto especificos del juego.
    /// </summary>
    public class ArchivoController
    {
        /// <summary>
        /// Genera una lista de strings desde un archivo que representan cartas en el juego.
        /// </summary>
        /// <param name="archivo">Archivo que contiene la partida</param>
        /// <returns>lista con cartas de partida</returns>
        public static List<string> CargarArchivo(StreamReader archivo)
        {
            List<string> cartas = new List<string>();
            string linea;
            int lineasLeidas = 0;

            while ((linea = archivo.ReadLine()) != null &&
                     !(String.IsNullOrWhiteSpace(linea)) &&
                     !(lineasLeidas > 12))
            {
                for (int i = 0; i < Carta.VALORES.Length; i++)
                {
                    for (int j = 0; j < Carta.PALOS.Length; j++)
                    {
                        if (linea.Contains(Carta.VALORES[i] + Carta.PALOS[j]))
                        {
                            if (!cartas.Contains(Carta.VALORES[i] + Carta.PALOS[j]))
                            {
                                cartas.Add(Carta.VALORES[i] + Carta.PALOS[j]);
                            }

                            else
                            {
                                throw new InvalidDataException();
                            }
                        }
                    }                   
                }

                if ((cartas.Count % 4) != 0)
                {
                    throw new InvalidDataException();
                }

                lineasLeidas++;
            }

            return cartas;
        }

        /// <summary>
        /// Abre un archivo de texto utilizando el explorador de archivos.
        /// </summary>
        /// <returns>retorna un StreamReader con el archivo seleccionado</returns>
        public static StreamReader AbrirArchivo()
        {
            StreamReader datos;

            string direccion = "";
            OpenFileDialog archivo = new OpenFileDialog();

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                direccion = archivo.FileName;
            }

            else
            {
                throw new FileLoadException();
            }

            datos = new StreamReader(direccion);

            return datos;
        }
    }
}
