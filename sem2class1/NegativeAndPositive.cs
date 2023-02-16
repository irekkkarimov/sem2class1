namespace sem2class1;

public class NegativeAndPositive
{
    private int[] input;
    private Queue<int> queue = new Queue<int>();

    public NegativeAndPositive(int[] input)
    {
        this.input = input;
    }

    public void Print()
    {
        foreach (var i in input)
        {
            if (i < 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                queue.Enqueue(i);
            }
            
        }
        
        foreach (var e in queue)
        {
            Console.WriteLine(e);
        }
    }
}