using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingspreePP
{
    internal class App
    {
        public void Run()
        {
            int discount = 30;

            var itemsInStock = new Stock();

            var shoppingCart = new ShoppingCart();

        }

        public List<InventoryItem> CreateItems()
        {
            List<InventoryItem> itemList =
            [
                new ClothingItem("T-skjorte", 5, 299, "large", "pink"),
                new ClothingItem("Hoodie", 16, 499, "small", "yellow"),
                new ElectronicItem("Acer laptop", 10, 9999, 240, "3 year warranty")
            ];

            return itemList;
        }

        public void BuyItem(InventoryItem item, int amount)
        {
            // shoppingCart.AddItem(item, amount)
            // itemsInStock.RemoveItem(item, amount)
        }
    }
}