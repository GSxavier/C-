using System;


namespace SENAIzinho
{
    public class Aluno
    {
        public string Nome {get;set;}
        public DateTime DataNascimento {get;set;}
        public string Curso {get;set;}
        public int numeroSala {get;set;}

        public Aluno(string Nome, DateTime DatadeNascimento, string Curso,int numeroSala){
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Curso = Curso;
            this.numeroSala = numeroSala;
        }
    }
}