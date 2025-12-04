// Variáveis
double valor = 500;
string pagamento = "à prazo"; // Opções: "à vista" ou "à prazo"

// Condicional
if (valor >= 100 && pagamento == "à vista")
{
    Console.WriteLine($"Desconto de 10% aplicado. Valor final: R${valor * 0.9}");
}
else
{
    Console.WriteLine($"O total da compra é R${valor}");
}

