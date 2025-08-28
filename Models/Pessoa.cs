using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_net_explorando.Models
{
    public class Pessoa
    {
        // Campos privados
        private string _nome;
        private int _idade;

        // Propriedades com validação
        public string Nome
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


        public int Idade
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
        public string Sobrenome { get; set; } 

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Propriedade somente leitura que retorna o nome completo em maiúsculas


        // Método para apresentar a pessoa
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}