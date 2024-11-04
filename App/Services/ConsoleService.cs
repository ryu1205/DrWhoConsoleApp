using DrWhoConsoleApp.Interfaces;

namespace DrWhoConsoleApp.Services;
public class ConsoleService : IConsoleService
{
    public string ReadLine()
    {
        return Console.ReadLine();
    }

    public void WriteLine(string? message)
    {
        Console.WriteLine(message);
    }
    public void Write(string message)
    {
        Console.Write(message);
    }
}