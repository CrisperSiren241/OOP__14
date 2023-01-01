using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB__9
{
    public class SecondCollection<T>: Queue<T>, IEnumerable<T> 
    {
        T item;
        public static Queue<T> list = new Queue<T>();
        public SecondCollection(T item)
        {
            this.item = item;
        }
    }
}
