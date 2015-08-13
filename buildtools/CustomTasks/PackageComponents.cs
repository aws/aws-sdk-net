using Microsoft.Build.Utilities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YamlDotNet.Serialization;
using System.Diagnostics;

namespace CustomTasks
{
    public class PackageComponents : Task
    {
        public string ComponentRootPath { get; set; }
        public string NugetExe { get; set; }
        public string ComponentsExe { get; set; }

        public override bool Execute()
        {
            if (string.IsNullOrEmpty(ComponentRootPath))
                throw new ArgumentNullException(ComponentRootPath);

            var directories = Directory.GetDirectories(ComponentRootPath);
            foreach (var dir in directories)
            {
                var componentPath = Path.GetFullPath(dir);
                Log.LogMessage("component {0}", componentPath);

                string yamlFile = Path.Combine(componentPath, "component.yaml");

                var yamlStringReader = new StringReader(File.ReadAllText(yamlFile, Encoding.UTF8));

                var deserializer = new Deserializer();
                var yamlObject = deserializer.Deserialize(yamlStringReader) as Dictionary<object, object>;

                if (yamlObject == null)
                    throw new Exception(string.Format("Unable to deserialize {0}", yamlFile));

                var samples = yamlObject["samples"] as List<object>;

                if (samples == null)
                    throw new Exception(string.Format("unable to find the samples in component {0}", yamlFile));

                var currentWorkingDirectory = Directory.GetCurrentDirectory();

                foreach (var sample in samples)
                {
                    var s = sample as Dictionary<object, object>;
                    var solutionFile = s["path"] as string;

                    //location of solution file is relative to the component.yaml file
                    Directory.SetCurrentDirectory(componentPath);
                    var sampleSolutionFile = Path.GetFullPath(solutionFile);
                    Log.LogMessage("found solution file {0}", sampleSolutionFile);
                    Directory.SetCurrentDirectory(currentWorkingDirectory);
                    
                    RestoreNuget(Path.GetFullPath(NugetExe), sampleSolutionFile);
                }
                PackageComponent(ComponentsExe, componentPath);
            }
            return true;
        }

        private static void RestoreNuget(string nugetExe, string solutionFile)
        {
            Process process = new Process();
            process.StartInfo.FileName = nugetExe;
            process.StartInfo.Arguments = string.Format(@"restore {0}", solutionFile);
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.EnableRaisingEvents = true;
            StringBuilder buffer = new StringBuilder();
            process.OutputDataReceived += new DataReceivedEventHandler
            (
                delegate(object sender, DataReceivedEventArgs e)
                {
                    Console.WriteLine(e.Data);
                    buffer.AppendLine(e.Data);
                }
            );
            process.ErrorDataReceived += new DataReceivedEventHandler
            (
                delegate(object sender,DataReceivedEventArgs e)
                {
                    Console.WriteLine(e.Data);
                    buffer.AppendLine(e.Data);
                }
            );
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();

            

        }

        private static void PackageComponent(string componentExe, string componentDirectory)
        {
            Console.WriteLine(@"component location {0}", componentExe);
            Process process = new Process();
            process.StartInfo.FileName = componentExe;
            process.StartInfo.Arguments = string.Format(@"package {0}", componentDirectory);
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.EnableRaisingEvents = true;
            StringBuilder buffer = new StringBuilder();
            process.OutputDataReceived += new DataReceivedEventHandler
            (
                delegate(object sender, DataReceivedEventArgs e)
                {
                    Console.WriteLine(e.Data);
                    buffer.AppendLine(e.Data);
                }
            );
            
            process.ErrorDataReceived += new DataReceivedEventHandler
            (
                delegate(object sender,DataReceivedEventArgs e)
                {
                    Console.WriteLine(e.Data);
                    buffer.AppendLine(e.Data);
                }
            );

            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();

            if (process.ExitCode != 0)
            { 
                throw new Exception(string.Format(@"error packaging {0}",componentDirectory));
            }
        }

    }
}
