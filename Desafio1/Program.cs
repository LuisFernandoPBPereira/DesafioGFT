var alfabeto = "abcdefghijklmnopqrstuvwxyz";

Console.WriteLine("Digite uma palavra que contenha uma sequência de pelo menos 3 letras em ordem alfabética");
var palavra = Console.ReadLine();

bool contem = false;
string sequencia = string.Empty;

if (palavra is not null && palavra.Length > 0)
{
    for (int i = 0; i < palavra.Length; i++)
    {
        sequencia += palavra[i];

        if (sequencia.Length >= 3)
        {
            if (sequencia.Length > 3)
            {
                sequencia = sequencia.Substring(1, 3);
            }

            contem = alfabeto.Contains(sequencia);

            if (contem) break;
        }
    }

    if (contem)
    {
        Console.WriteLine($"A palavra {palavra} contém uma sequência em ordem alfabética, sequencia: {sequencia}");
    }
    else
    {
        Console.WriteLine($"A palavra {palavra} não contém uma sequência em ordem alfabética");

    }
}