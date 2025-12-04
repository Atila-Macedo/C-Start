class Pessoa
{
    // Atributos
    private string? _nome;
    private int _idade;


    // Construtor
    public Pessoa(string Nome, int Idade)
    {
        _nome = Nome;
        _idade = Idade;
    }

    // Metodos para apresentar os dados
    protected void ApresentarPessoa()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine($"Idade: {_idade}");

    }

}