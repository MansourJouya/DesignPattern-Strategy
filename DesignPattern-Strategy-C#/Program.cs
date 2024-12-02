using System;
using System.Collections.Generic;

/// <summary>
/// Strategy interface for defining a family of algorithms.
/// </summary>
public interface IStrategy
{
    /// <summary>
    /// Executes the strategy.
    /// </summary>
    void Execute();
}

/// <summary>
/// Concrete implementation of a strategy: Algorithm A.
/// </summary>
public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing Strategy A");
    }
}

/// <summary>
/// Concrete implementation of a strategy: Algorithm B.
/// </summary>
public class ConcreteStrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing Strategy B");
    }
}

/// <summary>
/// Context class that uses a strategy.
/// </summary>
public class Context
{
    private IStrategy? _strategy;

    /// <summary>
    /// Sets the strategy at runtime.
    /// </summary>
    /// <param name="strategy">The strategy to use.</param>
    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    /// <summary>
    /// Executes the strategy.
    /// </summary>
    public void ExecuteStrategy()
    {
        if (_strategy == null)
        {
            Console.WriteLine("No strategy is set.");
            return;
        }

        _strategy.Execute();
    }
}

/// <summary>
/// Demonstrates the Strategy Design Pattern.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Create the context
        Context context = new Context();

        // Use Strategy A
        Console.WriteLine("Setting Strategy A:");
        context.SetStrategy(new ConcreteStrategyA());
        context.ExecuteStrategy();

        // Use Strategy B
        Console.WriteLine("\nSetting Strategy B:");
        context.SetStrategy(new ConcreteStrategyB());
        context.ExecuteStrategy();
    }
}
