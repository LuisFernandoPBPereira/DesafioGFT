namespace Desafio2.Classes;

public class Tambor : IInstrumento
{
    public void Tocar()
    {
        Console.WriteLine($"{nameof(Tambor)}: ♫ tum tum tum ♫");
    }
}
