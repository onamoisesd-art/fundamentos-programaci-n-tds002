using System;

class Program
{
    static double saldo = 10000;

    static bool ValidarPIN()
    {
        int intentos = 0;
        const string pinCorrecto = "1234";
        while (intentos < 3)
        {
            Console.Write("Ingrese PIN: ");
            string pin = Console.ReadLine();
            if (pin == pinCorrecto) return true;
            intentos++;
            Console.WriteLine("PIN incorrecto.");
        }
        return false;
    }

    static void Consultar()
    {
        Console.WriteLine($"Saldo actual: {saldo:C}");
    }

    static void Depositar()
    {
        Console.Write("Monto a depositar: ");
        double monto = double.Parse(Console.ReadLine());
        saldo += monto;
        Console.WriteLine("Depósito realizado.");
    }

    static void Retirar()
    {
        Console.Write("Monto a retirar (múltiplo de 100): ");
        double monto = double.Parse(Console.ReadLine());
        if (monto % 100 != 0)
        {
            Console.WriteLine("El monto debe ser múltiplo de 100.");
            return;
        }
        if (monto > saldo)
        {
            Console.WriteLine("Fondos insuficientes.");
            return;
        }
        saldo -= monto;
        Console.WriteLine("Retiro realizado.");
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nMenú Cajero:");
        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Depositar");
        Console.WriteLine("3. Retirar");
        Console.WriteLine("4. Salir");
    }

    static void Main()
    {
        if (!ValidarPIN())
        {
            Console.WriteLine("Acceso bloqueado.");
            return;
        }

        int opcion;
        do
        {
            MostrarMenu();
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: Consultar(); break;
                case 2: Depositar(); break;
                case 3: Retirar(); break;
                case 4: Console.WriteLine("Gracias por usar el cajero."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        } while (opcion != 4);
    }
}

