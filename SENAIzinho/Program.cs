using System;
namespace SENAIzinho {
    class Program {
        static void Main (string[] args) {
            int limiteAlunos = 10;
            int limiteSalas = 10;
            Aluno[] alunos = new Aluno[100];
            Sala[] salas = new Sala[10];
            int alunosCadastrados = 0;
            int salaCadastradas = 0;
            bool querSair;

            //! MENU DE AÇÕES
            System.Console.WriteLine ("BEM VINDO AO SENAIZINHO!");
            System.Console.WriteLine ("Digite o numero correspondente a acçao que deseja realizar");
            System.Console.Write (" 1 - CADASTRAR ALUNO");
            System.Console.Write (" 2 - CADASTRAR SALA");
            System.Console.Write (" 3 - ALOCAR ALUNO");
            System.Console.Write (" 4 - REMOVER ALUNO");
            System.Console.Write (" 5 - VERIFICAR SALAS");
            System.Console.Write (" 6 - VERIFICAR ALUNOS");
            System.Console.Write (" 0 - SAIR");
            int OpcaoMenu = int.Parse(Console.ReadLine ());

            switch (OpcaoMenu) {
                case 1:
                    
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                default:
                    break;
            }

        }
        public void CadastrarAluno (Aluno[] alunos, int totalAluno, int alunosCadastrados) {
            if (totalAluno < alunosCadastrados) {
                System.Console.WriteLine("Cadastro de Alunos");
                System.Console.WriteLine();
                System.Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                System.Console.WriteLine("Data de Nascimento: ");
                DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

                Aluno novoAluno = new Aluno();
                novoAluno.Nome = nome;
                novoAluno.DataNascmento = dtNascimento;
                int index = 0;
                foreach(Aluno aluno in alunos) {
                    if (alunos == null) {
                        alunos[index] = novoAluno;
                        break;
                    }
                    index++;
                }
                alunosCadastrados++;
                
            }
        }
        public void CadastrarSala () {

        }
        public void AlocarAluno () {

        }
        public void RemoverAluno () {

        }
        public void VerificarSala () {

        }
        public void VerificarAlunos () {
            
        }

    }

}