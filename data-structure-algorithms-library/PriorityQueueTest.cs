using System;
using PriorityQuue;

namespace data_structure_algorithms_library
{
    public class PriorityQueueTest
    {
        public void Test()
        {
            PriorityQueue<int> minPriorityQueue = new PriorityQueue<int>();
            minPriorityQueue.Enqueue(10);
            minPriorityQueue.Enqueue(20);
            minPriorityQueue.Enqueue(30);
            minPriorityQueue.Enqueue(15);
            minPriorityQueue.Enqueue(25);


            Console.WriteLine("Min Heap");
            foreach (var item in minPriorityQueue.DisplayQueue())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("DeQueue");
            minPriorityQueue.Dequeue();

            foreach (var item in minPriorityQueue.DisplayQueue())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("DeQueue");
            minPriorityQueue.Dequeue();

            foreach (var item in minPriorityQueue.DisplayQueue())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("DeQueue");
            minPriorityQueue.Dequeue();

            foreach (var item in minPriorityQueue.DisplayQueue())
            {
                Console.WriteLine(item);
            }




            PriorityQueue<int> maxPriorityQueue = new PriorityQueue<int>(true);
            maxPriorityQueue.Enqueue(10);
            maxPriorityQueue.Enqueue(20);
            maxPriorityQueue.Enqueue(30);
            maxPriorityQueue.Enqueue(15);
            maxPriorityQueue.Enqueue(25);
            Console.WriteLine("Max Heap");
            foreach (var item in maxPriorityQueue.DisplayQueue())
            {
                Console.WriteLine(item);
            }
        }
    }
}
