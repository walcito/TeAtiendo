using System;
using System.Collections.Generic;
using System.Linq;
using TeAtiendo.Web.Models;

namespace TeAtiendo.Web.State
{
    public class CartState
    {
        private readonly List<CartItemVm> _items = new List<CartItemVm>();

        public IReadOnlyList<CartItemVm> Items => _items;

        public event Action? OnChange;

        public void AddItem(CartItemVm item)
        {
            var existing = _items.FirstOrDefault(x => x.IdPlato == item.IdPlato);
            if (existing != null)
            {
                existing.Cantidad += item.Cantidad;
            }
            else
            {
                _items.Add(item);
            }
            Notify();
        }

        public void RemoveItem(int idPlato)
        {
            var existing = _items.FirstOrDefault(x => x.IdPlato == idPlato);
            if (existing != null)
            {
                _items.Remove(existing);
                Notify();
            }
        }

        public void Clear()
        {
            _items.Clear();
            Notify();
        }

        public decimal Subtotal => _items.Sum(x => x.TotalLinea);

        //agregar impuestos/descuentos:
        public decimal Total => Subtotal;

        private void Notify() => OnChange?.Invoke();
    }
}
