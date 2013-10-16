using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerSolitaire.Model
{

 /// <summary>
 /// Representa un objeto carta que posee un valor y palo
 /// </summary>
public class Carta
{
	private string valor;

	private string palo;

	private static List<Carta> MAZO;

	public static readonly string[] VALORES = { "A","2","3","4","5","6","7","8","9","10","J","Q","K" };

	public static readonly string[] PALOS = { "C","S","H","D"};

    /// <summary>
    /// Retorna una string de la carta con el formato (Valor)(Palo)
    /// </summary>
	public string CartaString
	{
		get
		{
			return valor + palo;
		}

	}

    /// <summary>
    /// Retorna el numero de cartas que quedan en el mazo.(creada para facilitar test unitarios)
    /// </summary>
    public static int CartasRestantesEnMazo { get { return MAZO.Count; } }

    /// <summary>
    /// Retorna un arreglo con las cartas en el mazo (creada para facilitar test unitarios)
    /// </summary>
    public static Carta[] Mazo 
    { 
        get 
        { 
            Carta[] nuevo_mazo = new Carta[MAZO.Count];
            MAZO.CopyTo(nuevo_mazo);
            return nuevo_mazo; 
        } 
    }

	/// <summary>
	/// Genera una carta
	/// </summary>
	/// <param name="valor">valor de la carta (A, 1.... K)</param>
	/// <param name="palo">palo de la carta (S,C,H,D)</param>
	public Carta(string valor, string palo)
	{
        this.valor = valor;
        this.palo = palo;
	}

    /// <summary>
    ///  Genera una lista de 52 cartas ordenadas de manera aleatorea para utilizar en el juego
    /// </summary>
    public static void GenerarMazoDeCartas()
	{
        Random rand = new Random();
        Carta temp;
        int swap;
        MAZO = CrearMazo();

        for (int i = 0; i < MAZO.Count; i++)
        {
            swap = rand.Next(i, MAZO.Count);
            
            temp = MAZO[i];
            MAZO[i] = MAZO[swap];
            MAZO[swap] = temp;
        }
	}

    /// <summary>
    /// Genera una lista de 52 cartas ordenadas
    /// </summary>
    /// <returns>Retorna una lista de 52 cartas ordenadas</returns>
    private static List<Carta> CrearMazo()
    {
        List<Carta> mazo = new List<Carta>();

        for (int i = 0; i < VALORES.Length; i++)
        {
            for (int j = 0; j < PALOS.Length; j++)
            {
                mazo.Add(new Carta(VALORES[i], PALOS[j]));
            }
        }

        return mazo;
    }

	/// <summary>
    /// Retorna y elimina una carta del mazo si este todavia contiene cartas.
	/// </summary>
    /// <returns>Retorna una carta si hay cartas en el mazo retorna, de lo contrario retorna null </returns>
	public static Carta ObtenerCartaDeMazo()
	{
        if (MAZO.Count != 0)
        {
            Carta retorno = MAZO[0];
            MAZO.RemoveAt(0);
            return retorno;
        }

		return null;
	}

	/// <summary>
    /// Elimina una carta del mazo, dado que la carta exista en el mismo.
	/// </summary>
	/// <param name="carta">carta a eliminar del mazo</param>
	public static void RemoverCartaDeMazo(Carta carta)
	{
        for (int i = 0; i < MAZO.Count; i++)
        {
            if (carta.CompararCon(MAZO[i]))
            {
                MAZO.RemoveAt(i);
            }
        }
	}

    

	/// <summary>
    /// Determina si un arreglo de cartas estan consecutivas segun su valor
	/// </summary>
    /// <param name="cartas">Arreglo de cartas (4 cartas para poker solitaire)</param>
    /// <returns>Retorna true si las cartas estan consecutivas, de lo contrario false</returns>
	public static bool DeterminarSiConsecutiva(Carta[] cartas)
	{
        List<int> indicesSegunValor = new List<int>();

        // para determinar caso especial
        List<string> casoEspecial = new List<string>();

        bool consecutivas = true;

        for (int i = 0; i < cartas.Length; i++)
        {
            // para determinar caso especial
            casoEspecial.Add(cartas[i].valor);

            for (int j = 0; j < VALORES.Length; j++)
            {
                if (VALORES[j] == cartas[i].valor)
                {
                    indicesSegunValor.Add(j);
                    break;
                }
            }
        }

        indicesSegunValor.Sort();


        for (int i = 0, j = i + 1; j < indicesSegunValor.Count; i++, j++)
        {
            if ((indicesSegunValor[i] + 1) != (indicesSegunValor[j])) 
            {
                consecutivas = false;
            }
        }

        // caso especial de 4 cartas que poseeen valores J, Q, K y A
        if ( casoEspecial.Contains("J") && casoEspecial.Contains("Q") && 
             casoEspecial.Contains("K") && casoEspecial.Contains("A") )
        {
            consecutivas = true;
        }

        return consecutivas;
	}

	/// <summary>
    /// Determina si un arreglo de cartas tienen el mismo palo.
	/// </summary>
    /// <param name="cartas">Arreglo de cartas (4 cartas para poker solitaire)</param>
	/// <returns>Retorna true si todas las cartas tienen el mismo palo, de lo contrario false</returns>
	public static bool DeterminarSiMismoPalo(Carta[] cartas)
	{
        bool mismoPalo = true;

        for (int i = 0, j = i + 1; j < cartas.Length; i++, j++)
        {
            if (cartas[i].palo != cartas[j].palo)
            {
                mismoPalo = false;
            }
        }

        return mismoPalo;
	}

    /// <summary>
    /// Determina si un arreglo de cartas tienen el mismo valor.
    /// </summary>
    /// <param name="cartas">Arreglo de cartas (4 cartas para poker solitaire)</param>
    /// <returns>Retorna true si todas las cartas tienen el mismo valor, de lo contrario false</returns>
	public static bool DeterminarSiMismoValor(Carta[] cartas)
	{
        bool mismoValor = true;

        for (int i = 0, j = i + 1; j < cartas.Length; i++, j++)
        {
            if (cartas[i].valor != cartas[j].valor)
            {
                mismoValor = false;
            }
        }

        return mismoValor;
	}

    /// <summary>
    /// Compara esta instancia de Carta con otra instancia de Carta y determina si son la misma carta.
    /// </summary>
    /// <param name="otraCarta">carta a comparar</param>
    /// <returns>/Retorna true si son la misma carta y false si son diferentes</returns>
    public bool CompararCon(Carta otraCarta)
    {
        return (this.palo == otraCarta.palo) && (this.valor == otraCarta.valor);
    }
}

}
