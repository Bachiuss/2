using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondChoice
{
    public class Electronics : Item
    {
        private int _quantity;
        private double _oneUnitPrice;

        public Electronics(int Quantity, double OneUnitPrice)
        {
            _quantity = Quantity;
            _oneUnitPrice = OneUnitPrice; 
        }

        public double CalculateTotalPrice()
        {
            // მგონი მათემატიკა სწორად დავსვი ფორმულა ამერია აშკარად თუ არასწორია ლოგიკა ესე უნდა :დდდდ
            price = _oneUnitPrice * _quantity;
            return price;
        }
    }
}
