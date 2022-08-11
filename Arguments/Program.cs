public class Program
{
    public static void Main(string[] args)
    {
        int age = 11;
if(age>0&& age < 5)
        {
            // else if
            Console.WriteLine("go to nursey");
        }
        else if(age<4 && age>15)

        {
            Console.WriteLine("go to primary");
        }
else if (age > 13 && age < 17)
        {
            Console.WriteLine("go to college");
        }
        else
        {
            Console.WriteLine("go to uni");
        }


        switch (age)
        {
            case var expression when (age >= 1 && age <= 4):
                Console.WriteLine("Go to nursery");
                break;
            case var expression when (age >= 5 && age <= 14):
                Console.WriteLine("Go to primary school");
                break;
            case var expression when (age > 14 && age < 19):
                Console.WriteLine("Go to college");
                break;
            case var expression when (age > 18 && age < 41):
                Console.WriteLine("Go to uni");
                break;
            default:
                Console.WriteLine($"Not a valid number {age}");
                break;
        }



    }
}



