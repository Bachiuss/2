using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondChoice
{
    public class Fruit : Item
    {
        private double _weightInKg;
        private double _priceOfOneKg;

        public Fruit(double WeightInKg, double PriceOfOneKg)
        {
            _weightInKg = WeightInKg;
            _priceOfOneKg = PriceOfOneKg;
        }

        public double CalculateTotalPrice()
        {
            price = _priceOfOneKg * _weightInKg;
            return price;
        }
    }
}
