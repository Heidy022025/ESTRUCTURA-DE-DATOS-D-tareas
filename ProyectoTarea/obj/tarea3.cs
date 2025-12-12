using System;

// Definición de la clase Estudiante
public class Estudiante
{
    public int ID { get; set; }                        // Identificador del estudiante
    public string? Nombres { get; set; }               // Nombres del estudiante (nullable)
    public string? Apellidos { get; set; }             // Apellidos del estudiante (nullable)
    public string? Direccion { get; set; }             // Dirección del estudiante (nullable)
    public string[] Telefonos = new string[3];         // Array para almacenar 3 números de teléfono
}

class Program
{
    static void Main()
    {
        Estudiante est = new Estudiante();

        Console.Write("Ingrese ID: ");
        string? entradaID = Console.ReadLine();
        est.ID = int.TryParse(entradaID, out int id) ? id : 0;

        Console.Write("Ingrese nombres: ");
        est.Nombres = Console.ReadLine() ?? "";

        Console.Write("Ingrese apellidos: ");
        est.Apellidos = Console.ReadLine() ?? "";

        Console.Write("Ingrese dirección: ");
        est.Direccion = Console.ReadLine() ?? "";

        // Ingreso de los 3 números de teléfono usando un array
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingrese teléfono {i + 1}: ");
            est.Telefonos[i] = Console.ReadLine() ?? "";
        }

        // Presentación de resultados
        Console.WriteLine("\n--- Datos Registrados ---");
        Console.WriteLine($"ID: {est.ID}");
        Console.WriteLine($"Nombre: {est.Nombres} {est.Apellidos}");
        Console.WriteLine($"Dirección: {est.Direccion}");
        Console.WriteLine("Teléfonos:");
        foreach (var tel in est.Telefonos)
        {
            Console.WriteLine($"- {tel}");
        }
    }
}
