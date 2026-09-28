namespace CowApp;

public class CoolnessComparer : IComparer<Cow>
{
    public int Compare(Cow? x, Cow? y)
    {
        if (x == null || y == null)
        {
            return 0;
        }

        int coolnessX = x.Age * x.Colour.Length;
        int coolnessY = y.Age * y.Colour.Length;

        int result = coolnessX.CompareTo(coolnessY);
        if (result != 0)
        {
            return result;
        }
        
        return x.Name.CompareTo(y.Name);
    }
}