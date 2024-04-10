/// <summary>
/// Why extension methods? Extension methods enable you to "add" methods to existing types without creating a new derived type
/// The extension methods are static methods, but they're called as if they were instance methods on the extended type. 
/// 
/// When using an extension method to extend a type whose source code you aren't in control of, you run the risk that a change in the implementation of the type will cause your extension method to break.
/// 
/// 
/// </summary>asdfasdf
/// 
// New Comment my new change
public interface FooInterface
{
    string Name { get; set; }
    string GetName();
}

class FooA : FooInterface
{
    public string Name { get; set; }

    public FooA()
    {
        Name = "FooA";
    }

    public string GetName()
    {
        return Name;
    }
}
static class FooB
{
    public static string GetNameExtension(this FooInterface fooInterface)
    {
        return "FooB";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Extensions Project!");
    }

}