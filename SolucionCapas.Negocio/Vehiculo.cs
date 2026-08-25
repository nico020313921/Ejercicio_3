using System;
using SolucionCapas.Datos;

namespace SolucionCapas.Negocio
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public string Modelo { get; set; }
        public bool TieneDeuda { get; set; }
    }

    public class VehiculoNegocio
    {
        private VehiculoDatos _datos = new VehiculoDatos();

        public Vehiculo ObtenerVehiculo(string patente)
        {
            // Validamos que la patente tenga al menos 6 caracteres
            if (string.IsNullOrEmpty(patente) || patente.Length < 6)
                return null;

            // Pide los datos a la capa de Datos
            var resultado = _datos.BuscarPorPatente(patente);

            if (resultado == null)
                return null;

            // Transforma el dato recibido en un objeto Vehiculo
            return new Vehiculo
            {
                Patente = resultado.Value.Patente,
                Modelo = resultado.Value.Modelo,
                TieneDeuda = resultado.Value.TieneDeuda
            };
        }
    }
}