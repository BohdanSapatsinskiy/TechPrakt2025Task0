namespace Task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть перше число:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введiть друге число:");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");

        }
    }
}
