namespace LibrarySystem;
public class Book : IComparable<Book>
{
    private string _Title;
    private string _Author;
    private string _ISBN;
    private int _YearPublished;
    public string Title {
        get => _Title;
        set
        {
            _Title = value;
        }
    }
    public string Author
    {
        get => _Author;
        set
        {
            _Author = value;
        }
    }
    public string ISBN {
        get => _ISBN;
        set
        {
            _ISBN = value;
        }
    }
    public int YearPublished
    {
        get => _YearPublished;
        set
        {
            if(value >= 1000 && value <= DateTime.Now.Year)
            {
                _YearPublished = value;
            } 
        }
    }

    public Book()
    {
        _Title = string.Empty;
        _Author = string.Empty;
        _ISBN = string.Empty;
        _YearPublished = DateTime.Now.Year;
    }

    public Book(string title, string author, string isbn, int yearPublished)
    {
        _Title = title;
        _Author = author;
        _ISBN = isbn;
        _YearPublished = yearPublished;
    }

    public Book(string title, string author)
    {
        _Title = title;
        _Author = author;
        _ISBN = string.Empty;
        _YearPublished = DateTime.Now.Year;
    }

    public override bool Equals(object obj)
    {
        if(obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Book otherBook = (Book) obj;
        return _ISBN == otherBook.ISBN;
    }

    public override int GetHashCode()
    {
        return ISBN == null ? 0 : ISBN.GetHashCode();
    }

    public int CompareTo(Book other)
    {
        if(other == null) return 1;
        return _YearPublished.CompareTo(other._YearPublished);
    }

    public bool isBookAfterYear(int year)
    {
        if(_YearPublished > year) return true;
        return false;
    }

}