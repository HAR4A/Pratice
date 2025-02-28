
namespace Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        private static void MasteringCycles()
        {
            Console.WriteLine("Enter the message: ");
            string _message = Console.ReadLine();

            Console.WriteLine("Enter the number of repetitions: ");
            int _numberOfRepetitions = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < _numberOfRepetitions; i++)
            {
                Console.WriteLine(_message);
            }
        }

        private static void ControlOfExit()
        { 
            string _correctWord = "exit";
            
            while (true)
            {
                Console.WriteLine("Enter the exit word: ");
                string _exitWord = Console.ReadLine();
                
                if (_exitWord == _correctWord)
                {
                    Console.WriteLine("You have entered the correct word");
                    break;
                }
            }
        }

        private static void Sequence()
        {
            /*выбор на цикл for пал по причине того, 
            что в нем можно удобно задать шаг в условие*/
            
            int _minNumber = 5;
            int _maxNumber = 96;

            for (int i = _minNumber; i <= _maxNumber; i+=7)
            {
                Console.WriteLine(i);
            }
        }

        private static void SumOfNumbers()
        {
            Random random = new Random();
            
            int _sum = 0;
            int _number = random.Next(1, 101);
            
            for (int i = 0; i < _number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    _sum += i;
                }
            }
            
            Console.WriteLine($"Случайное число: {_number}");
            Console.WriteLine($"Сумма чисел, кратных 3 или 5: {_sum}");
        }

        private static void CurrencyConverter()
        {
            
            const string _commandExit = "exit";
            const string _commandConvert = "convert";
            
            const double _usdToEur = 0.91;
            const double _usdToRub = 91.5;
            const double _eurToUsd = 1.1;
            const double _eurToRub = 100.5;
            const double _rubToUsd = 0.011;
            const double _rubToEur = 0.0099;
            
            double _usdBalance = 100;
            double _eurBalance = 150;
            double _rubBalance = 200;

            while (true)
            {
                Console.WriteLine("\nВаш баланс:");
                Console.WriteLine($"USD: {_usdBalance:F2}, EUR: {_eurBalance:F2}, RUB: {_rubBalance:F2}");
                Console.WriteLine("\nВведите команду (convert - конвертировать, exit - выйти):");

                string _command = Console.ReadLine()?.ToLower();

                if (_command == _commandExit)
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
                else if (_command == _commandConvert)
                {
                    Console.WriteLine("Выберите валюту, с которой хотите конвертировать (usd, eur, rub):");
                    string _fromCurrency = Console.ReadLine()?.ToLower();
                    
                    Console.WriteLine("Выберите валюту, в которую хотите конвертировать (usd, eur, rub):");
                    string _toCurrency = Console.ReadLine()?.ToLower();
                    
                    if (_fromCurrency == _toCurrency)
                    {
                        Console.WriteLine("Вы не можете конвертировать валюту саму в себя.");
                        continue;
                    }
                    
                    
                    Console.WriteLine("Введите сумму для конвертации:");
                    if (!double.TryParse(Console.ReadLine(), out double _amount) || _amount <= 0)
                    {
                        Console.WriteLine("Ошибка: введите корректное положительное число.");
                        continue;
                    }

                    double _rate = 0;
                    bool _validConversion = true;

                    if (_fromCurrency == "usd" && _toCurrency == "eur") _rate = _usdToEur;
                    else if (_fromCurrency == "usd" && _toCurrency == "rub") _rate = _usdToRub;
                    else if (_fromCurrency == "eur" && _toCurrency == "usd") _rate = _eurToUsd;
                    else if (_fromCurrency == "eur" && _toCurrency == "rub") _rate = _eurToRub;
                    else if (_fromCurrency == "rub" && _toCurrency == "usd") _rate = _rubToUsd;
                    else if (_fromCurrency == "rub" && _toCurrency == "eur") _rate = _rubToEur;
                    else _validConversion = false;

                    if (!_validConversion)
                    {
                        Console.WriteLine("Ошибка: неверный выбор валют.");
                        continue;
                    }

                    double _convertedAmount = _amount * _rate;

                    if (_fromCurrency == "usd" && _usdBalance >= _amount) { _usdBalance -= _amount; }
                    else if (_fromCurrency == "eur" && _eurBalance >= _amount) { _eurBalance -= _amount; }
                    else if (_fromCurrency == "rub" && _rubBalance >= _amount) { _rubBalance -= _amount; }
                    else
                    {
                        Console.WriteLine("Ошибка: недостаточно средств на балансе.");
                        continue;
                    }

                    if (_toCurrency == "usd") _usdBalance += _convertedAmount;
                    else if (_toCurrency == "eur") _eurBalance += _convertedAmount;
                    else if (_toCurrency == "rub") _rubBalance += _convertedAmount;

                    Console.WriteLine($"Успешная конвертация! Вы получили {_convertedAmount:F2} {_toCurrency.ToUpper()}");
                }
                else
                {
                    Console.WriteLine("Ошибка: неизвестная команда.");
                }
            }
        }

        private static void ForeachPracticeArray()
        {
            float[] numbers = {1.24f, 1.43f, 23.3f,98.4f, 11.3f};

            Array.Sort(numbers);
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }

        private static void ForeachPracticeList()
        {
            /*string[] _cities = { "Москва", "Лондон", "Нью-Йорк", "Париж", "Берлин" };

            foreach (var city in _cities)
            {
                Console.WriteLine(city);
            }*/
            
            /*int[] _numbers = {4, 7, 10, 23, 18, 21};
            int _countNumber = 0;
            
            foreach (var item  in _numbers)
            {
                if (item % 3 == 0)
                {
                    _countNumber++;
                } 
            }
            Console.WriteLine(_countNumber);*/

            
            /*List<string> _words = new List<string> { "яблоко", "банан", "ананас", "груша", "персик" };
            string _longestWord = "";

            foreach (var word in _words)
            {
                if (word.Length > _longestWord.Length)
                {
                    _longestWord = word;
                }
            }
            Console.WriteLine(_longestWord);*/
        }
        
    }
}