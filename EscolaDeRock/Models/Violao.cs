using System;
using EscolaDeRock.interfaces;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models {
    public class Violao : InstrumentoMusical, IMelodia, IPercussao, IHarmonia {
        public bool TocarAcordes () {
            System.Console.WriteLine ("Tocando acordes de violao!");
            return true;
        }
        public bool ManterRitmo () {
            System.Console.WriteLine ("Mantendo ritmo do violão!");
            return true;

        }
        public bool TocarSolo () {
            System.Console.WriteLine ("Tocando solo do violão!");
            return true;
        }

    }

}