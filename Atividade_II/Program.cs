#region Q1 ✅

/* int num1, num2, num3;
Console.WriteLine("Digite o primeiro número inteiro:");
num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o segundo número inteiro:");
num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o terceiro número inteiro:");
num3 = int.Parse(Console.ReadLine()!);

int maior, menor;

// Encontrar o maior número
if (num1 >= num2 && num1 >= num3)
{
    maior = num1;
}
else if (num2 >= num1 && num2 >= num3)
{
    maior = num2;
}
else
{
    maior = num3;
}

// Encontrar o menor número
if (num1 <= num2 && num1 <= num3)
{
    menor = num1;
}
else if (num2 <= num1 && num2 <= num3)
{
    menor = num2;
}
else
{
    menor = num3;
}

Console.WriteLine("O maior número é: " + maior);
Console.WriteLine("O menor número é: " + menor); */

#endregion

#region Q2 ✅

/* int numero;
Console.WriteLine("Digite um número inteiro:");
numero = int.Parse(Console.ReadLine()!);

if (numero >= 100 && numero <= 200)
{
    Console.WriteLine("O número está entre 100 e 200.");
}
else
{
    Console.WriteLine("O número está fora do intervalo de 100 a 200.");
} */

#endregion

#region Q3 ✅

/* char letra;
Console.WriteLine("Digite uma letra:");
letra = char.Parse(Console.ReadLine()!.ToLower());
if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
{
    Console.WriteLine("A letra é uma vogal.");
}
else if ((letra >= 'b' && letra <= 'z') && !(letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'))
{
    Console.WriteLine("A letra é uma consoante.");
}
else
{
    Console.WriteLine("O caractere digitado não é uma letra válida.");
}
 */
#endregion

#region Q4 ✅

/* int mes;
Console.WriteLine("Digite o código do mês (1 a 12):");
mes = int.Parse(Console.ReadLine()!);
switch (mes)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Verão");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Outono");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Inverno");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Primavera");
        break;
    default:
        Console.WriteLine("Código de mês inválido. Por favor, insira um número entre 1 e 12.");
        break;
} */

#endregion

#region Q5 ✅

/* int num;
Console.WriteLine("Digite um número inteiro:");
num = int.Parse(Console.ReadLine()!);

if (num > 0)
{
    Console.WriteLine("O número é positivo.");
} else if (num == 0)
{
    Console.WriteLine("O número é zero.");
} else 
{
    Console.WriteLine("O número é negativo.");
}
 */


#endregion

#region Q6 ✅

/* decimal salario, imposto;
Console.WriteLine("Digite o salário do funcionário:");
salario = decimal.Parse(Console.ReadLine()!);
if (salario <= 2000)
{
    imposto = 0;
}
else if (salario <= 3000)
{
    imposto = salario * 0.08m;
}
else
{
    imposto = salario * 0.15m;
}
Console.WriteLine("O imposto de renda é: R$ " + imposto.ToString("F2")); */

#endregion

#region Q7✅

/* int nota;
Console.WriteLine("Digite a nota: ");
nota = int.Parse(Console.ReadLine()!); */

// Usando if else
/* if (nota >= 90 && nota <= 100)
{
    Console.WriteLine("A");
}
else if (nota >= 80 && nota < 90)
{
    Console.WriteLine("B");
}
else if (nota >= 70 && nota < 80)
{
    Console.WriteLine("C");
}
else if (nota >= 60 && nota < 70)
{
    Console.WriteLine("D");
}
else if (nota >= 0 && nota < 60)
{
    Console.WriteLine("F");
}
else
{
    Console.WriteLine("Nota inválida.");
} */

// Usando switch case
/* switch (nota)
{
    case int n when (n >= 90 && n <= 100):
        Console.WriteLine("A");
        break;
    case int n when (n >= 80 && n < 90):
        Console.WriteLine("B");
        break;
    case int n when (n >= 70 && n < 80):
        Console.WriteLine("C");
        break;
    case int n when (n >= 60 && n < 70):
        Console.WriteLine("D");
        break;
    case int n when (n >= 0 && n < 60):
        Console.WriteLine("F");
        break;
    default:
        Console.WriteLine("Nota inválida.");
        break;
} */


#endregion

#region Q8✅

/* char caractere;
Console.WriteLine("Digite um caractere:");
caractere = char.Parse(Console.ReadLine()!);
if (char.IsUpper(caractere))
{
    Console.WriteLine("O caractere é maiúsculo.");
}
else if (char.IsLower(caractere))
{
    Console.WriteLine("O caractere é minúsculo.");
}
else
{
    Console.WriteLine("O caractere não é uma letra.");
} */

#endregion

#region Q9✅

/* int codigoOperacao;
double num1, num2, resultado;
Console.WriteLine("Digite o código da operação (1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Divisão):");
codigoOperacao = int.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o primeiro número:");
num1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o segundo número:");
num2 = double.Parse(Console.ReadLine()!);

switch (codigoOperacao)
{
    case 1:
        resultado = num1 + num2;
        Console.WriteLine("Resultado da soma: " + resultado);
        break;
    case 2:
        resultado = num1 - num2;
        Console.WriteLine("Resultado da subtração: " + resultado);
        break;
    case 3:
        resultado = num1 * num2;
        Console.WriteLine("Resultado da multiplicação: " + resultado);
        break;
    case 4:
        if (num2 != 0)
        {
            resultado = num1 / num2;
            Console.WriteLine("Resultado da divisão: " + resultado);
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }
        break;
    default:
        Console.WriteLine("Código de operação inválido.");
        break;
} */

#endregion

#region Q10✅

/* int diaSemana;
Console.WriteLine("Digite o dia da semana (1 a 7):");
diaSemana = int.Parse(Console.ReadLine()!);
string resultado = (diaSemana >= 2 && diaSemana <= 6) ? "Dia útil" : (diaSemana == 1 || diaSemana == 7) ? "Fim de semana" : "Número inválido";
Console.WriteLine(resultado); */

#endregion

