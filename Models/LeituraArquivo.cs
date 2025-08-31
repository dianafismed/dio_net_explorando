using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_net_explorando.Models
{
    public class LeituraArquivo
    {
        // Construtores
        public LeituraArquivo()
        {
        }

        public LeituraArquivo(string caminho)
        {
        }

        // Método que lê um arquivo e retorna uma tupla com três valores:
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) Ler(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}