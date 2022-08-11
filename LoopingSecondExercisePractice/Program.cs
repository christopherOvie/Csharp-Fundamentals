public class Program
{

    public static void Main(string[] args)
    {
        double[] salary = { 8.9, 6.8, 7.6, 7.9, 7.8 };
        double[] height = { 9.9, 7, 6.89, 1.8, 2.6, 3.9, 3.8 };

        for (int i = 0; i < salary.Length; i++)
        {
            //Console.WriteLine(salary[i]);

        }
        //got no business with array
        Console.WriteLine("aaaaaaaaaaaa");
        for (int i = 0; i < 50; i++)
        {
            //   Console.WriteLine(i);
        }
        int a = 1;
        while (a < height.Length)
        {
            // Console.WriteLine(height[a]);
            a++;
        }
        //Console.WriteLine("yyyyyyy");
        int c = 0;
        do
        {
            Console.WriteLine(c + "  " + height[c] + " - done in while loop");
            c++;
        }
        while (c < height.Length);
        //Console.WriteLine("zzzzzzzzzzzzzzzzPrintinreverse");
        for (int i = height.Length - 1; i >= 0; i--)
        {
            //Console.WriteLine(height[i]);
        }
        //Console.WriteLine("tttttttttttt");
        int[] myages = { 7, 8, 9, 10, 11, 12, 13, 17 };
        for (int r = myages.Length - 1; r >= 0; r--)
        {

            Console.WriteLine(myages[r] + " - done in for loop");
        }
    }

}