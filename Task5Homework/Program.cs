public class Program
{
 public static void Main(string[] args)
    {
        float numOne = 6.8F,  numTwo = 7.6F;
        AdditionMethod(numOne, numTwo);
        SubtractionMethod(numOne, numTwo);
        MultiplyMethod(numOne,numTwo);
        DivideMethod(numOne, numTwo);

    }






  public static void AdditionMethod(double numOne,float numTwo)
        
    {
        Console.WriteLine(numOne + numTwo);
    }

    public static void SubtractionMethod(double numOne, float numTwo)

    {
        Console.WriteLine(numOne - numTwo);
    }

    public static void MultiplyMethod(float numOne, float numTwo)

    {
        Console.WriteLine(numOne * numTwo);
    }

    public static void DivideMethod(float numOne, float numTwo)

    {
        Console.WriteLine(numOne / numTwo);
    }

}