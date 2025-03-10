﻿using System;
using System.Collections.Generic;

// Define the INotificationObserver interface
public interface INotificationObserver
{
    void Update(string message);
}

// Implement the EmailNotifier class
public class EmailNotifier : INotificationObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"EmailNotifier received: {message}");
    }
}

// Implement the SMSNotifier class
public class SMSNotifier : INotificationObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"SMSNotifier received: {message}");
    }
}

// Define the NotificationService class
public class NotificationService
{
    private readonly List<INotificationObserver> _observers = new List<INotificationObserver>();

    public void AddObserver(INotificationObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(INotificationObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }
}
