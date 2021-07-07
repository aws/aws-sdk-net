using Amazon.Runtime.Internal;
using Amazon.Util;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Threading;

namespace AWSSDK_DotNet35.UnitTests.EC2
{
    [TestClass]
    public class EC2InstanceMetadataTests
    {
        private FieldInfo nullTokenField = null;
        private const string endpointEnvVar = "AWS_EC2_METADATA_SERVICE_ENDPOINT";

        [TestInitialize]
        public void Init()
        {
            nullTokenField = ResetUseNullToken();
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (nullTokenField != null)
            {
                nullTokenField.SetValue(null, false);
            }            
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestAccessingEC2InstanceMetadataProperties()
        {
            using (var servlet = new ResponseTestServlet())
            {
                servlet.Response = string.Empty;
                servlet.StatusCode = 404;

                var metadataType = typeof(EC2InstanceMetadata);
                var currentEMSValue = Environment.GetEnvironmentVariable(endpointEnvVar);

                Action setEMSAction = () => SetEC2InstanceMetadataEndpoint(servlet.ServiceURL);
                Action resetEMSAction = () => SetEC2InstanceMetadataEndpoint(currentEMSValue);

                using (new DisposableSwitch(setEMSAction, resetEMSAction))
                {
                    var allMembers = metadataType.GetMembers(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    foreach (var member in allMembers)
                    {
                        var fi = member as FieldInfo;
                        var pi = member as PropertyInfo;

                        object value;

                        // make and exception for IsIMDSEnabled property or the IMDS endpoint and URI helpers
                        if (pi != null && !pi.Name.Equals("IsIMDSEnabled") && !pi.Name.Equals("ServiceEndpoint") && !pi.Name.StartsWith("EC2"))
                        {
                            value = pi.GetValue(null);
                            // all properties should return null on non-EC2 instances
                            Assert.IsNull(value, "Property {0} should be null", pi.Name);
                        }
                        else if (fi != null)
                        {
                            value = fi.GetValue(null);
                            // all fields should return non-null on non-EC2 instances
                            Assert.IsNotNull(value, "Field {0} should not be null", fi.Name);
                        }
                    }
                }
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(WebException))]
        public void TestEC2InstanceMetadata401Unauthorized()
        {
            var token = "ValidToken";
            var responses = new List<MultipleResponseServlet.Response>();
            responses.Add(TokenFetchResponse(token, HttpStatusCode.OK));
            responses.Add(MetadataGetSecurityCredentialsResponse(string.Empty, token, HttpStatusCode.Unauthorized));

            using (var servlet = new MultipleResponseServlet())
            {
                SetupResponseHandler(servlet, responses);
                try
                {
                    var metadata = GetSecurityCredentials(servlet);
                }
                catch (WebException wex)
                {
                    var response = wex.Response as HttpWebResponse;
                    Assert.IsNotNull(response);
                    Assert.AreEqual(HttpStatusCode.Unauthorized, response.StatusCode);
                    throw;
                }
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(WebException))]
        public void TestEC2InstanceMetadataAPIToken400BadRequest()
        {
            var responses = new List<MultipleResponseServlet.Response>();
            //DEFAULT_RETRIES of 3 for the metadata call for getting a token when BadRequest is used.
            responses.Add(TokenFetchResponse(string.Empty, HttpStatusCode.BadRequest));
            responses.Add(TokenFetchResponse(string.Empty, HttpStatusCode.BadRequest));
            responses.Add(TokenFetchResponse(string.Empty, HttpStatusCode.BadRequest));

            using (var servlet = new MultipleResponseServlet())
            {
                SetupResponseHandler(servlet, responses);
                try
                {
                    var metadata = GetSecurityCredentials(servlet);
                }
                catch(WebException wex)
                {
                    var response = wex.Response as HttpWebResponse;
                    Assert.IsNotNull(response);
                    Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);                    
                    throw;
                }
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestEC2InstanceMetadataSecureCredentialsSuccess()
        {
            var token = "ValidToken";
            var responses = new List<MultipleResponseServlet.Response>();
            responses.Add(TokenFetchResponse(token, HttpStatusCode.OK));
            responses.Add(MetadataGetSecurityCredentialsResponse("Item1", token, HttpStatusCode.OK));
            responses.Add(TokenFetchResponse(token, HttpStatusCode.OK));
            responses.Add(MetadataGetSecurityCredentialsResponse("{\"AccessKeyId\": \"value1\", \"SecretAccessKey\": \"value2\", \"Token\": \"value3\"}", 
                token, HttpStatusCode.OK));

            using (var servlet = new MultipleResponseServlet())
            {
                SetupResponseHandler(servlet, responses);
                var metadata = GetSecurityCredentials(servlet);
                Assert.IsNotNull(metadata);
                Assert.AreEqual(1, metadata.Count);
                Assert.IsTrue(metadata.ContainsKey("Item1"));
                var creds = metadata["Item1"];                
                Assert.AreEqual("value1", creds.AccessKeyId);
                Assert.AreEqual("value2", creds.SecretAccessKey);
                Assert.AreEqual("value3", creds.Token);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestEC2InstanceMetadataInsecureCredentialsFallbackToken()
        {
            var failFastStatusCodes = new HttpStatusCode[] 
            {
                HttpStatusCode.NotFound,
                HttpStatusCode.Forbidden,
                HttpStatusCode.MethodNotAllowed
            };

            for(var statusCodeIndex = 0; statusCodeIndex < failFastStatusCodes.Length; statusCodeIndex++)
            {
                ResetUseNullToken();

                var token = string.Empty;
                var responses = new List<MultipleResponseServlet.Response>();
                responses.Add(TokenFetchResponse(token, failFastStatusCodes[statusCodeIndex]));
                responses.Add(MetadataGetSecurityCredentialsResponse("Item1", token, HttpStatusCode.OK));
                responses.Add(MetadataGetSecurityCredentialsResponse("{\"AccessKeyId\": \"value1\", \"SecretAccessKey\": \"value2\", \"Token\": \"value3\"}",
                    token, HttpStatusCode.OK));

                using (var servlet = new MultipleResponseServlet())
                {
                    SetupResponseHandler(servlet, responses);
                    var metadata = GetSecurityCredentials(servlet);
                    Assert.IsNotNull(metadata);
                    Assert.AreEqual(1, metadata.Count);
                    Assert.IsTrue(metadata.ContainsKey("Item1"));
                    var creds = metadata["Item1"];
                    Assert.AreEqual("value1", creds.AccessKeyId);
                    Assert.AreEqual("value2", creds.SecretAccessKey);
                    Assert.AreEqual("value3", creds.Token);
                }
            }            
        }        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestEC2InstanceMetadataInsecureCredentialsFallbackNotFound()
        {
            var token = string.Empty;
            var responses = new List<MultipleResponseServlet.Response>();
            responses.Add(TokenFetchResponse(token, HttpStatusCode.NotFound));
            responses.Add(MetadataGetSecurityCredentialsResponse("Item1", token, HttpStatusCode.NotFound));
            
            using (var servlet = new MultipleResponseServlet())
            {
                SetupResponseHandler(servlet, responses);
                var metadata = GetSecurityCredentials(servlet);
                Assert.IsNull(metadata);                
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestEC2InstanceMetadataSecureCredentialsRetry()
        {
            var token = "ValidToken";
            var responses = new List<MultipleResponseServlet.Response>();
            responses.Add(TokenFetchResponse(string.Empty, HttpStatusCode.ServiceUnavailable));
            responses.Add(TokenFetchResponse(token, HttpStatusCode.OK));
            responses.Add(MetadataGetSecurityCredentialsResponse("Item1", token, HttpStatusCode.ServiceUnavailable));            
            responses.Add(MetadataGetSecurityCredentialsResponse("Item1", token, HttpStatusCode.OK));
            responses.Add(TokenFetchResponse(token, HttpStatusCode.OK));
            responses.Add(MetadataGetSecurityCredentialsResponse("{\"AccessKeyId\": \"value1\", \"SecretAccessKey\": \"value2\", \"Token\": \"value3\"}",
                token, HttpStatusCode.OK));

            using (var servlet = new MultipleResponseServlet())
            {
                SetupResponseHandler(servlet, responses);
                var metadata = GetSecurityCredentials(servlet);
                Assert.IsNotNull(metadata);
                Assert.AreEqual(1, metadata.Count);
                Assert.IsTrue(metadata.ContainsKey("Item1"));
                var creds = metadata["Item1"];
                Assert.AreEqual("value1", creds.AccessKeyId);
                Assert.AreEqual("value2", creds.SecretAccessKey);
                Assert.AreEqual("value3", creds.Token);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestEC2InstanceMetadataInsecureCredentialsRetry()
        {
            var token = string.Empty;
            var responses = new List<MultipleResponseServlet.Response>();            
            responses.Add(TokenFetchResponse(token, HttpStatusCode.NotFound));
            responses.Add(MetadataGetSecurityCredentialsResponse("Item1", token, HttpStatusCode.ServiceUnavailable));            
            responses.Add(MetadataGetSecurityCredentialsResponse("Item1", token, HttpStatusCode.OK));            
            responses.Add(MetadataGetSecurityCredentialsResponse("{\"AccessKeyId\": \"value1\", \"SecretAccessKey\": \"value2\", \"Token\": \"value3\"}",
                token, HttpStatusCode.OK));

            using (var servlet = new MultipleResponseServlet())
            {
                SetupResponseHandler(servlet, responses);
                var metadata = GetSecurityCredentials(servlet);
                Assert.IsNotNull(metadata);
                Assert.AreEqual(1, metadata.Count);
                Assert.IsTrue(metadata.ContainsKey("Item1"));
                var creds = metadata["Item1"];
                Assert.AreEqual("value1", creds.AccessKeyId);
                Assert.AreEqual("value2", creds.SecretAccessKey);
                Assert.AreEqual("value3", creds.Token);
            }
        }

        private static MultipleResponseServlet.Response TokenFetchResponse(string token, HttpStatusCode statusCode)
        {
            var headers = new Dictionary<string, string>();
            headers.Add(HeaderKeys.XAwsEc2MetadataTokenTtlSeconds, "21600");
            return new MultipleResponseServlet.Response
            {
                Contents = token,
                Headers = headers,
                StatusCode = (int)statusCode
            };
        }

        private static MultipleResponseServlet.Response MetadataGetSecurityCredentialsResponse(string contents, string token, HttpStatusCode statusCode)
        {
            var headers = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(token))
            {
                headers.Add(HeaderKeys.XAwsEc2MetadataToken, token);
            }            
            return new MultipleResponseServlet.Response
            {
                Contents = contents,
                Headers = headers,
                StatusCode = (int)statusCode
            };
        }

        private static void SetupResponseHandler(MultipleResponseServlet servlet, List<MultipleResponseServlet.Response> responses)
        {
            int requestCount = -1;
            servlet.OnRequest += path =>
            {
                requestCount++;
                if(requestCount >= responses.Count)
                {                    
                    Assert.Fail($"Number or responses requested {requestCount + 1} exceeds the number of mocked responses {responses.Count}.");
                }

                return responses[requestCount];
            };
        }

        private static IDictionary<string, IAMSecurityCredentialMetadata> GetSecurityCredentials(MultipleResponseServlet servlet)
        {
            var currentEMSValue = Environment.GetEnvironmentVariable(endpointEnvVar);

            Action setEMSAction = () => SetEC2InstanceMetadataEndpoint(servlet.ServiceURL);
            Action resetEMSAction = () => SetEC2InstanceMetadataEndpoint(currentEMSValue);

            using (new DisposableSwitch(setEMSAction, resetEMSAction))
            {
                var metadata = EC2InstanceMetadata.IAMSecurityCredentials;
                return metadata;
            }
        }

        private static void SetEC2InstanceMetadataEndpoint(string address)
        {
            Environment.SetEnvironmentVariable("AWS_EC2_METADATA_SERVICE_ENDPOINT", address);
            FallbackInternalConfigurationFactory.Reset();
        }

        private static FieldInfo ResetUseNullToken()
        {
            var nullTokenField = typeof(EC2InstanceMetadata).GetField("useNullToken", BindingFlags.NonPublic | BindingFlags.Static);
            nullTokenField.SetValue(null, false);
            Assert.IsFalse((bool)nullTokenField.GetValue(null));
            return nullTokenField;
        }
    }
}
