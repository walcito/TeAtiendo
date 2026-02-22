using System;
using TeAtiendo.Domain.Base;

namespace TeAtiendo.Domain.Entities
{
    public class Auditoria : AuditEntity
    {
        public int IdLog { get; set; } // PK

        public int IdAdmin { get; set; } // FK -> Usuario (Admin)

        public DateTime Fecha { get; set; }
        public string Accion { get; set; } = string.Empty;
        public string Modulo { get; set; } = string.Empty;
        public string Detalle { get; set; } = string.Empty;
        public string Ip { get; set; } = string.Empty;

        // Navegación (Admin )
        public Usuario Admin { get; set; } = null!;
    }
}
