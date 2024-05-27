namespace OperatorExercise
{
    class Program
    {
        private static double radius;

        public static void Main(string[] args)
        {
            //Exercise 1 declare variables
            int a = 17;
            int b = 4;

            //operations
            var sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");

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
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            //Exercise 2
            Console.WriteLine("What is the radious of your circle?");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);
            

            //Console.WriteLine(AreaOfCircle(radius));
            Console.WriteLine($"The area of a circle with radius of {radius} is {(AreaOfCircle(radius))}");


        } 
        public static double AreaOfCircle(double radius)
            {
            return (Math.PI * radius * radius);
            }



    }
}
