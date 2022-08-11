public class Assignment5
{




    public static void Main(string[] args)
    {
        //int numOne = 40, numTwo = 30;
        //Console.WriteLine(Convert.ToDouble(numOne)/Convert.ToDouble(numTwo));
        //Add(numOne, numTwo);
        //Subtract(numOne, numTwo);
        //Multiply(numOne, numTwo);
        //Divide(numOne, numTwo);
        StandardCalculation();
    }
public static void StandardCalculation()
    {
        Console.WriteLine("double");
        Console.WriteLine("what is numner one");
      var numOne  =  Console.ReadLine();
     var checkOne=  double.TryParse(numOne, out double resultOne);
if(checkOne is false)
        {
            Console.WriteLine($"the number {numOne}is not valid");
            StandardCalculation();
            Console.Clear();
        }



        Console.WriteLine("what is numner Two");
        var numTwo = Console.ReadLine();
    var checkTwo=  double.TryParse(numTwo, out double resultTwo); 
        if(checkTwo is false)
        {
               
            Console.WriteLine($"the number {numTwo}is not valid");
            StandardCalculation();
            Console.Clear();
        }

        Console.WriteLine("The addition is " + " "+(double.Parse(numOne)+double.Parse(numTwo)));
       Console.WriteLine("The subtraction is " + " " + (double.Parse(numOne) - double.Parse(numTwo)));
        Console.WriteLine("The multiplication is " + " " + (double.Parse(numOne) * double.Parse(numTwo)));
        Console.WriteLine("The division is " + " " + (double.Parse(numOne) / double.Parse(numTwo)));
    }


    }