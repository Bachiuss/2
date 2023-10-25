using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondChoice
{
    public class ForLoop
    {
        int quantity = 7;
        string ItemName = "Widget";

        public void Loop()
        {
            for (int i = 1; i <= 5; ++i)
            {
                Console.WriteLine(ItemName + " the index is " + i);
            }
        }
    }
}
