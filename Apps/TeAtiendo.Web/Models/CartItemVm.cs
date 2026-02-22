using System;

namespace TeAtiendo.Web.Models
{
    public class CartItemVm
    {
        public int IdPlato { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Cantidad { get; set; } = 1;
        public decimal PrecioUnitario { get; set; } = 0m;

        public decimal TotalLinea => Cantidad * PrecioUnitario;
    }
}
