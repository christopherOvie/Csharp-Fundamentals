public class Program
{

    public static void Main(string[] args)
    {
        int numberOne = 20;
        int numberTwo = 30;
        //  var numberThree = Convert.ToDouble(numberOne/numberTwo);
        var numberFour = int.Parse(numberOne.ToString());
        var numberFive = int.Parse("14");
        //Console.WriteLine();
        // numberFour = int.Parse(numberOne.ToString());
        Console.WriteLine(numberOne + numberTwo);
        Console.WriteLine(numberOne - numberTwo);
        Console.WriteLine(numberOne * numberTwo);
        Console.WriteLine(numberOne / numberTwo);

        

        Console.WriteLine(double.Parse(numberOne.ToString()) / double.Parse(numberTwo.ToString()));
        Console.WriteLine(Convert.ToDouble(numberOne) / Convert.ToDouble(numberTwo));
        var check = double.TryParse(numberOne.ToString(), out double result);
        Console.WriteLine(check);
        Console.WriteLine(result);


        var checkA = double.TryParse("chris", out double resultA);
        Console.WriteLine(checkA);
        Console.WriteLine(resultA);



    }


}