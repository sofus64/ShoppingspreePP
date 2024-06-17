using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingspreePP
{
    internal class ShopStock
    {
        public List<InventoryItem> _items { get; set; }
        public void AddItem(InventoryItem item, int amount)
        {
            var stockItem = FindItem(item);
            stockItem.IncreaseStock(amount);
        }
        public void RemoveItem(InventoryItem item, int amount)
        {
            var stockItem = FindItem(item);
            stockItem.ReduceStock(amount);
        }

        private InventoryItem FindItem(InventoryItem item)
        {
            var newItem = _items.Find(x => x.GetId() == item.GetId());
            return newItem;
        }
    }
}
