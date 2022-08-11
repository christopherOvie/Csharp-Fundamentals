
public class Program
{
    public static  void DoCalculation()
    {
        Console.WriteLine("xxxxxxxxxxxDouble");
        Console.Write("what is number one :");
        var numberOne = Console.ReadLine();

        Console.Write("what is number two  :");
        var numberTwo = Console.ReadLine();
        Console.WriteLine("The addition is:  " + "  " + (double.Parse(numberOne) + double.Parse(numberTwo)));
        Console.WriteLine("The subtraction is:  " + "  " + (double.Parse(numberOne) - double.Parse(numberTwo)));
        Console.WriteLine("The multiplication is:  " + "  " + (double.Parse(numberOne) * double.Parse(numberTwo)));
        Console.WriteLine("The division is:  " + "  " + (double.Parse(numberOne) / double.Parse(numberTwo)));

        Console.WriteLine("xxxxxxxxxxxFloat");
        Console.Write("what is number three :");
        var numberThree = Console.ReadLine();

        Console.Write("what is number four  :");
        var numberFour = Console.ReadLine();

        Console.WriteLine("The addition is:  " + "  " + (float.Parse(numberThree) + float.Parse(numberFour)));
        Console.WriteLine("The subtraction is:  " + "  " + (float.Parse(numberThree) - float.Parse(numberFour)));
        Console.WriteLine("The multiplication is:  " + "  " + (float.Parse(numberThree) * float.Parse(numberFour)));
        Console.WriteLine("The division is:  " + "  " + (float.Parse(numberThree) / float.Parse(numberFour)));


        Console.WriteLine("xxxxxxxxxxxLongxxxx");

        Console.Write("what is number five :");
        var numberFive = Console.ReadLine();

        Console.Write("what is number Six  :");
        var numberSix = Console.ReadLine();

        Console.WriteLine("The addition is:  " + "  " + (long.Parse(numberFive) + long.Parse(numberSix)));
        Console.WriteLine("The subtraction is:  " + "  " + (long.Parse(numberFive) - long.Parse(numberSix)));
        Console.WriteLine("The multiplication is:  " + "  " + (long.Parse(numberFive) * long.Parse(numberSix)));
        Console.WriteLine("The division is:  " + "  " + (long.Parse(numberFive) / long.Parse(numberSix)));

        Console.WriteLine("xxxxxxxxxxxIntxxxx");

        Console.Write("what is number seven :");
        var numberSeven = Console.ReadLine();

        Console.Write("what is number Eight  :");
        var numberEight = Console.ReadLine();

        Console.WriteLine("The addition is:  " + "  " + (int.Parse(numberSeven) + int.Parse(numberEight)));
        Console.WriteLine("The subtraction is:  " + "  " + (int.Parse(numberSeven) - int.Parse(numberEight)));
        Console.WriteLine("The multiplication is:  " + "  " + (int.Parse(numberSeven) * int.Parse(numberEight)));
        Console.WriteLine("The division is:  " + "  " + (int.Parse(numberSeven) / int.Parse(numberEight)));

    }
    public static void Main(string[] args)
 {
        DoCalculation();


    }

}
