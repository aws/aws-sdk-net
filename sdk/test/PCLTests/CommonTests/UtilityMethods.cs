using System;
using System.Globalization;
using System.IO;
using System.Text;

using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime;
using PCLStorage;

namespace CommonTests
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
                        Name = "sdk-accountid-lookup" + DateTime.Now.Ticks
                    };
                    using(var snsClient = new AmazonSimpleNotificationServiceClient(TestSettings.Credentials, TestSettings.Endpoint))
                    {
                        var response = snsClient.CreateTopicAsync(createRequest).Result;
                        var tokens = response.TopicArn.Split(':');

                        _accountId = tokens[4];

                        snsClient.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = response.TopicArn }).Wait();
                    }
                }

                return _accountId;
            }
        }

        public static AWSCredentials CreateTemporaryCredentials()
        {
            using (var sts = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient(TestSettings.Credentials, TestSettings.Endpoint))
            {
                var creds = sts.GetSessionTokenAsync(new Amazon.SecurityToken.Model.GetSessionTokenRequest()).Result.Credentials;
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

        public static T WaitUntilSuccess<T>(Func<T> loadFunction, int sleepSeconds = 5, int maxWaitSeconds = 300)
        {
            T result = default(T);
            WaitUntil(() =>
            {
                try
                {
                    result = loadFunction();
                    return true;
                }
                catch
                {
                    return false;
                }
            }, sleepSeconds, maxWaitSeconds);
            return result;
        }
        public static void WaitUntilSuccess(Action action, int sleepSeconds = 5, int maxWaitSeconds = 300)
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
            }, sleepSeconds, maxWaitSeconds);
        }
        public static void WaitUntil(Func<bool> matchFunction, int sleepSeconds = 5, int maxWaitSeconds = 300)
        {
            if (sleepSeconds < 0) throw new ArgumentOutOfRangeException("sleepSeconds");
            if (maxWaitSeconds < 0) throw new ArgumentOutOfRangeException("maxWaitSeconds");

            var sleepTime = TimeSpan.FromSeconds(sleepSeconds);
            var maxTime = TimeSpan.FromSeconds(maxWaitSeconds);
            var endTime = DateTime.Now + maxTime;

            while(DateTime.Now < endTime)
            {
                if (matchFunction())
                    return;
                Sleep(sleepTime);
            }

            throw new TimeoutException(string.Format("Wait condition was not satisfied for {0} seconds", maxWaitSeconds));
        }

        public static void WriteFile(string path, string contents)
        {
            var file = FileSystem.Current.GetFileFromPathAsync(path).Result;
            file.WriteAllTextAsync(contents).Wait();

            //string fullPath = Path.GetFullPath(path);
            //new DirectoryInfo(Path.GetDirectoryName(fullPath)).Create();
            //File.WriteAllText(fullPath, contents);
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
            return name + new Random().Next();
        }

        public static void Sleep(TimeSpan ts)
        {
            if (ts.Ticks < 0)
                throw new ArgumentOutOfRangeException("ts");

            new System.Threading.ManualResetEvent(false).WaitOne(ts);
        }
    }
}
