using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationUI.Models
{
    public static class FilePaths
    {
        static string temp = "MagtenBølleBookingsAndEvents";
        static string path = System.Environment.CurrentDirectory;
        public static string bookingPath = path.Substring(0, path.LastIndexOf(temp) + temp.Length) + "\\Files\\Bookings.txt";
        public static string eventPath = path.Substring(0, path.LastIndexOf(temp) + temp.Length) + "\\Files\\Events.txt";
    }
}
