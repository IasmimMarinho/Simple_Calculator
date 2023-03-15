using System;

class Program
{
    static void Menu()
    {
        Console.Write("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Operação desejada: ");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("");

        short op = short.Parse(Console.ReadLine());

        switch (op)
        {
            case 1: Sum(v1, v2); break;
            case 2: Sub(v1, v2); break;
            case 3: Div(v1, v2); break;
            case 4: Mult(v1, v2); break;
            case 0:
                System.Environment.Exit(0);
                break;
            default: Menu(); break;

        }
        Console.WriteLine("");
    }
    static void Sum(float v1, float v2)
    {
        Console.WriteLine($"O resultado da soma é {(v1 + v2)}");
        Direct();
    }
    static void Sub(float v1, float v2)
    {
        Console.WriteLine($"O resultado da subtração é {(v1 - v2)}");
        Direct();
    }
    static void Div(float v1, float v2)
    {
        Console.WriteLine($"O resultado da divisão é {(v1 / v2)}");
        Direct();
    }
    static void Mult(float v1, float v2)
    {
        Console.WriteLine($"O resultado da Multiplicação é {(v1 * v2)}");
        Direct();
    }
    static void Direct()
    {
        Console.WriteLine("");

        Console.WriteLine("Continuar - 1");
        Console.WriteLine("Sair - 0");
        int res = int.Parse(Console.ReadLine());

        if (res == 1)
        {
            Console.Clear();
            Menu();
        }
        else
        {
            System.Environment.Exit(0);
        }
    }

    public static void Main(string[] args)
    {
        Console.Clear();

        Menu();

        Console.ReadKey();

    }
}

