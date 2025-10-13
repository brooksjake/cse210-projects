class Prompt()
{
    public Random _randomGen = new Random();
    public List<String> _promptList = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public String GivePrompt()
    {
        int pick = _randomGen.Next(1, _promptList.Count());
        return _promptList[pick];
    }
}