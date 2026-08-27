using System;

class Program
{
    static void Main()
    {
        // 1. Estadísticas
        int[] notas = new int[10];
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Nota {i+1}: ");
            notas[i] = int.Parse(Console.ReadLine());
        }
        double promedio = 0;
        int mayor = notas[0], menor = notas[0], encima = 0;
        foreach (int n in notas)
        {
            promedio += n;
            if (n > mayor) mayor = n;
            if (n < menor) menor = n;
        }
        promedio /= notas.Length;
        foreach (int n in notas) if (n > promedio) encima++;
        Console.WriteLine($"\nPromedio: {promedio:F2}, Mayor: {mayor}, Menor: {menor}, Encima del promedio: {encima}");

        // 2. Búsqueda lineal
        string[] nombres = { "Ana", "Luis", "Pedro", "Maria", "Jose", "Juan", "Rosa", "Carmen" };
        Console.Write("\nIngrese nombre a buscar: ");
        string buscado = Console.ReadLine();
        int pos = -1;
        for (int i = 0; i < nombres.Length; i++)
            if (nombres[i].Equals(buscado, StringComparison.OrdinalIgnoreCase)) { pos = i; break; }
        Console.WriteLine(pos >= 0 ? $"Encontrado en posición {pos}" : "No existe");

        // 3. Ordenamiento burbuja
        int[] arr = { 5, 2, 9, 1, 7 };
        Console.WriteLine("\nArreglo original: " + string.Join(", ", arr));
        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = 0; j < arr.Length - i - 1; j++)
                if (arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
        Console.WriteLine("Burbuja: " + string.Join(", ", arr));
        Array.Sort(arr);
        Console.WriteLine("Array.Sort: " + string.Join(", ", arr));

        // 4. Invertir
        int[] original = { 1, 2, 3, 4, 5 };
        int[] invertido = Invertir(original);
        Console.WriteLine("\nInvertido: " + string.Join(", ", invertido));

        // 5. Matriz 3x3
        int[,] matriz = new int[3,3];
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
        Console.WriteLine("\nMatriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(matriz[i,j] + "\t");
            Console.WriteLine();
        }
        int sumaDiagonal = matriz[0,0] + matriz[1,1] + matriz[2,2];
        Console.WriteLine($"Suma diagonal principal: {sumaDiagonal}");
    }

    static int[] Invertir(int[] arr)
    {
        int[] nuevo = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            nuevo[i] = arr[arr.Length - 1 - i];
        return nuevo;
    }
}

