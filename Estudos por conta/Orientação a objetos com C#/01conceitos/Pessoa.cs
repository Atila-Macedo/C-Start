class Pessoa
{
    //Atributos
    //nome
    public string? Nome;

    //idade
    public int Idade;
    

    //Método de apresentação
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}.");
    }

    //Método par retornar a situação da idade
    public string VerificarIdade()
    {
        return Idade >= 18 ? "Maior de idade" : "Menor de idade";
    }

}