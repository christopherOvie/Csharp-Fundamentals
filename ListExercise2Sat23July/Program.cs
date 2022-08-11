public class Program
{
    public static void Main(string[] args)
    {
List<bool> list = new List<bool>();
        list.Add(true);
        list.Add(false);    

        foreach(bool item in list)
        {
            //list.Add(item);
            Console.WriteLine(item);
          
        }

       // Console.WriteLine(list.First && list.Last());

    }

    public class Man
    {
        String name;

  
    }

    public class Boy : Man{
    
        Man mo = new Man();
        
        
    
    }


}
