//Task 1
public class Play : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    private bool disposed = false;

    public Play(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }

    ~Play()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
               
            }
            disposed = true;
        }
    }
}

//Task 2
public class Store : IDisposable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Type { get; set; }
    private bool disposed = false;

    public Store(string name, string address, string type)
    {
        Name = name;
        Address = address;
        Type = type;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
            }
            disposed = true;
        }
    }

    ~Store()
    {
        Dispose(false);
    }
}

//Task 3
class Program
{
    static void Main(string[] args)
    {
        using (var play = new Play("Hamlet", "William Shakespeare", "Tragedy", 1600))
        {
            Console.WriteLine($"{play.Title}, {play.Author}, {play.Genre}, {play.Year}");
        }

        using (var store = new Store("SuperStore", "123 Main St", "Grocery"))
        {
            Console.WriteLine($"{store.Name}, {store.Address}, {store.Type}");
        }
    }
}