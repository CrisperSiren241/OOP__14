using LAB__9;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Xml.Linq;

namespace L09
{
    class Program
    {
        static void Main()
        {
            /*Создание объектов класса*/
            Collection<string, string> perfoma1 = new Collection<string, string>("18:00", "Игра");
            Collection<string, string> perfoma2 = new Collection<string, string>("18:10", "Сценка");
            Collection<string, string> perfoma3 = new Collection<string, string>("18:20", "Песни");
            Collection<string, string> perfoma4 = new Collection<string, string>("18:40", "Танцы");
            Collection<string, string> perfoma5 = new Collection<string, string>("19:00", "Речь");
            foreach(var elements in Collection<string, string>.dic)//перебираем элементы в коллекции
            {
                Console.WriteLine($"Время: {elements.Key}  Номер: {elements.Value}");
                SecondCollection<string>.list.Enqueue(elements.Key);//добавляем элемент из одной коллекции в другую
            }
            Console.WriteLine();
            foreach(var element in SecondCollection<string>.list)//перебираем элементы уже из другой коллекции
            {
                Console.WriteLine($"Элемент другой коллекции: {element}");
            }
            ObservableCollection<Collection<string, string>> sub = new ObservableCollection<Collection<string, string>>() {//вызываем объект класс, которые будет отслеживать изменения в коллекции
                new Collection<string, string>("20:00", "Песня"),
                new Collection<string, string>("20:10", "Танцы"),
                new Collection<string, string>("20:15", "Прощание")
            };

            sub.CollectionChanged += Collection<string, string>.Changes;
            sub.Add(new Collection<string, string>("", ""));//Событие уведомит, что был создан новый элемент коллекции

            /*Рефлексия*/
            Type myType = typeof(SecondCollection<int>);
            Console.WriteLine();
            Console.WriteLine($"Тип объекта второй коллекции: {typeof(SecondCollection<int>)}");
            Console.WriteLine($"Имя: {myType.Name}");
            Console.WriteLine($"Полное имя: {myType.FullName}");
            Console.WriteLine($"Пространство имён: {myType.Namespace}");
            Console.WriteLine($"Имеет ли конструктор: {myType.GetConstructors().ToString}");
            Console.WriteLine($"Является ли структурой: {myType.IsValueType}");
            Console.WriteLine($"Является ли классом: {myType.IsClass}");
            Console.WriteLine($"Имя сборки: {myType.Assembly}");
            Console.WriteLine($"Реализованные интерфейсы: {myType.GetInterfaces().ToString}");
        }
    }
}