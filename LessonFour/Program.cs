public class Program
{


public static void Main(string [] args)
    {


        //boolean can be true or false;
        bool check = true;

        // operators 
        // && (AND), || (OR), ! (NOT), == equality, != Not equals , <= less or equals, >= greater or equals,% Modulus the remainder value of a division

        bool mon = true, tue = false, wed = true, thur = false;
        //All And's have to be true for it to be true
        Console.WriteLine(mon && tue && wed);


        //true OR false = true
        Console.WriteLine(mon || tue);
        //False OR false = false
        Console.WriteLine(thur || tue);

        //True OR true = true
        Console.WriteLine(mon || wed);

        mon = false;
        wed = false;
        thur = true;
        //True OR true = true
        Console.WriteLine(mon || tue || wed || thur);

        //Not reverses any value
        Console.WriteLine(!mon);



        mon = false;
        tue = true;
        wed = true;
        thur = false;
        bool fri = true;


        Console.WriteLine(!mon && wed);
        Console.WriteLine();



    }

    // public static void PrintName()
    // {
    //     Console.WriteLine("chris");
    // }
    public static string name = "chris";
}