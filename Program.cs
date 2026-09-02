namespace project_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine($"Q1 - Second price: {prices[1]}");

            //2 
            int[,] shelfCopies =
            {
                {3, 5 },
                { 1 , 4 },
            };
            Console.WriteLine($"Q2 - Shelf 1, Slot 0 copies: {shelfCopies[1, 0]}");

            //3 
            Console.Write("Q3 - ");
            PrintWelcomeMessage();





















            //3 Method

            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }
        }
    }
}
