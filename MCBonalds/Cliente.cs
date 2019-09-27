using System;

namespace MCBonalds
{
    public class Cliente
    {
      public  string Nome;
      public   string endereço;
      public  string Telefone;
      public  string Senha;
      public  string Email;
      public  DateTime DataNascimento;

      public Cliente(string Nome, string Telefone , string Email){
          this.Nome= Nome;
          this.Telefone = Telefone;
          this.Email = Email;
      }
    }

}