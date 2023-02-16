using System.Collections;
using sem2class1;

public class Program
{
    public static void Main()
    {
        // #region
        // int maxSize = int.Parse(Console.ReadLine());
        // var test = new MyStack<int>(maxSize);
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
        // Console.WriteLine(test.GetMax());
        // }
        //
        // // stack.Pop() test
        // var temp = test.Count();
        // for (int i = 0; i < temp; i++)
        // {
        // test.Pop();
        // Console.WriteLine($"top - {test.Count() - 1}");
        // Console.WriteLine(test.GetMax() );
        // }
        // Console.WriteLine("stack length");
        // Console.WriteLine(test.Count());
        //
        // // stack.Clear() test
        // test.Push(10);
        // Console.WriteLine(test.GetMax());
        // test.Push(20);
        // Console.WriteLine(test.GetMax());
        //
        // Console.WriteLine("stack length");
        // Console.WriteLine(test.Count());
        // test.Clear();
        // Console.WriteLine("stack length");
        // Console.WriteLine(test.Count());
        // Console.WriteLine("arg exception \\/");
        // test.Pop();
        // #endregion MyStackTest

        #region LinkedListTest

        // var test = new LinkedList<int>();
        // test.AddLast(1);
        // test.AddLast(2);
        // test.AddLast(3);
        // Console.WriteLine(test.First.Value);
        // test.RemoveFirst();
        // Console.WriteLine(test.First.Value);

        #endregion

        // var test = new BracketsSequence();
        // test.BracketSequenceChecker("((()))");
        // Console.WriteLine("-----------------");
        // test.BracketSequenceChecker("()()");
        // Console.WriteLine("-----------------");
        // test.BracketSequenceChecker("");
        // Console.WriteLine("-----------------");
        // test.BracketSequenceChecker("(()");
        // Console.WriteLine("-----------------");
        // test.BracketSequenceChecker("text");
        // Console.WriteLine("-----------------");
        // test.BracketSequenceChecker("{([])<>}[]");

        // var test = new CycledQueue<int>(5);
        // test.Dequeue();
        // test.Enqueue(1);
        // test.Enqueue(2);
        // test.Enqueue(3);
        // test.Enqueue(4);
        // test.Enqueue(5);
        //
        // test.Dequeue();
        // test.Enqueue(6);
        //
        // foreach (var i in test.queue)
        // {
        //     Console.WriteLine(i);
        // }
        //
        // test.Enqueue(7);

        // Random r = new Random();
        // int[] testingArray = new int[100];
        //
        // for (int i = 0; i < 100; i++)
        // {
        //     testingArray[i] = r.Next(-100, 100);
        // }
        //
        // NegativeAndPositive test2 = new NegativeAndPositive(testingArray);
        // test2.Print();

        var test = new MyQueue<int>();

        test.Enqueue(1);
        Console.WriteLine(test.Dequeue());
        test.Dequeue();

    }
}