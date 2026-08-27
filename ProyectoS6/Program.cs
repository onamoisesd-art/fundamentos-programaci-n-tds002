using System;

class Program
{
    static void Main()
    {
        // 1. Calificación ITLA
        Console.Write("Ingrese nota (0-100): ");
        int nota = int.Parse(Console.ReadLine());
        if (nota < 0 || nota > 100)
        {
            Console.WriteLine("Nota fuera de rango.");
        }
        else
        {
            string letra;
            if (nota >= 90) letra = "A";
            else if (nota >= 80) letra = "B";
            else if (nota >= 70) letra = "C";
            else letra = "F";

            Console.WriteLine($"Calificación: {letra}");
            Console.WriteLine(nota >= 70 ? "Aprobado ✅" : "Reprobado ❌");
        }

        // 2. Menú de cafetería con switch
        Console.WriteLine("\nMenú:");
        Console.WriteLine("1. Café - 50");
        Console.WriteLine("2. Jugo - 60");
        Console.WriteLine("3. Sandwich - 120");
        Console.WriteLine("4. Empanada - 80");
        Console.WriteLine("5. Agua - 30");

        Console.Write("Seleccione opción: ");
        int opcion = int.Parse(Console.ReadLine());
        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        int precio = 0;
        switch (opcion)
        {
            case 1: precio = 50; break;
            case 2: precio = 60; break;
            case 3: precio = 120; break;
            case 4: precio = 80; break;
            case 5: precio = 30; break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
        if (precio > 0)
            Console.WriteLine($"Total a pagar: {precio * cantidad:C}");

        // 3. Triángulo
        Console.Write("\nLado A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Lado B: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Lado C: ");
        int c = int.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Forma un triángulo.");
            if (a == b && b == c) Console.WriteLine("Equilátero");
            else if (a == b || b == c || a == c) Console.WriteLine("Isósceles");
            else Console.WriteLine("Escaleno");
        }
        else
        {
            Console.WriteLine("No forma un triángulo.");
        }

        // 4. Par o impar con ternario
        Console.Write("\nIngrese un número: ");
        int num = int.Parse(Console.ReadLine());
        string resultado = (num % 2 == 0) ? "Par" : "Impar";
        Console.WriteLine($"El número es {resultado}");

        // Ampliado: positivo, negativo o cero
        string signo = (num > 0) ? "Positivo" : (num < 0 ? "Negativo" : "Cero");
        Console.WriteLine($"El número es {signo}");

        // 5. Año bisiesto
        Console.Write("\nIngrese un año: ");
        int año = int.Parse(Console.ReadLine());
        bool bisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        Console.WriteLine(bisiesto ? "Es bisiesto" : "No es bisiesto");
    }
}

