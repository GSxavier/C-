using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;


          while(num !=0){
                 Console.WriteLine("Digite um numero ou zero para parar:");
                  num = int.Parse(Console.ReadLine());

            if( num % 2 == 0){
                Console.WriteLine("Numero impar");
            }

            else {
              Console.WriteLine("Numero par");
                
            }
             
          }        
        }
    }
}
