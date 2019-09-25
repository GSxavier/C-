using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new Int32[6];
            int par = 0;
            int impar = 0;
            Console.WriteLine("Digite numeros");
            for(int i = 0; i< 6; i++)
            {
                Console.Write("Vetor [" + i + " ]: ");
                vetor1[i] = Convert.ToInt32(Console.ReadLine());
           
            }
            for(int i = 0; i < 6 ; i++)
            {
                if(vetor1[i]% 2 == 0)
                {
                    par++;
                }
            }
                impar = 6 -par;
                Console.WriteLine("Numeros pares :" + par);
                Console.WriteLine("Numeros impares: " + impar);
            
           
            
        }
    }
}
