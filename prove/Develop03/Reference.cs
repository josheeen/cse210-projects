public class Reference {
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _secondVerse;

    //Constructor for 1 verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
    }
    //Constructor for 2 verses
    public Reference(string book, int chapter, int verse, int secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _secondVerse = secondVerse;
    }
    public string GetReference()
    {
        if (_secondVerse == 0)
        {
            return ($"{_book} {_chapter}:{_firstVerse} ");
        }
        else
        {
            return ($"{_book} {_chapter}:{_firstVerse}-{_secondVerse}");
        }
        
    }
    
}