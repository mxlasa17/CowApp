namespace CowApp;

public class Cow : IEquatable<Cow>, IComparable<Cow>
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    public Cow(string name, string colour, int age)
    {
        Name = name;
        Colour = colour;
        Age = age;
    }


    public bool Equals(Cow? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name && Colour == other.Colour && Age == other.Age;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Cow)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Colour, Age);
    }

    public int CompareTo(Cow? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (other is null) return 1;
        var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;
        var colourComparison = string.Compare(Colour, other.Colour, StringComparison.Ordinal);
        if (colourComparison != 0) return colourComparison;
        return Age.CompareTo(other.Age);
    }
    
    
    public override string ToString()
    {
        return $"Name: {Name},Colour: {Colour},Age: {Age},Second Letter: {Name[1]},Coolness: {Age * Colour.Length}";
    }
}