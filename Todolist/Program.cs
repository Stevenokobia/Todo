namespace Todolist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");

            string userChoice = Console.ReadLine();
            Console.WriteLine("userInput:" + userChoice);

            Console.ReadKey();
        }
    }
}
