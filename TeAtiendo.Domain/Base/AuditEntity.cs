using System;

namespace TeAtiendo.Domain.Base
{
    /// <summary>
    /// Auditoría definida en el SAD: Actor, Operación, Timestamp.
    /// </summary>
    public abstract class AuditEntity : BaseEntity
    {
        public string Actor { get; set; } = string.Empty;
        public string Operacion { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
