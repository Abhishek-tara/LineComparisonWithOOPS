using LineComparisonOOPS;

namespace LineComparisonComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Computation Program");

            CalculateLength length = new CalculateLength();
            length.Calculate();
        }
    }
}

