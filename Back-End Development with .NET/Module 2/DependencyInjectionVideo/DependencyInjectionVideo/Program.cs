var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddSingleton<IMyService, MyService>(); 

app.MapGet("/", () => "Hello World!");

app.Run();

public interface IMyService
{
    void LogCreation(string message);
}

public class MyService : IMyService
{
    private readonly int _serviceId;

    public MyService()
    {
        _serviceId = new Random().Next(100000, 999999);
    }

    public void LogCreation(string message)
    {
        Console.WriteLine($"Service {_serviceId} created: {message}");
    }
}