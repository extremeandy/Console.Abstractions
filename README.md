# System.Console.Abstractions

> Abstraction which allows replacing static references to `System.Console` with an interface `IConsole.`

## Installation

```
dotnet add package System.Console.Abstractions
```

## Usage

```csharp
public class HelloWorldComponent
{
    readonly IConsole _console;

    public HelloWorldComponent(IConsole console)
    {
        _console = console;
    }

    public void WriteSomething()
    {
        _console.WriteLine("Hello, world!");
    }
}

void Main()
{
    // Real world usage
    var component = new HelloWorldComponent(SystemConsole.Instance);
    component.WriteSomething(); // Prints "Hello, world!" to actual console

    // Test usage with NSubstitute
    var mockConsole = Substitute.For<IConsole>();
    var testComponent = new HelloWorldComponent(mockConsole);
    testComponent.WriteSomething();

    mockConsole.Received().WriteLine("Hello, world!");
}
```


