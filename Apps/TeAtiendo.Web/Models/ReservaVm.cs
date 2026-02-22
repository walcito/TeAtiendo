using System;

namespace TeAtiendo.Web.Models
{
    public class ReservaVm
    {
        public int IdReserva { get; set; }
        public int IdRestaurante { get; set; }
        public int IdMesa { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Today;
        public string Hora { get; set; } = "19:00";
        public int CantidadPersonas { get; set; } = 2;

        public string Estado { get; set; } = "Pendiente";
    }
}
