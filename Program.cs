using C_.Models;

/*Pessoa p1 = new Pessoa();
p1.Nome = "Camila";
p1.Idade = -1;
p1.Sobrenome = "Fereira";

p1.Apresentar();

// Pessoa 1
Pessoa p1 = new Pessoa();
p1.Nome = "Camila";
p1.Sobrenome = "Fereira";


// Pessoa 2
Pessoa p2 = new Pessoa();
p2.Nome = "Michael";
p2.Sobrenome = "Santos";*/

// Pessoa 3
Pessoa p1 = new Pessoa("Davi", " Ferreira");
Pessoa p2 = new Pessoa("Camila", " Ferreira");
Pessoa p3 = new Pessoa("Micahel", " Ferreira");



// Curso 
Curso CursoIngles = new Curso();
CursoIngles.Nome = "Ingles";
CursoIngles.Alunos = new List<Pessoa>();

CursoIngles.AdicioanarAluno(p1); // adicionar o nome na lista Alunos
CursoIngles.AdicioanarAluno(p2);
CursoIngles.ListarAluno();