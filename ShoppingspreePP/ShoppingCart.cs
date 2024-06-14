using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingspreePP
{
    internal class ShoppingCart
    {
        private List<InventoryItem> _items;
        public void AddItem(InventoryItem item, int amount)
        {
            item.SetCount(amount);
            _items.Add(item);
        }
        public void RemoveItem(InventoryItem item, int amount)
        {
            _items.Remove(item);
        }
    }
}