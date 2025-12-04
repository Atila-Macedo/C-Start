
// Exemplo 01

/* Pessoa obj1 = new Pessoa();
obj1.Nome = "Átila";
obj1.Apresentar(); */

// Exemplo 02
/* Pessoa obj2 = new();
obj2.Nome = "Beatryz";
obj2.Apresentar(); */

// Exemplo 03
/* Pessoa obj3 = new()
{
    Nome = "Carlos",
    Idade = 24
};
string retorno = obj3.VerificarIdade();
Console.WriteLine(retorno); */

Pessoa obj4 = new()
{
    Nome = "Daniela",
    Idade = 16
};
Console.WriteLine($"{obj4.Nome} é {obj4.VerificarIdade()}");