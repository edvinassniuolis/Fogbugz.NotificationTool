using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutePY
{
    public class CaseWorker
    {
        public static void Parse(User user, Querry querry)
        {
            // User user = new User("Danny Gelber", @"edvinas.sniuolis@markmonitor.com", @"5ac&h#HAyEfR");
             //user.PrintData();

             //Querry querry = new Querry(QuerryColumns.OpenedBy);

             PythonBuilder pyBuilder = new PythonBuilder(StringBuilder.GetPythonExePath(StringBuilder.GetBuildPath()), 
                                                         StringBuilder.GetCrawlerPath(), 
                                                         StringBuilder.GetExportPath());

             pyBuilder.SetArguments(user.Username, user.Email, user.Password, querry.QuerryColumn);
             pyBuilder.BuildCMD();

             Console.WriteLine("Value received from script: " + pyBuilder.GetResult());
             Console.WriteLine("\ndone");


            //Console.ReadKey();
        }
    }
}
