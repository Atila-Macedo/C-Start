static class BancoDados
{
    public static async Task SalvarUsuarioAsync(Usuario usuario)
    {
        Console.WriteLine("Salvando usuário no banco de dados...");
        await Task.Delay(10000); // Simula um atraso de 10 segundos
        Console.WriteLine("Usuário salvo com sucesso!");
        Console.WriteLine($"Email: {usuario.email}");
    }
}