class Colaborardor : Pessoa
{
    // Atributos
    private string? _cargo;
    private double _salario;

    // Construtor
    public Colaborardor(string Nome, int Idade, string cargo, double salario) : base(Nome, Idade)
    {
        _cargo = cargo;
        _salario = salario;

        ApresentarPessoa();
        ApresentarColaborador();
    }
    

    // Metodo para apresntar os dados
    private void ApresentarColaborador()
    {
        Console.WriteLine($"Cargo: {_cargo}");
        Console.WriteLine($"Salário: {_salario}");
    }


}