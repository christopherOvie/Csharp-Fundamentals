public class Program
{

    public static void Main(string[] args)
    {

int i =1;

        do
        {

            Console.WriteLine(i);
            i++;
        }
        while (i <= 100);
        //2  print numbers from 1 t0 100 divisible by 4
        for (int j = 1; j < 101; j++)
        {
            Console.WriteLine(j);
        }
        Console.WriteLine("above is do while loop from 1 to 100");


        for(int d = 1; d < 100; d++)
        {
            if(d % 4 == 0)
            {
                Console.WriteLine("it is correct");
            }
            else
            {
                Console.WriteLine("print wrong numbers");
            }
            
        }
        Console.WriteLine("eeeeeeeeeeeee");
        int m = 1;
        do
        {    
            if(m % 4 == 0) {
                Console.WriteLine(m);
            }
       
            m++;
        }
        while (m < 101);
        //Console.WriteLine("ffffffffff");
        for (int counter = 1; counter <= 100; counter++)
        {
            if (counter % 4 == 0)
            {
          Console.WriteLine(counter +  " " + "is found in for loop");
            }
            else
            {
                Console.WriteLine(counter + " " + "is not found in for loop");
            }
        }
        
        for (int p = 1; p < 100; p++)
        {
            if (p % 4 == 0)
            {
                Console.WriteLine(p + " " + "is found in for loop");
            }
            else
            {
                Console.WriteLine(p + " " + "is not found in for loop");
            }
       
       }
    }

}
   
    //3put assignment 2 into reusable method  can be divided by 7 oor 8

