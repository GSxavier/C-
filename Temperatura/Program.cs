using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Temperatura = new double[12];
            double maior = 0;
            double menor = 0;

            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Digite a temperatura do mes {i + 1}:");
                Temperatura[i] = double.Parse(Console.ReadLine());
            }

            maior = Temperatura[0];
            menor = Temperatura[0];

            foreach(double temp in Temperatura)
            {
                if(temp > maior)
                {
                    maior = temp;
                }else if ( temp < menor)
                {
                    menor = temp;
                }
                Console.WriteLine($"A maior Temperatura e {maior}.");
                Console.WriteLine($"A menor Temperatura e {menor}");
            }
        }
    }
}
