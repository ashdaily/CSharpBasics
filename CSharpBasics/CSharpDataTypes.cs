namespace CSharpBasics;

public class CSharpDataTypes
{
    public static void PlayWithInt()
    {
        // int 
        int x = 0, y = 1, z = 2;
        Console.WriteLine($"Some ints for you {x} {y} {z}");
    }
    
    public static void PlayWithFloat()
    {
        // floating points
        float x = 1.99F;
        Console.WriteLine(x);
    }
    
    public static void PlayWithDecimal()
    {
        // floating points
        decimal x = 1.99M;
        Console.WriteLine($"the value of this decimal is {x}");
    }
    
    public static void PlayWithDouble()
    {
        // floating points
        double x = 1.99D;
        Console.WriteLine(x);
    }

    public static void PlayWithBool()
    {
        bool ashIsCool = true;
        bool ashLikesTruelayer = true;
    
        // try if/else with bool
        Console.WriteLine("Can we party ???");
        if (ashIsCool)
        {
            Console.WriteLine("We can party !!!!!");
        }
        else
        {
            Console.WriteLine("Don\'t care about Ash, let's party!!!");    
        }

        // ternary operator with bool 
        string answer = ashLikesTruelayer ? "yes" : "maybe";
        Console.WriteLine("Does Ash like Truelayer ??");
        Console.WriteLine(answer);
    }
}