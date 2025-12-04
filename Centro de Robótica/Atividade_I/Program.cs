//Aula 05 - Avaliação
#region Avaliação

#region Q1 ✅
/* //Declara as variáveis
double a, b, c, perimetro, area, s;
Console.WriteLine("Cálculo do Perímetro e Área de um Triângulo");
//Entrada de dados
Console.Write("Digite o valor do lado a: ");
a = double.Parse(Console.ReadLine()!);
Console.Write("Digite o valor do lado b: ");
b = double.Parse(Console.ReadLine()!);
Console.Write("Digite o valor do lado c: ");
c = double.Parse(Console.ReadLine()!);
//Processamento
perimetro = a + b + c;
s = perimetro / 2;
area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
//Saída de dados
Console.WriteLine($"O perímetro do triângulo é {perimetro:F3} e a área é {area:F3}."); */

#endregion

#region Q2✅

/* //Declara as variáveis
float horasTrabalhadas, valorHora, salarioBruto;
//Entrada de dados
Console.WriteLine("Cálculo do Salário Bruto");
float salarioLiquido;
Console.Write("Digite o número de horas trabalhadas: ");
horasTrabalhadas = float.Parse(Console.ReadLine()!);
Console.Write("Digite o valor da hora trabalhada: ");
valorHora = float.Parse(Console.ReadLine()!);
//Processamento
salarioBruto = horasTrabalhadas * valorHora;
//Saída de dados
Console.WriteLine($"O salário bruto é de R$ {salarioBruto:F2}."); */


/* //Entrada de dados
Console.Write("Digite o número de horas trabalhadas: ");
float horasTrabalhadas = float.Parse(Console.ReadLine()!);
Console.Write("Digite o valor da hora trabalhada: ");
float valorHora = float.Parse(Console.ReadLine()!);
//Processamento
float salarioBruto = horasTrabalhadas * valorHora;
//Saída de dados
Console.WriteLine($"O salário bruto é de R$ {salarioBruto:F2}.");  */


#endregion

#region Q3✅

/* //Declara as variáveis
double velocidade, tempo, distancia;
//Entrada de dados
Console.Write("Digite a velocidade em km/h: ");
velocidade = double.Parse(Console.ReadLine()!);
Console.Write("Digite o tempo em horas: ");
tempo = double.Parse(Console.ReadLine()!);
//Processamento
distancia = velocidade * tempo;
//Saída de dados
Console.WriteLine($"A distância percorrida é de {distancia:F2} metros."); */

#endregion

#region Q4✅

/* int raio = 0;
Console.Write("Digite o valor do raio da esfera: ");
raio = int.Parse(Console.ReadLine()!);
double volume = (4.0 / 3) * Math.PI * Math.Pow(raio, 3);
Console.WriteLine($"O volume da esfera é {volume:F4}."); */

#endregion

#region Q5✅

/* float temperaturaF, temperaturaC;
Console.Write("Digite a temperatura em °F: ");
temperaturaF = float.Parse(Console.ReadLine()!);
temperaturaC = (temperaturaF - 32) * 5 / 9;
Console.WriteLine($"A temperatura em °C é {temperaturaC:F2}."); */

#endregion

#region Q6✅

/* double nota1, nota2, nota3, nota4, media, peso, mediaFinal;

const int peso1 = 1, peso2 = 2, peso3 = 3, peso4 = 4;

Console.Write("Digite a primeira nota: "); 
nota1 = double.Parse(Console.ReadLine()!);
Console.Write("Digite a segunda nota: ");
nota2 = double.Parse(Console.ReadLine()!);
Console.Write("Digite a terceira nota: ");
nota3 = double.Parse(Console.ReadLine()!);
Console.Write("Digite a quarta nota: ");
nota4 = double.Parse(Console.ReadLine()!);
media = (nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3) + (nota4 * peso4);
peso = peso1 + peso2 + peso3 + peso4;
mediaFinal = media / peso;
Console.WriteLine($"A média ponderada é {media:F2}."); */

#endregion

#region Q7✅

/* decimal reais, imposto, valorComImposto;
Console.Write("Digite o valor em reais: ");
reais = decimal.Parse(Console.ReadLine()!);
imposto = reais * 0.07m;
valorComImposto = reais + imposto;
Console.WriteLine($"O valor do imposto é R$ {valorComImposto:F2}."); */

#endregion

#region Q8✅

/* //Declara as variáveis
int segundos, horas, minutos;
//Entrada de dados
Console.Write("Digite o número de segundos: ");
segundos = int.Parse(Console.ReadLine()!);
//Processamento
horas = segundos / 3600;
minutos = (segundos % 3600) / 60;
segundos = segundos % 60;
//Saída de dados
Console.WriteLine($"O valor convertido é {horas} horas, {minutos} minutos e {segundos} segundos."); */


#endregion

#region Q9✅

/* double hipotenusa, catetoA, catetoB;
Console.Write("Digite o valor do cateto A: ");
catetoA = double.Parse(Console.ReadLine()!);
Console.Write("Digite o valor do cateto B: ");
catetoB = double.Parse(Console.ReadLine()!);
hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
Console.WriteLine($"O valor da hipotenusa é {hipotenusa:F2}."); */

#endregion

#region Q10✅

/* float metros, tempo, Kmh;
Console.Write("Digite a distância em metros: ");
metros = float.Parse(Console.ReadLine()!);
Console.Write("Digite o tempo em segundos: ");
tempo = float.Parse(Console.ReadLine()!);
Kmh = metros / 1000 / (tempo / 3600);
Console.WriteLine($"A velocidade média é {Kmh:F2} km/h."); */

#endregion

#endregion




#region Estruta

#region Menus if/else

/* char opcao;
do
{
    Console.WriteLine("Menu de Opções:");
    Console.WriteLine("1 - Opção 1");
    Console.WriteLine("2 - Opção 2");
    Console.WriteLine("3 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (opcao == '1')
    {
        Console.WriteLine("Você escolheu a Opção 1.");
    }
    else if (opcao == '2')
    {
        Console.WriteLine("Você escolheu a Opção 2.");
    }
    else if (opcao == '3')
    {
        Console.WriteLine("Saindo do programa...");
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
    }

} while (opcao != '3'); */


#endregion

#region if/else 

/* float temperatura;
Console.Write("Digite a temperatura em °C: ");
temperatura = float.Parse(Console.ReadLine()!);
if (temperatura < 0)
{
    Console.WriteLine("A temperatura está negativa.");
}
else if (temperatura >= 0 && temperatura <= 30)
{
    Console.WriteLine("A temperatura está amena.");
}
else
{
    Console.WriteLine("A temperatura está alta.");
} */



#endregion

#region terário

/* string negativaoPositivo(int numero) => numero < 0 ? "Negativo" : numero > 0 ? "Positivo" : "Zero";

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine()!);
Console.WriteLine($"O número é {negativaoPositivo(numero)}."); */

#endregion

#region switch/case

/* char menu; */
/* do
{ */
/*     Console.WriteLine("Menu de Opções:");
    Console.WriteLine("A - Produto Alimentício");
    Console.WriteLine("B - Bebida");
   
 Console.WriteLine("C - Limpeza");
    Console.WriteLine("D - Eletrônico");
    Console.Write("Escolha uma opção: ");
    menu = Char.ToUpper(Console.ReadKey().KeyChar);
    Console.WriteLine();

    switch (menu)
    {
        case 'A': Console.WriteLine("Você escolheu Produto Alimentício."); break;
        case 'B': Console.WriteLine("Você escolheu Bebida."); break;
        case 'C': Console.WriteLine("Você escolheu Limpeza."); break;
        case 'D': Console.WriteLine("Você escolheu Eletrônico."); break;
        default: Console.WriteLine("Categoria inválida."); break; */
/* } while (menu != 'D');  */


#endregion

#endregion