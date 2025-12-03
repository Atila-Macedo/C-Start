// Variável
int idade = 0;
Console.WriteLine("Digite sua idade: ");
idade = Convert.ToInt16(Console.ReadLine());

// Condicional
if (idade >= 18)
{
    Console.WriteLine("Pode obter a CNH");
}
else
{
    Console.WriteLine("Não pode obter a CNH");
}