namespace sem2class1;

public static class Program
{
    public static void Main()
    {
    }

        
    public static void OrderedListTest()
    {
        var testingArray = new [] { 25, 150, 321, 5, 3, 234, 54, 234, 654, 76, 34, 7, 987, 564, 234, };
        var testingArrayForMerge = new [] { 4, 6, 8, 26, 988 };
        var test = new OrderedList<int>();
        var test2 = new OrderedList<int>();
        foreach (var number in testingArray)
        {
            test.Add(number);
        }

        foreach (var number in testingArrayForMerge)
        {
            test2.Add(number);
        }

        test.Print();
        Console.WriteLine("------------------");
       
        test.Merge(test2);
        test.Print();
       
    }

    public static void BracketSequenceTester()
    {
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
        test.BracketSequenceChecker("{([])<>}[]");
    }

    public static void NegativeAndPositiveTester()
    {
        Random r = new Random();
        int[] testingArray = new int[100];
        
        for (int i = 0; i < 100; i++)
        {
            testingArray[i] = r.Next(-100, 100);
        }
        
        NegativeAndPositive test2 = new NegativeAndPositive(testingArray);
        test2.Print();

        var test = new MyQueue<int>();
        
        test.Enqueue(1);
        Console.WriteLine(test.Dequeue());
        test.Dequeue();
    }

    public static void CycledQueueTester()
    {
        var test = new CycledQueue<int>(5);
        test.Dequeue();
        test.Enqueue(1);
        test.Enqueue(2);
        test.Enqueue(3);
        test.Enqueue(4);
        test.Enqueue(5);
        
        test.Dequeue();
        test.Enqueue(6);
        
        foreach (var i in test.queue)
        {
            Console.WriteLine(i);
        }
        
        test.Enqueue(7);
    }

    public static void MyStackTester()
    {
        var maxSize = int.Parse(Console.ReadLine());
        var test = new MyStack<int>(maxSize);
        
        // stack.IsEmpty() Test
        Console.WriteLine(test.IsEmpty());
        
        // stack.push() Test
        Random r = new Random();
        for (int i = 0; i < maxSize; i++)
        {
            test.Push(r.Next(-100, 101));
            Console.WriteLine($"top - {test.Count() - 1}");
            Console.WriteLine(test.GetMax());
        }
        
        // stack.Pop() test
        var temp = test.Count();
        for (int i = 0; i < temp; i++)
        {
            test.Pop();
            Console.WriteLine($"top - {test.Count() - 1}");
            Console.WriteLine(test.GetMax() );
        }
        Console.WriteLine("stack length");
        Console.WriteLine(test.Count());
        
        // stack.Clear() test
        test.Push(10);
        Console.WriteLine(test.GetMax());
        test.Push(20);
        Console.WriteLine(test.GetMax());
        
        Console.WriteLine("stack length");
        Console.WriteLine(test.Count());
        test.Clear();
        Console.WriteLine("stack length");
        Console.WriteLine(test.Count());
        Console.WriteLine("arg exception \\/");
        test.Pop();
    }
}
