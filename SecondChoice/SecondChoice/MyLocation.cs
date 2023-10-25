using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondChoice
{
    public class MyLocation<T>
    {
        private List<T> _data;

        public MyLocation()
        {
            _data = new List<T>();  
        }

        public void AddItem(T addData)
        {
            _data.Add(addData);
        }

        public T GetIndex(int index)
        {
            return _data[index];
        }

    }
}
