using AdministrationUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationUI
{
    public class DataAccessEvent
    {
        public void SaveEvent(List<CreateEvent> events)
        {
            string[] dates = new string[events.Count];
            for (int i = 0; i < dates.Length; i++)
            {
                CreateEvent eventer = events[i];
                string date = eventer.DateTime + '|' + eventer.Titel + '|' + eventer.Price + '|' + eventer.Description;
                dates[i] = date;
            }
            File.WriteAllLines(FilePaths.eventPath, dates);
        }

        public List<CreateEvent> LoadEvent()
        {
            List<CreateEvent> events = new List<CreateEvent>();
            try
            {
                string[] eventFile = File.ReadAllLines(FilePaths.eventPath);
                foreach (string line in eventFile)
                {
                    string[] field = line.Split('|');
                    events.Add(new CreateEvent(field[0], field[1], decimal.Parse(field[2]), field[3]));
                }
            }
            catch
            {

            }
            return events;
        }
    }
}
