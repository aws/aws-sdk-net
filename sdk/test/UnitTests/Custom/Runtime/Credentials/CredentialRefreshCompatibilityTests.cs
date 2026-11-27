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
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Logging;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Compatibility tests for <see cref="RefreshingAWSCredentials"/>: behavior that stays as it was in earlier versions
    /// of the SDK, and the log messages of the refresh lifecycle.
    /// <list type="bullet">
    /// <item>Providers outside the credential refresh specification's scope (ProcessAWSCredentials, customer
    /// subclasses) keep the background refresh inside PreemptExpiryTime, rethrow a failed refresh without a backoff,
    /// and read PreemptExpiryTime as the value set (zero by default).</item>
    /// <item>A subclass that makes its cached credentials expire gets a refresh on the next call.</item>
    /// <item>GetCredentials(TimeSpan) fails fast without applying the refresh backoff. On an EC2 instance metadata
    /// provider it behaves as GetCredentials(): it does not contact IMDS for valid credentials that expire within the
    /// requested lifetime, and handles an IMDS outage, an already-expired first response and a non-recoverable error as
    /// GetCredentials() does.</item>
    /// <item>A class derived directly from URIBasedRefreshingCredentialHelper is a customer-provided provider and keeps
    /// the behavior of earlier versions.</item>
    /// <item>A non-recoverable error that the credential source wrapped in an AmazonClientException is raised as
    /// AmazonNonRecoverableCredentialsException.</item>
    /// <item>Log messages: an error message with braces is logged as an argument, handled failures are logged at Warn,
    /// the cached-credentials fallback is logged once per refresh backoff, and only paths that return cached
    /// credentials say so.</item>
    /// </list>
    /// Time comes from a fake clock. A background refresh is awaited by polling for the provider to become idle, with a
    /// timeout that only elapses when a test fails; no test sleeps.
    /// </summary>
    [TestClass]
    [DoNotParallelize]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class CredentialRefreshCompatibilityTests
    {
        private static readonly DateTime T0 = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static readonly TimeSpan Lifetime = TimeSpan.FromMinutes(60);
        private static readonly TimeSpan Backoff = TimeSpan.FromMinutes(7.5);
        private static readonly TimeSpan ErrorCacheDuration = TimeSpan.FromSeconds(3);
        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(30);
        private static readonly TimeSpan Preempt = TimeSpan.FromMinutes(15);

        // Credentials fetched at T0 have a 60-minute lifetime and a 1-minute ExpirationBuffer: Expiration = T0+59m and
        // the reported expiration is T0+60m. With PreemptExpiryTime = 15 minutes the preempt window opens at T0+44m.
        private static DateTime At(double minutes) => T0 + TimeSpan.FromMinutes(minutes);

        private const string CachedCredentialsText = "The SDK will continue using cached credentials";
        private const string NextAttemptText = "A refresh of these credentials will be attempted again after";

        #region Providers outside the specification's scope

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task OutOfScope_InsidePreemptWindow_ServesCachedAndRefreshesInBackground(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: false) { PreemptExpiryTime = Preempt };
            var gen1 = await Get(creds, useAsync);

            clock.Now = At(50);
            Assert.AreSame(gen1, await Get(creds, useAsync), "the cached credentials are returned while the refresh runs");
            WaitUntilIdle(creds, sourceCalls: 2);

            var gen2 = await Get(creds, useAsync);
            Assert.AreNotSame(gen1, gen2, "the background refresh replaced the credentials");
            Assert.AreEqual(2, creds.SourceCalls);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task OutOfScope_PreemptExpiryTimeSetAfterFetch_AppliesToTheCachedCredentials(bool useAsync)
        {
            // Earlier versions of the SDK compared the current PreemptExpiryTime on every call, so a value set after the
            // credentials were fetched applies to those credentials at once.
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: false);
            var gen1 = await Get(creds, useAsync);
            Assert.AreEqual(TimeSpan.Zero, creds.PreemptExpiryTime);

            clock.Now = At(50);
            Assert.AreSame(gen1, await Get(creds, useAsync));
            Assert.IsTrue(IsIdle(creds), "with a zero window no background refresh starts");
            Assert.AreEqual(1, creds.SourceCalls);

            creds.PreemptExpiryTime = Preempt; // the window of the cached credentials now opens at T0+44m
            Assert.AreSame(gen1, await Get(creds, useAsync), "the cached credentials are returned while the refresh runs");
            WaitUntilIdle(creds, sourceCalls: 2);
            Assert.AreNotSame(gen1, await Get(creds, useAsync), "the background refresh replaced the credentials");
        }

        // URIBasedRefreshingCredentialHelper is public, and an application can derive its own HTTP credential provider
        // from it. Such a provider is a customer-provided provider, so it keeps the behavior of earlier versions of the
        // SDK; only the SDK's instance metadata and container providers, which also derive from the helper, opt in.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task OutOfScope_ClassDerivedFromUriHelper_KeepsEarlierBehavior(bool useAsync)
        {
            var creds = new CustomHttpCredentials();
            Assert.AreEqual(TimeSpan.Zero, creds.PreemptExpiryTime, "no background refresh window unless one is set");
            await Get(creds, useAsync);

            // The credentials expire 30 seconds after they are fetched, inside the 1-minute ExpirationBuffer, so the next
            // call refreshes them. The failed refresh throws, with no refresh backoff, so the call after it contacts the
            // source again.
            var failure = new AmazonServiceException("Unable to reach credentials server");
            creds.Failure = failure;
            Assert.AreSame(failure, await GetError<AmazonServiceException>(creds, useAsync));
            Assert.AreSame(failure, await GetError<AmazonServiceException>(creds, useAsync));
            Assert.AreEqual(3, creds.SourceCalls);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task OutOfScope_FetchedInsidePreemptWindow_EachCallStartsBackgroundRefresh(bool useAsync)
        {
            // Credentials that expire in 10 minutes with a 15-minute PreemptExpiryTime are inside the preempt window as
            // soon as they are fetched. Earlier versions of the SDK started a background refresh on each call then.
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: false, lifetime: TimeSpan.FromMinutes(10)) { PreemptExpiryTime = Preempt };
            await Get(creds, useAsync);
            Assert.AreEqual(1, creds.SourceCalls);

            await Get(creds, useAsync);
            WaitUntilIdle(creds, sourceCalls: 2);
            await Get(creds, useAsync);
            WaitUntilIdle(creds, sourceCalls: 3);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task OutOfScope_BackgroundRefreshFails_LoggedAsBefore_NextCallRetriesWithoutBackoff(bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var clock = new TestClock(T0);
                var creds = new CompatCredentials(clock, inScope: false) { PreemptExpiryTime = Preempt };
                var gen1 = await Get(creds, useAsync);

                clock.Now = At(50);
                var failure = new AmazonClientException("background failure");
                creds.ThrowOnRefresh(_ => failure);
                Assert.AreSame(gen1, await Get(creds, useAsync), "a failed background refresh does not reach the caller");
                WaitUntilIdle(creds, sourceCalls: 2);

                // No refresh backoff: the next call inside the preempt window starts another background refresh.
                Assert.AreSame(gen1, await Get(creds, useAsync));
                WaitUntilIdle(creds, sourceCalls: 3);

                var logged = log.Entries.Where(e => ReferenceEquals(e.Exception, failure)).ToList();
                Assert.AreEqual(2, logged.Count);
                Assert.IsTrue(logged.All(e => e.Level == SdkLogLevel.Error
                                              && e.Message == "Exception occurred performing background credentials refresh."),
                    "the failure is logged as in earlier versions of the SDK");

                creds.ClearThrowOnRefresh();
                Assert.AreSame(gen1, await Get(creds, useAsync));
                WaitUntilIdle(creds, sourceCalls: 4);
                Assert.AreNotSame(gen1, await Get(creds, useAsync));
            }
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task OutOfScope_PreemptExpiryTimeNotSet_NoBackgroundRefresh_RefreshesAfterExpiration(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: false);
            var gen1 = await Get(creds, useAsync);
            Assert.AreEqual(TimeSpan.Zero, creds.PreemptExpiryTime, "PreemptExpiryTime is zero unless it is set");

            clock.Now = At(58.9);
            Assert.AreSame(gen1, await Get(creds, useAsync));
            Assert.IsTrue(IsIdle(creds), "no background refresh may start");

            clock.Now = At(59.5); // past Expiration: the call refreshes while the caller waits
            Assert.AreNotSame(gen1, await Get(creds, useAsync));
            Assert.AreEqual(2, creds.SourceCalls);
        }

        [TestMethod]
        public void PreemptExpiryTime_OutOfScope_IsValueSetOrZero_InScope_IsTableWindow()
        {
            var clock = new TestClock(T0);
            var outOfScope = new CompatCredentials(clock, inScope: false);
            Assert.AreEqual(TimeSpan.Zero, outOfScope.PreemptExpiryTime);
            outOfScope.GetCredentials();
            Assert.AreEqual(TimeSpan.Zero, outOfScope.PreemptExpiryTime, "the lifetime table does not apply out of scope");
            outOfScope.PreemptExpiryTime = TimeSpan.FromMinutes(7);
            Assert.AreEqual(TimeSpan.FromMinutes(7), outOfScope.PreemptExpiryTime);

            var inScope = new CompatCredentials(clock, inScope: true);
            Assert.AreEqual(TimeSpan.FromMinutes(5), inScope.PreemptExpiryTime, "the table window before the first fetch");
            inScope.GetCredentials();
            Assert.AreEqual(TimeSpan.FromMinutes(15), inScope.PreemptExpiryTime, "the table window for 60-minute credentials");
        }

        [TestMethod]
        public void ProcessAWSCredentials_PreemptExpiryTime_IsFifteenMinutes()
        {
            using (var creds = new ProcessAWSCredentials("credential-process-that-is-never-run"))
            {
                Assert.AreEqual(TimeSpan.FromMinutes(15), creds.PreemptExpiryTime);
            }
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task OutOfScope_FailedRefresh_Throws_EachCallContactsSource(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: false);
            await Get(creds, useAsync);

            clock.Now = At(61);
            var failure = new AmazonClientException("source failure");
            creds.ThrowOnRefresh(_ => failure);
            Assert.AreSame(failure, await GetError<AmazonClientException>(creds, useAsync));
            Assert.AreSame(failure, await GetError<AmazonClientException>(creds, useAsync));
            Assert.AreEqual(3, creds.SourceCalls, "no refresh backoff: every call contacts the source");
        }

        [TestMethod]
        [DataRow(false, false)]
        [DataRow(false, true)]
        [DataRow(true, false)]
        [DataRow(true, true)]
        // With nothing cached, a response that expires exactly now is used in and out of scope. Out of scope this is the
        // behavior of earlier versions of the SDK. In scope the response is already expired, so the next call refreshes
        // it at once.
        public async Task ResponseThatExpiresExactlyNow_AcceptedOnInitialFetch_InScopeRefreshedOnNextCall(bool inScope, bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope) { ExpirationForNow = now => now };

            var initial = await Get(creds, useAsync);
            if (inScope)
            {
                Assert.AreEqual("AKIA_COMPAT_1", initial.AccessKey, "the only credentials available are used, not failed");
                Assert.AreEqual(1, creds.SourceCalls);

                creds.ExpirationForNow = null; // the source now returns credentials valid for the lifetime
                Assert.AreEqual("AKIA_COMPAT_2", (await Get(creds, useAsync)).AccessKey,
                    "no refresh backoff is armed by the initial fetch, so the next call refreshes the expired credentials");
                Assert.AreEqual(2, creds.SourceCalls);
            }
            else
            {
                Assert.IsNotNull(initial, "earlier versions of the SDK accepted this response");
            }
        }

        #endregion

        #region Subclass forcing a refresh

        [TestMethod]
        [DataRow(false, 0.0, false)]
        [DataRow(false, 0.0, true)]
        [DataRow(false, -1.0, false)]
        [DataRow(true, 0.0, false)]
        [DataRow(true, 0.0, true)]
        [DataRow(true, -1.0, true)]
        public async Task SubclassSetsExpirationToPast_NextCallRefreshes(bool inScope, double offsetMinutes, bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope);
            var gen1 = await Get(creds, useAsync);

            clock.Now = At(10);
            creds.SetExpiration(clock.Now + TimeSpan.FromMinutes(offsetMinutes));
            clock.Advance(TimeSpan.FromSeconds(1));

            var next = await Get(creds, useAsync);
            Assert.AreNotSame(gen1, next, "setting currentState.Expiration to a past time forces a refresh");
            Assert.AreEqual(2, creds.SourceCalls);
        }

        [TestMethod]
        [DataRow(false, false)]
        [DataRow(false, true)]
        [DataRow(true, false)]
        [DataRow(true, true)]
        public async Task SubclassAssignsExpiredState_NextCallRefreshes(bool inScope, bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope);
            await Get(creds, useAsync);

            clock.Now = At(10);
            var seeded = new ImmutableCredentials("AKIA_SEEDED", "secret", "token");
            creds.State = new RefreshingAWSCredentials.CredentialsRefreshState(seeded, clock.Now - TimeSpan.FromMinutes(1), clock);

            Assert.AreNotSame(seeded, await Get(creds, useAsync));
            Assert.AreEqual(2, creds.SourceCalls);
        }

        #endregion

        #region GetCredentials(TimeSpan)

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task MinimumLifetime_FailedRefresh_ThrowsWithoutApplyingRefreshBackoff(bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var clock = new TestClock(T0);
                var creds = new CompatCredentials(clock, inScope: true);
                var gen1 = await Get(creds, useAsync);

                clock.Now = At(120);
                var failure = new AmazonClientException("the credential source is unavailable");
                creds.ThrowOnRefresh(n => n == 2 ? failure : null);
                Assert.AreSame(failure, await GetMinimumLifetimeError<AmazonClientException>(creds, useAsync));

                // No backoff was applied, so the next call contacts the (recovered) source instead of returning gen1.
                Assert.AreNotSame(gen1, await Get(creds, useAsync));
                Assert.AreEqual(3, creds.SourceCalls);
                Assert.IsFalse(log.Entries.Any(e => e.Message.Contains(CachedCredentialsText) || e.Message.Contains(NextAttemptText)),
                    "the error is thrown and no backoff is applied, so no backoff message may be logged");
            }
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task MinimumLifetime_DuringRefreshBackoff_ContactsSourceAndDoesNotExtendBackoff(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: true);
            var gen1 = await Get(creds, useAsync);

            clock.Now = At(59.5);
            creds.ThrowOnRefresh(n => new AmazonClientException("failure " + n));
            Assert.AreSame(gen1, await Get(creds, useAsync), "static stability; the backoff lasts until T0+67m");
            Assert.AreEqual(2, creds.SourceCalls);

            foreach (var minutes in new[] { 60.0, 62.0, 64.0 })
            {
                clock.Now = At(minutes);
                await GetMinimumLifetimeError<AmazonClientException>(creds, useAsync);
            }
            Assert.AreEqual(5, creds.SourceCalls, "each minimum-lifetime call contacts the source");

            // Past the backoff applied at T0+59.5m. Had the minimum-lifetime failures applied it again, it would last
            // until T0+71.5m and this call would return gen1.
            clock.Now = At(67.5);
            creds.ClearThrowOnRefresh();
            Assert.AreNotSame(gen1, await Get(creds, useAsync));
            Assert.AreEqual(6, creds.SourceCalls);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task MinimumLifetime_OtherProviderReturnsExpiredCredentials_Throws(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: true) { ExpirationForNow = now => now - TimeSpan.FromMinutes(5) };

            var ex = await GetMinimumLifetimeError<AmazonClientException>(creds, useAsync);
            StringAssert.Contains(ex.Message, "already expired");
            Assert.IsNull(creds.Expiration, "nothing is cached");
        }

        // IMDS returns the same credentials until it rotates them, so the EC2 instance metadata providers cannot get
        // longer-lived credentials on request, and GetCredentials(TimeSpan) behaves as GetCredentials(): valid cached
        // credentials are returned without contacting IMDS even when they expire within the requested lifetime. Inside
        // the background refresh window they are returned at once and the background refresh starts, as GetCredentials()
        // does. RDS and DSQL token generation and presigning call this overload.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task MinimumLifetime_Imds_ValidCredentialsShorterThanTheLifetime_ReturnedWithoutContactingImds(bool useAsync)
        {
            var clock = new TestClock(T0);
            var imds = new StubImds(clock);
            var provider = NewImdsProvider(imds, clock);
            var cached = await Get(provider, useAsync); // AK1: reported expiration T0+60m, background refresh from T0+45m

            clock.Now = At(10); // AK1 expires in 50 minutes
            Assert.AreSame(cached, await GetMinimumLifetime(provider, useAsync, TimeSpan.FromHours(2)));
            Assert.AreSame(cached, await GetMinimumLifetime(provider, useAsync, TimeSpan.FromMinutes(55)));
            Assert.AreEqual(1, imds.FetchCount, "IMDS is not contacted for credentials that are still valid");
            Assert.IsTrue(IsIdle(provider), "no refresh was started");

            clock.Now = At(50); // inside the background refresh window
            Assert.AreSame(cached, await GetMinimumLifetime(provider, useAsync),
                "the cached credentials are returned at once, as GetCredentials() returns them");
            Assert.IsTrue(SpinWait.SpinUntil(() => imds.FetchCount == 2 && IsIdle(provider), WaitTimeout),
                "the background refresh did not run");
            var refreshed = await GetMinimumLifetime(provider, useAsync);
            Assert.AreNotSame(cached, refreshed, "the background refresh replaced the credentials");
            Assert.AreEqual(2, imds.FetchCount);
        }

        // An IMDS outage is handled as GetCredentials() handles it: the cached credentials are returned, even after
        // they expire, and IMDS is contacted again only after the refresh backoff.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task MinimumLifetime_Imds_ImdsUnreachable_HandledAsByGetCredentials(bool useAsync)
        {
            var clock = new TestClock(T0);
            var imds = new StubImds(clock);
            var provider = NewImdsProvider(imds, clock);
            var cached = await Get(provider, useAsync); // AK1: Expiration T0+59m, reported expiration T0+60m

            clock.Now = At(59.5); // AK1 has reached Expiration, so the call waits for a refresh
            imds.FailWith = ImdsUnreachable();
            Assert.AreSame(cached, await GetMinimumLifetime(provider, useAsync), "the cached credentials are returned");
            Assert.AreEqual(2, imds.FetchCount);

            clock.Now = At(62); // AK1 has expired, inside the backoff applied at T0+59.5m, which lasts until T0+67m
            Assert.AreSame(cached, await GetMinimumLifetime(provider, useAsync));
            Assert.AreSame(cached, await Get(provider, useAsync));
            Assert.AreEqual(2, imds.FetchCount, "IMDS is not contacted while the refresh backoff lasts");

            clock.Now = At(67.5);
            imds.FailWith = null; // IMDS recovers, and the next call gets new credentials
            var fresh = await GetMinimumLifetime(provider, useAsync);
            Assert.AreNotSame(cached, fresh);
            Assert.AreSame(fresh, await Get(provider, useAsync), "the new credentials are cached");
        }

        // With nothing cached, an already-expired IMDS response is used and cached without a refresh backoff, as on the
        // first GetCredentials() call: the next call contacts IMDS again, and only when that refresh fails is IMDS not
        // contacted again until the backoff has elapsed.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task MinimumLifetime_Imds_ExpiredFirstResponse_UsedAsByGetCredentials(bool useAsync)
        {
            var clock = new TestClock(T0);
            var imds = new StubImds(clock) { ReturnExpired = true };
            var provider = NewImdsProvider(imds, clock);

            var creds = await GetMinimumLifetime(provider, useAsync);
            Assert.AreEqual("AK1", creds.AccessKey, "the expired IMDS credentials are used");
            Assert.AreEqual((DateTime?)(T0 - StubImds.ExpiredBy), provider.Expiration);

            clock.Now = At(1); // no backoff after the initial fetch: the next call refreshes, and IMDS is still expired
            Assert.AreSame(creds, await GetMinimumLifetime(provider, useAsync), "the cached credentials are returned");
            Assert.AreEqual(2, imds.FetchCount, "the next call contacts IMDS again");

            clock.Now = At(8); // inside the refresh backoff applied by that failed refresh, until T0+8.5m
            Assert.AreSame(creds, await GetMinimumLifetime(provider, useAsync));
            Assert.AreSame(creds, await Get(provider, useAsync));
            Assert.AreEqual(2, imds.FetchCount, "IMDS is not contacted while the refresh backoff lasts");

            clock.Now = At(9); // the backoff has elapsed
            imds.ReturnExpired = false;
            var fresh = await GetMinimumLifetime(provider, useAsync);
            Assert.AreNotSame(creds, fresh);
            Assert.AreEqual(3, imds.FetchCount);
        }

        // A non-recoverable IMDS error is raised as GetCredentials() raises it, and raised again for the next 1 to 5
        // seconds without contacting IMDS. (For other providers GetCredentials(TimeSpan) does not cache it.)
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task MinimumLifetime_Imds_NonRecoverableError_RaisedAndCachedAsByGetCredentials(bool useAsync)
        {
            var clock = new TestClock(T0);
            var imds = new StubImds(clock);
            var provider = NewImdsProvider(imds, clock);
            await Get(provider, useAsync);

            clock.Now = At(59.5); // AK1 has reached Expiration
            var failure = new AmazonNonRecoverableCredentialsException("The credential source cannot provide credentials until reconfigured.");
            imds.FailWith = failure;
            Assert.AreSame(failure, await GetMinimumLifetimeError<AmazonNonRecoverableCredentialsException>(provider, useAsync),
                "a non-recoverable error is raised, not replaced by the cached credentials");
            Assert.AreSame(failure, await GetMinimumLifetimeError<AmazonNonRecoverableCredentialsException>(provider, useAsync));
            Assert.AreEqual(2, imds.FetchCount, "the error is cached, so IMDS is not contacted again");
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task MinimumLifetime_ImdsUnreachable_NothingCached_Throws(bool useAsync)
        {
            var clock = new TestClock(T0);
            var failure = ImdsUnreachable();
            var provider = NewImdsProvider(new StubImds(clock) { FailWith = failure }, clock);

            Assert.AreSame(failure, await GetMinimumLifetimeError<AmazonServiceException>(provider, useAsync),
                "with nothing cached there is nothing to fall back to");
            Assert.IsNull(provider.Expiration, "nothing is cached");
        }

        private static AmazonServiceException ImdsUnreachable()
            => new AmazonServiceException("Unable to get IAM security credentials from EC2 Instance Metadata Service.");

        #endregion

        #region Non-recoverable errors wrapped by the credential source

        private static AmazonClientException WrappedAccessDenied() =>
            new AmazonClientException("Error calling AssumeRole for role arn:aws:iam::123456789012:role/test",
                new AmazonServiceException("User is not authorized to perform: sts:AssumeRole", null, ErrorType.Sender,
                    "AccessDenied", "req-id", HttpStatusCode.Forbidden));

        private static void AssertRaisedAsNonRecoverable(AmazonClientException wrapper, Exception raised)
        {
            Assert.IsInstanceOfType<AmazonNonRecoverableCredentialsException>(raised);
            Assert.AreEqual(typeof(AmazonNonRecoverableCredentialsException), raised.GetType());
            Assert.AreEqual(wrapper.Message, raised.Message, "the message is the wrapper's message");
            Assert.AreSame(wrapper.InnerException, raised.InnerException, "the inner exception is the wrapper's inner exception");
        }

        [TestMethod]
        [DataRow(false, false)]
        [DataRow(false, true)]
        [DataRow(true, false)]
        [DataRow(true, true)]
        public async Task WrappedNonRecoverableError_RaisedAsNonRecoverableException_AndCached(bool initialFetch, bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: true);
            if (!initialFetch)
            {
                await Get(creds, useAsync);
                clock.Now = At(59.5);
            }

            var wrapper = WrappedAccessDenied();
            creds.ThrowOnRefresh(_ => wrapper);
            var first = await GetError<AmazonNonRecoverableCredentialsException>(creds, useAsync);
            AssertRaisedAsNonRecoverable(wrapper, first);

            var second = await GetError<AmazonNonRecoverableCredentialsException>(creds, useAsync);
            Assert.AreSame(first, second, "the same exception is raised while it is cached");
            Assert.AreEqual(initialFetch ? 1 : 2, creds.SourceCalls);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task WrappedNonRecoverableError_FromBackgroundRefresh_RaisedToNextCaller(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: true) { PreemptExpiryTime = Preempt };
            var gen1 = await Get(creds, useAsync);

            clock.Now = At(50);
            var wrapper = WrappedAccessDenied();
            creds.ThrowOnRefresh(_ => wrapper);
            Assert.AreSame(gen1, await Get(creds, useAsync));
            WaitUntilIdle(creds, sourceCalls: 2);

            AssertRaisedAsNonRecoverable(wrapper, await GetError<AmazonNonRecoverableCredentialsException>(creds, useAsync));
            Assert.AreEqual(2, creds.SourceCalls, "the cached error is raised without contacting the source");
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task WrappedNonRecoverableError_MinimumLifetime_RaisedAsNonRecoverableException(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: true);
            await Get(creds, useAsync);

            clock.Now = At(50);
            var wrapper = WrappedAccessDenied();
            creds.ThrowOnRefresh(_ => wrapper);
            AssertRaisedAsNonRecoverable(wrapper, await GetMinimumLifetimeError<AmazonNonRecoverableCredentialsException>(creds, useAsync));
        }

        [TestMethod]
        [DataRow("ServiceException")]
        [DataRow("NonRecoverableException")]
        [DataRow("DerivedWrapper")]
        public void NonRecoverableError_NotWrappedInPlainAmazonClientException_RaisedUnchanged(string kind)
        {
            Exception error;
            switch (kind)
            {
                case "ServiceException":
                    error = new AmazonServiceException("denied", null, ErrorType.Sender, "AccessDenied", "req-id", HttpStatusCode.Forbidden);
                    break;
                case "NonRecoverableException":
                    error = new AmazonNonRecoverableCredentialsException("Please reauthenticate.");
                    break;
                default:
                    error = new DerivedWrapperException(WrappedAccessDenied().InnerException);
                    break;
            }

            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: true);
            creds.ThrowOnRefresh(_ => error);
            Exception raised = null;
            try { creds.GetCredentials(); }
            catch (Exception e) { raised = e; }
            Assert.AreSame(error, raised, "the exception from the credential source is raised unchanged");
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task OutOfScope_WrappedNonRecoverableError_RaisedUnchanged(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: false);
            var wrapper = WrappedAccessDenied();
            creds.ThrowOnRefresh(_ => wrapper);
            Assert.AreSame(wrapper, await GetError<AmazonClientException>(creds, useAsync));
        }

        #endregion

        #region Log messages

        // A message with braces, like the JSON body in an unmarshalling error.
        private const string BraceMessage = "Unable to unmarshall the response. Response Body: {\"code\":\"x\"}";

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task SourceErrorWithBraces_MandatoryRefresh_ServesCachedAndLogsWarningWithTheError(bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var clock = new TestClock(T0);
                var creds = new CompatCredentials(clock, inScope: true);
                var gen1 = await Get(creds, useAsync);

                clock.Now = At(59.5);
                var failure = new AmazonServiceException(BraceMessage);
                creds.ThrowOnRefresh(_ => failure);
                Assert.AreSame(gen1, await Get(creds, useAsync), "static stability returns the cached credentials");

                var entry = log.Entries.Single(e => ReferenceEquals(e.Exception, failure));
                Assert.AreEqual(SdkLogLevel.Warn, entry.Level, "a handled failure is logged at Warn");
                Assert.AreEqual(
                    "Credential refresh failed: " + BraceMessage + ". The SDK will continue using cached credentials. " +
                    "A refresh of these credentials will be attempted again after 450 seconds.",
                    entry.Message);
            }
        }

        [TestMethod]
        public void SourceErrorWithBraces_ConsoleLogging_MandatoryRefreshServesCached()
        {
            var original = AWSConfigs.LoggingConfig.LogTo;
            AWSConfigs.LoggingConfig.LogTo = LoggingOptions.Console;
            try
            {
                // Constructed after the console logger is registered, so the provider's logger writes to it.
                var clock = new TestClock(T0);
                var creds = new CompatCredentials(clock, inScope: true);
                var gen1 = creds.GetCredentials();

                clock.Now = At(59.5);
                creds.ThrowOnRefresh(_ => new AmazonServiceException(BraceMessage));
                Assert.AreSame(gen1, creds.GetCredentials());
            }
            finally
            {
                AWSConfigs.LoggingConfig.LogTo = original;
            }
        }

        [TestMethod]
        public void SourceErrorWithBraces_BackgroundRefresh_LogsWarningWithTheError()
        {
            using (var log = new LogCapture())
            {
                var clock = new TestClock(T0);
                var creds = new CompatCredentials(clock, inScope: true) { PreemptExpiryTime = Preempt };
                var gen1 = creds.GetCredentials();

                clock.Now = At(50);
                var failure = new AmazonServiceException(BraceMessage);
                creds.ThrowOnRefresh(_ => failure);
                Assert.AreSame(gen1, creds.GetCredentials());
                WaitUntilIdle(creds, sourceCalls: 2);

                var entry = log.Entries.Single(e => ReferenceEquals(e.Exception, failure));
                Assert.AreEqual(SdkLogLevel.Warn, entry.Level);
                StringAssert.Contains(entry.Message, BraceMessage);
                StringAssert.Contains(entry.Message, CachedCredentialsText);
                StringAssert.Contains(entry.Message, NextAttemptText + " 450 seconds.");
            }
        }

        [TestMethod]
        [DataRow(false, false)]
        [DataRow(false, true)]
        [DataRow(true, false)]
        [DataRow(true, true)]
        public async Task SourceErrorWithBraces_ThrowingPaths_ThrowTheSourceError(bool minimumLifetime, bool useAsync)
        {
            using (new LogCapture())
            {
                var clock = new TestClock(T0);
                var creds = new CompatCredentials(clock, inScope: true);
                if (minimumLifetime)
                {
                    await Get(creds, useAsync);
                    clock.Now = At(59.5);
                }

                // GetCredentials() throws only when nothing is cached; GetCredentials(TimeSpan) also throws when the
                // cached credentials do not last long enough.
                var failure = new AmazonServiceException(BraceMessage);
                creds.ThrowOnRefresh(_ => failure);
                var raised = minimumLifetime
                    ? await GetMinimumLifetimeError<AmazonServiceException>(creds, useAsync)
                    : await GetError<AmazonServiceException>(creds, useAsync);
                Assert.AreSame(failure, raised);
            }
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task CachedCredentialsDuringRefreshBackoff_LoggedOncePerBackoff(bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var clock = new TestClock(T0);
                var creds = new CompatCredentials(clock, inScope: true);
                var gen1 = await Get(creds, useAsync);

                clock.Now = At(59.5);
                creds.ThrowOnRefresh(n => new AmazonClientException("failure " + n));
                Assert.AreSame(gen1, await Get(creds, useAsync)); // applies the backoff, until T0+67m
                for (var i = 1; i <= 5; i++)
                {
                    clock.Now = At(59.5 + i);
                    Assert.AreSame(gen1, await Get(creds, useAsync));
                }
                Assert.AreEqual(2, creds.SourceCalls);
                Assert.AreEqual(1, BackoffServeEntries(log).Count, "logged once for the first backoff");

                clock.Now = At(67.5); // the backoff has elapsed: the refresh fails again and applies a new backoff
                Assert.AreSame(gen1, await Get(creds, useAsync));
                for (var i = 1; i <= 3; i++)
                {
                    clock.Now = At(67.5 + i);
                    Assert.AreSame(gen1, await Get(creds, useAsync));
                }
                Assert.AreEqual(3, creds.SourceCalls);

                var entries = BackoffServeEntries(log);
                Assert.AreEqual(2, entries.Count, "logged once for each backoff");
                Assert.IsTrue(entries.All(e => e.Level == SdkLogLevel.Warn));
            }
        }

        private static List<LogCapture.Entry> BackoffServeEntries(LogCapture log)
            => log.Entries.Where(e => e.Message.Contains("until the refresh backoff ends")).ToList();

        [TestMethod]
        public async Task DuringRefreshBackoff_CallDoesNotWaitForARefreshInProgress_Async()
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: true);
            var gen1 = await creds.GetCredentialsAsync();
            clock.Now = At(59.5);
            creds.FailNextRefreshes(1);
            Assert.AreSame(gen1, await creds.GetCredentialsAsync()); // applies the backoff

            // A minimum-lifetime refresh holds the refresh lock while it waits for the source.
            creds.CloseGate();
            var holder = Task.Run(() => creds.GetCredentials(TimeSpan.FromMinutes(30)));
            try
            {
                Assert.IsTrue(SpinWait.SpinUntil(() => creds.SourceCalls == 3, WaitTimeout), "the refresh did not reach the source");

                var call = creds.GetCredentialsAsync();
                Assert.IsTrue(call.IsCompleted, "during the backoff the call must return without waiting for the lock");
                Assert.AreSame(gen1, await call);
            }
            finally
            {
                creds.OpenGate();
            }
            Assert.AreNotSame(gen1, await holder);
        }

        [TestMethod]
        public void DuringRefreshBackoff_CallDoesNotWaitForARefreshInProgress()
        {
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: true);
            var gen1 = creds.GetCredentials();
            clock.Now = At(59.5);
            creds.FailNextRefreshes(1);
            Assert.AreSame(gen1, creds.GetCredentials()); // applies the backoff

            creds.CloseGate();
            var holder = Task.Run(() => creds.GetCredentials(TimeSpan.FromMinutes(30)));
            try
            {
                Assert.IsTrue(SpinWait.SpinUntil(() => creds.SourceCalls == 3, WaitTimeout), "the refresh did not reach the source");

                var call = Task.Run(() => creds.GetCredentials());
                Assert.IsTrue(call.Wait(WaitTimeout), "during the backoff the call must return without waiting for the lock");
                Assert.AreSame(gen1, call.Result);
            }
            finally
            {
                creds.OpenGate();
            }
            Assert.AreNotSame(gen1, holder.Result);
        }

        // The expired initial response arms no refresh backoff, so the message announces a refresh on the next request
        // for credentials rather than a next-attempt delay.
        private const string ExpiredInitialResponseMessage =
            "The credential source returned credentials that have already expired. Expiration time: 2019-12-31T23:30:00.0000000Z, " +
            "Current time: 2020-01-01T00:00:00.0000000Z. No other credentials are cached, so the SDK will use these credentials " +
            "and refresh them on the next request for credentials.";

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task ImdsExpiredInitialResponse_LoggedAtWarn(bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var clock = new TestClock(T0);
                var provider = NewImdsProvider(new StubImds(clock) { ReturnExpired = true }, clock);
                Assert.AreEqual("AK1", (await Get(provider, useAsync)).AccessKey);

                var entry = log.Entries.Single(e => e.Message.Contains("returned credentials that have already expired"));
                Assert.AreEqual(SdkLogLevel.Warn, entry.Level);
                Assert.AreEqual(ExpiredInitialResponseMessage, entry.Message);
                Assert.IsFalse(log.Entries.Any(e => e.Message.Contains(NextAttemptText)), "no refresh backoff is armed");
            }
        }

        // A provider other than IMDS that uses the refresh lifecycle serves an expired initial response the same way:
        // it is used and logged at Warn, and the next call contacts the source at once and returns the fresh credentials.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task NonImdsExpiredInitialResponse_ServedLoggedAtWarn_RefreshedOnNextCall(bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var clock = new TestClock(T0);
                var creds = new CompatCredentials(clock, inScope: true) { ExpirationForNow = now => now - StubImds.ExpiredBy };

                var initial = await Get(creds, useAsync);
                Assert.AreEqual("AKIA_COMPAT_1", initial.AccessKey, "the expired initial credentials are used, not failed");
                Assert.AreEqual((DateTime?)(T0 - StubImds.ExpiredBy), creds.Expiration, "Expiration reports when they expired");
                var entry = log.Entries.Single(e => e.Message.Contains("returned credentials that have already expired"));
                Assert.AreEqual(SdkLogLevel.Warn, entry.Level);
                Assert.AreEqual(ExpiredInitialResponseMessage, entry.Message);

                creds.ExpirationForNow = null; // the source now returns credentials valid for the lifetime
                var refreshed = await Get(creds, useAsync);
                Assert.AreEqual("AKIA_COMPAT_2", refreshed.AccessKey, "the next call refreshes the expired credentials");
                Assert.AreEqual(2, creds.SourceCalls);
                Assert.AreSame(refreshed, await Get(creds, useAsync), "the fresh credentials are cached");
                Assert.AreEqual(2, creds.SourceCalls);
                Assert.IsFalse(log.Entries.Any(e => e.Message.Contains(NextAttemptText)), "no refresh failed, so no backoff was armed");
            }
        }

        #endregion

        #region PreemptExpiryTime read and set back

        [TestMethod]
        public void InScope_PreemptExpiryTimeSetToValueRead_IsMeasuredFromBufferedExpiration()
        {
            // Documented behavior: the value read is the table window, measured from the reported expiration; a value
            // set is measured from Expiration, which has ExpirationBuffer subtracted, as in earlier versions of the SDK.
            var clock = new TestClock(T0);
            var creds = new CompatCredentials(clock, inScope: true);
            creds.GetCredentials();
            Assert.AreEqual(At(45), creds.State.AdvisoryRefreshAt, "table: reported expiration (T0+60m) - 15 minutes");

            creds.PreemptExpiryTime = creds.PreemptExpiryTime;
            clock.Now = At(59.5);
            creds.GetCredentials(); // next generation, fetched at T0+59.5m
            Assert.AreEqual(At(59.5 + 60 - 1 - 15), creds.State.AdvisoryRefreshAt, "set value: Expiration - 15 minutes");
        }

        #endregion

        #region Helpers

        private static Task<ImmutableCredentials> Get(RefreshingAWSCredentials creds, bool useAsync)
            => useAsync ? creds.GetCredentialsAsync() : Task.FromResult(creds.GetCredentials());

        private static Task<ImmutableCredentials> GetMinimumLifetime(RefreshingAWSCredentials creds, bool useAsync)
            => GetMinimumLifetime(creds, useAsync, TimeSpan.FromMinutes(15));

        private static Task<ImmutableCredentials> GetMinimumLifetime(RefreshingAWSCredentials creds, bool useAsync, TimeSpan minimumLifetime)
            => useAsync
                ? creds.GetCredentialsAsync(minimumLifetime)
                : Task.FromResult(creds.GetCredentials(minimumLifetime));

        private static async Task<T> GetError<T>(RefreshingAWSCredentials creds, bool useAsync) where T : Exception
        {
            if (useAsync)
                return await Assert.ThrowsExactlyAsync<T>(() => creds.GetCredentialsAsync());
            return Assert.ThrowsExactly<T>(() => creds.GetCredentials());
        }

        private static async Task<T> GetMinimumLifetimeError<T>(RefreshingAWSCredentials creds, bool useAsync) where T : Exception
        {
            if (useAsync)
                return await Assert.ThrowsExactlyAsync<T>(() => creds.GetCredentialsAsync(TimeSpan.FromMinutes(30)));
            return Assert.ThrowsExactly<T>(() => creds.GetCredentials(TimeSpan.FromMinutes(30)));
        }

        private static DefaultInstanceProfileAWSCredentials NewImdsProvider(StubImds imds, ITimeProvider clock)
        {
            var provider = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(imds, clock);
            provider.RefreshBackoffGenerator = () => Backoff;
            return provider;
        }

        // True when no refresh holds the lock and no background refresh is pending.
        private static bool IsIdle(RefreshingAWSCredentials creds) => RefreshingCredentialsTestProbes.IsIdle(creds);

        // Waits for the background refresh a call started: the source has been called sourceCalls times and the
        // provider is idle again. The timeout only elapses when a test fails.
        private static void WaitUntilIdle(CompatCredentials creds, int sourceCalls)
        {
            Assert.IsTrue(SpinWait.SpinUntil(() => creds.SourceCalls >= sourceCalls && IsIdle(creds), WaitTimeout),
                "expected " + sourceCalls + " source calls and an idle provider; saw " + creds.SourceCalls + " source calls");
            Assert.AreEqual(sourceCalls, creds.SourceCalls);
        }

        #endregion

        #region Test doubles

        private sealed class TestClock : ITimeProvider
        {
            private long _nowTicks;

            public TestClock(DateTime now)
            {
                Now = now;
            }

            public DateTime Now
            {
                get => new DateTime(Interlocked.Read(ref _nowTicks), DateTimeKind.Utc);
                set => Interlocked.Exchange(ref _nowTicks, value.ToUniversalTime().Ticks);
            }

            public void Advance(TimeSpan by) => Now = Now + by;

            public DateTime CorrectedUtcNow => Now;
        }

        /// <summary>
        /// A <see cref="RefreshingAWSCredentials"/> whose scope is chosen by the test, with deterministic backoff and
        /// error-cache durations, a gate that holds source calls, and injectable failures. Each generation has its own
        /// access key.
        /// </summary>
        private sealed class CompatCredentials : RefreshingAWSCredentials
        {
            private readonly bool _inScope;
            private readonly TimeSpan _lifetime;
            private readonly ManualResetEventSlim _gate = new ManualResetEventSlim(initialState: true);
            private int _sourceCalls;
            private int _generated;
            private int _failuresRemaining;
            private Func<int, Exception> _throwOnRefresh;
            private Exception _lastError;

            public CompatCredentials(ITimeProvider clock, bool inScope, TimeSpan? lifetime = null) : base(clock)
            {
                _inScope = inScope;
                _lifetime = lifetime ?? Lifetime;
                RefreshBackoffGenerator = () => Backoff;
                NonRecoverableErrorCacheGenerator = () => ErrorCacheDuration;
            }

            /// <summary>Computes the expiration of a generation from the fetch time. Defaults to fetch time + lifetime.</summary>
            public Func<DateTime, DateTime> ExpirationForNow { get; set; }

            public int SourceCalls => Volatile.Read(ref _sourceCalls);
            public Exception LastError => Volatile.Read(ref _lastError);

            public CredentialsRefreshState State
            {
                get => currentState;
                set => currentState = value;
            }

            // The way a subclass forced a refresh in earlier versions of the SDK.
            public void SetExpiration(DateTime expiration) => currentState.Expiration = expiration;

            /// <summary>
            /// Makes each source call throw the exception the factory returns for that call number, or succeed when it
            /// returns null.
            /// </summary>
            public void ThrowOnRefresh(Func<int, Exception> factory) => Volatile.Write(ref _throwOnRefresh, factory);
            public void ClearThrowOnRefresh() => Volatile.Write(ref _throwOnRefresh, null);
            public void FailNextRefreshes(int count) => Interlocked.Exchange(ref _failuresRemaining, count);
            public void CloseGate() => _gate.Reset();
            public void OpenGate() => _gate.Set();

            protected override bool UsesManagedRefreshLifecycle => _inScope;

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                var call = Interlocked.Increment(ref _sourceCalls);
                if (!_gate.Wait(WaitTimeout))
                    throw new TimeoutException("The test did not open the gate.");

                var error = Volatile.Read(ref _throwOnRefresh)?.Invoke(call);
                if (error == null && Interlocked.Decrement(ref _failuresRemaining) >= 0)
                    error = new AmazonClientException("Simulated credential source failure.");
                if (error != null)
                {
                    Volatile.Write(ref _lastError, error);
                    throw error;
                }

                var n = Interlocked.Increment(ref _generated);
                var now = _timeProvider.CorrectedUtcNow;
                var expiration = ExpirationForNow != null ? ExpirationForNow(now) : now + _lifetime;
                return new CredentialsRefreshState(
                    new ImmutableCredentials("AKIA_COMPAT_" + n, "secret_" + n, "token_" + n), expiration, _timeProvider);
            }
        }

        /// <summary>
        /// An HTTP credential provider that an application derives from <see cref="URIBasedRefreshingCredentialHelper"/>.
        /// Each generation expires 30 seconds after it is fetched, measured against the SDK clock, or the fetch throws
        /// <see cref="Failure"/> when it is set.
        /// </summary>
        private sealed class CustomHttpCredentials : URIBasedRefreshingCredentialHelper
        {
            private int _sourceCalls;

            public Exception Failure { get; set; }
            public int SourceCalls => Volatile.Read(ref _sourceCalls);

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                var n = Interlocked.Increment(ref _sourceCalls);
                var failure = Failure;
                if (failure != null)
                    throw failure;
                return new CredentialsRefreshState(new ImmutableCredentials("AKIA_HTTP_" + n, "secret_" + n, "token_" + n),
                    _timeProvider.CorrectedUtcNow.AddSeconds(30));
            }
        }

        private sealed class DerivedWrapperException : AmazonClientException
        {
            public DerivedWrapperException(Exception inner) : base("A provider-specific wrapper.", inner) { }
        }

        /// <summary>
        /// IMDS access stub. Each fetch returns a distinct access key (AK1, AK2, ...) that is either already expired or
        /// valid for 60 minutes, measured against the test clock, or throws <see cref="FailWith"/> when it is set.
        /// </summary>
        private sealed class StubImds : DefaultInstanceProfileAWSCredentials.IIMDSAccessMethods
        {
            internal static readonly TimeSpan ExpiredBy = TimeSpan.FromMinutes(30);

            private readonly TestClock _clock;
            private int _fetchCount;

            public StubImds(TestClock clock)
            {
                _clock = clock;
            }

            public bool ReturnExpired { get; set; }
            public Exception FailWith { get; set; }
            public int FetchCount => Volatile.Read(ref _fetchCount);

            public RefreshingAWSCredentials.CredentialsRefreshState FetchCredentials()
            {
                var n = Interlocked.Increment(ref _fetchCount);
                var failure = FailWith;
                if (failure != null)
                    throw failure;
                var now = _clock.CorrectedUtcNow;
                var expiration = ReturnExpired ? now - ExpiredBy : now + Lifetime;
                return new RefreshingAWSCredentials.CredentialsRefreshState(
                    new ImmutableCredentials("AK" + n, "sk" + n, "tok" + n), expiration, _clock);
            }

            public Task<RefreshingAWSCredentials.CredentialsRefreshState> FetchCredentialsAsync()
                => Task.Run(() => FetchCredentials());

            public void CheckIsIMDSEnabled()
            {
            }
        }

        /// <summary>
        /// Captures every message the SDK logger emits by registering a temporary <see cref="IAdaptorLoggerFactory"/>.
        /// Registering clears the logger cache, so credentials under test must be constructed inside the using scope.
        /// The message is formatted with <see cref="string.Format(IFormatProvider, string, object[])"/>, as the
        /// console logger does, so a malformed format string fails here as it does there.
        /// </summary>
        private sealed class LogCapture : IDisposable
        {
            public sealed class Entry
            {
                public SdkLogLevel Level { get; set; }
                public string Message { get; set; }
                public Exception Exception { get; set; }
            }

            private readonly string _factoryName = "credential-compat-capture-" + Guid.NewGuid().ToString("N");
            private readonly List<Entry> _entries = new List<Entry>();
            private readonly object _sync = new object();

            public LogCapture()
            {
                Logger.RegisterAdaptorLoggerFactory(new Factory(_factoryName, this));
            }

            // A snapshot copy, safe to enumerate while a background refresh may still be appending.
            public IReadOnlyList<Entry> Entries
            {
                get { lock (_sync) { return _entries.ToList(); } }
            }

            public void Dispose()
            {
                Logger.DeregisterAdaptorLoggerFactory(_factoryName);
                Logger.ClearLoggerCache();
            }

            private void Add(SdkLogLevel level, string message, Exception ex)
            {
                lock (_sync) { _entries.Add(new Entry { Level = level, Message = message, Exception = ex }); }
            }

            private sealed class Factory : IAdaptorLoggerFactory
            {
                private readonly LogCapture _owner;
                public Factory(string name, LogCapture owner) { Name = name; _owner = owner; }
                public string Name { get; }
                public IAdaptorLogger CreateAdaptorLogger(Type type) => new Adaptor(_owner);
            }

            private sealed class Adaptor : IAdaptorLogger
            {
                private readonly LogCapture _owner;
                public Adaptor(LogCapture owner) { _owner = owner; }
                public bool IsEnabled(SdkLogLevel level) => true;
                public void Log(SdkLogLevel level, string message, Exception ex, params object[] parameters)
                    => _owner.Add(level, string.Format(CultureInfo.CurrentCulture, message, parameters), ex);
            }
        }

        #endregion
    }
}
