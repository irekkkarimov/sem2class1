using sem2class1;

public class Program
{
    public static void Main()
    {
        int maxSize = int.Parse(Console.ReadLine());
        var test = new MyStack(10);
        
        // stack.IsEmpty() Test
        Console.WriteLine(test.IsEmpty());
        
        // stack.push() Test
        Random r = new Random();
        for (int i = 0; i < maxSize; i++)
        {
            test.Push(r.Next(-100, 101));
            Console.WriteLine($"top - {test.Count() - 1}");
        }

        // stack.Pop() test
        var temp = test.Count();
        for (int i = 0; i < temp; i++)
        {
            test.Pop();
            Console.WriteLine($"top - {test.Count() - 1}");
        }
        Console.WriteLine("stack length");
        Console.WriteLine(test.Count());
        
        // stack.Clear() test
        test.Push(10);
        test.Push(20);
        
        Console.WriteLine("stack length");
        Console.WriteLine(test.Count());
        test.Clear();
        Console.WriteLine("stack length");
        Console.WriteLine(test.Count());
        Console.WriteLine("arg exception \\/");
        test.Pop();


    }
}