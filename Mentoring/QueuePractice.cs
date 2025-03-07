namespace Practice;

public class QueuePractice
{
    public void PrintQueueDocuments()
    {
        Queue<string> documentsQueue = new Queue<string>();

        Console.WriteLine("Добавляйте документы для печати. Напишите 'print' для печати: ");

        while (true)
        {
            Console.Write("Введите название документа: ");
            string documentName = Console.ReadLine();

            if (documentName.ToLower() == "print") 
                break;

            documentsQueue.Enqueue(documentName);
        }
        
        Console.WriteLine("\nПечать документов: ");
        while (documentsQueue.Count > 0)
        {
            string printedDocument = documentsQueue.Dequeue();
            Console.WriteLine($"Документ печатается: {printedDocument}");
        }

        Console.WriteLine("Очередь пуста. Все документы распечатаны");
    }

    public void OutputOfRequests()
    {
        Queue<string> usersRequests = new Queue<string>();

        Console.WriteLine("Добавляйте строки в очередь записей. Напишите 'history' для вывода последних 5 запросов: ");
        
        while (true)
        {
            Console.WriteLine("Введите запрос: ");
            string request = Console.ReadLine();

            if (request.ToLower() == "history")
            {
                Console.WriteLine("\nПоследние 5 запросов: ");

                if (usersRequests.Count == 0)
                {
                    Console.WriteLine("История пуста");
                }
                else
                {
                    foreach (var latestRequest in usersRequests)
                    {
                        Console.WriteLine(latestRequest);
                    }
                }
                continue;
            }
            
            usersRequests.Enqueue(request);

            if (usersRequests.Count > 5)
            {
                usersRequests.Dequeue();
            }
        }
    }
}