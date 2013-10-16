using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerSolitaire.Model;
using System.Collections.Generic;

namespace PokerSolitaireTest
{
    [TestClass]
    public class CartaTest
    {
        Carta carta;
        Carta carta2;
        Carta carta3;
        Carta carta4;

        [TestInitialize]
        public void TestInitialize()
        {
            Carta.GenerarMazoDeCartas();
            carta = new Carta("A", "S");
            carta2 = new Carta("A", "D");
            carta3 = new Carta("A", "H");
            carta4 = new Carta("A", "C");
        }

        [TestMethod]
        public void TestCompararConCartasIguales()
        {            
            carta2 = new Carta("A", "S");

            Assert.IsTrue(carta.CompararCon(carta2));
        }

        [TestMethod]
        public void TestCompararConCartasDiferentes()
        {
            Assert.IsFalse(carta.CompararCon(carta2));
        }

        [TestMethod]
        public void TestGenerarMazoDeCartasCrea52Cartas()
        {
            Assert.AreEqual(52, Carta.CartasRestantesEnMazo);
        }

        [TestMethod]
        public void TestGenerarMazoDeCartasCreaLas52CartasDeUnMazoNormalDeJuego()
        {
            Carta[] mazoCreado = Carta.Mazo;

            for (int i = 0; i < Carta.VALORES.Length; i++)
            {
                for (int j = 0; j < Carta.PALOS.Length; j++)
                {
                    Assert.IsTrue(ContieneCarta(mazoCreado, new Carta(Carta.VALORES[i], Carta.PALOS[j])));
                }
            }
        }

        [TestMethod]
        public void TestObtenerCartaDeMazoEliminaUnaCarta()
        {
            Carta.ObtenerCartaDeMazo();

            Assert.AreEqual(51, Carta.CartasRestantesEnMazo);
        }

        [TestMethod]
        public void TestObtenerCartaDeMazoEliminaLaCartaRetornada()
        {
            Carta retornada = Carta.ObtenerCartaDeMazo();

            Assert.IsFalse(ContieneCarta(Carta.Mazo, retornada));
        }

        [TestMethod]
        public void TestObtenerCartaDeMazoRetornaNullCuandoNoTieneCartas()
        {
            for (int i = 0; i < 52; i++)
            {
                Carta.ObtenerCartaDeMazo();
            }

            Assert.AreEqual(null, Carta.ObtenerCartaDeMazo());
        }

        [TestMethod]
        public void TestRemoverCartaDeMazoEliminaUnaCarta()
        {
            Carta.RemoverCartaDeMazo(carta);

            Assert.AreEqual(51, Carta.CartasRestantesEnMazo);
        }

        [TestMethod]
        public void TestRemoverCartaDeMazoEliminaLaCartaProvista()
        {
            Carta.RemoverCartaDeMazo(carta);

            Assert.IsFalse(ContieneCarta(Carta.Mazo, carta));
        }

        [TestMethod]
        public void TestDeterminarSiConsecutivaCuandoEstanConsecutivasYEnOrden()
        {
            carta = new Carta("A", "S");
            carta2 = new Carta("2", "S");
            carta3 = new Carta("3", "S");
            carta4 = new Carta("4", "S");

            Carta[] cartas = { carta, carta2, carta3, carta4 };

            Assert.IsTrue(Carta.DeterminarSiConsecutiva(cartas));
        }

        [TestMethod]
        public void TestDeterminarSiConsecutivaCuandoEstanConsecutivasPeroNoEnOrden()
        {
            carta4 = new Carta("4", "S");
            carta3 = new Carta("3", "H");
            carta = new Carta("A", "S");
            carta2 = new Carta("2", "D");

            Carta[] cartas = { carta, carta2, carta3, carta4 };

            Assert.IsTrue(Carta.DeterminarSiConsecutiva(cartas));
        }

        [TestMethod]
        public void TestDeterminarSiConsecutivaCuandoEstanConsecutivasYCuandoElAsRepresentaUn14()
        {
            carta4 = new Carta("J", "S");
            carta3 = new Carta("Q", "H");
            carta = new Carta("K", "S");
            carta2 = new Carta("A", "D");

            Carta[] cartas = { carta, carta2, carta3, carta4 };

            Assert.IsTrue(Carta.DeterminarSiConsecutiva(cartas));
        }

        [TestMethod]
        public void TestDeterminarSiConsecutivaCuandoNoEstanConsecutivas()
        {
            Carta[] cartas = { carta, carta2, carta3, carta4 };

            Assert.IsFalse(Carta.DeterminarSiConsecutiva(cartas));
        }

        [TestMethod]
        public void TestDeterminarSiMismoPaloCuandoTienenDiferentesPalos()
        {
            Carta[] cartas = { carta, carta2, carta3, carta4 };

            Assert.IsFalse(Carta.DeterminarSiMismoPalo(cartas));
        }

        [TestMethod]
        public void TestDeterminarSiMismoPaloCuandoTienenMismosPalos()
        {
            carta = new Carta("A", "S");
            carta2 = new Carta("2", "S");
            carta3 = new Carta("3", "S");
            carta4 = new Carta("4", "S");
            Carta[] cartas = {carta, carta2, carta3, carta4};

            Assert.IsTrue(Carta.DeterminarSiMismoPalo(cartas));
        }

        [TestMethod]
        public void TestDeterminarSiMismoValorCuandoTienenDiferentesValores()
        {
            carta = new Carta("A", "S");
            carta2 = new Carta("2", "S");
            carta3 = new Carta("3", "S");
            carta4 = new Carta("4", "S");

            Carta[] cartas = { carta, carta2, carta3, carta4 };

            Assert.IsFalse(Carta.DeterminarSiMismoValor(cartas));
        }

        [TestMethod]
        public void TestDeterminarSiMismoValorCuandoTienenMismosValores()
        {            
            Carta[] cartas = { carta, carta2, carta3, carta4 };

            Assert.IsTrue(Carta.DeterminarSiMismoValor(cartas));
        }
        

        private bool ContieneCarta(Carta[] cartas, Carta carta)
        {
            bool contieneCarta = false;

            for (int i = 0; i < cartas.Length; i++)
            {
                if (carta.CompararCon(cartas[i]))
                {
                    contieneCarta = true;
                }
            }

            return contieneCarta;
        }
        
    }
}
