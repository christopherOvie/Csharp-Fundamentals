
public class Program

{
    public static void Main(string[] args)
    {


        string[] cars = { "Audi", "Seat", "BMW" };


        foreach (string eachCar in cars)
        {
            Console.Write(eachCar);
        }

        int counter = 0;

        do
        {
            Console.WriteLine(cars[counter]);
            counter++;

        } while (counter < cars.Length);
        Console.WriteLine("first do while loop:cars");

        int[] numbers = { 10, 20, 30, 40 };

        foreach (int eachNumber in numbers)
        {
            
            Console.WriteLine(eachNumber);
        }
        Console.WriteLine("ist foreach for numbers");
        counter = 0;
        while (counter < numbers.Length)
            

        {
            Console.WriteLine(numbers[counter]);
            counter++;
        }
        Console.WriteLine("ist whileloop for numbers");
        for (int i = 0; i < numbers.Length; i++)
        {
            
            Console.WriteLine(numbers[i]);
            
        }
        Console.WriteLine("for loop for numbers");
        counter = cars.Length - 1;

        do

        {
            if (cars[counter] == "BMW")
            {
             
                Console.WriteLine(counter + " Mercedes-" + cars[counter] + " - done in do while loop");
                
            }

            else

            {
                // Console.WriteLine(counter + " Mercedes-" + cars[counter] + " - done in do while loop");
                Console.WriteLine(counter + " " + cars[counter] + " - done in do while loop");

            }
            counter--;

        } while (counter >= 0);

        counter = cars.Length - 1;
        do

        {
            string addition = "";
            if (cars[counter] == "BMW")
            {
                addition = " Mercedes-";
            }

            Console.WriteLine(counter + " " + addition + cars[counter] + " - done in do while loop");
            counter--;
            
        } while (counter >= 0);
        Console.WriteLine("b4 using arrays but now using lists for cars2");
        //using arrays but now using lists
        // string[] cars = { "Audi", "Seat", "BMW" };


        List<string> car2 = new List<string>()
        {

            "Audi", "Seat", "BMW"
        };


        foreach (string eachCar in cars)
        {
            Console.Write(eachCar);
        }

    }

}