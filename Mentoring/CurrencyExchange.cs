namespace Practice;

public class CurrencyExchange
{
    private readonly Dictionary<string, double> _exchangeRates = new()
    {
        { "usd_to_eur", 0.91 }, { "usd_to_rub", 91.5 },
        { "eur_to_usd", 1.1 }, { "eur_to_rub", 100.5 },
        { "rub_to_usd", 0.011 }, { "rub_to_eur", 0.0099 }
    };
    
    public Dictionary<string, double> Balances { get; private set; } = new()
    {
        { "usd", 100 },
        { "eur", 150 },
        { "rub", 200 }
    };
    
    public bool ConvertCurrency(string from, string to, double amount, out double convertedAmount)
    {
        convertedAmount = 0;
        string key = from + "_to_" + to;
        if (from == to || !_exchangeRates.TryGetValue(key, out double rate) || amount <= 0)
        {
            return false;
        }
        
        if (Balances[from] < amount)
        {
            Console.WriteLine("Ошибка: недостаточно средств на балансе.");
            return false;
        }

        convertedAmount = amount * rate;
        Balances[from] -= amount;
        Balances[to] += convertedAmount;
        return true;
    }
}