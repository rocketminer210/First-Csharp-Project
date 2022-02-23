



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number: ");
            double inputted = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i <= 3; i++)
            {
                string mathoutput = Convert.ToString(Math.Pow(inputted, i));
                Console.WriteLine(mathoutput);
            }




        }
    }
}