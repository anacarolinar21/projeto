public class Aritmetica
{
    public static void Soma()
    {
        double a, b, resultado;
        Console.WriteLine("---Soma A+B ---\n");
        Console.WriteLine("digite os valores:");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        resultado = a + b;
        Console.WriteLine($"{a} mais {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        return;
    }

    public static void subtracao()
    {
        double a, b, resultado;
        Console.WriteLine("---Subtração A-B ---\n");

        Console.WriteLine("digite os valores:");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        resultado = a - b;
        Console.WriteLine($"{a} menos {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        return;
    }

    public static void mutiplicacao()
{
     double a, b, resultado;
        Console.WriteLine("--- Multiplicação A*B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a * b;

        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        return;
}
    public static void divisao()
    {
        double a, b, resultado;
         Console.WriteLine("--- Divisão A/B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());
        
         resultado = a / b;
         Console.WriteLine($"{a} multiplicado por {b} é {resultado}");


        if (b == 0)
        {
            Console.WriteLine("não é possivel realizar a divisão");
        }
        else
        {
           resultado = a / b;
        }

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        return;
    }

    public static void radiciacao()
    {
         double o, p, resultado;
        Console.WriteLine("--- Calcular radiciacao ---\n");

        Console.WriteLine("---radiciado o#p ---\n");
        Console.WriteLine("digite os valores:");
        o = Convert.ToDouble(Console.ReadLine());
        p = Convert.ToDouble(Console.ReadLine());
        resultado = Math.Pow(o, 1 / p);
        Console.WriteLine($"{o} radiciado {p} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        return;
    }

    public static void exponenciacao()
    {
        double numeroA, numeroB, potencia;
Console.WriteLine("--- Exponenciação A^B---\n");

Console.WriteLine("Digite os valores.");
Console.Write("(a):");
numeroA = Convert.ToDouble(Console.ReadLine());
Console.Write("(b):");
numeroB = Convert.ToDouble(Console.ReadLine());
potencia = Math.Pow(numeroA, numeroB);
Console.WriteLine($"{numeroA} elevado a {numeroB} é: {potencia}");

Console.WriteLine("\nPressione uma tecla para continuar...");
Console.ReadKey();
return;
    }

}