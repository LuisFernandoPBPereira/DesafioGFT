namespace Desafio2.Classes;

public class Violino : IInstrumento
{
    public void Tocar()
    {
        Console.WriteLine($"{nameof(Violino)}: ♫ fiiiiiiuuu ♫");
    }
}
