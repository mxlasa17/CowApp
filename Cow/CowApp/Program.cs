namespace CowApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        List<Cow> cows = new List<Cow>
        {
            new Cow("Milka", "lila", 4),
            new Cow("Paula", "weiss", 6),
            new Cow("Conny", "schwarz", 4),
            new Cow("Berta", "weiss", 7),
            new Cow("Mathias", "rosa", 4),
            new Cow("Milka", "rosa", 4),
            new Cow("Milka", "lila", 5)
        };


        Console.WriteLine("Cows IComparable");
        cows.Sort();
        foreach (Cow VARIABLE in cows)
        {
            Console.WriteLine(VARIABLE.ToString());
        }

        Console.WriteLine("1 Comparator ColourName ");
        cows.Sort(new ColourAgeComparer());
        foreach (Cow cow in cows)
        {
            Console.WriteLine(cow.ToString());
        }

        Console.WriteLine("2 Comparator AgeName");
        cows.Sort(new AgeNameComparer());
        foreach (Cow cow in cows)
        {
            Console.WriteLine(cow.ToString());
        }
    }
}
