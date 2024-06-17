﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingspreePP
{
    internal class ShoppingCart
    {
        public List<InventoryItem> _items { get; set; }
        public void AddItem(InventoryItem item, int amount)
        {
            var cartItem = FindItem(item);
            cartItem.IncreaseStock(amount);
        }
        public void RemoveItem(InventoryItem item, int amount)
        {
            var cartItem = FindItem(item);
            cartItem.ReduceStock(amount);
        }

        private InventoryItem FindItem(InventoryItem item)
        {
            var newItem = _items.Find(x => x.GetId() == item.GetId());
            return newItem;
        }
    }
}