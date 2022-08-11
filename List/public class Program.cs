
public class Program
{
    public static void Main(string[] args)
    {
        List<string> names = new List<string>();
        names.Add("john");
        names.Remove("john");
        names.AddRange(new string[] { "mary" });
        names.Count();


        List<string> snames = new List<string>

        {
        "Andrew","john","peter"

        };
        foreach(string s in snames)
        {
            Console.WriteLine(s);
        }

        List<int> ints = new List<int>()
        {

            1, 2, 3, 4, 5, 6
        };

        foreach (var item in ints)
        {
            Console.WriteLine(item);
        }

    }



    public static void ArrayOutput(string[] names)
    {
        int counter = 0;
        foreach (var name in names)
        {
            Console.WriteLine($"Index {counter} has name {name}");
            counter++;
        }
    }
}