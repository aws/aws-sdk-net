using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceClientGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace AWSSDK_DotNet35.UnitTests
{
    public static class Utils
    {
        public static ServiceModel LoadServiceModel(string modelName, string customizationsName)
        {
#if BCL45
            using (var stream = typeof(Utils).Assembly.GetManifestResourceStream("AWSSDK_DotNet45.UnitTests..........generator.ServiceModels." + modelName))
#else
            using (var stream = typeof(Utils).Assembly.GetManifestResourceStream("AWSSDK_DotNet35.UnitTests..........generator.ServiceModels." + modelName))
#endif

            using (var streamReader = new StreamReader(stream))
            {
                StreamReader customizationsReader = null;
                try
                {
                    if (!string.IsNullOrEmpty(customizationsName))
                    {
#if BCL45
                        var customizationsStream = typeof(Utils).Assembly.GetManifestResourceStream("AWSSDK_DotNet45.UnitTests..........generator.ServiceModels." + customizationsName);
#else
                        var customizationsStream = typeof(Utils).Assembly.GetManifestResourceStream("AWSSDK_DotNet35.UnitTests..........generator.ServiceModels." + customizationsName);
#endif
                        if (customizationsStream != null)
                            customizationsReader = new StreamReader(customizationsStream);
                    }

                    return new ServiceModel(streamReader, customizationsReader);
                }
                finally
                {
                    if(customizationsReader != null)
                        customizationsReader.Dispose();
                }
            }
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

#if BCL45
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
            var resource = FindResourceName(resourceName);
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
        public static string FindResourceName(string partialName)
        {
            return FindResourceName(s => s.IndexOf(partialName, StringComparison.OrdinalIgnoreCase) >= 0).Single();
        }
        public static IEnumerable<string> FindResourceName(Predicate<string> match)
        {
            Assembly assembly = typeof(Utils).Assembly;
            var allResources = assembly.GetManifestResourceNames();
            foreach (var resource in allResources)
            {
                if (match(resource))
                    yield return resource;
            }
        }
    }
}
