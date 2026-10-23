var randomValue = Guid.NewGuid();

while (true)

{
    var timeStamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

    Console.WriteLine($"{timeStamp} : {randomValue.ToString()}");

    await Task.Delay(TimeSpan.FromSeconds(5));
}