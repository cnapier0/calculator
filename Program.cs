namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator");
            double num1;
            double num2;
            double result;

            Console.WriteLine("Enter Number 1:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            num2 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Please Enter Operation: +,   -,  *,  /");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Please enter valid operation");
                    break;

            }
        }
    }
}
