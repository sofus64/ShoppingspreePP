using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingspreePP
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
        private int _voltage;
        private string _insuranceInformation;

        public ElectronicItem(string name, int count, int price, int volt, string insuranceInfo) : base(name, count, price)
        {
            _voltage = volt;
            _insuranceInformation = insuranceInfo;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Produktnavn: " + GetName() +
                              "\nPris: " + GetPrice() +
                              "\nAntall på lager: " + GetCount() +
                              "\nVolt: " + _voltage +
                              "\nForsikringsinformasjon: " + _insuranceInformation);
        }
    }
}
