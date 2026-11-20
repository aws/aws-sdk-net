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
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Lifecycle tests for <see cref="RefreshingAWSCredentials"/>: callers that wait for the refresh lock behind a
    /// non-recoverable failure, a background non-recoverable error reaching the next on-demand caller,
    /// ClearCredentials while a refresh is failing, the lock-free expiry of the refresh backoff, expirations with
    /// <see cref="DateTimeKind.Local"/>, rethrowing a cached error, and
    /// <see cref="RefreshingAWSCredentials.Invalidate"/> racing ClearCredentials, a direct state assignment or Dispose.
    /// <para />
    /// Time comes from a fake clock. Interleavings are forced from inside a clock read, which runs on the thread and
    /// at the point in the SDK call where the clock is read, so no test depends on thread timing or sleeps.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class CredentialRefreshLifecycleTests
    {
        private static readonly DateTime T0 = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static readonly TimeSpan Lifetime = TimeSpan.FromMinutes(60);
        private static readonly TimeSpan Backoff = TimeSpan.FromMinutes(7.5);
        private static readonly TimeSpan ErrorCacheDuration = TimeSpan.FromSeconds(3);
        private static readonly TimeSpan PastErrorCacheDuration = ErrorCacheDuration + TimeSpan.FromSeconds(1);
        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(30);
        private const int Callers = 8;

        // Credentials fetched at T0 have a 60-minute lifetime and PreemptExpiryTime is 15 minutes (see
        // LifecycleCredentials), so AdvisoryRefreshAt = T0+44m, Expiration = T0+59m (after the 1-minute buffer) and
        // RawExpiration = T0+60m.
        private static readonly DateTime AdvisoryTime = T0 + TimeSpan.FromMinutes(50);
        private static readonly DateTime MandatoryTime = T0 + TimeSpan.FromMinutes(59.5);

        #region Callers waiting for the lock behind a non-recoverable failure

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task NoCredentials_CallersWaitingBehindNonRecoverableError_SourceCalledOnce(bool useAsync)
        {
            var creds = new LifecycleCredentials(new TestClock(T0));
            creds.ThrowOnRefresh(n => new AmazonNonRecoverableCredentialsException("non-recoverable " + n));

            var results = useAsync ? await RunQueuedCallersAsync(creds) : RunQueuedCallers(creds, expectedSourceCalls: 1);

            Assert.AreEqual(1, creds.SourceCalls, "the callers that waited for the lock must receive the cached error without contacting the source");
            AssertAllReceived(creds.LastError, results);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task Mandatory_CallersWaitingBehindNonRecoverableError_SourceCalledOnce(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            creds.GetCredentials();
            clock.Now = MandatoryTime;
            creds.ThrowOnRefresh(n => new AmazonNonRecoverableCredentialsException("non-recoverable " + n));

            var results = useAsync ? await RunQueuedCallersAsync(creds) : RunQueuedCallers(creds, expectedSourceCalls: 2);

            Assert.AreEqual(2, creds.SourceCalls, "one initial fetch and one refresh; the callers that waited for the lock must receive the cached error");
            AssertAllReceived(creds.LastError, results);
        }

        [TestMethod]
        public void BackgroundRefresh_ErrorCachedBeforeItAcquiresTheLock_DoesNotContactSource()
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            creds.GetCredentials();
            clock.Now = AdvisoryTime;

            // The first clock read on another thread is the background refresh classifying the credentials after it
            // acquired the lock. Caching an error there stands in for another caller that cached one after this
            // background refresh was dispatched.
            var cached = new AmazonNonRecoverableCredentialsException("cached by another caller");
            var testThread = Environment.CurrentManagedThreadId;
            var hookRan = new ManualResetEventSlim();
            clock.OnRead(() => Environment.CurrentManagedThreadId != testThread, () =>
            {
                creds.CacheNonRecoverableErrorForTest(cached);
                hookRan.Set();
            });

            creds.GetCredentials(); // advisory: serves cached and dispatches the background refresh
            Assert.IsTrue(hookRan.Wait(WaitTimeout), "the background refresh did not run");
            Assert.IsTrue(SpinWait.SpinUntil(() => IsIdle(creds), WaitTimeout), "the background refresh did not finish");

            Assert.AreEqual(1, creds.SourceCalls, "the background refresh must not contact the source while a non-recoverable error is cached");
            var thrown = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
            Assert.AreSame(cached, thrown, "the cached error is left for the next on-demand caller");
        }

        #endregion

        #region A background non-recoverable error reaches the next on-demand caller

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task Advisory_AfterBackgroundNonRecoverableError_NextCallRefreshesWhileWaitingAndRaisesError(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            var gen1 = await Get(creds, useAsync);
            clock.Now = AdvisoryTime;
            creds.ThrowOnRefresh(n => new AmazonNonRecoverableCredentialsException("non-recoverable " + n));

            Assert.AreSame(gen1, await Get(creds, useAsync), "an advisory call serves the cached credentials");
            Assert.IsTrue(SpinWait.SpinUntil(() => creds.HasCachedErrorForTest && IsIdle(creds), WaitTimeout), "the background refresh did not cache its error");
            var backgroundError = creds.LastError;
            Assert.AreEqual(2, creds.SourceCalls);

            // Within the cache duration the cached error is raised without contacting the source.
            Assert.AreSame(backgroundError, await GetError(creds, useAsync));
            Assert.AreEqual(2, creds.SourceCalls);

            // After the cache duration, still in the advisory window: the call refreshes while it waits, instead of
            // returning the cached credentials and dispatching another background refresh, and raises the error.
            clock.Advance(PastErrorCacheDuration);
            var recurring = await GetError(creds, useAsync);
            Assert.AreEqual(3, creds.SourceCalls, "the caller must contact the source itself");
            Assert.AreSame(creds.LastError, recurring, "the caller receives the error from its own attempt");
            Assert.AreNotSame(backgroundError, recurring);

            // Within the new cache duration: the cached error again, without a source call.
            Assert.AreSame(recurring, await GetError(creds, useAsync));
            Assert.AreEqual(3, creds.SourceCalls);

            // The source recovers: the next call after the cache duration refreshes and returns new credentials.
            creds.ClearThrowOnRefresh();
            clock.Advance(PastErrorCacheDuration);
            var gen2 = await Get(creds, useAsync);
            Assert.AreEqual(4, creds.SourceCalls);
            Assert.AreNotEqual(gen1.Token, gen2.Token, "the call returns the refreshed credentials");

            // The success cleared the failure state, so an advisory call is non-blocking again.
            clock.Advance(TimeSpan.FromMinutes(50)); // inside gen2's advisory window
            creds.CloseGate();
            try
            {
                var call = useAsync ? creds.GetCredentialsAsync() : Task.Run(() => creds.GetCredentials());
                Assert.IsTrue(call.Wait(WaitTimeout), "the advisory call must not wait for the background refresh");
                Assert.AreSame(gen2, call.Result);
            }
            finally
            {
                creds.OpenGate();
            }
            Assert.IsTrue(SpinWait.SpinUntil(() => creds.SourceCalls == 5 && IsIdle(creds), WaitTimeout), "the background refresh did not run");
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task Advisory_AfterBackgroundNonRecoverableError_RecoverableFailureAppliesBackoffAndServesCached(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            var gen1 = await Get(creds, useAsync);
            clock.Now = AdvisoryTime;
            creds.ThrowOnRefresh(n => new AmazonNonRecoverableCredentialsException("non-recoverable " + n));
            await Get(creds, useAsync); // dispatches the background refresh, which fails non-recoverably
            Assert.IsTrue(SpinWait.SpinUntil(() => creds.HasCachedErrorForTest && IsIdle(creds), WaitTimeout), "the background refresh did not cache its error");

            // After the cache duration the caller refreshes while it waits. This time the failure is recoverable:
            // the still-valid cached credentials are returned and the refresh backoff applies.
            creds.ClearThrowOnRefresh();
            creds.FailNextRefreshes(1);
            clock.Advance(PastErrorCacheDuration);
            Assert.AreSame(gen1, await Get(creds, useAsync));
            Assert.AreEqual(3, creds.SourceCalls, "the caller must contact the source itself");

            // The backoff is in effect: once a rejection moves the credentials to the mandatory path, the cached
            // credentials are returned without a source call.
            creds.Invalidate(gen1);
            Assert.AreSame(gen1, await Get(creds, useAsync));
            Assert.AreEqual(3, creds.SourceCalls, "no refresh may be attempted until the backoff has elapsed");
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task Advisory_AfterBackgroundNonRecoverableError_CallerFindingRefreshInProgressServesCached(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            var gen1 = await Get(creds, useAsync);
            clock.Now = AdvisoryTime;
            creds.ThrowOnRefresh(n => new AmazonNonRecoverableCredentialsException("non-recoverable " + n));
            await Get(creds, useAsync); // dispatches the background refresh, which fails non-recoverably
            Assert.IsTrue(SpinWait.SpinUntil(() => creds.HasCachedErrorForTest && IsIdle(creds), WaitTimeout), "the background refresh did not cache its error");
            clock.Advance(PastErrorCacheDuration);

            // The first call after the cache duration refreshes while it waits. Its source call waits on the gate, so
            // it holds the refresh lock.
            Task<ImmutableCredentials> first;
            creds.CloseGate();
            try
            {
                first = useAsync ? creds.GetCredentialsAsync() : Task.Run(() => creds.GetCredentials());
                Assert.IsTrue(SpinWait.SpinUntil(() => creds.SourceCalls == 3, WaitTimeout), "the first caller did not reach the source");

                // Another call in the advisory window finds that refresh in progress. The cached credentials are still
                // valid, so it returns them at once instead of waiting for the refresh and receiving its error.
                var second = useAsync ? creds.GetCredentialsAsync() : Task.Run(() => creds.GetCredentials());
                Assert.IsTrue(second.Wait(WaitTimeout), "the second caller must not wait for the refresh in progress");
                Assert.AreSame(gen1, second.Result);
                Assert.IsFalse(first.IsCompleted, "precondition: the first caller's refresh is still in progress");
                Assert.AreEqual(3, creds.SourceCalls, "the second caller must not contact the source");
            }
            finally
            {
                creds.OpenGate();
            }

            var error = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => first);
            Assert.AreSame(creds.LastError, error, "the first caller receives the error from its own attempt");
            Assert.AreEqual(3, creds.SourceCalls);
        }

        #endregion

        #region ClearCredentials

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task ClearCredentials_ClearsCachedNonRecoverableError(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            await Get(creds, useAsync);
            clock.Now = MandatoryTime;
            creds.ThrowOnRefresh(n => new AmazonNonRecoverableCredentialsException("non-recoverable " + n));
            await GetError(creds, useAsync);
            Assert.IsTrue(creds.HasCachedErrorForTest, "precondition: the non-recoverable error is cached");
            var callsBefore = creds.SourceCalls;

            creds.ClearCredentials();
            Assert.IsFalse(creds.HasCachedErrorForTest, "ClearCredentials must clear the cached non-recoverable error");
            Assert.IsNull(creds.State);

            // Still inside the error cache duration: the next call contacts the source instead of raising the error.
            creds.ClearThrowOnRefresh();
            Assert.IsNotNull(await Get(creds, useAsync));
            Assert.AreEqual(callsBefore + 1, creds.SourceCalls);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task ClearCredentials_ClearsRefreshBackoff(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            var gen1 = await Get(creds, useAsync);
            clock.Now = MandatoryTime;
            creds.FailNextRefreshes(1);
            Assert.AreSame(gen1, await Get(creds, useAsync)); // fails recoverably and applies the refresh backoff
            Assert.AreSame(gen1, await Get(creds, useAsync));
            Assert.AreEqual(2, creds.SourceCalls, "precondition: the refresh backoff is in effect");

            creds.ClearCredentials();

            // An initial fetch never waits for the backoff, so assign expired credentials: the next call refreshes them
            // only if ClearCredentials cleared the refresh backoff.
            var seeded = new ImmutableCredentials("AKIA_SEEDED", "secret", "token");
            creds.SetState(new RefreshingAWSCredentials.CredentialsRefreshState(seeded, clock.Now - TimeSpan.FromMinutes(1), clock));
            Assert.AreNotSame(seeded, await Get(creds, useAsync));
            Assert.AreEqual(3, creds.SourceCalls, "ClearCredentials must clear the refresh backoff");
        }

        [TestMethod]
        [DataRow(false, "NoCredentials")]
        [DataRow(true, "NoCredentials")]
        [DataRow(false, "Mandatory")]
        [DataRow(true, "Mandatory")]
        [DataRow(false, "Advisory")]
        [DataRow(true, "Advisory")]
        public async Task ClearCredentialsDuringFailingRefresh_NonRecoverableErrorNotCached(bool useAsync, string phase)
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            if (phase == "Mandatory")
            {
                await Get(creds, useAsync);
                clock.Now = MandatoryTime;
            }
            else if (phase == "Advisory")
            {
                // After a background non-recoverable error and its cache duration, an advisory call refreshes while it
                // waits.
                await Get(creds, useAsync);
                clock.Now = AdvisoryTime;
                creds.ThrowOnRefresh(n => new AmazonNonRecoverableCredentialsException("non-recoverable " + n));
                await Get(creds, useAsync);
                Assert.IsTrue(SpinWait.SpinUntil(() => creds.HasCachedErrorForTest && IsIdle(creds), WaitTimeout), "the background refresh did not cache its error");
                clock.Advance(PastErrorCacheDuration);
            }
            var callsBefore = creds.SourceCalls;

            // ClearCredentials runs while the source is being called, and then the source fails non-recoverably.
            creds.ThrowOnRefresh(n =>
            {
                creds.ClearCredentials();
                return new AmazonNonRecoverableCredentialsException("started before the reset " + n);
            });
            var failed = await GetError(creds, useAsync);
            Assert.AreEqual(callsBefore + 1, creds.SourceCalls, "precondition: the call contacted the source");
            Assert.AreSame(creds.LastError, failed, "the caller whose attempt failed still receives its error");
            Assert.IsFalse(creds.HasCachedErrorForTest, "an attempt that started before ClearCredentials must not cache its error after the reset");

            // The next call starts over: it contacts the source instead of raising the error from before the reset.
            creds.ClearThrowOnRefresh();
            Assert.IsNotNull(await Get(creds, useAsync));
            Assert.AreEqual(callsBefore + 2, creds.SourceCalls);
        }

        [TestMethod]
        public void ClearCredentialsDuringFailingBackgroundRefresh_NonRecoverableErrorNotCached()
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            var gen1 = creds.GetCredentials();
            clock.Now = AdvisoryTime;

            creds.ThrowOnRefresh(n =>
            {
                creds.ClearCredentials();
                return new AmazonNonRecoverableCredentialsException("started before the reset " + n);
            });
            Assert.AreSame(gen1, creds.GetCredentials()); // advisory: dispatches the background refresh
            Assert.IsTrue(SpinWait.SpinUntil(() => creds.SourceCalls == 2 && IsIdle(creds), WaitTimeout), "the background refresh did not run");
            Assert.IsFalse(creds.HasCachedErrorForTest, "an attempt that started before ClearCredentials must not cache its error after the reset");

            creds.ClearThrowOnRefresh();
            Assert.IsNotNull(creds.GetCredentials());
            Assert.AreEqual(3, creds.SourceCalls, "the next call must contact the source instead of raising the error from before the reset");
        }

        [TestMethod]
        [DataRow(false, false)]
        [DataRow(true, false)]
        [DataRow(false, true)]
        [DataRow(true, true)]
        public async Task ClearCredentialsDuringFailingRefresh_RefreshBackoffNotApplied(bool useAsync, bool minimumLifetime)
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            await Get(creds, useAsync);
            clock.Now = MandatoryTime;

            // ClearCredentials runs while the source is being called, and then the source fails recoverably.
            creds.ThrowOnRefresh(n =>
            {
                creds.ClearCredentials();
                return new AmazonClientException("started before the reset " + n);
            });
            if (!minimumLifetime)
                await Get(creds, useAsync); // mandatory refresh
            else if (useAsync)
                await Assert.ThrowsExactlyAsync<AmazonClientException>(() => creds.GetCredentialsAsync(TimeSpan.FromMinutes(15)));
            else
                Assert.ThrowsExactly<AmazonClientException>(() => creds.GetCredentials(TimeSpan.FromMinutes(15)));
            Assert.AreEqual(2, creds.SourceCalls, "precondition: the call contacted the source");

            // Credentials assigned after the reset have already expired. The next call refreshes them, because the
            // failure of the attempt that started before the reset did not apply the refresh backoff.
            creds.ClearThrowOnRefresh();
            var seeded = new ImmutableCredentials("AKIA_SEEDED", "secret", "token");
            creds.SetState(new RefreshingAWSCredentials.CredentialsRefreshState(seeded, clock.Now - TimeSpan.FromMinutes(1), clock));
            Assert.AreNotSame(seeded, await Get(creds, useAsync));
            Assert.AreEqual(3, creds.SourceCalls, "no refresh backoff may apply after ClearCredentials");
        }

        #endregion

        #region Lock-free expiry of the refresh backoff

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task ElapsedBackoffClearedWithoutLock_DoesNotEraseNewerBackoff(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            var gen1 = creds.GetCredentials();

            // A background refresh fails recoverably: backoff until AdvisoryTime + 7.5m = T0+57.5m.
            clock.Now = AdvisoryTime;
            creds.FailNextRefreshes(1);
            creds.GetCredentials();
            Assert.IsTrue(SpinWait.SpinUntil(() => creds.SourceCalls == 2 && IsIdle(creds), WaitTimeout), "the background refresh did not run");

            // T0+58m: that backoff has elapsed and the credentials are still in the advisory window, so the next call
            // clears the elapsed backoff without the lock before it dispatches a background refresh. The hook runs
            // after that call has read the elapsed backoff and before it clears it. There, a service rejection moves
            // the credentials to the mandatory path, where a refresh fails and applies a newer backoff.
            clock.Now = T0 + TimeSpan.FromMinutes(58);
            var testThread = Environment.CurrentManagedThreadId;
            var hookRan = false;
            clock.OnRead(
                () => Environment.CurrentManagedThreadId == testThread && IsOnStack("IsRefreshRateLimited", "TriggerBackgroundRefreshIfNeeded"),
                () =>
                {
                    hookRan = true;
                    creds.Invalidate(gen1);
                    creds.FailNextRefreshes(1);
                    creds.GetCredentials();
                });

            Assert.AreSame(gen1, await Get(creds, useAsync));
            Assert.IsTrue(hookRan, "precondition: the hook must run inside the lock-free backoff check");
            Assert.AreEqual(3, creds.SourceCalls, "precondition: the refresh inside the hook failed and applied a newer backoff");

            // The newer backoff must still apply: the next call, on the mandatory path, returns the cached credentials
            // without contacting the source.
            Assert.AreSame(gen1, await Get(creds, useAsync));
            Assert.IsTrue(SpinWait.SpinUntil(() => IsIdle(creds), WaitTimeout), "the background refresh did not finish");
            Assert.AreEqual(3, creds.SourceCalls, "clearing the elapsed backoff must not erase the newer one");
        }

        #endregion

        #region Expirations with DateTimeKind.Local

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task LocalKindExpiration_FromSource_BehavesLikeTheSameUtcInstant(bool useAsync)
        {
            // The source reports the same instant as the other tests (fetch time + 60 minutes), in local time. On a
            // host whose UTC offset is not zero the local ticks differ from the UTC ticks, which is what a refresh
            // decision that ignores DateTimeKind gets wrong. On any host every value a refresh decision uses must be
            // UTC.
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock) { ExpirationForNow = now => (now + Lifetime).ToLocalTime() };
            var offset = HostUtcOffsetMessage();

            var gen1 = await Get(creds, useAsync);
            var state = creds.State;
            Assert.AreEqual(DateTimeKind.Utc, state.ExpirationUtc.Kind, offset);
            Assert.AreEqual(T0 + TimeSpan.FromMinutes(59), state.ExpirationUtc, offset);
            Assert.AreEqual(DateTimeKind.Utc, state.RawExpiration.Kind, offset);
            Assert.AreEqual(T0 + Lifetime, state.RawExpiration, offset);
            Assert.AreEqual(DateTimeKind.Utc, state.AdvisoryRefreshAt.Kind, offset);
            Assert.AreEqual(T0 + TimeSpan.FromMinutes(44), state.AdvisoryRefreshAt, offset);
            Assert.AreEqual(Lifetime, state.Lifetime, offset);
            Assert.AreEqual(T0 + TimeSpan.FromMinutes(59), creds.Expiration, offset);

            // The public Expiration of the state keeps the kind the source used, and, as in earlier versions of the
            // SDK, is the reported expiration minus the 1-minute buffer.
            Assert.AreEqual(DateTimeKind.Local, state.Expiration.Kind, offset);
            Assert.AreEqual((T0 + TimeSpan.FromMinutes(59)).ToLocalTime(), state.Expiration, offset);

            // Valid until the advisory window: no further source call.
            clock.Now = T0 + TimeSpan.FromMinutes(43);
            for (var i = 0; i < 4; i++)
                Assert.AreSame(gen1, await Get(creds, useAsync), offset);
            Assert.AreEqual(1, creds.SourceCalls, offset);

            // Inside the mandatory window: a blocking refresh.
            clock.Now = MandatoryTime;
            var gen2 = await Get(creds, useAsync);
            Assert.AreEqual(2, creds.SourceCalls, offset);
            Assert.AreNotEqual(gen1.Token, gen2.Token, offset);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task LocalKindExpiration_StateAssignedDirectly_ClassifiedLikeTheSameUtcInstant(bool useAsync)
        {
            // A subclass can assign currentState without a refresh (CognitoAWSCredentials does, from its cache).
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            var seeded = new ImmutableCredentials("AKIA_SEEDED", "secret", "token");
            creds.SetState(new RefreshingAWSCredentials.CredentialsRefreshState(seeded, (T0 + Lifetime).ToLocalTime(), clock));
            var offset = HostUtcOffsetMessage();

            Assert.AreEqual(DateTimeKind.Utc, creds.State.RawExpiration.Kind, offset);
            Assert.AreEqual(T0 + Lifetime, creds.State.RawExpiration, offset);
            Assert.AreEqual(DateTimeKind.Utc, creds.State.AdvisoryRefreshAt.Kind, offset);
            Assert.AreEqual(T0 + Lifetime, creds.State.AdvisoryRefreshAt, offset);
            Assert.AreEqual(DateTimeKind.Local, creds.State.Expiration.Kind, "the assigned expiration keeps its kind. " + offset);
            Assert.AreEqual(T0 + Lifetime, creds.Expiration, offset);

            // Assigning Expiration later also moves the UTC instant that refresh decisions use.
            var reassigned = new RefreshingAWSCredentials.CredentialsRefreshState(seeded, T0, clock);
            reassigned.Expiration = (T0 + Lifetime).ToLocalTime();
            Assert.AreEqual(DateTimeKind.Utc, reassigned.ExpirationUtc.Kind, offset);
            Assert.AreEqual(T0 + Lifetime, reassigned.ExpirationUtc, offset);

            clock.Now = T0 + TimeSpan.FromMinutes(30);
            Assert.AreSame(seeded, await Get(creds, useAsync), offset);
            Assert.AreEqual(0, creds.SourceCalls, "the seeded credentials are valid for another 30 minutes. " + offset);

            clock.Now = T0 + Lifetime + TimeSpan.FromMinutes(1);
            Assert.AreNotSame(seeded, await Get(creds, useAsync), offset);
            Assert.AreEqual(1, creds.SourceCalls, "the seeded credentials have expired and must be refreshed. " + offset);
        }

        #endregion

        #region Rethrowing a cached non-recoverable error

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task CachedNonRecoverableError_RethrownRepeatedly_StackTraceDoesNotGrow(bool useAsync)
        {
            var creds = new LifecycleCredentials(new TestClock(T0));
            var error = new AmazonNonRecoverableCredentialsException("token expired");
            creds.ThrowOnRefresh(_ => error);

            // The first call contacts the source and caches the error; every later call receives the cached error.
            var traces = new List<string>();
            for (var i = 0; i < 20; i++)
            {
                var thrown = await GetError(creds, useAsync);
                Assert.AreSame(error, thrown);
                traces.Add(thrown.StackTrace);
            }

            Assert.AreEqual(1, creds.SourceCalls);
            Assert.AreEqual(traces[1], traces[traces.Count - 1],
                "each rethrow of the cached error must start from the stack trace captured when it was cached");
        }

        #endregion

        #region Invalidate racing other writers

        [TestMethod]
        public void Invalidate_ClearCredentialsDuringCall_CredentialsStayCleared()
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            var gen1 = creds.GetCredentials();

            // Runs inside Invalidate after it has matched the cached access key and before it replaces the state.
            clock.OnRead(() => IsOnStack("Invalidate"), () => creds.ClearCredentials());
            creds.Invalidate(gen1);

            Assert.IsNull(creds.State, "Invalidate must not bring back credentials that ClearCredentials removed");
            Assert.IsNull(creds.Expiration);

            // With nothing cached the next call is an initial fetch, so a failing source is reported instead of being
            // hidden behind the cleared credentials.
            creds.FailNextRefreshes(1);
            Assert.ThrowsExactly<AmazonClientException>(() => creds.GetCredentials());
            Assert.AreEqual(2, creds.SourceCalls);
        }

        [TestMethod]
        public void Invalidate_StateAssignedDuringCall_AssignedStateKept()
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            var gen1 = creds.GetCredentials();
            var replacement = new RefreshingAWSCredentials.CredentialsRefreshState(
                new ImmutableCredentials(gen1.AccessKey, "replacement-secret", "replacement-token"), T0 + Lifetime, clock);

            clock.OnRead(() => IsOnStack("Invalidate"), () => creds.SetState(replacement));
            creds.Invalidate(gen1);

            Assert.AreSame(replacement, creds.State, "Invalidate must not overwrite a state assigned while it ran");
            Assert.AreSame(replacement.Credentials, creds.GetCredentials(), "the assigned credentials are still valid");
            Assert.AreEqual(1, creds.SourceCalls);
        }

        [TestMethod]
        public void Invalidate_DisposedWhileHoldingTheLock_DoesNotThrow()
        {
            var clock = new TestClock(T0);
            var creds = new LifecycleCredentials(clock);
            var gen1 = creds.GetCredentials();

            clock.OnRead(() => IsOnStack("Invalidate"), () => creds.Dispose());
            creds.Invalidate(gen1);

            creds.Invalidate(gen1); // after Dispose
        }

        [TestMethod]
        public void Invalidate_DisposedAfterItsDisposedCheck_DoesNotThrow()
        {
            var creds = new LifecycleCredentials(new TestClock(T0));
            var gen1 = creds.GetCredentials();
            creds.Dispose();

            // Stands in for a Dispose that runs after Invalidate has checked whether the instance is disposed: the
            // refresh lock is disposed, but the flag still reads false when Invalidate tries to take the lock.
            RefreshingCredentialsTestProbes.Require(DisposedField, "_disposed").SetValue(creds, false);
            creds.Invalidate(gen1);
        }

        #endregion

        #region Helpers

        private static Task<ImmutableCredentials> Get(RefreshingAWSCredentials creds, bool useAsync)
            => useAsync ? creds.GetCredentialsAsync() : Task.FromResult(creds.GetCredentials());

        private static async Task<AmazonNonRecoverableCredentialsException> GetError(RefreshingAWSCredentials creds, bool useAsync)
        {
            if (useAsync)
                return await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentialsAsync());
            return Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
        }

        // Calls GetCredentials() from Callers threads. The first reaches the source, which waits on the gate while it
        // holds the refresh lock; the rest are started only then, and the gate opens once all of them are waiting for
        // the lock, so every one of them has already passed the check that runs before the lock.
        private static Exception[] RunQueuedCallers(LifecycleCredentials creds, int expectedSourceCalls)
        {
            var results = new Exception[Callers];
            var threads = Enumerable.Range(0, Callers).Select(i => new Thread(() =>
            {
                try { creds.GetCredentials(); }
                catch (Exception e) { results[i] = e; }
            })).ToArray();

            creds.CloseGate();
            try
            {
                threads[0].Start();
                Assert.IsTrue(SpinWait.SpinUntil(() => creds.SourceCalls == expectedSourceCalls, WaitTimeout), "the first caller did not reach the source");
                foreach (var thread in threads.Skip(1))
                    thread.Start();
                var waiters = threads.Skip(1).ToArray();
                Assert.IsTrue(SpinWait.SpinUntil(() => RefreshingCredentialsTestProbes.AreWaitingForRefreshLock(creds, waiters), WaitTimeout), "the other callers did not wait for the lock");
            }
            finally
            {
                creds.OpenGate();
            }

            foreach (var thread in threads)
                Assert.IsTrue(thread.Join(WaitTimeout), "a caller did not finish");
            return results;
        }

        // Calls GetCredentialsAsync() Callers times from this thread. Each call runs synchronously up to its first
        // incomplete await: the first holds the refresh lock while its source call waits on the gate, and each of the
        // others has passed the check that runs before the lock and is waiting for the lock.
        private static async Task<Exception[]> RunQueuedCallersAsync(LifecycleCredentials creds)
        {
            Task<ImmutableCredentials>[] calls;
            creds.CloseGate();
            try
            {
                calls = Enumerable.Range(0, Callers).Select(_ => creds.GetCredentialsAsync()).ToArray();
                Assert.IsFalse(calls.Any(c => c.IsCompleted), "every call must be waiting for the source or for the lock");
            }
            finally
            {
                creds.OpenGate();
            }

            var results = new Exception[Callers];
            for (var i = 0; i < Callers; i++)
            {
                try { await calls[i].ConfigureAwait(false); }
                catch (Exception e) { results[i] = e; }
            }
            return results;
        }

        private static void AssertAllReceived(Exception expected, Exception[] results)
        {
            Assert.IsInstanceOfType<AmazonNonRecoverableCredentialsException>(expected);
            for (var i = 0; i < results.Length; i++)
                Assert.AreSame(expected, results[i], "caller " + i + " must receive the error from the single source call");
        }

        private static bool IsOnStack(params string[] methodNames)
        {
            var frames = new StackTrace().GetFrames();
            return frames != null && frames.Any(f => Array.IndexOf(methodNames, f.GetMethod()?.Name) >= 0);
        }

        private static string HostUtcOffsetMessage()
            => "Host UTC offset at the test instant: " + TimeZoneInfo.Local.GetUtcOffset(T0 + Lifetime) + ".";

        private static readonly FieldInfo DisposedField =
            typeof(RefreshingAWSCredentials).GetField("_disposed", BindingFlags.Instance | BindingFlags.NonPublic);

        private static bool IsIdle(RefreshingAWSCredentials creds) => RefreshingCredentialsTestProbes.IsIdle(creds);

        #endregion

        #region Test doubles

        /// <summary>
        /// A fake clock. <see cref="OnRead"/> runs an action once, on the first read of the clock for which a
        /// condition holds. The action runs on the reading thread, inside the SDK call that read the clock, which
        /// lets a test act at an exact point in that call.
        /// </summary>
        private sealed class TestClock : ITimeProvider
        {
            private long _nowTicks;
            private ReadHook _hook;

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

            public void OnRead(Func<bool> condition, Action action) => Volatile.Write(ref _hook, new ReadHook(condition, action));

            public DateTime CorrectedUtcNow
            {
                get
                {
                    var hook = Volatile.Read(ref _hook);
                    if (hook != null && hook.Condition() && Interlocked.CompareExchange(ref _hook, null, hook) == hook)
                        hook.Action();
                    return Now;
                }
            }

            private sealed class ReadHook
            {
                public ReadHook(Func<bool> condition, Action action)
                {
                    Condition = condition;
                    Action = action;
                }

                public Func<bool> Condition { get; }
                public Action Action { get; }
            }
        }

        /// <summary>
        /// An in-scope <see cref="RefreshingAWSCredentials"/> with deterministic backoff and error-cache durations, a
        /// gate that holds source calls, and injectable failures. Every generation uses the same access key.
        /// </summary>
        private sealed class LifecycleCredentials : RefreshingAWSCredentials
        {
            private readonly ManualResetEventSlim _gate = new ManualResetEventSlim(initialState: true);
            private int _sourceCalls;
            private int _generated;
            private int _failuresRemaining;
            private Func<int, Exception> _throwOnRefresh;
            private Exception _lastError;

            public LifecycleCredentials(ITimeProvider clock) : base(clock)
            {
                RefreshBackoffGenerator = () => Backoff;
                NonRecoverableErrorCacheGenerator = () => ErrorCacheDuration;
                PreemptExpiryTime = TimeSpan.FromMinutes(15);
            }

            /// <summary>Computes the expiration of a generation from the fetch time. Defaults to fetch time + 60 minutes.</summary>
            public Func<DateTime, DateTime> ExpirationForNow { get; set; }

            public int SourceCalls => Volatile.Read(ref _sourceCalls);
            public Exception LastError => Volatile.Read(ref _lastError);
            public CredentialsRefreshState State => currentState;
            public void SetState(CredentialsRefreshState state) => currentState = state;

            /// <summary>Makes every source call throw the exception the factory returns for that call number.</summary>
            public void ThrowOnRefresh(Func<int, Exception> factory) => Volatile.Write(ref _throwOnRefresh, factory);
            public void ClearThrowOnRefresh() => Volatile.Write(ref _throwOnRefresh, null);
            public void FailNextRefreshes(int count) => Interlocked.Exchange(ref _failuresRemaining, count);
            public void CloseGate() => _gate.Reset();
            public void OpenGate() => _gate.Set();

            protected override bool UsesManagedRefreshLifecycle => true;

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                var call = Interlocked.Increment(ref _sourceCalls);
                if (!_gate.Wait(WaitTimeout))
                    throw new TimeoutException("The test did not open the gate.");

                var factory = Volatile.Read(ref _throwOnRefresh);
                if (factory != null)
                {
                    var error = factory(call);
                    Volatile.Write(ref _lastError, error);
                    throw error;
                }
                if (Interlocked.Decrement(ref _failuresRemaining) >= 0)
                    throw new AmazonClientException("Simulated credential source failure.");

                var n = Interlocked.Increment(ref _generated);
                var now = _timeProvider.CorrectedUtcNow;
                var expiration = ExpirationForNow != null ? ExpirationForNow(now) : now + Lifetime;
                return new CredentialsRefreshState(
                    new ImmutableCredentials("AKIA_LIFECYCLE", "secret_" + n, "token_" + n), expiration, _timeProvider);
            }
        }

        #endregion
    }
}
