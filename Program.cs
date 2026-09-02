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

            //6

            double[] myPrices = { 25.5, 40.0 };
            ApplyDiscount(myPrices);
            Console.WriteLine($"Q6 - Prices[0]: {myPrices[0]}");

            //7 

            int pagesRef = 400;
            AddBonusPagesByRef(ref pagesRef);
            Console.WriteLine($"Q7 - Pages by ref: {pagesRef}");


            //8
            double[] arrayToReplace = { 25.5, 40.0 };
            ReplaceArray(ref arrayToReplace);
            Console.WriteLine($"Q8 - Array Length: {arrayToReplace.Length}");

            //9

            if (TryGetPrice("Clean Code", out double foundPrice))
            {
                Console.WriteLine($"Q9 - Found price: {foundPrice}");
            }

            //10

            Console.Write("Q10 (Default) - ");
            PrintBookInfo("C# Essentials");
            Console.Write("Q10 (Provided) - ");
            PrintBookInfo("C# Essentials", 500);


            //11
            Console.Write("Q11 - ");
            PrintBookInfo(pages: 250, title: "Refactoring");


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


            //6 Method

            static void ApplyDiscount(double[] prices)
            {
                prices[0] -= 5;
            }

            //7 Method

            static void AddBonusPagesByRef(ref int pages)
            {
                pages += 50;
            }

            //8 Method

            static void ReplaceArray(ref double[] prices)
            {
                prices = new double[] { 10.0, 12.5, 15.0 };
            }


            //9 Method

            static bool TryGetPrice(string title, out double price)
            {
                if (title == "Clean Code")
                {
                    price = 25.5;
                    return true;
                }

                price = 0;
                return false;
            }


            //10 Method

            static void PrintBookInfo(string title, int pages = 300)
            {
                Console.WriteLine($"Title: {title}, Pages: {pages}");
            }


            //11 Method

            static void PrintBookInfo1(string title, int pages = 300)
            {
                Console.WriteLine($"Title: {title}, Pages: {pages}");
            }


        }
    }
}
