namespace CSharpBasics;

public class CSharpTypeCasting
{
    public static void PlayWithCastTypeManualAndAutomatic()
    {
        // int to char
        int myInt = 10;
        char myChar = (char) myInt;
        Console.WriteLine($"type casting int {myInt} to char produces {myChar}");
      
        // int to string
        string myString = Convert.ToString(myInt);
        Console.WriteLine($"type casting int {myInt} to string produces {myString}");
    }
}