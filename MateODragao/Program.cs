using System;
using MateODragao.Models;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorNaoDesistiu = true;
            do
            {



                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("       Mate o Dragão!");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine(" 1 - Iniciar jogo");
                System.Console.WriteLine(" 0 - Sair do jogo");

                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        Console.Clear();

                        Guerreiro guerreiro = CriarGuerreiro();
                        Dragao dragao = CriarDragao();

                        /*INICIO - primeiro Dialogo */
                        CriarDialogo(guerreiro.Nome, $"{dragao.Nome} , Seu louco da cabeça! Vim-lhe derrotar-lhe!");
                        CriarDialogo(dragao.Nome, "Vem entao.Quem es tu ?");

                        FinalizaçaoDialogo();

                        /*FIM - Primeiro Dialogo */

                        /*INICIO - Segundo Dialogo */
                        CriarDialogo(guerreiro.Nome, $"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome} , o criatura morfetica");
                        CriarDialogo(guerreiro.Nome, $"{guerreiro.Nome.ToUpper()}:Vim de {guerreiro.CidadeNatal} para derrotar-lhe");
                        CriarDialogo(guerreiro.Nome, $"{dragao.Nome.ToUpper()} Quem? De onde ? Bom que seja irei te derrotar");
                        CriarDialogo(guerreiro.Nome, "Wesley: Cai Para cima Roger!");
                        FinalizaçaoDialogo();

                        /*FIM - Segundo Dialogo */
                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueguerreiro = guerreiro.Força > guerreiro.Inteligencia ? guerreiro.Força + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("Turno do Jogador");
                            System.Console.WriteLine("Escolha uma açao:");
                            System.Console.WriteLine("1 - Atacar");
                            System.Console.WriteLine("2 - Fugir");

                            string opacaoBatalhaJogador = Console.ReadLine();
                            switch (opacaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        CriarDialogo(guerreiro.Nome,$"{guerreiro.Nome.ToUpper()}: Toma essa Chagas!!");
                                        dragao.Vida -= poderAtaqueguerreiro + 5;
                                        System.Console.WriteLine($"HP Dragao : {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro : {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        CriarDialogo(dragao.Nome,$"{dragao.Nome.ToUpper()}: Errouuu");
                                    }
                                    break;
                                case "2":
                                    CriarDialogo(guerreiro.Nome ,$"{guerreiro.Nome.ToUpper()}:Vou Vazar flw! !");
                                   CriarDialogo(dragao.Nome ,$"{dragao.Nome.ToUpper()}: GG IZI !");
                                    jogadorNaoCorreu = false;

                                    break;
                            }
                        }

                        System.Console.WriteLine();
                        FinalizaçaoDialogo();
                        Console.ReadLine();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                        {
                            Console.Clear();
                            System.Console.WriteLine("** Turno Dragao **");
                            Random geradorNumeroAleatorio = new Random();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (dragaoDestrezaTotal > guerreiroDestrezaTotal)
                            {
                               CriarDialogo(dragao.Nome,$"{dragao.Nome.ToUpper()}: Toma essa Roger!!");
                                guerreiro.Vida -= dragao.Força;
                                System.Console.WriteLine($"HP Dragao : {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreiro : {guerreiro.Vida}");
                            }
                            else
                            {
                                CriarDialogo(guerreiro.Nome,$"{guerreiro.Nome.ToUpper()}: Oleeee ");
                            }
                            System.Console.WriteLine();
                            FinalizaçaoDialogo();
                            Console.ReadLine();

                            Console.Clear();

                            System.Console.WriteLine("Turno do Jogador");
                            System.Console.WriteLine("Escolha uma açao:");
                            System.Console.WriteLine("1 - Atacar");
                            System.Console.WriteLine("2 - Fugir");

                            string opacaoBatalhaJogador = Console.ReadLine();
                            switch (opacaoBatalhaJogador)
                            {
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa Chagas!!");
                                        dragao.Vida -= poderAtaqueguerreiro + 5;
                                        System.Console.WriteLine($"HP Dragao : {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro : {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        CriarDialogo(dragao.Nome, $"{dragao.Nome.ToUpper()}: Errouuu");
                                    }
                                    break;
                                case "2":
                                    CriarDialogo(guerreiro.Nome, $"{guerreiro.Nome.ToUpper()}:Vou Vazar flw! !");
                                    CriarDialogo(dragao.Nome, $"{dragao.Nome.ToUpper()}: GG IZI !");
                                    jogadorNaoCorreu = false;

                                    break;
                            }

                        }

                        if (guerreiro.Vida <= 0)
                        {
                            System.Console.WriteLine("Vocde perdeu!");
                        }

                        if (dragao.Vida <= 0)
                        {
                            System.Console.WriteLine("Voce venceu!");
                        }


                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine("GAME OVER!");
                        break;
                    default:
                        System.Console.WriteLine("Comando invalido");
                        break;
                }

            } while (jogadorNaoDesistiu);
        }

        public static void CriarDialogo(string nome, string frase)
        {

            System.Console.WriteLine($"{nome.ToUpper()}: \n-{frase}");
        }

        public static void FinalizaçaoDialogo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte ENTER para prosseguir");
            Console.ReadLine();
            Console.Clear();

        }

        public static Guerreiro CriarGuerreiro()
        {
            Guerreiro guerreiro = new Guerreiro();
            guerreiro.Nome = "Rogerio";
            guerreiro.Sobrenome = "Cardoso";
            guerreiro.CidadeNatal = "Berlim";
            guerreiro.DataNascimento = DateTime.Parse("20/02/1400");
            guerreiro.FerramentaAtaque = "Arco";
            guerreiro.FerramentaProtecao = "Armadura";
            guerreiro.Força = 3;
            guerreiro.Destreza = 2;
            guerreiro.Inteligencia = 3;
            guerreiro.Vida = 20;

            return guerreiro;
        }
        public static Dragao CriarDragao()
        {
            Dragao dragao = new Dragao();
            dragao.Nome = "Chagas";
            dragao.Força = 5;
            dragao.Destreza = 1;
            dragao.Inteligencia = 3;
            dragao.Vida = 300;
            return dragao;
        }
    }

}
