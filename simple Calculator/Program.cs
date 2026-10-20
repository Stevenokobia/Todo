namespace simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Input the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What do you want to do with those numbers?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiply");
            var input = Console.ReadLine();

            if (EqualsCaseInsensitive(input, "A")) 
            {
                int sum = firstNumber + secondNumber;
                PrintFinalEquation(firstNumber, secondNumber, sum, "+");
            }
            else if (EqualsCaseInsensitive(input, "S"))
            {
                int difference = firstNumber - secondNumber;
                PrintFinalEquation(firstNumber, secondNumber, difference, "-");
            }
            else if (EqualsCaseInsensitive(input, "M"))
            {
                int multiplied = firstNumber * secondNumber;
                PrintFinalEquation(firstNumber, secondNumber, multiplied, "*");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();

            void PrintFinalEquation(
                int firstNumber, int secondNumber, int result, string @operator
                )
            {
                Console.WriteLine(firstNumber + "" + @operator + "" + secondNumber + "" + "=" + result);
            }

            bool EqualsCaseInsensitive(string left, string right)
            {
                return left.ToUpper() == right.ToUpper();
            }
        }
    }
}



