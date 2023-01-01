using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09
{
    public class Collection<K, V> : Dictionary<K, V>, IDictionary<K, V>//Создаем обобщенный класс с заданной коллекцией и интерфейсом
    {
        public K? key; //Для коллекции "словарь" должны быть объявлены две важные переменные "ключ" и "значение"
        public V? value;
        public static Dictionary<K, V> dic = new Dictionary<K, V>();//Статическая коллекция, которая будет хранить объекты класса Collection

        public Collection(K? key, V? value)//Конструктор Класса, первые два поля инициализируют ключ и значение. Третье добавляет созданный объект в коллекцию
        {
            this.key = key;
            this.value = value;
            dic.Add(key, value);
        }

        public void Remove(K? key)
        {
            dic.Remove(key);    
        }

        public bool Contains(K? key)
        {
            if (dic.ContainsKey(key))
            {
                Console.WriteLine(dic[key]);
                return true;
            }
            else
            {
                Console.WriteLine("Ключ не найден");
                return false;
            }
        }

        public static void Changes(object sender, NotifyCollectionChangedEventArgs e)//создаем статический метод и регистрируем с помощью переменной е на обработчик событий NotifyCollectionChangedEventArgs
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Collection<K, V> new_perfoma = e.NewItems[0] as Collection<K, V>;
                    Console.WriteLine("Добавлен новый номер");//Если был добавлен элемент, то событие уведомит об этом
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Collection<K, V> old_perfoma = e.NewItems[1] as Collection<K, V>;
                    Console.WriteLine("Номер исключен");//Точно так же и с удалением
                    break;
                case NotifyCollectionChangedAction.Move:
                    Collection<K, V> moved_perfoma = e.NewItems[2] as Collection<K, V>;
                    Console.WriteLine("Номер перенесен");//Точно также и с перенесением
                    break;
            }
        }
    }
}
