using System;

namespace Course5
{
    public class Functions
    {
        // Lesson 4 : Guided Project
        public static void guidedProject() {

            string[] pettingZoo = 
            {
                "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
                "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
                "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            };

            PlanSchoolVisit("School A");
            PlanSchoolVisit("School B", 3);
            PlanSchoolVisit("School C", 2);

            void PlanSchoolVisit(string schoolName, int groups = 6) 
            {
                RandomizeAnimals(); 
                string[,] group1 = AssignGroup(groups);
                Console.WriteLine(schoolName);
                PrintGroup(group1);
            }

            void RandomizeAnimals() 
            {
                Random random = new Random();

                for (int i = 0; i < pettingZoo.Length; i++) 
                {
                    int r = random.Next(i, pettingZoo.Length);

                    string temp = pettingZoo[r];
                    pettingZoo[r] = pettingZoo[i];
                    pettingZoo[i] = temp;
                }
            }

            string[,] AssignGroup(int groups = 6) 
            {
                string[,] result = new string[groups, pettingZoo.Length/groups];
                int start = 0;

                for (int i = 0; i < groups; i++) 
                {
                    for (int j = 0; j < result.GetLength(1); j++) 
                    {
                        result[i,j] = pettingZoo[start++];
                    }
                }

                return result;
            }

            void PrintGroup(string[,] groups) 
            {
                for (int i = 0; i < groups.GetLength(0); i++) 
                {
                    Console.Write($"Group {i + 1}: ");
                    for (int j = 0; j < groups.GetLength(1); j++) 
                    {
                        Console.Write($"{groups[i,j]}  ");
                    }
                    Console.WriteLine();
                }
            }
        }

        // Lesson 3 : Method with return
        public static void returnMethod() {
            int target = 30;
            int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
            int[,] result = TwoCoins(coins, target);

            if (result.Length == 0) 
            {
                Console.WriteLine("No two coins make change");
            } 
            else 
            {
                Console.WriteLine("Change found at positions:");
                for (int i = 0; i < result.GetLength(0); i++) 
                {
                    if (result[i,0] == -1) 
                    {
                        break;
                    }
                    Console.WriteLine($"{result[i,0]},{result[i,1]}");
                }
            }

            int[,] TwoCoins(int[] coins, int target) 
            {
                int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
                int count = 0;

                for (int curr = 0; curr < coins.Length; curr++) 
                {
                    for (int next = curr + 1; next < coins.Length; next++) 
                    {    
                        if (coins[curr] + coins[next] == target) 
                        {
                            result[count, 0] = curr;
                            result[count, 1] = next;
                            count++;
                        }
                        if (count == result.GetLength(0)) 
                        {
                            return result;
                        }
                    }
                }
                return (count == 0) ? new int[0,0] : result;
            }
        }

        // Lesson 2 : Parameters
        public static void parameterPractice() {
            string[,] corporate = 
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

            string[,] external = 
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";

            for (int i = 0; i < corporate.GetLength(0); i++) 
            {
                DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
            }

            for (int i = 0; i < external.GetLength(0); i++) 
            {
                DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
            }

            void DisplayEmail(string first, string last, string domain = "contoso.com") 
            {
                string email = first.Substring(0, 2) + last;
                email = email.ToLower();
                Console.WriteLine($"{email}@{domain}");
            }
        }

        // Lesson 1 : Write Your First C# Methid
        public static void DisplayRandomNumbers() {
            string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
            string[] address;
            bool validLength = false;
            bool validZeroes = false;
            bool validRange = false;

            foreach (string ip in ipv4Input) 
            {
                address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

                ValidateLength(); 
                ValidateZeroes(); 
                ValidateRange();

                Console.WriteLine($"{validLength.ToString()} {validZeroes.ToString()}, {validRange.ToString()}");

                if (validLength && validZeroes && validRange) 
                {
                    Console.WriteLine($"{ip} is a valid IPv4 address");
                } 
                else 
                {
                    Console.WriteLine($"{ip} is an invalid IPv4 address");
                }
            }

            void ValidateLength() 
            {
                validLength = address.Length == 4;
            };

            void ValidateZeroes() 
            {
                foreach (string number in address) 
                {
                    if (number.Length > 1 && number.StartsWith("0")) 
                    {
                        validZeroes = false;
                        return;
                    }
                }

                validZeroes = true;
            }

            void ValidateRange() 
            {
                foreach (string number in address) 
                {
                    int value = int.Parse(number);
                    if (value < 0 || value > 255) 
                    {
                        validRange = false;
                        return;
                    }
                }
                validRange = true;
            }
        }
    }
}