public class Program
{
    public static void Main(string[] args)
    {
        int numberOne = 14;
        int numberTwo = 25;

        double addResult= numberOne+numberTwo;
       
        var check = double.TryParse(addResult.ToString(), out double result);
        Console.WriteLine(check);
        Console.WriteLine(result);


        int numberFive = 14;
        int numberSix = 25;

        double divResult = numberFive / numberSix;

        var checkDiv = double.TryParse(divResult.ToString(), out double resultDiv);
        Console.WriteLine(checkDiv);
        Console.WriteLine(resultDiv);

        //double numberFour;
        /* string numberFour = Console.ReadLine();

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
         Console.WriteLine(resultA)*/




        //Console.WriteLine(numberFour);

        //int numberFive = int.Parse(numberOne.ToString());



    }


}