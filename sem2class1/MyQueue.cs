using System.Collections;

namespace sem2class1;

public class QueueItem<T>
{
    private T _value;
    private QueueItem<T> _next;

    public QueueItem<T> Next
    {
        get => _next;
        set => _next = value;
    }

    public T Value
    {
        get => _value;
        set => _value = value;
    }

    public QueueItem(T value)
    {
        this.Value = value;
        Next = null;
    }
}

public class MyQueue<T> : IEnumerable<T>
{
    private QueueItem<T> head = null;
    private QueueItem<T> tail = null;

    public MyQueue()
    {
        
    }

    public void Enqueue(T value)
    {
        if (head == null)
        {
            head = new QueueItem<T>(value);
            tail = head;
        }
        else
        {
            tail.Next = new QueueItem<T>(value);
            tail = tail.Next;
        }
    }

    public T Dequeue()
    {
        T temp;
        if (head == null) throw new ArgumentException("The queue is empty");
        if (head.Next != null)
        {
            temp = head.Value;
            head = head.Next;
        }
        else
        {
            temp = head.Value;
            head = null;
            tail = head;
        }
        

        return temp;
    }

    public IEnumerator<T> GetEnumerator()
    {
        QueueItem<T> temp = head;
        while (temp != null)
        {
            yield return temp.Value;
            if (temp.Next != null)
            {
                temp = temp.Next;
            }
            else
            {
                yield break;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}