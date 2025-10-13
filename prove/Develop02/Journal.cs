class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    public void AppendEntry(Entry e)
    {
        _entryList.Add(e);
    }

    public void Display()
    {
        Console.WriteLine("--- (Full Journal) ---");
        foreach (Entry e in _entryList)
        {
            e.Display();
            Console.WriteLine("-------------");
        }
    }
}