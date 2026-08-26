using System;

class Program
{
    static void Main()
    {
        // 1. Factura de colmado
        Console.Write("Nombre del cliente: ");
        string cliente = Console.ReadLine();

        Console.Write("Producto 1: ");
        string prod1 = Console.ReadLine();
        Console.Write("Precio 1: ");
        double precio1 = double.Parse(Console.ReadLine());
        Console.Write("Cantidad 1: ");
        int cant1 = int.Parse(Console.ReadLine());

        Console.Write("Producto 2: ");
        string prod2 = Console.ReadLine();
        Console.Write("Precio 2: ");
        double precio2 = double.Parse(Console.ReadLine());
        Console.Write("Cantidad 2: ");
        int cant2 = int.Parse(Console.ReadLine());

        Console.Write("Producto 3: ");
        string prod3 = Console.ReadLine();
        Console.Write("Precio 3: ");
        double precio3 = double.Parse(Console.ReadLine());
        Console.Write("Cantidad 3: ");
        int cant3 = int.Parse(Console.ReadLine());

        double subtotal = (precio1 * cant1) + (precio2 * cant2) + (precio3 * cant3);
        double itbis = subtotal * 0.18;
        double total = subtotal + itbis;

        Console.WriteLine("\n******** FACTURA ********");
        Console.WriteLine($"Cliente: {cliente}");
        Console.WriteLine($"{"Producto",-15} {"Precio",10} {"Cant.",5} {"Total",10}");
        Console.WriteLine($"{prod1,-15} {precio1,10:C} {cant1,5} {(precio1*cant1),10:C}");
        Console.WriteLine($"{prod2,-15} {precio2,10:C} {cant2,5} {(precio2*cant2),10:C}");
        Console.WriteLine($"{prod3,-15} {precio3,10:C} {cant3,5} {(precio3*cant3),10:C}");
        Console.WriteLine($"{"Subtotal:",-20}{subtotal,10:C}");
        Console.WriteLine($"{"ITBIS (18%):",-20}{itbis,10:C}");
        Console.WriteLine($"{"Total:",-20}{total,10:C}");

        // 2. Nómina simple
        Console.Write("\nHoras trabajadas: ");
        double horas = double.Parse(Console.ReadLine());
        Console.Write("Tarifa por hora: ");
        double tarifa = double.Parse(Console.ReadLine());

        double bruto = horas * tarifa;
        double afp = bruto * 0.0287;
        double sfs = bruto * 0.0304;
        double neto = bruto - afp - sfs;

        Console.WriteLine("\n******** NÓMINA ********");
        Console.WriteLine($"Salario bruto: {bruto:C}");
        Console.WriteLine($"Descuento AFP (2.87%): {afp:C}");
        Console.WriteLine($"Descuento SFS (3.04%): {sfs:C}");
        Console.WriteLine($"Salario neto: {neto:C}");

        // 3. Reloj
        Console.Write("\nIngrese segundos: ");
        int segundos = int.Parse(Console.ReadLine());

        int horasR = segundos / 3600;
        int minutosR = (segundos % 3600) / 60;
        int segR = segundos % 60;

        Console.WriteLine("\n******** RELOJ ********");
        Console.WriteLine($"{horasR}h : {minutosR}m : {segR}s");
    }
}

