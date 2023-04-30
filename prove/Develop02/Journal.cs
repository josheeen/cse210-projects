using System;

class Journal
{
    public List<Entry> entries = new List<Entry>();
    public void ShowJournal()
    {
        for (int entry = 0; entry < entries.Count; entry++)
        {
            entries[entry].ShowEntry();
        }
    }
}