using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExecutePY
{
    public class FileEditor
    {
        public static void Expand(string filename)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(filename);
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                using (XmlWriter writer = XmlWriter.Create(filename, settings))
                {
                    document.WriteTo(writer);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("{0} File was not found", filename);
              //  LogWriter.AddToLog(ex.ToString());
            }
        }
    }
}
