using System;

class Program
{
    // 1. Biblioteca matemática
    static int Factorial(int n)
    {
        int resultado = 1;
        for (int i = 1; i <= n; i++) resultado *= i;
        return resultado;
    }

    static bool EsPrimo(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    static int Mcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static double Potencia(double baseNum, int exp)
    {
        double resultado = 1;
        for (int i = 0; i < exp; i++) resultado *= baseNum;
        return resultado;
    }

    // 2. Sobrecarga de métodos
    static double Area(double lado) => lado * lado; // cuadrado
    static double Area(double b, double h) => b * h; // rectángulo
    static double Area(double a, double b, double c) // triángulo (Herón)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    // 3. Métodos void
    static void ImprimirLinea(char c, int n)
    {
        for (int i = 0; i < n; i++) Console.Write(c);
        Console.WriteLine();
    }

    static void ImprimirTitulo(string t)
    {
        ImprimirLinea('=', t.Length);
        Console.WriteLine(t);
        ImprimirLinea('=', t.Length);
    }

    static void Main()
    {
        // Menú para probar los métodos
        ImprimirTitulo("Biblioteca Matemática");

        Console.WriteLine($"Factorial(5) = {Factorial(5)}");
        Console.WriteLine($"EsPrimo(17) = {EsPrimo(17)}");
        Console.WriteLine($"MCD(48,18) = {Mcd(48,18)}");
        Console.WriteLine($"Potencia(2,5) = {Potencia(2,5)}");

        ImprimirTitulo("Sobrecarga de Área");
        Console.WriteLine($"Cuadrado lado 4: {Area(4)}");
        Console.WriteLine($"Rectángulo 5x3: {Area(5,3)}");
        Console.WriteLine($"Triángulo 3,4,5: {Area(3,4,5)}");

        ImprimirTitulo("Scope de variables");
        // Ejemplo: una variable declarada aquí no se ve dentro de otro método
        int x = 10;
        Console.WriteLine($"Variable en Main: {x}");
        // Si intentaras usar 'x' dentro de Factorial, daría error porque no existe en ese scope.
    }
}
