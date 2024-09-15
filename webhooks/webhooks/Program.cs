using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

// Interface defining the contract for a Webhook
public interface IWebhook
{
    // Method to register a webhook URL
    void Register(string url);

    // Method to trigger the webhook with a message
    Task TriggerAsync<T>(T message);
}

// Implementation of the Webhook
public class Webhook : IWebhook
{
    // List to store registered webhook URLs
    private readonly List<string> _webhookUrls = new();

    // Registers a new webhook URL
    public void Register(string url)
    {
        _webhookUrls.Add(url);
    }

    // Triggers the webhook by sending a POST request to each registered URL
    public async Task TriggerAsync<T>(T message)
    {
        using var httpClient = new HttpClient();

        // Serialize the message to JSON format
        var jsonMessage = Newtonsoft.Json.JsonConvert.SerializeObject(message);
        var content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");

        // Iterate through all registered webhook URLs
        foreach (var url in _webhookUrls)
        {
            try
            {
                // Send a POST request with the message to the webhook URL
                var response = await httpClient.PostAsync(url, content);
                response.EnsureSuccessStatusCode(); // Throws if the response status code is not successful
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send webhook to {url}: {ex.Message}");
            }
        }
    }
}

// Example message class representing an order placement event
public class OrderPlaced
{
    public string OrderId { get; }
    public string CustomerId { get; }

    // Constructor to initialize the OrderId and CustomerId
    public OrderPlaced(string orderId, string customerId)
    {
        OrderId = orderId;
        CustomerId = customerId;
    }
}

// Main program demonstrating the usage of Webhook
class Program
{
    static async Task Main(string[] args)
    {
        // Create an instance of the Webhook
        IWebhook webhook = new Webhook();

        // Register some webhook URLs (example URLs)
        webhook.Register("https://example.com/webhook1");
        webhook.Register("https://example.com/webhook2");

        // Create a new OrderPlaced message
        var orderPlacedMessage = new OrderPlaced("12345", "cust001");

        // Trigger the webhooks with the order placed message
        await webhook.TriggerAsync(orderPlacedMessage);
    }
}