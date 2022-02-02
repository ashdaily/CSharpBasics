namespace CSharpBasics;

public class CSharpUserInput
{
    public static void UserInput()
    {
        // collect some data
        Console.WriteLine("what is your username ?");
        string name = Console.ReadLine();
        Console.WriteLine($"Username is : {name}");
        
        Console.WriteLine("what is your age ?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Age is : {age}");
    }
}