using System;
using System.Collections.Generic;

class Program
{
    // 1. Registro de estudiantes
    static void RegistroEstudiantes()
    {
        List<string> nombres = new List<string>();
        List<int> notas = new List<int>();
        int opcion;
        do
        {
            Console.WriteLine("\nMenú Estudiantes:");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Buscar por nombre");
            Console.WriteLine("3. Ver promedio del grupo");
            Console.WriteLine("4. Mostrar aprobados");
            Console.WriteLine("5. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre: ");
                    nombres.Add(Console.ReadLine());
                    Console.Write("Nota: ");
                    notas.Add(int.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.Write("Nombre a buscar: ");
                    string buscado = Console.ReadLine();
                    int idx = nombres.IndexOf(buscado);
                    Console.WriteLine(idx >= 0 ? $"Nota: {notas[idx]}" : "No encontrado");
                    break;
                case 3:
                    double promedio = 0;
                    foreach (int n in notas) promedio += n;
                    promedio /= notas.Count;
                    Console.WriteLine($"Promedio grupo: {promedio:F2}");
                    break;
                case 4:
                    Console.WriteLine("Aprobados (>=70):");
                    for (int i = 0; i < nombres.Count; i++)
                        if (notas[i] >= 70) Console.WriteLine($"{nombres[i]} - {notas[i]}");
                    break;
                case 5:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 5);
    }

    // 2. Juego del ahorcado
    static void Ahorcado()
    {
        string[] palabras = { "programacion", "csharp", "itla", "arreglo", "metodo" };
        Random rnd = new Random();
        string secreta = palabras[rnd.Next(palabras.Length)];
        char[] progreso = new string('_', secreta.Length).ToCharArray();
        int vidas = 6;

        while (vidas > 0 && new string(progreso) != secreta)
        {
            Console.WriteLine($"\nPalabra: {new string(progreso)}  Vidas: {vidas}");
            Console.Write("Letra: ");
            char letra = Console.ReadLine()[0];
            bool acierto = false;
            for (int i = 0; i < secreta.Length; i++)
                if (secreta[i] == letra) { progreso[i] = letra; acierto = true; }
            if (!acierto) vidas--;
        }
        Console.WriteLine(new string(progreso) == secreta ? "¡Ganaste!" : $"Perdiste. La palabra era {secreta}");
    }

    // 3. Analizador de texto
    static void AnalizadorTexto()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();
        string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int vocales = 0, consonantes = 0;
        string masLarga = "";
        foreach (string p in palabras)
        {
            if (p.Length > masLarga.Length) masLarga = p;
            foreach (char c in p.ToLower())
            {
                if ("aeiou".Contains(c)) vocales++;
                else if (char.IsLetter(c)) consonantes++;
            }
        }
        Console.WriteLine($"Palabras: {palabras.Length}, Vocales: {vocales}, Consonantes: {consonantes}, Más larga: {masLarga}");
    }

    static void Main()
    {
        Console.WriteLine("Ejercicios Integradores");
        Console.WriteLine("1. Registro de estudiantes");
        Console.WriteLine("2. Ahorcado");
        Console.WriteLine("3. Analizador de texto");
        Console.Write("Seleccione: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: RegistroEstudiantes(); break;
            case 2: Ahorcado(); break;
            case 3: AnalizadorTexto(); break;
            default: Console.WriteLine("Opción inválida."); break;
        }
    }
}
