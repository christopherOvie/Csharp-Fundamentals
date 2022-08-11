public class Program
{

    

    public static void Main(string[] args)
    {
        Addition2(1, 100);

        //int m = 1;
        //do
        //{
        //    if (m % 4 == 0)
        //    {
        //        Console.WriteLine(m);
        //    }

        //    m++;
        //} while (m < 101);

        //a += 1;
        //cout << a; // Here it will print 6.

        //a = +1;
        //cout << a; // Here it will print 1 (+1).

        //a = -1;
        //cout << a; // Here it will print -1.
        
//+= means it will increment the lValue by Right side value.

//= +means it will assign the right side value(with sign) to "lValue"

int a = 5;
        a += 1;
       // cout << a; // Here it will print 6.

        a = +1;
       // cout << a; // Here it will print 1 (+1).

        a = -1;
       // cout << a; // Here it will print -1.
       // cout << a; // Here it will print -1.





        int total = 0; 
        for(int count = 1; count <= 100; count++)
        {
           // total = count + total;
            //total += count;
            total = total + count;
         
            
        }
        Console.WriteLine(total);
        Console.WriteLine("xxxxxxxxxxxxxxx");
        AddStrings(new string[] { "A", "B" });
        AddStrings(new string[0]);
        Console.WriteLine();
        Console.WriteLine("zzzzzzzzzzzzzzzzz");
        var arrayValues = SplitString("A,B", ',');
        AddStrings(arrayValues);

    }

    public static void Addition(int count)
    {
        int total = 0;
        while(count <= 100)
        {
            
            total = total + count;
            count++;

        }
        Console.WriteLine(total);
    }

    public static void Addition2(int counter,int range)
    {
        int total = 0;
        for (int count= counter; count <= range;count++)
        {

            total = total + count;
            

        }
        Console.WriteLine(total);
    }
    public static void GenericLoop(int counter, int range, int divisibleBy)
    {
        try
        {
            while (counter < range)
            {
                if (counter % divisibleBy == 0)
                {
                    Console.WriteLine(counter);
                }

                counter++;
            }

        }
        catch (Exception e)
        {

            Console.WriteLine("The exeption is " + e.Message);
        }

        //    while (counter < range)
        //    {
        //        if (counter % divisibleBy == 0)
        //        {
        //            Console.WriteLine(counter);
        //        }

        //        counter++;
        //    }
        //

    }

    public static void GenericLoop2(int counter, int range, int divisibleBy)
    {
        if (divisibleBy == 0)
        {
            Console.WriteLine("you can´t divide by 0");
        }
        else

        {
            while (counter < range)
            {
                if (counter % divisibleBy == 0)
                {
                    Console.WriteLine(counter);
                }

                counter++;
            }
        }
        //while (counter < range)
        //{
        //    if (counter % divisibleBy == 0)
        //    {
        //        Console.WriteLine(counter);
        //    }

        //    counter++;
        //}


    }

    public static void GenericLoop3(int counter, int range, int divisibleBy)
    {
        if (divisibleBy == 0)
        {
            Console.WriteLine("you can´t divide by 0");
            return;

        }

        while (counter < range)
        {
            if (counter % divisibleBy == 0)
            {
                Console.WriteLine(counter);
            }

            counter++;
        }


    }

public static void AddTwoStrings(string A,string B)
    {
        Console.WriteLine(A + B);
        Console.WriteLine(A.Concat(B));

        

    }
    
    public static void AddStrings(string[] names)
    {
       foreach(var name in names)
        {
            Console.Write(name);
        }    
    }

    public static void ArrayOutput(string[] names)
    {
        int counter = 0;
        foreach (var name in names)
        {
            Console.WriteLine($"Index {counter} has name {name}");
            counter++;
        }
    }

    public static string [] SplitString(string text,char seperator)
    {
        return text.Split(seperator);
    }
public static void  SplitAndAddStrings(string text,char seperator)
    {
        var arrayValues = SplitString(text, seperator);
        AddStrings(arrayValues);
    }
    public static void SplitStringAndArrayOutput(string text, char seperator)
    {
        var arrayValues = SplitString(text, seperator);
        ArrayOutput(arrayValues);

    }


}

