var randomValue = Guid.NewGuid();
var timeStamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/", () =>
{
    timeStamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffz");

    return Results.Ok(
        new
        {
            timestamp = timeStamp,
            randString = randomValue
        }
    );
});

var server = app.RunAsync("http://0.0.0.0:8080");

while (!server.IsCompleted)
{
    timeStamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffz");

    Console.WriteLine($"{timeStamp} : {randomValue.ToString()}");

    await Task.Delay(TimeSpan.FromSeconds(5));
}

await server;