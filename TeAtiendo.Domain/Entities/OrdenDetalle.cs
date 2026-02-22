using TeAtiendo.Domain.Base;

namespace TeAtiendo.Domain.Entities
{
    public class OrdenDetalle : AuditEntity
    {
        public int IdDetalle { get; set; } // PK

        public int IdOrden { get; set; } // FK
        public int IdPlato { get; set; } // FK

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        // Navegación
        public Orden Orden { get; set; } = null!;
        public Plato Plato { get; set; } = null!;
    }
}
