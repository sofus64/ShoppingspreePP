using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingspreePP
{
    internal abstract class InventoryItem
    {
        private int _id;
        private string _name;
        private int _count;
        private int _price;

        public InventoryItem(int id, string name, int count, int price)
        {
            _id = id;
            _name = name;
            _count = count;
            _price = price;
        }

        public abstract void ShowInfo();

        public int GetId()
        {
            return _id;
        }
        public int GetPrice()
        {
            return _price;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetCount()
        {
            return _count;
        }

        public void SetCount(int amount)
        {
            _count = amount;
        }

        public void ReduceStock(int amount)
        {
            if (amount > _count)
            {
                throw new InvalidOperationException("Not enough stock available");
            }
            _count -= amount;
        }

        public void IncreaseStock(int amount)
        {
            _count += amount;
        }

        public decimal CalculatePrice(int discount)
        {
            var discountedPrice = GetPrice() * (1 - discount / 100m);
            return discountedPrice;
        }
    }
}
