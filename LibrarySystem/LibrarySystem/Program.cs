using LibrarySystem;


public class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new Book
            {
                Title = "Lập trình C# cơ bản",
                Author = "Nguyễn Văn A",
                ISBN = "978-1234567890",
                YearPublished = 2024
            },
            new Book
            {
                Title = "Học OOP với C#",
                Author = "Độ Mee She",
                ISBN = "978-0987654321",
                YearPublished = 2021
            }, 
            new Book
            {
                Title = "C# nâng cao và thực hành",
                Author = "Lê Văn C",
                ISBN = "978-1122334455",
                YearPublished = 2022
            }
        };
        
        foreach(var book in books) {
            System.Console.WriteLine($"{book.Title} - {book.Author} - {book.ISBN} - {book.YearPublished}");
        }
        books.Sort();

        foreach (var book in books)
        {
            Console.WriteLine($"{book.YearPublished} - {book.Title}");
        }

        Dictionary<string, int> countBook = new Dictionary<string, int>();
        foreach(var book in books)
        {
            if(countBook.ContainsKey(book.Author))
            {
                countBook[book.Author]++; 
            } else
            {
                countBook[book.Author] = 1;
            }
        }

    }   
}