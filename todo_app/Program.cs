var builder = WebApplication.CreateBuilder(args);
var portVal = Environment.GetEnvironmentVariable("PORT");

var port = int.TryParse(portVal, out var definedPort) && definedPort is > 0 and <= 65535 ? definedPort : 8080;

builder.WebHost.UseUrls($"http://0.0.0.0:{port}");
var app = builder.Build();
app.MapGet("/", () => "TODO app running");

app.Lifetime.ApplicationStarted.Register(() =>
{
   Console.WriteLine($"Server Started in Port: {port}"); 
});

app.Run();
