// Basic Middleware setup for HTTP Logging  ("Configure Middleware for API Requests") example.
// Adding the HTTP logging service which takes a function that does nothing, but has the (o) => {}) as a convention, but it can have an actual function if needed.
// Will also need to add some configuration in appsettings.json
// This is the service that needs to be added, but be sure to add the logging level desired
// "Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware" : "Information"
// This is build in middleware for ASP.NET Core applications, but we can create out own with app.Use 

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpLogging((o) => {});

var app = builder.Build();

app.Use(async (context, next) =>{
    Console.WriteLine("Logic before.");
    await next.Invoke();
    Console.WriteLine("Logic after.");
});


app.UseHttpLogging();

// This is a basic middleware that does nothing, but it could be extended to log requests and responses, but in this case, it does nothing; next is the next middleware in the pipeline




app.MapGet("/", () => "Hello World!");
app.MapGet("/hello", () => "This is the hello route.");

app.Run();


