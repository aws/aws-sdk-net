using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.SecurityToken.SAML;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [Trait("Category", "General")]
    [Collection("Serial")]
    public partial class General
    {
        private readonly string fakeData = "obviously-super-duper-fake-data";

        [Fact]
        // Test exception parsing with selected services
        public async Task TestExceptions()
        {
            using (var client = new Amazon.Lightsail.AmazonLightsailClient())
            {
                var ex = await Assert.ThrowsAsync<Amazon.Lightsail.Model.NotFoundException>(() =>
                    client.GetInstanceAsync(new Amazon.Lightsail.Model.GetInstanceRequest
                    {
                        InstanceName = fakeData
                    }));
                Assert.Equal(ErrorType.Unknown, ex.ErrorType);
            }

            using (var ddb = new Amazon.DynamoDBv2.AmazonDynamoDBClient())
            {
                var ex = await Assert.ThrowsAsync<Amazon.DynamoDBv2.Model.ResourceNotFoundException>(() =>
                    ddb.DescribeTableAsync("fakey-mcfake-table"));
                Assert.Equal(ErrorType.Unknown, ex.ErrorType);
            }

            using (var client = new Amazon.Batch.AmazonBatchClient())
            {
                var ex = await Assert.ThrowsAsync<Amazon.Batch.Model.ClientException>(() =>
                    client.UpdateComputeEnvironmentAsync(new Amazon.Batch.Model.UpdateComputeEnvironmentRequest
                    {
                        ComputeEnvironment = fakeData
                    }));
                Assert.Equal(ErrorType.Unknown, ex.ErrorType);
            }
        }

        // BinaryFormatter, S3PostUploadException, and AdfsAuthenticationControllerException are only
        // available on .NET Framework. BinaryFormatter was removed in .NET 8, and S3PostUploadException
        // and AdfsAuthenticationControllerException are defined in BCL-only (_bcl/) source folders.
#if NETFRAMEWORK
        [Fact]
        public void TestSerializingExceptions()
        {
            using(var client = new Amazon.S3.AmazonS3Client())
            {
                try
                {
                    var fakeBucketName = "super.duper.fake.bucket.name.123." + Guid.NewGuid().ToString();
                    client.ListObjects(fakeBucketName);
                }
                catch(AmazonS3Exception e)
                {
                    TestException(e);
                }

                var s3pue = CreateS3PostUploadException();
                TestException(s3pue);

                var doe = CreateDeleteObjectsException();
                TestException(doe);

                var aace = new AdfsAuthenticationControllerException("Message");
                TestException(aace);
            }
        }

        [Fact]
        public void TestSerializaingObjects()
        {
            DeleteObjectsResponse response = new DeleteObjectsResponse
            {
                DeletedObjects = new List<DeletedObject>
                {
                    new DeletedObject{ Key = "hello", VersionId ="version" },
                    new DeletedObject{ Key = "world", VersionId ="version" },
                    new DeletedObject{ Key = "!!!" ,  VersionId ="version"}
                },
                DeleteErrors = new List<DeleteError>
                {
                    new DeleteError{ Code = "200", Key = "key", Message = "Some Message!" },
                    new DeleteError{ Code = "500", Key = "key", Message = "Some Message!" }
                },
                RequestCharged = RequestCharged.Requester
            };

            var serializer = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, response);
                ms.Seek(0, SeekOrigin.Begin);
                DeleteObjectsResponse deserialized = serializer.Deserialize(ms) as DeleteObjectsResponse;

                List<string> deleteObjectKeys = new List<string>{ "hello", "world", "!!!"};
                foreach (var obj in deserialized.DeletedObjects)
                {
                    Assert.Equal("version", obj.VersionId);
                    Assert.Contains(obj.Key, deleteObjectKeys);
                }

                List<string> errorCodes = new List<string>{ "200", "500" };
                foreach (var error in deserialized.DeleteErrors)
                {
                    Assert.Equal("key", error.Key);
                    Assert.Contains(error.Code, errorCodes);
                }

                Assert.Equal(RequestCharged.Requester, deserialized.RequestCharged);
            }
        }

        private static S3PostUploadException CreateS3PostUploadException()
        {
            var s3pue = new S3PostUploadException("ErrorCode", "Message");
            s3pue.ErrorCode = "ec1";
            s3pue.RequestId = "rq1";
            s3pue.HostId = "hi1";
            s3pue.StatusCode = HttpStatusCode.OK;
            s3pue.ExtraFields = new Dictionary<string, string>
            {
                { "k1", "v1" },
                { "k2", "v2" },
            };
            return s3pue;
        }

        private static DeleteObjectsException CreateDeleteObjectsException()
        {
            var dor = new Amazon.S3.Model.DeleteObjectsResponse
            {
                DeletedObjects = new List<DeletedObject>
                {
                    new DeletedObject { Key = "key1", VersionId = "v1", DeleteMarker = true, DeleteMarkerVersionId = "mv1" },
                    new DeletedObject { Key = "key2", VersionId = "v2", DeleteMarker = false, DeleteMarkerVersionId = "mv2" }
                },
                DeleteErrors = new List<DeleteError>
                {
                    new DeleteError { Key = "key3", Code = "code3", Message = "message3", VersionId = "v3" },
                    new DeleteError { Key = "key4", Code = "code4", Message = "message4", VersionId = "v4" },
                    new DeleteError { Key = "key5", Code = "code5", Message = "message5", VersionId = "v5" }
                },
                ContentLength = 10,
                HttpStatusCode = HttpStatusCode.OK,
                ResponseMetadata = new ResponseMetadata
                {
                    Metadata = { { "m1", "mv1" }, { "m2", "mv2" } },
                    RequestId = "requestId"
                }
            };
            var doe = new DeleteObjectsException(dor)
            {
                ErrorType = ErrorType.Sender,
                ErrorCode = "ec1",
                RequestId = "requestIdSomething",
                StatusCode = HttpStatusCode.OK,
            };
            doe.GetType().GetProperty("AmazonId2").SetValue(doe, "amzid2", null);
            doe.GetType().GetProperty("ResponseBody").SetValue(doe, "uhh, stuff", null);
            return doe;
        }

        private static void TestException(Exception e)
        {
            string[] headers = null;
            var here = e.InnerException as HttpErrorResponseException;
            var hasHttpResponse = here != null;
            if (hasHttpResponse)
            {
                Assert.NotNull(here.Response);
                headers = here.Response.GetHeaderNames();
                Assert.NotNull(headers);
                Assert.NotEqual(0, headers.Length);
            }

            var serializer = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, e);
                ms.Seek(0, SeekOrigin.Begin);
                var deserialized = serializer.Deserialize(ms) as Exception;

                Assert.NotNull(deserialized);
                Assert.Equal(e.Message, deserialized.Message);

                if (e is AmazonS3Exception)
                {
                    var as3e = e as AmazonS3Exception;
                    var dAs3e = deserialized as AmazonS3Exception;
                    Assert.Equal(as3e.ErrorType, dAs3e.ErrorType);
                    Assert.Equal(as3e.ErrorCode, dAs3e.ErrorCode);
                    Assert.Equal(as3e.RequestId, dAs3e.RequestId);
                    Assert.Equal(as3e.StatusCode, dAs3e.StatusCode);
                    Assert.Equal(as3e.AmazonId2, dAs3e.AmazonId2);
                    Assert.Equal(as3e.ResponseBody, dAs3e.ResponseBody);
                }

                if (hasHttpResponse)
                {
                    var hereDeserialized = deserialized.InnerException as HttpErrorResponseException;
                    Assert.NotNull(hereDeserialized);
                    Assert.NotNull(hereDeserialized.Response);
                    var headersDeserialized = hereDeserialized.Response.GetHeaderNames();
                    Assert.NotNull(headersDeserialized);
                    Assert.NotEqual(0, headersDeserialized.Length);
                    Assert.Equal(headers.Length, headersDeserialized.Length);

                    Assert.Equal(here.Response.StatusCode, hereDeserialized.Response.StatusCode);
                    Assert.Equal(here.Response.IsSuccessStatusCode, hereDeserialized.Response.IsSuccessStatusCode);
                    Assert.Equal(here.Response.ContentLength, hereDeserialized.Response.ContentLength);
                    Assert.Equal(here.Response.ContentType, hereDeserialized.Response.ContentType);

                    foreach (var header in headers)
                    {
                        Assert.True(hereDeserialized.Response.IsHeaderPresent(header));
                        var value = hereDeserialized.Response.GetHeaderValue(header);
                        Assert.NotNull(value);
                        Assert.Equal(here.Response.GetHeaderValue(header), value);
                    }
                }

                if (e is DeleteObjectsException)
                {
                    var doe = e as DeleteObjectsException;
                    var dDoe = deserialized as DeleteObjectsException;

                    Assert.Equal(doe.Response.DeletedObjects.Count, dDoe.Response.DeletedObjects.Count);
                    foreach(var deleted in dDoe.Response.DeletedObjects)
                    {
                        Assert.NotNull(deleted.DeleteMarkerVersionId);
                        Assert.NotNull(deleted.Key);
                        Assert.NotNull(deleted.VersionId);
                        Assert.NotNull(deleted.DeleteMarker);
                        Assert.Equal(deleted.Key.EndsWith("1"), deleted.DeleteMarker);
                    }
                    Assert.Equal(doe.Response.DeleteErrors.Count, dDoe.Response.DeleteErrors.Count);
                    foreach (var error in dDoe.Response.DeleteErrors)
                    {
                        Assert.NotNull(error.Code);
                        Assert.NotNull(error.Key);
                        Assert.NotNull(error.Message);
                        Assert.NotNull(error.VersionId);
                    }
                }

                if (e is S3PostUploadException)
                {
                    var pue = e as S3PostUploadException;
                    var dPue = deserialized as S3PostUploadException;

                    Assert.Equal(pue.ErrorCode, dPue.ErrorCode);
                    Assert.Equal(pue.RequestId, dPue.RequestId);
                    Assert.Equal(pue.HostId, dPue.HostId);
                    Assert.Equal(pue.StatusCode, dPue.StatusCode);
                    Assert.Equal(pue.ExtraFields.Count, dPue.ExtraFields.Count);
                    foreach(var kvp in dPue.ExtraFields)
                    {
                        Assert.False(string.IsNullOrEmpty(kvp.Key));
                        Assert.False(string.IsNullOrEmpty(kvp.Value));
                    }
                }
            }
        }
#endif

        [Fact]
        public void JsonCountSerializationBug()
        {
            var json = @"{""Data"":{""NotCount"":""42""}}";
            var poco = JsonSerializer.Deserialize<Poco>(json);
            Assert.Equal(1, poco.Data.Count);
            Assert.Equal("42", poco.Data["NotCount"]);

            json = @"{""Data"":{""Count"":""Dracula""}}";
            poco = JsonSerializer.Deserialize<Poco>(json);
            Assert.Equal(1, poco.Data.Count);
            Assert.Equal("Dracula", poco.Data["Count"]);
        }
        private class Poco
        {
            public Dictionary<string, string> Data { get; set; }
        }

        [Fact]
        public void TestLargeRetryCount()
        {
            var maxRetries = 1000;
            var maxMilliseconds = 1;
            ClientConfig config = new AmazonDynamoDBConfig();
            config.MaxErrorRetry = 100;
            var coreRetryPolicy = new DefaultRetryPolicy(config)
            {
                MaxBackoffInMilliseconds = maxMilliseconds
            };
            var ddbRetryPolicy = new DynamoDBRetryPolicy(config)
            {
                MaxBackoffInMilliseconds = maxMilliseconds
            };

            var context = new Amazon.Runtime.Internal.ExecutionContext(new RequestContext(false, new NullSigner()), null);
            for (int i = 0; i < maxRetries; i++)
            {
                context.RequestContext.Retries = i;
                coreRetryPolicy.WaitBeforeRetry(context);
                ddbRetryPolicy.WaitBeforeRetry(context);
            }
        }

        [Fact]
        public async Task TestClientDispose()
        {
            IAmazonS3 client;
            using(client = new AmazonS3Client())
            {
                var response = await client.ListBucketsAsync();
                Assert.NotNull(response);
                Assert.NotNull(response.ResponseMetadata);
                Assert.NotNull(response.ResponseMetadata.RequestId);
                Assert.False(string.IsNullOrEmpty(response.ResponseMetadata.RequestId));
            }

            await Assert.ThrowsAsync<ObjectDisposedException>(() => client.ListBucketsAsync());
        }

        [Fact]
        public async Task TestManualClockCorrection()
        {
            await TestClientsAsync(TestServiceCallForManualClockCorrectionAsync);
        }

        // This test verifies that all service clients are able to
        // correctly handle clock skew errors.
        // By default it only tests a small subset of services.
        [Fact(Skip = "Skipping flaky test while design for clock skew behavior is defined")]
        public async Task TestClockSkewCorrection()
        {
            // VerifyClockSkewSetting reads from App.config via ConfigurationManager, which is
            // only available on .NET Framework. .NET 8 does not support the aws config section.
#if NETFRAMEWORK
            VerifyClockSkewSetting();
#endif
            await TestClientsAsync(TestServiceCallForClockSkewAsync);
        }

        private async Task TestClientsAsync(Func<ClockSkewTestContext, Task> serviceCall)
        {
            bool allPassed = true;
            foreach (var clientTest in clientTests)
            {
                try
                {
                    await TestClientAsync(clientTest.Client, clientTest.Method, clientTest.Request, serviceCall);
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

        // ConfigurationManager and App.config are only available on .NET Framework.
        // .NET 8 does not support reading the aws config section from App.config.
#if NETFRAMEWORK
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
            Assert.True(bool.TryParse(attributeValueText, out configClockSkewSetting));
            Assert.Equal(clockSkewSetting, configClockSkewSetting);
        }
#endif

        private class ClockSkewTestContext
        {
            public IClientConfig Config;
            public Func<Task> TestAction;
        }

        private static async Task TestServiceCallForManualClockCorrectionAsync(ClockSkewTestContext context)
        {
            var oldManualClockCorrection = AWSConfigs.ManualClockCorrection;
            var oldCorrectClockSkew = AWSConfigs.CorrectForClockSkew;
            var oldUtcNowSource = GetUtcNowSource();

            try
            {
                AWSConfigs.CorrectForClockSkew = false;

                SetUtcNowSource(() => DateTime.UtcNow + IncorrectPositiveClockSkewOffset);
                AWSConfigs.ManualClockCorrection = null;
                await Assert.ThrowsAnyAsync<Exception>(context.TestAction);

                AWSConfigs.ManualClockCorrection = IncorrectPositiveClockSkewOffset.Negate();
                await context.TestAction();

                SetUtcNowSource(() => DateTime.UtcNow + IncorrectNegativeClockSkewOffset);
                AWSConfigs.ManualClockCorrection = IncorrectNegativeClockSkewOffset.Negate();
                await context.TestAction();

                AWSConfigs.ManualClockCorrection = TimeSpan.FromTicks(IncorrectNegativeClockSkewOffset.Negate().Ticks * 2);
                await Assert.ThrowsAnyAsync<Exception>(context.TestAction);

                AWSConfigs.ManualClockCorrection = TimeSpan.Zero;
                await Assert.ThrowsAnyAsync<Exception>(context.TestAction);
            }
            finally
            {
                AWSConfigs.ManualClockCorrection = oldManualClockCorrection;
                AWSConfigs.CorrectForClockSkew = oldCorrectClockSkew;
                SetUtcNowSource(oldUtcNowSource);
            }
        }

        private static async Task TestServiceCallForClockSkewAsync(ClockSkewTestContext context)
        {
            var oldCorrectClockSkew = AWSConfigs.CorrectForClockSkew;
            var oldUtcNowSource = GetUtcNowSource();

            try
            {
                AWSConfigs.CorrectForClockSkew = true;
                SetClockSkewCorrection(TimeSpan.Zero);
                await context.TestAction();

                SetClockSkewCorrection(IncorrectPositiveClockSkewOffset);
                await context.TestAction();

                SetClockSkewCorrection(IncorrectNegativeClockSkewOffset);
                await context.TestAction();

                Console.WriteLine("Simulating positive clock skew");
                SetUtcNowSource(() => DateTime.UtcNow + IncorrectPositiveClockSkewOffset);
                AWSConfigs.CorrectForClockSkew = false;
                await Assert.ThrowsAnyAsync<Exception>(context.TestAction);

                AWSConfigs.CorrectForClockSkew = true;
                SetClockSkewCorrection(TimeSpan.Zero);
                await context.TestAction();

                Console.WriteLine("Simulating negative clock skew");
                SetUtcNowSource(() => DateTime.UtcNow + IncorrectNegativeClockSkewOffset);
                AWSConfigs.CorrectForClockSkew = true;
                SetClockSkewCorrection(TimeSpan.Zero);
                await context.TestAction();

                AWSConfigs.CorrectForClockSkew = false;
                await Assert.ThrowsAnyAsync<Exception>(context.TestAction);
            }
            finally
            {
                AWSConfigs.CorrectForClockSkew = oldCorrectClockSkew;
                SetUtcNowSource(oldUtcNowSource);
            }
        }

        // ClientTest helpers
        private async Task TestClientAsync(Type clientType, string methodName, object request, Func<ClockSkewTestContext, Task> serviceCall)
        {
            Console.WriteLine("Testing client: " + clientType.FullName);
            var client = Activator.CreateInstance(clientType, null) as IDisposable;

            // Optionally modify client config
            var config = GetConfig(client);
            using (client)
            {
                Func<Task> action = GetClientAsyncAction(client, methodName, request);
                await serviceCall(new ClockSkewTestContext { TestAction = action, Config = config });
            }
        }
        private class ClientTest
        {
            public Type Client { get; set; }
            public string Method { get; set; }
            public object Request { get; set; }
        }
        private static List<ClientTest> clientTests = new List<ClientTest>
        {
            // Partial list of clients to test
            new ClientTest { Client = typeof(Amazon.CognitoSync.AmazonCognitoSyncClient), Method = "ListIdentityPoolUsageAsync", Request = new Amazon.CognitoSync.Model.ListIdentityPoolUsageRequest { MaxResults = 1 } },
            new ClientTest { Client = typeof(Amazon.EC2.AmazonEC2Client), Method = "DescribeKeyPairsAsync" },
            new ClientTest { Client = typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), Method = "ListTablesAsync" },
            new ClientTest { Client = typeof(AmazonS3Client), Method = "ListBucketsAsync" },
            new ClientTest { Client = typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), Method = "ListGroupsAsync" },
        };

        private ClientConfig GetConfig(object client)
        {
            var configProperty = typeof(AmazonServiceClient).GetProperty("Config", BindingFlags.Instance | BindingFlags.Public);
            return configProperty.GetValue(client, null) as ClientConfig;
        }

        private static Func<Task> GetClientAsyncAction(object client, string methodName, object request)
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
                    // Match async methods: single request param, or request + CancellationToken
                    if (parameters.Length >= 1 && requestType.IsAssignableFrom(parameters[0].ParameterType))
                    {
                        method = m;
                        break;
                    }
                }
            }
            if (method == null)
                throw new InvalidOperationException("Cannot find method [" + methodName + "]");

            parameters = method.GetParameters();
            object[] inputs;
            if (request != null)
            {
                if (parameters.Length == 2) // request + CancellationToken
                    inputs = new object[] { request, CancellationToken.None };
                else
                    inputs = new object[] { request };
            }
            else
            {
                if (parameters.Length == 0)
                {
                    inputs = null;
                }
                else if (parameters.Length == 1 && parameters[0].ParameterType == typeof(CancellationToken))
                {
                    inputs = new object[] { CancellationToken.None };
                }
                else if (parameters.Length == 1)
                {
                    var input = Activator.CreateInstance(parameters[0].ParameterType);
                    inputs = new object[] { input };
                }
                else if (parameters.Length == 2)
                {
                    var input = Activator.CreateInstance(parameters[0].ParameterType);
                    inputs = new object[] { input, CancellationToken.None };
                }
                else
                {
                    throw new InvalidOperationException("Method requires more than expected inputs");
                }
            }

            return async () =>
            {
                var result = method.Invoke(client, inputs);
                if (result is Task task)
                    await task;
            };
        }
    }
}
