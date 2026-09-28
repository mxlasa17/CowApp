namespace CowApp;

class Program
{
    static void Main(string[] args)
    {
        


        /*Console.WriteLine("Cows IComparable");
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
        
        Console.WriteLine("3 Comparator Coolness");
        cows.Sort(new CoolnessComparer());
        foreach (Cow cow in cows)
        {
            Console.WriteLine(cow.ToString());
        } 
        
        Console.WriteLine("4 Comparator Secondletter");
        cows.Sort(new Compare2ndLetter());
        foreach (Cow cow in cows)
        {
            Console.WriteLine(cow.ToString());
        }*/

        List<Cow> cows = new List<Cow>();
        
        string FilePath = "file.txt";
        using (StreamReader streamReader = new StreamReader(FilePath))
        {
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] parts = line.Split(';');
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith('#') || line.StartsWith(';'))
                {
                    continue;
                }

                if (parts.Length != 3)
                {
                    continue;
                }
                string name = parts[0];
                string colour = parts[1];
                if (!int.TryParse(parts[2], out int age))
                {
                    continue;
                }
                
                cows.Add(new Cow(name, colour, age));

            }
        }
        
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
        
        Console.WriteLine("3 Comparator Coolness");
        cows.Sort(new CoolnessComparer());
        foreach (Cow cow in cows)
        {
            Console.WriteLine(cow.ToString());
        } 
        
        Console.WriteLine("4 Comparator Secondletter");
        cows.Sort(new Compare2ndLetter());
        foreach (Cow cow in cows)
        {
            Console.WriteLine(cow.ToString());
        }
    }
}
