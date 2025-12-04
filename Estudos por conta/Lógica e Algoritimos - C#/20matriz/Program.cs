// Matriz

string[,] dados =
{
    { "ID", "Nome", "Idade" },
    { "1", "Ana", "28" },
    { "2", "Bruno", "34" },
    { "3", "Carla", "23" }
};

// Exibir dados
//Console.WriteLine(dados[1,1]);

foreach(string dado in dados)
{
    Console.Write(dado);
}   