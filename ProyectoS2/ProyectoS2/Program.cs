using System;

class Program
{
    static void Main()
    {
        // 1. Ficha de datos
        string nombre = "Onasies";
        int edad = 20;
        double estatura = 1.75;
        float peso = 70.5f;
        char inicialApellido = 'O';
        bool estudianteActivo = true;

        Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Estatura: {estatura}, Peso: {peso}, Inicial: {inicialApellido}, Activo: {estudianteActivo}");

        // 2. Operadores en acción
        int a = 10, b = 3;
        Console.WriteLine($"Suma: {a + b}, Resta: {a - b}, Multiplicación: {a * b}, División entera: {a / b}, División real: {(double)a / b}, Módulo: {a % b}");
        Console.WriteLine($"Mayor que: {a > b}, Igual: {a == b}, Diferente: {a != b}");
        Console.WriteLine($"AND lógico: {a > 5 && b < 5}, OR lógico: {a > 5 || b > 5}");

        // 3. Precedencia
        Console.WriteLine($"5 + 3 * 2 = {5 + 3 * 2}");
        Console.WriteLine($"(5 + 3) * 2 = {(5 + 3) * 2}");
        Console.WriteLine($"10 / 4 = {10 / 4}");       // división entera
        Console.WriteLine($"10 / 4.0 = {10 / 4.0}");   // división real
        Console.WriteLine($"10 % 4 = {10 % 4}");       // módulo
    }
}

