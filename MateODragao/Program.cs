using System;
using MateODragao.Models;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorNaoDesistiu = true;
            do{
            
            
            
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
                Guerreiro guerreiro = new Guerreiro(); 
                guerreiro.Nome = "Rogerio";
                guerreiro.Sobrenome = "Cardoso";
                guerreiro.CidadeNatal = "Berlim";
                guerreiro.DataNascimento = DateTime.Parse("29/02/473");
                guerreiro.FerramentaAtaque = "Arco";
                guerreiro.FerramentaProtecao = "Armadura";
                guerreiro.Força = 3;
                guerreiro.Destreza = 2;
                guerreiro.Inteligencia = 3;
                guerreiro.Vida = 20;
                
                Dragao dragao = new Dragao();
                dragao.Nome = "Chagas";
                dragao.Força = 5;
                dragao.Destreza = 1;
                dragao.Inteligencia = 3;
                dragao.Vida = 300;

                /*INICIO - primeiro Dialogo */
                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: {guerreiro.Nome} , Seu louco da cabeça! Vim-lhe derrotar-lhe!");
                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: {dragao.Nome} , Ta achando que e quem Humano");

                System.Console.WriteLine();
                System.Console.WriteLine("Aperte ENTER para prosseguir");
                Console.ReadLine();
                  
                /*FIM - Primeiro Dialogo */

                /*INICIO - Segundo Dialogo */
                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome} , o criatura morfetica");
                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:Vim de {guerreiro.CidadeNatal} para derrotar-lhe");
                System.Console.WriteLine($"{dragao.Nome.ToUpper()} Quem? De onde ? Bom que seja irei te derrotar");
                System.Console.WriteLine("Wesley: Cai Para cima Roger!");
                System.Console.WriteLine("Aperte ENTER para prosseguir");
                
                /*FIM - Segundo Dialogo */
                Console.Clear();
                
               bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;
               
               int poderAtaqueguerreiro = guerreiro.Força > guerreiro.Inteligencia ? guerreiro.Força + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza; 
               
               bool jogadorNaoCorreu = true; 

               if(jogadorAtacaPrimeiro)
               {
                   System.Console.WriteLine("Turno do Jogador");
                   System.Console.WriteLine("Escolha uma açao:");
                   System.Console.WriteLine("1 - Atacar");
                   System.Console.WriteLine("2 - Fugir");

                   string opacaoBatalhaJogador = Console.ReadLine();
                   switch(opacaoBatalhaJogador)
                   {
                       case "1":
                        Random geradorNumeroAleatorio = new Random();
                        int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                        int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                        int guerreiroDestrezaTotal = guerreiro.Destreza +  numeroAleatorioJogador;
                        int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                        if(guerreiroDestrezaTotal > dragaoDestrezaTotal){
                            System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa Chagas!!");
                            dragao.Vida  -=  poderAtaqueguerreiro + 5; 
                            System.Console.WriteLine($"HP Dragao : {dragao.Vida}");
                            System.Console.WriteLine($"HP Guerreiro : {guerreiro.Vida}");
                        }
                        else{
                            System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errouuu");
                        }
                       break;
                       case "2":
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:Vou Vazar flw! !");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG IZI !");
                        jogadorNaoCorreu = false;
                        
                       break;
                   }
               }
                 
                 System.Console.WriteLine();
                 System.Console.WriteLine("Aperte ENTER para Prosseguir");
                 Console.ReadLine();
                 
                while(guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                {
                    Console.Clear();
                    System.Console.WriteLine("** Turno Dragao **");
                    Random geradorNumeroAleatorio = new Random();
                        int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                        int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                        int guerreiroDestrezaTotal = guerreiro.Destreza +  numeroAleatorioJogador;
                        int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                        if( dragaoDestrezaTotal > guerreiroDestrezaTotal  ){
                            System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Toma essa Roger!!");
                            guerreiro.Vida  -=  dragao.Força; 
                            System.Console.WriteLine($"HP Dragao : {dragao.Vida}");
                            System.Console.WriteLine($"HP Guerreiro : {guerreiro.Vida}");
                        }
                        else{
                            System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Oleeee ");
                        }
                         System.Console.WriteLine();
                         System.Console.WriteLine("Aperte ENTER para prosseguir");
                         Console.ReadLine();
                         
                         Console.Clear();

                   System.Console.WriteLine("Turno do Jogador");
                   System.Console.WriteLine("Escolha uma açao:");
                   System.Console.WriteLine("1 - Atacar");
                   System.Console.WriteLine("2 - Fugir");

                   string opacaoBatalhaJogador = Console.ReadLine();
                   switch(opacaoBatalhaJogador)
                   {
                       case "1":
                        Random geradorNumeroAleatorio = new Random();
                        int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                        int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                        int guerreiroDestrezaTotal = guerreiro.Destreza +  numeroAleatorioJogador;
                        int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                        if(guerreiroDestrezaTotal > dragaoDestrezaTotal){
                            System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa Chagas!!");
                            dragao.Vida  -=  poderAtaqueguerreiro + 5; 
                            System.Console.WriteLine($"HP Dragao : {dragao.Vida}");
                            System.Console.WriteLine($"HP Guerreiro : {guerreiro.Vida}");
                        }
                        else{
                            System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errouuu");
                        }
                       break;
                       case "2":
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:Vou Vazar flw! !");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG IZI !");
                        jogadorNaoCorreu = false;
                        
                       break;
                   }
                         
                }

                break;
                case "0":
                jogadorNaoDesistiu = false;
                System.Console.WriteLine("GAME OVER");  
                break;
                default:
                 System.Console.WriteLine("Comando invalido");
                break;
            }

          }while(jogadorNaoDesistiu);
        }
    }
}
