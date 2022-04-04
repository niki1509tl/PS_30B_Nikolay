using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace UserLogin
{
    static public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
            + LoginValidation.Username + ";"
            + LoginValidation.CurrentUserRole + ";"
            + activity;
            currentSessionActivities.Add(activityLine);

            if (File.Exists("Log.txt") == true)
            {
                StreamWriter outputFile = new StreamWriter("Log.txt", append: true);
                outputFile.WriteLine(activityLine);
                outputFile.Close();
            }
        }
        static public IEnumerable<string> GetActivities()
        {
            List<string> fileLines = new List<string>();
            foreach(String s in File.ReadLines("Log.txt"))
            {
                fileLines.Add(s);
            }
            return fileLines;
        }
        static public IEnumerable<string> GetCurrentSessionActivities(String filter)
        {
            List<string> filteredActivities = 
                (
                 from activity 
                 in currentSessionActivities 
                 where activity.Contains(filter)
                 select activity
                 ).ToList();
            return filteredActivities;
        }
    }
}
