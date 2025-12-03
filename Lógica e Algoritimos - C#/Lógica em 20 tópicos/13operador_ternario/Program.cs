// Váriável
double media = 0;
Console.Write("Digite a média do aluno: ");
media = Convert.ToDouble(Console.ReadLine());  

// Operador ternário
//Console.WriteLine(media >= 7 ? "Aprovado" : "Reprovado");

string situacao = media >= 7 ? "Aprovado" : "Reprovado";
Console.WriteLine(situacao);


