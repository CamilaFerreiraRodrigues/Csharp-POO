using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.Models
{
    public class Curso
    {
        public string Nome {get; set;}


        //    lista<Tipo> nomeLista
        public List<Pessoa> Alunos {get; set;}


        // Métodos

        public void AdicioanarAluno( Pessoa aluno){
            Alunos.Add(aluno);
        }   

        //quantos alunos tenho cadastrados
        public int ObterQuantidadeDeAlunosMatriculados(){

            int quantidade = Alunos.Count;

            return quantidade;
        }

        public bool RemoverAluno( Pessoa Aluno){
            return Alunos.Remove(Aluno);
        }

        public void ListarAluno(){

            foreach(Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}