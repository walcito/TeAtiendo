using System;
using TeAtiendo.Domain.Base;
using TeAtiendo.Domain.Enums;

namespace TeAtiendo.Domain.Entities
{
    public class Disponibilidad : AuditEntity
    {
        public int IdDisponibilidad { get; set; } // PK

        public int IdMesa { get; set; } // FK
        public DateTime Fecha { get; set; }
        public TimeOnly Hora { get; set; }

        public EstadoDisponibilidad Estado { get; set; }

        // Navegación
        public Mesa Mesa { get; set; } = null!;
    }
}
