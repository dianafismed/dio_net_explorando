using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_net_explorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public Pessoa(String nome, String sobrenome, int idade)
        {
            NomeAluno = nome;
            SobrenomeAluno = sobrenome;
            IdadeAluno = idade;
        }
     
        // Campos privados
        private string _nome;
        private int _idade;

        // Propriedades com validação
        public string NomeAluno
        {
            get => _nome.ToUpper(); // Retorna o nome em maiúsculas
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio"); // Lança uma exceção se o nome for vazio
                }
                _nome = value;
            }
        }


        public int IdadeAluno
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa"); // Lança uma exceção se a idade for negativa
                }
                _idade = value;
            }
        }

        // Propriedades sem validação
        public string SobrenomeAluno { get; set; } 

        public string NomeCompleto => $"{NomeAluno} {SobrenomeAluno}".ToUpper(); // Propriedade somente leitura que retorna o nome completo em maiúsculas


        // Método para apresentar a pessoa
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {IdadeAluno} anos.");
        }
    }
}