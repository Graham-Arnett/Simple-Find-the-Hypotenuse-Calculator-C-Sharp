namespace PythagoreanApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my Pythagorean Calculator! We will be solving for the Hypotenuse!");
            string choice;
            do
            {
                Console.Write("Please enter a number: ");
                int entryA = int.Parse(Console.ReadLine());
                Console.Write("One more number: ");
                int entryB = int.Parse(Console.ReadLine());

                int aSquare = entryA * entryA;
                int bSquare = entryB * entryB;
                int hypotenuseSquare = aSquare + bSquare;

                Console.WriteLine($"The hypotenuse's square is: {hypotenuseSquare}");
                Console.WriteLine($"The hypotenuse is: {Math.Sqrt(hypotenuseSquare)}");
                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
