public class Program
{

    //public static int number = 0;
  /*  public static void Main(string[] args)
    {
       
        string firstname = "Andrew";
        string surname = "Jackson";
        Console.WriteLine($"My name is {firstname} {surname}");


        PrintName();
        PrintName("Paula");
        PrintName("Andrew");
        PrintName("Chris");
        PrintName("Andrew", "Jackson");
        PrintName("Paula", "Jackson");

    }*/


    //public is a access modifier
    //static means there is only one copy (optional)
    //void this method doesn't return anything
    //Method name
    //Method overloading - (polymorphism) - Object Oriented concepts
    public static void PrintName()
    {
        Console.WriteLine("Andrew");
    }

   //create a void mehod Add   taking two parameters of type int num1 and num2 ansd
   //add and output to console.



    public static void Add(int numI, int num2)
    {
        Console.WriteLine(numI + num2);

    }

    //public is a access modifier
    //static means there is only one copy (optional)
    //void this method doesn't return anything
    //Method name
    //parameter
    public static void PrintName(string name)
    {
        Console.WriteLine(name);
    }

    public static void PrintName(string firstname,string surname)
    {
        Console.WriteLine($"My name is {firstname} {surname}");

    }

}