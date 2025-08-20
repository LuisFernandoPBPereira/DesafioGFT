using Desafio2;
using Desafio2.Classes;

var instrumentosParaOrquestra = new List<IInstrumento>();

string opcao = string.Empty;

Console.WriteLine("Quais instrumentos você deseja adicionar para a orquestra?");
Console.WriteLine("1 - Violino\n2 - Piano\n3 - Tambor\n4 - Apresentar Orquestra\n0 - Sair");

while (opcao != "0")
{
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            AdicionarInstrumento(new Violino());
            break;
    
        case "2":
            AdicionarInstrumento(new Piano());
            break;
    
        case "3":
            AdicionarInstrumento(new Tambor());
            break;
    
        case "4":
            ApresentarOrquestra();
            break;
        
        case "0":
            Console.WriteLine("Saindo da aplicação...");
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente");
            break;
    }
}


void ApresentarOrquestra()
{
    foreach(var instrumento in instrumentosParaOrquestra)
    {
        instrumento.Tocar();
    }
}

void AdicionarInstrumento(IInstrumento instrumento)
{
    instrumentosParaOrquestra.Add(instrumento);
    Console.WriteLine("Instrumento adicionado\n");
}