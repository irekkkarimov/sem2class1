using System.Diagnostics;

namespace sem2class1;

public class OrderedList<T>
where T : IComparable
{
    private MyLinkedList<T> List;
    
    public OrderedList()
    {
        List = new MyLinkedList<T>();
    }

    public void Add(T value)
    {
        if (List.IsEmpty)
        {
            List.AddFirst(value);
            
        }
        else
        {
            Node<T> previous = null;
            var current = List.Head;
            while (true)
            {
                if (current == null)
                {
                    List.AddLast(value);
                    break;
                }
                if (current.Value.CompareTo(value) == 0) break;
                
                if (value.CompareTo(current.Value) < 0)
                {
                    if (previous == null) List.AddFirst(value);
                    else
                    {
                        List.AddAfter(previous, value);
                    }

                    break;
                }

                previous = current;
                current = current.Next;
            }
        }
    }

    public void Delete(T value)
    {
        Node<T> previous = null;
        foreach (var node in List)
        {
            if (value.CompareTo(node.Value) == 0)
            {
                if (previous == null) List.RemoveFirst();
                else
                {
                    List.RemoveAfter(previous);
                }

                break;
            }
        }
    }
    

    public void Merge(OrderedList<T> inputted)
    {
        var inPointer = List.Head;
        var outPointer = inputted.List.Head;

        Node<T> previous = null; // Current List's previous pointer

        while (outPointer != null)
        {
            if (inPointer == null && outPointer != null)
            {
                List.AddAfter(previous, outPointer.Value);
                outPointer = outPointer.Next;
                
            }
            else
            {
                if (outPointer.Value.CompareTo(inPointer.Value) < 0)
                {
                    if (previous == null)
                    {
                        List.AddFirst(outPointer.Value);
                    }
                    else
                    {
                        List.AddAfter(previous, outPointer.Value);
                    }
                    outPointer = outPointer.Next;
                }
                else
                {
                    previous = inPointer;
                    inPointer = inPointer.Next;
                }
            }
        }
    }
    
    
    

    public void Print()
    {
        foreach (var node in List)
        {
            Console.WriteLine(node.Value);
        }
    }
















    private static T[] BubbleSort(T[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (arr[j].CompareTo(arr[j + 1]) > 0)
            {
                // swap temp and arr[i]
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }

        return arr;
    }
}