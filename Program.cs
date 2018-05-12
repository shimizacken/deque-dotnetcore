using System;
using Queues;

namespace deque_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrFront = {1, 2, 3};
            int[] arrBack = {4, 5, 6};

            // // create new Deque using these arrays
            // Deque<int> d = new Deque<int>(arrBack, arrFront);

            Console.Write("Or in reverse order : ");

            // // add at front
            Deque<int> d = new Deque<int>();
            // int[] arr = {1, 2, 3};
            // d.Prepend(arr);
            // d.Prepend(100);

            // add at back
            // Deque<int> d2 = new Deque<int>();
            // d2.Push(arr);
            // d2.Push(100);

            d.Push(1);
            d.Push(2);
            d.Push(3);
            //d.PopFirst();
            d.PopLast();

            // iterate from first to last
            Console.Write("The Deque contains:\n");
            foreach(int i in d) 
            {
                Console.WriteLine("\n{0}", i);
            }
        }
    }
}
