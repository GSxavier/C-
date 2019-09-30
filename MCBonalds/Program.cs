using System;

namespace MCBonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Jose", "4455444444444444", "sgxdhfh@gmail.com");

            Console.WriteLine("Nome:"+ cliente1.Nome);
            Console.WriteLine("Telefone:"+ cliente1.Telefone);
            Console.WriteLine("Email:"+ cliente1.Email);


        }
    }
}
