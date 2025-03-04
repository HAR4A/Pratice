namespace Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        private static void StringsRepeating()
        {
            Console.WriteLine("Enter the message: ");
            string message = Console.ReadLine();

            Console.WriteLine("Enter the number of repetitions: ");
            int numberOfRepetitions = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRepetitions; i++)
            {
                Console.WriteLine(message);
            }
        }

        private static void LoopUntilExit()
        { 
            const string correctWord = "exit";
            
            while (true)
            {
                Console.WriteLine("Enter the exit word: ");
                string exitWord = Console.ReadLine();
                
                if (exitWord == correctWord)
                {
                    Console.WriteLine("You have entered the correct word");
                    break;
                }
            }
        }

        private static void StartSequence()
        {
            /*выбор на цикл for пал по причине того, 
            что в нем можно удобно задать шаг в условие*/
            
            const int minNumber = 5;
            const int maxNumber = 96;

            for (int i = minNumber; i <= maxNumber; i+=7)
            {
                Console.WriteLine(i);
            }
        }

        private static void CalculatingSum()
        {
            Random random = new Random();
            
            int sum = 0;
            int number = random.Next(1, 101);
            
            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            
            Console.WriteLine($"Случайное число: {number}");
            Console.WriteLine($"Сумма чисел, кратных 3 или 5: {sum}");
        }
        
        private static void EnumerationOfArray()
        {
            float[] numbers = {1.24f, 1.43f, 23.3f,98.4f, 11.3f};

            Array.Sort(numbers);
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }

        private static void EnumerationOfList()
        {
            string[] cities = { "Москва", "Лондон", "Нью-Йорк", "Париж", "Берлин" };

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            
            int[] numbers = {4, 7, 10, 23, 18, 21};
            int countNumber = 0;
            
            foreach (var item  in numbers)
            {
                if (item % 3 == 0)
                {
                    countNumber++;
                } 
            }
            Console.WriteLine(countNumber);

            
            List<string> words = new List<string> { "яблоко", "банан", "ананас", "груша", "персик" };
            string longestWord = "";

            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine(longestWord);
        }

        private static void CurrencyConverter()
        {
            const string commandExit = "exit";
            const string commandConvert = "convert";
            
            var exchange = new CurrencyExchange();

            while (true)
            {
                Console.WriteLine($"\nВаш баланс: USD: {exchange.Balances["usd"]:F2}, EUR: {exchange.Balances["eur"]:F2}, RUB: {exchange.Balances["rub"]:F2}");
                Console.WriteLine("\nВведите команду (convert - конвертировать, exit - выйти):");
                
                string command = Console.ReadLine()?.ToLower();

                if (command == commandExit)
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
                
                if (command == commandConvert)
                {
                    Console.WriteLine("Выберите валюту, с которой хотите конвертировать (usd, eur, rub):");
                    string fromCurrency = Console.ReadLine()?.ToLower();

                    Console.WriteLine("Выберите валюту, в которую хотите конвертировать (usd, eur, rub):");
                    string toCurrency = Console.ReadLine()?.ToLower();

                    Console.WriteLine("Введите сумму для конвертации:");
                    if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
                    {
                        Console.WriteLine("Ошибка: введите корректное положительное число.");
                        continue;
                    }

                    if (exchange.ConvertCurrency(fromCurrency, toCurrency, amount, out double convertedAmount))
                    {
                        Console.WriteLine(
                            $"Успешная конвертация! Вы получили {convertedAmount:F2} {toCurrency.ToUpper()}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: неверная операция конвертации.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: неизвестная команда.");
                }
            }

        }
    }
    
    
    
    
}