public class Program
{




    public static void Main(string[] args)
    {
      double g = DivideNumbers(16,9);
        Console.WriteLine(g);
    }

  


    public static double DivideNumbers(int numberOne,int numberTwo)
    {
       // var total = Convert.ToDouble(numberOne) / Convert.ToDouble(numberTwo);
        var total = double.Parse(numberOne.ToString()) / double.Parse(numberTwo.ToString());
        return total;   
    }






    }