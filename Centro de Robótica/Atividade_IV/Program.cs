#region 1

/* void MostrarMensagem(string mensagem)
{
    Console.WriteLine(mensagem);
} 

MostrarMensagem("Olá, esta é uma mensagem de teste da Atividade IV."); */

#endregion

#region 2

/* void ExibirSaudacaoHora(string nome, int hora)
{
    if (hora >= 6 && hora <= 12)
    {
        Console.WriteLine($"Bom dia, {nome}!");
    }
    else if (hora >= 13 && hora <= 18)
    {
        Console.WriteLine($"Boa tarde, {nome}!");
    }
    else
    {
        Console.WriteLine($"Boa noite, {nome}!");
    }
}  
Console.Write("Digite seu nome: ");
string nomeUsuario = Console.ReadLine()!;
int horaAtual = DateTime.Now.Hour;
ExibirSaudacaoHora(nomeUsuario, horaAtual);
 */



#endregion

#region 3
    
/* int GerarNumeroAleatorio(int min, int max)
{
    Random random = new Random();
    return random.Next(min, max + 1);
}
Console.Write("Digite o valor mínimo: ");
int minValor = int.Parse(Console.ReadLine()!);
Console.Write("Digite o valor máximo: ");
int maxValor = int.Parse(Console.ReadLine()!);
int numeroAleatorio = GerarNumeroAleatorio(minValor, maxValor);
Console.WriteLine($"Número aleatório entre {minValor} e {maxValor}: {numeroAleatorio}"); */

#endregion

#region 4
    
/* int CalcularCubo(int numero)
{
    return numero * numero * numero;
}
Console.Write("Digite um número para calcular o cubo: ");
int numeroInput = int.Parse(Console.ReadLine()!);
int cubo = CalcularCubo(numeroInput);
Console.WriteLine($"O cubo de {numeroInput} é {cubo}."); */

#endregion

#region 5
    
/* int Multiplicador(int a, int b)
{
    return a * b;
}
Console.Write("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine()!);
int multiplo = Multiplicador(num1, num2);
Console.WriteLine($"O resultado da multiplicação de {num1} e {num2} é {multiplo}."); */

#endregion

#region 6
    
/* int CalcularSoma(int n)
{
    int soma = 0;
    for (int i = 1; i <= n; i++)
    {
        soma += i;
    }
    return soma;
}
Console.Write("Digite um número inteiro positivo: ");
int numeroInput = int.Parse(Console.ReadLine()!);
int resultadoSoma = CalcularSoma(numeroInput);
Console.WriteLine($"A soma dos números de 1 a {numeroInput} é {resultadoSoma}."); */

#endregion

#region 7

/* string RepetirString(string texto, int n)
{
    string resultado = "";
    for (int i = 0; i < n; i++)
    {
        resultado += texto;
    }
    return resultado;
}
Console.Write("Digite uma string: ");
string textoInput = Console.ReadLine()!;
Console.Write("Digite o número de repetições: ");
int repeticoes = int.Parse(Console.ReadLine()!);
string textoRepetido = RepetirString(textoInput, repeticoes);
Console.WriteLine($"String repetida {repeticoes} vezes: {textoRepetido}"); */

#endregion

#region 8

/* bool ContemApenasLetras(string texto)
{
    foreach (char c in texto)
    {
        if (!char.IsLetter(c))
        {
            return false;
        }
    }
    return true;
}
Console.Write("Digite uma string: ");
string textoInput = Console.ReadLine()!;
bool resultado = ContemApenasLetras(textoInput);
if (resultado)
{
    Console.WriteLine("A string contém apenas letras.");
}
else
{
    Console.WriteLine("A string contém caracteres que não são letras.");
} */

#endregion

#region 9
    
/* int EncontrarMenorNumero(int[] numeros)
{
    int menor = numeros[0];
    foreach (int num in numeros)
    {
        if (num < menor)
        {
            menor = num;
        }
    }
    return menor;
}
Console.Write("Digite a quantidade de números no array: ");
int quantidade = int.Parse(Console.ReadLine()!);
int[] numerosArray = new int[quantidade];
for (int i = 0; i < quantidade; i++)
{
    Console.Write($"Digite o número {i + 1}: ");
    numerosArray[i] = int.Parse(Console.ReadLine()!);
}
int menorNumero = EncontrarMenorNumero(numerosArray);
Console.WriteLine($"O menor número no array é: {menorNumero}");
   */
#endregion

#region 10

/* int ContarPalavras(string texto)
{
    if (string.IsNullOrWhiteSpace(texto))
    {
        return 0;
    }
    string[] palavras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return palavras.Length;
}
Console.Write("Digite uma string: ");
string textoInput = Console.ReadLine()!;
int numeroPalavras = ContarPalavras(textoInput);
Console.WriteLine($"A string contém {numeroPalavras} palavras."); */

#endregion

