int nota1 = 0;
Console.Write("Digite a primeira nota: ");
nota1 = Convert.ToInt32(Console.ReadLine());

int nota2 = 0;
Console.Write("Digite a segunda nota: ");
nota2 = Convert.ToInt32(Console.ReadLine());

int nota3 = 0;
Console.Write("Digite a terceira nota: ");
nota3 = Convert.ToInt32(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

// Estrutura encadeada
if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media >= 5)
{
    Console.WriteLine("Em exame");
}
else
{
    Console.WriteLine("Reprovado");
}


