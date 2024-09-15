using System;
using System.Collections.Generic;

// Interface defining the contract for a Message Bus
public interface IMessageBus
{
    // Method to publish a message of type T
    void Publish<T>(T message);

    // Method to subscribe to messages of type T with a specified handler
    void Subscribe<T>(Action<T> handler);
}

// Implementation of the Message Bus
public class MessageBus : IMessageBus
{
    // Dictionary to store subscribers for each message type
    private readonly Dictionary<Type, List<Delegate>> _subscribers = new();

    // Publishes a message to all subscribers of that message type
    public void Publish<T>(T message)
    {
        // Check if there are subscribers for the message type
        if (_subscribers.TryGetValue(typeof(T), out var handlers))
        {
            // Invoke each handler with the published message
            foreach (var handler in handlers)
            {
                ((Action<T>)handler)(message);
            }
        }
    }

    // Subscribes a handler to messages of type T
    public void Subscribe<T>(Action<T> handler)
    {
        // Check if this message type already has subscribers
        if (!_subscribers.ContainsKey(typeof(T)))
        {
            // If not, create a new list of handlers for this type
            _subscribers[typeof(T)] = new List<Delegate>();
        }
        // Add the handler to the list of subscribers for this message type
        _subscribers[typeof(T)].Add(handler);
    }
}

// Example message class representing an order placement event
public class OrderPlaced
{
    public string OrderId { get; }

    // Constructor to initialize the OrderId
    public OrderPlaced(string orderId)
    {
        OrderId = orderId;
    }
}

// Example subscriber class that handles order placed events
public class OrderService
{
    // Method that gets called when an OrderPlaced message is published
    public void OnOrderPlaced(OrderPlaced orderPlaced)
    {
        Console.WriteLine($"Order placed: {orderPlaced.OrderId}");
    }
}

// Main program demonstrating the usage of the Message Bus
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Message Bus
        IMessageBus messageBus = new MessageBus();

        // Create an instance of the OrderService subscriber
        var orderService = new OrderService();

        // Subscribe to the OrderPlaced event with the orderService's handler
        messageBus.Subscribe<OrderPlaced>(orderService.OnOrderPlaced);

        // Publish a new OrderPlaced message
        messageBus.Publish(new OrderPlaced("12345"));
    }
}