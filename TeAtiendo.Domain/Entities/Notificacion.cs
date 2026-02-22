using System;
using TeAtiendo.Domain.Base;

namespace TeAtiendo.Domain.Entities
{
    public class Notificacion : AuditEntity
    {
        public int IdNotificacion { get; set; } // PK

        public int IdUsuario { get; set; } // FK

        public string Tipo { get; set; } = string.Empty;
        public string Mensaje { get; set; } = string.Empty;

        public DateTime FechaEnvio { get; set; }
        public bool Leida { get; set; }

        public string Canal { get; set; } = "email";

        // Navegación
        public Usuario Usuario { get; set; } = null!;
    }
}
