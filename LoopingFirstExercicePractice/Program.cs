public class Program
{

    public static void Main(string[] args)
    {
        String[] cars = { "benz", "cardillac", "jeep", "ferrari", "bentley" };

        //for (int a = 0; a < cars.Length; a++)
        //{
        //    // Console.WriteLine(cars[i]);
        //    Console.WriteLine(cars.Length);
        //}

        int i = 0;
        while (i < cars.Length)
        {

            // Console.WriteLine(cars[i]);
            Console.WriteLine(cars[i].Reverse());
            i++;

        }

        int b = 3;
        do
        {
            Console.WriteLine(cars[b]);
            b++;
        }
        while (b < cars.Count());

        int[] age = { 5, 10, 12, 18, 19, 34, 56 };
        Console.WriteLine("abccccccccc");
        foreach (var ageNumbers in age)
        {
            Console.WriteLine(ageNumbers);
        }
        Console.WriteLine("yyyyyyyyyyyy");
        int y = 3;
        while (y < age.Length)
        {
            Console.WriteLine(age[y]);
            y++;
        }
        Console.WriteLine("zzzzzzzzzzz");
        int z = 0;
        do
        {
            Console.WriteLine(age[z]);
            z++;
        }
        while (z < age.Length);
        Console.WriteLine("qqqqqqqqqqq");
        String[] vehicle = { "benz", "beetle", "taxi", "bentley" };
        Console.WriteLine("dddddddddddowhileloop");


        int h = vehicle.Length - 1;
        do
        {
            if (vehicle[h] == "benz")
            {
                Console.WriteLine(h + " Mercedes " + vehicle[h] + " - done in do while loop");
            }
            else
            {
                Console.WriteLine(h + " " + vehicle[h] + " - done in do while loop");
            }
            h--;
        }
        while (h >= 0);
        Console.WriteLine("bbbbbbbbbbb");
        int k = vehicle.Length - 1;
        do
        {
            string addition = " ";
            if (vehicle[k] == "benz")
            {
                Console.WriteLine(k + " " + addition  + vehicle[k] + " - done in do while loop");
            }
            k--;    
            
        } while (k >= 0);
    }











}
