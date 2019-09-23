using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
                 double escolha = 0;
        
           Console.WriteLine("Selecione um :  Quadrado(1), Triangulo(2), Circulo(3), Trapézio(4), Retangulo(5), Losango(6).");
           escolha = double.Parse(Console.ReadLine());

           double mek1 = 0;
           double mek2 = 0;
           double mek3 = 0;
          

            
            double area = 0;
            switch(escolha){
                case 1 :
                      Console.WriteLine("Digite as medidas dos lados do quadrado: ");
                      mek1 = double.Parse(Console.ReadLine());
                      Console.WriteLine("Digite as medidas dos lados do quadrado: ");
                      mek2 = double.Parse(Console.ReadLine());
                     Console.WriteLine( area = mek1 * mek2);
                     Console.WriteLine("A area da figura é: " + area);
                break;

                case 2:
                     Console.WriteLine("Digite o valor da BASE: ");
                     mek1 = double.Parse(Console.ReadLine());
                     Console.WriteLine("Digite o valor da altura: ");
                     mek2 = double.Parse(Console.ReadLine());
                     Console.WriteLine(area = (mek1 * mek2)/2);
                     Console.WriteLine("A area da figura é: " + area);
                break;

                case 3:
                   Console.WriteLine("Digite o valor do raio: ");
                   mek1 = double.Parse(Console.ReadLine());
                   
                   Console.WriteLine( area = 3.14 * (mek1 * mek1));
                   Console.WriteLine("A area da figura é: " + area);
                break;

                case 4:
                    Console.WriteLine("Digite o valor da base MAIOR: ");
                    mek1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da base MENOR: ");
                    mek2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do Altura: ");
                    mek3 = double.Parse(Console.ReadLine());
                    Console.WriteLine( area = ((mek1 + mek2)* mek3)/2);
                    Console.WriteLine("A area da figura é: " + area);
                    
                break;

                case 5:
                   Console.WriteLine("Digite o valor da largura: ");
                   mek1 = double.Parse(Console.ReadLine());
                   Console.WriteLine("Digite o valor da altura: ");
                   mek2 = double.Parse(Console.ReadLine());
                    Console.WriteLine( area = mek1 * mek2);
                    Console.WriteLine("A area da figura é: " + area);
                break; 

                case 6:
                    Console.WriteLine("Digite o valor da diagonal MAIOR: ");
                    mek1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da diagonal MENOR: ");
                    mek1 = double.Parse(Console.ReadLine());
                    Console.WriteLine( area = (mek1 * mek2 )/2);
                    Console.WriteLine("A area da figura é: " + area);
                break;

                default:
                    Console.WriteLine( "Operação invalida!");
                break;

                
                
               
            }
        }
    }
}
