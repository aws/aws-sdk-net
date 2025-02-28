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
#if ASYNC_AWAIT
using System.Threading.Tasks;
#endif

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
                Assert.ThrowsException<AmazonClientException>(() => webIdentityCredentials.GetCredentials());
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

#if ASYNC_AWAIT
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
                await Assert.ThrowsExceptionAsync<AmazonClientException>(async () => await webIdentityCredentials.GetCredentialsAsync());
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
#endif
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

#if ASYNC_AWAIT
        public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
        {
            EventHandler?.Invoke(this, new RetryEventArgs(executionContext));
            return base.RetryForExceptionAsync(executionContext, exception);
        }
#endif
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
