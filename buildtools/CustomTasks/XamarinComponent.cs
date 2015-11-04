using Microsoft.Build.Utilities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YamlDotNet.Serialization;
using System.Diagnostics;
using Microsoft.Build.Framework;


namespace CustomTasks
{
    public class XamarinComponent : Task
    {
        public string ComponentRootPath { get; set; }
        public string NugetExe { get; set; }
        public string ComponentsExe { get; set; }
        public string DevEnvExe { get; set; }
        public string NugetRestoreLocation { get; set; }

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

                var version = yamlObject["version"] as string;
                var id = yamlObject["id"] as string;

                var componentName = string.Format(@"{0}-{1}.xam", id, version);

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

                    RestoreNuget(Path.GetFullPath(NugetExe), NugetRestoreLocation, sampleSolutionFile);

                    CompileSample(DevEnvExe, sampleSolutionFile);
                }
                PackageComponent(ComponentsExe, componentPath, componentName);
            }
            return true;
        }

        private static void CompileSample(string devenvExe, string solutionFile)
        {
            Process process = new Process();
            process.StartInfo.FileName = devenvExe;
            process.StartInfo.Arguments = string.Format(@"/Rebuild Debug {0}", solutionFile);
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
                delegate(object sender, DataReceivedEventArgs e)
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
                throw new Exception(string.Format(@"error building solution {0}", solutionFile));
            }
        }

        private static void RestoreNuget(string nugetExe, string nugetRestoreLocation, string solutionFile)
        {
            Console.WriteLine("restore location = " + nugetRestoreLocation);
            Process process = new Process();
            process.StartInfo.FileName = nugetExe;

            process.StartInfo.Arguments = string.Format(@"restore -Source ""{0}"" {1}", nugetRestoreLocation, solutionFile);
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
                delegate(object sender, DataReceivedEventArgs e)
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
                throw new Exception(string.Format(@"error restoring nuget for {0}", solutionFile));
            }
        }

        private static void PackageComponent(string componentExe, string componentDirectory, string componentName)
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
                delegate(object sender, DataReceivedEventArgs e)
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
                throw new Exception(string.Format(@"error packaging {0}", componentDirectory));
            }

            if (!CheckXamPackage(componentDirectory, componentName))
            {
                throw new Exception(string.Format(@"error packaging {0}", componentDirectory));
            }
        }

        private static bool CheckXamPackage(string componentDirectory, string componentName)
        {
            var componentFullPath = Path.Combine(componentDirectory, componentName);
            Console.WriteLine(@"checking if the component exists {0}", componentFullPath);
            return File.Exists(componentFullPath);
        }


    }
}
