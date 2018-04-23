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
using Amazon.Util;
using Amazon.Runtime.Internal;
using Amazon.DynamoDBv2.Internal;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Net;
using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;
using Amazon.SecurityToken.SAML;
using Amazon.DynamoDBv2;
using Amazon.ElasticTranscoder;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public partial class General
    {
        [TestMethod]
        [TestCategory("General")]
        // Test exception parsing with selected services
        public void TestDownloadStringContentWithTimeout()
        {
            var timeout = TimeSpan.FromSeconds(3);
            var url = new Uri("https://httpbin.org/delay/10"); // server will delay for 10 seconds
            string downloadedContent = null;
            Exception caughtException = null;
            var thread = new Thread(() =>
            {
                try
                {
                    downloadedContent = Amazon.Util.AWSSDKUtils.DownloadStringContent(url, timeout);
                }
                catch(Exception e)
                {
                    caughtException = e;
                }
            });

            try
            {
                thread.IsBackground = true;
                thread.Start();

                Thread.Sleep(timeout + timeout);
                Assert.IsNull(downloadedContent);
                Assert.IsNotNull(caughtException);

                var webException = caughtException as WebException;
                Assert.IsNotNull(webException);
                Console.WriteLine("Exception message = [{0}]", webException.Message);
                Assert.AreEqual("The operation has timed out", webException.Message);
            }
            finally
            {
                thread.Abort();
            }
        }

        [TestMethod]
        [TestCategory("General")]
        // Test exception parsing with selected services
        public void TestExceptions()
        {
            var fakeData = "obviously-super-duper-fake-data";

            using (var client = new Amazon.Lightsail.AmazonLightsailClient())
            {
                var ex = AssertExtensions.ExpectException<Amazon.Lightsail.Model.NotFoundException>(() =>
                {
                    client.GetInstance(new Amazon.Lightsail.Model.GetInstanceRequest
                    {
                        InstanceName = fakeData
                    });
                });
                Assert.AreEqual(ErrorType.Unknown, ex.ErrorType);
            }

            using (var client = new Amazon.ElasticTranscoder.AmazonElasticTranscoderClient())
            {
                var ex = AssertExtensions.ExpectException<Amazon.ElasticTranscoder.Model.ValidationException>(() =>
                {
                    client.DeletePipeline(new Amazon.ElasticTranscoder.Model.DeletePipelineRequest
                    {
                        Id = fakeData
                    });
                });
                Assert.AreEqual(ErrorType.Unknown, ex.ErrorType);
            }

            using (var ddb = new Amazon.DynamoDBv2.AmazonDynamoDBClient())
            {
                var ex = AssertExtensions.ExpectException<Amazon.DynamoDBv2.Model.ResourceNotFoundException>(() => ddb.DescribeTable("fakey-mcfake-table"));
                Assert.AreEqual(ErrorType.Unknown, ex.ErrorType);
            }

            using (var client = new Amazon.Pinpoint.AmazonPinpointClient())
            {
                var ex = AssertExtensions.ExpectException<Amazon.Pinpoint.Model.NotFoundException>(() =>
                {
                    client.DeleteCampaign(new Amazon.Pinpoint.Model.DeleteCampaignRequest
                    {
                        ApplicationId = fakeData,
                        CampaignId = fakeData
                    });
                });
                Assert.AreEqual(ErrorType.Unknown, ex.ErrorType);
            }

            using (var client = new Amazon.Batch.AmazonBatchClient())
            {
                var ex = AssertExtensions.ExpectException<Amazon.Batch.Model.ClientException>(() =>
                {
                    client.UpdateComputeEnvironment(new Amazon.Batch.Model.UpdateComputeEnvironmentRequest
                    {
                        ComputeEnvironment = fakeData
                    });
                });
                Assert.AreEqual(ErrorType.Unknown, ex.ErrorType);
            }

            using(var client = new Amazon.Glacier.AmazonGlacierClient())
            {
                var ex = AssertExtensions.ExpectException<Amazon.Glacier.Model.ResourceNotFoundException>(() =>
                {
                    client.InitiateMultipartUpload(new Amazon.Glacier.Model.InitiateMultipartUploadRequest
                    {
                        AccountId = "-",
                        ArchiveDescription = fakeData,
                        VaultName = fakeData,
                        PartSize = 123
                    });
                });
                Assert.AreEqual(ErrorType.Unknown, ex.ErrorType);
            }

            using (var client = new Amazon.IdentityManagement.AmazonIdentityManagementServiceClient())
            {
                var ex = AssertExtensions.ExpectException<Amazon.IdentityManagement.Model.NoSuchEntityException>(() =>
                {
                    client.AttachGroupPolicy(new Amazon.IdentityManagement.Model.AttachGroupPolicyRequest
                    {
                        PolicyArn = fakeData,
                        GroupName = fakeData
                    });
                });
                Assert.AreEqual(ErrorType.Sender, ex.ErrorType);
            }
        }


        [TestMethod]
        [TestCategory("General")]
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

#pragma warning disable 618

                var ccre = new CredentialCallbackRequiredException("Message");
                TestException(ccre);

                var afe = new AuthenticationFailedException("Message");
                TestException(afe);

#pragma warning restore 618

            }
        }

        
        [TestMethod]
        [TestCategory("General")]
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
                // Validate deserialized dataa
                foreach (var obj in deserialized.DeletedObjects)
                {
                    Assert.AreEqual(obj.VersionId, "version");
                    Assert.IsTrue(deleteObjectKeys.Contains(obj.Key));
                }

                List<string> errorCodes = new List<string>{ "200", "500" };
                foreach (var error in deserialized.DeleteErrors)
                {
                    Assert.AreEqual(error.Key, "key");
                    Assert.IsTrue(errorCodes.Contains(error.Code));
                }

                Assert.AreEqual(deserialized.RequestCharged, RequestCharged.Requester);
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
                DeletedObjects =
                    {
                        new DeletedObject
                        {
                            Key = "key1",
                            VersionId = "v1",
                            DeleteMarker = true,
                            DeleteMarkerVersionId = "mv1"
                        },
                        new DeletedObject
                        {
                            Key = "key2",
                            VersionId = "v2",
                            DeleteMarker = false,
                            DeleteMarkerVersionId = "mv2"
                        }
                    },
                DeleteErrors =
                    {
                        new DeleteError
                        {
                            Key = "key3",
                            Code = "code3",
                            Message = "message3",
                            VersionId = "v3"
                        },
                        new DeleteError
                        {
                            Key = "key4",
                            Code = "code4",
                            Message = "message4",
                            VersionId = "v4"
                        },
                        new DeleteError
                        {
                            Key = "key5",
                            Code = "code5",
                            Message = "message5",
                            VersionId = "v5"
                        }
                    },
                ContentLength = 10,
                HttpStatusCode = HttpStatusCode.OK,
                ResponseMetadata = new ResponseMetadata
                {
                    Metadata =
                        {
                            { "m1", "mv1" },
                            { "m2", "mv2" }
                        },
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
                Assert.IsNotNull(here.Response);
                headers = here.Response.GetHeaderNames();
                Assert.IsNotNull(headers);
                Assert.AreNotEqual(0, headers.Length);
            }

            var serializer = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, e);
                ms.Seek(0, SeekOrigin.Begin);
                var deserialized = serializer.Deserialize(ms) as Exception;

                Assert.IsNotNull(deserialized);

                Assert.AreEqual(e.Message, deserialized.Message);
                if (e is AmazonS3Exception)
                {
                    var as3e = e as AmazonS3Exception;
                    var dAs3e = deserialized as AmazonS3Exception;
                    Assert.AreEqual(as3e.ErrorType, dAs3e.ErrorType);
                    Assert.AreEqual(as3e.ErrorCode, dAs3e.ErrorCode);
                    Assert.AreEqual(as3e.RequestId, dAs3e.RequestId);
                    Assert.AreEqual(as3e.StatusCode, dAs3e.StatusCode);
                    Assert.AreEqual(as3e.AmazonId2, dAs3e.AmazonId2);
                    Assert.AreEqual(as3e.ResponseBody, dAs3e.ResponseBody);
                }

                if (hasHttpResponse)
                {
                    var hereDeserialized = deserialized.InnerException as HttpErrorResponseException;
                    Assert.IsNotNull(hereDeserialized);
                    Assert.IsNotNull(hereDeserialized.Response);
                    var headersDeserialized = hereDeserialized.Response.GetHeaderNames();
                    Assert.IsNotNull(headersDeserialized);
                    Assert.AreNotEqual(0, headersDeserialized.Length);
                    Assert.AreEqual(headers.Length, headersDeserialized.Length);

                    Assert.AreEqual(here.Response.StatusCode, hereDeserialized.Response.StatusCode);
                    Assert.AreEqual(here.Response.IsSuccessStatusCode, hereDeserialized.Response.IsSuccessStatusCode);
                    Assert.AreEqual(here.Response.ContentLength, hereDeserialized.Response.ContentLength);
                    Assert.AreEqual(here.Response.ContentType, hereDeserialized.Response.ContentType);

                    foreach (var header in headers)
                    {
                        Assert.IsTrue(hereDeserialized.Response.IsHeaderPresent(header));
                        var value = hereDeserialized.Response.GetHeaderValue(header);
                        Assert.IsNotNull(value);
                        Assert.AreEqual(here.Response.GetHeaderValue(header), value);
                    }
                }

                if (e is DeleteObjectsException)
                {
                    var doe = e as DeleteObjectsException;
                    var dDoe = deserialized as DeleteObjectsException;

                    Assert.AreEqual(doe.Response.DeletedObjects.Count, dDoe.Response.DeletedObjects.Count);
                    foreach(var deleted in dDoe.Response.DeletedObjects)
                    {
                        Assert.IsNotNull(deleted.DeleteMarkerVersionId);
                        Assert.IsNotNull(deleted.Key);
                        Assert.IsNotNull(deleted.VersionId);
                        Assert.IsNotNull(deleted.DeleteMarker);
                        Assert.AreEqual(deleted.Key.EndsWith("1"), deleted.DeleteMarker);
                    }
                    Assert.AreEqual(doe.Response.DeleteErrors.Count, dDoe.Response.DeleteErrors.Count);
                    foreach (var error in dDoe.Response.DeleteErrors)
                    {
                        Assert.IsNotNull(error.Code);
                        Assert.IsNotNull(error.Key);
                        Assert.IsNotNull(error.Message);
                        Assert.IsNotNull(error.VersionId);
                    }
                }

                if (e is S3PostUploadException)
                {
                    var pue = e as S3PostUploadException;
                    var dPue = deserialized as S3PostUploadException;

                    Assert.AreEqual(pue.ErrorCode, dPue.ErrorCode);
                    Assert.AreEqual(pue.RequestId, dPue.RequestId);
                    Assert.AreEqual(pue.HostId, dPue.HostId);
                    Assert.AreEqual(pue.StatusCode, dPue.StatusCode);
                    Assert.AreEqual(pue.ExtraFields.Count, dPue.ExtraFields.Count);
                    foreach(var kvp in dPue.ExtraFields)
                    {
                        Assert.IsFalse(string.IsNullOrEmpty(kvp.Key));
                        Assert.IsFalse(string.IsNullOrEmpty(kvp.Value));
                    }
                }
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void JsonCountSerializationBug()
        {
            var json = @"{""Data"":{""NotCount"":""42""}}";
            var poco = ThirdParty.Json.LitJson.JsonMapper.ToObject<Poco>(json);
            Assert.AreEqual(1, poco.Data.Count);
            Assert.AreEqual("42", poco.Data["NotCount"]);

            json = @"{""Data"":{""Count"":""Dracula""}}";
            poco = ThirdParty.Json.LitJson.JsonMapper.ToObject<Poco>(json);
            Assert.AreEqual(1, poco.Data.Count);
            Assert.AreEqual("Dracula", poco.Data["Count"]);
        }
        private class Poco
        {
            public Dictionary<string, string> Data { get; set; }
        }

        [TestMethod]
        [TestCategory("General")]
        public void TestSDKExceptions()
        {
            var allTypes = new List<Type>();
            foreach (Assembly ass in AppDomain.CurrentDomain.GetAssemblies())
            {
                allTypes.AddRange(ass.GetExportedTypes());
            }
            Assert.AreNotEqual(0, allTypes.Count);

            var exceptionType = typeof(Exception);

            var binding = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
            var inputTypes = new Type[] { typeof(SerializationInfo), typeof(StreamingContext) };

            var errors = new List<string>();

            foreach (var type in allTypes)
            {
                var typeName = type.FullName;

                if (type.FullName.IndexOf("Amazon.", StringComparison.OrdinalIgnoreCase) >= 0 &&
                    exceptionType.IsAssignableFrom(type))
                {
                    var serializableAttributes = type.GetCustomAttributes(typeof(SerializableAttribute), false).ToList();

                    // exceptions must have [Serializable] attribute
                    if (serializableAttributes.Count == 0)
                    {
                        //exceptionsWithoutSerializeable.Add(type);
                        errors.Add("Exception " + type.FullName + " exception types are not serializeable");
                    }

                    // exceptions must have serialization constructor
                    var serializationConstructor = type.GetConstructor(binding, null, inputTypes, null);
                    if (serializationConstructor == null)
                        errors.Add("Type " + type.FullName + " missing serialization constructor");

                    // exceptions which have extra fields on them, must overload GetObjectData
                    var declaredFields = type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance);
                    if (declaredFields.Length > 0)
                    {
                        var getObjectDataMethod = type.GetMethod("GetObjectData", binding, null, inputTypes, null);
                        if (getObjectDataMethod == null)
                            errors.Add("Type " + type.FullName + " missing serialization GetObjectData method");
                    }
                }
            }

            // report all errors
            if (errors.Count > 0)
                Assert.Fail("Errors found:" + string.Join(Environment.NewLine, errors.ToArray()));
        }

        [TestMethod]
        [TestCategory("General")]
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

        [TestMethod]
        [TestCategory("General")]
        public void TestBidiCharsInUri()
        {
            var bidiChar = '\u200E';
            using(var client = TestBase<AmazonS3Client>.CreateClient())
            {
                var part1 = "test";
                var part2 = "key";
                var bidiKey = part1 + bidiChar + part2;
                
                // verify character is in the string
                Assert.IsTrue(bidiKey.IndexOf(bidiChar) > 0);
                Assert.IsTrue(AWSSDKUtils.HasBidiControlCharacters(bidiKey));

                // verify character is dropped by the Uri class
                Uri uri = new Uri(new Uri("http://www.amazon.com/"), bidiKey);
                Assert.IsTrue(uri.AbsoluteUri.IndexOf(bidiChar) < 0);
                Assert.IsFalse(AWSSDKUtils.HasBidiControlCharacters(uri.AbsoluteUri));
                Assert.IsTrue(uri.AbsoluteUri.IndexOf(part1 + part2) > 0);

                // verify that trying to use key throws the appropriate exception
                var e = AssertExtensions.ExpectException<AmazonClientException>(() => client.GetObject("fake-bucket", bidiKey));
                Assert.IsNotNull(e);
                Assert.IsTrue(e.Message.Contains("[" + bidiKey + "]"));
                Assert.IsTrue(e.Message.Contains("cannot be handled by the .NET SDK"));
                Assert.IsTrue(AWSSDKUtils.HasBidiControlCharacters(e.Message));
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void TestClientDispose()
        {
            IAmazonS3 client;
            using(client = new AmazonS3Client())
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

        [TestMethod]
        [TestCategory("General")]
        public void TestManualClockCorrection()
        {
            TestClients(TestServiceCallForManualClockCorrection);
        }

        // This test verifies that all service clients are able to
        // correctly handle clock skew errors.
        // By default it only tests a small subset of services.
        [TestMethod]
        [TestCategory("General")]
        public void TestClockSkewCorrection()
        {
            VerifyClockSkewSetting();
            TestClients(TestServiceCallForClockSkew);
        }

        private void TestClients(Action<ClockSkewTestContext> serviceCall)
        {
            bool allPassed = true;
            foreach (var clientTest in clientTests)
            {
                try
                {
                    TestClient(clientTest.Client, clientTest.Method, clientTest.Request, serviceCall);
                    Console.WriteLine("Client test succeeded");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Client test FAILED: " + e);
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

#pragma warning disable CS0618 // Type or member is obsolete
                Assert.IsTrue(AWSConfigs.ClockOffset == TimeSpan.Zero);
#pragma warning restore CS0618 // Type or member is obsolete
                Assert.IsTrue(context.Config.ClockOffset == TimeSpan.Zero);                

                SetClockSkewCorrection(context.Config, IncorrectPositiveClockSkewOffset);
                context.TestAction();
#pragma warning disable CS0618 // Type or member is obsolete
                Assert.AreNotEqual(IncorrectPositiveClockSkewOffset, AWSConfigs.ClockOffset);
#pragma warning restore CS0618 // Type or member is obsolete
                Assert.AreNotEqual(IncorrectPositiveClockSkewOffset, context.Config.ClockOffset);

                SetClockSkewCorrection(context.Config, IncorrectNegativeClockSkewOffset);
                context.TestAction();
#pragma warning disable CS0618 // Type or member is obsolete
                Assert.AreNotEqual(IncorrectPositiveClockSkewOffset, AWSConfigs.ClockOffset);
#pragma warning restore CS0618 // Type or member is obsolete
                Assert.AreNotEqual(IncorrectNegativeClockSkewOffset, context.Config.ClockOffset);

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

        // ClientTest helpers
        private void TestClient(Type clientType, string methodName, object request, Action<ClockSkewTestContext> serviceCall)
        {
            Console.WriteLine("Testing client: " + clientType.FullName);
            var client = Activator.CreateInstance(clientType, null) as IDisposable;

            // Optionally modify client config
            var config = GetConfig(client);
            //config.UseHttp = true;

            using (client)
            {
                Action action = GetClientAction(client, methodName, request);

                // Optionally log the signer type
                //var signer = GetSigner(client);
                //Console.WriteLine("Signer: " + signer.GetType().FullName);

                serviceCall(
                    new ClockSkewTestContext {
                        TestAction = action,
                        Config = config
                });
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
            new ClientTest { Client = typeof(Amazon.CognitoSync.AmazonCognitoSyncClient), Method = "ListIdentityPoolUsage", Request = new Amazon.CognitoSync.Model.ListIdentityPoolUsageRequest { MaxResults = 1 } },
            new ClientTest { Client = typeof(Amazon.EC2.AmazonEC2Client), Method = "DescribeKeyPairs" },
            new ClientTest { Client = typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), Method = "ListTables" },
            new ClientTest { Client = typeof(AmazonS3Client), Method = "ListBuckets" },
            new ClientTest { Client = typeof(Amazon.Glacier.AmazonGlacierClient), Method = "ListVaults" },
            new ClientTest { Client = typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), Method = "ListGroups" },
            // ImportExport returns a 500.  Investigating...
            //new ClientTest { Client = typeof(Amazon.ImportExport.AmazonImportExportClient), Method = "ListJobs" },
        };

        // Reflection helpers
        private AbstractAWSSigner GetSigner(object client)
        {
            var signerProperty = typeof(AmazonServiceClient).GetProperty("Signer", BindingFlags.Instance | BindingFlags.NonPublic);
            var signer = signerProperty.GetValue(client, null) as AbstractAWSSigner;
            return signer;
        }
        private ClientConfig GetConfig(object client)
        {
            var configProperty = typeof(AmazonServiceClient).GetProperty("Config", BindingFlags.Instance | BindingFlags.Public);
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
