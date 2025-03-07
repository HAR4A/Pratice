namespace Practice;

public class StackPractice
{
    public void UndoFunctionality()
    {
        Stack<string> actions = new Stack<string>();

        while (true)
        {
            Console.WriteLine("Для отмены введите 'undo', для выхода введите 'exit' ");
            Console.WriteLine("------------------");
            Console.WriteLine("Введите текст для записи");
            
            string userInput = Console.ReadLine();


            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Выход из программы");
                break;
            }
            if (userInput.ToLower() == "undo")
            {
                if (actions.Count > 0)
                {
                    actions.Pop();
                    Console.WriteLine("Последнее действие было отменено");
                }
                else
                {
                    Console.WriteLine("Нет действий для отмены");
                }
            }
            else
            {
                actions.Push(userInput);
            }
            
            Console.WriteLine("Текущий текст: " + string.Join(" ", actions));
        }
    }
    
    public void ReverseString()
    {
        Stack<char> userString = new Stack<char>();
        
        Console.WriteLine("Введите строку, которую хотите перевернуть: ");
        string userInput = Console.ReadLine();
        
        foreach (char c in userInput)
        {
            userString.Push(c);    
        }

        Console.WriteLine("Перевернутая строка: ");

        while (userString.Count > 0)
        {
            Console.Write(userString.Pop());
        }
        Console.WriteLine();
    }
}