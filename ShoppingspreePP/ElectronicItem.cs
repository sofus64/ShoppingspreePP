namespace solo_test
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
        private int _voltage;
        private string _insuranceInformation;

        public ElectronicItem(int id, string name, int count, int price, int volt, string insuranceInfo) : base(id, name, count, price)
        {
            _voltage = volt;
            _insuranceInformation = insuranceInfo;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Produktnavn: " + GetName() +
                              $"\nPris: {GetPrice()}" +
                              $"\nAntall på lager: {GetCount()}" +
                              $"\nVolt: {_voltage} " +
                              $"\nForsikringsinformasjon: {_insuranceInformation}\n");
        }
    }
}
