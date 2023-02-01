using System.Text.Json;

public class ExchangeRepository
{
    public IEnumerable<Exchange>? Get()
    {

        return JsonSerializer
            .Deserialize<IEnumerable<Exchange>>(
            File.OpenRead("wwwroot/exchanges.json")
        );

    }
}
