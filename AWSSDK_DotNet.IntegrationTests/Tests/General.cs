using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.S3;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon;
using Amazon.Runtime;
using System.Collections.Generic;
using System.Reflection;
using Amazon.Runtime.Internal.Auth;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml;
using Amazon.Runtime.Internal.Settings;
using System.IO;
using ThirdParty.Json.LitJson;
using Amazon.Runtime.Internal.Util;


namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class General
    {
        [TestMethod]
        public void TestPersistenceManagerDecryptionFail()
        {
            var settingsType = "IntegTests";
            var fakeAccessKey = "FAKEKEY";
            var storeFolder = PersistenceManager.GetSettingsStoreFolder();
            var jsonFile = Path.Combine(storeFolder, settingsType + ".json");
            var uniqueKey = DateTime.Now.ToFileTime().ToString();

            var allSettings = PersistenceManager.Instance.GetSettings(settingsType);
            var settings = allSettings.NewObjectSettings(uniqueKey);
            settings[SettingsConstants.AccessKeyField] = fakeAccessKey;
            PersistenceManager.Instance.SaveSettings(settingsType, allSettings);

            Assert.IsTrue(File.Exists(jsonFile));

            try
            {
                PushGarbageData(fakeAccessKey, jsonFile, uniqueKey);

                using (UtilityMethods.SetLogging(LoggingOptions.SystemDiagnostics, ResponseLoggingOption.Never))
                {
                    var listener = UtilityMethods.AttachListener();

                    allSettings = PersistenceManager.Instance.GetSettings(settingsType);
                    settings = allSettings[uniqueKey];
                    Assert.IsFalse(settings.Keys.Contains(SettingsConstants.AccessKeyField));

                    // check that we logged the error message and key
                    var loggedMessages = listener.AccumulatedLog;
                    Assert.IsTrue(loggedMessages.Contains(uniqueKey));
                    Assert.IsTrue(loggedMessages.Contains(SettingsConstants.AccessKeyField));
                }
            }
            finally
            {
                File.Delete(jsonFile);
            }
        }

        private static void PushGarbageData(string fakeAccessKey, string jsonFile, string uniqueKey)
        {
            var jsonText = File.ReadAllText(jsonFile);
            var json = JsonMapper.ToObject(jsonText);

            // storing clear data into encrypted field
            json[uniqueKey][SettingsConstants.AccessKeyField] = fakeAccessKey;
            jsonText = json.ToJson(prettyPrint: true);
            File.WriteAllText(jsonFile, jsonText);
        }

        [TestMethod]
        public void TestClientDispose()
        {
            IAmazonS3 client;
            using (client = new AmazonS3Client())
            {
                var response = client.ListBuckets();
                Assert.IsNotNull(response);
                Assert.IsNotNull(response.ResponseMetadata);
                Assert.IsNotNull(response.ResponseMetadata.RequestId);
                Assert.IsFalse(string.IsNullOrEmpty(response.ResponseMetadata.RequestId));
            }

            AssertExtensions.ExpectException(() => client.ListBuckets(), typeof(ObjectDisposedException));
        }

        public void TestExpiringCredentials()
        {
            // test that non-expired credentials work
            TestExpireOffset(returnExpiredCredentials: false);

            // test that expired credentials do not work
            TestExpireOffset(returnExpiredCredentials: true);


            // test that various dates work
            TestExpire(DateTime.Now, expectFailure: true);
            TestExpire(DateTime.UtcNow, expectFailure: true);

            // 1 minute offset
            var epsilon = TimeSpan.FromMinutes(1);

            TestExpire(DateTime.Now + epsilon, expectFailure: false);
            TestExpire(DateTime.UtcNow + epsilon, expectFailure: false);
            TestExpire(DateTime.Now - epsilon, expectFailure: true);
            TestExpire(DateTime.UtcNow - epsilon, expectFailure: true);
        }

        private static void TestExpireOffset(bool returnExpiredCredentials)
        {
            TimeSpan expireOffset;
            if (returnExpiredCredentials)
                expireOffset = TimeSpan.FromHours(-1);
            else
                expireOffset = TimeSpan.FromHours(6);

            var creds = new ProxyRefreshingAWSCredentials(expireOffset);
            TestCredentials(creds, returnExpiredCredentials);
        }
        private static void TestExpire(DateTime expire, bool expectFailure)
        {
            var creds = new ProxyRefreshingAWSCredentials(expire);
            TestCredentials(creds, expectFailure);
        }


        private static void TestCredentials(ProxyRefreshingAWSCredentials creds, bool expectFailure)
        {
            using (var client = new AmazonS3Client(creds))
            {
                try
                {
                    client.ListBuckets();
                    Assert.IsFalse(expectFailure);
                }
                catch (AmazonClientException ace)
                {
                    Assert.IsTrue(expectFailure);
                    Assert.IsNotNull(ace);
                    Assert.IsNotNull(ace.Message);
                    Assert.IsTrue(ace.Message.IndexOf("already") >= 0);
                }
            }
        }

        private class ProxyRefreshingAWSCredentials : RefreshingAWSCredentials
        {
            private TimeSpan expireOffset;
            private DateTime? expireValue = null;

            public ProxyRefreshingAWSCredentials()
                : this(TimeSpan.FromHours(6))
            { }
            public ProxyRefreshingAWSCredentials(TimeSpan expireOffset)
            {
                this.expireOffset = expireOffset;
            }
            public ProxyRefreshingAWSCredentials(DateTime expireValue)
            {
                this.expireValue = expireValue;
            }

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                var credentials = UtilityMethods.CreateTemporaryCredentials();
                var ic = credentials.GetCredentials();

                DateTime expiration;
                if (expireValue.HasValue)
                {
                    expiration = expireValue.Value;
                }
                else
                {
                    var now = DateTime.Now;
                    expiration = now + expireOffset;
                }

                return new CredentialsRefreshState(ic, expiration);
            }
        }

        // This test verifies that all service clients are able to
        // correctly handle clock skew errors.
        // By default it only tests a small subset of services.
        [TestMethod]
        public void TestClockSkewCorrection()
        {
            VerifyClockSkewSetting();

            bool allPassed = true;
            foreach (var clientTest in clientTests)
            {
                try
                {
                    TestClient(clientTest.Client, clientTest.Method, clientTest.Request);
                    Console.WriteLine("Client test succeeded");
                }
                catch
                {
                    Console.WriteLine("Client test FAILED");
                    allPassed = false;
                }
            }

            Assert.IsTrue(allPassed);
        }

        private static void VerifyClockSkewSetting()
        {
            var clockSkewSetting = AWSConfigs.CorrectForClockSkew;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var doc = new System.Xml.XmlDocument();
            doc.Load(config.FilePath);
            var awsNode = doc.SelectSingleNode("//aws");
            var attribute = awsNode.Attributes["correctForClockSkew"];
            var attributeValueText = attribute.Value;
            bool configClockSkewSetting;
            Assert.IsTrue(bool.TryParse(attributeValueText, out configClockSkewSetting));
            Assert.AreEqual(clockSkewSetting, configClockSkewSetting);
        }

        private static void TestServiceCallForClockSkew(Action action)
        {
            var oldCorrectClockSkew = AWSConfigs.CorrectForClockSkew;
            var oldClockSkewCorrection = AWSConfigs.ClockOffset;

            try
            {
                // Enable clock skew correction
                AWSConfigs.CorrectForClockSkew = true;

                // Make call to possibly set the offset
                action();

                // Determine if skew exists
                var skewCorrection = AWSConfigs.ClockOffset;
                var skewExists = skewCorrection > TimeSpan.Zero;

                if (skewExists)
                {
                    Console.WriteLine("Clock skew exists, offset is " + AWSConfigs.ClockOffset);

                    // If skew exists, test that disabling correction results in an error
                    AWSConfigs.CorrectForClockSkew = false;
                    AssertExtensions.ExpectException(action);
                }
                else
                {
                    Console.WriteLine("No clock skew found");

                    // If no skew exists, set invalid skew correction and
                    // verify an exception is thrown before the invalid correction is
                    // corrected by the SDK

                    // Do this twice, once for positive offset and once for negative

                    SetClockSkewCorrection(IncorrectPositiveClockSkewOffset);
                    action();
                    Assert.AreNotEqual(IncorrectPositiveClockSkewOffset, AWSConfigs.ClockOffset);

                    SetClockSkewCorrection(IncorrectNegativeClockSkewOffset);
                    action();
                    Assert.AreNotEqual(IncorrectNegativeClockSkewOffset, AWSConfigs.ClockOffset);
                }
            }
            finally
            {
                AWSConfigs.CorrectForClockSkew = oldCorrectClockSkew;
                SetClockSkewCorrection(oldClockSkewCorrection);
            }
        }

        // ClientTest helpers
        private bool ClientExists(IEnumerable<Type> types, string client)
        {
            return types.Any(t => t.FullName.IndexOf(client, StringComparison.OrdinalIgnoreCase) >= 0);
        }
        internal Type FindClient(string clientName)
        {
            var allTypes = (typeof(AWSConfigs).Assembly.GetTypes());
            var clientType = allTypes.FirstOrDefault(t => t.FullName.IndexOf(clientName, StringComparison.Ordinal) >= 0);
            return clientType;
        }
        private void TestClient(string clientName, string methodName, object request)
        {
            Type clientType = FindClient(clientName);
            if (clientType == null)
            {
                Console.WriteLine("Could not find client [{0}], skipping test", clientName);
                return;
            }

            Console.WriteLine("Testing client: " + clientType.FullName);
            var client = Activator.CreateInstance(clientType, null) as IDisposable;

            // Optionally modify client config
            //var config = GetConfig(client);
            //config.UseHttp = true;

            using (client)
            {
                Action action = GetClientAction(client, methodName, request);

                // Optionally log the signer type
                //var signer = GetSigner(client);
                //Console.WriteLine("Signer: " + signer.GetType().FullName);

                TestServiceCallForClockSkew(action);
            }
        }
        private class ClientTest
        {
            public string Client { get; set; }
            public string Method { get; set; }
            public object Request { get; set; }
        }
        private static List<ClientTest> clientTests = new List<ClientTest>
        {
            // Partial list of clients to test
            new ClientTest { Client = "AmazonCognitoSyncClient", Method = "ListIdentityPoolUsage", Request = new Amazon.CognitoSync.Model.ListIdentityPoolUsageRequest { MaxResults = 1 } },
            new ClientTest { Client = "AmazonEC2Client", Method = "DescribeKeyPairs" },
            new ClientTest { Client = "AmazonDynamoDBClient", Method = "ListTables" },
            new ClientTest { Client = "AmazonS3Client", Method = "ListBuckets" },
            new ClientTest { Client = "AmazonGlacierClient", Method = "ListVaults" },
            new ClientTest { Client = "AmazonIdentityManagementServiceClient", Method = "ListGroups" },
            new ClientTest { Client = "AmazonImportExportClient", Method = "ListJobs" },
        };

        // Reflection helpers
        public static TimeSpan IncorrectPositiveClockSkewOffset = TimeSpan.FromHours(26);
        public static TimeSpan IncorrectNegativeClockSkewOffset = TimeSpan.FromHours(-1);
        public static void SetClockSkewCorrection(TimeSpan value)
        {
            var property = typeof(AWSConfigs).GetProperty("ClockOffset");
            property.SetValue(null, value, null);
        }
        private AbstractAWSSigner GetSigner(object client)
        {
            var signerProperty = typeof(AmazonServiceClient).GetProperty("Signer", BindingFlags.Instance | BindingFlags.NonPublic);
            var signer = signerProperty.GetValue(client, null) as AbstractAWSSigner;
            return signer;
        }
        private ClientConfig GetConfig(object client)
        {
            var configProperty = typeof(AmazonServiceClient).GetProperty("Config", BindingFlags.Instance | BindingFlags.NonPublic);
            var config = configProperty.GetValue(client, null) as ClientConfig;
            return config;

        }
        private static Action GetClientAction(object client, string methodName, object request)
        {
            Type requestType = typeof(AmazonWebServiceRequest);
            Type clientType = client.GetType();
            MethodInfo method = null;
            ParameterInfo[] parameters;
            foreach (var m in clientType.GetMethods())
            {
                if (string.Equals(m.Name, methodName, StringComparison.OrdinalIgnoreCase))
                {
                    parameters = m.GetParameters();
                    if (parameters.Length == 1 && requestType.IsAssignableFrom(parameters[0].ParameterType))
                    {
                        method = m;
                        break;
                    }
                }
            }
            if (method == null)
                throw new InvalidOperationException("Cannot find method [" + methodName + "]");

            parameters = method.GetParameters();
            object[] inputs = request == null ? null : new object[] { request };
            if (inputs == null)
            {
                if (parameters.Length == 0)
                {
                    inputs = null;
                }
                else if (parameters.Length == 1)
                {
                    var input = Activator.CreateInstance(parameters[0].ParameterType);
                    inputs = new object[] { input };
                }
                else
                {
                    throw new InvalidOperationException("Method requires more than 1 input");
                }
            }
            Action action = () => method.Invoke(client, inputs);
            return action;
        }
    }
}
