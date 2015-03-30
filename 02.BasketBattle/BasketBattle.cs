using System;
class BasketBattle
{
    static void Main()
    {
        string playerName = Console.ReadLine();
        int roundInTheGame = int.Parse(Console.ReadLine());

        double pointsNakov = 0;
        double pointsSimeon = 0;

        string playerNameThisRound = playerName;
        string playerWin = "";
        int turn = 1;
        int round = 0;

        for (int i = 1; i <= roundInTheGame; i++)
        {
            for (int j = 1; j <= 2; j++)
            {
                if (turn%2 == 0)
                {
                    if (playerNameThisRound.Contains("Nakov"))
                        playerNameThisRound = "Simeon";
                    else if (playerNameThisRound.Contains("Simeon"))
                        playerNameThisRound = "Nakov";
                }

                double points = double.Parse(Console.ReadLine());
                string stage = Console.ReadLine();

                if (stage.Contains("success"))
                {
                    if (playerNameThisRound.Contains("Nakov"))
                        pointsNakov += points;
                    else if (playerNameThisRound.Contains("Simeon"))
                        pointsSimeon += points;
                }
                turn++;
            }
            round++;
            if (pointsNakov >= 500)
            {
                playerWin = "Nakov";
                break;
            }
            else if (pointsSimeon >= 500)
            {
                playerWin = "Simeon";
                break;
            }
        }

        if (playerWin == "Nakov")
        {
            Console.WriteLine(playerWin);
            Console.WriteLine(round);
            Console.WriteLine(pointsSimeon);
        }
        else if (playerWin == "Simeon")
        {
            Console.WriteLine(playerWin);
            Console.WriteLine(round);
            Console.WriteLine(pointsNakov);
        }
        else if (pointsNakov == pointsSimeon)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(pointsNakov);
        }
        else if (pointsNakov > pointsSimeon && pointsNakov < 500)
        {
            Console.WriteLine("Nakov");
            Console.WriteLine(pointsNakov - pointsSimeon);
        }
        else if (pointsSimeon > pointsNakov && pointsSimeon < 500)
        {
            Console.WriteLine("Simeon");
            Console.WriteLine(pointsSimeon - pointsNakov);
        }
    }
}