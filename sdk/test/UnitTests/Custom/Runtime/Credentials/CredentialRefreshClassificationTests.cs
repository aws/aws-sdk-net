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
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Settings;
using Amazon.Runtime.SharedInterfaces;
using Amazon.RuntimeDependencies;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.Util;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for how credential refresh failures are classified as recoverable or non-recoverable: STS errors that
    /// the STS client wraps, non-recoverable errors raised by the source credentials of an assume-role provider, the
    /// SSO and Login token managers, and the scope of the SAML federated credentials provider.
    /// <para />
    /// A non-recoverable error is raised to the caller immediately and does not arm the refresh backoff; a
    /// recoverable error on a refresh that has cached credentials serves those credentials and arms the backoff.
    /// </summary>
    [TestClass]
    public sealed class CredentialRefreshClassificationTests
    {
        private const string TestRoleArn = "arn:aws:iam::123456789012:role/classification-test";
        private const string TestRoleSessionName = "classification-test";
        private const string SsoRemediationMessage = "SSO Token has expired and can not be refreshed. Please reauthenticate.";
        private const string LoginRemediationMessage = "Login Token has expired and failed to refresh. Please reauthenticate.";

        #region Classifier

        private sealed class ClassifierProbe : RefreshingAWSCredentials
        {
            public bool IsNonRecoverable(Exception e) => IsNonRecoverableError(e);
        }

        private static AmazonClientException WrappedByStsClient(Exception stsError) =>
            new AmazonClientException("Error calling AssumeRole for role " + TestRoleArn, stsError);

        private static Exception StsError(string errorCode)
        {
            switch (errorCode)
            {
                case "IDPRejectedClaim":
                    return new IDPRejectedClaimException("rejected", null, ErrorType.Sender, errorCode, "req-id", HttpStatusCode.Forbidden);
                case "InvalidIdentityToken":
                    return new InvalidIdentityTokenException("invalid", null, ErrorType.Sender, errorCode, "req-id", HttpStatusCode.BadRequest);
                case "MalformedPolicyDocument":
                    return new MalformedPolicyDocumentException("malformed", null, ErrorType.Sender, errorCode, "req-id", HttpStatusCode.BadRequest);
                case "PackedPolicyTooLarge":
                    return new PackedPolicyTooLargeException("too large", null, ErrorType.Sender, errorCode, "req-id", HttpStatusCode.BadRequest);
                case "RegionDisabledException":
                    return new RegionDisabledException("STS is not activated in this region", null, ErrorType.Sender, errorCode, "req-id", HttpStatusCode.Forbidden);
                case "ExpiredTokenException":
                    return new ExpiredTokenException("expired", null, ErrorType.Sender, errorCode, "req-id", HttpStatusCode.BadRequest);
                default:
                    return new AmazonSecurityTokenServiceException("sts error", null, ErrorType.Sender, errorCode, "req-id", HttpStatusCode.Forbidden);
            }
        }

        [TestMethod]
        [DataRow("AccessDenied")]
        [DataRow("IDPRejectedClaim")]
        [DataRow("InvalidIdentityToken")]
        [DataRow("MalformedPolicyDocument")]
        [DataRow("PackedPolicyTooLarge")]
        [DataRow("RegionDisabled")]
        [DataRow("RegionDisabledException")]
        public void StsNonRecoverableCode_WrappedByStsClient_IsNonRecoverable(string errorCode)
        {
            var probe = new ClassifierProbe();

            Assert.IsTrue(probe.IsNonRecoverable(StsError(errorCode)), "unwrapped STS error");
            Assert.IsTrue(probe.IsNonRecoverable(WrappedByStsClient(StsError(errorCode))),
                "the STS client wraps STS errors in an AmazonClientException; the classifier must see through it");
        }

        [TestMethod]
        public void NonRecoverableCredentialsException_NestedInAssumeRoleChain_IsNonRecoverable()
        {
            var probe = new ClassifierProbe();
            var sourceError = new AmazonNonRecoverableCredentialsException(SsoRemediationMessage);

            // One wrapper per assume-role hop over a source profile.
            Assert.IsTrue(probe.IsNonRecoverable(WrappedByStsClient(sourceError)));
            Assert.IsTrue(probe.IsNonRecoverable(WrappedByStsClient(WrappedByStsClient(sourceError))));
        }

        [TestMethod]
        public void TransientErrors_WrappedByStsClient_AreRecoverable()
        {
            var probe = new ClassifierProbe();
            var transientErrors = new Exception[]
            {
                new IOException("The connection was reset."),
                new WebException("The remote name could not be resolved."),
                new TimeoutException(),
                new TaskCanceledException(),
                new AmazonServiceException("Unable to reach credentials server", new IOException("connection refused")),
                StsError("Throttling"),
                StsError("ServiceUnavailable"),
                StsError("InternalFailure"),
                StsError("IDPCommunicationError"),
                // The source credentials served under static stability have expired; STS rejects them until the
                // source refreshes.
                StsError("ExpiredToken"),
                StsError("ExpiredTokenException"),
                new AmazonSecurityTokenServiceException("Service Unavailable", new IOException(), ErrorType.Receiver, null, "req-id", HttpStatusCode.ServiceUnavailable),
#if !NETFRAMEWORK
                new System.Net.Http.HttpRequestException("No such host is known.", new IOException()),
#endif
            };

            foreach (var error in transientErrors)
            {
                Assert.IsFalse(probe.IsNonRecoverable(error), "unwrapped " + Describe(error));
                Assert.IsFalse(probe.IsNonRecoverable(WrappedByStsClient(error)), "wrapped " + Describe(error));
            }
        }

        [TestMethod]
        public void FirstServiceExceptionWithAnErrorCode_DecidesTheClassification()
        {
            var probe = new ClassifierProbe();

            // A throttled STS response is recoverable even if something beneath it carries a non-recoverable code:
            // the outermost service exception with a code is the credential source's answer.
            var throttledOverDenied = new AmazonServiceException("throttled", StsError("AccessDenied"), ErrorType.Sender,
                "Throttling", "req-id", HttpStatusCode.BadRequest);
            Assert.IsFalse(probe.IsNonRecoverable(WrappedByStsClient(throttledOverDenied)));

            // A service exception without a code does not stop the walk.
            var uncodedOverDenied = new AmazonServiceException("Unable to retrieve credentials.", StsError("AccessDenied"));
            Assert.IsTrue(probe.IsNonRecoverable(WrappedByStsClient(uncodedOverDenied)));
        }

        private static string Describe(Exception e) =>
            e.GetType().Name + ((e as AmazonServiceException)?.ErrorCode is string code ? " (" + code + ")" : string.Empty);

        #endregion

        #region AssumeRole and AssumeRoleWithWebIdentity through the real STS client

        /// <summary>
        /// A real STS client whose pipeline throws the configured exception in place of the HTTP call, so the
        /// ICoreAmazonSTS implementation applies its real wrapping. Retries are disabled so each call is one send.
        /// </summary>
        private sealed class ThrowingStsClient : AmazonSecurityTokenServiceClient
        {
            private int _sendCount;
            public Func<Exception> ExceptionFactory { get; set; }
            public int SendCount => Volatile.Read(ref _sendCount);

            public ThrowingStsClient(Func<Exception> exceptionFactory)
                : base(new BasicAWSCredentials("AKIDSTSCALLER", "secret"),
                       new AmazonSecurityTokenServiceConfig { RegionEndpoint = RegionEndpoint.USEast1, MaxErrorRetry = 0 })
            {
                ExceptionFactory = exceptionFactory;
            }

            protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
            {
                base.CustomizeRuntimePipeline(pipeline);
                pipeline.AddHandlerAfter<ErrorHandler>(new ThrowHandler(this));
            }

            private sealed class ThrowHandler : PipelineHandler
            {
                private readonly ThrowingStsClient _owner;
                public ThrowHandler(ThrowingStsClient owner) { _owner = owner; }

                public override void InvokeSync(IExecutionContext executionContext)
                {
                    Interlocked.Increment(ref _owner._sendCount);
                    throw _owner.ExceptionFactory();
                }

                public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
                {
                    Interlocked.Increment(ref _owner._sendCount);
                    return Task.FromException<T>(_owner.ExceptionFactory());
                }
            }
        }

        // The first generation is seeded without calling STS. Its 30 second lifetime is shorter than the one minute
        // expiration buffer, so the next call is a blocking refresh that has cached credentials to fall back on.
        private static RefreshingAWSCredentials.CredentialsRefreshState SeededState() =>
            new RefreshingAWSCredentials.CredentialsRefreshState(
                new ImmutableCredentials("ASIASEEDED", "seed-secret", "seed-token"),
                AWSSDKUtils.CorrectedUtcNow.AddSeconds(30));

        private sealed class SeededAssumeRoleCredentials : AssumeRoleAWSCredentials
        {
            private int _generations;

            public SeededAssumeRoleCredentials(AWSCredentials sourceCredentials)
                : base(sourceCredentials, TestRoleArn, TestRoleSessionName) { }

            protected override CredentialsRefreshState GenerateNewCredentials()
                => Interlocked.Increment(ref _generations) == 1 ? SeededState() : base.GenerateNewCredentials();

            protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
                => Interlocked.Increment(ref _generations) == 1 ? Task.FromResult(SeededState()) : base.GenerateNewCredentialsAsync();
        }

        private sealed class SeededWebIdentityCredentials : AssumeRoleWithWebIdentityCredentials
        {
            private readonly ICoreAmazonSTS _stsClient;
            private int _generations;

            public SeededWebIdentityCredentials(string webIdentityTokenFile, ICoreAmazonSTS stsClient)
                : base(webIdentityTokenFile, TestRoleArn, TestRoleSessionName)
            {
                _stsClient = stsClient;
            }

            protected override ICoreAmazonSTS CreateClient() => _stsClient;

            protected override CredentialsRefreshState GenerateNewCredentials()
                => Interlocked.Increment(ref _generations) == 1 ? SeededState() : base.GenerateNewCredentials();

            protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
                => Interlocked.Increment(ref _generations) == 1 ? Task.FromResult(SeededState()) : base.GenerateNewCredentialsAsync();
        }

        /// <summary>
        /// Source credentials that fail with a non-recoverable error, like an SSO or Login source profile whose
        /// session has expired.
        /// </summary>
        private sealed class NonRecoverableSourceCredentials : AWSCredentials
        {
            private int _calls;
            public AmazonNonRecoverableCredentialsException Error { get; }
            public int Calls => Volatile.Read(ref _calls);

            public NonRecoverableSourceCredentials(string message)
            {
                Error = new AmazonNonRecoverableCredentialsException(message);
            }

            public override ImmutableCredentials GetCredentials()
            {
                Interlocked.Increment(ref _calls);
                throw Error;
            }

            public override Task<ImmutableCredentials> GetCredentialsAsync()
            {
                Interlocked.Increment(ref _calls);
                return Task.FromException<ImmutableCredentials>(Error);
            }
        }

        private static void RegisterStsClient(ThrowingStsClient stsClient) =>
            GlobalRuntimeDependencyRegistry.Instance.RegisterSecurityTokenServiceClient(stsClient);

        // The registry has no way to unregister; a factory that returns null restores the default lookup.
        private static void ResetStsClientRegistration() =>
            GlobalRuntimeDependencyRegistry.Instance.RegisterSecurityTokenServiceClient((RuntimeDependencyFactory)(context => null));

        private static AmazonSecurityTokenServiceException StsAccessDenied() =>
            new AmazonSecurityTokenServiceException(
                "User: arn:aws:iam::123456789012:user/test is not authorized to perform: sts:AssumeRole",
                null, ErrorType.Sender, "AccessDenied", "req-id", HttpStatusCode.Forbidden);

        [TestMethod]
        public void AssumeRole_StsAccessDeniedOnRefresh_RaisedImmediately_NoBackoff()
        {
            var sts = new ThrowingStsClient(StsAccessDenied);
            RegisterStsClient(sts);
            try
            {
                var creds = new SeededAssumeRoleCredentials(new BasicAWSCredentials("AKIDSOURCE", "secret"));
                creds.NonRecoverableErrorCacheGenerator = () => TimeSpan.Zero; // let the next call re-attempt at once
                Assert.AreEqual("ASIASEEDED", creds.GetCredentials().AccessKey);

                // Raised as AmazonNonRecoverableCredentialsException with the STS client's message and the STS error as
                // its inner exception, the same message and inner exception as the STS client's AmazonClientException.
                var ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
                StringAssert.StartsWith(ex.Message, "Error calling AssumeRole for role ");
                var stsError = ex.InnerException as AmazonSecurityTokenServiceException;
                Assert.IsNotNull(stsError, "the STS error is the inner exception, as in the STS client's exception");
                Assert.AreEqual("AccessDenied", stsError.ErrorCode);
                Assert.AreEqual(1, sts.SendCount);

                // No refresh backoff was armed and the cached credentials are not served: the next call contacts
                // STS again and raises the error again.
                Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
                Assert.AreEqual(2, sts.SendCount);
            }
            finally
            {
                ResetStsClientRegistration();
                sts.Dispose();
            }
        }

        [TestMethod]
        public async Task AssumeRole_StsRegionDisabledOnRefresh_RaisedImmediately_NoBackoff_Async()
        {
            var sts = new ThrowingStsClient(() => StsError("RegionDisabledException"));
            RegisterStsClient(sts);
            try
            {
                var creds = new SeededAssumeRoleCredentials(new BasicAWSCredentials("AKIDSOURCE", "secret"));
                creds.NonRecoverableErrorCacheGenerator = () => TimeSpan.Zero;
                Assert.AreEqual("ASIASEEDED", (await creds.GetCredentialsAsync()).AccessKey);

                var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentialsAsync());
                Assert.IsInstanceOfType(ex.InnerException, typeof(RegionDisabledException));
                Assert.AreEqual(1, sts.SendCount);

                await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentialsAsync());
                Assert.AreEqual(2, sts.SendCount);
            }
            finally
            {
                ResetStsClientRegistration();
                sts.Dispose();
            }
        }

        [TestMethod]
        public void AssumeRole_StsAccessDeniedOnRefresh_IsCachedBrieflyAsNonRecoverable()
        {
            var sts = new ThrowingStsClient(StsAccessDenied);
            RegisterStsClient(sts);
            try
            {
                var creds = new SeededAssumeRoleCredentials(new BasicAWSCredentials("AKIDSOURCE", "secret"));
                creds.NonRecoverableErrorCacheGenerator = () => TimeSpan.FromMinutes(5);
                creds.GetCredentials();

                var first = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
                var second = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());

                Assert.AreSame(first, second, "the cached non-recoverable error is re-raised");
                Assert.AreEqual(1, sts.SendCount, "STS is not contacted while the error is cached");
            }
            finally
            {
                ResetStsClientRegistration();
                sts.Dispose();
            }
        }

        private static Exception TransientStsFailure(string kind)
        {
            switch (kind)
            {
                case "Throttling":
                    return new AmazonSecurityTokenServiceException("Rate exceeded", null, ErrorType.Sender, "Throttling", "req-id", HttpStatusCode.BadRequest);
                case "ServiceUnavailable":
                    return new AmazonSecurityTokenServiceException("Service Unavailable", null, ErrorType.Receiver, "ServiceUnavailable", "req-id", HttpStatusCode.ServiceUnavailable);
                case "IOException":
                    return new IOException("Unable to read data from the transport connection.");
                default:
                    throw new ArgumentOutOfRangeException(nameof(kind));
            }
        }

        [TestMethod]
        [DataRow("Throttling")]
        [DataRow("ServiceUnavailable")]
        [DataRow("IOException")]
        public void AssumeRole_TransientStsFailureOnRefresh_ServesCachedCredentials_AndBacksOff(string kind)
        {
            var sts = new ThrowingStsClient(() => TransientStsFailure(kind));
            RegisterStsClient(sts);
            try
            {
                var creds = new SeededAssumeRoleCredentials(new BasicAWSCredentials("AKIDSOURCE", "secret"));
                creds.GetCredentials();

                Assert.AreEqual("ASIASEEDED", creds.GetCredentials().AccessKey, "static stability serves cached credentials");
                Assert.AreEqual("ASIASEEDED", creds.GetCredentials().AccessKey);
                Assert.AreEqual(1, sts.SendCount, "the refresh backoff suppresses the next attempt");
            }
            finally
            {
                ResetStsClientRegistration();
                sts.Dispose();
            }
        }

        [TestMethod]
        [DataRow("Throttling")]
        [DataRow("ServiceUnavailable")]
        [DataRow("IOException")]
        public async Task AssumeRole_TransientStsFailureOnRefresh_ServesCachedCredentials_AndBacksOff_Async(string kind)
        {
            var sts = new ThrowingStsClient(() => TransientStsFailure(kind));
            RegisterStsClient(sts);
            try
            {
                var creds = new SeededAssumeRoleCredentials(new BasicAWSCredentials("AKIDSOURCE", "secret"));
                await creds.GetCredentialsAsync();

                Assert.AreEqual("ASIASEEDED", (await creds.GetCredentialsAsync()).AccessKey);
                Assert.AreEqual("ASIASEEDED", (await creds.GetCredentialsAsync()).AccessKey);
                Assert.AreEqual(1, sts.SendCount);
            }
            finally
            {
                ResetStsClientRegistration();
                sts.Dispose();
            }
        }

        private static string CreateWebIdentityTokenFile()
        {
            var path = Path.Combine(Path.GetTempPath(), "classification-test-" + Guid.NewGuid().ToString("N") + ".jwt");
            File.WriteAllText(path, "Dummy.OIDC.Token");
            return path;
        }

        [TestMethod]
        public void WebIdentity_StsInvalidIdentityTokenOnRefresh_RaisedImmediately_NoBackoff()
        {
            var tokenFile = CreateWebIdentityTokenFile();
            using (var sts = new ThrowingStsClient(() => StsError("InvalidIdentityToken")))
            {
                try
                {
                    var creds = new SeededWebIdentityCredentials(tokenFile, sts);
                    creds.NonRecoverableErrorCacheGenerator = () => TimeSpan.Zero;
                    creds.GetCredentials();

                    var ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
                    Assert.IsInstanceOfType(ex.InnerException, typeof(InvalidIdentityTokenException));

                    Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
                    Assert.AreEqual(2, sts.SendCount, "no refresh backoff after a non-recoverable STS error");
                }
                finally
                {
                    File.Delete(tokenFile);
                }
            }
        }

        [TestMethod]
        public async Task WebIdentity_StsIdpRejectedClaimOnRefresh_RaisedImmediately_NoBackoff_Async()
        {
            var tokenFile = CreateWebIdentityTokenFile();
            using (var sts = new ThrowingStsClient(() => StsError("IDPRejectedClaim")))
            {
                try
                {
                    var creds = new SeededWebIdentityCredentials(tokenFile, sts);
                    creds.NonRecoverableErrorCacheGenerator = () => TimeSpan.Zero;
                    await creds.GetCredentialsAsync();

                    var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentialsAsync());
                    Assert.IsInstanceOfType(ex.InnerException, typeof(IDPRejectedClaimException));

                    await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentialsAsync());
                    Assert.AreEqual(2, sts.SendCount, "no refresh backoff after a non-recoverable STS error");
                }
                finally
                {
                    File.Delete(tokenFile);
                }
            }
        }

        [TestMethod]
        public void ChainedAssumeRole_SourceRaisesNonRecoverableError_RaisedWithSourceMessage()
        {
            // With no STS client registered, the provider builds a real STS client signed by the source credentials.
            ResetStsClientRegistration();
            var source = new NonRecoverableSourceCredentials(SsoRemediationMessage);
            var creds = new SeededAssumeRoleCredentials(source);
            creds.NonRecoverableErrorCacheGenerator = () => TimeSpan.Zero;
            creds.GetCredentials();

            // Raised as AmazonNonRecoverableCredentialsException with the STS client's message; the source's error is in
            // its inner exceptions, as in the STS client's exception.
            var ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
            StringAssert.StartsWith(ex.Message, "Error calling AssumeRole for role ");
            Assert.AreSame(source.Error, FindInChain<AmazonNonRecoverableCredentialsException>(ex.InnerException),
                "the source's non-recoverable error is surfaced, not masked by cached credentials");
            Assert.AreEqual(SsoRemediationMessage, source.Error.Message);
            var callsAfterFirstFailure = source.Calls;

            // No refresh backoff: the next call asks the source again.
            Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
            Assert.IsTrue(source.Calls > callsAfterFirstFailure, "the refresh is re-attempted instead of being backed off");
        }

        [TestMethod]
        public async Task ChainedAssumeRole_SourceRaisesNonRecoverableError_RaisedWithSourceMessage_Async()
        {
            ResetStsClientRegistration();
            var source = new NonRecoverableSourceCredentials(LoginRemediationMessage);
            var creds = new SeededAssumeRoleCredentials(source);
            creds.NonRecoverableErrorCacheGenerator = () => TimeSpan.Zero;
            await creds.GetCredentialsAsync();

            var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentialsAsync());
            StringAssert.StartsWith(ex.Message, "Error calling AssumeRole for role ");
            Assert.AreSame(source.Error, FindInChain<AmazonNonRecoverableCredentialsException>(ex.InnerException));
            Assert.AreEqual(LoginRemediationMessage, source.Error.Message);
            var callsAfterFirstFailure = source.Calls;

            await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentialsAsync());
            Assert.IsTrue(source.Calls > callsAfterFirstFailure, "the refresh is re-attempted instead of being backed off");
        }

        private static T FindInChain<T>(Exception exception) where T : Exception
        {
            for (var current = exception; current != null; current = current.InnerException)
            {
                if (current is T match)
                    return match;
            }
            return null;
        }

        #endregion

        #region SSO token manager

        // The token cache file name for this start URL (see SSOTokenManagerTests.ValidateTokenCacheLocation).
        private const string SsoStartUrl = "https://d-abc123.awsapps.com/start";
        private const string SsoCacheFolder = "classification-test";
        private const string SsoCacheFile = "40a89917e3175433e361b710a9d43528d7f1890a.json";
        private const string MissingSsoTokenMessage = "No valid SSO Token could be found. Please reauthenticate.";

        private static SSOTokenManager NewSsoTokenManager(MockFileSystem fileSystem) =>
            new SSOTokenManager(
                new Mock<ICoreAmazonSSOOIDC>().Object,
                new SSOTokenFileCache(CryptoUtilFactory.CryptoInstance, fileSystem, fileSystem));

        // As SSOAWSCredentials passes by default: the SDK does not start a new SSO login on its own.
        private static SSOTokenManagerGetTokenOptions SsoOptions() => new SSOTokenManagerGetTokenOptions
        {
            StartUrl = SsoStartUrl,
            CacheFolderLocation = SsoCacheFolder,
            SupportsGettingNewToken = false
        };

        private static MockFileSystem SsoCacheWithFileContents(string json)
        {
            var fileSystem = new MockFileSystem();
            fileSystem.WriteAllText(Path.Combine(SsoCacheFolder, SsoCacheFile), json);
            return fileSystem;
        }

        [TestMethod]
        public async Task SsoTokenManager_MissingCachedToken_ThrowsNonRecoverable_Async()
        {
            var manager = NewSsoTokenManager(new MockFileSystem());

            var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(
                () => manager.GetTokenAsync(SsoOptions()));
            Assert.AreEqual(MissingSsoTokenMessage, ex.Message);
        }

        [TestMethod]
        [DataRow("{ \"expiresAt\": \"3000-12-25T21:30:00Z\" }")]  // missing accessToken
        [DataRow("{ \"accessToken\": \"cachedToken\" }")]         // missing expiresAt
        [DataRow("{ \"accessToken\": \"cachedToken\", ")]         // not valid JSON
        public async Task SsoTokenManager_MalformedCachedToken_ThrowsNonRecoverable_Async(string json)
        {
            var manager = NewSsoTokenManager(SsoCacheWithFileContents(json));

            var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(
                () => manager.GetTokenAsync(SsoOptions()));
            Assert.AreEqual(MissingSsoTokenMessage, ex.Message);
        }

        // An expired cached token without a refresh token, when the SDK does not start a new SSO login.
        [TestMethod]
        public async Task SsoTokenManager_ExpiredTokenThatCannotBeRefreshed_ThrowsNonRecoverable_Async()
        {
            var manager = NewSsoTokenManager(SsoCacheWithFileContents(
                "{ \"accessToken\": \"cachedToken\", \"expiresAt\": \"2000-01-01T00:00:00Z\" }"));

            var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(
                () => manager.GetTokenAsync(SsoOptions()));
            Assert.AreEqual("SSO Token has expired and can not be refreshed. Please reauthenticate.", ex.Message);
        }

        private SSOTokenManager ExpiredRefreshableSsoTokenManager(Exception refreshFailure)
        {
            var oidc = new Mock<ICoreAmazonSSOOIDC>();
            oidc.Setup(c => c.RefreshTokenAsync(It.IsAny<GetSsoTokenResponse>())).ThrowsAsync(refreshFailure);
            var fileSystem = SsoCacheWithFileContents(
                "{ \"accessToken\": \"cachedToken\", \"expiresAt\": \"2000-01-01T00:00:00Z\", " +
                "\"clientId\": \"clientid\", \"clientSecret\": \"YSBzZWNyZXQ=\", " +
                "\"registrationExpiresAt\": \"3000-12-25T21:30:00Z\", \"refreshToken\": \"cachedrefreshtoken\", " +
                "\"region\": \"us-west-2\", \"startUrl\": \"" + SsoStartUrl + "\" }");
            return new SSOTokenManager(oidc.Object, new SSOTokenFileCache(CryptoUtilFactory.CryptoInstance, fileSystem, fileSystem));
        }

        // An expired cached token whose refresh fails for a reason that a later attempt can resolve (SSO OIDC
        // unavailable): recoverable, so the credential provider keeps its cached credentials and applies the refresh
        // backoff. Calls during the 30-second refresh cooldown raise the same failure, with the same cause.
        [TestMethod]
        public async Task SsoTokenManager_ExpiredTokenWhoseRefreshFailsTransiently_ThrowsRecoverable_Async()
        {
            var refreshFailure = new AmazonServiceException("The SSO OIDC service is unavailable.");
            var manager = ExpiredRefreshableSsoTokenManager(refreshFailure);

            var ex = await Assert.ThrowsExactlyAsync<AmazonClientException>(() => manager.GetTokenAsync(SsoOptions()));
            Assert.AreEqual("SSO Token has expired and failed to refresh", ex.Message);
            Assert.AreSame(refreshFailure, ex.InnerException);

            var duringCooldown = await Assert.ThrowsExactlyAsync<AmazonClientException>(() => manager.GetTokenAsync(SsoOptions()));
            Assert.AreEqual("SSO Token has expired and failed to refresh", duringCooldown.Message);
            Assert.AreSame(refreshFailure, duringCooldown.InnerException, "calls during the cooldown keep the cause");
        }

        // An expired cached token whose refresh SSO OIDC rejects (the refresh token or client registration is invalid,
        // expired or revoked): non-recoverable, with the OIDC error as the inner exception, also during the cooldown.
        [TestMethod]
        [DataRow("InvalidGrantException")]
        [DataRow("ExpiredTokenException")]
        [DataRow("InvalidClientException")]
        [DataRow("UnauthorizedClientException")]
        [DataRow("AccessDeniedException")]
        [DataRow("InvalidRequestException")]
        public async Task SsoTokenManager_ExpiredTokenWhoseRefreshIsRejected_ThrowsNonRecoverable_Async(string errorCode)
        {
            var refreshFailure = new AmazonServiceException("The refresh was rejected.") { ErrorCode = errorCode };
            var manager = ExpiredRefreshableSsoTokenManager(refreshFailure);

            var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(
                () => manager.GetTokenAsync(SsoOptions()));
            Assert.AreEqual("SSO Token has expired and failed to refresh. Please reauthenticate.", ex.Message);
            Assert.AreSame(refreshFailure, ex.InnerException);

            var duringCooldown = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(
                () => manager.GetTokenAsync(SsoOptions()));
            Assert.AreSame(refreshFailure, duringCooldown.InnerException);
        }

#if NETFRAMEWORK
        // The synchronous SSOTokenManager.GetToken exists only on .NET Framework.
        [TestMethod]
        public void SsoTokenManager_MissingCachedToken_ThrowsNonRecoverable()
        {
            var manager = NewSsoTokenManager(new MockFileSystem());

            var ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => manager.GetToken(SsoOptions()));
            Assert.AreEqual(MissingSsoTokenMessage, ex.Message);
        }

        [TestMethod]
        [DataRow("{ \"expiresAt\": \"3000-12-25T21:30:00Z\" }")]
        [DataRow("{ \"accessToken\": \"cachedToken\" }")]
        [DataRow("{ \"accessToken\": \"cachedToken\", ")]
        public void SsoTokenManager_MalformedCachedToken_ThrowsNonRecoverable(string json)
        {
            var manager = NewSsoTokenManager(SsoCacheWithFileContents(json));

            var ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => manager.GetToken(SsoOptions()));
            Assert.AreEqual(MissingSsoTokenMessage, ex.Message);
        }
#endif

        #endregion

        #region Login token manager

        private const string RecoverableLoginMessage = "Login Token has expired and failed to refresh.";

        private static LoginToken RefreshableLoginToken(DateTime expiresAt) => new LoginToken
        {
            AccessToken = new LoginImmutableCredentials("AKIALOGIN", "secret", "token", expiresAt, "123456789012"),
            RefreshToken = "refresh-token",
            ClientId = "client-id",
            DPoPKey = "dpop-key"
        };

        private static Mock<ILoginTokenFileCache> LoginFileCacheReturning(LoginToken token)
        {
            var fileCache = new Mock<ILoginTokenFileCache>();
            var cached = token;
            fileCache.Setup(x => x.TryGetLoginToken(It.IsAny<string>(), It.IsAny<string>(), out cached)).Returns(true);
            fileCache.Setup(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                     .ReturnsAsync(() => new TryResponse<LoginToken> { Success = true, Value = token });
            return fileCache;
        }

        private static Mock<ICoreAmazonSignin> SigninThrowing(Exception error)
        {
            var signin = new Mock<ICoreAmazonSignin>();
#if NETFRAMEWORK
            signin.Setup(x => x.CreateOAuth2Token(It.IsAny<CoreCreateOAuth2TokenRequest>(), It.IsAny<bool>())).Throws(error);
#endif
            signin.Setup(x => x.CreateOAuth2TokenAsync(It.IsAny<CoreCreateOAuth2TokenRequest>(), It.IsAny<bool>(), It.IsAny<CancellationToken>()))
                  .ThrowsAsync(error);
            return signin;
        }

        private static int SigninCalls(Mock<ICoreAmazonSignin> signin) =>
            signin.Invocations.Count;

        private static LoginTokenManagerGetTokenOptions LoginOptions() =>
            new LoginTokenManagerGetTokenOptions { LoginSession = "classification-test-" + Guid.NewGuid().ToString("N") };

        private static Exception TransientSigninFailure(string kind)
        {
            switch (kind)
            {
                case "ServiceUnavailable":
                    return new AmazonServiceException("Service Unavailable", null, ErrorType.Receiver, "ServiceUnavailable", "req-id", HttpStatusCode.ServiceUnavailable);
                case "Throttling":
                    return new AmazonServiceException("Too many requests", null, ErrorType.Sender, "TooManyRequestsError", "req-id", (HttpStatusCode)429);
                case "IOException":
                    return new IOException("Unable to read data from the transport connection.");
                default:
                    throw new ArgumentOutOfRangeException(nameof(kind));
            }
        }

        private static void WithSdkCache(bool enabled, Action body)
        {
            var original = AWSConfigs.UseSdkCache;
            AWSConfigs.UseSdkCache = enabled;
            try { body(); }
            finally { AWSConfigs.UseSdkCache = original; }
        }

        private static async Task WithSdkCacheAsync(bool enabled, Func<Task> body)
        {
            var original = AWSConfigs.UseSdkCache;
            AWSConfigs.UseSdkCache = enabled;
            try { await body(); }
            finally { AWSConfigs.UseSdkCache = original; }
        }

        [TestMethod]
        [DataRow("ServiceUnavailable")]
        [DataRow("Throttling")]
        [DataRow("IOException")]
        public async Task LoginTokenManager_ExpiredToken_TransientRefreshFailure_ThrowsRecoverable_Async(string kind)
        {
            await WithSdkCacheAsync(false, async () =>
            {
                var error = TransientSigninFailure(kind);
                var signin = SigninThrowing(error);
                var manager = new LoginTokenManager(signin.Object,
                    LoginFileCacheReturning(RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(-5))).Object);

                var ex = await Assert.ThrowsExactlyAsync<AmazonClientException>(() => manager.GetTokenAsync(LoginOptions()));

                Assert.AreEqual(RecoverableLoginMessage + " " + ex.InnerException?.Message, ex.Message, "a transient failure does not ask the user to reauthenticate");
                Assert.AreSame(error, ex.InnerException);
                Assert.AreEqual(1, SigninCalls(signin));
            });
        }

        [TestMethod]
        public async Task LoginTokenManager_ExpiredToken_MissingDPoPKey_ThrowsNonRecoverable_Async()
        {
            await WithSdkCacheAsync(false, async () =>
            {
                var signin = SigninThrowing(new InvalidOperationException("Sign-In must not be called"));
                var token = RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(-5));
                token.DPoPKey = null;
                var manager = new LoginTokenManager(signin.Object, LoginFileCacheReturning(token).Object);

                var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => manager.GetTokenAsync(LoginOptions()));

                Assert.AreEqual(LoginRemediationMessage, ex.Message);
                Assert.AreEqual(0, SigninCalls(signin));
            });
        }

        [TestMethod]
        public async Task LoginTokenManager_TransientFailureBeforeExpiry_ThenExpired_RetriesRefresh_Async()
        {
            await WithSdkCacheAsync(true, async () =>
            {
                var now = AWSSDKUtils.CorrectedUtcNow;
                using (new AWSConfigsDateFaker(() => now))
                {
                    var t0 = now;
                    var token = RefreshableLoginToken(t0.AddMinutes(3)); // inside the refresh window, not expired
                    var signin = SigninThrowing(TransientSigninFailure("ServiceUnavailable"));
                    var manager = new LoginTokenManager(signin.Object, LoginFileCacheReturning(token).Object);
                    var options = LoginOptions();

                    // The refresh fails while the token is still valid: the valid token is returned.
                    Assert.AreSame(token, await manager.GetTokenAsync(options));
                    Assert.AreEqual(1, SigninCalls(signin));

                    // Once the token has expired, the refresh is attempted again, and the transient failure stays
                    // recoverable instead of being reported as a token that cannot be refreshed.
                    now = t0.AddMinutes(4);
                    var ex = await Assert.ThrowsExactlyAsync<AmazonClientException>(() => manager.GetTokenAsync(options));
                    Assert.AreEqual(RecoverableLoginMessage + " " + ex.InnerException?.Message, ex.Message);
                    Assert.AreEqual(2, SigninCalls(signin));
                }
            });
        }

#if NETFRAMEWORK
        // The synchronous LoginTokenManager.GetToken exists only on .NET Framework.
        [TestMethod]
        [DataRow("ServiceUnavailable")]
        [DataRow("Throttling")]
        [DataRow("IOException")]
        public void LoginTokenManager_ExpiredToken_TransientRefreshFailure_ThrowsRecoverable(string kind)
        {
            WithSdkCache(false, () =>
            {
                var error = TransientSigninFailure(kind);
                var signin = SigninThrowing(error);
                var manager = new LoginTokenManager(signin.Object,
                    LoginFileCacheReturning(RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(-5))).Object);

                var ex = Assert.ThrowsExactly<AmazonClientException>(() => manager.GetToken(LoginOptions()));

                Assert.AreEqual(RecoverableLoginMessage + " " + ex.InnerException?.Message, ex.Message);
                Assert.AreSame(error, ex.InnerException);
                Assert.AreEqual(1, SigninCalls(signin));
            });
        }

        [TestMethod]
        public void LoginTokenManager_ExpiredToken_MissingDPoPKey_ThrowsNonRecoverable()
        {
            WithSdkCache(false, () =>
            {
                var signin = SigninThrowing(new InvalidOperationException("Sign-In must not be called"));
                var token = RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(-5));
                token.DPoPKey = null;
                var manager = new LoginTokenManager(signin.Object, LoginFileCacheReturning(token).Object);

                var ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => manager.GetToken(LoginOptions()));

                Assert.AreEqual(LoginRemediationMessage, ex.Message);
                Assert.AreEqual(0, SigninCalls(signin));
            });
        }

        [TestMethod]
        public void LoginTokenManager_TransientFailureBeforeExpiry_ThenExpired_RetriesRefresh()
        {
            WithSdkCache(true, () =>
            {
                var now = AWSSDKUtils.CorrectedUtcNow;
                using (new AWSConfigsDateFaker(() => now))
                {
                    var t0 = now;
                    var token = RefreshableLoginToken(t0.AddMinutes(3));
                    var signin = SigninThrowing(TransientSigninFailure("ServiceUnavailable"));
                    var manager = new LoginTokenManager(signin.Object, LoginFileCacheReturning(token).Object);
                    var options = LoginOptions();

                    Assert.AreSame(token, manager.GetToken(options));
                    Assert.AreEqual(1, SigninCalls(signin));

                    now = t0.AddMinutes(4);
                    var ex = Assert.ThrowsExactly<AmazonClientException>(() => manager.GetToken(options));
                    Assert.AreEqual(RecoverableLoginMessage + " " + ex.InnerException?.Message, ex.Message);
                    Assert.AreEqual(2, SigninCalls(signin));
                }
            });
        }
#endif

        private static LoginAWSCredentials NewLoginCredentials(Mock<ICoreAmazonSignin> signin, LoginToken token)
        {
            // The constructor builds its Sign-In client through the registry; the token manager is then replaced
            // with one that reads the test token.
            GlobalRuntimeDependencyRegistry.Instance.RegisterSigninClient(signin.Object);
            var credentials = new LoginAWSCredentials(new LoginAWSCredentialsOptions
            {
                LoginSession = "classification-test-" + Guid.NewGuid().ToString("N"),
                Region = "us-east-1",
                ProfileName = "classification-test"
            });
            var field = typeof(LoginAWSCredentials).GetField("_loginTokenManager", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(field, "LoginAWSCredentials._loginTokenManager");
            field.SetValue(credentials, new LoginTokenManager(signin.Object, LoginFileCacheReturning(token).Object));
            return credentials;
        }

        private static void ResetSigninClientRegistration() =>
            GlobalRuntimeDependencyRegistry.Instance.RegisterSigninClient((RuntimeDependencyFactory)(context => null));

        [TestMethod]
        public void LoginCredentials_ExpiredToken_TransientSigninFailure_ServesCachedCredentials()
        {
            WithSdkCache(true, () =>
            {
                var now = AWSSDKUtils.CorrectedUtcNow;
                using (new AWSConfigsDateFaker(() => now))
                {
                    var t0 = now;
                    var signin = SigninThrowing(TransientSigninFailure("ServiceUnavailable"));
                    try
                    {
                        var login = NewLoginCredentials(signin, RefreshableLoginToken(t0.AddMinutes(60)));
                        var cached = login.GetCredentials();
                        Assert.AreEqual(0, SigninCalls(signin));

                        // The credentials and the login token have expired and Sign-In is unavailable: static
                        // stability serves the cached credentials and backs off further refresh attempts.
                        now = t0.AddMinutes(61);
                        Assert.AreEqual(cached, login.GetCredentials());
                        Assert.AreEqual(cached, login.GetCredentials());
                        Assert.AreEqual(1, SigninCalls(signin));
                    }
                    finally
                    {
                        ResetSigninClientRegistration();
                    }
                }
            });
        }

        [TestMethod]
        public async Task LoginCredentials_ExpiredToken_TransientSigninFailure_ServesCachedCredentials_Async()
        {
            await WithSdkCacheAsync(true, async () =>
            {
                var now = AWSSDKUtils.CorrectedUtcNow;
                using (new AWSConfigsDateFaker(() => now))
                {
                    var t0 = now;
                    var signin = SigninThrowing(TransientSigninFailure("ServiceUnavailable"));
                    try
                    {
                        var login = NewLoginCredentials(signin, RefreshableLoginToken(t0.AddMinutes(60)));
                        var cached = await login.GetCredentialsAsync();
                        Assert.AreEqual(0, SigninCalls(signin));

                        now = t0.AddMinutes(61);
                        Assert.AreEqual(cached, await login.GetCredentialsAsync());
                        Assert.AreEqual(cached, await login.GetCredentialsAsync());
                        Assert.AreEqual(1, SigninCalls(signin));
                    }
                    finally
                    {
                        ResetSigninClientRegistration();
                    }
                }
            });
        }

        #endregion

        #region Federated (SAML) credentials

        /// <summary>
        /// A <see cref="FederatedAWSCredentials"/> whose first generation is seeded and whose later generations fail,
        /// without contacting a SAML endpoint.
        /// </summary>
        private sealed class ProbeFederatedCredentials : FederatedAWSCredentials
        {
            private int _generations;
            public Exception RefreshError { get; } = new AmazonClientException("Credential generation from SAML authentication failed.");

            public ProbeFederatedCredentials()
                : base(new SAMLEndpoint("classification-test", new Uri("https://saml.example.com")), TestRoleArn) { }

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                if (Interlocked.Increment(ref _generations) == 1)
                    return SeededState();
                throw RefreshError;
            }

            protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
            {
                if (Interlocked.Increment(ref _generations) == 1)
                    return Task.FromResult(SeededState());
                return Task.FromException<CredentialsRefreshState>(RefreshError);
            }
        }

        [TestMethod]
        [OSCondition(OperatingSystems.Windows)] // the SAML role session store only exists on Windows
        public void Federated_FailedRefresh_PropagatesError_WithoutServingCachedCredentials()
        {
            using (new EncryptedStoreTestFixture(SettingsConstants.RegisteredRoleSessions))
            {
                var creds = new ProbeFederatedCredentials();
                creds.GetCredentials();

                // SAML federation is outside the credential refresh specification's scope, so it keeps the earlier
                // behavior: a failed refresh is raised to the caller and the next call tries again.
                var ex = Assert.ThrowsExactly<AmazonClientException>(() => creds.GetCredentials());
                Assert.AreSame(creds.RefreshError, ex);
                Assert.ThrowsExactly<AmazonClientException>(() => creds.GetCredentials());
            }
        }

        [TestMethod]
        [OSCondition(OperatingSystems.Windows)]
        public async Task Federated_FailedRefresh_PropagatesError_WithoutServingCachedCredentials_Async()
        {
            using (new EncryptedStoreTestFixture(SettingsConstants.RegisteredRoleSessions))
            {
                var creds = new ProbeFederatedCredentials();
                await creds.GetCredentialsAsync();

                var ex = await Assert.ThrowsExactlyAsync<AmazonClientException>(() => creds.GetCredentialsAsync());
                Assert.AreSame(creds.RefreshError, ex);
                await Assert.ThrowsExactlyAsync<AmazonClientException>(() => creds.GetCredentialsAsync());
            }
        }

        [TestMethod]
        [OSCondition(OperatingSystems.Windows)]
        public void Federated_PreemptExpiryTime_IsFifteenMinutes()
        {
            using (new EncryptedStoreTestFixture(SettingsConstants.RegisteredRoleSessions))
            {
                Assert.AreEqual(TimeSpan.FromMinutes(15), new ProbeFederatedCredentials().PreemptExpiryTime);
            }
        }

        #endregion
    }
}
