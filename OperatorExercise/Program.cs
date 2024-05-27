namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 declare variables
            int a = 17;
            int b = 4;
            
            //operations
            var sum = a + b;
            Console.WriteLine($"{ a} + { b} = { sum}");
          
            var subtract = a - b;
            Console.WriteLine($"{a} - {b} = {subtract}");

            var mult = a * b;
            Console.WriteLine($"{a} * {b} = {mult}");

            var div = a / b;
            Console.WriteLine($"{a} / {b} = {sum}");

            var mod = a % b;
            Console.WriteLine($"{a} % {b} = {sum}");

            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is { quotient} remainder { remainder}");









        }
    }
}
