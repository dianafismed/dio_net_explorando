using dio_net_explorando.Models;

// Pessoa pessoa1 = new Pessoa();
// pessoa1.NomeAluno = "Vampiro";
// pessoa1.Sobrenome = "Drácula";
// pessoa1.Idade = 100;
// pessoa1.Apresentar();

Pessoa pessoa2 = new Pessoa();
pessoa2.NomeAluno = "Frankenstein";
pessoa2.Sobrenome = "Stein";
pessoa2.Idade = 200;
pessoa2.Apresentar(); 

Curso cursoDeIngles = new Curso();
cursoDeIngles.NomeCurso = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(pessoa2);