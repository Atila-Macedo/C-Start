abstract class Acoes
{
    
    // Métodos obrigatórios
    public abstract void Falar();
    public abstract void Andar();

    // Método opcional
    public virtual void Pular()
    {
        Console.WriteLine("Pulando...");
    }

}