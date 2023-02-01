using System.Text.Json;

public class ExchangeSymbolRepository
{
    public IEnumerable<ExchangeSymbol>? Get()
    {

        return JsonSerializer
            .Deserialize<IEnumerable<ExchangeSymbol>>(
            File.OpenRead("wwwroot/exchangesymbols.json")
        );

    }
}
