using System.Collections.Generic;
using TeAtiendo.Domain.Base;

namespace TeAtiendo.Domain.Entities
{
    public class CategoriaPlato : AuditEntity
    {
        public int IdCategoria { get; set; } // PK

        public int IdMenu { get; set; } // FK
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        // Navegación
        public Menu Menu { get; set; } = null!;
        public ICollection<Plato> Platos { get; set; } = new List<Plato>();
    }
}
