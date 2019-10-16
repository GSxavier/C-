using System;
using System.Collections.Generic;
using System.Text;
namespace SENAIzinho {
    public class Sala {
        public int capacidadeAtual { get; set; }
        public int capacidadeTotal { get; set; }
        public int numeroSala { get; set; }
        public string[] Alunos { get; set; }

        // !CONSTRUTOR
        public Sala (int numeroSala, int capacidadeTotal) {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
            this.capacidadeAtual = this.capacidadeTotal;
            this.Alunos = new string[capacidadeTotal];
        }

        // !MÉTODO ALOCAR ALUNO
        public string AlocarAluno (string nomeAluno) {
            int index = 0;
            if (this.capacidadeAtual > 0) {
                foreach (string aluno in this.Alunos) {
                    if (aluno == "") {
                        this.Alunos[index] = nomeAluno;
                        break;
                    }
                    index++;
                }
                this.capacidadeAtual--;
                return "ok";
            } else {
                return "Lotado";
            }
        }

        // !MÉTODO REMOVER ALUNO

        public string RemoverAluno (string nomeAluno) {
            int index = 0;
            if (this.capacidadeAtual == this.capacidadeTotal) {
                return "Sala vazia!";
            }
            foreach (string aluno in this.Alunos) {
                if (nomeAluno == aluno) {
                    this.Alunos[index] = "";
                    return "OK";
                }
                index++;
            }
            return "Não encontrado!";
        }
        // !MÉTODO MOSTRAR ALUNO
        public string MostrarAlunos () {
            string listaAlunos = "";
            foreach(string aluno in this.Alunos) {
                if(aluno != "") {
                    listaAlunos = listaAlunos + aluno + "";
                }
            }
            listaAlunos.TrimEnd();
            return listaAlunos;
        }

    }

}