using System;

class Program
{
    // 2. Entrada blindada
    static int LeerEntero(string mensaje)
    {
        int valor;
        bool valido;
        do
        {
            Console.Write(mensaje);
            valido = int.TryParse(Console.ReadLine(), out valor);
            if (!valido) Console.WriteLine("Entrada inválida. Intente de nuevo.");
        } while (!valido);
        return valor;
    }

    // Métodos para el menú
    static void Sumar()
    {
        int a = LeerEntero("Número A: ");
        int b = LeerEntero("Número B: ");
        Console.WriteLine($"Resultado: {a + b}");
    }

    static void VerificarPrimo()
    {
        int n = LeerEntero("Ingrese número: ");
        bool primo = true;
        if (n <= 1) primo = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) { primo = false; break; }
        }
        Console.WriteLine(primo ? "Es primo" : "No es primo");
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nMenú:");
        Console.WriteLine("1. Sumar dos números");
        Console.WriteLine("2. Verificar si un número es primo");
        Console.WriteLine("3. Salir");
    }

    static void Main()
    {
        int opcion;
        do
        {
            MostrarMenu();
            opcion = LeerEntero("Seleccione opción: ");
            switch (opcion)
            {
                case 1: Sumar(); break;
                case 2: VerificarPrimo(); break;
                case 3: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        } while (opcion != 3);
    }
}

