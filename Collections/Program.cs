using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("необобщенная коллекция ArrayList:");
            ArrayList alst = new ArrayList();
            alst.Add(10);
            alst.Add("11");
            alst.Add(12.5);
            foreach (var item in alst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Общее число элементов коллекции: {0}", alst.Count);


            Console.WriteLine("обобщенная коллекция List:");
            List<Int32> lst = new List<Int32>();
            lst.Add(10);
            lst.Add(11);
            lst.Add(12);

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }


            LinkedList<Int32> llst = new LinkedList<Int32>();

            llst.AddFirst(10);
            llst.AddFirst(11);
            llst.AddFirst(12);

            foreach (var item in llst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nОчередь");
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(3); // очередь 3
            numbers.Enqueue(5); // очередь 3, 5
            numbers.Enqueue(8); // очередь 3, 5, 8

            foreach (int el in numbers)
            {
                Console.WriteLine(el);
            }

            // получаем первый элемент очереди
            int queueElement = numbers.Dequeue(); //теперь очередь 5, 8
            Console.WriteLine("del: " + queueElement);
            Console.WriteLine("Сейчас в очереди {0} элементов", numbers.Count);

            foreach (int el in numbers)
            {
                Console.WriteLine(el);
            }

            // Извлекаем первый элемент в очереди - Tom
            int del = numbers.Dequeue(); // теперь в очереди Bill, John
            Console.WriteLine("del: " + del);
            foreach (int el in numbers)
            {
                Console.WriteLine(el);
            }


            Console.WriteLine("\nКоллекция:");
            Dictionary<int, string> countries = new Dictionary<int, string>(5);
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");
            countries.Add(1, "Ukraine");


            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            // получение элемента по ключу
            string country = countries[4];
            // изменение объекта
            countries[4] = "Spain";
            // удаление по ключу
            countries.Remove(2);

            Console.WriteLine();
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Console.WriteLine();
            Dictionary<string, string> countries2 = new Dictionary<string, string>
            {
                ["Франция"] = "Париж",
                ["Германия"] = "Берлин",
                ["Великобритания"] = "Лондон"
            };

            foreach (var pair in countries2)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
        }
    }
}
