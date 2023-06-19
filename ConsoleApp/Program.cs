namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World1");
            Console.WriteLine("Hello, World2");
            Console.WriteLine("Hello, World3");

            first_class first_ = new first_class();

            first_.Method("Vlad");

        }
    }
}