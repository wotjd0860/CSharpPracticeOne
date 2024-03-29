using System.Globalization;

namespace Course4
{
    public class Functions
    {
        /*
        public static void builtInStringDataType() {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here

            // Extract the "quantity"
            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
            int quantityEnd= input.IndexOf(closeSpan);
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength);
            quantity = $"Quantity: {quantity}";

            // Set output to input, replacing the trademark symbol with the registered trademark symbol
            const string tradeSymbol = "&trade;";
            const string regSymbol = "&reg;";
            output = input.Replace(tradeSymbol, regSymbol);

            // Remove the opening <div> tag
            const string openDiv = "<div>";
            int divStart = output.IndexOf(openDiv);
            output = output.Remove(divStart, openDiv.Length);

            // Remove the closing </div> tag and add "Output:" to the beginning
            const string closeDiv = "</div>";
            int divCloseStart = output.IndexOf(closeDiv);
            output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

            Console.WriteLine(quantity);
            Console.WriteLine(output);
        }
        */

        /*
        public static void stringFormattingPractice() {
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine(comparisonMessage);
        }
        */

        /*
        public static void strinfFormatting() {
            // string first = "Hello";
            // string second = "World";
            // Console.WriteLine($"{first} {second}!");
            // Console.WriteLine($"{second} {first}!");
            // Console.WriteLine($"{first} {first} {first}!");

            // // currency format
            // decimal price = 123.45m;
            // int discount = 50;
            // Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            // // change currency symbol
            // CultureInfo us = CultureInfo.GetCultureInfo("en-US");
            // Console.WriteLine($"Price: {string.Format(us, "{0:C}", price)} (Save {string.Format(us, "{0:C}", discount)})");

            // // formatting number
            // decimal measurement = 123456.78912m;
            // Console.WriteLine($"Measurement: {measurement:N} units");
            // Console.WriteLine($"Measurement: {measurement:N4} units");

            // // formatting percentage
            // decimal tax = .36785m;
            // Console.WriteLine($"Tax rate: {tax:P2}");

            // // combination
            // decimal price = 67.55m;
            // decimal salePrice = 59.99m;

            // CultureInfo us = CultureInfo.GetCultureInfo("en-US");
            // string yourDiscount = String.Format(us, "You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

            // yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
            // Console.WriteLine(yourDiscount);

            // int invoiceNumber = 1201;
            // decimal productShares = 25.4568m;
            // decimal subtotal = 2750.00m;
            // decimal taxPercentage = .15825m;
            // decimal total = 3185.19m;

            // CultureInfo us = CultureInfo.GetCultureInfo("en-US");

            // Console.WriteLine($"Invoice Number: {invoiceNumber}");
            // Console.WriteLine($"   Shares: {productShares:N3} Product");
            // Console.WriteLine($"     Sub Total: {String.Format(us, "{0:C}", subtotal)}");
            // Console.WriteLine($"           Tax: {taxPercentage:P2}");
            // Console.WriteLine($"     Total Billed: {String.Format(us, "{0:C}", total)}");

            // // padding
            // string paymentId = "769C";
            // string payeeName = "Mr. Stephen Ortega";
            // string paymentAmount = "$5,000.00";

            // var formattedLine = paymentId.PadRight(6);
            // formattedLine += payeeName.PadRight(24);
            // formattedLine += paymentAmount.PadLeft(10);

            // Console.WriteLine("1234567890123456789012345678901234567890");
            // Console.WriteLine(formattedLine);
        }
        */

        /*
        public static void arrayFunctions() {
            // string[] pallets = { "B14", "A11", "B12", "A13" };

            // Console.WriteLine("Sorted...");
            // Array.Sort(pallets);
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Console.WriteLine("Reversed...");
            // Array.Reverse(pallets);
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");

            // Array.Clear(pallets, 0, 2);
            // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Array.Resize(ref pallets, 6);
            // Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            // pallets[4] = "C01";
            // pallets[5] = "C02";

            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Array.Resize(ref pallets, 3);
            // Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // ToCharArray, Reverse
            // string value = "abc123";
            // char[] valueArray = value.ToCharArray();
            // Array.Reverse(valueArray);
            // string result = new string(valueArray);
            // string result = String.Join(",", valueArray);
            // Console.WriteLine(result);

            // // Split()
            // string[] items = result.Split(',');
            // foreach (string item in items)
            // {
            //     Console.WriteLine(item);
            // }

            // Practice
            string pangram = "The quick brown fox jumps over the lazy dog";

            // Step 1
            string[] message = pangram.Split(' ');

            //Step 2
            string[] newMessage = new string[message.Length];

            // Step 3
            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            //Step 4
            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);

            // Practice 2
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] items = orderStream.Split(',');
            Array.Sort(items);

            foreach (var item in items)
            {
                if (item.Length == 4)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine(item + "\t- Error");
                }
            }
        }
        */

        /*
        public static void convertDataTypes() {
            // // an example of narrowing conversion
            // decimal myDecimal = 1.23456789m;
            // float myFloat = (float)myDecimal;

            // Console.WriteLine($"Decimal: {myDecimal}");
            // Console.WriteLine($"Float  : {myFloat}");

            // // Use of toString() : int to string
            // int first = 5;
            // int second = 7;
            // string message = first.ToString() + second.ToString();
            // Console.WriteLine(message);

            // // Use of parse() : string to int
            // string third = "5";
            // string forth = "7";
            // int sum = int.Parse(third) + int.Parse(forth);
            // Console.WriteLine(sum);

            // // Use of Convert class : string to int
            // string value1 = "5";
            // string value2 = "7";
            // int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            // Console.WriteLine(result);

            // int value3 = (int)1.5m; // casting truncates
            // Console.WriteLine(value3);

            // int value4 = Convert.ToInt32(1.5m); // converting rounds up
            // Console.WriteLine(value4);

            // TryParse()
            // string value = "bad";
            // int result = 0;
            // if (int.TryParse(value, out result))
            // {
            //     Console.WriteLine($"Measurement: {result}");
            // }
            // else
            // {
            //     Console.WriteLine("Unable to report the measurement.");
            // }

            // if (result > 0)
            // {
            //     Console.WriteLine($"Measurement (w/ offset): {50 + result}");
            // }

            string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string message = "";

            foreach (var value in values)
            {
                decimal number; // stores the TryParse "out" value
                if (decimal.TryParse(value, out number))
                {
                    total += number;
                } else
                {
                    message += value;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");
        }
        */

        /*
        public static void dataType() {
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
        }
        */
    }
}