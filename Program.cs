using System.Globalization;
using dio_net_explorando.Models;

// Pessoa pessoa1 = new Pessoa();
// pessoa1.NomeAluno = "Vampiro";
// pessoa1.SobrenomeAluno = "Drácula";
// pessoa1.IdadeAluno = 100;
// pessoa1.Apresentar();

// Pessoa pessoa2 = new Pessoa("Frankenstein", "Stein", 150);
// Pessoa pessoa3 = new Pessoa("Zé", "Ninguém", 20);
// Pessoa pessoa4 = new Pessoa("Maria", "Silva", 30);

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.NomeCurso = "Inglês";
// cursoDeIngles.AdicionarAluno(pessoa1);
// cursoDeIngles.AdicionarAluno(pessoa2);
// cursoDeIngles.AdicionarAluno(pessoa3);
// cursoDeIngles.AdicionarAluno(pessoa4);
// cursoDeIngles.ListarAlunos();

// Curso cursoDeProgramacao = new Curso("Programação C#");
// cursoDeProgramacao.AdicionarAluno(pessoa2);
// cursoDeProgramacao.ListarAlunos();

// Console.WriteLine($"Total de alunos no curso de Inglês: {cursoDeIngles.ContarAlunos()}");
// Console.WriteLine($"Total de alunos no curso de Programação C#: {cursoDeProgramacao.ContarAlunos()}");

// // Formatação em moeda corrente do sistema
// decimal valor = 1215.5M;
// Console.WriteLine($"{valor:C}"); // C de currency (moeda)
// Console.WriteLine(valor.ToString("C5")); 
// // Formatação em moeda corrente de localidade específica
// Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// // Alterando a localidade para mudar o formato da moeda
// System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("en-US");
// Console.WriteLine($"{valor:C}"); // C de currency (moeda)

// // Porcentagem
// decimal porcentagem = .3421M;
// Console.WriteLine(porcentagem.ToString("P")); // P de percentage (porcentagem)

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// // Data e hora
// DateTime data = DateTime.Now;
// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy"));
// Console.WriteLine(data.ToString("yyyy-MM-dd"));
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss.fff")); // fff = milissegundos
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss.fff tt")); // tt = AM/PM
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss.fff zzz")); // zzz = fuso horário
// Console.WriteLine(data.ToString("D")); // Formato longo da data
// Console.WriteLine(data.ToString("d")); // Formato curto da data
// Console.WriteLine(data.ToString("T")); // Formato longo da hora
// Console.WriteLine(data.ToString("t")); // Formato curto da hora
// Console.WriteLine(data.ToString("F")); // Formato longo da data e hora
// Console.WriteLine(data.ToString("f")); // Formato curto da data e hora
// Console.WriteLine(data.ToString("g")); // Formato geral curto da data e hora
// Console.WriteLine(data.ToString("G")); // Formato geral longo da data e hora
// Console.WriteLine(data.ToString("M")); // M de month (mês e dia)
// Console.WriteLine(data.ToString("Y")); // Y de year (mês e ano)
// Console.WriteLine(data.ToString("R")); // R de RFC1123 (padrão internacional)
// Console.WriteLine(data.ToString("s")); // s de sortable (padrão internacional sem fuso)
// Console.WriteLine(data.ToString("u")); // u de universal (padrão internacional sem fuso)
// Console.WriteLine(data.ToString("U")); // U de universal (padrão internacional com fuso)

// DateTime data = DateTime.Parse("28/07/2025 15:00");
// Console.WriteLine(data);

// string dataString = "2025-05-28 15:30";
// string dataString2 = "2025/05/40";
// DateTime.TryParseExact(dataString2,
//                         "yyyy/MM/dd",
//                         CultureInfo.InvariantCulture,  // InvariantCulture = cultura neutra
//                         DateTimeStyles.None,
//                         out DateTime data);  // retorna true ou false
// Console.WriteLine(data);

// Exceções
// string[] linhas = File.ReadAllLines("Arquivos/texto.txt");
// foreach (var linha in linhas)
// {
//   Console.WriteLine(linha);
// }

// try
// {
//   string[] linhas = File.ReadAllLines("Arquivos/texto1.txt");
//   foreach (var linha in linhas)
//   {
//     Console.WriteLine(linha);
//   }
//   // using (StreamReader sr = new StreamReader("Arquivos/texto1.txt"))
//   // {
//   //   string? linha = string.Empty;
//   //   while ((linha = sr.ReadLine()) != null)
//   //   {
//   //     Console.WriteLine(linha);
//   //   }
//   // }
// }
// catch (FileNotFoundException ex)
// {
//   Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//   Console.WriteLine($"Diretório não encontrado: {ex.Message}");
// }
// catch (IOException ex)
// {
//   Console.WriteLine($"Erro de I/O: {ex.Message}");
// }
// catch (Exception ex)
// {
//   Console.WriteLine($"Erro genérico: {ex.Message}");
// }
// finally
// {
//   Console.WriteLine("Chegou no bloco finally.");
// }

// new ExemploExcecao().Metodo1();

// // Filas
// Queue<int> fila = new Queue<int>();
// // Colocando elementos na fila
// fila.Enqueue(1);
// fila.Enqueue(2);
// fila.Enqueue(3);

// foreach (var item in fila)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Primeiro elemento da fila: {fila.Peek()}");

// // Retirando elementos da fila
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// foreach (var item in fila)
// {
//   Console.WriteLine(item);
// }

// //Pilhas
// Stack<int> pilha = new Stack<int>();
// // Colocando elementos na pilha 
// pilha.Push(1);
// pilha.Push(2);
// pilha.Push(3);

// foreach (var item in pilha)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Topo da pilha: {pilha.Peek()}");

// // Retirando elementos da pilha
// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
// foreach (var item in pilha)
// {
//   Console.WriteLine(item);
// }

// // Dicionários
// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");
// foreach (var item in estados)
// {
//   Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// Console.WriteLine("\n");

// // Acessando um valor através da chave
// Console.WriteLine($"Acessando um valor através da chave {estados["MG"]}");

// // Removendo um item do dicionário
// Console.WriteLine($"Removendo o estado do RJ {estados.Remove("RJ")}");
// foreach (var item in estados)
// {
//   Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// Console.WriteLine("\n");

// // Verificando se o dicionário contém uma chave
// Console.WriteLine($"Verificando se o dicionário contém a chave SP {estados.ContainsKey("SP")}"); // true
// Console.WriteLine($"Verificando se o dicionário contém a chave SC {estados.ContainsKey("SC")}"); // false
// Console.WriteLine("\n");

// // Verificando se o dicionário contém um valor
// Console.WriteLine($"Verificando se o dicionário contém o valor MG {estados.ContainsValue("Minas Gerais")}"); // true
// Console.WriteLine($"Verificando se o dicionário contém o valor SC {estados.ContainsValue("Santa Catarina")}"); // false
// Console.WriteLine("\n");

// // Obtendo o número de itens no dicionário
// Console.WriteLine($"Total de estados no dicionário: {estados.Count}");
// Console.WriteLine("\n");

// // Limpando o dicionário
// estados.Clear();
// Console.WriteLine($"Total de estados no dicionário após o Clear: {estados.Count}");
// Console.WriteLine("\n");

// // Tuplas
// ( string nome, int idade, decimal saldo) tupla = ("Vampiro", 100, 1234.56M);
// Console.WriteLine($"Nome: {tupla.nome}, Idade: {tupla.idade}, Saldo: {tupla.saldo}");

// (int, string, string) nomeCompleto = (1, "Vampiro", "Drácula");
// Console.WriteLine($"ID: {nomeCompleto.Item1}, Nome: {nomeCompleto.Item2}, Sobrenome: {nomeCompleto.Item3}");

// var nome = (2, "Frankenstein", "Stein");
// Console.WriteLine($"ID: {nome.Item1}, Nome: {nome.Item2}, Sobrenome: {nome.Item3}");

// ValueTuple<int, string, string> nome2 = (3, "Zé", "Ninguém");
// Console.WriteLine($"ID: {nome2.Item1}, Nome: {nome2.Item2}, Sobrenome: {nome2.Item3}");

// var outro = Tuple.Create(4, "Maria", "Silva");
// Console.WriteLine($"ID: {outro.Item1}, Nome: {outro.Item2}, Sobrenome: {outro.Item3}");

// LeituraArquivo leitura = new LeituraArquivo();
// (bool sucesso, string[] linhas, int quantidade) = leitura.Ler("Arquivos/texto.txt");
// if (sucesso)
// {
//   Console.WriteLine($"Quantidade de linhas do arquivo: {leitura.Ler("Arquivos/texto.txt").QuantidadeLinhas}");
//   foreach (var linha in leitura.Ler("Arquivos/texto.txt").Linhas)
//   {
//     Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine("Não foi possível ler o arquivo.");
// }

LeituraArquivo arquivo = new LeituraArquivo();
var leitura = arquivo.Ler("Arquivos/texto.txt");
if (leitura.Sucesso)
{
  Console.WriteLine("Conteúdo do arquivo:");
  foreach (var linha in leitura.Linhas)
  {
    Console.WriteLine(linha);
  }
  Console.WriteLine($"\nQuantidade de linhas do arquivo: {leitura.QuantidadeLinhas}\n");
}
else
{
  Console.WriteLine("Não foi possível ler o arquivo.");
}













