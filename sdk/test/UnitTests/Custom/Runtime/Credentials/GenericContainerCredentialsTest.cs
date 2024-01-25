/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class GenericContainerCredentialsTest
    {
        private string cachedRelativeUriVariable;
        private string cachedFullUriVariable;
        private string cachedTokenValueVariable;
        private string cachedTokenFileVariable;

        private string _tempFile;
        private readonly string staticTokenValue = "Basic static%20token";

        [TestInitialize]
        public void TestSetup()
        {
            cachedRelativeUriVariable = Environment.GetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable);
            cachedFullUriVariable = Environment.GetEnvironmentVariable(GenericContainerCredentials.FullURIEnvVariable);
            cachedTokenValueVariable = Environment.GetEnvironmentVariable(GenericContainerCredentials.AuthorizationTokenEnvVariable);
            cachedTokenFileVariable = Environment.GetEnvironmentVariable(GenericContainerCredentials.AuthorizationTokenFileEnvVariable);

            // If running these tests on ECS or CodeBuild, the environment variables may already be set.
            // We'll temporarily remove them for the test cases in this class.
            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, string.Empty);
            Environment.SetEnvironmentVariable(GenericContainerCredentials.FullURIEnvVariable, string.Empty);
            Environment.SetEnvironmentVariable(GenericContainerCredentials.AuthorizationTokenEnvVariable, string.Empty);
            Environment.SetEnvironmentVariable(GenericContainerCredentials.AuthorizationTokenFileEnvVariable, string.Empty);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, cachedRelativeUriVariable);
            Environment.SetEnvironmentVariable(GenericContainerCredentials.FullURIEnvVariable, cachedFullUriVariable);
            Environment.SetEnvironmentVariable(GenericContainerCredentials.AuthorizationTokenEnvVariable, cachedTokenValueVariable);
            Environment.SetEnvironmentVariable(GenericContainerCredentials.AuthorizationTokenFileEnvVariable, cachedTokenFileVariable);

            if (File.Exists(_tempFile))
            {
                File.Delete(_tempFile);
            }
        }

        [DataTestMethod]
        [DataRow("", false)]
        [DataRow("http://192.168.1.1/endpoint", false)] // Forbidden host
        [DataRow("http://169.254.170.3/endpoint", false)] // Forbidden link-local host
        [DataRow("https://awscredentials.amazonaws.com/credentials", true)] // HTTPS URI
        [DataRow("http://127.0.0.2/credentials", true)] // HTTP loopback(v4) URI
        [DataRow("http://[::1]/credentials", true)] // HTTP loopback(v6) URI
        [DataRow("http://169.254.170.2/credentials", true)] // HTTP link-local ECS URI
        [DataRow("http://169.254.170.23/credentials", true)] // HTTP link-local EKS URI
        [DataRow("http://127.0.0.1:8080/credentials?foo=bar%20baz", true)] // Complex URI
        public void TestValidateHost_FullUri(string fullUri, bool isValid)
        {
            Environment.SetEnvironmentVariable(GenericContainerCredentials.FullURIEnvVariable, fullUri);

            if (isValid)
            {
                var expectedEndpoint = new Uri(fullUri);

                var provider = new GenericContainerCredentials();
                provider.DetermineEndpoint();
                Assert.AreEqual(expectedEndpoint, provider.ResolvedEndpointUri);
            }
            else
            {
                Assert.ThrowsException<ArgumentException>(() => new GenericContainerCredentials());
            }
        }

        [TestMethod]
        public void TestValidateHost_RelativeUri()
        {
            var expectedEndpoint = new Uri("http://169.254.170.2/endpoint");
            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, "/endpoint");

            var provider = new GenericContainerCredentials();
            provider.DetermineEndpoint();
            Assert.IsNotNull(provider.ResolvedEndpointUri);
            Assert.AreEqual(expectedEndpoint, provider.ResolvedEndpointUri);
        }

        [TestMethod]
        public void TestAuthorizationHeader_InvalidPath()
        {
            var nonExistentPath = Guid.NewGuid().ToString();
            Environment.SetEnvironmentVariable(GenericContainerCredentials.AuthorizationTokenFileEnvVariable, nonExistentPath);

            Assert.ThrowsException<FileNotFoundException>(() => GenericContainerCredentials.CreateAuthorizationHeader());
        }

        [TestMethod]
        public void TestAuthorizationHeader_InvalidSequence()
        {
            Environment.SetEnvironmentVariable(GenericContainerCredentials.AuthorizationTokenEnvVariable, "basic\r\ntoken");

            Assert.ThrowsException<InvalidOperationException>(() => GenericContainerCredentials.CreateAuthorizationHeader());
        }

        [TestMethod]
        public void TestAuthorizationHeader_ValidPath()
        {
            _tempFile = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            File.WriteAllText(_tempFile, staticTokenValue);

            Environment.SetEnvironmentVariable(GenericContainerCredentials.AuthorizationTokenFileEnvVariable, _tempFile);

            var headers = GenericContainerCredentials.CreateAuthorizationHeader();
            ValidateHeaders(headers);
        }

        [TestMethod]
        public void TestAuthorizationHeader_ValidToken()
        {
            Environment.SetEnvironmentVariable(GenericContainerCredentials.AuthorizationTokenEnvVariable, staticTokenValue);

            var headers = GenericContainerCredentials.CreateAuthorizationHeader();
            ValidateHeaders(headers);
        }

        [TestMethod]
        public void TestParsingResponse_200Result()
        {
            var relativeUri = "/LocalTest/Endpoint/";
            var expiration = DateTime.UtcNow.AddHours(1).ToString("s") + "Z";

            using (var servlet = new ResponseTestServlet(relativeUri))
            {
                var baseUri = "http://localhost:" + servlet.Port;
                Environment.SetEnvironmentVariable(GenericContainerCredentials.FullURIEnvVariable, $"{baseUri}{relativeUri}");

                servlet.Response =
$@"{{
    ""Foo"": ""bar"",
    ""AccessKeyId"" : ""foo"",
    ""SecretAccessKey"" : ""bar"",
    ""AccountId"" : ""qux"",
    ""Token"" : ""baz"",
    ""Expiration"" : ""{expiration}""
}}";

                var provider = new GenericContainerCredentials();
                ImmutableCredentials credentials = provider.GetCredentials();

                Assert.IsNotNull(credentials);
                Assert.AreEqual("foo", credentials.AccessKey);
                Assert.AreEqual("bar", credentials.SecretKey);
                Assert.AreEqual("baz", credentials.Token);
            }
        }

        [DataTestMethod]
        [DataRow(301)]
        [DataRow(401)]
        [DataRow(429)]
        [DataRow(500)]
        public void TestParsingResponse_Non200Result(int statusCode)
        {
            // The provider will return a message similar to:
            // Unable to retrieve credentials. Message = "The remote server returned an error: (301) Moved Permanently Redirect."
            var errorMessageRegex = new Regex($"({statusCode})");

            // These test cases also take longer (up to 30s) as the provider will attempt 4 times (on non-successful responses) before
            // throwing an exception to the caller.
            using (var servlet = new ErrorServlet(statusCode))
            {
                var fullUri = "http://localhost:" + servlet.Port;
                Environment.SetEnvironmentVariable(GenericContainerCredentials.FullURIEnvVariable, fullUri);

                if (statusCode == 401)
                {
                    // Unauthorized responses may contain extra details in the body
                    servlet.Response = "{\"Code\":\"TokenNotFound\"}";
                }

                var provider = new GenericContainerCredentials();
                AssertExtensions.ExpectException(() => provider.GetCredentials(), typeof(AmazonServiceException), errorMessageRegex);
            }
        }

        private void ValidateHeaders(Dictionary<string, string> headers)
        {
            Assert.IsNotNull(headers);
            Assert.AreEqual(1, headers.Count);

            var header = headers.First();
            Assert.AreEqual("Authorization", header.Key);
            Assert.AreEqual(staticTokenValue, header.Value);
        }
    }
}
