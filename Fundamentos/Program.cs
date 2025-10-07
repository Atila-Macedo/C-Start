#region Meu primeiro programa em C#
// Console.WriteLine("Hello, World!");
#endregion

//Aula 02 - Fundamentos de C#
#region Tipos de Váriaveis

// Insetir Dados dentro de uma variável

#region Variáveis de entrada e Saída
/* Console.WriteLine("Digite sua idade: "); // Imprime no console
string idadeImput = Console.ReadLine(); // Lê o que o usuário digitou no console
Console.WriteLine($"Sua idade é {idadeImput} anos");// Imprime no console a idade digitada pelo usuário */
#endregion

#region Variáveis de tipos primitivos

/* // Texto (Conjunto de caracteres)
string nome = "Átila";
int idade = 25; 
Console.WriteLine($"Seu nome é {nome}"); // Interpolação de strings
Console.WriteLine("Seu nome é {0} e tem {1} anos.", nome, idade); // Placeholders */

#endregion

#region Declaração de Variáveis
/* // Sintaxe de Decclaração de Variáveis
// Do tipo Inteiro
int idade; // posso começar declarando a variável sem atribuir um valor
int idade02 = 25; // posso declarar e atribuir um valor na mesma linha

//Numero quebrado (numero com parte fracionária)
double peso; // posso começar declarando a variável sem atribuir um valor
double altura = 1.77; // Números quebrados com mais precisão (Exemplo: 10.5, 25.99, -1500.50)
double altura02 = 1.77; // Números quebrados com menos precisão

// Texto (Conjunto de caracteres)
string nome; // Exemplo: "João", "Maria", "Pedro"

// Booleano (Verdadeiro ou Falso)
bool estudante; // Exemplo: true (verdadeiro), false (falso)
bool estudante02 = true;
bool estudante03 = false;
bool valor = 2 < 3; */
#endregion

#endregion

//Aula 03 - Operadores Aritméticos, Atribuição e Comparação
#region Operadores Aritméticos 

#region Exercício 1
/* string nomeDoUsuario;
int idadeDoUsuario;

Console.Write("Digite seu nome: ");
nomeDoUsuario = Console.ReadLine()!;
Console.Write("Digite sua idade: ");
idadeDoUsuario = int.Parse(Console.ReadLine()!);
Console.Write($"Olá {nomeDoUsuario}, você tem {idadeDoUsuario} anos."); */
#endregion

#region  Exercício 2
/* int num1 = 10, num2 = 20; 
Console.WriteLine($"A soma entre {num1} e {num2} é igual a {num1 + num2}.");  
Console.WriteLine($"A subtração entre {num2} e {num1} é igual a {num2 - num1}.");
Console.WriteLine($"A multiplicação entre {num1} e {num2} é igual a {num1 * num2}."); 
Console.WriteLine($"A divisão entre {num2} e {num1} é igual a {num2 / num1}.");

int num3 = 11, num4 = 3;
Console.WriteLine($"O resto da divisão entre {num3} e {num4} é igual a {num3 % num4}."); */
#endregion

#region  Exercício 3
/* double raio = 5.5;
Console.WriteLine($"Para um círculo com raio {raio}, a área é {Math.PI * Math.Pow(raio, 2)} e o perímetro é {2 * Math.PI * raio}."); */
#endregion

#region Exercício 4
/* double c = 25.0;
Console.WriteLine($"{c}°C equivalem a {(c * 9/5) + 32}°F."); */

#endregion

#endregion

//Aula 04 - Prática
#region Exercícios

#region Exercício 1
/* Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()!);
int proximoAno = idade + 1;
Console.WriteLine($"No próximo ano você terá {proximoAno} anos."); */

#endregion

#region Exercício 2
/* Console.Write("Digite o valor do desejado: ");
float valor = float.Parse(Console.ReadLine()!);
Console.Write("Digite a quantidade de parcelas desejada: ");
double parcelas = double.Parse(Console.ReadLine()!);
double valorParcela = (valor / parcelas) + (valor * 0.05);
Console.WriteLine($"O valor de cada parcela será de R$ {valorParcela}."); */

#endregion

#region Exercício 3
/* char letra;
Console.Write("Digite uma letra: ");
letra = Console.ReadKey().KeyChar;
Console.WriteLine($"\nA letra digitada foi: {letra}."); */

#endregion

#region Exercício 4
/* Console.Write("Digite seu nome: ");
string nome = Console.ReadLine()!;
Console.Write("Digite seu sobrenome: ");
string sobrenome = Console.ReadLine()!;
string nomeCompleto = nome + " " + sobrenome;
Console.WriteLine($"Olá, {nomeCompleto}, seja bem-vindo!"); */

#endregion

#region Exercício 5

/* Console.Write("Digite o primeiro valor decimal: ");
decimal valor1 = decimal.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo valor decimal: ");
decimal valor2 = decimal.Parse(Console.ReadLine()!);
decimal resultado = valor1 * valor2;
Console.WriteLine($"O resultado da multiplicação é: {resultado.ToString("F2")}."); */

#endregion

#region Exercício 6
/* Console.Write("Digite o núemero para calcular o quadrado: ");
int numero = int.Parse(Console.ReadLine()!);
int quadrado = numero * numero;
Console.WriteLine($"O quadrado de {numero} é {quadrado}."); */

#endregion

#region Exercício 7

/* Console.Write("Digite a nota do primeiro semestre:  ");
double nota1 = double.Parse(Console.ReadLine()!);
Console.Write("Digite a nota do segundo semestre:  ");
double nota2 = double.Parse(Console.ReadLine()!);
double media = (nota1 + nota2) / 2;
Console.WriteLine($"A média anual é {media}.");  */


#endregion

#region Exercício 8
//Cenário: Copras acima de 50 ganham 10.5 de desconto
/* const float valorDesconto = 10.5f;
Console.Write("O valor da compra: ");
float valorCompra = float.Parse(Console.ReadLine()!);
float valorFinal = valorCompra - valorDesconto;
Console.WriteLine($"O valor final da compra é {valorFinal}."); */

#endregion

#region Exercício 9

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine()!;
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Olá {nome}, você tem {idade} anos.");

#endregion

#endregion

