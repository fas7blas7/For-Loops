namespace _4_NumbersEndingIn7
{
    internal class NumbersEndingIn7
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endOfRange; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}