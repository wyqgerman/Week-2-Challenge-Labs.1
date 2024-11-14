namespace Week_2_Challenge_Labs._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Fahrenheit: ");
            int temperature = int.Parse(Console.ReadLine());

            if (temperature < 10)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temperature >= 11 && temperature <= 20)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temperature >= 21 && temperature <= 35)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temperature >= 36 && temperature <= 50)
            {
                Console.WriteLine("Normal weather");
            }
            else if (temperature >= 51 && temperature <= 65)
            {
                Console.WriteLine("It's Hot");
            }
            else if (temperature >= 66 && temperature <= 80)
            {
                Console.WriteLine("It's Very Hot");
            }
            else
            {
                Console.WriteLine("Extreme Heat");
            }
        }
    }
}
