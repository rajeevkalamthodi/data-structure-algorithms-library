using System;
using System.Collections.Generic;

namespace PriorityQuue
{
    public class PriorityQueue<T> where T : IComparable
    {
        private List<T> list;
        public int Count { get { return list.Count; } }
        public readonly bool IsDescending;

        public PriorityQueue()
        {
            list = new List<T>();
        }

        public PriorityQueue(bool isdesc) : this()
        {
            IsDescending = isdesc;
        }

        public PriorityQueue(int capacity) : this(capacity, false)
        { }

        public PriorityQueue(IEnumerable<T> collection) : this(collection, false)
        { }

        public PriorityQueue(int capacity, bool isdesc)
        {
            list = new List<T>(capacity);
            IsDescending = isdesc;
        }

        public PriorityQueue(IEnumerable<T> collection, bool isdesc) : this()
        {
            IsDescending = isdesc;
            foreach (var item in collection)
                Enqueue(item);
        }


        public void Enqueue(T item)
        {
            list.Add(item);
            int i = Count - 1;

            while (i > 0)
            {
                int parent = (i - 1) / 2;
                if ((IsDescending ? -1 : 1) * list[parent].CompareTo(item) <= 0) break;

                list[i] = list[parent];
                i = parent;
            }

            if (Count > 0) list[i] = item;
        }

        public T Dequeue()
        {
            T target = Peek();
            T root = list[Count - 1];
            list.RemoveAt(Count - 1);

            int i = 0;
            while (i * 2 + 1 < Count)
            {
                int leftChild = i * 2 + 1;
                int rightChild = i * 2 + 2;

                int c = rightChild < Count && (IsDescending ? -1 : 1) * list[rightChild].CompareTo(list[leftChild]) < 0 ? rightChild : leftChild;

                if ((IsDescending ? -1 : 1) * list[c].CompareTo(root) >= 0) break;
                list[i] = list[c];
                i = c;
            }

            if (Count > 0) list[i] = root;
            return target;
        }

        public T Peek()
        {
            if (Count == 0) throw new InvalidOperationException("Queue is empty.");
            return list[0];
        }

        public void Clear()
        {
            list.Clear();
        }

        public IEnumerable<T> DisplayQueue()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }
    }
}
