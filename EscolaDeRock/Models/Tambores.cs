using EscolaDeRock.Interfaces;
using System;

namespace EscolaDeRock.Models {
    public class Tambores : InstrumentoMusical, IPercussao   {
        public bool ManterRitmo () {
            System.Console.WriteLine ("Mantendo ritmo dos tambores");
            return true;
        }

    }
}