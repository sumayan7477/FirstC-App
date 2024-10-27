namespace MyNETWebApp.Models
{
    public class Book
    {
        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Price { get; set; }

        // Constructor
        public Book(string title, string author, string isbn, string price)
        {
            Title = title;
            Author = author;
            Price = price;
            ISBN = isbn;
        }

        // Method to get author details
        public string GetDetails()
        {
            return $"Title: {Title}\n Author: {Author}\n Price: {Price} \n ISBN = {ISBN}";
        }
    }

    public class AuthorInfo
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Nationality { get; set; }

        public AuthorInfo(string name, string email, string nationality)
        {
            Name = name;
            Email = email;
            Nationality = nationality;
        }

        // Method to get author details
        public string GetDetails()
        {
            return $"Author: {Name}\nEmail: {Email}\nNationality: {Nationality}";
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating an instance of Author
            AuthorInfo author = new AuthorInfo("Jane Doe", "jane.doe@example.com", "American");

            Book book = new Book ("Calculus","Jane Doe","12233","50");

            // Displaying author details
            Console.WriteLine(author.GetDetails());
            Console.WriteLine(book.GetDetails());
        }
    }
}
