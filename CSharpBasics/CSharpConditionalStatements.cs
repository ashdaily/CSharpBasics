namespace CSharpBasics;

public class CSharpConditionalStatements
{
    public static void ConditionalStatements()
    {
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());

        switch (age)
        {
            case 18:
                Console.WriteLine("You are a teen");
                break;
            case 19:
                Console.WriteLine("You are an adult");
                break;
            default:
                Console.WriteLine("Invalid age, check again");
                break;
        }
    }
}