public class Program
{

    public static void Main(string[] args)
    {
        // Console.WriteLine("Enter a Number");
        //var number=  Console.ReadLine(); 
        // Console.WriteLine(number);


        //if (int.Parse(number) == 100)
        //{
        //   ; Console.WriteLine($"you have guess right number :{number}")
        //}

        //put in a loop continue till get to 100
        int number;
        List<int> numbers = new List<int>();
        do
        {
            Console.WriteLine("Enter a Number");
             var check = int.TryParse(Console.ReadLine(),out  number);
            if(check == false)
            {
                continue;
            }
            numbers.Add(number);    
        } while (number != 100);
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"you have guess right number :{number}");


        //create a list to store numbers
       



    }


}
