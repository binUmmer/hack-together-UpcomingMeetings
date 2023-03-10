using Azure.Identity;
using Microsoft.Graph;

public class Authentication {

    public GraphServiceClient GetGraphClient(string[] scopes, Settings settings){
        
        InteractiveBrowserCredentialOptions interactiveBrowserCredentialOptions = new InteractiveBrowserCredentialOptions
        {
            ClientId = settings.ClientId
        };

        //Getting the token credential using clientId
        InteractiveBrowserCredential tokenCredential = new InteractiveBrowserCredential(interactiveBrowserCredentialOptions);

        //This creates a client with default handlers
        GraphServiceClient graphClient = new GraphServiceClient(tokenCredential, scopes);
        
        //return the default client
        return graphClient;
    }
}