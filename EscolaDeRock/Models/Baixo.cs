using System;
using EscolaDeRock.interfaces;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models {
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia {
        public bool ManterRitmo () {
            System.Console.WriteLine ("Mantendo ritmo do baixo!");
            return true;
        }
        public bool TocarAcordes () {
            System.Console.WriteLine ("Tocando acordes do baixo");
            return true;
        }

    }
}