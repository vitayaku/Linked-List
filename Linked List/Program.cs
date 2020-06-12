using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);

            foreach(var item in circularList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            circularList.Delete(3);

            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            var duplexList = new DuplexLinkedList<int>();
            duplexList.Add(1);
            duplexList.Add(2);
            duplexList.Add(3);
            duplexList.Add(4);
            duplexList.Add(5);

            foreach(var item in duplexList)
            {
                Console.WriteLine(item);
            }
            duplexList.Delete(3);

            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            var reverse = duplexList.Reverse();
            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
