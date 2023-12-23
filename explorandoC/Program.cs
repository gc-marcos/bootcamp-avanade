using explorandoC.Models;

Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Lima");
Pessoa p2 = new Pessoa(nome: "Marcos", sobrenome: "Carvalho");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAluno();

// Pessoa p1 = new Pessoa();
// p1.Nome =  "Marcos";
// p1.Idade = 28;
// p1.Sobrenome = "Carvalho";
// p1.Apresentar();