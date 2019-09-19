using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma nota");
            int not1= 0;
            int not2= 0;
            int not3= 0;
            int not4= 0;

            Console.WriteLine("primeira nota");
            not1 = int.Parse(Console.ReadLine());
            Console.WriteLine("segunda nota");
            not2 = int.Parse(Console.ReadLine());
            Console.WriteLine("terceira nota");
            not3 = int.Parse(Console.ReadLine());
            Console.WriteLine("quarta nota");
            not4 = int.Parse(Console.ReadLine());
            float media = (not1 + not2 + not3 + not4) / 4 ;
             
            Console.WriteLine($"Sua media e: "  + media);

            if( media >=7 ){ 
            
                Console.WriteLine("voce foi APROVADO " + media);
                }
            else if (media == 7.0){
                Console.WriteLine(" Passou por pouco");
            }
            else{
                Console.WriteLine("voce foi REPROVADO");
            }
            

        }
    }
}
