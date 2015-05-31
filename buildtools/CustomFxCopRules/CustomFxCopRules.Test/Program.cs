using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CustomFxCopRules.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var expectedIssues = 6 + 14; // 6 for MD5, 12 for ILogger
            var issuesXpath = "//Issue";
            var reportPath = Path.GetFullPath("report.xml");
            var customRulesPath = Path.GetFullPath(Environment.CurrentDirectory + @"..\..\..\..\bin\Debug\CustomFxCopRules.dll");
            var arguments = string.Format(@"/file:""{0}"" /rule:""{0}"" /out:""{1}""",
                customRulesPath, reportPath);

            if (File.Exists(reportPath))
                File.Delete(reportPath);

            var process = Process.Start(new ProcessStartInfo
            {
                FileName = @"C:\Program Files (x86)\Microsoft Fxcop 10.0\FxCopCmd.exe",
                Arguments = arguments,
                WorkingDirectory = Environment.CurrentDirectory,
                UseShellExecute = false
            });
            process.WaitForExit();

            var report = new XmlDocument();
            report.Load(reportPath);
            var allIssues = report.SelectNodes(issuesXpath);
            if (allIssues.Count != expectedIssues)
                throw new InvalidDataException();

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
