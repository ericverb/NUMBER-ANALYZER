// See https://aka.ms/new-console-template for more information

bool runAgain = true;

while (runAgain)
{
    Console.WriteLine("Enter a number between 1 and 100:");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    int evenOrOddNumber = userNumber % 2;
    if (userNumber is >= 1 and <= 100)
    {

        if (evenOrOddNumber == 0 && userNumber is >= 2 and <= 24)
        {
            Console.WriteLine($"Your Number: {userNumber} - Even and less then 25.{Environment.NewLine}");

        }
        else if (evenOrOddNumber == 0 && userNumber is >= 26 and <= 60)
        {
            Console.WriteLine($"YourNumber: {userNumber}  - Even and between 26 and 60.{Environment.NewLine}");

        }
        if (evenOrOddNumber != 0 && userNumber < 60)
        {
            Console.WriteLine($"Your Number: {userNumber} - Odd and less then 60. {Environment.NewLine}");
        }
        else if (evenOrOddNumber == 0 && userNumber is > 60)
        {
            Console.WriteLine($"YourNumber: {userNumber}  - Even and greater then 60. {Environment.NewLine}");

        }

        else if (evenOrOddNumber != 0 && userNumber is > 60)
        {
            Console.WriteLine($"YourNumber: {userNumber}  - Odd and greater then 60. {Environment.NewLine}");

        }

        //Run Again
        Console.WriteLine("Do you want to run again? Enter Yes or No!");
        string runYesNo = Console.ReadLine();
        runYesNo.ToLower();

        if (runYesNo == "no")
        {
            runAgain = false;
        }

    }
    else
    {
        Console.WriteLine($"You entered {userNumber} it is not between 1 and 100!");
        runAgain = false;
    }

}

Console.WriteLine("Bye!");


