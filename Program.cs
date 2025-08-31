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

new ExemploExcecao().Metodo1();