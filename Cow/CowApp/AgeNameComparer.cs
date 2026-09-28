namespace CowApp;

public class AgeNameComparer : IComparer<Cow>
{
    public int Compare(Cow? x, Cow? y)
    {
        int result = x.Age.CompareTo(y.Age);
        if (result != 0)
        {
            return result;
        }

        return x.Name.CompareTo(y.Name);
    }
}