namespace sem2class1;

public class CycledQueue<T>
{
    private LinkedList<T> queue;
    
    private int size;
    private int topElement;

    public CycledQueue(int size)
    {
        queue = new LinkedList<T>();
        this.size = size;
        topElement = -1;
    }

    public void Enqueue(T value)
    {
        if (topElement < size - 1)
        {
            queue.AddLast(value);
            topElement++;
        }
        else
        {
            
        }
    }





}