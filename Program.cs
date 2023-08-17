namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Sequence Generator\n");

            Console.Write("Enter the number of terms: ");
            if (int.TryParse(Console.ReadLine(), out int terms) && terms > 0)
            {
                GenerateFibonacci(terms);
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }

        static void GenerateFibonacci(int terms)
        {
            int firstTerm = 0;
            int secondTerm = 1;

            Console.Write("Fibonacci Sequence: ");

            if (terms >= 1)
            {
                Console.Write(firstTerm);
            }

            for (int i = 0; i < terms; i++)
            {
                Console.Write(", " + secondTerm);

                int nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm; 
                secondTerm = nextTerm;
            }

            Console.WriteLine();
        }
    }
}