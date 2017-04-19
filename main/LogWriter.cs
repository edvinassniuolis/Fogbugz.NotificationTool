using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutePY
{
    public class LogWriters
    {
        private static string path = @"C:\Users\esniuolis\Documents\Visual Studio 2015\Projects\Tesx\Tesx\log.txt";
        private static string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public static void AddToLog(string text)
        {
            if (!File.Exists(path))
            {
                File.Create(path);

            }
            else if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine("{0} {1} {2}", date, text.ToUpper(), Environment.NewLine);
                    tw.Close();
                }
            }
        }
    }
}
