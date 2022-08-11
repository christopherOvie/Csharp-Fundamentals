public class Program
{
    public static void Main(string[] args)
    {
        //Loops are used to iterate through a collection
        //types of loop for , foreach, while, do while

        string[] names = {"Andrew", "Chris", "Paula" };
        int number = 0;
        number = number + 1;
        number++;
        number = number - 1;
        number--;
        Console.WriteLine(number);

        //foreach
        // names = names.Reverse().ToArray();
        Console.WriteLine("Foreach loop");
        foreach (var name in names)
        {
            Console.Write(name + ", ");
        }

        //for
        //first part is the index counter
        //second part is the range of our array
        //third part is the increment
        Console.WriteLine("For loop - increment");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
            // Console.WriteLine(names.ElementAt(i));
        }

        for (int i = 1; i < 101; i++)
        {
            Console.WriteLine(i);
            // Console.WriteLine(names.ElementAt(i));
        }

        //for
        //first part is the index counter
        //second part is the range of our array
        //third part is the decrement
        Console.WriteLine("For loop - decrement");
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
            // Console.WriteLine(names.ElementAt(i));
        }


        //while
        //first part is the index counter
        //second part is the range of our array
        //third part is the increment
        Console.WriteLine("While loop");
        int whileCounter = 0;
        while (whileCounter < names.Length)
        {
            Console.WriteLine(names[whileCounter]);
            whileCounter++;
        }

        //do while
        //first part is the index counter
        //second part is the increment
        //third part is the range of our array
        Console.WriteLine("do While loop");
        int doWhileCounter = 0;
        do
        {
            Console.WriteLine(names[doWhileCounter]);
            doWhileCounter++;
        } while (doWhileCounter < names.Length);


        //Joining strings in a collection
        Console.WriteLine(string.Join(", ", names));

    }

}