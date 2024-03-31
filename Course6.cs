namespace Course6
{
    public class Functions
    {
        public static void exceptionThrowing() {
            try
            {
                OperatingProcedure1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exiting application.");
            }

            static void OperatingProcedure1()
            {
                string[][] userEnteredValues = new string[][]
                {
                    new string[] { "1", "two", "3"},
                    new string[] { "0", "1", "2"}
                };

                foreach(string[] userEntries in userEnteredValues)
                {
                    try
                    {
                        BusinessProcess1(userEntries);
                    }
                    catch (Exception ex)
                    {
                        if (ex.StackTrace.Contains("BusinessProcess1"))
                        {
                            if (ex is FormatException)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Corrective action taken in OperatingProcedure1");
                            }
                            else if (ex is DivideByZeroException)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                                // re-throw the original exception
                                throw;
                            }
                            else
                            {
                                // create a new exception object that wraps the original exception
                                throw new ApplicationException("An error occurred - ", ex);
                            }
                        }
                    }

                }
            }

            static void BusinessProcess1(string[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    try
                    {
                        valueEntered = int.Parse(userValue);

                        checked
                        {
                            int calculatedValue = 4 / valueEntered;
                        }
                    }
                    catch (FormatException)
                    {
                        FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                        throw invalidFormatException;
                    }
                    catch (DivideByZeroException)
                    {
                        DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
                        throw unexpectedDivideByZeroException;

                    }
                }
            }
        }
        public static void exceptionHandlingPractice1() {
            try
            {
                Process1();
            }
            catch
            {
                Console.WriteLine("An exception has occurred");
            }

            Console.WriteLine("Exit program");

            static void Process1()
            {
                try
                {
                    WriteMessage();
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Exception caught in Process1: {ex.Message}");
                }
            }

            static void WriteMessage()
            {
                double float1 = 3000.0;
                double float2 = 0.0;
                int number1 = 3000;
                int number2 = 0;
                byte smallNumber;

                try
                {
                    Console.WriteLine(float1 / float2);
                    Console.WriteLine(number1 / number2);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
                }
                
                // This statement is used to check whether there is overflow when you assign a value to a variable.
                checked
                {
                    try
                    {
                        smallNumber = (byte)number1;
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
                    }  
                }
            }
        }

        public static void overflowException() {
            decimal x = 400;
            byte i;

            i = (byte)x; // OverflowException occurs
            Console.WriteLine(i);
        }

        public static void nullReferenceException() {
            int[] values = null;
            for (int i = 0; i <= 9; i++)
                values[i] = i * 2;

            // nullable
            string? lowCaseString = null;
            Console.WriteLine(lowCaseString.ToUpper());
        }
        
        public static void invalidCastException() {
            object obj = "This is a string";
            int num = (int)obj;
        }

        public static void indexOutOfRangeException() {
            int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
            int[] values2 = new int[6];

            values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs
        }

        public static void formatException() {
            int valueEntered;
            string userValue = "two";
            valueEntered = int.Parse(userValue); // FormatException occurs
        }

        public static void dividedByZeroException() {
            int number1 = 3000;
            int number2 = 0;
            Console.WriteLine(number1 / number2); // DivideByZeroException occurs
        }
        
        public static void arrayTypeMismatchException() {
            string[] names = { "Dog", "Cat", "Fish" };
            Object[] objs = (Object[])names;

            Object obj = (Object)13;
            objs[2] = obj; // ArrayTypeMismatchException occurs
        }
    }
}