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
                Console.Write($"Subject: {item.Subject}");
                Console.ForegroundColor = defaultColor;

                //Checking and alerting if the meeting is already in progress
                var inProgress = string.Empty;
                if (item.Start.ToDateTime().ToLocalTime() < DateTime.Now && item.End.ToDateTime().ToLocalTime() > DateTime.Now)
                    inProgress = " - In Progress";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(inProgress);
                Console.ForegroundColor = defaultColor;

                Console.WriteLine($"Start: {item.Start.ToDateTime().ToLocalTime().ToString("d-MMM-yyyy hh:mm tt")}");
                Console.WriteLine($"End: {item.End.ToDateTime().ToLocalTime().ToString("d-MMM-yyyy hh:mm tt")}");
            }
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
