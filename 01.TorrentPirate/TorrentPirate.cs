using System;
class TorrentPirate
{
    static void Main()
    {
        decimal downloadData = int.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        decimal w = decimal.Parse(Console.ReadLine());

        decimal downloadTime = downloadData/2/60/60;
        decimal downloadInMall = downloadTime*w;
        decimal filmsOfCinema = (downloadData/1500)*p;

        if (downloadInMall > filmsOfCinema)
        {
            Console.WriteLine("cinema -> {0:f2}lv", filmsOfCinema);
        }
        else if (filmsOfCinema >= downloadInMall)
        {
            Console.WriteLine("mall -> {0:f2}lv", downloadInMall);
        }
        else
        {
            Console.WriteLine("cinema -> {0:f2}lv", filmsOfCinema);
        }

        
    }
}