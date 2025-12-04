// Exercicios  de laços de repetição em C#

#region Exercício 1

/* Console.WriteLine("Digite um número inteiro positivo:");
int numero = int.Parse(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
} */

#endregion

#region Exercício 2

/* int soma = 0;
while (true)
{
    Console.WriteLine("Digite um número inteiro (ou 0 para sair):");
    int numero = int.Parse(Console.ReadLine());
    if (numero == 0)
    {
        break;
    }
    soma += numero;
}
Console.WriteLine($"A soma dos números digitados é: {soma}"); */

#endregion

#region Exercício 3

/* Console.WriteLine("Digite um número inteiro positivo:");
int numero = int.Parse(Console.ReadLine());
int fatorial = 1;
for (int i = 1; i <= numero; i++)
{
    fatorial *= i;
}
Console.WriteLine($"O fatorial de {numero} é: {fatorial}"); */


#endregion

#region Exercício 4

/* Console.WriteLine("Digite um texto ou uma palavra:");
string input = Console.ReadLine();
int contadorVogais = 0;
foreach (char c in input.ToLower())
{
    if ("aeiou".Contains(c))
    {
        contadorVogais++;
    }
}
Console.WriteLine($"A string contém {contadorVogais} vogais."); */


#endregion

#region Exercício 5

/* Console.WriteLine("Digite um número inteiro positivo:");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
} */

#endregion


Console.Write($"I")