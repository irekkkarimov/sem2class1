namespace sem2class1;

public class BracketsSequence
{
    private MyStack<char> stack;
    private List<Tuple<int, int>> indexes;
    private int index = -1;
    private int current = -1;
    private bool _ifSequenceCorrect = true;

    public bool IfSequenceCorrect
    {
        get => _ifSequenceCorrect;
        set => _ifSequenceCorrect = value;
    }
    
    public void PrintIndexes()
    {
        if (_ifSequenceCorrect)
        {
            foreach (var i in indexes)
            {
                Console.WriteLine($"{i.Item1} : {i.Item2}");
            }
        }
        else
        {
            Console.WriteLine("Неправильная скобочная запись");
        }

        stack.Clear();
        indexes.Clear();
        index = -1; current = -1;
        _ifSequenceCorrect = true;

    }

    public void BracketSequenceChecker(string sequence)
    {
        stack = new MyStack<char>(sequence.Length);
        indexes = new List<Tuple<int, int>>(sequence.Length / 2);
        foreach (var i in sequence)
        {
            if (i == '(')
            {
                stack.Push(i);
                index++;
                current++;
            }
            else
            {
                current++;
                if (i == ')' && stack.Count() > 0 && stack.Pop() == '(')
                {
                    indexes.Add(new Tuple<int, int>(index, current));
                    index--;
                }
                else
                {
                    _ifSequenceCorrect = false;
                    break;
                }
            }
        }
        if (stack.Count() == 0 && indexes.Any())
            PrintIndexes();
        else
        {
            _ifSequenceCorrect = false;
            PrintIndexes();
        }
    }
}