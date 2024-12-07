using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using RouletteConsoleApp;
List<Number> numbers = new List<Number>();
#region
Number number = new Number();
number.Value = 0;
number.Color = "Green";

numbers.Add(number);

number = new Number();
number.Value = 1;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 2;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 3;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 4;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 5;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 6;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 7;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 8;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 9;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 10;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 11;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 12;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 13;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 14;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 15;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 16;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 17;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 18;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 19;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 20;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 21;
number.Color = "Red";

numbers.Add(number);


number = new Number();
number.Value = 22;
number.Color = "Black";

numbers.Add(number);


number = new Number();
number.Value = 23;
number.Color = "Red";

numbers.Add(number);


number = new Number();
number.Value = 24;
number.Color = "Black";

numbers.Add(number);


number = new Number();
number.Value = 25;
number.Color = "Red";

numbers.Add(number);


number = new Number();
number.Value = 26;
number.Color = "Black";

numbers.Add(number);


number = new Number();
number.Value = 27;
number.Color = "Red";

numbers.Add(number);


number = new Number();
number.Value = 28;
number.Color = "Black";

numbers.Add(number);


number = new Number();
number.Value = 29;
number.Color = "Black";

numbers.Add(number);


number = new Number();
number.Value = 30;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 31;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 32;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 33;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 34;
number.Color = "Red";

numbers.Add(number);

number = new Number();
number.Value = 35;
number.Color = "Black";

numbers.Add(number);

number = new Number();
number.Value = 36;
number.Color = "Red";

numbers.Add(number);

#endregion
bool keepPlaying = true;
int balance = 1000;
int payoutMultiplier = 0;
while (keepPlaying)
{

    Console.WriteLine($"\nTwoje saldo: {balance} PLN");

    if (balance <= 0)
    {
        Console.WriteLine("Masz za mało pieniędzy, aby kontynuować grę. Gra kończy się!");
        break;
    }
    Console.WriteLine("Welcome gambler, what would you like to place your bet on?");
    Console.WriteLine("1 = Number");
    Console.WriteLine("2 = Color");
    Console.WriteLine("3 = Range");
    Console.WriteLine("4 = Even/Odd");
    Console.WriteLine("5 = End the game");
    int betType = int.Parse(Console.ReadLine());
    if (betType == 5)
    {
        Console.WriteLine("Dziękujemy za grę!");
        keepPlaying = false;
        continue;
    }

    Console.WriteLine("Ile chcesz obstawić?");
    int betAmount = int.Parse(Console.ReadLine());

    if (betAmount > balance)
    {
        Console.WriteLine("Nie masz wystarczającej ilości pieniędzy. Spróbuj ponownie.");
        continue;
    }
    if (betAmount <= 0)
    {
        Console.WriteLine("Kwota zakładu musi być większa niż 0. Spróbuj ponownie.");
        continue;
    }

    string userBet = "";
    switch (betType)
    {
        case 1:
            Console.WriteLine("Obstaw liczbę (0-36):");
            userBet = Console.ReadLine();
            if (!int.TryParse(userBet, out int betNumber) || betNumber < 0 || betNumber > 36)
            {
                Console.WriteLine("Niepoprawna liczba. Spróbuj ponownie!");
                return;
            }
            break;

        case 2:
            Console.WriteLine("Obstaw, jaki kolor wypadnie (Red, Black, Green):");
            userBet = Console.ReadLine();
            if (userBet != "Red" && userBet != "Black" && userBet != "Green")
            {
                Console.WriteLine("Niepoprawny kolor. Spróbuj ponownie!");
                return;
            }
            break;

        case 3:
            Console.WriteLine("Obstaw zakres (1-12, 13-24, 25-36):");
            userBet = Console.ReadLine();
            if (userBet != "1-12" && userBet != "13-24" && userBet != "25-36")
            {
                Console.WriteLine("Niepoprawny zakres. Spróbuj ponownie!");
                return;
            }
            break;

        case 4:
            Console.WriteLine("Obstaw parzysta/nieparzysta (Even/Odd):");
            userBet = Console.ReadLine();
            if (userBet != "Even" && userBet != "Odd")
            {
                Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie!");
                return;
            }
            break;

        default:
            Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie!");
            return;
    }
    Random rnd = new Random();
    int random = rnd.Next(0, 37);

    Number result = numbers.Find(num => num.Value == random);
    Console.WriteLine($"Ball landed on {result.Color} {result.Value}");

    bool isWin = false;

    switch (betType)
    {
        case 1:
            isWin = result.Value == int.Parse(userBet);
            payoutMultiplier = 36;
            break;

        case 2:
            isWin = result.Color.Equals(userBet, StringComparison.OrdinalIgnoreCase);
            payoutMultiplier = 2;
            break;
        case 3:
            if (userBet == "1-12") isWin = result.Value >= 1 && result.Value <= 12;
            else if (userBet == "13-24") isWin = result.Value >= 13 && result.Value <= 24;
            else if (userBet == "25-36") isWin = result.Value >= 25 && result.Value <= 36;
            payoutMultiplier = 3;
            break;

        case 4:
            if (userBet == "Even") isWin = result.Value % 2 == 0 && result.Value != 0; 
            else if (userBet == "Odd") isWin = result.Value % 2 != 0;
            payoutMultiplier = 2;
            break; ;
    }


    if (isWin)
    {
        int winnings = betAmount * payoutMultiplier;
        balance += winnings;
        Console.WriteLine($"Gratulacje! Wygrałeś {winnings} PLN! Twoje saldo to teraz {balance} PLN.");
    }
    else
    {
        balance -= betAmount;
        Console.WriteLine($"Niestety, przegrałeś {betAmount} PLN. Twoje saldo to teraz {balance} PLN.");
    }
}
