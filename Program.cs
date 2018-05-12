using System;
using Queues;

namespace deque_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            // initiate default
            Deque<int> d = new Deque<int>();
            
            // add single and range at front
            int[] arr = {1, 2, 3};

            d.Prepend(100);
            d.Prepend(arr);

            Console.Write("after prepend Deque contains:\n");

            foreach(int i in d) 
            {
                Console.WriteLine("{0}", i);
            }

            // add single and range at back
            Deque<int> d2 = new Deque<int>();
            
            int[] arr2 = {4, 5, 6};
            d2.Push(200);
            d2.Push(arr2);

            Console.Write("after push Deque contains:\n");

            foreach(int i in d2) 
            {
                Console.WriteLine("{0}", i);
            }

            d.PopFirst();
            d.PopLast();

            Console.Write("after pops Deque contains:\n");

            foreach(int i in d) 
            {
                Console.WriteLine("{0}", i);
            }


            int number = 5;
            var dSafe = new DequeSafe<int>();

            dSafe.Prepend(number);

            Console.Write("after prepend DequeSafe contains:\n");
            foreach(int i in dSafe) 
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
