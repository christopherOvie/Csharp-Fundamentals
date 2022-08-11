

public class Program
{
    public static void Main(string[] args)
    {
        //Arrays -  an array is a structure representing a fixed length ordered collection of values or objects with the same type
        string name = "andrew";
        string[] names = { "Andrew", "Chris", "Paula" };
        int[] numbers = { 1, 2, 3 };
        double[] values = { 12.5, 11.9, 23.90 };
        char[] chars = { 'A' };
        int[] noNumbers = new int[0];
        //noNumbers[0] = 9;
        name = "Fox";

        Console.WriteLine(name);
        //Giving an index means you can retrieve the value of the item you want based on position
        Console.WriteLine(names[2]);
        //length of array means the numbers of items in the array
        Console.WriteLine(names.Length);
        //Set or overwrite values
        //  names[2] = "Jackson";
        Console.WriteLine(names[2]);
        Console.WriteLine(noNumbers.Length);
        //Console.WriteLine(noNumbers[0]);

        Console.WriteLine(names.ElementAt(1));
        Console.WriteLine(names.First());
        Console.WriteLine(names.Last());
        Console.WriteLine("xxxxxxx");
        Console.WriteLine(noNumbers.FirstOrDefault());
        Console.WriteLine(noNumbers.LastOrDefault());

        string[] namesTpPost;

        Console.WriteLine(noNumbers.FirstOrDefault());
        Console.WriteLine(chars.First());
        Console.WriteLine(chars.Last());

        Console.WriteLine("yyyyyyyyyyyyReverse");
        names = names.Reverse().ToArray();
        Console.WriteLine(names[0]);

        names = names.Reverse().ToArray();
        Console.WriteLine(names[0]);

        Array.Clear(names);
        Console.WriteLine(names[0]);




    }


}
