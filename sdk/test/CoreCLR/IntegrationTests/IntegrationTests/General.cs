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
using System.Threading.Tasks;
using Xunit;
using Amazon.DNXCore.IntegrationTests;


namespace Amazon.DNXCore.IntegrationTests
{
    
    public class General
    {
        [Fact]
        public async Task TestClientDispose()
        {
            IAmazonS3 client;
            using(client = TestBase.CreateClient<AmazonS3Client>())
            {
                var response = await client.ListBucketsAsync();
                Assert.NotNull(response);
                Assert.NotNull(response.ResponseMetadata);
                Assert.NotNull(response.ResponseMetadata.RequestId);
                Assert.False(string.IsNullOrEmpty(response.ResponseMetadata.RequestId));
            }

            //AssertExtensions.ExpectExceptionAsync<ObjectDisposedException>(client.ListBucketsAsync()).Wait();
            AssertExtensions.ExpectException<ObjectDisposedException>(() => client.ListBucketsAsync().Wait());
        }
        
        public async Task TestExpiringCredentials()
        {
            // test that non-expired credentials work
            await TestExpireOffset(returnExpiredCredentials: false);

            // test that expired credentials do not work
            await TestExpireOffset(returnExpiredCredentials: true);


            // test that various dates work
            await TestExpire(DateTime.Now, expectFailure: true);
            await TestExpire(DateTime.UtcNow, expectFailure: true);

            // 1 minute offset
            var epsilon = TimeSpan.FromMinutes(1);
            
            await TestExpire(DateTime.Now + epsilon, expectFailure: false);
            await TestExpire(DateTime.UtcNow + epsilon, expectFailure: false);
            await TestExpire(DateTime.Now - epsilon, expectFailure: true);
            await TestExpire(DateTime.UtcNow - epsilon, expectFailure: true);
        }

        private static async Task TestExpireOffset(bool returnExpiredCredentials)
        {
            TimeSpan expireOffset;
            if (returnExpiredCredentials)
                expireOffset = TimeSpan.FromHours(-1);
            else
                expireOffset = TimeSpan.FromHours(6);

            var creds = new ProxyRefreshingAWSCredentials(expireOffset);
            await TestCredentials(creds, returnExpiredCredentials);
        }
        private static async Task TestExpire(DateTime expire, bool expectFailure)
        {
            var creds = new ProxyRefreshingAWSCredentials(expire);
            await TestCredentials(creds, expectFailure);
        }


        private static async Task TestCredentials(ProxyRefreshingAWSCredentials creds, bool expectFailure)
        {
            using (var client = new AmazonS3Client(creds))
            {
                try
                {
                    await client.ListBucketsAsync();
                    Assert.False(expectFailure);
                }
                catch (AmazonClientException ace)
                {
                    Assert.True(expectFailure);
                    Assert.NotNull(ace);
                    Assert.NotNull(ace.Message);
                    Assert.True(ace.Message.IndexOf("already") >= 0);
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

        //[Fact]
        public void TestManualClockCorrection()
        {
            TestClients(TestServiceCallForManualClockCorrection);
        }

        // This test verifies that all service clients are able to
        // correctly handle clock skew errors.
        // By default it only tests a small subset of services.
        //[Fact]
        public void TestClockSkewCorrection()
        {
            TestClients(TestServiceCallForClockSkew);
        }

        private void TestClients(Action<ClockSkewTestContext> serviceCall)
        {
            bool allPassed = true;
            foreach (var clientTest in clientTests)
            {
                try
                {
                    TestClient(clientTest, serviceCall);
                    Console.WriteLine("Client test succeeded");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Client test FAILED: " + e);
                    allPassed = false;
                }
            }

            Assert.True(allPassed);
        }

        private class ClockSkewTestContext
        {
            public IClientConfig Config;
            public Action TestAction;
        }

        private static void TestServiceCallForManualClockCorrection(ClockSkewTestContext context)
        {
            var oldManualClockCorrection = AWSConfigs.ManualClockCorrection;
            var oldCorrectClockSkew = AWSConfigs.CorrectForClockSkew;
            var oldClockSkewCorrection = context.Config.ClockOffset;
            var oldUtcNowSource = GetUtcNowSource();

            try
            {
                AWSConfigs.CorrectForClockSkew = false;

                SetUtcNowSource(() => DateTime.UtcNow + IncorrectPositiveClockSkewOffset);
                AWSConfigs.ManualClockCorrection = null;
                AssertExtensions.ExpectException(context.TestAction);

                AWSConfigs.ManualClockCorrection = IncorrectPositiveClockSkewOffset.Negate();
                context.TestAction();

                SetUtcNowSource(() => DateTime.UtcNow + IncorrectNegativeClockSkewOffset);
                AWSConfigs.ManualClockCorrection = IncorrectNegativeClockSkewOffset.Negate();
                context.TestAction();

                AWSConfigs.ManualClockCorrection = TimeSpan.FromTicks(IncorrectNegativeClockSkewOffset.Negate().Ticks * 2);
                AssertExtensions.ExpectException(context.TestAction);

                AWSConfigs.ManualClockCorrection = TimeSpan.Zero;
                AssertExtensions.ExpectException(context.TestAction);
            }
            finally
            {
                AWSConfigs.ManualClockCorrection = oldManualClockCorrection;
                AWSConfigs.CorrectForClockSkew = oldCorrectClockSkew;
                SetClockSkewCorrection(context.Config, oldClockSkewCorrection);
                SetUtcNowSource(oldUtcNowSource);
            }
        }

        private static void TestServiceCallForClockSkew(ClockSkewTestContext context)
        {
            var oldCorrectClockSkew = AWSConfigs.CorrectForClockSkew;
            var oldClockSkewCorrection = context.Config.ClockOffset;
            var oldUtcNowSource = GetUtcNowSource();

            try
            {
                AWSConfigs.CorrectForClockSkew = true;
                SetClockSkewCorrection(context.Config, TimeSpan.Zero);
                context.TestAction();
                Assert.True(context.Config.ClockOffset == TimeSpan.Zero);

                SetClockSkewCorrection(context.Config, IncorrectPositiveClockSkewOffset);
                context.TestAction();
                Assert.NotStrictEqual(IncorrectPositiveClockSkewOffset, context.Config.ClockOffset);

                SetClockSkewCorrection(context.Config, IncorrectNegativeClockSkewOffset);
                context.TestAction();
                Assert.NotStrictEqual(IncorrectNegativeClockSkewOffset, context.Config.ClockOffset);

                Console.WriteLine("Simulating positive clock skew");
                SetUtcNowSource(() => DateTime.UtcNow + IncorrectPositiveClockSkewOffset);
                AWSConfigs.CorrectForClockSkew = false;
                AssertExtensions.ExpectException(context.TestAction);

                AWSConfigs.CorrectForClockSkew = true;
                SetClockSkewCorrection(context.Config, TimeSpan.Zero);
                context.TestAction();

                Console.WriteLine("Simulating negative clock skew");
                SetUtcNowSource(() => DateTime.UtcNow + IncorrectNegativeClockSkewOffset);
                AWSConfigs.CorrectForClockSkew = true;
                SetClockSkewCorrection(context.Config, TimeSpan.Zero);
                context.TestAction();

                AWSConfigs.CorrectForClockSkew = false;
                AssertExtensions.ExpectException(context.TestAction);
            }
            finally
            {
                AWSConfigs.CorrectForClockSkew = oldCorrectClockSkew;
                SetClockSkewCorrection(context.Config, oldClockSkewCorrection);
                SetUtcNowSource(oldUtcNowSource);
            }
        }

        private void TestClient(ClientTest ct, Action<ClockSkewTestContext> serviceCall)
        {
            var clientType = ct.ClientType;

            if (clientType == null)
            {
                Console.WriteLine("Could not find client [{0}], skipping test", clientType);
                return;
            }

            Console.WriteLine("Testing client: " + clientType.FullName);
            var region = AWSConfigs.RegionEndpoint ?? RegionEndpoint.USEast1;
            var client = Activator.CreateInstance(clientType, region) as IDisposable;

            // Optionally modify client config
            var config = GetConfig(client);
            //config.UseHttp = true;

            using (client)
            {
                Action action = GetClientAction(client, ct.Method, ct.Request);

                // Optionally log the signer type
                //var signer = GetSigner(client);
                //Console.WriteLine("Signer: " + signer.GetType().FullName);

                serviceCall(new ClockSkewTestContext
                {
                    TestAction = action,
                    Config = config
                });
            }
        }
        private class ClientTest
        {
            public Type ClientType { get; set; }
            public string Method { get; set; }
            public object Request { get; set; }
        }
        private static List<ClientTest> clientTests = new List<ClientTest>
        {
            // Partial list of clients to test
            new ClientTest
            {
                ClientType = typeof(Amazon.CognitoSync.AmazonCognitoSyncClient),
                Method = "ListIdentityPoolUsage",
                Request = new Amazon.CognitoSync.Model.ListIdentityPoolUsageRequest { MaxResults = 1 },
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
        private static Func<DateTime> GetUtcNowSource()
        {
            var field = typeof(AWSConfigs).GetField("utcNowSource", BindingFlags.Static | BindingFlags.NonPublic);
            return (Func<DateTime>)field.GetValue(null);
        }
        private static void SetUtcNowSource(Func<DateTime> source)
        {
            var field = typeof(AWSConfigs).GetField("utcNowSource", BindingFlags.Static | BindingFlags.NonPublic);
            field.SetValue(null, source);
        }
        public static void SetClockSkewCorrection(IClientConfig config, TimeSpan value)
        {
            var func = typeof(CorrectClockSkew).GetTypeInfo().GetMethod("SetClockCorrectionForEndpoint", BindingFlags.Static | BindingFlags.NonPublic);
            func.Invoke(null, new object[] {config.DetermineServiceURL(), value});
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
