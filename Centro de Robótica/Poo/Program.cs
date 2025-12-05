class Program
{
    static async Task Main()
    {
        Console.WriteLine("Informe um email: ");
        string email = Console.ReadLine()!;
        Console.WriteLine("Informe uma senha: ");
        string senha = Console.ReadLine()!;

        Usuario usuario = new Usuario(email, senha);
        if (Validar.ValidarEmailSenha(usuario.email, usuario.senha))
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Email e senha válidos!");
            Console.WriteLine("--------------------------");
            await BancoDados.SalvarUsuarioAsync(usuario);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Processamento assíncrono iniciado para salvar o usuário.");
        }
        else
        {
            Console.WriteLine("Email ou senha não são válidos ou fortes.");
        }
    }
}