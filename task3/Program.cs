

namespace task3
{

    class Book
    {
        public string title;
        public string author;
        public string ISBN;
        public bool availability;

        public Book(string title, string author, string iSBN, bool availability)
        {
            this.title = title;
            this.author = author;
            ISBN = iSBN;
            this.availability = availability;
        }
    }
    class library
    {
        public List<Book> books = new();
        public List<Book> Borrow = new();
        public bool AddBook( Book book)
        {
            books.Add(book);
            

            return true;
        }

        public bool searchBook(string title)
        {
           
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == title)
                {


                    return true;
                }
                
            }
            return false;
        }
        
        public bool BorrowBook(string title)
        {
            
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == title )
                {
                    
                    Borrow.Add(books[i]);
                    Console.WriteLine($"Book '{title}' borrowed successfully.");
                    return true;
                }
            }
            Console.WriteLine($"Book '{title}' not found.");
            return false;    
        }

        public bool ReturnBook(Book x)
        {
            
            for (int i = 0; i < Borrow.Count; i++)
            {
                if (Borrow[i].title == x.title && Borrow[i].author == x.author && Borrow[i].ISBN == x.ISBN)
                {
                    books.Add(x);
                    Borrow.Remove(x);
                    Console.WriteLine($"Book {x.title} returned to library");
                    return true;
                }

            }
            Console.WriteLine($"Book '{x.title}' not found in borrowed list.");
            return false;
        }
        
            
        
    }



          internal class Program
    {
        static void Main(string[] args)
        {
            library library = new library();

            
            Book book1=new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565" ,true);
            Book book2=new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084", true);
            Book book3=new Book("1984", "George Orwell", "9780451524935",true);
            
            library.AddBook(book1);
            Console.WriteLine("Book added successfully.");
            library.AddBook(book2);
            Console.WriteLine("Book added successfully.");
            library.AddBook(book3);
            Console.WriteLine("Book added successfully.");
            




            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("The Great Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); 
            
            
            Console.WriteLine("Returning books...");
            library.ReturnBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", true));
            library.ReturnBook(new Book("Sapiens", "George Orwell", "9780451524935",true)); 

           


        }
    }
}
