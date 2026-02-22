using TeAtiendo.Domain.Base;

namespace TeAtiendo.Domain.Entities
{
    public class Plato : AuditEntity
    {
        public int IdPlato { get; set; } // PK

        public int IdCategoria { get; set; } // FK
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public decimal Precio { get; set; }
        public bool Disponible { get; set; }

        // Navegación
        public CategoriaPlato CategoriaPlato { get; set; } = null!;
    }
}
