string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[#] Radiciacao");
Console.WriteLine("[^] Exponenciacao");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        Aritmetica.Soma();
        break;
    case "-":
    Aritmetica.subtracao();
        break;
    case "*":
    Aritmetica.mutiplicacao();

        break;
    case "/":
    Aritmetica.divisao();

        break;

    case "#":
    Aritmetica.radiciacao();
    
        break;
    case "^":
    Aritmetica.exponenciacao();
        break;

    default:
        Console.WriteLine("Opção inválida.");
        break;
    

}

Console.WriteLine("\nObrigado por utilizar nosso programa.");

Console.Clear();

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nNome: Ana Carolina Rodrigues");
Console.WriteLine("\nGithub: Anacarolinar21\n");
Console.ResetColor();