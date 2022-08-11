

public class Program
{

    public static void Main(string[] args)
    {
        // var yourName = "Andrew";
        // var jobName = "Tester";
        // var country = "UK";
       
        
       // Console.WriteLine($"My name is {yourName}");
       // Console.WriteLine($"My job is {jobName}");
       // Console.WriteLine($"I live in {country}");

        //What is your name?
       // What is your job ?
       // Where do you live?
      // string name= Console.ReadLine();
        Console.Write($"What is your name  :");
        var name = Console.ReadLine();
        //name = null;
        Console.WriteLine($"My name is {name}");
        Console.WriteLine($"The number of characters of my name is {name.Length}");

        Console.Write($"What is your job :");
        var job = Console.ReadLine();
        Console.WriteLine($"My job is {job.ToLower()}");


        Console.Write($"Where do you live :");
        var liveIn = Console.ReadLine();
        Console.WriteLine($"I live in {liveIn}");

      //  Console.WriteLine("The number of characters of my name is :");

    }

}
