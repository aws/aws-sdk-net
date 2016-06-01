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
        // Unity command may intermittently fail with inability to access files
        // it need, and still exit with code 0. Allow retrying if the
        // application was not created.
        public bool RetryOnApplicationMissing { get; set; }

        private const int MaxTries = 5;
        private string APKLocation;
        private string IOS64BuildLocation;
        private string IOSMonoBuildLocation;

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

            APKLocation = Path.Combine(buildPath, "Android", "UnityTestRunner.apk");
            IOS64BuildLocation = Path.Combine(buildPath, "iOS64");
            IOSMonoBuildLocation = Path.Combine(buildPath, "iOSMono");

            if (Platform.Equals("android", StringComparison.InvariantCultureIgnoreCase))
            {
                return ExecuteAndroid(RetryOnApplicationMissing);
            }
            else if (Platform.Equals("ios64", StringComparison.InvariantCultureIgnoreCase))
            {
                return ExecuteIos64(RetryOnApplicationMissing);
            }
            else if (Platform.Equals("ios32", StringComparison.InvariantCultureIgnoreCase))
            {
                return ExecuteIos32(RetryOnApplicationMissing);
            }
            throw new ArgumentException("Invalid Platform");
        }

        private bool ExecuteAndroid(bool retry = false)
        {
            int tryCount = 0;
            bool success;
            do
            {
                var command = string.Format(@"-quit -batchmode -projectPath {0} -executeMethod BuildTools.Android -logFile {1}", ProjectPath, string.Format(@"{0}{1}{2}{1}{3}{1}log-android.txt", DeploymentPath, Path.DirectorySeparatorChar, @"unity", @"build"));
                UnityPackage.ExecuteUnityCommand(UnityExe, command);
                success = File.Exists(APKLocation);
                tryCount++;
            }
            while (retry && !success && tryCount <= MaxTries);
            return success;
        }

        private bool ExecuteIos64(bool retry = false)
        {
            int tryCount = 0;
            bool success;
            do
            {
                var command = string.Format(@"-quit -batchmode -projectPath {0} -executeMethod BuildTools.Ios64 -logFile {1}", ProjectPath, string.Format(@"{0}{1}{2}{1}{3}{1}log-ios64.txt", DeploymentPath, Path.DirectorySeparatorChar, @"unity", @"build"));
                UnityPackage.ExecuteUnityCommand(UnityExe, command);
                // Approximation of knowing if the app was created is checking
                // if the build directory exists and some subdirectories exist.
                success = Directory.Exists(IOS64BuildLocation) && (Directory.GetDirectories(IOS64BuildLocation).Length > 0);
                tryCount++;
            }
            while (retry && !success && tryCount <= MaxTries);
            return success;
        }

        private bool ExecuteIos32(bool retry = false)
        {
            int tryCount = 0;
            bool success;
            do
            {
                var command = string.Format(@"-quit -batchmode -projectPath {0} -executeMethod BuildTools.IosMono -logFile {1}", ProjectPath, string.Format(@"{0}{1}{2}{1}{3}{1}log-ios-mono.txt", DeploymentPath, Path.DirectorySeparatorChar, @"unity", @"build"));
                UnityPackage.ExecuteUnityCommand(UnityExe, command);
                // Approximation of knowing if the app was created is checking
                // if the build directory exists and some subdirectories exist.
                success = Directory.Exists(IOSMonoBuildLocation) && (Directory.GetDirectories(IOSMonoBuildLocation).Length > 0);
                tryCount++;
            }
            while (retry && !success && tryCount <= MaxTries);
            return success;
        }
    }
}
