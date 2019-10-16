using System;
using EscolaDeRock.interfaces;
using EscolaDeRock.Models;

namespace EscolaDeRock {
    class Program {
        static void Main (string[] args) {
            InstrumentoMusical instrumento = new InstrumentoMusical ();
            System.Console.WriteLine (instrumento.TocarMusica ());

            Violao violao = new Violao ();
            System.Console.WriteLine (violao.TocarMusica ());
        }
    }
}