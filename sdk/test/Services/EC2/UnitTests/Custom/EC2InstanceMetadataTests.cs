#if NETFRAMEWORK
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using Amazon.Util;
using AWSSDK.UnitTests;
using AWSSDK_DotNet.CommonTest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.UnitTests.EC2
{
    [TestClass]
    public class EC2InstanceMetadataTests
    {
        private readonly IAMSecurityCredentialMetadata _fakeValidIamSecurityCredentialMetadata = new IAMSecurityCredentialMetadata
        {
            AccessKeyId = "value1",
            SecretAccessKey = "value2",
            Token = "value3"
        };

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestAccessingEC2InstanceMetadataProperties()
        {
            using (var servlet = new EC2InstanceMetadataServlet())
            {
                var allMembers = typeof(EC2InstanceMetadata).GetMembers(BindingFlags.Public | BindingFlags.Static);
                foreach (var member in allMembers)
                {
                    servlet.AddMetadataGenericResponse(string.Empty, string.Empty, HttpStatusCode.NotFound);

                    var fi = member as FieldInfo;
                    var pi = member as PropertyInfo;

                    object value;

                    // make and exception for IsIMDSEnabled property or the IMDS endpoint and URI helpers
                    if (pi != null && !pi.Name.Equals("IsIMDSEnabled") && !pi.Name.Equals("ServiceEndpoint") && !pi.Name.StartsWith("EC2"))
                    {
                        value = pi.GetValue(null);
                        // all properties should return null on non-EC2 instances
                        Assert.IsNull(value, $"Property {pi.Name} should be null");
                    }
                    else if (fi != null)
                    {
                        value = fi.GetValue(null);
                        // all fields should return non-null on non-EC2 instances
                        Assert.IsNotNull(value, $"Field {fi.Name} should not be null");
                    }
                }
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestEC2InstanceMetadata401Unauthorized()
        {
            var token = "ValidToken";

            using (var servlet = new EC2InstanceMetadataServlet())
            {
                servlet.AddTokenFetchResponse(token);
                servlet.AddMetadataGetSecurityCredentialsResponse(new IAMSecurityCredentialMetadata(), token, HttpStatusCode.Unauthorized);
                var wex = Assert.ThrowsExactly<WebException>(() =>
                {
                    var metadata = EC2InstanceMetadata.IAMSecurityCredentials;
                });
                var response = wex.Response as HttpWebResponse;
                Assert.IsNotNull(response);
                Assert.AreEqual(HttpStatusCode.Unauthorized, response.StatusCode);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestEC2InstanceMetadataAPIToken400BadRequest()
        {
            using (var servlet = new EC2InstanceMetadataServlet())
            {
                servlet.AddTokenFetchResponse(string.Empty, HttpStatusCode.BadRequest);
                servlet.AddTokenFetchResponse(string.Empty, HttpStatusCode.BadRequest);
                servlet.AddTokenFetchResponse(string.Empty, HttpStatusCode.BadRequest);
                var wex = Assert.ThrowsExactly<WebException>(() =>
                {
                    var metadata = EC2InstanceMetadata.FetchApiToken();
                });
                var response = wex.Response as HttpWebResponse;
                Assert.IsNotNull(response);
                Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestEC2InstanceMetadataSecureCredentialsSuccess()
        {
            var token = "ValidToken";
            
            using (var servlet = new EC2InstanceMetadataServlet())
            {
                servlet.AddTokenFetchResponse(token);
                servlet.AddMetadataGenericResponse("Item1", token, HttpStatusCode.OK);
                servlet.AddTokenFetchResponse(token);
                servlet.AddMetadataGetSecurityCredentialsResponse(_fakeValidIamSecurityCredentialMetadata, token);

                var metadata = EC2InstanceMetadata.IAMSecurityCredentials;

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
        public async Task TestEC2InstanceMetadataSecureCredentialsSuccessAsync()
        {
            var token = "ValidToken";

            using (var servlet = new EC2InstanceMetadataServlet())
            {
                servlet.AddTokenFetchResponse(token);
                servlet.AddMetadataGenericResponse("Item1", token, HttpStatusCode.OK);
                servlet.AddTokenFetchResponse(token);
                servlet.AddMetadataGetSecurityCredentialsResponse(_fakeValidIamSecurityCredentialMetadata, token);

                var metadata = await EC2InstanceMetadata.GetIAMSecurityCredentialsAsync();

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
        public void TestEC2InstanceMetadataFailFastStatusCodes()
        {
            var failFastStatusCodes = new HttpStatusCode[]
            {
                HttpStatusCode.NotFound,
                HttpStatusCode.Forbidden,
                HttpStatusCode.MethodNotAllowed
            };

            foreach (var failFastStatusCode in failFastStatusCodes)
            {
                var token = string.Empty;
                
                using (var servlet = new EC2InstanceMetadataServlet())
                {
                    servlet.AddTokenFetchResponse(token, failFastStatusCode);

                    Assert.ThrowsExactly<InvalidOperationException>(() => EC2InstanceMetadata.FetchApiToken(), "IMDS rejected request to get API token.");
                }
            }
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestEC2InstanceMetadataTokenNotFound()
        {
            var token = string.Empty;

            using (var servlet = new EC2InstanceMetadataServlet())
            {
                servlet.AddTokenFetchResponse(token, HttpStatusCode.NotFound);

                Assert.ThrowsExactly<InvalidOperationException>(() => EC2InstanceMetadata.FetchApiToken());
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestEC2InstanceMetadataSecureCredentialsRetry()
        {
            var token = "ValidToken";

            using (var servlet = new EC2InstanceMetadataServlet())
            {
                servlet.AddTokenFetchResponse(string.Empty, HttpStatusCode.ServiceUnavailable);
                servlet.AddTokenFetchResponse(token);
                servlet.AddMetadataGenericResponse("Item1", token, HttpStatusCode.ServiceUnavailable);
                servlet.AddMetadataGenericResponse("Item1", token, HttpStatusCode.OK);
                servlet.AddTokenFetchResponse(token);
                servlet.AddMetadataGetSecurityCredentialsResponse(_fakeValidIamSecurityCredentialMetadata, token);

                var metadata = EC2InstanceMetadata.IAMSecurityCredentials;

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
}
#endif
