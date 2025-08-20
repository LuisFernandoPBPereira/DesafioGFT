var alfabeto = "abcdefghijklmnopqrstuvwxyz";


var palavra = Console.ReadLine();

string sequencia = string.Empty;

for (int i = 0; i < palavra.Length; i++)
{
    sequencia += palavra[i];

    if (sequencia.Length >= 3)
    {
        alfabeto.Contains(sequencia);
    }
}