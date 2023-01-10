using System;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Soap;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Laba4
{
    interface IZoo /* interface 2 задание*/
    {
        public void Show(); // 4 tasl


    }

    // 6 задание в каждом классе
    abstract public class Mammal // абстрактный класс  это класс, в котором объявлен хотя бы один абстрактный элемент  4 tasl
    {
        public abstract void Show();

        public override string? ToString()
        {
            Console.WriteLine($"Мой тип: {GetType().Name} \n");
            return GetType().Name;
        }
    }
    
    
    public class Animal : Mammal
    {
        public override void Show() // Те методы и свойства, которые мы хотим сделать доступными для переопределения, в базовом классе
                                    // помечается модификатором virtual. Такие методы и свойства называют виртуальными.
        {
            Console.WriteLine("А я животное");
        }

        public override string? ToString()
        {
            Console.WriteLine($"Мой тип: {GetType().Name}\n");
            return GetType().Name;
        }
    }

    public class Fish : Mammal
    {
        public override void Show()
        {
            Console.WriteLine("А я рыба");
        }

        public override string? ToString()
        {
            Console.WriteLine($"Мой тип: {GetType().Name}\n");
            return GetType().Name;
        }
    }

    public class Lion : Animal
    {
        public virtual void Show()
        {
            Console.WriteLine($"Кол-во самцов: {population_m}, кол-во не самцов: {population_f}");
        }

        private int population_m = 0;
        public int Population_m
        {
            get { return population_m; }
            set { population_m = value; }
        }

        private int population_f = 0;
        public int Population_f
        {
            get { return population_f; }
            set { population_f = value; }
        }

        public override string? ToString()
        {
            Console.WriteLine($"Мой тип: {GetType().Name} \n");
            return GetType().Name;
        }
    }

    public class Owl : Bird
    {
        public void Show()
        {
            Console.WriteLine($"Кол-во сов: {angrybirds}");
        }

        private int angrybirds = 0;
        public int Angrybirds
        {
            get { return angrybirds; }
            set { angrybirds = value; }
        }

        public override string? ToString()
        {
            Console.WriteLine($"Мой тип: {GetType().Name} \n");
            return GetType().Name;
        }
    }

    public class Tiger : Animal
    {
        public void Show()
        {
            Console.WriteLine("А я тигр!");
        }

        public override string? ToString()
        {
            Console.WriteLine($"Мой тип: {GetType().Name} \n");
            return GetType().Name;
        }
    }

    public sealed class Shark : Fish // модификатор sealed запрещает другим классам наследовать от этого класса. 3 здаание
    {
        public void Show()
        {
            Console.WriteLine("А я акула!");
        }
        private double shark = 1;
        public override string? ToString()
        {
            Console.WriteLine($"Мой тип: {GetType().Name}");
            return GetType().Name;
        }
        public override bool Equals(object? obj)
        {

            if (obj is Shark) return true;          // is  5 task
            return false;
        }
        public override int GetHashCode() => shark.GetHashCode();
    }

    public class Parrot : Bird, IZoo
    {
        public override sealed void Show()
        {
            Console.WriteLine("Попугай");
        }

        public bool parrot
        {
            get { return parrot; }
            set { parrot = value; }
        }


        public override string? ToString()
        {
            Console.WriteLine($"Мой тип: {GetType().Name} \n");
            return GetType().Name;
        }
    }

    public class Crocodile : Animal, IZoo
    {
        public override void Show()
        {
            Console.WriteLine("Крокодил");
        }

        public bool crocodile
        {
            get { return crocodile; }
            set { crocodile = value; }
        }

        public override string? ToString()
        {
            Console.WriteLine($"Мой тип: {GetType().Name} \n");
            return GetType().Name;
        }
    }
    public class Printer // 7 zadanie
    {
        public void IAmPrinting(Mammal obj) // определяем тип и вызываем тустринг
        {
            Console.WriteLine(obj.ToString());

        }
    }


    internal class Program
    {


        static void Main(string[] args)
        {

            Printer printer = new Printer();
            Bird bird = new Bird();
            Animal animal = new Animal();
            Fish fish = new Fish();
            Lion lion = new Lion();
            Owl owl = new Owl();
            Tiger tiger = new Tiger();
            Shark shark = new Shark();
            Parrot parrot = new Parrot();
            Crocodile crocodile = new Crocodile();


            bool loop = false;
            while (loop = true)
            {
                Console.WriteLine("1. Bird  \n2. Animal  \n3. Fish \n4. Lion \n5. Owl \n6. Tiger \n7. Shark \n8. Parrot \n9. Crocodile \n10. Print \n11. Exit\n");
                int choice1 = int.Parse(Console.ReadLine());

                switch (choice1)
                {
                    case 1:

                        bird.Show();
                        bird.ToString();
                        break;

                    case 2:

                        animal.Show();      // вызыываем методы, которые прописывали в классах
                        animal.ToString();
                        break;

                    case 3:

                        fish.Show();
                        fish.ToString();
                        break;

                    case 4:

                        Console.WriteLine("Введите кол-во самцов");
                        int animalm = int.Parse(Console.ReadLine());
                        lion.Population_m = animalm;
                        Console.WriteLine("Введите кол-во самок");   // задаем значения
                        int animalf = int.Parse(Console.ReadLine());
                        lion.Population_f = animalf;
                        lion.Show();
                        lion.ToString();
                        break;

                    case 5:

                        Console.WriteLine("Введите кол-во сов");
                        int birds = int.Parse(Console.ReadLine());
                        owl.Angrybirds = birds;
                        owl.Show();
                        owl.ToString();
                        break;

                    case 6:

                        tiger.Show();
                        tiger.ToString();
                        break;

                    case 7:

                        shark.Show();
                        shark.ToString();
                        Console.WriteLine($"Является ли shark parrot?: {shark.Equals(parrot)}");
                        Console.WriteLine($"Hash Code: {shark.GetHashCode()}\n");
                        break;

                    case 8:

                        parrot.Show();
                        parrot.ToString();
                        break;

                    case 9:

                        crocodile.Show();
                        crocodile.ToString();
                        break;

                    case 10:
                        ((IZoo)parrot).Show();
                        printer.IAmPrinting(parrot);
                        printer.IAmPrinting(crocodile);
                        break;

                    case 11:

                        loop = false;
                        return;

                }
            }

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Dflint.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, bird);
                Console.WriteLine("Объект сериализован");
            }

            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                Bird newBird = (Bird)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
            }

            //------------------------------------------//

            string json = JsonSerializer.Serialize(bird);
            Console.WriteLine(json);
            Bird rBird = JsonSerializer.Deserialize<Bird>(json);
            Console.WriteLine(rBird.info);

            //---------------------------------------//

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bird));
            using (FileStream fs = new FileStream("flint.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, bird);

                Console.WriteLine("Object has been serialized");
            }

            using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            {
                Bird Bbird = xmlSerializer.Deserialize(fs) as Bird;
            }

            //------------------------------------------------------------//

            List<Bird> list = new List<Bird>();
            string newjson = JsonSerializer.Serialize(list);
            Console.WriteLine(newjson);

        }
        public static void SoapWriteFile(object objGraph, string fileName)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = new FileStream(fileName,
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormatter.Serialize(fStream, objGraph);
            }
        }

        static void Deserialize()
        {
            Hashtable addresses = null;
            FileStream fs = new FileStream("DataFile.soap", FileMode.Open);
            try
            {
                SoapFormatter formatter = new SoapFormatter();

                addresses = (Hashtable)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
            foreach (DictionaryEntry de in addresses)
            {
                Console.WriteLine("{0} lives at {1}.", de.Key, de.Value);
            }
        }

    }
}

