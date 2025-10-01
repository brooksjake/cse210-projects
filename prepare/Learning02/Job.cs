public class Job()
{
    public String _company;
    public String _jobTitle;
    public String _startyear;
    public String _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startyear}-{_endYear}");
    }
}