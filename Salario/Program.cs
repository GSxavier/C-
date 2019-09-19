using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal= 0;
            Console.WriteLine("Digite o Salario");
            sal = int.Parse(Console.ReadLine());
            double sale = 0;

            if(sale >=500){
                Console.WriteLine("Seu Salario aumentou em " + sale);
                Console.WriteLine( sale = sal * 1.3);
                  }
            else{
                Console.WriteLine("nao teve aumento");
            }
        }
    }
}
