using System;

class Program
{
    static void Main()
    {
        // 1. Tabla de multiplicar con FOR
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nTabla de multiplicar del {num}");
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }

        // 2. Menú que no muere con DO-WHILE
        int opcion;
        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Sumar dos números");
            Console.WriteLine("2. Verificar si un número es primo");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Número A: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Número B: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultado: {a + b}");
                    break;
                case 2:
                    Console.Write("Ingrese número: ");
                    int n = int.Parse(Console.ReadLine());
                    bool primo = true;
                    if (n <= 1) primo = false;
                    else
                    {
                        for (int i = 2; i <= Math.Sqrt(n); i++)
                        {
                            if (n % i == 0) { primo = false; break; }
                        }
                    }
                    Console.WriteLine(primo ? "Es primo" : "No es primo");
                    break;
                case 3:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 3);

        // 3. Adivina el número
        Random rnd = new Random();
        int secreto, intento, contador;
        string jugar;
        do
        {
            secreto = rnd.Next(1, 21); // número entre 1 y 20
            contador = 0;
            Console.WriteLine("\nAdivina el número (1-20)");
            do
            {
                Console.Write("Tu intento: ");
                intento = int.Parse(Console.ReadLine());
                contador++;
                if (intento > secreto) Console.WriteLine("Muy alto");
                else if (intento < secreto) Console.WriteLine("Muy bajo");
                else Console.WriteLine($"¡Correcto en {contador} intentos!");
            } while (intento != secreto);

            Console.Write("¿Quieres jugar otra vez? (s/n): ");
            jugar = Console.ReadLine().ToLower();
        } while (jugar == "s");

        // 4. Pirámide con ciclos anidados
        Console.Write("\nIngrese altura de la pirámide: ");
        int altura = int.Parse(Console.ReadLine());
        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // 5. Break y Continue
        Console.WriteLine("\nNúmeros del 1 al 50 (saltando múltiplos de 3, detener en múltiplo de 7 > 30):");
        for (int i = 1; i <= 50; i++)
        {
            if (i % 3 == 0) continue;
            Console.WriteLine(i);
            if (i > 30 && i % 7 == 0) break;
        }
    }
}
