using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Gustavo", "48531730805" , "Dev");
            Console.WriteLine("Nome:"+ aluno1.Nome);
            Console.WriteLine("Curso:"+ aluno1.Curso);
            Console.WriteLine("Cpf:"+ aluno1.Cpf);
            
            Aluno aluno2 = new Aluno("cleber", "12423534634" , "chagas");


            Console.Write("Entre com nome:");
            string nome = Console.ReadLine();
            Console.Write("Entre com Cpf:");
            string cpf = Console.ReadLine();
            Console.Write("Entre com Curso:");
            string curso= Console.ReadLine();
            Console.Write("Entre com nota:");

            int nota = int.Parse(Console.ReadLine());
            int bimestre = int.Parse(Console.ReadLine());
            Aluno aluno3 = new Aluno(nome,cpf,curso);
            aluno3.setNotas(bimestre,nota);

            Console.WriteLine("Nome :"+ aluno3.Nome);
            Console.WriteLine("CPF :"+ aluno3.Cpf);
            Console.WriteLine("Curso :"+ aluno3.Curso);
            Console.WriteLine("Notas:");
            foreach( int n in aluno3.getNotas()){
                Console.Write(n +" ");
    
            }
            Console.WriteLine();




        }
    }
}
