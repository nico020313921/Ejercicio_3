using System;
using SolucionCapas.Negocio;

public class Program
{
    public static void Main()
    {
        Console.Write("Ingrese patente: ");
        string patente = Console.ReadLine();

        VehiculoNegocio negocio = new VehiculoNegocio();

        // La Presentación recibe el Vehiculo directamente desde Negocio
        Vehiculo vehiculo = negocio.ObtenerVehiculo(patente);

        if (vehiculo != null)
        {
            Console.WriteLine($"Modelo: {vehiculo.Modelo}");

            if (vehiculo.TieneDeuda)
                Console.WriteLine("Tiene deudas pendientes.");
            else
                Console.WriteLine("No tiene deudas pendientes.");
        }
        else
        {
            Console.WriteLine("Vehículo no encontrado o patente inválida.");
        }
    }
}