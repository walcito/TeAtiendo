using System.Collections.Generic;
using TeAtiendo.Domain.Base;

namespace TeAtiendo.Domain.Entities
{
    public class Mesa : AuditEntity
    {
        public int IdMesa { get; set; } // PK

        public int IdRestaurante { get; set; } // FK
        public int Numero { get; set; }
        public int Capacidad { get; set; }

        public string Estado { get; set; } = "Activa";

        // Navegación
        public Restaurante Restaurante { get; set; } = null!;
        public ICollection<Disponibilidad> Disponibilidades { get; set; } = new List<Disponibilidad>();
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}
