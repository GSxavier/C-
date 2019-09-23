using System;

namespace Nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
           int ida1 = 0;
           int num = 0;
           do{
            Console.WriteLine("Digite sua data de nascimento :");
             ida1 = int.Parse( Console.ReadLine());
             if(ida1 >2021 || (ida1 < 0)){
                 Console.WriteLine("Data Invalida");
             }
           }while((ida1 > 2021) || (ida1 < 0));
            
            num = 2019 - ida1;

            if( num <= 2) {
                Console.WriteLine("Recem nascido");
            }

           else if(num >= 3 && num <= 11){
               Console.WriteLine( "Criança");
           }
            else if(num >= 12 && num <= 19){
               Console.WriteLine( "adolecente");
           }
            else if(num >= 20 && num <= 65){
               Console.WriteLine( "adulto");
           }
            else if(num > 65 ){
               Console.WriteLine( "Idoso");
           }
         
        }
    }
}
