using System;
using TeAtiendo.Domain.Base;
using TeAtiendo.Domain.Enums;

namespace TeAtiendo.Domain.Entities
{
    public class Resena : AuditEntity
    {
        public int IdResena { get; set; } // PK

        public int IdUsuario { get; set; } // FK
        public int IdRestaurante { get; set; } // FK

        // E-R: idReserva OR idOrden (según regla)
        public int? IdReserva { get; set; }
        public int? IdOrden { get; set; }

        public int Calificacion { get; set; }
        public string Comentario { get; set; } = string.Empty;

        public DateTime Fecha { get; set; }

        public EstadoResena Estado { get; set; }

        // Navegación
        public Usuario Usuario { get; set; } = null!;
        public Restaurante Restaurante { get; set; } = null!;
        public Reserva? Reserva { get; set; }
        public Orden? Orden { get; set; }
    }
}
