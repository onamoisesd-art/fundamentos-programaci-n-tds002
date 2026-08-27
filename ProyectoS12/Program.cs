using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Lista de tareas
        List<string> tareas = new List<string>();
        int opcion;
        do
        {
            Console.WriteLine("\nMenú de Tareas:");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Eliminar tarea");
            Console.WriteLine("3. Marcar como hecha");
            Console.WriteLine("4. Listar tareas");
            Console.WriteLine("5. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Nueva tarea: ");
                    tareas.Add(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Número de tarea a eliminar: ");
                    int idx = int.Parse(Console.ReadLine());
                    if (idx >= 0 && idx < tareas.Count) tareas.RemoveAt(idx);
                    else Console.WriteLine("Índice inválido.");
                    break;
                case 3:
                    Console.Write("Número de tarea a marcar: ");
                    int pos = int.Parse(Console.ReadLine());
                    if (pos >= 0 && pos < tareas.Count) tareas[pos] = "[x] " + tareas[pos];
                    else Console.WriteLine("Índice inválido.");
                    break;
                case 4:
                    Console.WriteLine("\nLista de tareas:");
                    for (int i = 0; i < tareas.Count; i++)
                        Console.WriteLine($"{i}. {tareas[i]}");
                    break;
                case 5:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 5);

        // 2. Arreglo vs lista
        Console.WriteLine("\n--- Arreglo ---");
        string[] nombresArr = new string[3];
        for (int i = 0; i < nombresArr.Length; i++)
        {
            Console.Write($"Nombre {i+1}: ");
            nombresArr[i] = Console.ReadLine();
        }
        Console.WriteLine("Nombres en arreglo: " + string.Join(", ", nombresArr));

        Console.WriteLine("\n--- Lista ---");
        List<string> nombresList = new List<string>();
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Nombre {i+1}: ");
            nombresList.Add(Console.ReadLine());
        }
        Console.WriteLine("Nombres en lista: " + string.Join(", ", nombresList));
        // Comentario: la lista puede crecer dinámicamente, el arreglo tiene tamaño fijo.

        // 3. Filtro
        Random rnd = new Random();
        List<int> numeros = new List<int>();
        for (int i = 0; i < 15; i++) numeros.Add(rnd.Next(1, 100));
        List<int> pares = numeros.FindAll(n => n % 2 == 0);
        List<int> mayores50 = numeros.FindAll(n => n > 50);
        Console.WriteLine("\nOriginal: " + string.Join(", ", numeros));
        Console.WriteLine("Pares: " + string.Join(", ", pares) + $" (Count={pares.Count})");
        Console.WriteLine("Mayores a 50: " + string.Join(", ", mayores50) + $" (Count={mayores50.Count})");

        // 4. Sin repetidos
        List<string> palabras = new List<string>();
        string entrada;
        Console.WriteLine("\nIngrese palabras (escriba 'fin' para terminar):");
        do
        {
            entrada = Console.ReadLine();
            if (entrada.ToLower() != "fin" && !palabras.Contains(entrada))
                palabras.Add(entrada);
        } while (entrada.ToLower() != "fin");

        palabras.Sort();
        Console.WriteLine("Lista final sin repetidos: " + string.Join(", ", palabras));
    }
}

