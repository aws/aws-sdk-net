using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime;
using ThirdParty.MD5;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Utils
{
    public static class UtilityMethods
    {
        public const string SDK_TEST_PREFIX = "aws-net-sdk";

        static string _accountId;

        /// <summary>
        /// There is not a good way to get account id. This hack creates
        /// a topic gets the account id out of the ARN and then deletes the topic.
        /// </summary>
        public static string AccountId
        {
            get
            {
                if(_accountId == null)
                {
                    var createRequest = new CreateTopicRequest
                    {
                        Name = "sdk-accountid-lookup" + DateTime.UtcNow.Ticks
                    };
                    using(var snsClient = new AmazonSimpleNotificationServiceClient())
                    {
                        var response = snsClient.CreateTopic(createRequest);
                        var tokens = response.TopicArn.Split(':');

                        _accountId = tokens[4];

                        snsClient.DeleteTopic(new DeleteTopicRequest { TopicArn = response.TopicArn });
                    }
                }

                return _accountId;
            }
        }

        public static AWSCredentials CreateTemporaryCredentials()
        {
            using (var sts = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient())
            {
                var creds = sts.GetSessionToken().Credentials;
                return creds;
            }
        }

        public static Stream CreateStreamFromString(string s)
        {
            return CreateStreamFromString(s, new MemoryStream());
        }
        
        public static Stream CreateStreamFromString(string s, Stream stream)
        {        
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static string GetResourceText(string resourceName)
        {
            using (StreamReader reader = new StreamReader(GetResourceStream(resourceName)))
            {
                return reader.ReadToEnd();
            }
        }

        public static Stream GetResourceStream(string resourceName)
        {
            Assembly assembly = typeof(UtilityMethods).Assembly;
            var resource = FindResourceName(resourceName);
            Stream stream = assembly.GetManifestResourceStream(resource);
            return stream;
        }

        public static string FindResourceName(string partialName)
        {
            return FindResourceName(s => s.IndexOf(partialName, StringComparison.OrdinalIgnoreCase) >= 0).Single();
        }

        public static IEnumerable<string> FindResourceName(Predicate<string> match)
        {
            Assembly assembly = typeof(UtilityMethods).Assembly;
            var allResources = assembly.GetManifestResourceNames();
            foreach (var resource in allResources)
            {
                if (match(resource))
                    yield return resource;
            }
        }

        /// <summary>
        /// Helper function to format a byte array into string
        /// </summary>
        /// <param name="data">The data blob to process</param>
        /// <param name="lowercase">If true, returns hex digits in lower case form</param>
        /// <returns>String version of the data</returns>
        public static string ToHex(byte[] data, bool lowercase)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString(lowercase ? "x2" : "X2", CultureInfo.InvariantCulture));
            }

            return sb.ToString();
        }

        public static byte[] ComputeSHA256(byte[] data)
        {
            return new SHA256CryptoServiceProvider().ComputeHash(data);
        }

        public static void  CompareFiles(string file1, string file2)
        {
            byte[] file1MD5 = computeHash(file1);
            byte[] file2MD5 = computeHash(file2);

            Assert.AreEqual(file1MD5.Length, file2MD5.Length);
            for (int i = 0; i < file1MD5.Length; i++)
            {
                Assert.AreEqual(file1MD5[i], file2MD5[i], "MD5 of files do not match");
            }
        }

        private static byte[] computeHash(string file)
        {
            Stream fileStream = File.OpenRead(file);
            byte[] fileMD5 = new MD5Managed().ComputeHash(fileStream);
            fileStream.Close();
            return fileMD5;
        }

        public static T WaitUntilSuccess<T>(Func<T> loadFunction, int sleepSeconds = 5, int maxWaitSeconds = 300)
        {
            T result = default(T);            
            WaitUntil(() =>
            {            
                try
                {
                    result = loadFunction();
                    return result != null;
                }
                catch
                {                
                    return false;
                }
            }, sleepSeconds, maxWaitSeconds);
            
            return result;
        }

        public static void WaitUntilException(Action action, int sleepSeconds = 5, int maxWaitSeconds = 300)
        {        
            WaitUntil(() =>
            {
                try
                {
                    action();
                    return false;
                }
                catch (Exception)
                {
                    throw;
                }
            }, sleepSeconds, maxWaitSeconds);
        }

        public static void WaitUntilSuccess(Action action, int sleepSeconds = 5, int maxWaitSeconds = 300)
        {
            if (sleepSeconds < 0) throw new ArgumentOutOfRangeException("sleepSeconds");
            WaitUntilSuccess(action, new ListSleeper(sleepSeconds * 1000), maxWaitSeconds);
        }

        public static void WaitUntilSuccess(Action action, ListSleeper sleeper, int maxWaitSeconds = 300)
        {
            WaitUntil(() =>
            {
                try
                {
                    action();
                    return true;
                }
                catch
                {
                    return false;
                }
            }, sleeper, maxWaitSeconds);
        }

        public static void WaitUntil(Func<bool> matchFunction, int sleepSeconds = 5, int maxWaitSeconds = 300)
        {
            if (sleepSeconds < 0) throw new ArgumentOutOfRangeException("sleepSeconds");
            WaitUntil(matchFunction, new ListSleeper(sleepSeconds * 1000), maxWaitSeconds);
        }

        public static void WaitUntil(Func<bool> matchFunction, ListSleeper sleeper, int maxWaitSeconds = 300)
        {
            if (maxWaitSeconds < 0) throw new ArgumentOutOfRangeException("maxWaitSeconds");

            var maxTime = TimeSpan.FromSeconds(maxWaitSeconds);
            var endTime = DateTime.UtcNow + maxTime;

            while(DateTime.UtcNow < endTime)
            {
                if (matchFunction())
                    return;
                sleeper.Sleep();
            }

            throw new TimeoutException(string.Format("Wait condition was not satisfied for {0} seconds", maxWaitSeconds));
        }

        /// <summary>
        /// Runs an async function until the function either succeeds, throws an exception, or times out.
        /// If the async function doesn't succeed, an exception is thrown.
        /// </summary>
        /// <param name="asyncFunc"> Async function  </param>
        /// <param name="timeout"> Timeout </param>
        /// <exception cref="TimeoutException"> Thrown when the <paramref name="asyncFunc"/> runs out of <paramref name="timeout"/></exception>
        public static async Task WaitUntilAsync(Func<Task> asyncFunc, TimeSpan timeout)
        {
            // Create a CancellationTokenSource with the specified timeout duration
            using (var cts = new CancellationTokenSource(timeout))
            {
                // Get the token from CancellationTokenSource
                var cancellationToken = cts.Token;

                // Start the async operation and wait for either the task to complete or the timeout
                var task = asyncFunc();
                var completedTask = await Task.WhenAny(task, Task.Delay(-1, cancellationToken));

                // If the operation completed, await the task to observe any exceptions thrown
                if (completedTask == task)
                {
                    await task;
                    return;
                }

                // If the operation was canceled due to timeout, throw an exception
                throw new TimeoutException("The operation has timed out.");
            }
        }

        public static void WriteFile(string path, string contents)
        {
            string fullPath = Path.GetFullPath(path);
            new DirectoryInfo(Path.GetDirectoryName(fullPath)).Create();
            File.WriteAllText(fullPath, contents);
        }
        public static void GenerateFile(string path, long size)
        {
            string contents = GenerateTestContents(size);
            WriteFile(path, contents);
        }

        public static string GenerateTestContents(long size)
        {
            StringBuilder sb = new StringBuilder();
            for (long i = 0; i < size; i++)
            {
                char c = (char)('a' + (i % 26));
                sb.Append(c);
            }
            string contents = sb.ToString();
            return contents;
        }

        public static string GenerateName()
        {
            return GenerateName(SDK_TEST_PREFIX + "-");
        }

        public static string GenerateName(string name)
        {
            return name + DateTime.UtcNow.Ticks;
        }
        public class ListSleeper
        {
            private int attempt;
            private int[] millisecondsList;

            public ListSleeper(params int[] millisecondsList)
            {
                if (millisecondsList.Length < 1)
                    throw new ArgumentException("There must be at least one sleep period in millisecondsList.");

                attempt = 0;
                this.millisecondsList = millisecondsList;
            }

            public void Sleep()
            {
                // if there are more attempts than array elements just keep using the last one
                var index = Math.Min(attempt, millisecondsList.Length - 1);
                Thread.Sleep(millisecondsList[index]);
                attempt++;
            }

            /// <summary>
            /// Create a new exponential growth sleeper. The following sleeper will be created:
            /// ListSleeper(500, 1000, 2000, 5000)
            /// </summary>
            /// <returns>A new ListSleeper with exponential growth</returns>
            public static ListSleeper Create()
            {
                return new ListSleeper(500, 1000, 2000, 5000);
            }
        }
    }
}
