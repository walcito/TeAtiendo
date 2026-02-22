using System;

namespace TeAtiendo.Web.Models
{
    public class RestaurantVm
    {
        public int IdRestaurante { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;

        //  badges en tiempo real (UI)
        public bool Disponible { get; set; } = true;

        // txt opcional p (ej. ""Abierto"", ""Cerrado"", ""Pocas mesas"")
        public string EstadoVisual { get; set; } = "Abierto";
    }
}
