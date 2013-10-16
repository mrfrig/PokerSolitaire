using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerSolitaire.Model;
using System.Collections.Generic;

namespace PokerSolitaireTest
{
    [TestClass]
    public class TurnoTest
    {
        Turno turnoRandom;
        Turno turnoStraightFlush;
        Turno turnoStraight;
        Turno turnoFullHouse;
        Turno turnoFlush;
        Turno turnoNinguna;

        [TestInitialize]
        public void TestInitialize()
        {
            turnoStraightFlush = new Turno(new string[] { "4C", "5C", "6C", "7C" }, 100);
            turnoStraight = new Turno(new string[] { "4H", "5D", "6C", "7D" }, -10);
            turnoFullHouse = new Turno(new string[] { "10H", "10D", "10C", "10D" }, 1000);
            turnoFlush = new Turno(new string[] { "4H", "5H", "6H", "8H" }, 10);
            turnoNinguna = new Turno(new string[] { "4H", "5D", "6H", "8H" }, -100);
        }

        [TestMethod]
        public void TestTurnoRandomElimina4Cartas()
        {
            Carta.GenerarMazoDeCartas();

            turnoRandom = new Turno(400);

            Assert.AreEqual(48, Carta.CartasRestantesEnMazo);
        }

        [TestMethod]
        public void TestTurnoRandomCartasRegistradasEnTurnoNoEstanEnMazo()
        {
            Carta.GenerarMazoDeCartas();

            turnoRandom = new Turno(400);

            for (int i = 0; i < turnoRandom.Cartas.Length; i++)
            {
                Assert.IsFalse(ContieneCarta(Carta.Mazo, turnoRandom.Cartas[i]));
            }
        }

        [TestMethod]
        public void TestTurnoNoRandomPuntuacionDeCombinacionStraightFlush()
        {
            Assert.AreEqual(500, turnoStraightFlush.Puntuacion);
        }

        [TestMethod]
        public void TestTurnoNoRandomPuntuacionAcumuladaStraightFlush()
        {
            Assert.AreEqual(600, turnoStraightFlush.PuntuacionAcumulada);
        }

        [TestMethod]
        public void TestTurnoNoRandomNombreDeCombinacionStraightFlush()
        {
            Assert.AreEqual("Straight Flush", turnoStraightFlush.NombreCombinacion);
        }        

        [TestMethod]
        public void TestTurnoNoRandomPuntuacionDeCombinacionStraight()
        {
            Assert.AreEqual(300, turnoStraight.Puntuacion);
        }

        [TestMethod]
        public void TestTurnoNoRandomPuntuacionAcumuladaStraight()
        {
            Assert.AreEqual(290, turnoStraight.PuntuacionAcumulada);
        }

        [TestMethod]
        public void TestTurnoNoRandomNombreDeCombinacionStraight()
        {
            Assert.AreEqual("Straight", turnoStraight.NombreCombinacion);
        }

        [TestMethod]
        public void TestTurnoNoRandomPuntuacionDeCombinacionFullHouse()
        {
            Assert.AreEqual(100, turnoFullHouse.Puntuacion);
        }

        [TestMethod]
        public void TestTurnoNoRandomPuntuacionAcumuladaFullHouse()
        {
            Assert.AreEqual(1100, turnoFullHouse.PuntuacionAcumulada);
        }

        [TestMethod]
        public void TestTurnoNoRandomNombreDeCombinacionFullHouse()
        {
            Assert.AreEqual("Full House", turnoFullHouse.NombreCombinacion);
        }

        [TestMethod]
        public void TestTurnoNoRandomPuntuacionDeCombinacionFlush()
        {
            Assert.AreEqual(10, turnoFlush.Puntuacion);
        }

        [TestMethod]
        public void TestTurnoNoRandomPuntuacionAcumuladaFlush()
        {
            Assert.AreEqual(20, turnoFlush.PuntuacionAcumulada);
        }

        [TestMethod]
        public void TestTurnoNoRandomNombreDeCombinacionFlush()
        {
            Assert.AreEqual("Flush", turnoFlush.NombreCombinacion);
        }

        [TestMethod]
        public void TestTurnoNoRandomPuntuacionDeCombinacionNinguna()
        {
            Assert.AreEqual(-10, turnoNinguna.Puntuacion);
        }

        [TestMethod]
        public void TestTurnoNoRandomPuntuacionAcumuladaNinguna()
        {
            Assert.AreEqual(-110, turnoNinguna.PuntuacionAcumulada);
        }

        [TestMethod]
        public void TestTurnoNoRandomNombreDeCombinacionNinguna()
        {
            Assert.AreEqual("Ninguna", turnoNinguna.NombreCombinacion);
        }

        [TestMethod]
        public void TestTurnoNoRandomNombreDeCombinacionEliminaCartasDeMazo()
        {
            Carta[] cartas = Carta.Mazo;

            for (int i = 0; i < turnoNinguna.Cartas.Length; i++)
            {
                Assert.IsFalse(ContieneCarta(cartas, turnoNinguna.Cartas[i]));
            }
        }

        private bool ContieneCarta(Carta[] cartas, string carta)
        {
            bool contieneCarta = false;

            for (int i = 0; i < cartas.Length; i++)
            {
                if (cartas[i].CartaString == carta)
                {
                    contieneCarta = true;
                }
            }

            return contieneCarta;
        }
    }
}
