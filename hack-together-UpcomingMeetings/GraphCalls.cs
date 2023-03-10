using Microsoft.Graph.Models;
using Microsoft.Graph;

public class GraphCalls
{
    public static async Task<EventCollectionResponse> GetTodaysUpcomingEventsAsync(GraphServiceClient graphClient)
    {
        var startOfToday = DateTime.Now.AddMilliseconds(1);        
        var endOfToday = DateTime.Today.AddDays(1);

        var todaysEvents = await graphClient.Me.CalendarView.GetAsync((requestConfiguration) =>
        {
            requestConfiguration.QueryParameters.StartDateTime = startOfToday.ToString("o");
            requestConfiguration.QueryParameters.EndDateTime = endOfToday.ToString("o");
            requestConfiguration.QueryParameters.Select = new string[] { "id", "subject", "start", "end" };
        });

        return todaysEvents;
    }

}
