using MyFirstEfCoreApp.Date;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var db = new AppDbContext())
        {
            var books = db.Books;
            foreach (var book in books.Include(b => b.Author))
            {
                Console.WriteLine($"{book.Author.Name} - {book.Title} выпущена в {book.PublishedOn} году");
            }
        }
    }
}