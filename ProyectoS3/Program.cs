using System;

class Program
{
    static void Main()
    {
        // 1. Conversor de temperatura
        Console.Write("Ingrese grados Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        double kelvin = celsius + 273.15;
        Console.WriteLine($"Fahrenheit: {fahrenheit:F2}, Kelvin: {kelvin:F2}");

        // 2. Área y perímetro
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());
        double areaCirculo = Math.PI * Math.Pow(radio, 2);
        double perimetroCirculo = 2 * Math.PI * radio;
        Console.WriteLine($"Área círculo: {areaCirculo:F2}, Perímetro círculo: {perimetroCirculo:F2}");

        Console.Write("Ingrese el lado A del rectángulo: ");
        double ladoA = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el lado B del rectángulo: ");
        double ladoB = double.Parse(Console.ReadLine());
        double areaRect = ladoA * ladoB;
        double perimetroRect = 2 * (ladoA + ladoB);
        Console.WriteLine($"Área rectángulo: {areaRect:F2}, Perímetro rectángulo: {perimetroRect:F2}");

        // 3. Cambio de moneda
        Console.Write("Ingrese monto en pesos dominicanos: ");
        double pesos = double.Parse(Console.ReadLine());
        Console.Write("Ingrese tasa de cambio (1 USD en DOP): ");
        double tasaUSD = double.Parse(Console.ReadLine());
        double dolares = pesos / tasaUSD;
        double euros = dolares * 0.92; // ejemplo de tasa fija
        Console.WriteLine($"Equivalente: {dolares:F2} USD, {euros:F2} EUR");

        // 4. Saludo personalizado
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese su apellido: ");
        string apellido = Console.ReadLine();
        string completo = (nombre + " " + apellido).ToUpper();
        Console.WriteLine($"Nombre completo: {completo}");
        Console.WriteLine($"Cantidad de letras: {completo.Length}");
        Console.WriteLine($"Iniciales: {nombre.Substring(0,1)}{apellido.Substring(0,1)}");
    }
}
