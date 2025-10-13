using System;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {

        Boolean loop = false;
        Journal journal;
        parseFileContentsToJournal(out journal);

        do
        {
            displayMenu();
            int userpick = int.Parse(Console.ReadLine());

            if (userpick == 1)
            {
                // give prompt, receive new entry, save new entry to journal list and csv file
                Entry newentry;
                writeNewEntry(out newentry);
                journal.AppendEntry(newentry);
                SaveEntryToFile(newentry);
                loop = true;
            }
            else if (userpick == 2)
            {
                // print all entries in journal
                journal.Display();
                loop = true;
            }
            else if (userpick == 3)
            {
                // quit
                loop = false;
            }
            else
            {
                // if userpick != 1,2, or 3
                Console.WriteLine("invalid query entered, try again");
                loop = true;
            }


        } while (loop);

    }

    static void displayMenu()
    {
        Console.WriteLine("====== JOURNAL ======");
        Console.WriteLine("Instructions:\n1. be given a prompt\n2. show journal contents\n3. quit");
    }

    static void parseFileContentsToJournal(out Journal j)
    {
        j = new Journal();
        

    }

    static void writeNewEntry(out Entry e)
    {
        e = new Entry();
        Prompt p = new Prompt();
        e._givenPrompt = p.GivePrompt();
        Console.Write("Entry: ");
        e._text = Console.ReadLine();
        e._date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    static void SaveEntryToFile(Entry e)
    {
        
    }

}