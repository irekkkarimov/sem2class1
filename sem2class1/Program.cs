using System.Collections;
using sem2class1;

public class Program
{
    public static void Main()
    {
        #region
        // int maxSize = int.Parse(Console.ReadLine());
        // var test = new MyStack(10);
        //
        // // stack.IsEmpty() Test
        // Console.WriteLine(test.IsEmpty());
        //
        // // stack.push() Test
        // Random r = new Random();
        // for (int i = 0; i < maxSize; i++)
        // {
        // test.Push(r.Next(-100, 101));
        // Console.WriteLine($"top - {test.Count() - 1}");
        // }
        //
        // // stack.Pop() test
        // var temp = test.Count();
        // for (int i = 0; i < temp; i++)
        // {
        // test.Pop();
        // Console.WriteLine($"top - {test.Count() - 1}");
        // }
        // Console.WriteLine("stack length");
        // Console.WriteLine(test.Count());
        //
        // // stack.Clear() test
        // test.Push(10);
        // test.Push(20);
        //
        // Console.WriteLine("stack length");
        // Console.WriteLine(test.Count());
        // test.Clear();
        // Console.WriteLine("stack length");
        // Console.WriteLine(test.Count());
        // Console.WriteLine("arg exception \\/");
        // test.Pop();
        #endregion MyStackTest

        #region LinkedListTest
        // var test = new LinkedList<int>();
        // test.AddLast(1);
        // test.AddLast(2);
        // test.AddLast(3);
        // Console.WriteLine(test.First.Value);
        // test.RemoveFirst();
        // Console.WriteLine(test.First.Value);
        #endregion


        var test = new BracketsSequence();
        test.BracketSequenceChecker("((()))");
        Console.WriteLine("-----------------");
        test.BracketSequenceChecker("()()");
        Console.WriteLine("-----------------");
        test.BracketSequenceChecker("");
        Console.WriteLine("-----------------");
        test.BracketSequenceChecker("(()");
        Console.WriteLine("-----------------");
        test.BracketSequenceChecker("text");
        Console.WriteLine("-----------------");
        test.BracketSequenceChecker("{}()<>[]");



    }

    
    public class Fibonacci : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            var currentValue = 1;
            var previousValue = 1;
            yield return 1;
            yield return 1;
            while (true)
            {
                yield return currentValue + previousValue;
                (previousValue, currentValue) = (currentValue, currentValue + previousValue);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        IEnumerable<int> GetNumbers(int n){
            if (n < 0) throw new ArgumentException("n < 0");
            yield return 0;
            for(int i = 1; i < n; i++)
                if (i % 10000 == 0) break;
                else yield return i;
            yield break;
        }
    }
    
    
    public class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> Next { get; set; }
    }
    public class Queue<T> : IEnumerable<T>
    {
        Queue<T> queue;
        QueueItem<T> currentItem;
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            var test = 2..5;
            return GetEnumerator();
        }

        public QueueItem<T> Head { get; private set; }
        QueueItem<T> tail;

        public bool IsEmpty { get { return Head == null; } }

        public void Enqueue(T value)
        {
            if (IsEmpty)
                tail = Head = new QueueItem<T> { Value = value, Next = null };
            else
            {
                var item = new QueueItem<T> { Value = value, Next = null };
                tail.Next = item;
                tail = item;
            }
        }

        public T Dequeue()
        {
            if (Head == null) throw new InvalidOperationException();
            var result = Head.Value;
            Head = Head.Next;
            if (Head == null)
                tail = null;
            return result;
        }
    }
}