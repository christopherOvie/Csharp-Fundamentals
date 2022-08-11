public class Program
{
    public static void Main()

    {

        string name = "Paula";

        string nametoUpper = name.ToUpper();
        Console.WriteLine(nametoUpper);

        Console.WriteLine(name);
        string nametoLower = name.ToLower();
        Console.WriteLine(nametoLower);
        name = name.ToUpper();
        Console.WriteLine("firstname".ToUpper());

        //int paulaDoaJob = 0
        //if paula does a job
        //paulaDoaJob + 1 

        //string question = "Firstname:- ";
        //Console.Write(question.ToUpper());

       /* var firstname = Console.ReadLine();

         question = "Surname:- ";
         Console.Write(question.ToUpper());

        var surname = Console.ReadLine();
         Console.WriteLine("My name is " +firstname + " " +  surname);
  */
        var names = "Christopher";

        Console.WriteLine(names.StartsWith("Chris"));
        Console.WriteLine(names.EndsWith("pher"));

        bool  pass = false;
        Console.WriteLine(pass.Equals(false));



        int number = 22;
        Console.WriteLine(number + 8);



        //  Firstname:- Andrew
        //Surname:- Jackson
        //My name is Andrew Jackson






    }
}

