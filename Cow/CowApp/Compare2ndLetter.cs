namespace CowApp;

public class Compare2ndLetter : IComparer<Cow>
{
    public int Compare(Cow? x, Cow? y)
    {
        char secondX = ' ';
        char secondY = ' ';

        if (x.Name.Length > 1)
        {
            secondX = x.Name[1];
        }

        if (x.Name.Length > 1)
        {
            secondY = y.Name[1];
        }

        int result = secondX.CompareTo(secondY);

        if (result != 0)
        {
            return result;
        }

        return x.Name.CompareTo(y.Name);
    }
}