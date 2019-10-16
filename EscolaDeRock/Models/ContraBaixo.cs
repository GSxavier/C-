using System;
using EscolaDeRock.interfaces;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models {
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia {
        public bool ManterRitmo () {
            System.Console.WriteLine ("Mantendo o ritmo do contrabaixo!");
            return true;
        }
        public bool TocarAcordes () {
            System.Console.WriteLine ("Tocando acordes do contrabaixo!");
            return true;
        }

    }
}