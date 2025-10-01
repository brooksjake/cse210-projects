public class Resume()
{
    public String _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }
        
}