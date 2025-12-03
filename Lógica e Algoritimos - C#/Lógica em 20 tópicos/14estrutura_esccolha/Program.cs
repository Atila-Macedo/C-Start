
#region Switch Case em C#
// Váriável

string linguagem = "HTML";

// Estrutura de escolha
switch (linguagem)
{
    case "HTML":
        Console.WriteLine("Linguagem de marcação para estruturar páginas web.");
        break;

        case "CSS":
        Console.WriteLine("Linguagem de estilo para estilizar páginas web.");
        break;

        case "C#":
        Console.WriteLine("Linguagem de programação orientada a objetos desenvolvida pela Microsoft.");
        break;

        default:
        Console.WriteLine("Linguagem desconhecida.");
        break;
}
#endregion


// Expressão switch
/* string retorno = linguagem switch
{
    "HTML" => "Linguagem de marcação para estruturar páginas web.",
    "CSS" => "Linguagem de estilo para estilizar páginas web.",
    "C#" => "Linguagem de programação orientada a objetos desenvolvida pela Microsoft.",
    _ => "Linguagem desconhecida."
}; */