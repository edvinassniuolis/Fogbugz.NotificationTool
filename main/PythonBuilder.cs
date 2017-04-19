using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutePY
{
    public class PythonBuilder
    {
        private static bool success = true;
        private string args;
        private string result;

        private ProcessStartInfo myProcessStartInfo;
        private Process myProcess;

        public string PythonExePath { get; set; }
        public string CrawlerPath { get; set; }
        public string ExportPath { get; set; }

        public PythonBuilder(string pythonExePath, string crawlerPath, string exportPath)
        {
            PythonExePath = pythonExePath;
            CrawlerPath = crawlerPath;
            ExportPath = exportPath;
        }

        public void BuildCMD()
        {
            myProcessStartInfo = new ProcessStartInfo(PythonExePath);

            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;
            myProcessStartInfo.Arguments = CrawlerPath + args;
            

            StartProcess();
        }

        public void StartProcess()
        {
            myProcess = new Process();
            myProcess.StartInfo = myProcessStartInfo;
            myProcess.Start();

            Console.WriteLine("Parsing starting...\n");

            result = StringBuilder.GetExecutedPyValue(myProcess);

            myProcess.WaitForExit();
            myProcess.Close();
        }

        public void SetArguments(string userName, string userEmail, string password, string query)
        {
            args = " " + userEmail + " " + password + " " + userName + " " + query + " " + ExportPath;
        }

        public string GetResult()
        {
            return result;
        }
        public string GetArgs()
        {
            return args;
        }
        public static bool CheckSuccess()
        {
            return success;
        }
    }
}
