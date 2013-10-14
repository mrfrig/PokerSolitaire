using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerSolitaire.Controller
{
    /**
 * Representa un objeto carta que posee un valor y palo
 */
public class Carta
{
	private string valor;

	private string palo;

	private static List<Carta> MAZO;

	public static string[] VALORES = { "A","2","3","4","5","6","7","8","9","10","J","Q","K" };

	public static string[] PALOS = { "C","S","H","D"};

	public string _Carta
	{
		get
		{
			return valor + palo;

		}

	}

	/**
	 * Genera una carta.
	 */
	public Carta(string valor, string palo)
	{
        this.valor = valor;
        this.palo = palo;
	}

    /**
     * Genera una lista de 52 cartas ordenadas de manera aleatorea para utilizar en el juego
     */
    public static void GenerarMazoDeCartas()
	{

	}

	/**
	 * Retorna y elimina una carta del mazo
	 */
	public static Carta ObtenerCartaDeMazo()
	{
		return null;
	}

	/**
	 * Elimina una carta del mazo.
	 */
	public static void RemoverCartaDeMazo(Carta carta)
	{

	}

	/**
	 * Determina si un arreglo de cartas son consecutivas unas de otras.
	 */
	public static bool DeterminarSiConsecutiva(Carta[] cartas)
	{
		return true;
	}

	/**
	 * Determina si un arreglo de cartas tienen el mismo palo.
	 */
	public static bool DeterminarSiMismoPalo(Carta[] cartas)
	{
		return true;
	}

	/**
	 * Determina si un arreglo de cartas tienen el mismo valor.
	 */
	public static bool DeterminarSiMismoValor(Carta[] cartas)
	{
		return true;
	}
}

}
