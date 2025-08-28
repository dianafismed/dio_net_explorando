using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_net_explorando.Models
{
    public class Curso
    {
        // Propriedades do curso
        public String NomeCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }


        // // Construtor para inicializar a lista de alunos
        // public Curso()
        // {
        //     Alunos = new List<Pessoa>();
        // }


        // Métodos
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso {NomeCurso}:");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

        public int ContarAlunos()
        {
            return Alunos.Count;
        }
    }
}