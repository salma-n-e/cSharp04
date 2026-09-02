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

            //4 
            Console.Write("Q4 - ");
            PrintBookTitle("Clean Code");

            //5
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine($"Q5 - Pages: {pages}");















            //3 Method

            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }

            //4 Method

            static void PrintBookTitle(string title)
            {
                Console.WriteLine("Book title: " + title);
            }

            //5 Method

            static void AddBonusPages(int pages)
            {
                pages += 50;
            }
        }
    }
}
