using System.Data;

namespace sem2class1;

public class CycledQueue<T>
{
    public LinkedList<T> queue;
    private int[] takenPlaces;
    private int size;
    private int topElement;
    private int pointer;
    private int current;

    public CycledQueue(int size)
    {
        queue = new LinkedList<T>();
        takenPlaces = new int[size];
        pointer = -1;
        this.size = size;
        topElement = -1;
        current = -1;
    }

    public void Enqueue(T value)
    {
        if (topElement < size - 1)
        {
            pointer++;
            queue.AddLast(value);
            takenPlaces[pointer] = 1;
            topElement++;
            current++;
        }
        else
        {
            if (queue.Count >= size)
            {
                throw new ArgumentException("The queue is full");
            }
            else
            {
                current = current % topElement;
                queue.AddFirst(value);
                takenPlaces[current] = 1;
            }
        }
    }

    public T Dequeue()
    {
        int i = 0;
        while (takenPlaces[i] == 0)
        {
            i++;
        }

        takenPlaces[i] = 0;
        var temp = queue.First.Value;
        queue.RemoveFirst();
        return temp;
    }





}