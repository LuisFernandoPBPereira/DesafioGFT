namespace Desafio2.Classes;

public class Piano : IInstrumento
{
    public void Tocar()
    {
        Console.WriteLine($"{nameof(Piano)}: ♫ plim plim plim ♫");
    }
}
