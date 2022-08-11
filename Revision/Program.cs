
public class Program
{



    public static void Main(string[] args)
    {



        string firstName = "chris";

        string surname = "brown";
        string space = " ";


        Console.WriteLine("my name is james brown");
        Console.WriteLine("my name is james brown");
        Console.WriteLine("my name is james brown");
        Console.WriteLine("my name is james brown");
        //string interpolation
        Console.WriteLine($"my name is {firstName} {surname}");
        //string concatenation
        Console.WriteLine("my name is " + firstName + space + surname);
        Console.WriteLine("my name is " + firstName + " " + surname);
        firstName = firstName + " ";
        Console.WriteLine("my name is " + firstName + surname);








    }


}