using System;
class Dummbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', (n / 2) + 1), new string('.', n));
        for (int i = 0, j = (n/2)-1, k = (n/2); i < (n/2)-1; i++, j--, k++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', j), new string('*', k), new string('.', n));
        }
        Console.WriteLine("&{0}&{1}&{0}&", new string('*', n-2), new string('=', n));
        for (int i = 0, j = 1, k = n - 3; i < (n / 2) - 1; i++, j++, k--)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', j), new string('*', k), new string('.', n));
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', (n / 2) + 1), new string('.', n));

    }
}