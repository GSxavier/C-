using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string senha;
             
             Console.WriteLine("Login");
             login = Console.ReadLine();

             Console.WriteLine("senha");
             senha = Console.ReadLine();

             if(login == "admin" && senha == "admin"){
                 Console.WriteLine("ADMIN LOGADO");
             }
            else{
                Console.WriteLine("voce conseguiu logar");
              }
        }
    
    }
}
