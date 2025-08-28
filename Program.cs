using dio_net_explorando.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.NomeAluno = "Vampiro";
pessoa1.SobrenomeAluno = "Drácula";
pessoa1.IdadeAluno = 100;
// pessoa1.Apresentar();

Pessoa pessoa2 = new Pessoa("Frankenstein", "Stein", 150);

Curso cursoDeIngles = new Curso();
cursoDeIngles.NomeCurso = "Inglês";
cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.ListarAlunos();

Curso cursoDeProgramacao = new Curso("Programação C#");
cursoDeProgramacao.AdicionarAluno(pessoa2);
cursoDeProgramacao.ListarAlunos();

Console.WriteLine($"Total de alunos no curso de Inglês: {cursoDeIngles.ContarAlunos()}");
Console.WriteLine($"Total de alunos no curso de Programação C#: {cursoDeProgramacao.ContarAlunos()}");