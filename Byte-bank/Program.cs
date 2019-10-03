using System;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ByteBank - Cadastro de Clientes");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Cliente cliente1 = new Cliente(nome,cpf,email);

            bool trocouSenha = false;
            do{
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha  = cliente1.TrocaSenha(senha); 
                if(trocouSenha){
                    System.Console.WriteLine("Senha alterada com sucesso!");
                } else{
                    System.Console.WriteLine("Senha Invalida!");
                }
            }while(!trocouSenha);

            System.Console.WriteLine(" Digite Nome do titular");
            string Titular = Console.ReadLine();
            System.Console.WriteLine("Digite Numero da Agencia");
            int Agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite numero da conta");
            int Numero = int.Parse(Console.ReadLine());

            ContaCorrente cliente1 = new ContaCorrente( Titular,Agencia,Numero);
            
            cliente1 Saldo = Console.ReadLine();
            
            
            

            }
        }
    }