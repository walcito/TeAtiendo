using System;
using System.Collections.Generic;
using TeAtiendo.Domain.Base;

namespace TeAtiendo.Domain.Entities
{
    public class Menu : AuditEntity
    {
        public int IdMenu { get; set; } // PK

        public int IdRestaurante { get; set; } // FK
        public string Nombre { get; set; } = string.Empty;
        public string Estado { get; set; } = "Activo";
        public DateTime FechaActualizacion { get; set; }

        // Navegación
        public Restaurante Restaurante { get; set; } = null!;
        public ICollection<CategoriaPlato> Categorias { get; set; } = new List<CategoriaPlato>();
    }
}
