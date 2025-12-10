using Azure;
using Azure.AI.OpenAI;
using Azure.Identity;
using OpenAI.Chat;

namespace ZavaStorefront.Services
{
    public class ChatService
    {
        private readonly AzureOpenAIClient _client;
        private readonly string _deploymentName;
        private readonly ILogger<ChatService> _logger;

        public ChatService(IConfiguration configuration, ILogger<ChatService> logger)
        {
            _logger = logger;
            
            var endpoint = configuration["AI_FOUNDRY_ENDPOINT"];
            _deploymentName = configuration["AI_FOUNDRY_DEPLOYMENT_NAME"] ?? "gpt-4o-mini";

            if (string.IsNullOrEmpty(endpoint))
            {
                _logger.LogWarning("AI_FOUNDRY_ENDPOINT is not configured. Chat functionality will not be available.");
                _client = null!;
                return;
            }

            _logger.LogInformation("Initializing ChatService with endpoint: {Endpoint}, deployment: {Deployment}", 
                endpoint, _deploymentName);

            _client = new AzureOpenAIClient(
                new Uri(endpoint),
                new DefaultAzureCredential());
        }

        public async Task<string> SendMessageAsync(string message)
        {
            if (_client == null)
            {
                return "Chat service is not configured. Please set AI_FOUNDRY_ENDPOINT.";
            }

            try
            {
                _logger.LogInformation("Sending message to AI: {Message}", message);

                var chatClient = _client.GetChatClient(_deploymentName);
                
                var chatMessages = new List<ChatMessage>
                {
                    new SystemChatMessage("You are a helpful assistant for the Zava Storefront. Help customers with product inquiries and general questions."),
                    new UserChatMessage(message)
                };

                var response = await chatClient.CompleteChatAsync(chatMessages);
                var content = response.Value.Content[0].Text;

                _logger.LogInformation("Received response from AI");
                return content;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error calling AI Foundry endpoint");
                return $"Error: {ex.Message}";
            }
        }
    }
}
