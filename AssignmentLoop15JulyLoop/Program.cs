public class Program
{




    public static void Main(string[] args)
    {
        //GenericLoops3(6,8,8);
        //GenericLoops1(8, 96, 0);
        // GenericLoops3(4, 100, 20);
        //  GenericLoops2(17,7,0);
        // GenericLoops3(6,7,0);
        //additionMtd1(1, 25);
        //additionMtd3(4);
        // additionMtd4(1, 100);
        //additionMtd4();
         //addStrings(new string[] {"dAlpha","jBeta","michael"});
       // ArrayOutput(new string[] { "dAlpha", "jBeta", "michael"});

        Console.WriteLine("kkkkkkkk");
        var arrayValues = SplitArray("A,B", ',');
         addStrings(arrayValues);

        Console.WriteLine("jjjjjjjjjjjjj");
        var arrayValues1 = SplitArray("C,D", ',');
        ArrayOutput(arrayValues1);




        /* public void GenericMethodsForLoop2()
                {
                    Console.WriteLine("kkkkkkkk");
                    int bread = 1;

                    while (bread < 10)

                        if (bread % 4 == 0)
                        {
                            Console.WriteLine(bread);
                        }
                    bread++;
                }
               */
    }
        public static void GenericLoops1(int age, int range, int divisibleBy)
        {
            try
            {
                while (age < range)
                {
                    if (age % divisibleBy == 0)
                    {
                        Console.WriteLine(age);

                    }
                    age++;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("The exception is :" + e.Message);
            }



        }


        public static void GenericLoops2(int age, int range, int divisibleBy)
        {
            if (divisibleBy == 0)
            {
                Console.WriteLine("you cannot divide by zero");
            }
            else
            {
                while (age < range)
                {
                    if (age % divisibleBy == 0)
                    {
                        Console.WriteLine(age);

                    }
                    age++;
                }
            }
        }

        public static void GenericLoops3(int age, int range, int divisibleBy)
        {
            if (divisibleBy == 0)
            {
                Console.WriteLine("you cannot divide by zero");
                return;
            }
            while (age < range)
            {
                if (age % divisibleBy == 0)
                {
                    Console.WriteLine(age);

                }
                age++;
            }
        }

    public static void additionMtd1(int count,int range)
    {
       int total = 0;

        while (count < range)
        {
            
            //or total+=;
            
            total = total + count;
            count++;
        }
        Console.WriteLine(total);

    }

    public static void additionMtd2(int count, int range)
    {
        int total = 0;

        while (count < range)
        {

            //or total+=;

            total = total + count;
            count++;
        }
        Console.WriteLine(total);

    }


    public static void additionMtd3(int count)
    {
        int total = 0;

        while (count < 20)
        {

            //or total+=;

            total = total + count;
            count++;
        }
        Console.WriteLine(total);

    }

    public static void additionMtd4(int counter,int range)
    {
        int total = 0;

        for (int count = counter; count <= range;count++)
        {

            //or total+=;

           // total = total + count;
            total += count;
            
        }
        Console.WriteLine(total);

    }
    
    //create a method takes two parameter
    public static void addTwoStrings(string A,string B)
    {
        Console.WriteLine(A+B);
        Console.WriteLine(A.Concat(B));
    }


    public static void addStrings(string [] name)
    {
       // Console.WriteLine("Alpha","Beta","gamma");
        //Console.WriteLine(A.Concat(B));
        foreach(var names in name)
        {
            //Console.Write("the names are  "+names);
            Console.WriteLine(names);
        }
    }

    public static void ArrayOutput(string[] name)
    {

        int counter = 0;
        foreach (var names in name)
        {
            //combine normal text with variable for string interpolation
            // Console.Write($"index {counter} has name  "+names);
            Console.WriteLine(names);
            counter++;  
        }   
    }

    public static string [] SplitArray(string text, char seperator)
    {
        return text.Split(seperator);
    }

    //combine splitstrings and addstrings as one overall method
    public static void SplitStringsAndAddStrings(string text,char seperator)
    {
        //can call a method within a method

        var arrayValues = SplitArray(text, seperator);
        addStrings(arrayValues);

        //assignment combine split and array output
    }

    public static void SplitStringsAndArrayOutput(string text, char seperator)
    {
        var arrayValues1= SplitArray(text, seperator);
        ArrayOutput(arrayValues1);
    }
}
    

    


 

