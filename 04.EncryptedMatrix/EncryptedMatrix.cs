using System;
class EncryptedMatrix
{
    static void Main()
    {
        string massages = Console.ReadLine();
        char direction = char.Parse(Console.ReadLine());

        int[] numbers = new int[massages.Length];
        int[] num = new int[massages.Length];
        char str = '.';

        for (int i = 0; i < massages.Length; i++)
        {
            numbers[i] = massages[i];
            for (int j = 0; j < numbers[i].ToString().Length; j++)
            {
                
                if (j == numbers[i].ToString().Length - 1)
                {
                    str = numbers[i].ToString()[j];
                }
            }
            num[i] = (int) Char.GetNumericValue(str);
        }
        
        int before = 0;
        int next = 0;
        string numberStr = "";
        int nums = 0;

        for (int i = 0; i < num.Length; i++)
        {
            int numN = i + 1;
            int numB = i - 1;
            if (i != 0)
                before = num[numB];
            if (i < num.Length)
            {
                if (numN == num.Length)
                    next = 0;
                else
                    next = num[numN];
            }

            nums = (num[i]%2 == 0) ? ((int) Math.Pow(num[i], 2)) : (num[i] + before + next) ;
            numberStr += nums.ToString();

            nums = 0;
        }

        int[,] matrix = new int[numberStr.Length, numberStr.Length];

        if (numberStr.Length == 1)
            Console.WriteLine(numberStr);
        else
        {
            
            if (direction == '\\')
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i == j)
                            matrix[i, j] = (int)Char.GetNumericValue(numberStr[i]);
                    }
                }
            }
            else
            {
                for (int i = 0, col = matrix.GetLength(1) - 1; i < matrix.GetLength(0); i++, col--)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                            matrix[i, col] = (int)Char.GetNumericValue(numberStr[col]);
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(Convert.ToString(matrix[i, j]).PadRight(2));
                }
                Console.WriteLine();
            }
        }
    }
}