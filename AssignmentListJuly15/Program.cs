public class Program
{




    public static void Main(string[] args)
    {
        List<string> names = new List<string>();//initialise it
        names.Add("john");
        names.Remove("john");
        names.AddRange(new string[] {"maryham"});
        names.Count();

        List<string> names2 = new List<string>() {
             "chris","john","michael"  //give it values straight away

        };

        foreach (string s in names2)
        {
            Console.WriteLine(s);
        }
        List<int> names3 = new List<int>()
        {
                 5,7,9,9,8
        };
        foreach (int s in names3)
        {
            Console.WriteLine(s);
        }
    }
    public static void ArrayOutput(string[] name)
    {

        int counter = 0;
        foreach (var names in name)
        {
            //combine normal text with variable for string interpolation
            // Console.Write($"index {counter} has name  "+names);
            Console.WriteLine(names);
            counter++;
        }
    }
}