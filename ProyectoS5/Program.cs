using System;

class Program
{
    static void Main()
    {
        // Calculadora de viaje
        Console.Write("Distancia en km: ");
        double distancia = double.Parse(Console.ReadLine());

        Console.Write("Consumo del vehículo (km por galón): ");
        double consumo = double.Parse(Console.ReadLine());

        Console.Write("Precio del galón: ");
        double precioGalon = double.Parse(Console.ReadLine());

        Console.Write("Número de pasajeros: ");
        int pasajeros = int.Parse(Console.ReadLine());

        // Cálculos
        double galonesNecesarios = distancia / consumo;
        double costoTotal = galonesNecesarios * precioGalon;
        double costoPorPasajero = costoTotal / pasajeros;

        // Resultados
        Console.WriteLine("\n******** CALCULADORA DE VIAJE ********");
        Console.WriteLine($"Distancia: {distancia} km");
        Console.WriteLine($"Galones necesarios: {galonesNecesarios:F2}");
        Console.WriteLine($"Costo total: {costoTotal:C}");
        Console.WriteLine($"Cada pasajero paga: {costoPorPasajero:C}");
    }
}

