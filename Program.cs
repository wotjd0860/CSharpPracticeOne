

void IfElseExample() {
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

void Methods() {
    int firstValue = 500;
    int secondValue = 600;
    int largerValue = Math.Max(firstValue, secondValue);;

    Console.WriteLine(largerValue);
}

void Calculate()
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

void UnicodeAndTypes()
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

void firstClass()
{
    Console.WriteLine("Hello, World!");

    // This is the comment in C#

    Console.WriteLine("This is the first line");

    Console.Write("This is ");
    Console.Write("the ");
    Console.Write("second line");
}