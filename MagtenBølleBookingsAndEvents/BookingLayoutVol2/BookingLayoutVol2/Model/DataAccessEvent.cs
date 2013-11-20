using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLayoutVol2.Model
{
    public class DataAccessEvent
    {
        public List<Events> LoadEvent()
        {
            List<Events> events = new List<Events>();
            try
            {
                string[] eventFile = File.ReadAllLines(FilePaths.eventPath);
                foreach (string line in eventFile)
                {
                    string[] field = line.Split('|');
                    events.Add(new Events(field[0], field[1], decimal.Parse(field[2]), field[3]));
                }
            }
            catch
            {

            }
            return events;
        }
    }
}
