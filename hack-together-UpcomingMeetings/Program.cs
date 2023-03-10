using Microsoft.Graph;

var settings = Settings.LoadSettings();
string[] scopes = { "User.Read", "Calendars.Read" };
GraphServiceClient graphClient;

try
{
    graphClient = new Authentication().GetGraphClient(scopes, settings);
    var upcomingEvents = await GraphCalls.GetTodaysUpcomingEventsAsync(graphClient);
    ProcessOutput.DisplayUpcomingEvents(upcomingEvents?.Value);

}
catch (Exception e)
{
    var defaultColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Unable authenticate and get access to graph!");
    Console.WriteLine("Check if you have consented to the application or if the user has mailbox!");
    Console.ForegroundColor = defaultColor;

    Console.WriteLine(e.Message);    
}



