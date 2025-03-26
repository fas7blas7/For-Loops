namespace _3_SumNumbers
{
    internal class SumNumbers
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}