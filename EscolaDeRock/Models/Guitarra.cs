using System;
using EscolaDeRock.interfaces;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcorder()
        {
            System.Console.WriteLine("Tocando acordes da guitarra!");
            return true;
        }

        public bool TocarAcordes()
        {
            throw new NotImplementedException();
        }                                                                                                                                                                     

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo da guitarra");
            return true;
        }

    }
}