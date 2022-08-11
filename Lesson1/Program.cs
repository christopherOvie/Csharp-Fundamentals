public class Program
{

public static void Main(string[] args)


    {
        
        //types of data
        //boolean true or false
        bool check = true;

        //printing to console
        Console.WriteLine(check);



        //Int
        // can only store -2147483648 to 2147483647
        //used to store numbers
        int number = 2;
        number = 3;


        Console.WriteLine("=======================================================");
        Console.WriteLine("Integer/Int/Numbers");
        Console.WriteLine(number);
        //minimum value
        Console.WriteLine(int.MaxValue);
        //maximum value
        Console.WriteLine(int.MinValue);
        Console.WriteLine("=======================================================");





        //Long
        //used to store numbers
        // can only store --9223372036854775808 to 9223372036854775807
        long longNumber = -2147483649L;
        Console.WriteLine("=======================================================");
        Console.WriteLine("Long/Numbers");
        Console.WriteLine(longNumber);
        Console.WriteLine(long.MaxValue);
        //minimum value
        Console.WriteLine(long.MinValue);
        //maximum value
        Console.WriteLine();
        Console.WriteLine("=======================================================");




        //Short
        //used to store numbers
        // can only store -32768 to 32767
        short shortNumber = 30000;
        Console.WriteLine("=======================================================");
        Console.WriteLine("Short/Numbers");
        Console.WriteLine(shortNumber);

        Console.WriteLine(short.MaxValue);
        //maximum value
        Console.WriteLine(short.MinValue);
        Console.WriteLine("=======================================================");







        //Byte
        //used to store numbers
        // can only store -128 to 127
        byte byteNumber = 127;
        Console.WriteLine("=======================================================");
        Console.WriteLine("Byte/Numbers");
        Console.WriteLine(byteNumber);
        //minimum value
        Console.WriteLine(byte.MaxValue);
        //maximum value

        Console.WriteLine(byte.MinValue);
        Console.WriteLine("=======================================================");







        //Double
        //used to store numbers
        // can only store huge decimals
        double doubleNumber = 1.7976931348623157;
        Console.WriteLine("=======================================================");
        Console.WriteLine("Double/Decimal Numbers");
        Console.WriteLine(doubleNumber);
        //minimum value
        Console.WriteLine(double.MaxValue);
        Console.WriteLine(double.MinValue);
        Console.WriteLine("=======================================================");






        //Float
        //used to store numbers
        // can only store huge decimals
        float floatNumber = 3.4028235F;
        Console.WriteLine("=======================================================");
        Console.WriteLine("Float/Decimal Numbers");
        Console.WriteLine(floatNumber);
        //minimum value
        Console.WriteLine(float.MaxValue);
        //maximum value
        Console.WriteLine(float.MinValue);
        Console.WriteLine("=======================================================");



        //char
        //used to store characters
        // can only store characters - examples A, B,a, &, )
        char character = 'A';
        Console.WriteLine("=======================================================");
        Console.WriteLine("Char/Characters");
        Console.WriteLine(character);
        Console.WriteLine("=======================================================");



        //string
        //used to store text
        // can only store text -examples - Home, Car, I am going to work
        String stringtext = "jsjsjjfsjfs";
        Console.WriteLine("=======================================================");
        Console.WriteLine("String/words");
        Console.WriteLine(stringtext);
        Console.WriteLine("=======================================================");

        //var takes the datatype of its value

        

        var varname = 'A';
     //   Console.WriteLine(10 + varname);
        Console.WriteLine(varname.GetType().Name);

        Console.WriteLine(stringtext.GetType().Name);
    }



}
