namespace CSharpBasics;

public class CSharpArrays
{
    public static void Arrays()
    {
        // empty array
        string[] myArray = {};
        Console.WriteLine(myArray);
        
        // loop around
        string[] cars = {"tesla", "jeep", "maserati", "suzuki"};
        
        // loop using simple for 
        for(int i=0; i< cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
        
        // loop using foreach 
        foreach(string car in cars)
        {
            Console.WriteLine(car);
        }
        
        // sort the array
        Array.Sort(cars);
        Console.WriteLine(cars);
    }
}