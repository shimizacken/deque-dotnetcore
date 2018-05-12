using System;
using Queues;

namespace deque_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[] arrFront = {5, 4, 3, 2, 1};
            // int[] arrBack = {6, 7, 8, 9, 10};

            // // create new Deque using these arrays
            // Deque<int> d = new Deque<int>(arrBack, arrFront);

            // // iterate from first to last
            // Console.Write("The Deque contains  : ");
            // foreach(int i in d) Console.Write("{0} ", i); // 1 to 10
            // Console.WriteLine();

            // // iterate from last to first
            // Console.Write("Or in reverse order : ");
            // foreach(int i in d.Reversed) Console.Write("{0} ", i); // 10 to 1
            // Console.WriteLine();

            // // permanently reverse the order of the items
            // d.Reverse();

            // // iterate from first to last again
            // Console.Write("After permanent reversal : ");
            // foreach(int i in d) Console.Write("{0} ", i); // 10 to 1
            // Console.WriteLine();

            // // add items at front
            // Console.WriteLine("Added 11 and 12 at the front");
            // d.AddRangeFirst(new int[]{11, 12});

            // // add item at back
            // Console.WriteLine("Added 0 at the back");
            // d.AddLast(0);

            // Console.WriteLine("The first item is : {0}", d.PeekFirst()); // 12
            // int num;
            // if(d.TryPeekLast(out num))
            // {
            //     Console.WriteLine("The last item is : {0}", num); // 0 
            // }
        
            // // pop last item
            // Console.WriteLine("Popped last item");
            // num = d.PopLast();

            // // pop first item
            // Console.WriteLine("Popped first item");
            // d.TryPopFirst(out num);
        
            // if (d.Contains(11))
            // {
            //     // iterate again
            //     Console.Write("The Deque now contains : ");          
            //     foreach(int i in d) Console.Write("{0} ", i); // 11 to 1
            //     Console.WriteLine();
            // }

            // // peek at last item
            // Console.WriteLine("The last item is : {0}", d.PeekLast());  // 1 

            // // count items
            // Console.WriteLine("The number of items is : {0}", d.Count); // 11

            // // convert to an array
            // int[] ia = d.ToArray();

            // // reload to a new Deque adding all items at front so they'll now be reversed       
            // d = new Deque<int>(null, ia);
            // Console.Write("The new Deque contains : ");          
            // foreach(int i in d) Console.Write("{0} ", i); // 1 to 11

            // Console.WriteLine("\nThe capacity is : {0}", d.Capacity);
            // d.TrimExcess();
            // Console.WriteLine("After trimming the capacity is now : {0}", d.Capacity); 

            // // copy to an existing array
            // ia = new int[d.Count];
            // d.CopyTo(ia, 0);

            // // clear the Deque (No pun intended!)
            // d.Clear();
            // Console.WriteLine("After clearing the Deque is now empty : {0}", d.IsEmpty);
            // Console.WriteLine("The third element used to be : {0}", ia[2]);

            // Console.ReadKey();
        }
    }
}
