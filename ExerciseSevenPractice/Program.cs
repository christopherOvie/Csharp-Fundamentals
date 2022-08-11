
public class Program
{


    public static void Main(string[] args)
    {

        string[] cars = { "benz", "porche", "ferrari", "bentley" };

        //string[] cars = new string[0];
        foreach (string eachCar in cars)
        {
            Console.WriteLine(eachCar);
        }

        int counter = 0;
        Console.WriteLine("zzzzzzzzzzz");
        do
        {
            Console.WriteLine(cars[counter]);
            counter++;
        } while (counter < cars.Length);

        //"benz", "porche", "ferrari", "bentley"
        counter = cars.Length - 1;
        Console.WriteLine("xxxxxxxxxxxx");
        do
        {

            if (cars[counter] == "benz")
            {
                Console.WriteLine(counter + "  Mercedes-" + cars[counter] + "  - done in do while loop");
            }
            else
            {
                Console.WriteLine(counter + " " + cars[counter] + "  - done in do while loop");
            }
            counter--;
        } while (counter >= 0);



    }

}