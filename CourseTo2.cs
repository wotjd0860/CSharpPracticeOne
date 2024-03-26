namespace CourseTo2
{
    public class Functions
    {
        /*
        public static void IterateAndIfElse() {
            // initialize variables - graded assignments
            int examAssignments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

            // Student names
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            int[] studentScores = new int[10];

            string currentStudentLetterGrade = "";

            // Write the Report Header to the console
            Console.WriteLine("Student\t\tGrade\n");

            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                studentScores = sophiaScores;

                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;

                else if (currentStudent == "Emma")
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                // initialize/reset the sum of scored assignments
                int sumAssignmentScores = 0;

                // initialize/reset the calculated average of exam + extra credit scores
                decimal currentStudentGrade = 0;

                // initialize/reset a counter for the number of assignment 
                int gradedAssignments = 0;

                // loop through the scores array and complete calculations for currentStudent
                foreach (int score in studentScores)
                {
                    // increment the assignment counter
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments)
                        // add the exam score to the sum
                        sumAssignmentScores += score;

                    else
                        // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                        sumAssignmentScores += score / 10;
                }

                currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            }

            // required for running in VS Code (keeps the Output windows open to view results)
            Console.WriteLine("\n\rPress the Enter key to continue");
            Console.ReadLine();
        }
        */

        /*
        public static void VariableAndCommentPractice() {
            
            This code reverses a message, counts the number of times 
            a particular character appears, then prints the results
            to the console window.
            

            string originalMessage = "The quick brown fox jumps over the lazy dog.";

            char[] message = originalMessage.ToCharArray();
            Array.Reverse(message);

            int letterCount = 0;

            foreach (char letter in message)
            {
                if (letter == 'o')
                {
                    letterCount++;
                }
            }

            string newMessage = new String(message);

            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {letterCount} times.");
        }
        */

        /*
        public static void ArrayPractice() {
            string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            // fraudulentOrderIDs[3] = "D000";

            string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");
        }
        */

        /*
        public static void IfElseExample() {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }

                Console.WriteLine($"Your total including the bonus: {total}");
            }

            if (total >= 16)
            {
                Console.WriteLine("You win a new car!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a kitten!");
            }
        }
        */

        /*
        public static void Methods() {
            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);;

            Console.WriteLine(largerValue);
        }
        */

        /*
        public static void Calculate()
        {
            decimal decimalQuotient1 = 7 / 5.0m;
            Console.WriteLine($"Decimal quotient: {decimalQuotient1}");
            decimal decimalQuotient2 = 7.0m / 5;
            Console.WriteLine($"Decimal quotient: {decimalQuotient2}");
            decimal decimalQuotient3 = 7.0m / 5.0m;
            Console.WriteLine($"Decimal quotient: {decimalQuotient3}");
            decimal decimalQuotient4 = 7 / 5;
            Console.WriteLine($"Decimal quotient: {decimalQuotient4}");

            int value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine($"Second: {value++}");
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));

            int fahrenheit = 94;
            Console.WriteLine($"The temperature is " + ((fahrenheit - 32m) * (5m / 9m)) + " Celsius.");
        }
        */

        /*
        public static void UnicodeAndTypes()
        {
            string name = "Bob";
            int msgCnt = 3;
            float temperature = 34.4f;

            Console.WriteLine("Hello, " + name + "! You have " + msgCnt + " messages in your inbox. The temperature is " + temperature + " celsius.");

            string projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
        }
        */

        /*
        public static void firstClass()
        {
            Console.WriteLine("Hello, World!");

            // This is the comment in C#

            Console.WriteLine("This is the first line");

            Console.Write("This is ");
            Console.Write("the ");
            Console.Write("second line");
        }
        */
    }
}