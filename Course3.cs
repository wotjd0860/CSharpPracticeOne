namespace Course3
{
    public class Functions
    {
        public static void variableScope() {
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;

            foreach (int number in numbers)
            {
                total += number;
                if (number == 42)
                    found = true;
            }

            if (found)
                Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");
        }
        
        /*
        public static void booleanActivity() {
            string permission = "Admin|Manager";
            int level = 53;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
        */

        /*
        public static void evaluateBoolean() {
            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            Console.WriteLine(1 == 2);

            string myValue = "a";
            Console.WriteLine(myValue == "a");

            Console.WriteLine("a" != "a");
            Console.WriteLine("a" != "A");
            Console.WriteLine(1 != 2);

            string myValue = "a";
            Console.WriteLine(myValue != "a");

            Console.WriteLine(1 > 2);
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);

            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(!pangram.Contains("fox"));
            Console.WriteLine(!pangram.Contains("cow"));

            int saleAmount = 1001;
            // int discount = saleAmount > 1000 ? 100 : 50;

            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

            Random coin = new Random();
            Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
        }
        */
    }
}