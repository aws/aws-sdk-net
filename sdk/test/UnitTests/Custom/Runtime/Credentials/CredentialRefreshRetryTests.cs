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
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Identity;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.Util;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Pipeline tests for requests that a service rejects with <c>ExpiredToken</c> or <c>ExpiredTokenException</c>,
    /// whatever the HTTP status code; <c>InvalidToken</c> is not such a rejection. When the
    /// request was signed with refreshing credentials that support invalidation, the pipeline invalidates those
    /// credentials and retries the request through the configured retry policy, re-signed with credentials resolved
    /// again. For any other identity the error is left to the retry policy, as before.
    /// <para />
    /// Each test runs RetryHandler -> Signer -> a fake transport that records what each attempt was signed with and
    /// returns a scripted response. Backoff is disabled and the clock is fixed, so no test sleeps.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class CredentialRefreshRetryTests : RuntimePipelineTestBase
    {
        private const int MaxRetries = 2;
        private static readonly DateTime Now = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public enum PolicyKind
        {
            Legacy,
            Standard,
            Adaptive,
        }

        #region In-scope credentials: invalidate and retry

        [TestMethod]
        [DataRow("ExpiredToken", PolicyKind.Legacy, false)]
        [DataRow("ExpiredToken", PolicyKind.Legacy, true)]
        [DataRow("ExpiredToken", PolicyKind.Standard, false)]
        [DataRow("ExpiredToken", PolicyKind.Standard, true)]
        [DataRow("ExpiredToken", PolicyKind.Adaptive, false)]
        [DataRow("ExpiredToken", PolicyKind.Adaptive, true)]
        [DataRow("ExpiredTokenException", PolicyKind.Legacy, false)]
        [DataRow("ExpiredTokenException", PolicyKind.Legacy, true)]
        [DataRow("ExpiredTokenException", PolicyKind.Standard, false)]
        [DataRow("ExpiredTokenException", PolicyKind.Standard, true)]
        [DataRow("ExpiredTokenException", PolicyKind.Adaptive, false)]
        [DataRow("ExpiredTokenException", PolicyKind.Adaptive, true)]
        public async Task RejectedOnce_RetriedOnceWithRefreshedCredentials(string errorCode, PolicyKind kind, bool useAsync)
        {
            var creds = new RetryTestCredentials(new TestClock());
            var scenario = BuildScenario(creds, attempt => attempt == 1 ? Rejection(errorCode) : null, kind);

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.IsNull(thrown, "the retry signed with refreshed credentials should succeed");
            Assert.AreEqual(2, scenario.Transport.Attempts, "exactly one retry");
            Assert.AreEqual(1, scenario.Context.RequestContext.Retries);
            CollectionAssert.AreEqual(new[] { "AKIA_RETRY_1", "AKIA_RETRY_2" }, scenario.Transport.SentAccessKeys,
                "the retry must be signed with the credentials obtained after invalidation");
            CollectionAssert.AreEqual(new[] { "token_1", "token_2" }, scenario.Transport.SentTokens);
            CollectionAssert.AreEqual(new[] { "AKIA_RETRY_1", "AKIA_RETRY_2" }, scenario.Signer.SignedAccessKeys,
                "the retry must be re-signed");
            Assert.AreEqual(2, creds.GenerateCount);

            // The retry is charged exactly like the retry of any other retryable error.
            var control = BuildScenario(new RetryTestCredentials(new TestClock()), attempt => attempt == 1 ? ServerError() : null, kind);
            Assert.IsNull(await InvokeAsync(control, useAsync));
            Assert.IsTrue(scenario.Transport.CapacityAtAttempt[1] < scenario.Transport.CapacityAtAttempt[0],
                "the retry must consume retry capacity");
            CollectionAssert.AreEqual(control.Transport.CapacityAtAttempt, scenario.Transport.CapacityAtAttempt,
                "an invalid credential retry must consume the same retry capacity as a server error retry");
            Assert.AreEqual(control.Capacity.AvailableCapacity, scenario.Capacity.AvailableCapacity);
        }

        // RetryPolicy.Retry has a separate branch for the newer retry behavior (RetryPolicy.UseNewRetries2026); the
        // invalid credential retry must work there too.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task RejectedOnce_NewRetryBehavior_RetriedOnceWithRefreshedCredentials(bool useAsync)
        {
            var original = RetryPolicy.UseNewRetries2026;
            RetryPolicy.UseNewRetries2026 = true;
            try
            {
                var creds = new RetryTestCredentials(new TestClock());
                var scenario = BuildScenario(creds, attempt => attempt == 1 ? Rejection("ExpiredToken") : null, PolicyKind.Standard);

                var thrown = await InvokeAsync(scenario, useAsync);

                Assert.IsNull(thrown, "the retry signed with refreshed credentials should succeed");
                Assert.AreEqual(2, scenario.Transport.Attempts, "exactly one retry");
                CollectionAssert.AreEqual(new[] { "AKIA_RETRY_1", "AKIA_RETRY_2" }, scenario.Transport.SentAccessKeys,
                    "the retry must be signed with the credentials obtained after invalidation");
                Assert.AreEqual(2, creds.GenerateCount);
            }
            finally
            {
                RetryPolicy.UseNewRetries2026 = original;
            }
        }

        // ExpiredTokenException is an invalid credential error whatever the HTTP status code it comes with, such as 400
        // or 403.
        [TestMethod]
        [DataRow(400, false)]
        [DataRow(400, true)]
        [DataRow(403, false)]
        [DataRow(403, true)]
        public async Task ExpiredTokenException_AnyStatusCode_InvalidatedAndRetriedWithRefreshedCredentials(int statusCode, bool useAsync)
        {
            var creds = new RetryTestCredentials(new TestClock());
            var scenario = BuildScenario(creds,
                attempt => attempt == 1 ? Rejection("ExpiredTokenException", (HttpStatusCode)statusCode) : null);

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.IsNull(thrown, "the retry signed with refreshed credentials should succeed");
            Assert.AreEqual(2, scenario.Transport.Attempts, "exactly one retry");
            CollectionAssert.AreEqual(new[] { "AKIA_RETRY_1", "AKIA_RETRY_2" }, scenario.Transport.SentAccessKeys,
                "the rejected credentials must be invalidated and the retry signed with refreshed ones");
            CollectionAssert.AreEqual(new[] { "AKIA_RETRY_1", "AKIA_RETRY_2" }, scenario.Signer.SignedAccessKeys,
                "the retry must be re-signed");
            Assert.AreEqual(2, creds.GenerateCount);
        }

        // InvalidToken is returned for tokens other than the signing credentials, such as Step Functions task tokens, so
        // it does not invalidate the credentials, and the request is not retried for them.
        [TestMethod]
        [DataRow(400, false)]
        [DataRow(400, true)]
        [DataRow(403, false)]
        [DataRow(403, true)]
        public async Task InvalidToken_NotInvalidatedAndNotRetried(int statusCode, bool useAsync)
        {
            var creds = new RetryTestCredentials(new TestClock());
            var initial = creds.GetCredentials();
            var scenario = BuildScenario(creds, attempt => Rejection("InvalidToken", (HttpStatusCode)statusCode));

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.AreEqual(1, scenario.Transport.Attempts, "InvalidToken must not be retried as an invalid credential error");
            Assert.AreSame(scenario.Transport.LastThrown, thrown, "the caller sees the service exception unchanged");
            Assert.AreEqual(1, scenario.Signer.SignCount);
            Assert.AreSame(initial, creds.GetCredentials(), "InvalidToken must not invalidate the credentials");
            Assert.AreEqual(1, creds.GenerateCount);
        }

        [TestMethod]
        [DataRow(PolicyKind.Legacy, false)]
        [DataRow(PolicyKind.Legacy, true)]
        [DataRow(PolicyKind.Standard, false)]
        [DataRow(PolicyKind.Standard, true)]
        [DataRow(PolicyKind.Adaptive, false)]
        [DataRow(PolicyKind.Adaptive, true)]
        public async Task RejectedEveryAttempt_StopsAtMaxAttempts_ServiceExceptionUnchanged(PolicyKind kind, bool useAsync)
        {
            var creds = new RetryTestCredentials(new TestClock());
            var scenario = BuildScenario(creds, attempt => Rejection("ExpiredToken"), kind);

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.AreEqual(MaxRetries + 1, scenario.Transport.Attempts, "retries count toward the maximum attempts");
            Assert.AreSame(scenario.Transport.LastThrown, thrown, "the caller sees the service exception unchanged");
            CollectionAssert.AreEqual(new[] { "AKIA_RETRY_1", "AKIA_RETRY_2", "AKIA_RETRY_3" }, scenario.Transport.SentAccessKeys,
                "each rejection invalidates the credentials that signed it, so each retry is signed with new credentials");

            // Retry capacity is consumed exactly as for a server error that is retried to the maximum.
            var control = BuildScenario(new RetryTestCredentials(new TestClock()), attempt => ServerError(), kind);
            await InvokeAsync(control, useAsync);
            Assert.AreEqual(MaxRetries + 1, control.Transport.Attempts);
            CollectionAssert.AreEqual(control.Transport.CapacityAtAttempt, scenario.Transport.CapacityAtAttempt);
            Assert.AreEqual(control.Capacity.AvailableCapacity, scenario.Capacity.AvailableCapacity);
            Assert.IsTrue(scenario.Capacity.AvailableCapacity < scenario.Capacity.MaxCapacity);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task RefreshBackoffActive_RetrySentWithSameCachedCredentials(bool useAsync)
        {
            var clock = new TestClock();
            var creds = new RetryTestCredentials(clock);
            var cached = creds.GetCredentials();

            // Enter the mandatory refresh window and fail the refresh, which arms the refresh backoff and serves
            // the cached credentials.
            clock.CorrectedUtcNow = Now + TimeSpan.FromMinutes(59.5);
            creds.FailNextRefreshes(1);
            Assert.AreSame(cached, creds.GetCredentials());
            var sourceCalls = creds.SourceCallCount;

            var scenario = BuildScenario(creds, attempt => Rejection("ExpiredToken"));
            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.AreEqual(MaxRetries + 1, scenario.Transport.Attempts, "the rejected request is still retried");
            CollectionAssert.AreEqual(Enumerable.Repeat("AKIA_RETRY_1", MaxRetries + 1).ToList(), scenario.Transport.SentAccessKeys,
                "while the refresh backoff is active every retry is signed with the same cached credentials");
            Assert.AreEqual(sourceCalls, creds.SourceCallCount, "invalidation must not bypass the refresh backoff");
            Assert.AreSame(scenario.Transport.LastThrown, thrown);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task NoRetriesConfigured_RejectedCredentialsStillInvalidated(bool useAsync)
        {
            var creds = new RetryTestCredentials(new TestClock());
            var scenario = BuildScenario(creds, attempt => Rejection("ExpiredToken"), maxRetries: 0);

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.AreEqual(1, scenario.Transport.Attempts);
            Assert.AreSame(scenario.Transport.LastThrown, thrown);
            Assert.AreEqual("AKIA_RETRY_2", creds.GetCredentials().AccessKey,
                "the rejected credentials are invalidated even when the request is not retried");
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task RetryQuotaExhausted_RejectionNotRetried(bool useAsync)
        {
            var creds = new RetryTestCredentials(new TestClock());
            var scenario = BuildScenario(creds, attempt => Rejection("ExpiredToken"));
            scenario.Capacity.AvailableCapacity = 0;

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.AreEqual(1, scenario.Transport.Attempts, "an invalid credential retry requires retry quota");
            Assert.AreSame(scenario.Transport.LastThrown, thrown);
            Assert.AreEqual("AKIA_RETRY_2", creds.GetCredentials().AccessKey);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task ServerError_RetriedAsBefore_NotResignedAndNotInvalidated(bool useAsync)
        {
            var creds = new RetryTestCredentials(new TestClock());
            var scenario = BuildScenario(creds, attempt => ServerError());

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.AreEqual(MaxRetries + 1, scenario.Transport.Attempts);
            Assert.AreSame(scenario.Transport.LastThrown, thrown);
            Assert.AreEqual(1, scenario.Signer.SignCount, "retries of other errors reuse the original signature");
            Assert.AreEqual(1, creds.GenerateCount);
            Assert.AreEqual("AKIA_RETRY_1", creds.GetCredentials().AccessKey, "other errors do not invalidate credentials");
        }

        #endregion

        #region Identities without invalidation support: behavior unchanged

        [TestMethod]
        [DataRow("ExpiredToken", false)]
        [DataRow("ExpiredToken", true)]
        [DataRow("ExpiredTokenException", false)]
        [DataRow("ExpiredTokenException", true)]
        public async Task OutOfScopeRefreshingCredentials_NotInvalidatedAndNotRetried(string errorCode, bool useAsync)
        {
            var creds = new RetryTestCredentials(new TestClock(), inScope: false);
            var initial = creds.GetCredentials();
            var scenario = BuildScenario(creds, attempt => Rejection(errorCode));

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.AreEqual(1, scenario.Transport.Attempts);
            Assert.AreSame(scenario.Transport.LastThrown, thrown);
            Assert.AreSame(initial, creds.GetCredentials(), "out-of-scope credentials must not be invalidated");
            Assert.AreEqual(1, creds.GenerateCount);
        }

        [TestMethod]
        [DataRow("Basic", "ExpiredToken", false)]
        [DataRow("Basic", "ExpiredToken", true)]
        [DataRow("Session", "ExpiredTokenException", false)]
        [DataRow("Session", "ExpiredTokenException", true)]
        public async Task NonRefreshingCredentials_NotRetried(string identityKind, string errorCode, bool useAsync)
        {
            var scenario = BuildScenario(CreateNonRefreshingIdentity(identityKind), attempt => Rejection(errorCode));

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.AreEqual(1, scenario.Transport.Attempts);
            Assert.AreSame(scenario.Transport.LastThrown, thrown);
        }

        // A customer retry policy that retries ExpiredToken keeps working exactly as before for identities without
        // invalidation support: the request is retried with the original signature and nothing is invalidated.
        [TestMethod]
        [DataRow("OutOfScopeRefreshing", false)]
        [DataRow("OutOfScopeRefreshing", true)]
        [DataRow("Basic", false)]
        [DataRow("Basic", true)]
        public async Task CustomPolicyRetryingExpiredToken_IdentityWithoutInvalidation_RetriedAsBefore(string identityKind, bool useAsync)
        {
            var outOfScope = new RetryTestCredentials(new TestClock(), inScope: false);
            var identity = identityKind == "OutOfScopeRefreshing" ? outOfScope : CreateNonRefreshingIdentity(identityKind);
            var scenario = BuildScenario(identity, attempt => Rejection("ExpiredToken"),
                createPolicy: config => new RetryExpiredTokenPolicy(config));

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.AreEqual(MaxRetries + 1, scenario.Transport.Attempts, "the customer policy's retries are honored");
            Assert.AreEqual(1, scenario.Signer.SignCount, "retries are not re-signed, as before");
            Assert.AreEqual(1, scenario.Transport.SentAccessKeys.Distinct().Count());
            Assert.AreSame(scenario.Transport.LastThrown, thrown);
            if (identity == outOfScope)
                Assert.AreEqual(1, outOfScope.GenerateCount, "out-of-scope credentials must not be invalidated");
        }

        #endregion

        #region Invalidation failures never replace the service exception

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task DisposedCredentials_Rejected_ServiceExceptionSurfaces(bool useAsync)
        {
            var creds = new RetryTestCredentials(new TestClock());
            creds.GetCredentials();
            creds.Dispose();
            var scenario = BuildScenario(creds, attempt => Rejection("ExpiredToken"));

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.IsInstanceOfType(thrown, typeof(AmazonServiceException));
            Assert.AreSame(scenario.Transport.LastThrown, thrown,
                "the service exception must reach the caller, not an ObjectDisposedException");
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task InvalidateOverrideThrows_ServiceExceptionSurfaces(bool useAsync)
        {
            var creds = new RetryTestCredentials(new TestClock()) { ThrowFromInvalidate = true };
            var scenario = BuildScenario(creds, attempt => Rejection("ExpiredTokenException"));

            var thrown = await InvokeAsync(scenario, useAsync);

            Assert.AreSame(scenario.Transport.LastThrown, thrown,
                "an exception from Invalidate must not replace the service exception");
        }

        [TestMethod]
        public void Invalidate_AfterDispose_DoesNotThrow()
        {
            var creds = new RetryTestCredentials(new TestClock());
            var used = creds.GetCredentials();
            var expiration = creds.Expiration;
            creds.Dispose();

            creds.Invalidate(used);
            creds.Invalidate(new ImmutableCredentials("AKIA_OTHER", "secret", "token"));
            Assert.AreEqual(expiration, creds.Expiration, "a disposed provider ignores the rejection and keeps its credentials unchanged");
        }

        #endregion

        #region Classification

        [TestMethod]
        public void IsInvalidCredentialError_RequiresExactCodeAndInScopeSigningCredentials()
        {
            var inScope = new RetryTestCredentials(new TestClock());
            var outOfScope = new RetryTestCredentials(new TestClock(), inScope: false);
            var used = inScope.GetCredentials();

            Assert.IsTrue(Classify(inScope, used, Rejection("ExpiredToken")));
            Assert.IsTrue(Classify(inScope, used, Rejection("ExpiredTokenException")));

            // Error codes are matched exactly. InvalidToken is returned for other tokens, such as Step Functions task
            // tokens, so it is not an invalid credential error.
            Assert.IsFalse(Classify(inScope, used, Rejection("expiredtoken")));
            Assert.IsFalse(Classify(inScope, used, Rejection("expiredTokenException")));
            Assert.IsFalse(Classify(inScope, used, Rejection("InvalidToken")));
            Assert.IsFalse(Classify(inScope, used, Rejection("AccessDenied")));
            Assert.IsFalse(Classify(inScope, used, ServerError()));
            Assert.IsFalse(Classify(inScope, used, new AmazonClientException("ExpiredToken")));

            // The signing credentials must be known, and the identity must support invalidation.
            Assert.IsFalse(Classify(inScope, null, Rejection("ExpiredToken")));
            Assert.IsFalse(Classify(outOfScope, outOfScope.GetCredentials(), Rejection("ExpiredToken")));
            Assert.IsFalse(Classify(new BasicAWSCredentials("AKIA_BASIC", "secret"), used, Rejection("ExpiredToken")));
        }

        private static bool Classify(BaseIdentity identity, ImmutableCredentials used, Exception exception)
        {
            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(false, null);
            var requestContext = (RequestContext)executionContext.RequestContext;
            requestContext.Identity = identity;
            requestContext.ResolvedCredentials = used;
            return CredentialsInvalidation.IsInvalidCredentialError(executionContext, exception);
        }

        #endregion

        #region Helpers

        private sealed class Scenario
        {
            public RuntimePipeline Pipeline { get; set; }
            public FakeTransport Transport { get; set; }
            public RecordingSigner Signer { get; set; }
            public RetryCapacity Capacity { get; set; }
            public IExecutionContext Context { get; set; }
        }

        private Scenario BuildScenario(BaseIdentity identity, Func<int, Exception> responseForAttempt,
            PolicyKind kind = PolicyKind.Standard, int maxRetries = MaxRetries, Func<IClientConfig, RetryPolicy> createPolicy = null)
        {
            // A unique service URL gives each scenario its own retry capacity bucket.
            var config = new AmazonS3Config
            {
                ServiceURL = "https://retry-" + Guid.NewGuid().ToString("N") + ".example.com",
                MaxErrorRetry = maxRetries,
            };
            var policy = createPolicy != null ? createPolicy(config) : CreatePolicy(kind, config);
            var capacity = (policy as IRetryCapacityProbe)?.Capacity;

            var transport = new FakeTransport(responseForAttempt, () => capacity?.AvailableCapacity ?? -1);
            var pipeline = new RuntimePipeline(transport);
            pipeline.AddHandler(new Amazon.Runtime.Internal.Signer());
            pipeline.AddHandler(new RetryHandler(policy));

            var signer = new RecordingSigner();
            var context = CreateTestContext(signer, null, config);
            context.RequestContext.Identity = identity;

            return new Scenario
            {
                Pipeline = pipeline,
                Transport = transport,
                Signer = signer,
                Capacity = capacity,
                Context = context,
            };
        }

        private static RetryPolicy CreatePolicy(PolicyKind kind, IClientConfig config)
        {
            switch (kind)
            {
                case PolicyKind.Legacy:
                    return new ProbedDefaultRetryPolicy(config);
                case PolicyKind.Standard:
                    return new ProbedStandardRetryPolicy(config);
                case PolicyKind.Adaptive:
                    return new ProbedAdaptiveRetryPolicy(config);
                default:
                    throw new ArgumentOutOfRangeException(nameof(kind));
            }
        }

        private static BaseIdentity CreateNonRefreshingIdentity(string kind)
        {
            switch (kind)
            {
                case "Basic":
                    return new BasicAWSCredentials("AKIA_BASIC", "secret");
                case "Session":
                    return new SessionAWSCredentials("AKIA_SESSION", "secret", "session_token");
                default:
                    throw new ArgumentOutOfRangeException(nameof(kind));
            }
        }

        private static async Task<Exception> InvokeAsync(Scenario scenario, bool useAsync)
        {
            try
            {
                if (useAsync)
                    await scenario.Pipeline.InvokeAsync<AmazonWebServiceResponse>(scenario.Context).ConfigureAwait(false);
                else
                    scenario.Pipeline.InvokeSync(scenario.Context);
                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private static AmazonServiceException Rejection(string errorCode, HttpStatusCode statusCode = HttpStatusCode.BadRequest) =>
            new AmazonServiceException(errorCode + " rejection", ErrorType.Sender, errorCode, "request-id", statusCode);

        private static AmazonServiceException ServerError() =>
            new AmazonServiceException("Internal Server Error", ErrorType.Receiver, "InternalError", "request-id", HttpStatusCode.InternalServerError);

        #endregion

        #region Test doubles

        private sealed class TestClock : ITimeProvider
        {
            public DateTime CorrectedUtcNow { get; set; } = Now;
        }

        /// <summary>
        /// Refreshing credentials that produce a distinct access key and session token per refresh
        /// (AKIA_RETRY_1/token_1, AKIA_RETRY_2/token_2, ...), so the credentials each attempt was signed with are
        /// observable. In scope for the credential refresh behavior unless constructed with <c>inScope: false</c>.
        /// </summary>
        private sealed class RetryTestCredentials : RefreshingAWSCredentials
        {
            private readonly bool _inScope;
            private int _generated;
            private int _sourceCalls;
            private int _failuresRemaining;

            public RetryTestCredentials(ITimeProvider clock, bool inScope = true) : base(clock)
            {
                _inScope = inScope;
                RefreshBackoffGenerator = () => TimeSpan.FromMinutes(7.5);
            }

            public int GenerateCount => Volatile.Read(ref _generated);
            public int SourceCallCount => Volatile.Read(ref _sourceCalls);
            public bool ThrowFromInvalidate { get; set; }

            public void FailNextRefreshes(int count) => Interlocked.Exchange(ref _failuresRemaining, count);

            protected override bool UsesManagedRefreshLifecycle => _inScope;

            public override void Invalidate(ImmutableCredentials rejectedCredentials)
            {
                if (ThrowFromInvalidate)
                    throw new InvalidOperationException("Simulated failure in a custom Invalidate override.");
                base.Invalidate(rejectedCredentials);
            }

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                Interlocked.Increment(ref _sourceCalls);
                if (Interlocked.Decrement(ref _failuresRemaining) >= 0)
                    throw new AmazonClientException("Simulated credential source failure.");

                var n = Interlocked.Increment(ref _generated);
                return new CredentialsRefreshState(
                    new ImmutableCredentials("AKIA_RETRY_" + n, "secret_" + n, "token_" + n),
                    _timeProvider.CorrectedUtcNow + TimeSpan.FromMinutes(60),
                    _timeProvider);
            }
        }

        /// <summary>
        /// Stands in for the HTTP handler: records the credentials and session token each attempt was sent with and
        /// the retry capacity available at that moment, then returns the scripted response for the attempt.
        /// </summary>
        private sealed class FakeTransport : PipelineHandler
        {
            private readonly Func<int, Exception> _responseForAttempt;
            private readonly Func<int> _capacityProbe;

            public FakeTransport(Func<int, Exception> responseForAttempt, Func<int> capacityProbe)
            {
                _responseForAttempt = responseForAttempt;
                _capacityProbe = capacityProbe;
            }

            public List<string> SentAccessKeys { get; } = new List<string>();
            public List<string> SentTokens { get; } = new List<string>();
            public List<int> CapacityAtAttempt { get; } = new List<int>();
            public Exception LastThrown { get; private set; }
            public int Attempts => SentAccessKeys.Count;

            public override void InvokeSync(IExecutionContext executionContext)
            {
                var exception = Send(executionContext);
                if (exception != null)
                    throw exception;
            }

            public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
            {
                var exception = Send(executionContext);
                return exception != null ? Task.FromException<T>(exception) : Task.FromResult(new T());
            }

            private Exception Send(IExecutionContext executionContext)
            {
                var requestContext = (RequestContext)executionContext.RequestContext;
                SentAccessKeys.Add(requestContext.ResolvedCredentials?.AccessKey);
                requestContext.Request.Headers.TryGetValue(HeaderKeys.XAmzSecurityTokenHeader, out var token);
                SentTokens.Add(token);
                CapacityAtAttempt.Add(_capacityProbe());

                LastThrown = _responseForAttempt(SentAccessKeys.Count);
                return LastThrown;
            }
        }

        /// <summary>
        /// Resolves the credentials from the identity when signing, as the SigV4 signer does, and records them.
        /// </summary>
        private sealed class RecordingSigner : AbstractAWSSigner
        {
            public List<string> SignedAccessKeys { get; } = new List<string>();
            public int SignCount => SignedAccessKeys.Count;

            public override ClientProtocol Protocol => ClientProtocol.RestProtocol;

            public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, BaseIdentity identity)
            {
                SignedAccessKeys.Add(((AWSCredentials)identity).GetCredentials().AccessKey);
            }
        }

        private interface IRetryCapacityProbe
        {
            RetryCapacity Capacity { get; }
        }

        private sealed class ProbedDefaultRetryPolicy : DefaultRetryPolicy, IRetryCapacityProbe
        {
            public ProbedDefaultRetryPolicy(IClientConfig config) : base(config) { MaxBackoffInMilliseconds = 0; }
            public RetryCapacity Capacity => RetryCapacity;
        }

        private sealed class ProbedStandardRetryPolicy : StandardRetryPolicy, IRetryCapacityProbe
        {
            public ProbedStandardRetryPolicy(IClientConfig config) : base(config) { MaxBackoffInMilliseconds = 0; }
            public RetryCapacity Capacity => RetryCapacity;
        }

        private sealed class ProbedAdaptiveRetryPolicy : AdaptiveRetryPolicy, IRetryCapacityProbe
        {
            public ProbedAdaptiveRetryPolicy(IClientConfig config) : base(config) { MaxBackoffInMilliseconds = 0; }
            public RetryCapacity Capacity => RetryCapacity;
        }

        /// <summary>
        /// A customer-style retry policy that also retries <c>ExpiredToken</c>.
        /// </summary>
        private sealed class RetryExpiredTokenPolicy : DefaultRetryPolicy
        {
            public RetryExpiredTokenPolicy(IClientConfig config) : base(config) { MaxBackoffInMilliseconds = 0; }

            public override bool RetryForException(IExecutionContext executionContext, Exception exception) =>
                IsExpiredToken(exception) || base.RetryForException(executionContext, exception);

            public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception) =>
                IsExpiredToken(exception) ? Task.FromResult(true) : base.RetryForExceptionAsync(executionContext, exception);

            private static bool IsExpiredToken(Exception exception) =>
                (exception as AmazonServiceException)?.ErrorCode == "ExpiredToken";
        }

        #endregion
    }
}
