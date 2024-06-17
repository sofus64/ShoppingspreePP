namespace solo_test
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        private string _size;
        private string _color;

        public ClothingItem(int id, string name, int count, int price, string size, string color) : base(id, name, count, price)  
        {
            _size = size;
            _color = color;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Produktnavn: {GetName()}" +
                              $"\nPris: {GetPrice()}" +
                              $"\nAntall på lager: {GetCount()}" +
                              $"\nStørrelse: {_size}" +
                              $"\nFarge: {_color}\n");
        }
    }
}