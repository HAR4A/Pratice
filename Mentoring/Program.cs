namespace Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DictionaryPractice dictionary = new DictionaryPractice();
            dictionary.ManageShoppingList();
        }
    }
    
    public class DictionaryPractice
    {
        public void ManageShoppingList()
        {
            Dictionary<string, int> products  = new Dictionary<string, int>();

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Добавить товар и его кол-во");
                Console.WriteLine("2 - Показать весь список покупок");
                Console.WriteLine("3 - Обновлять кол-во товара");
                Console.WriteLine("4 - Удалить товар");
                Console.WriteLine("5 - Выход");
                Console.Write("Ваш выбор: ");
                
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        AddItemAndTheyAmount(products);
                        break;
                    case "2":
                        ShowAllItemsList(products);
                        break;
                    case "3":
                        UpdateItemAmount(products);
                        break;
                    case "4":
                        RemoveItemFromList(products);
                        break;
                    case "5":
                        Console.WriteLine("Выход из программы...");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод, повторите попытку");
                        break;
                }
            }
        }

        private void AddItemAndTheyAmount(Dictionary<string, int> products)
        {
            Console.WriteLine("Введите название товара: ");
            string name = Console.ReadLine().ToLower();
            
            Console.WriteLine("Введите количество товара: ");
            
            if (int.TryParse(Console.ReadLine(), out int amount) && amount > 0)
            {
                products.Add(name, amount);
                Console.WriteLine("Товар успешно добавлен");
            }
            else if (products.ContainsKey(name) && products.ContainsValue(amount))
            {
                Console.WriteLine("Такой товар уже существует");
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректное число.");
            }
        }

        private void ShowAllItemsList(Dictionary<string, int> products)
        {
            Console.WriteLine("\nСписок товаров:");
            if (products.Count <= 0)
            {
                Console.WriteLine("Список товаров пока пуст :(");
            }
            else
            {
                foreach (var items in products)
                {
                    Console.WriteLine($"Товар - {items.Key}, Количество - {items.Value}");
                }
            }
        }
        
        private void UpdateItemAmount(Dictionary<string, int> products)
        {
            Console.WriteLine("Введите название товара");
            string name = Console.ReadLine().ToLower();

            if (products.ContainsKey(name))
            {
                Console.WriteLine("Введите новое количество: ");
                if (int.TryParse(Console.ReadLine(), out int newAmountValue) && newAmountValue > 0)
                {
                    products[name] = newAmountValue;
                    Console.WriteLine($"Новое количество товара: {newAmountValue}");
                }
                else
                {
                    Console.WriteLine("Введите корректное число");
                }
            }
            else
            {
                Console.WriteLine("Товар не найден");
            }
        }

        private void RemoveItemFromList(Dictionary<string, int> products)
        {
            Console.WriteLine("Введите название товара, который хотите удалить: ");
            string name = Console.ReadLine().ToLower();
            
            if (products.ContainsKey(name))
            {
                Console.WriteLine("Вы действительно хотите удалить этот товар?");
                string answer = Console.ReadLine().ToLower();

                if (answer == "да")
                {
                    if (products.Remove(name))
                    {
                        Console.WriteLine("Товар успешно удален");
                    }   
                }
                else if(answer == "нет")
                {
                    Console.WriteLine("Отмена команды");
                }
            }
        }
    }
}