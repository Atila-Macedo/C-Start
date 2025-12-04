class Pessoa
{
    // 1° Construtor
    public Pessoa ()
    {
        Console.WriteLine("Construtor 1 chamado");
    }

    // 2° Construtor
    public Pessoa (string nome)
    {
        Console.WriteLine($"Construtor 2 chamado. Nome: {nome}");
    }


    // 3° Construtor
    public Pessoa (string nome, int idade)
    {
        Console.WriteLine($"Construtor 3 chamado. Olá {nome}, você tem {idade} anos.");
    }
}