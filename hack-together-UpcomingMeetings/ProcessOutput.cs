using Microsoft.Graph.Models;

public class ProcessOutput
{
    public static void DisplayUpcomingEvents(List<Event>? events)
    {
        var defaultColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;        

        if (events?.Count < 1)
        {
            Console.WriteLine($"There are no upcoming meetings for you today, enjoy or use it as your focus time!");
            Console.ForegroundColor = defaultColor;
            return;
        }
        else
        {
            Console.WriteLine($"Your upcoming meetings for today({events?.Count}):");
            Console.ForegroundColor = defaultColor;

            foreach (var item in events!)
            {
                Console.WriteLine(Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Subject: {item.Subject}");
                Console.ForegroundColor = defaultColor;

                Console.WriteLine($"Start: {item.Start.ToDateTime().ToLocalTime().ToString("d-MMM-yyyy hh:mm tt")}");
                Console.WriteLine($"End: {item.End.ToDateTime().ToLocalTime().ToString("d-MMM-yyyy hh:mm tt")}");
            }
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
