using System;
class GameOfBits
{
    static void Other()
    {
        uint number = uint.Parse(Console.ReadLine());
        int loops = 0;
        string command = Console.ReadLine();
        string binaryNumber = Convert.ToString(number, 2);
        string finalBinaryNumber = "";

        while (loops <= 31 && !command.Contains("Game Over!"))
        {
            for (int i = 0; i < binaryNumber.Length; i++)
            {


                if (command.Contains("Odd") && i%2 == 1)
                    finalBinaryNumber += binaryNumber[i];
                else if (command.Contains("Even") && i % 2 == 0)
                    finalBinaryNumber += binaryNumber[i];
            }
            if (Convert.ToInt32(finalBinaryNumber, 2) <= 0)
                break;

            binaryNumber = finalBinaryNumber;
            finalBinaryNumber = "";

            command = Console.ReadLine();
            loops++;
        }

        int numOfBits = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[i] == 49)
                numOfBits++;
        }

        Console.WriteLine("{0} -> {1}", Convert.ToInt32(binaryNumber, 2), numOfBits);

    }
}