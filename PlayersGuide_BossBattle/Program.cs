int manticoreHealth = 10;
int consolasHealth = 15;
int gameRound = 1;


GameLoop();

void GameLoop()
{
    int manticoreDistance = -1;
    while (manticoreDistance > 0 || manticoreDistance < 100 && manticoreHealth > 0 && consolasHealth > 0)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("PlayerOne, how far is Manticore from city? (0 to 100) ");
        string playerOneResponse = Console.ReadLine();
        manticoreDistance = Convert.ToInt32(playerOneResponse);
        if (manticoreDistance < 0 || manticoreDistance > 100)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("That number is not between 0 and 100. \nTry again: \n");
            continue;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Roger that. Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        while (manticoreHealth > 0 && consolasHealth > 0)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
                DisplayStats();
                int damage = DamageForRound(gameRound);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Now, player two, Fire!");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > manticoreDistance && consolasHealth > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{guess} is too far. Try again.");
                    consolasHealth--;
                    gameRound++;
                }
                else if (guess < manticoreDistance && consolasHealth > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{guess} fell short. Try again.");
                    consolasHealth--;
                    gameRound++;
                }
                else if (guess == manticoreDistance)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Direct hit!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    DisplayStats();
                    manticoreHealth -= damage;
                    consolasHealth--;
                    gameRound++;
                    break;
                }
            }
            if (manticoreHealth <= 0)
            {
                WinCondition();
                break;
            }
            if (consolasHealth <= 0)
            {
                loseCondition();
                break;
            }
        }
    }
}

int DamageForRound(int roundNumber)
{
    if (roundNumber % 5 == 0 && roundNumber % 3 == 0) return 10; 
    else if (roundNumber % 5 == 0) return 3; 
    else if (roundNumber % 3 == 0) return 3; 
    return 1; 
}

void DisplayStats()
{
    Console.WriteLine($"Status: Round: {gameRound} City: {consolasHealth} Manticore: {manticoreHealth}");
}

void WinCondition()
{
        Console.WriteLine("You have destroyed the Manticore!");
            return;
}

void loseCondition()
{
        Console.WriteLine("Consolas has fallen!");
            return;
}