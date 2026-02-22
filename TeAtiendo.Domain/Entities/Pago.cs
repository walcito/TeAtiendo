using System;
using TeAtiendo.Domain.Base;
using TeAtiendo.Domain.Enums;

namespace TeAtiendo.Domain.Entities
{
    public class Pago : AuditEntity
    {
        public int IdPago { get; set; } // PK

        public int IdOrden { get; set; } // FK
        public decimal Monto { get; set; }

        public string MetodoPago { get; set; } = "Stripe";

        public EstadoPago EstadoPago { get; set; }

        public DateTime FechaPago { get; set; }

        // E-R: referenciaExterna (stripe paymentIntent/charge id)
        public string? ReferenciaExterna { get; set; }

        // Navegación
        public Orden Orden { get; set; } = null!;
    }
}
