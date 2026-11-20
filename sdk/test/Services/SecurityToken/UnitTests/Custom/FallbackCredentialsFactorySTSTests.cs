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
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Amazon.SecurityToken.Model;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// This class contains Fallback Credentials Factory tests that must be completed wihtin the service assembly
    /// </summary>
    [TestClass]
    public class FallbackCredentialsFactorySTSTests
    {
        public void TestRetriesOnException<T>(T exception) where T : AmazonServiceException
        {
            var webIdentityToken = "Dummy.OIDC.Token";
            var roleArn = "someRoleArn";
            var roleSessionName = "someRoleSessionName";

            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");
            File.WriteAllText(webIdentityTokenFilePath, webIdentityToken);

            var envVariables = new Dictionary<string, string>()
            {
                {  AssumeRoleWithWebIdentityCredentials.WebIdentityTokenFileEnvVariable, webIdentityTokenFilePath },
                {  AssumeRoleWithWebIdentityCredentials.RoleArnEnvVariable, roleArn },
                {  AssumeRoleWithWebIdentityCredentials.RoleSessionNameEnvVariable, roleSessionName },
            };

            AWSCredentials awsCredentials;
            using (new FallbackFactoryTestFixture(envVariables))
            {
                awsCredentials = FallbackCredentialsFactory.GetCredentials();
            }

            var webIdentityCredentials = new AssumeRoleWithWebIdentityTestCredentials((AssumeRoleWithWebIdentityCredentials)awsCredentials, null);
            var retries = 0;
            var client = webIdentityCredentials.Client as AmazonSecurityTokenServiceClient;
            var pipeline = client
                .GetType()
                .GetProperty("RuntimePipeline", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .GetValue(client, null)
                as RuntimePipeline;
            // Setup STS failures
            var signer = new Mock<Signer>();
            signer.Setup(cr => cr.InvokeSync(It.IsAny<IExecutionContext>())).Throws(exception); // Setting up the exception here
            pipeline.ReplaceHandler<Signer>(signer.Object);
            // Setup retry count notifications
            var retryHandler = pipeline.Handlers.Find(h => h is RetryHandler) as RetryHandler;
            var notifyingRetryHandler = new NotifyingRetryHandler(client.Config);
            notifyingRetryHandler.AddHandler((object sender, RetryEventArgs e) => { retries++; });
            pipeline.ReplaceHandler<RetryHandler>(notifyingRetryHandler);
            var defaultRetryPolicy = new DefaultRetryPolicy(client.Config);

            using (new FallbackFactoryTestFixture(envVariables))
            {
                // Act and Assert
                Assert.ThrowsExactly<AmazonClientException>(() => webIdentityCredentials.GetCredentials());
            }

            Assert.AreEqual(defaultRetryPolicy.MaxRetries, retries);

            webIdentityCredentials.Dispose();
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_RetriesInvalidIdentityToken()
        {
            TestRetriesOnException(new InvalidIdentityTokenException("InvalidIdentityToken"));
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_RetriesIDPCommunicationErrors()
        {
            TestRetriesOnException(new IDPCommunicationErrorException("IDPCommunicationError"));
        }

        // ------------------------------------------------------------------------------------------------
        // On an ExpiredToken error from the STS call the provider reloads the (possibly rotated) OIDC token file and
        // retries the STS call, within the single refresh attempt. The exact modeled wire code is
        // "ExpiredTokenException" and it surfaces as the inner exception of the AmazonClientException that the STS
        // extension wraps every failure in.
        //
        // Each retry waits DefaultRetryPolicy.WaitBeforeRetry (100, 400 and 1000 ms), which has no test seam, so the
        // tests that exhaust the retries take about 1.5 seconds each.
        // ------------------------------------------------------------------------------------------------

        // The exact modeled STS wire code, pinned independently of the production constant.
        private const string ExpiredTokenWireCode = "ExpiredTokenException";

        private static AmazonClientException WrapExpiredToken() =>
            new AmazonClientException(
                "Error calling AssumeRole for role someRoleArn",
                new ExpiredTokenException("The web identity token that was passed is expired.") { ErrorCode = ExpiredTokenWireCode });

        // A token file with a unique name in the temp folder, so tests never share or collide on a file.
        private static string UniqueTokenFilePath()
            => Path.Combine(Path.GetTempPath(), "web-identity-token-" + Guid.NewGuid().ToString("N") + ".jwt");

        private static string WriteTokenFile(string contents)
        {
            var path = UniqueTokenFilePath();
            File.WriteAllText(path, contents);
            return path;
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_ExpiredToken_ReloadsTokenFileAndRetries()
        {
            const string firstToken = "first.oidc.token";
            const string secondToken = "second.oidc.token";
            var tokenPath = WriteTokenFile(firstToken);
            try
            {
                var capturedTokens = new List<string>();
                var callCount = 0;
                var mock = new Mock<ICoreAmazonSTS>();
                mock.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthentication(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                    .Returns((string token, string roleArn, string sessionName, AssumeRoleWithWebIdentityCredentialsOptions options) =>
                    {
                        capturedTokens.Add(token);
                        callCount++;
                        if (callCount == 1)
                        {
                            // Simulate the OIDC provider rotating the token on disk between the first and second STS calls.
                            File.WriteAllText(tokenPath, secondToken);
                            throw WrapExpiredToken();
                        }
                        return new AssumeRoleImmutableCredentials("ak", "sk", "st", DateTime.UtcNow.AddHours(1));
                    });

                using (var credentials = new AssumeRoleWithWebIdentityTestCredentials(tokenPath, "someRoleArn", "someRoleSessionName", new AssumeRoleWithWebIdentityCredentialsOptions()) { Client = mock.Object })
                {
                    var immutable = credentials.GetCredentials();

                    Assert.AreEqual("ak", immutable.AccessKey);
                    Assert.AreEqual(2, callCount, "Expected exactly one reload retry after ExpiredToken.");
                    Assert.AreEqual(firstToken, capturedTokens[0], "First STS call must use the original token.");
                    Assert.AreEqual(secondToken, capturedTokens[1], "Second STS call must use the reloaded (rotated) token.");
                }
            }
            finally
            {
                File.Delete(tokenPath);
            }
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_ExpiredToken_ExhaustsRetriesAndPropagates()
        {
            var tokenPath = WriteTokenFile("persistently.expired.token");
            try
            {
                var callCount = 0;
                var mock = new Mock<ICoreAmazonSTS>();
                mock.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthentication(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                    .Returns((string token, string roleArn, string sessionName, AssumeRoleWithWebIdentityCredentialsOptions options) =>
                    {
                        callCount++;
                        throw WrapExpiredToken();
                    });

                using (var credentials = new AssumeRoleWithWebIdentityTestCredentials(tokenPath, "someRoleArn", "someRoleSessionName", new AssumeRoleWithWebIdentityCredentialsOptions()) { Client = mock.Object })
                {
                    // No fabricated success: the wrapped ExpiredToken propagates so the base records the failed refresh.
                    Assert.ThrowsExactly<AmazonClientException>(() => credentials.GetCredentials());
                }

                // Initial attempt + AWSSDKUtils.DefaultMaxRetry (3) reloads = 4 total STS calls.
                Assert.AreEqual(4, callCount);
            }
            finally
            {
                File.Delete(tokenPath);
            }
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_NonExpiredTokenError_NotRetriedByReloadPath()
        {
            var tokenPath = WriteTokenFile("some.oidc.token");
            try
            {
                var callCount = 0;
                var mock = new Mock<ICoreAmazonSTS>();
                mock.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthentication(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                    .Returns((string token, string roleArn, string sessionName, AssumeRoleWithWebIdentityCredentialsOptions options) =>
                    {
                        callCount++;
                        // A different (non-expired) STS error: must NOT be caught by the reload path.
                        throw new AmazonClientException(
                            "Error calling AssumeRole for role someRoleArn",
                            new AmazonServiceException("Access denied.") { ErrorCode = "AccessDenied" });
                    });

                using (var credentials = new AssumeRoleWithWebIdentityTestCredentials(tokenPath, "someRoleArn", "someRoleSessionName", new AssumeRoleWithWebIdentityCredentialsOptions()) { Client = mock.Object })
                {
                    // AccessDenied is non-recoverable, so it is raised as AmazonNonRecoverableCredentialsException (an
                    // AmazonClientException) with the STS client's message and inner exception.
                    var ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => credentials.GetCredentials());
                    Assert.AreEqual("Error calling AssumeRole for role someRoleArn", ex.Message);
                    Assert.AreEqual("AccessDenied", ((AmazonServiceException)ex.InnerException).ErrorCode);
                }

                Assert.AreEqual(1, callCount, "A non-ExpiredToken error must propagate on the first STS call without a reload retry.");
            }
            finally
            {
                File.Delete(tokenPath);
            }
        }

        [TestMethod]
        public void TestAssumeRoleWithWebIdentity_FileReadFailure_Unchanged()
        {
            var tokenPath = UniqueTokenFilePath(); // never created

            var callCount = 0;
            var mock = new Mock<ICoreAmazonSTS>();
            mock.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthentication(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                .Returns((string token, string roleArn, string sessionName, AssumeRoleWithWebIdentityCredentialsOptions options) =>
                {
                    callCount++;
                    return new AssumeRoleImmutableCredentials("ak", "sk", "st", DateTime.UtcNow.AddHours(1));
                });

            using (var credentials = new AssumeRoleWithWebIdentityTestCredentials(tokenPath, "someRoleArn", "someRoleSessionName", new AssumeRoleWithWebIdentityCredentialsOptions()) { Client = mock.Object })
            {
                var ex = Assert.ThrowsExactly<InvalidOperationException>(() => credentials.GetCredentials());
                Assert.IsTrue(ex.Message.Contains("A token could not be loaded from the WebIdentityTokenFile."));
            }

            Assert.AreEqual(0, callCount, "The STS call must not be reached when the token file cannot be read.");
        }

        public async Task TestRetriesOnExceptionAsync<T>(T excpetion) where T : AmazonServiceException
        {
            var webIdentityToken = "Dummy.OIDC.Token";
            var roleArn = "someRoleArn";
            var roleSessionName = "someRoleSessionName";

            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");
            File.WriteAllText(webIdentityTokenFilePath, webIdentityToken);

            var envVariables = new Dictionary<string, string>()
            {
                {  AssumeRoleWithWebIdentityCredentials.WebIdentityTokenFileEnvVariable, webIdentityTokenFilePath },
                {  AssumeRoleWithWebIdentityCredentials.RoleArnEnvVariable, roleArn },
                {  AssumeRoleWithWebIdentityCredentials.RoleSessionNameEnvVariable, roleSessionName },
            };

            AWSCredentials awsCredentials;
            using (new FallbackFactoryTestFixture(envVariables))
            {
                awsCredentials = FallbackCredentialsFactory.GetCredentials();
            }

            var webIdentityCredentials = new AssumeRoleWithWebIdentityTestCredentials((AssumeRoleWithWebIdentityCredentials)awsCredentials, null);
            var retries = 0;
            var client = webIdentityCredentials.Client as AmazonSecurityTokenServiceClient;
            var pipeline = client
                .GetType()
                .GetProperty("RuntimePipeline", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .GetValue(client, null)
                as RuntimePipeline;
            // Setup STS failures
            var signer = new Mock<Signer>();
            signer.Setup(cr => cr.InvokeAsync<AssumeRoleWithWebIdentityResponse>(It.IsAny<IExecutionContext>())).ThrowsAsync(excpetion); // Setting up the exception here
            pipeline.ReplaceHandler<Signer>(signer.Object);
            // Setup retry count notifications
            var retryHandler = pipeline.Handlers.Find(h => h is RetryHandler) as RetryHandler;
            var notifyingRetryHandler = new NotifyingRetryHandler(client.Config);
            notifyingRetryHandler.AddHandler((object sender, RetryEventArgs e) => { retries++; });
            pipeline.ReplaceHandler<RetryHandler>(notifyingRetryHandler);
            var defaultRetryPolicy = new DefaultRetryPolicy(client.Config);

            using (new FallbackFactoryTestFixture(envVariables))
            {
                // Act and Assert
                await Assert.ThrowsExactlyAsync<AmazonClientException>(async () => await webIdentityCredentials.GetCredentialsAsync());
            }

            Assert.AreEqual(defaultRetryPolicy.MaxRetries, retries);

            webIdentityCredentials.Dispose();
        }

        [TestMethod]
        public async Task TestAssumeRoleWithWebIdentityAsync_RetriesInvalidIdentityToken()
        {
            await TestRetriesOnExceptionAsync(new InvalidIdentityTokenException("InvalidIdentityToken"));
        }

        [TestMethod]
        public async Task TestAssumeRoleWithWebIdentityAsync_RetriesIDPCommunicationErrors()
        {
            await TestRetriesOnExceptionAsync(new IDPCommunicationErrorException("IDPCommunicationError"));
        }

        // Async variants of the ExpiredToken reload tests. They compile and run on net472/netcoreapp3.1/net8.0.
        [TestMethod]
        public async System.Threading.Tasks.Task TestAssumeRoleWithWebIdentityAsync_ExpiredToken_ReloadsTokenFileAndRetriesAsync()
        {
            const string firstToken = "first.oidc.token";
            const string secondToken = "second.oidc.token";
            var tokenPath = WriteTokenFile(firstToken);
            try
            {
                var capturedTokens = new List<string>();
                var callCount = 0;
                var mock = new Mock<ICoreAmazonSTS>();
                mock.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                    .Returns((string token, string roleArn, string sessionName, AssumeRoleWithWebIdentityCredentialsOptions options) =>
                    {
                        capturedTokens.Add(token);
                        callCount++;
                        if (callCount == 1)
                        {
                            File.WriteAllText(tokenPath, secondToken);
                            throw WrapExpiredToken();
                        }
                        return System.Threading.Tasks.Task.FromResult(new AssumeRoleImmutableCredentials("ak", "sk", "st", DateTime.UtcNow.AddHours(1)));
                    });

                using (var credentials = new AssumeRoleWithWebIdentityTestCredentials(tokenPath, "someRoleArn", "someRoleSessionName", new AssumeRoleWithWebIdentityCredentialsOptions()) { Client = mock.Object })
                {
                    var immutable = await credentials.GetCredentialsAsync().ConfigureAwait(false);

                    Assert.AreEqual("ak", immutable.AccessKey);
                    Assert.AreEqual(2, callCount, "Expected exactly one reload retry after ExpiredToken.");
                    Assert.AreEqual(firstToken, capturedTokens[0], "First STS call must use the original token.");
                    Assert.AreEqual(secondToken, capturedTokens[1], "Second STS call must use the reloaded (rotated) token.");
                }
            }
            finally
            {
                File.Delete(tokenPath);
            }
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestAssumeRoleWithWebIdentityAsync_ExpiredToken_ExhaustsRetriesAndPropagatesAsync()
        {
            var tokenPath = WriteTokenFile("persistently.expired.token");
            try
            {
                var callCount = 0;
                var mock = new Mock<ICoreAmazonSTS>();
                mock.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                    .Returns((string token, string roleArn, string sessionName, AssumeRoleWithWebIdentityCredentialsOptions options) =>
                    {
                        callCount++;
                        throw WrapExpiredToken();
                    });

                using (var credentials = new AssumeRoleWithWebIdentityTestCredentials(tokenPath, "someRoleArn", "someRoleSessionName", new AssumeRoleWithWebIdentityCredentialsOptions()) { Client = mock.Object })
                {
                    await Assert.ThrowsExactlyAsync<AmazonClientException>(async () => await credentials.GetCredentialsAsync().ConfigureAwait(false));
                }

                // Initial attempt + AWSSDKUtils.DefaultMaxRetry (3) reloads = 4 total STS calls.
                Assert.AreEqual(4, callCount);
            }
            finally
            {
                File.Delete(tokenPath);
            }
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestAssumeRoleWithWebIdentityAsync_NonExpiredTokenError_NotRetriedByReloadPathAsync()
        {
            var tokenPath = WriteTokenFile("some.oidc.token");
            try
            {
                var callCount = 0;
                var mock = new Mock<ICoreAmazonSTS>();
                mock.Setup(c => c.CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<AssumeRoleWithWebIdentityCredentialsOptions>()))
                    .Returns((string token, string roleArn, string sessionName, AssumeRoleWithWebIdentityCredentialsOptions options) =>
                    {
                        callCount++;
                        throw new AmazonClientException(
                            "Error calling AssumeRole for role someRoleArn",
                            new AmazonServiceException("Access denied.") { ErrorCode = "AccessDenied" });
                    });

                using (var credentials = new AssumeRoleWithWebIdentityTestCredentials(tokenPath, "someRoleArn", "someRoleSessionName", new AssumeRoleWithWebIdentityCredentialsOptions()) { Client = mock.Object })
                {
                    // AccessDenied is non-recoverable, so it is raised as AmazonNonRecoverableCredentialsException (an
                    // AmazonClientException) with the STS client's message and inner exception.
                    var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(async () => await credentials.GetCredentialsAsync().ConfigureAwait(false));
                    Assert.AreEqual("Error calling AssumeRole for role someRoleArn", ex.Message);
                    Assert.AreEqual("AccessDenied", ((AmazonServiceException)ex.InnerException).ErrorCode);
                }

                Assert.AreEqual(1, callCount, "A non-ExpiredToken error must propagate on the first STS call without a reload retry.");
            }
            finally
            {
                File.Delete(tokenPath);
            }
        }
    }

    public class RetryEventArgs
    {
        public RetryEventArgs(IExecutionContext executionContext)
        {
            RetryExecutionContext = executionContext;
        }

        public IExecutionContext RetryExecutionContext { get; set; }
    }

    public class NotifyingDefaultRetryPolicy : SecurityTokenServiceRetryPolicy
    {
        public delegate void RetryEventHandler(object sender, RetryEventArgs e);

        public event RetryEventHandler EventHandler;

        public NotifyingDefaultRetryPolicy(IClientConfig config) : base(config)
        {
            MaxBackoffInMilliseconds = 1;
        }

        public override bool RetryForException(IExecutionContext executionContext, Exception exception)
        {
            EventHandler?.Invoke(this, new RetryEventArgs(executionContext));
            return base.RetryForException(executionContext, exception);
        }

        public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
        {
            EventHandler?.Invoke(this, new RetryEventArgs(executionContext));
            return base.RetryForExceptionAsync(executionContext, exception);
        }
    }

    public class NotifyingRetryHandler : RetryHandler
    {
        public NotifyingRetryHandler(IClientConfig config) : base(new NotifyingDefaultRetryPolicy(config)) { }

        public void AddHandler(NotifyingDefaultRetryPolicy.RetryEventHandler eventHandler)
        {
            (RetryPolicy as NotifyingDefaultRetryPolicy).EventHandler += eventHandler;
        }

        public void RemoveHandler(NotifyingDefaultRetryPolicy.RetryEventHandler eventHandler)
        {
            (RetryPolicy as NotifyingDefaultRetryPolicy).EventHandler -= eventHandler;
        }
    }

    public class AssumeRoleWithWebIdentityTestCredentials : AssumeRoleWithWebIdentityCredentials
    {
        public ICoreAmazonSTS Client { get; set; }
        public AssumeRoleWithWebIdentityTestCredentials(string webIdentityTokenFile, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
            : base(webIdentityTokenFile, roleArn, roleSessionName, options)
        {
            Client = base.CreateClient();
        }

        public AssumeRoleWithWebIdentityTestCredentials(AssumeRoleWithWebIdentityCredentials baseCreds, AssumeRoleWithWebIdentityCredentialsOptions options)
            : base(baseCreds.WebIdentityTokenFile, baseCreds.RoleArn, baseCreds.RoleSessionName, options)
        {
            Client = base.CreateClient();
        }

        protected override ICoreAmazonSTS CreateClient()
        {
            return Client;
        }
    }

    public class FallbackFactoryTestFixture : IDisposable
    {
        private readonly Dictionary<string, string> originalEnvironmentVariables = new Dictionary<string, string>();

        public FallbackFactoryTestFixture(Dictionary<string, string> newEnvironmentVariables = null)
        {
            if (newEnvironmentVariables != null)
            {
                foreach (KeyValuePair<string, string> envVariable in newEnvironmentVariables)
                {
                    var originalValue = Environment.GetEnvironmentVariable(envVariable.Key);
                    Environment.SetEnvironmentVariable(envVariable.Key, envVariable.Value);
                    originalEnvironmentVariables.Add(envVariable.Key, originalValue);
                }
            }

            // reset before use to ensure the new credentialProfileChains are used.
            FallbackCredentialsFactory.Reset();
            FallbackRegionFactory.Reset();
            FallbackInternalConfigurationFactory.Reset();
        }

        public void Dispose()
        {
            foreach (KeyValuePair<string, string> envVariable in originalEnvironmentVariables)
            {
                Environment.SetEnvironmentVariable(envVariable.Key, envVariable.Value);
            }

            FallbackCredentialsFactory.Reset();
            FallbackRegionFactory.Reset();
            FallbackInternalConfigurationFactory.Reset();
        }
    }
}
