using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutePY
{
    public class StringBuilder
    {

        public static string GetBuildPath()
        {
            return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", ""); ;
        }
        public static string GetPythonExePath(string path)
        {
            return path + "\\DO_NOT_CHANGE\\Python27\\python.exe";
        }
        public static string GetCrawlerPath()
        {
            return @"DO_NOT_CHANGE\Parameters\crawler.py";
        }
        public static string GetExecutedPyValue(Process myProcess)
        {
            StreamReader myStreamReader = myProcess.StandardOutput;
            return myStreamReader.ReadLine();
        }
        public static string GetExportPath()
        {
            return @"DO_NOT_CHANGE\Parameters\crawler.xml";
        }
    }
}
