using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ola");
            double result = 0;
            int num1 = 0;
            int num2 = 0;
            string oper; 
          Console.WriteLine("Digite o 1º numero");
          num1 =  int.Parse(Console.ReadLine());
          Console.WriteLine("Digite o 2º numero");
          num2 = int.Parse(Console.ReadLine());
          Console.WriteLine("Digite o operador");
          oper = Console.ReadLine();

          

          switch(oper){
              case "+":
               Console.WriteLine( result = num1 + num2 );
              break;

              case "-":
                 Console.WriteLine (result = num1 - num2);
              break;

              case "*":
                Console.WriteLine (result = num1 * num2);
              break;

              case "/":
               Console.WriteLine(result = num1 / num2);
              break;

              case "%":
                Console.WriteLine (result = num1 % num2);
              break;

              default:
               Console.WriteLine("operaçao invalidade");
               break;



            
              
              
          }
        }
    }
}
