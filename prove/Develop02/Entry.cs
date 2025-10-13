class Entry()
{
    public String _givenPrompt;
    public String _date;
    public String _text;

    public void Display()
    {
        Console.WriteLine(_date + " | " + _givenPrompt);
        Console.WriteLine(_text);
    }
}