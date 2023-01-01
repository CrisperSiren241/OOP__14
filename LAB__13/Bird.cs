using Laba4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    [Serializable]
    public class Bird : Mammal
    {
        [NonSerialized]
        public string info;
        public override void Show()
        {
            Console.WriteLine("А я птица"); // функция шоу
        }

        public override string? ToString()
        {
            Console.WriteLine($"Мой тип: {GetType().Name}\n"); // берем тип 
            return GetType().Name;
        }
    }
}
