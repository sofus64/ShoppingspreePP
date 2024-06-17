namespace solo_test
{
    internal class App
    {
        private readonly ShopStock _stock = new();
        private readonly ShoppingCart _shoppingCart = new();
        public void Run()
        {
            CreateStock();
        }

        public void CreateStock()
        {
            List<InventoryItem> itemList =
            [
                new ClothingItem(0, "T-skjorte", 5, 299, "large", "pink"),
                new ClothingItem(1, "Hoodie", 16, 499, "small", "yellow"),
                new ElectronicItem(2, "Acer laptop", 10, 9999, 240, "3 year warranty")
            ];

            _stock._items = itemList;
        }

        public void AddToCart(InventoryItem item, int amount)
        {
            _stock.RemoveItem(item, amount);
            _shoppingCart.AddItem(item, amount);
        }

        public void RemoveFromCart(InventoryItem item, int amount)
        {
            _stock.AddItem(item, amount);
            _shoppingCart.RemoveItem(item, amount);
        }
    }
}