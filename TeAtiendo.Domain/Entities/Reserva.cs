using System;
using TeAtiendo.Domain.Base;
using TeAtiendo.Domain.Enums;

namespace TeAtiendo.Domain.Entities
{
    public class Reserva : AuditEntity
    {
        public int IdReserva { get; set; } // PK

        public int IdUsuario { get; set; } // FK
        public int IdRestaurante { get; set; } // FK
        public int IdMesa { get; set; } // FK
        public int IdDisponibilidad { get; set; } // FK

        public DateTime Fecha { get; set; }
        public TimeOnly Hora { get; set; }
        public int CantidadPersonas { get; set; }

        public EstadoReserva Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        // Navegación
        public Usuario Usuario { get; set; } = null!;
        public Restaurante Restaurante { get; set; } = null!;
        public Mesa Mesa { get; set; } = null!;
        public Disponibilidad Disponibilidad { get; set; } = null!;
    }
}
