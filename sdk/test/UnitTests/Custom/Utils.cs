using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceClientGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace AWSSDK_DotNet.UnitTests
{
    public static class Utils
    {
        public static ServiceModel LoadServiceModel(string service)
        {
            string repoRoot = Directory.GetCurrentDirectory();
            do
            {
                if (Directory.Exists(Path.Combine(repoRoot, "generator")))
                { 
                    break;
                }

                var directoryInfo = Directory.GetParent(repoRoot);
                repoRoot = directoryInfo != null ? directoryInfo.FullName : null;
            } while (repoRoot != null);

            string serviceModelDirectory = Path.Combine(repoRoot, "generator", "ServiceModels", service);

            string modelPath = GetLatestModelPath(serviceModelDirectory);
            string customizationsPath = Path.Combine(serviceModelDirectory, service + ".customizations.json");

            using (var streamReader = new StreamReader(modelPath))
            {
                StreamReader customizationsReader = null;
                if (File.Exists(customizationsPath))
                {
                    using (customizationsReader = new StreamReader(customizationsPath))
                    {
                        return new ServiceModel(streamReader, customizationsReader);
                    }
                }
                return new ServiceModel(streamReader, null);
            }
        }

        private static string GetLatestModelPath(string serviceDirectory)
        {
            string latestModelPath = "";
            if (Directory.Exists(serviceDirectory))
            {
                foreach (string modelName in Directory.GetFiles(serviceDirectory, "*.normal.json", SearchOption.TopDirectoryOnly))
                {
                    if (string.Compare(latestModelPath, modelName) < 0)
                    {
                        latestModelPath = modelName;
                    }
                }
            }

            if (latestModelPath == "") // try test services location
            {
                serviceDirectory = serviceDirectory.Replace("ServiceModels", "TestServiceModels");

                foreach (string modelName in Directory.GetFiles(serviceDirectory, "*.normal.json", SearchOption.TopDirectoryOnly))
                {
                    if (string.Compare(latestModelPath, modelName) < 0)
                    {
                        latestModelPath = modelName;
                    }
                }
            }

            if (string.IsNullOrEmpty(latestModelPath))
            {
                throw new FileNotFoundException("Failed to find a model file in " + serviceDirectory);
            }

            return latestModelPath;
        }

        public static Stream CreateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
        
        public static void AssertExceptionExpected(Action action)
        {
            AssertExceptionExpected(action, typeof(Exception));
        }

        public static T AssertExceptionExpected<T>(Action action) where T : Exception
        {
            return AssertExceptionExpected(action, typeof(T)) as T;
        }

        public static Exception AssertExceptionExpected(Action action, Type expectedExceptionType, string expectedExceptionMessage = null)
        {
            try
            {
                action();
                if (expectedExceptionType != null)
                {
                    Assert.Fail("Exception of type " + expectedExceptionType.FullName + " expected but not thrown!");
                }
                Console.WriteLine("Success, no exception expected or thrown");
                return null;
            }
            catch (Exception e)
            {
                if (expectedExceptionType == null)
                {
                    Assert.Fail("No exception expected, but exception thrown: " + e.ToString());
                }

                Type eType = e.GetType();
                if (!expectedExceptionType.IsAssignableFrom(eType))
                {
                    Assert.Fail("Expected exception of type " + expectedExceptionType.FullName + ", but thrown exception is of type " + eType.FullName + " : " + e.Message);
                }
                else if (
                    !string.IsNullOrEmpty(expectedExceptionMessage) &&
                    !string.Equals(expectedExceptionMessage, e.Message, StringComparison.OrdinalIgnoreCase))
                {
                    Assert.Fail("Expected exception message of [" + expectedExceptionType.FullName + "], but thrown exception has message of [" + e.Message + "]");
                }

                Console.WriteLine("Success, expected " + expectedExceptionType.FullName + ", thrown " + eType.FullName + ": " + e.Message);
                return e;
            }
        }

#if BCL
        public static async Task<Exception> AssertExceptionExpectedAsync(Func<Task> func, Type expectedExceptionType, string expectedExceptionMessage = null)
        {
            try
            {
                await func();
                if (expectedExceptionType != null)
                {
                    Assert.Fail("Exception of type " + expectedExceptionType.FullName + " expected but not thrown!");
                }
                Console.WriteLine("Success, no exception expected or thrown");
                return null;
            }
            catch (Exception e)
            {
                if (expectedExceptionType == null)
                {
                    Assert.Fail("No exception expected, but exception thrown: " + e.ToString());
                }

                Type eType = e.GetType();
                if (!expectedExceptionType.IsAssignableFrom(eType))
                {
                    Assert.Fail("Expected exception of type " + expectedExceptionType.FullName + ", but thrown exception is of type " + eType.FullName + " : " + e.Message);
                }
                else if (
                    !string.IsNullOrEmpty(expectedExceptionMessage) &&
                    !string.Equals(expectedExceptionMessage, e.Message, StringComparison.OrdinalIgnoreCase))
                {
                    Assert.Fail("Expected exception message of [" + expectedExceptionType.FullName + "], but thrown exception has message of [" + e.Message + "]");
                }

                Console.WriteLine("Success, expected " + expectedExceptionType.FullName + ", thrown " + eType.FullName + ": " + e.Message);
                return e;
            }
        }
#endif
        public static Stream GetResourceStream(string resourceName)
        {
            Assembly assembly = typeof(Utils).Assembly;
            var resource = FindResourceName(assembly, resourceName);
            if(resource == null)
            {
                assembly = Assembly.GetCallingAssembly();
                resource = FindResourceName(assembly, resourceName);
            }

            Stream stream = assembly.GetManifestResourceStream(resource);
            return stream;
        }
        public static string GetResourceText(string resourceName)
        {
            using (StreamReader reader = new StreamReader(GetResourceStream(resourceName)))
            {
                return reader.ReadToEnd();
            }
        }
        public static string FindResourceName(Assembly assembly, string partialName)
        {
            var resources = FindResourceName(assembly, s => s.IndexOf(partialName, StringComparison.OrdinalIgnoreCase) >= 0);
            if (resources.Any())
                return resources.Single();
            return null;
        }
        public static IEnumerable<string> FindResourceName(Assembly assembly, Predicate<string> match)
        {    
            var allResources = assembly.GetManifestResourceNames();
            foreach (var resource in allResources)
            {
                if (match(resource))
                    yield return resource;
            }
        }
    }
}
