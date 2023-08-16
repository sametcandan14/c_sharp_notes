using System;
using System.Globalization;

namespace _9_dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
              string[] aylar = {"Ocak", "Şubat", "Mart", "Nisan", "Mayıs","Haziran",
              "Temmuz","Ağustos","Eylül", "Ekim", "Kasım", "Aralık"};

            DateTime simdi = DateTime.Now;

            // Console.WriteLine(simdi.Year);
            // Console.WriteLine(simdi.Month);
            // Console.WriteLine(aylar[simdi.Month-1]);
            // Console.WriteLine(simdi.Day);
            // Console.WriteLine(simdi.DayOfWeek);
            // Console.WriteLine(simdi.Hour);
            // Console.WriteLine(simdi.Minute);
            // Console.WriteLine(simdi.Second);

            DateTime dt= new DateTime(2018,2,22,14,30,21);

            // DateTime dt1= dt.AddDays(2);
            // DateTime dt1= dt.AddYears(2);
            DateTime dt1= dt.AddHours(-5);

            var fark = simdi - dt;


            // System.Console.WriteLine(fark.TotalDays);
            // System.Console.WriteLine(fark.TotalHours);

            // System.Console.WriteLine(simdi.ToString("d"));
            // System.Console.WriteLine(simdi.ToString("D"));
            // System.Console.WriteLine(simdi.ToString("F"));
            // System.Console.WriteLine(simdi.ToString("M"));
            // System.Console.WriteLine(simdi.ToString("t"));
            // System.Console.WriteLine(simdi.ToString("T"));
            // System.Console.WriteLine(simdi.ToString("Y"));

        System.Console.WriteLine(simdi.ToString("hh-mm-ss"));
        System.Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy"));

        CultureInfo culture= new CultureInfo("en");
        System.Console.WriteLine(simdi.ToString("F",culture));

        }
    }
}
