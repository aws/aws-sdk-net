using System;
using System.Linq;

using Amazon.S3;
using Amazon;
using Amazon.Runtime;
using System.Collections.Generic;
using System.Reflection;
using Amazon.Runtime.Internal.Auth;
using System.Collections.Specialized;
using System.Xml;
using NUnit.Framework;
using CommonTests.Framework;


namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class General
    {
        [Test]
        public void TestClientDispose()
        {
            IAmazonS3 client;
            using(client = TestBase.CreateClient<AmazonS3Client>())
            {
                var response = client.ListBucketsAsync().Result;
                Assert.IsNotNull(response);
                Assert.IsNotNull(response.ResponseMetadata);
                Assert.IsNotNull(response.ResponseMetadata.RequestId);
                Assert.IsFalse(string.IsNullOrEmpty(response.ResponseMetadata.RequestId));
            }

            //AssertExtensions.ExpectExceptionAsync<ObjectDisposedException>(client.ListBucketsAsync()).Wait();
            AssertExtensions.ExpectException<ObjectDisposedException>(() => client.ListBucketsAsync().Wait());
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
                    client.ListBucketsAsync().Wait();
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
        [Test]
        public void TestClockSkewCorrection()
        {
            bool allPassed = true;
            foreach (var clientTest in clientTests)
            {
                try
                {
                    TestClient(clientTest);
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

        private void TestClient(ClientTest ct)
        {
            var clientType = ct.ClientType;

            if (clientType == null)
            {
                Console.WriteLine("Could not find client [{0}], skipping test", clientType);
                return;
            }

            Console.WriteLine("Testing client: " + clientType.FullName);
            var region = ct.Region ?? TestRunner.RegionEndpoint;
            var client = Activator.CreateInstance(clientType, TestRunner.Credentials, region) as IDisposable;

            // Optionally modify client config
            //var config = GetConfig(client);
            //config.UseHttp = true;

            using (client)
            {
                Action action = GetClientAction(client, ct.Method, ct.Request);

                // Optionally log the signer type
                //var signer = GetSigner(client);
                //Console.WriteLine("Signer: " + signer.GetType().FullName);

                TestServiceCallForClockSkew(action);
            }
        }
        private class ClientTest
        {
            public Type ClientType { get; set; }
            public string Method { get; set; }
            public object Request { get; set; }
            public RegionEndpoint Region { get; set; }
        }
        private static List<ClientTest> clientTests = new List<ClientTest>
        {
            // Partial list of clients to test
            new ClientTest
            {
                ClientType = typeof(Amazon.CognitoSync.AmazonCognitoSyncClient),
                Method = "ListIdentityPoolUsage",
                Request = new Amazon.CognitoSync.Model.ListIdentityPoolUsageRequest { MaxResults = 1 },
                Region = RegionEndpoint.USEast1
            },
            new ClientTest { ClientType = typeof(Amazon.EC2.AmazonEC2Client), Method = "DescribeKeyPairs" },
            new ClientTest { ClientType = typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), Method = "ListTables" },
            new ClientTest { ClientType = typeof(AmazonS3Client), Method = "ListBuckets" },
            new ClientTest { ClientType = typeof(Amazon.Glacier.AmazonGlacierClient), Method = "ListVaults" },
            new ClientTest { ClientType = typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), Method = "ListGroups" },
            new ClientTest { ClientType = typeof(Amazon.ImportExport.AmazonImportExportClient), Method = "ListJobs" },
        };

        // Reflection helpers
        public static TimeSpan IncorrectPositiveClockSkewOffset = TimeSpan.FromHours(26);
        public static TimeSpan IncorrectNegativeClockSkewOffset = TimeSpan.FromHours(-1);
        public static void SetClockSkewCorrection(TimeSpan value)
        {
            var property = typeof(AWSConfigs).GetTypeInfo().GetDeclaredProperty("ClockOffset");
            property.SetValue(null, value, null);
        }
        private AbstractAWSSigner GetSigner(object client)
        {
            var signerProperty = typeof(AmazonServiceClient).GetTypeInfo().GetDeclaredProperty("Signer");
            var signer = signerProperty.GetValue(client, null) as AbstractAWSSigner;
            return signer;
        }
        private ClientConfig GetConfig(object client)
        {
            var configProperty = typeof(AmazonServiceClient).GetTypeInfo().GetDeclaredProperty("Config");
            var config = configProperty.GetValue(client, null) as ClientConfig;
            return config;

        }
        private static Action GetClientAction(object client, string methodName, object request)
        {
            Type requestType = typeof(AmazonWebServiceRequest);
            Type clientType = client.GetType();
            MethodInfo method = null;
            ParameterInfo[] parameters;
            foreach (var m in clientType.GetRuntimeMethods())
            {
                if (string.Equals(m.Name, methodName, StringComparison.OrdinalIgnoreCase))
                {
                    parameters = m.GetParameters();
                    if (parameters.Length == 1 && requestType.GetTypeInfo().IsAssignableFrom(parameters[0].ParameterType.GetTypeInfo()))
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
