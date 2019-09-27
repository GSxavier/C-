using System;

namespace Aluno
{
    public class Aluno{
        //Propiedades
     public string Nome{get;set;}
     public string Curso{get;set;}
     public  string Cpf{get;set;}
     public int[] Notas;

     //Construtor
     public Aluno(string Nome, string Cpf){
         this.Nome = Nome;
         this.Cpf = Cpf;
     }
     public Aluno(string Nome, string Cpf , string Curso){
         this.Nome = Nome;
         this.Cpf = Cpf;
         this.Curso = Curso;        
     }
     //Metodods de acesso
     public int[] getNotas(){return notas;}

     public void setNotas(int bi, int notas){
         int i = bi - 1;
         if((i < 0) || (i > 3)){
             //Condiçoes de erro
             throw new ArgumentOutOfRangeException($"{nameof (value)} must be between 1 and 4");
         }else if ( int notas )
     }

    }
}