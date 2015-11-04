using System;
using Microsoft.Build.Utilities;
using System.IO;

namespace CustomTasks
{
    public class UnityBuild : Task
    {
        public string Platform { get; set; }
        public string UnityExe { get; set; }
        public string DeploymentPath { get; set; }
        public string ProjectPath { get; set; }

        public override bool Execute()
        {
            if (string.IsNullOrEmpty(UnityExe))
                throw new ArgumentNullException("UnityExe");

            if (string.IsNullOrEmpty(DeploymentPath))
                throw new ArgumentNullException("DeploymentPath");

            if (string.IsNullOrEmpty(ProjectPath))
                throw new ArgumentNullException("ProjectPath");

            if (string.IsNullOrEmpty(Platform))
                throw new ArgumentNullException("Platform");

            var buildPath = String.Format(@"{0}{1}{2}{1}{3}", DeploymentPath, Path.DirectorySeparatorChar, @"unity", @"build");
            Environment.SetEnvironmentVariable("UNITYBUILDPATH", buildPath);

            if (Platform.Equals("android", StringComparison.InvariantCultureIgnoreCase))
            {
                return ExecuteAndroid();
            }
            else if (Platform.Equals("ios64", StringComparison.InvariantCultureIgnoreCase))
            {
                return ExecuteIos64();
            }
            else if (Platform.Equals("ios32", StringComparison.InvariantCultureIgnoreCase))
            {
                return ExecuteIos32();
            }
            throw new ArgumentException("Invalid Platform");
        }

        private bool ExecuteAndroid()
        {
            var command = string.Format(@"-quit -batchmode -projectPath {0} -executeMethod BuildTools.Android -logFile {1}", ProjectPath, string.Format(@"{0}{1}{2}{1}{3}{1}log-android.txt", DeploymentPath, Path.DirectorySeparatorChar, @"unity", @"build"));
            UnityPackage.ExecuteUnityCommand(UnityExe, command);
            return true;
        }

        private bool ExecuteIos64()
        {
            var command = string.Format(@"-quit -batchmode -projectPath {0} -executeMethod BuildTools.Ios64 -logFile {1}", ProjectPath, string.Format(@"{0}{1}{2}{1}{3}{1}log-ios64.txt", DeploymentPath, Path.DirectorySeparatorChar, @"unity", @"build"));
            UnityPackage.ExecuteUnityCommand(UnityExe, command);
            return true;
        }

        private bool ExecuteIos32()
        {
            var command = string.Format(@"-quit -batchmode -projectPath {0} -executeMethod BuildTools.IosMono -logFile {1}", ProjectPath, string.Format(@"{0}{1}{2}{1}{3}{1}log-ios-mono.txt", DeploymentPath, Path.DirectorySeparatorChar, @"unity", @"build"));
            UnityPackage.ExecuteUnityCommand(UnityExe, command);
            return true;
        }
    }
}
