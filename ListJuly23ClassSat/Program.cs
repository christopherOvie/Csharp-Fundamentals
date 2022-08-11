public class Program
{
    public static void Main(string[] args)
    {

        //Arrays
        //created an array with one length
        string[] arrays = new string[1];
        string[] arrays1 = { "Paula" };
        //set the value to "Paula"
        arrays[0] = "Paula";

        //will throw index out of bounds error as array length is 1
        //arrays[1] = "Chris";

        //iterate
        foreach (string arr in arrays)
        {
            Console.WriteLine(arr);
        }
        foreach (string arr in arrays1)
        {
            Console.WriteLine(arr);
        }


        //Lists
        //created a new List of type string
        List<string> names = new List<string>()
            {
                "Paula",
               GetName("Andrew")
            };
        List<string> names2 = new List<string>();
        //added a name to the list
        names2.Add("Paula");
        names2.Add(GetName("Andrew"));




        //iterate through the list
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        foreach (var name in names2)
        {
            Console.WriteLine(name);
        }


        Console.WriteLine("chris task begins here");
        List<char> alphabets = new List<char>();
        alphabets.Add('A');
        alphabets.Add('B');
        alphabets.Add('C');
           
        PrintItems(alphabets);
        //foreach(char character in alphabets)
        //{
        //    Console.WriteLine(character);
        //}
        Console.WriteLine("before removal");
        alphabets.Remove('B');
        PrintItems(alphabets);

        Console.WriteLine("reversal");
        alphabets.Reverse();
        PrintItems(alphabets);

        Console.WriteLine("clear all");
        alphabets.Clear();
        PrintItems(alphabets);



    }

    public static void PrintItems(List<char> alphabets)
    {
        foreach (char character in alphabets)
        {
            Console.WriteLine(character);
        }
    }

    private static string GetName(string name)
    {
        return name;
    }
}