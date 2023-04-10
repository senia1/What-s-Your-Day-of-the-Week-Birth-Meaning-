using System;
using System.Globalization;

public class Example
{
    enum PlanetEnum
    {
        Sun=1,
        Moon,
        Mars,
        Mercury,
        Jupiter,
        Venera,
        Saturn
    };
    enum Days { Sun=1, Mon, Tue, Wed, Thu, Fri, Sat };
    class Client
    {
        public Client(int x)
        {
            switch (x)
            {
                case (int)PlanetEnum.Sun:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Sunday is ruled by SUN.\n" +
                        "* People born on Sunday spend their lives in search of the extraordinary " +
                        "and will not be satisfied with anything ordinary.\n" +
                        "* These people make excellent leaders, can influence people, and are often successful.");
                    Console.ResetColor();
                    break;
                case (int)PlanetEnum.Moon:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Monday is ruled by MOON\n" +
                        "* People born on Monday are subject to ever changing moods and desires.\n" +
                        "* Family and a few close friends are your priorities.\n" +
                        "* You are an excellent negotiator and make sure everyone gets what they want.");
                    Console.ResetColor();
                    break;
                case (int)PlanetEnum.Mars:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Tuesday is ruled by MARS.\n" +
                        "* Those born on Tuesday share a fighting spirit and strong determination.\n" +
                        "* They are always fuelled by a desire to lead and win.\n" +
                        "");
                    Console.ResetColor();
                    break;
                case (int)PlanetEnum.Mercury:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wednesday is ruled by MERCURY.\n" +
                        "* Often associated with restlessness, Mercury passes a wandering spirit and " +
                        "questioning attitude to Wednesday’s children. \n" +
                        "* Communication is crucial to people born on this day and they will seek to talk things out, ask questions and look for " +
                        "answers.\n " +
                        "* People born on this day are also logical and flexible. ");
                    Console.ResetColor();
                    break;
                case (int)PlanetEnum.Jupiter:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Thursday is ruled by JUPITER.\n" +
                        "* Thursday’s child is likely to be optimistic, generous and jovial. " +
                        "* They will also be drawn toward teaching and have a desire to share their " +
                        "positive perspective with others.\n" +
                        "====Just like you were born on Thursday: ");
                    Console.ResetColor();
                    break;
                case (int)PlanetEnum.Venera:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Friday is ruled by VENUS.\n" +
                        "* Those born on Friday will be drawn towards beauty, romance, art and refinement.\n" +
                        "* They may also use seduction and beauty to influence others.\n" +
                        "* People born on this day are often generous and open to sharing.");
                    Console.ResetColor();
                    break;
                case (int)PlanetEnum.Saturn:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Saturday is ruled by SATURN.\n" +
                        "* Saturday’s child is born with a purpose and they will spend their life looking for " +
                        "and trying to achieve that objective.\n" +
                        "* These modest and studios workers are professional and practical.\n " +
                        "* They routinely put their life’s work ahead of enjoyment and are often far wiser than their peers.");
                    Console.ResetColor();
                    break;
            }
        }
    }
    public static void Main()
    {
        Console.WriteLine("Hello! What The Day Of The Week You Were Born Says About You\n");
        string dateBirth = GetNumber();
        int dayofweek;
        string day;
        
        if (GetValidDate(dateBirth))
        { 
            DateTime myDate = DateTime.ParseExact(dateBirth, "ddMMyyyy", System.Globalization.CultureInfo.InvariantCulture);
            dayofweek = (int)myDate.DayOfWeek + 1;
            day = myDate.DayOfWeek.ToString();
            
            Console.WriteLine($"You were born on {day}") ;
            Client client1 = new Client(dayofweek);
        }
        else 
        {
            Console.WriteLine("there is no such day");
            GetNumber(); 
        }
    }
    public static string GetNumber() 
    {
        var userText = "";
        int maxCountDigit = 8;
        var isNumber = false;
        var isValidDate = false;
       
        while (true)
        {
            Console.WriteLine("Please type your birthday like ddMMyyyy: \ne.g. 15091980 if you were born on September 15, 1980 or 03072003 if you were born on July 3, 2003 ");
            userText = Console.ReadLine();
            if (userText.Length != 8)
            {
                Console.WriteLine("only 8 chars");
                continue;
            }
            int count = 0;
            foreach (var item in userText)
            {
                if (!char.IsDigit(item))
                {
                    isNumber = false;
                    break;
                }
                else
                {
                    isNumber= true;
                    count++;
                }
            }

            if (isNumber)
            {
                  break;
            }
            Console.WriteLine("only digits and valid date!");
        }
        return userText;
    }

    public static bool GetValidDate(string dateBirth)
    {
        DateTime tempDate;
        return DateTime.TryParseExact(dateBirth,
                       "ddMMyyyy",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out tempDate);
    }
}   