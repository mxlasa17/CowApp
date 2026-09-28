namespace CowApp;

public class ColourAgeComparer : IComparer<Cow>
{
    public int Compare(Cow? x, Cow? y)
    {
        int result = x.Colour.CompareTo(y.Colour);
        if (result != 0)
        {
            return result;
        }

        return x.Name.CompareTo(y.Name);
    }
}