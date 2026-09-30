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
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Logging;
using Amazon.S3;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for the credential refresh lifecycle of <see cref="RefreshingAWSCredentials"/>: the five-state lifecycle, the
    /// advisory window lifetime table, the jittered refresh backoff, non-recoverable error classification and caching,
    /// static stability, the providers the lifecycle applies to, and Invalidate() plus its pipeline wiring. Refresh
    /// windows are driven by a mock clock. Tests with a background refresh or concurrent callers wait for an observable
    /// event (a source call, a published state, a caller blocked on the refresh lock, an idle provider) with a timeout
    /// that only elapses when a test fails; no test sleeps for a fixed time.
    /// </summary>
    [TestClass]
    public sealed class CredentialRefreshBehaviorTests
    {
        private MockTimeProvider _clock;
        private readonly DateTime _baseTimeUtc = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static readonly TimeSpan Lifetime60 = TimeSpan.FromMinutes(60);
        private static readonly TimeSpan Backoff = TimeSpan.FromMinutes(7.5); // deterministic, inside [60s,600s]

        // Bounds every wait on a background refresh or another caller. It only elapses when a test fails.
        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(30);

        // How long a gated source call waits for the test to open the gate before it gives up. Longer than WaitTimeout,
        // so a caller that wrongly waits for a gated refresh is still waiting when a WaitTimeout-bounded check fails.
        private static readonly TimeSpan GateTimeout = TimeSpan.FromSeconds(60);

        [TestInitialize]
        public void Initialize() => _clock = new MockTimeProvider { CorrectedUtcNow = _baseTimeUtc };

        private TestRefreshingCredentials NewCreds(TimeSpan lifetime, TimeSpan? explicitPreempt = null)
        {
            var creds = new TestRefreshingCredentials(lifetime, _clock);
            if (explicitPreempt.HasValue)
                creds.PreemptExpiryTime = explicitPreempt.Value;
            return creds;
        }

        private void SetNow(double minutesFromBase) =>
            _clock.CorrectedUtcNow = _baseTimeUtc + TimeSpan.FromMinutes(minutesFromBase);

        #region State model

        [TestMethod]
        public void NoCredentials_FirstCall_BlockingFetch()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var c = creds.GetCredentials();
            Assert.IsNotNull(c);
            Assert.AreEqual(1, creds.GeneratedTokenCount);
        }

        [TestMethod]
        public void Valid_WellBeforeAdvisory_ReturnsCachedNoRefresh()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            SetNow(30); // AdvisoryRefreshAt is t0+44 -> still Valid
            var again = creds.GetCredentials();

            Assert.AreEqual(initial, again);
            Assert.AreEqual(1, creds.GeneratedTokenCount);
        }

        [TestMethod]
        public void ExactlyAtAdvisory_ReturnsCached_StartsBackgroundRefresh()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();
            var previousState = creds.CurrentState;

            SetNow(44); // exactly AdvisoryRefreshAt
            var during = creds.GetCredentials();
            Assert.AreEqual(initial, during); // cached returned immediately

            Assert.IsTrue(SpinWait.SpinUntil(() => !ReferenceEquals(creds.CurrentState, previousState), WaitTimeout));
            Assert.AreEqual(2, creds.GeneratedTokenCount);
        }

        [TestMethod]
        public void InsideAdvisory_FiveThreads_ExactlyOneBackgroundRefresh()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();
            var previousState = creds.CurrentState;

            SetNow(50);
            Task<ImmutableCredentials>[] tasks;
            creds.CloseGate();
            try
            {
                tasks = Enumerable.Range(0, 5).Select(_ => Task.Run(() => creds.GetCredentials())).ToArray();
            }
            finally
            {
                creds.OpenGate();
            }
            Assert.IsTrue(Task.WaitAll(tasks, WaitTimeout), "the advisory callers did not finish");

            Assert.IsTrue(SpinWait.SpinUntil(() => !ReferenceEquals(creds.CurrentState, previousState), WaitTimeout));
            WaitUntilIdle(creds);
            Assert.AreEqual(2, creds.GeneratedTokenCount); // 1 initial + exactly 1 background
            // Each racing thread observed either the cached credentials or the single refreshed set -- never a
            // torn or third value. Which one depends on timing; the guarantee is that only one background refresh
            // ran (asserted above).
            var refreshedCreds = creds.CurrentState.Credentials;
            foreach (var t in tasks)
                Assert.IsTrue(t.Result == initial || t.Result == refreshedCreds);
        }

        [TestMethod]
        public void InsideMandatory_BlockingRefresh()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            SetNow(59.5); // Expiration=t0+59, RawExpiration=t0+60 -> Mandatory
            var refreshed = creds.GetCredentials();

            Assert.AreNotEqual(initial, refreshed);
            Assert.AreEqual(2, creds.GeneratedTokenCount);
        }

        [TestMethod]
        public void PastRawExpiration_BlockingRefresh()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            SetNow(61); // past RawExpiration -> Expired
            var refreshed = creds.GetCredentials();

            Assert.AreNotEqual(initial, refreshed);
            Assert.AreEqual(2, creds.GeneratedTokenCount);
        }

        #endregion

        #region Advisory window lifetime table

        private void AssertAdvisoryWindow(TimeSpan lifetime, TimeSpan expectedWindow)
        {
            var creds = NewCreds(lifetime); // no explicit preempt -> table governs
            creds.GetCredentials();
            var state = creds.CurrentState;
            // The advisory refresh fires at RawExpiration - advisoryWindow: the window is measured from the expiration
            // the provider reported. ResolveAdvisoryWindow subtracts ExpirationBuffer from the table value to cancel the
            // buffer already applied to Expiration.
            Assert.AreEqual(state.RawExpiration - expectedWindow, state.AdvisoryRefreshAt,
                $"lifetime {lifetime} should map to advisory window {expectedWindow} measured from raw expiration");
        }

        [TestMethod]
        public void Window_15MinLifetime_5MinAdvisory() => AssertAdvisoryWindow(TimeSpan.FromMinutes(15), TimeSpan.FromMinutes(5));

        [TestMethod]
        public void Window_60MinLifetime_15MinAdvisory() => AssertAdvisoryWindow(TimeSpan.FromMinutes(60), TimeSpan.FromMinutes(15));

        [TestMethod]
        public void Window_12HourLifetime_60MinAdvisory() => AssertAdvisoryWindow(TimeSpan.FromHours(12), TimeSpan.FromMinutes(60));

        [TestMethod] // Boundary: exactly 20 min -> 5 min
        public void Window_Exactly20MinLifetime_5MinAdvisory() => AssertAdvisoryWindow(TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(5));

        [TestMethod] // Boundary: exactly 90 min -> 60 min
        public void Window_Exactly90MinLifetime_60MinAdvisory() => AssertAdvisoryWindow(TimeSpan.FromMinutes(90), TimeSpan.FromMinutes(60));

        [TestMethod]
        public void Window_ExplicitPreemptOverridesTable()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(25)); // table would give 15, explicit says 25
            creds.GetCredentials();
            var state = creds.CurrentState;
            Assert.AreEqual(state.Expiration - TimeSpan.FromMinutes(25), state.AdvisoryRefreshAt);
            Assert.AreEqual(TimeSpan.FromMinutes(25), creds.PreemptExpiryTime);
        }

        [TestMethod]
        public void Window_ShortCredsBornInsideWindow_ClampedToNow()
        {
            var creds = NewCreds(TimeSpan.FromMinutes(3)); // table gives 5 min > (3 - 1) buffer window
            creds.GetCredentials();
            var state = creds.CurrentState;
            // AdvisoryRefreshAt would be in the past; it must be clamped to the fetch time (base time).
            Assert.AreEqual(_baseTimeUtc, state.AdvisoryRefreshAt);
        }

        [TestMethod]
        public void PolicyTable_DirectBoundaries()
        {
            Assert.AreEqual(TimeSpan.FromMinutes(5), CredentialRefreshPolicy.AdvisoryWindowForLifetime(TimeSpan.Zero));
            Assert.AreEqual(TimeSpan.FromMinutes(5), CredentialRefreshPolicy.AdvisoryWindowForLifetime(TimeSpan.FromMinutes(20)));
            Assert.AreEqual(TimeSpan.FromMinutes(15), CredentialRefreshPolicy.AdvisoryWindowForLifetime(TimeSpan.FromMinutes(20.0001)));
            Assert.AreEqual(TimeSpan.FromMinutes(15), CredentialRefreshPolicy.AdvisoryWindowForLifetime(TimeSpan.FromMinutes(89.999)));
            Assert.AreEqual(TimeSpan.FromMinutes(60), CredentialRefreshPolicy.AdvisoryWindowForLifetime(TimeSpan.FromMinutes(90)));
        }

        #endregion

        #region Refresh backoff

        // Drives creds to a recoverable mandatory failure at t0+59.5, arming the deterministic 7.5 min backoff.
        private TestRefreshingCredentials ArmBackoffAtMandatory()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            creds.GetCredentials();       // gen 1 at t0
            SetNow(59.5);                 // Mandatory
            creds.FailNextNRefreshes(1);
            var served = creds.GetCredentials(); // fails recoverably -> backoff set, static stability serves cached
            Assert.AreEqual(1, creds.GeneratedTokenCount);
            Assert.IsNotNull(served);
            return creds;
        }

        [TestMethod]
        public void Backoff_WithinWindow_NoProviderCall()
        {
            var creds = ArmBackoffAtMandatory();
            SetNow(59.5 + 7.0); // inside the 7.5 min backoff window
            creds.GetCredentials();
            Assert.AreEqual(1, creds.GeneratedTokenCount); // still no new provider call
            Assert.AreEqual(2, creds.AttemptCount);        // 1 initial success + 1 failed attempt only
        }

        [TestMethod]
        public void Backoff_AfterWindowElapses_ProviderCalledOnce()
        {
            var creds = ArmBackoffAtMandatory();
            SetNow(59.5 + 8.0); // past the 7.5 min backoff window
            var refreshed = creds.GetCredentials();
            Assert.AreEqual(2, creds.GeneratedTokenCount);
            Assert.IsNotNull(refreshed);
        }

        [TestMethod]
        public void Backoff_SuccessClears_ThenFailureReArms()
        {
            var creds = ArmBackoffAtMandatory();
            SetNow(59.5 + 8.0);
            creds.GetCredentials(); // success -> clears backoff (gen 2 fetched at this time)

            // gen2 fetched at t=67.5: Expiration = 67.5+59, RawExpiration = 67.5+60.
            SetNow(67.5 + 59.5); // Mandatory for gen2
            creds.FailNextNRefreshes(1);
            creds.GetCredentials(); // fails -> re-arm backoff, serve cached gen2
            Assert.AreEqual(2, creds.GeneratedTokenCount);

            // Prove backoff was re-armed: an immediate second call makes no provider attempt.
            var attemptsBefore = creds.AttemptCount;
            creds.GetCredentials();
            Assert.AreEqual(attemptsBefore, creds.AttemptCount);
        }

        [TestMethod]
        public void InitialFetchFailure_SetsNoBackoff_SecondCallRetries()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            creds.FailNextNRefreshes(2);

            Assert.ThrowsExactly<AmazonClientException>(() => creds.GetCredentials());
            // No backoff on initial fetch: the second call must attempt the provider again (and throw again).
            Assert.ThrowsExactly<AmazonClientException>(() => creds.GetCredentials());
            Assert.AreEqual(2, creds.AttemptCount);
            Assert.AreEqual(0, creds.GeneratedTokenCount);
        }

        #endregion

        #region Refresh backoff and non-recoverable error cache durations

        // The refresh backoff is uniformly random between 1 minute and half the remaining lifetime of the cached
        // credentials, with that upper bound kept between 90 seconds and 10 minutes (the SEP's RefreshBackoff table).
        [TestMethod]
        [DataRow(3600, 600, DisplayName = "1 hour left: 1 to 10 minutes")]
        [DataRow(1200, 600, DisplayName = "20 minutes left: 1 to 10 minutes")]
        [DataRow(600, 300, DisplayName = "10 minutes left: 1 to 5 minutes")]
        [DataRow(300, 150, DisplayName = "5 minutes left: 1 to 2.5 minutes")]
        [DataRow(180, 90, DisplayName = "3 minutes left: 1 to 1.5 minutes")]
        [DataRow(30, 90, DisplayName = "30 seconds left: 1 to 1.5 minutes")]
        [DataRow(0, 90, DisplayName = "expired: 1 to 1.5 minutes")]
        [DataRow(-600, 90, DisplayName = "expired 10 minutes ago: 1 to 1.5 minutes")]
        public void RefreshBackoff_IsUniformlyRandomBetween60SecondsAndHalfTheRemainingLifetime(int remainingSeconds, int upperSeconds)
            => AssertUniformlyRandom(() => CredentialRefreshPolicy.NextRefreshBackoff(TimeSpan.FromSeconds(remainingSeconds)),
                TimeSpan.FromSeconds(60), TimeSpan.FromSeconds(upperSeconds));

        [TestMethod]
        public void NonRecoverableErrorCacheDuration_IsUniformlyRandomBetween1And5Seconds()
            => AssertUniformlyRandom(CredentialRefreshPolicy.NextNonRecoverableErrorCacheDuration, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(5));

        // Draws samples on several threads at once, as concurrent refresh failures do, and checks that every sample is
        // in [min, max] and that every tenth of that range receives samples, which a constant or collapsed generator
        // would not.
        private static void AssertUniformlyRandom(Func<TimeSpan> next, TimeSpan min, TimeSpan max)
        {
            const int threadCount = 4;
            const int samplesPerThread = 2500;
            var samples = new TimeSpan[threadCount][];
            var threads = Enumerable.Range(0, threadCount).Select(t => new Thread(() =>
            {
                var drawn = new TimeSpan[samplesPerThread];
                for (var i = 0; i < samplesPerThread; i++)
                    drawn[i] = next();
                samples[t] = drawn;
            })).ToArray();
            foreach (var thread in threads)
                thread.Start();
            foreach (var thread in threads)
                Assert.IsTrue(thread.Join(WaitTimeout), "sampling did not finish");

            var all = samples.SelectMany(s => s).ToList();
            foreach (var sample in all)
                Assert.IsTrue(sample >= min && sample <= max, $"{sample} is outside [{min}, {max}]");

            var buckets = new int[10];
            foreach (var sample in all)
                buckets[Math.Min(9, (int)((sample - min).Ticks * 10 / (max - min).Ticks))]++;
            var expectedPerBucket = all.Count / buckets.Length;
            for (var b = 0; b < buckets.Length; b++)
                Assert.IsTrue(buckets[b] > expectedPerBucket / 2,
                    $"tenth {b} of the range received {buckets[b]} of {all.Count} samples; the values are not uniform");
            foreach (var perThread in samples)
                Assert.IsTrue(perThread.Distinct().Count() > samplesPerThread / 2, "each thread must draw distinct values");
        }

        // The production backoff is drawn from the remaining lifetime of the cached credentials when the refresh fails:
        // a mandatory refresh failing 30 seconds before the reported expiration backs off for 60 to 90 seconds, and a
        // background refresh failing 10 minutes before it backs off for 60 to 300 seconds. A background refresh runs off
        // the caller's thread, so each call is followed by a wait for the provider to become idle.
        [TestMethod]
        [DataRow(59.5, 90, DisplayName = "mandatory refresh, 30 seconds left: 60 to 90 seconds")]
        [DataRow(50.0, 300, DisplayName = "background refresh, 10 minutes left: 60 to 300 seconds")]
        public void DefaultRefreshBackoff_SuppressesRefreshFor60SecondsToHalfTheRemainingLifetime(double failAtMinutes, int upperSeconds)
        {
            var creds = new TestRefreshingCredentials(Lifetime60, _clock, pinDurations: false) { PreemptExpiryTime = TimeSpan.FromMinutes(15) };
            creds.GetCredentials();
            SetNow(failAtMinutes);
            var failedAt = _clock.CorrectedUtcNow;
            creds.FailNextNRefreshes(1);
            creds.GetCredentials(); // fails recoverably and applies the production refresh backoff
            WaitUntilIdle(creds);
            var attempts = creds.AttemptCount;
            Assert.AreEqual(2, attempts, "the refresh must have been attempted and failed");

            _clock.CorrectedUtcNow = failedAt + TimeSpan.FromSeconds(59.999);
            creds.GetCredentials();
            WaitUntilIdle(creds);
            Assert.AreEqual(attempts, creds.AttemptCount, "the refresh backoff must last at least 60 seconds");

            _clock.CorrectedUtcNow = failedAt + TimeSpan.FromSeconds(upperSeconds);
            creds.GetCredentials();
            WaitUntilIdle(creds);
            Assert.AreEqual(attempts + 1, creds.AttemptCount,
                $"the refresh backoff must end within {upperSeconds} seconds, half the remaining lifetime kept between 90 and 600 seconds");
            Assert.AreEqual(2, creds.GeneratedTokenCount);
        }

        [TestMethod]
        public void DefaultNonRecoverableErrorCache_RaisesCachedErrorFor1To5Seconds()
        {
            var creds = new TestRefreshingCredentials(Lifetime60, _clock, pinDurations: false) { PreemptExpiryTime = TimeSpan.FromMinutes(15) };
            creds.GetCredentials();
            SetNow(59.5); // Mandatory
            var failedAt = _clock.CorrectedUtcNow;
            var error = new AmazonNonRecoverableCredentialsException("token expired");
            creds.ThrowOnRefresh(error);
            Assert.AreSame(error, Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials()));
            var attempts = creds.AttemptCount;

            _clock.CorrectedUtcNow = failedAt + TimeSpan.FromSeconds(0.999);
            Assert.AreSame(error, Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials()));
            Assert.AreEqual(attempts, creds.AttemptCount, "the error must be cached for at least 1 second");

            creds.ClearThrowOnRefresh();
            _clock.CorrectedUtcNow = failedAt + TimeSpan.FromSeconds(5);
            Assert.IsNotNull(creds.GetCredentials());
            Assert.AreEqual(attempts + 1, creds.AttemptCount, "the error must be cached for at most 5 seconds");
        }

        #endregion

        #region Static stability

        [TestMethod]
        public void StaticStability_ExpiredCredsFailingProvider_ReturnsExpired()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            SetNow(61); // Expired
            creds.FailNextNRefreshes(10);
            var served = creds.GetCredentials(); // static stability

            Assert.AreEqual(initial, served);
            Assert.AreEqual(1, creds.GeneratedTokenCount);
        }

        #endregion

        #region Non-recoverable error and short cache

        [TestMethod]
        public void NonRecoverable_OnMandatory_Throws_NoBackoff_Cached()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            creds.GetCredentials();

            SetNow(59.5); // Mandatory
            creds.ThrowOnRefresh(new AmazonNonRecoverableCredentialsException("token expired"));
            Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
            Assert.AreEqual(1, creds.GeneratedTokenCount);
        }

        [TestMethod]
        public void NonRecoverable_SecondCallWithinCache_SameException_NoProviderCall()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            creds.GetCredentials();

            SetNow(59.5);
            creds.ThrowOnRefresh(new AmazonNonRecoverableCredentialsException("token expired"));
            Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
            var attemptsAfterFirst = creds.AttemptCount;

            // Within the deterministic 3s error cache -> short-circuits before taking the lock or calling the provider.
            SetNow(59.5 + (2.0 / 60.0)); // +2 seconds
            Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
            Assert.AreEqual(attemptsAfterFirst, creds.AttemptCount);
        }

        [TestMethod]
        public void NonRecoverable_CacheExpires_ProviderRetried()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            creds.GetCredentials();

            SetNow(59.5);
            creds.ThrowOnRefresh(new AmazonNonRecoverableCredentialsException("token expired"));
            Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
            var attemptsAfterFirst = creds.AttemptCount;

            creds.ClearThrowOnRefresh();
            SetNow(59.6); // +6 seconds > 3s deterministic cache
            var refreshed = creds.GetCredentials();
            Assert.IsNotNull(refreshed);
            Assert.IsTrue(creds.AttemptCount > attemptsAfterFirst);
        }

        #endregion

        #region Invalidate

        [TestMethod]
        public void Invalidate_MatchingAccessKey_NextCallRefreshes()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            SetNow(10); // Valid
            creds.Invalidate(initial);
            var refreshed = creds.GetCredentials();

            Assert.AreNotEqual(initial, refreshed);
            Assert.AreEqual(2, creds.GeneratedTokenCount);
        }

        [TestMethod]
        public void Invalidate_NonMatchingAccessKey_NoOp()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            SetNow(10);
            creds.Invalidate(new ImmutableCredentials("SOME_OTHER_KEY", "secret", "token"));
            var again = creds.GetCredentials();

            Assert.AreEqual(initial, again);
            Assert.AreEqual(1, creds.GeneratedTokenCount);
        }

        [TestMethod]
        public void Invalidate_WhileRefreshHoldsLock_ReturnsImmediately_NoDeadlock()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            Task<ImmutableCredentials> fetchTask;
            creds.CloseGate();
            try
            {
                // Thread A performs the blocking initial fetch and blocks inside GenerateNewCredentials holding the lock.
                fetchTask = Task.Run(() => creds.GetCredentials());
                Assert.IsTrue(SpinWait.SpinUntil(() => creds.AttemptCount >= 1, WaitTimeout), "initial fetch did not start");

                // Invalidate must not block on the held lock (try_acquire only). The gate stays closed while this
                // waits, so an Invalidate that waited for the lock could not finish.
                var invalidateTask = Task.Run(() => creds.Invalidate(new ImmutableCredentials("AKIA_KEY_1", "s", "t")));
                Assert.IsTrue(invalidateTask.Wait(WaitTimeout), "Invalidate blocked while a refresh held the lock");
            }
            finally
            {
                creds.OpenGate();
            }

            Assert.IsTrue(fetchTask.Wait(WaitTimeout));
            Assert.IsNotNull(fetchTask.Result);
            Assert.AreEqual(1, creds.GeneratedTokenCount);
        }

        [TestMethod] // Invalidate must not bypass or clear the refresh backoff.
        public void Invalidate_DuringActiveBackoff_NextCallServesCachedNoSourceCall()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials(); // gen1, key AKIA_KEY_1

            SetNow(59.5);
            creds.FailNextNRefreshes(10); // every refresh from here fails recoverably
            creds.GetCredentials();       // mandatory fail -> backoff armed, cached served
            Assert.AreEqual(1, creds.GeneratedTokenCount);
            var attemptsAfterBackoff = creds.AttemptCount;

            // Invalidate during active backoff: routes to the mandatory path but must not touch the backoff.
            creds.Invalidate(initial);
            var served = creds.GetCredentials();

            // The next call returns the cached credentials without contacting the source, because the
            // rate-limit gate is still in effect.
            Assert.AreEqual(initial, served);
            Assert.AreEqual(attemptsAfterBackoff, creds.AttemptCount, "Invalidate must not bypass the refresh backoff");
        }

        #endregion

        #region Unobserved exception and GetCredentials(TimeSpan)

        [TestMethod]
        public void AdvisoryRefreshFailure_DoesNotRaiseUnobservedTaskException()
        {
            // Finalize tasks that earlier tests left unobserved, so they are not finalized while the handler is installed.
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // The handler is process-wide and a faulted task leaked by other code can still be finalized while it is
            // installed, so only an unobserved exception carrying this test's own source error counts.
            var sourceError = new AmazonClientException("background refresh failure for the unobserved task check");
            var raised = 0;
            EventHandler<UnobservedTaskExceptionEventArgs> handler = (s, e) =>
            {
                if (e.Exception.Flatten().InnerExceptions.Any(x => ReferenceEquals(x, sourceError)))
                    Interlocked.Exchange(ref raised, 1);
            };
            TaskScheduler.UnobservedTaskException += handler;
            try
            {
                var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
                creds.GetCredentials();

                SetNow(50); // Advisory
                creds.ThrowOnRefresh(sourceError);
                creds.GetCredentials(); // triggers a background refresh that fails and must be swallowed

                // Wait for the background refresh to run, fail and finish before checking for leaks.
                Assert.IsTrue(SpinWait.SpinUntil(() => creds.AttemptCount >= 2, WaitTimeout), "background refresh did not run");
                WaitUntilIdle(creds);

                for (var i = 0; i < 3; i++)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }

                Assert.AreEqual(0, Volatile.Read(ref raised), "a failed advisory refresh raised an unobserved task exception");
                Assert.AreEqual(1, creds.GeneratedTokenCount);
            }
            finally
            {
                TaskScheduler.UnobservedTaskException -= handler;
            }
        }

        [TestMethod]
        public void GetCredentialsWithMinimumLifetime_WhileBackedOff_StillCallsProviderAndThrows()
        {
            var creds = ArmBackoffAtMandatory(); // backoff armed at t0+59.5
            SetNow(59.5 + 1.0); // still inside backoff window
            var attemptsBefore = creds.AttemptCount;
            creds.FailNextNRefreshes(1);

            // GetCredentials(TimeSpan) deliberately bypasses backoff and static stability.
            Assert.ThrowsExactly<AmazonClientException>(() => creds.GetCredentials(TimeSpan.FromMinutes(30)));
            Assert.IsTrue(creds.AttemptCount > attemptsBefore, "GetCredentials(TimeSpan) should not respect backoff");
        }

        #endregion

        #region Pipeline Invalidate wiring

        [TestMethod]
        public void CredentialsInvalidation_InvalidatingErrorCode_Invalidates()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            var ec = new Amazon.Runtime.Internal.ExecutionContext(false, null);
            var rc = (RequestContext)ec.RequestContext;
            rc.Identity = creds;
            rc.ResolvedCredentials = initial;
            rc.IsSigned = true;

            var ex = new AmazonServiceException("expired", ErrorType.Sender, "ExpiredToken", "req-1", HttpStatusCode.Forbidden);
            Assert.IsTrue(CredentialsInvalidation.IsInvalidCredentialError(ec, ex), "ExpiredToken is an invalid credential error");
            CredentialsInvalidation.NotifyIfAuthFailure(ec, ex);

            // The credentials are invalidated so the next GetCredentials() (for example, when a retry is
            // re-signed) performs a mandatory refresh.
            SetNow(10); // still 'Valid' by the clock, but Invalidate marked the state expired
            var refreshed = creds.GetCredentials();
            Assert.AreNotEqual(initial, refreshed);
            Assert.AreEqual(2, creds.GeneratedTokenCount);
        }

        [TestMethod]
        public void CredentialsInvalidation_SignatureDoesNotMatch_IsIgnored()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            var ec = new Amazon.Runtime.Internal.ExecutionContext(false, null);
            var rc = (RequestContext)ec.RequestContext;
            rc.Identity = creds;
            rc.ResolvedCredentials = initial;
            rc.IsSigned = true;

            var ex = new AmazonServiceException("bad sig", ErrorType.Sender, "SignatureDoesNotMatch", "req-2", HttpStatusCode.Forbidden);
            CredentialsInvalidation.NotifyIfAuthFailure(ec, ex);

            Assert.IsFalse(CredentialsInvalidation.IsInvalidCredentialError(ec, ex),
                "a non-invalidating error code must not be classified as an invalid credential error");
            // SignatureDoesNotMatch must not invalidate the credentials: the next call is served from the cache.
            SetNow(10);
            var again = creds.GetCredentials();
            Assert.AreEqual(initial, again);
            Assert.AreEqual(1, creds.GeneratedTokenCount);
        }

        [TestMethod] // The invalidating set is exactly {ExpiredToken, ExpiredTokenException}.
        public void InvalidatingErrorCodes_ExactSet()
        {
            CollectionAssert.AreEquivalent(
                new[] { "ExpiredToken", "ExpiredTokenException" },
                CredentialsInvalidation.InvalidatingErrorCodes.ToList());

            // Explicitly-removed codes must be absent. InvalidToken is returned for other tokens (such as Step
            // Functions task tokens), not for expired credentials.
            Assert.IsFalse(CredentialsInvalidation.InvalidatingErrorCodes.Contains("InvalidToken"));
            Assert.IsFalse(CredentialsInvalidation.InvalidatingErrorCodes.Contains("AuthFailure"));
            Assert.IsFalse(CredentialsInvalidation.InvalidatingErrorCodes.Contains("InvalidClientTokenId"));
            Assert.IsFalse(CredentialsInvalidation.InvalidatingErrorCodes.Contains("UnrecognizedClientException"));
            // Compared ordinally: a differently-cased code is not in the set.
            Assert.IsFalse(CredentialsInvalidation.InvalidatingErrorCodes.Contains("expiredtokenexception"));
            Assert.IsFalse(CredentialsInvalidation.InvalidatingErrorCodes.Contains("RequestExpired"));
            Assert.IsFalse(CredentialsInvalidation.InvalidatingErrorCodes.Contains("SignatureDoesNotMatch"));
        }

        [TestMethod]
        public void NonRecoverableErrorCodes_Membership()
        {
            Assert.IsTrue(CredentialRefreshPolicy.NonRecoverableErrorCodes.Contains("AccessDenied"));
            Assert.IsTrue(CredentialRefreshPolicy.NonRecoverableErrorCodes.Contains("IDPRejectedClaim"));
            // SSO GetRoleCredentials rejected the SSO access token.
            Assert.IsTrue(CredentialRefreshPolicy.NonRecoverableErrorCodes.Contains("UnauthorizedException"));
            Assert.IsFalse(CredentialRefreshPolicy.NonRecoverableErrorCodes.Contains("ThrottlingException"));
        }

        // The SSO service's UnauthorizedException is non-recoverable whether it reaches the classifier directly or wrapped
        // in an AmazonClientException, as the SSO client wraps service errors.
        [TestMethod]
        public void Classifier_SsoUnauthorized_NonRecoverable()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var unauthorized = new AmazonServiceException("Session token not found or invalid", ErrorType.Sender,
                "UnauthorizedException", "req", HttpStatusCode.Unauthorized);

            Assert.IsTrue(creds.IsNonRecoverableErrorPublic(unauthorized), "a bare UnauthorizedException must be non-recoverable");
            Assert.IsTrue(creds.IsNonRecoverableErrorPublic(new AmazonClientException("Error calling GetRoleCredentials", unauthorized)),
                "a wrapped UnauthorizedException must be non-recoverable");
        }

        // The classifier set carries the three Login OAuth2 members that require reauthentication and RegionDisabled,
        // but not the bare AccessDeniedException, and never AUTHCODE_EXPIRED.
        [TestMethod]
        public void NonRecoverableErrorCodes_LoginMembersAndRegionDisabled()
        {
            var set = CredentialRefreshPolicy.NonRecoverableErrorCodes;

            // Login: exactly the three members.
            Assert.IsTrue(set.Contains("TOKEN_EXPIRED"));
            Assert.IsTrue(set.Contains("USER_CREDENTIALS_CHANGED"));
            Assert.IsTrue(set.Contains("INSUFFICIENT_PERMISSIONS"));
            // AUTHCODE_EXPIRED is recoverable.
            Assert.IsFalse(set.Contains("AUTHCODE_EXPIRED"));
            // The bare modeled exception name is not non-recoverable on its own.
            Assert.IsFalse(set.Contains("AccessDeniedException"));

            // STS RegionDisabled, keyed by wire code; the modeled exception name is kept too.
            Assert.IsTrue(set.Contains("RegionDisabled"));
            Assert.IsTrue(set.Contains("RegionDisabledException"));

            // STS AccessDenied wire code stays non-recoverable.
            Assert.IsTrue(set.Contains("AccessDenied"));
        }

        // IsNonRecoverableError keys off AmazonServiceException.ErrorCode.
        [TestMethod]
        public void Classifier_LoginOAuthMembers_NonRecoverable()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            foreach (var code in new[] { "TOKEN_EXPIRED", "USER_CREDENTIALS_CHANGED", "INSUFFICIENT_PERMISSIONS" })
            {
                var ex = new AmazonServiceException("denied", ErrorType.Sender, code, "req", HttpStatusCode.Forbidden);
                Assert.IsTrue(creds.IsNonRecoverableErrorPublic(ex), $"{code} must be non-recoverable");
            }
        }

        [TestMethod]
        public void Classifier_AuthCodeExpired_Recoverable()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var ex = new AmazonServiceException("authcode expired", ErrorType.Sender, "AUTHCODE_EXPIRED", "req", HttpStatusCode.Unauthorized);
            Assert.IsFalse(creds.IsNonRecoverableErrorPublic(ex), "AUTHCODE_EXPIRED must stay recoverable");
        }

        [TestMethod]
        public void Classifier_RegionDisabled_NonRecoverable()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var ex = new AmazonServiceException("region disabled", ErrorType.Sender, "RegionDisabled", "req", HttpStatusCode.Forbidden);
            Assert.IsTrue(creds.IsNonRecoverableErrorPublic(ex), "RegionDisabled must be non-recoverable");
        }

        [TestMethod]
        public void Classifier_TransientAndUnknown_Recoverable()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));

            // A transient service error (e.g., throttling / server-side): recoverable, gets backoff + retry.
            var transient = new AmazonServiceException("throttled", ErrorType.Sender, "ThrottlingException", "req", HttpStatusCode.ServiceUnavailable);
            Assert.IsFalse(creds.IsNonRecoverableErrorPublic(transient), "a transient service error must stay recoverable");

            // A plain AccessDeniedException (no member discrimination) is not non-recoverable on its own.
            var bareAccessDenied = new AmazonServiceException("denied", ErrorType.Sender, "AccessDeniedException", "req", HttpStatusCode.Forbidden);
            Assert.IsFalse(creds.IsNonRecoverableErrorPublic(bareAccessDenied), "bare AccessDeniedException must not be non-recoverable");

            // A non-service exception (e.g., a network fault) is recoverable.
            Assert.IsFalse(creds.IsNonRecoverableErrorPublic(new System.Net.WebException("connection reset")));
        }

        #endregion

        #region Concurrency, stale responses and the failure message

        [TestMethod] // Advisory refresh is non-blocking: a second advisory caller returns cached at once.
        public void Advisory_WhileRefreshHoldsLock_OtherCallerReturnsCachedImmediately()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            SetNow(50); // Advisory
            creds.CloseGate();
            try
            {
                // First advisory caller dispatches the background refresh; it acquires the lock and blocks on the gate.
                creds.GetCredentials();
                Assert.IsTrue(SpinWait.SpinUntil(() => creds.AttemptCount >= 2, WaitTimeout), "background refresh did not start");

                // A second advisory caller must return cached without waiting for the held lock. The gate stays closed
                // while this waits, so a caller that waited for the lock could not finish.
                var second = Task.Run(() => creds.GetCredentials());
                Assert.IsTrue(second.Wait(WaitTimeout), "advisory caller blocked while a refresh held the lock");
                Assert.AreEqual(initial, second.Result);
                Assert.AreEqual(1, creds.GeneratedTokenCount); // background refresh still gated
            }
            finally
            {
                creds.OpenGate();
            }

            Assert.IsTrue(SpinWait.SpinUntil(() => creds.GeneratedTokenCount == 2, WaitTimeout));
        }

        [TestMethod] // Advisory and mandatory refreshes are single-flight: only one source call in total.
        public void SingleFlight_AdvisoryInProgress_MandatoryCallerDoesNotDoubleFetch()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            creds.GetCredentials(); // gen1 at t0
            SetNow(50);             // Advisory

            BlockedCaller mandatory;
            creds.CloseGate();
            try
            {
                creds.GetCredentials(); // dispatches the background refresh; it acquires the lock, blocks on the gate
                Assert.IsTrue(SpinWait.SpinUntil(() => creds.AttemptCount >= 2, WaitTimeout), "background refresh did not start");

                // Advance into mandatory; this caller waits for the lock the background refresh holds.
                SetNow(59.5);
                mandatory = BlockedCaller.Start(creds);
            }
            finally
            {
                creds.OpenGate();
            }

            var refreshed = mandatory.Join();
            WaitUntilIdle(creds);

            // The background refresh published fresh credentials; the mandatory caller saw them and did NOT
            // fetch again. Exactly one source call occurred beyond the initial fetch.
            Assert.AreEqual(2, creds.GeneratedTokenCount);
            Assert.AreEqual(2, creds.AttemptCount, "a second concurrent source call occurred");
            Assert.AreSame(creds.CurrentState.Credentials, refreshed, "the mandatory caller must receive the background refresh's credentials");
        }

        [TestMethod] // A source response with Expiration == now is treated as a failure (equality fails).
        public void StaleAtNow_SourceResponse_TreatedAsFailure_ServesCached()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            SetNow(59.5); // Mandatory
            creds.ReturnStaleCredentialsOnce(); // next generation reports Expiration == now
            var served = creds.GetCredentials();

            // Stale-at-now rejected -> recoverable failure -> backoff armed -> static stability serves cached.
            Assert.AreEqual(initial, served);
            var attemptsBefore = creds.AttemptCount;
            creds.GetCredentials();
            Assert.AreEqual(attemptsBefore, creds.AttemptCount, "backoff should suppress a further source call");
        }

        [TestMethod] // The failed-refresh message reports the seconds until the next retry.
        public void RefreshFailureMessage_IncludesSecondsUntilRetry()
        {
            var msg = RefreshingAWSCredentials.FormatRefreshFailureMessage(new AmazonClientException("boom"), 450);
            StringAssert.Contains(msg, "450");
            StringAssert.Contains(msg, "boom");
            StringAssert.Contains(msg, "seconds");
        }

        #endregion

        #region Background refresh dispatch and failure publication

        // An advisory (background) refresh must never run on the GetCredentials() caller's thread.
        // SemaphoreSlim.WaitAsync(TimeSpan.Zero) usually completes synchronously, so calling the refresh inline
        // would continue synchronously into the customer-overridable GenerateNewCredentialsAsync(); if that does
        // synchronous work before returning its Task, the caller blocks. The refresh is dispatched with Task.Run.
        // Here the async source blocks synchronously on a closed gate; GetCredentials() must still return the
        // cached credentials without waiting for the gate to open.
        [TestMethod]
        public void AdvisoryRefresh_SourceBlocksSynchronously_GetCredentialsReturnsCachedImmediately()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials(); // gen1

            creds.MakeAsyncGenerationBlockSynchronously();
            creds.CloseGate(); // the advisory source will now block synchronously until the gate opens
            try
            {
                SetNow(50); // Advisory: serve cached, dispatch a background refresh

                // Run on a worker so a regression (inline blocking) fails after the timeout instead of hanging the
                // test run. GetCredentials returns immediately; the blocked refresh sits on a ThreadPool thread.
                var call = Task.Run(() => creds.GetCredentials());
                Assert.IsTrue(call.Wait(WaitTimeout),
                    "GetCredentials blocked on a synchronously blocking advisory refresh: the refresh ran on the caller's thread");
                Assert.AreEqual(initial, call.Result, "advisory phase must serve the cached credentials");
            }
            finally
            {
                creds.OpenGate(); // let the parked background refresh finish so it does not leak
            }
        }

        // When an advisory refresh fails, it must publish its failure state (refresh backoff or a cached
        // non-recoverable error) BEFORE releasing the lock. Otherwise a mandatory caller waiting for the lock could
        // acquire it in the gap, see no backoff, and perform a redundant source fetch. This test parks a failing
        // advisory refresh inside the gated source (holding the lock), lines a mandatory caller up behind it, then
        // releases the advisory refresh. The mandatory caller must observe the backoff on acquiring the lock and serve
        // the cached credentials via static stability rather than fetching again.
        [TestMethod]
        public void AdvisoryFailure_PublishesBackoffBeforeReleasingLock_MandatoryWaiterDoesNotRefetch()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials(); // gen1, attempt 1
            Assert.AreEqual(1, creds.AttemptCount);

            creds.FailNextNRefreshes(1); // the advisory refresh will fail (recoverable -> applies the backoff)
            BlockedCaller mandatory;
            creds.CloseGate();           // ...and block inside the source, holding the lock
            try
            {
                SetNow(50); // Advisory: dispatches the background refresh, which acquires the lock and parks
                creds.GetCredentials();
                Assert.IsTrue(SpinWait.SpinUntil(() => creds.AttemptCount >= 2, WaitTimeout),
                    "background advisory refresh did not start");

                SetNow(59.5); // Mandatory: this caller waits for the lock behind the advisory refresh
                mandatory = BlockedCaller.Start(creds);
            }
            finally
            {
                creds.OpenGate(); // advisory fails -> applies the backoff while it holds the lock -> releases the lock
            }

            var served = mandatory.Join();

            Assert.AreEqual(2, creds.AttemptCount,
                "the mandatory caller performed its own fetch instead of seeing the backoff that the advisory failure published before releasing the lock");
            Assert.AreEqual(1, creds.GeneratedTokenCount, "no new credentials were generated -- both attempts after gen1 must be the single failed advisory attempt");
            Assert.AreEqual(initial, served, "static stability should serve the cached credentials to the mandatory caller");
        }

        #endregion

        #region Advisory window measured from the reported expiration, and credentials born inside it

        [TestMethod] // Table path: the advisory refresh fires at RawExpiration - advisoryWindow (buffer cancelled).
        public void AdvisoryWindow_TablePath_FiresAtRawExpirationMinusWindow()
        {
            var creds = NewCreds(Lifetime60); // 60m lifetime, no explicit preempt -> table window = 15m
            creds.GetCredentials();
            var s = creds.CurrentState;

            // The advisory refresh must be RawExpiration - 15m, NOT (RawExpiration - 1m buffer) - 15m. The
            // ExpirationBuffer subtraction in ResolveAdvisoryWindow cancels the buffer already applied to
            // Expiration, which moves the default advisory refresh ~1 minute later than earlier versions of the SDK.
            Assert.AreEqual(s.RawExpiration - TimeSpan.FromMinutes(15), s.AdvisoryRefreshAt);
            Assert.IsFalse(s.AdvisoryUnreachable, "a 60m credential is not born inside its advisory window");
        }

        [TestMethod] // An advisory instant EXACTLY at 'now' (equality) must be unreachable.
        public void AdvisoryUnreachable_BornExactlyAtAdvisoryInstant_EqualityCase_SuppressesBackgroundRefresh()
        {
            // now=T, RawExpiration=T+5m, ExpirationBuffer=1m: table(5m)=5m; corrected window=4m;
            // Expiration=T+4m; advisoryRefreshAt = T+4m - 4m = T == now. Strict '<' would miss this.
            var creds = NewCreds(TimeSpan.FromMinutes(5));
            creds.GetCredentials();
            Assert.IsTrue(creds.CurrentState.AdvisoryUnreachable,
                "advisory instant == now must be treated as unreachable (equality, not strict '<')");

            SetNow(3); // Advisory phase (between advisoryRefreshAt=T and Expiration=T+4m)
            var previousState = creds.CurrentState;
            creds.GetCredentials();

            // A background refresh is dispatched before GetCredentials returns, so once the provider is idle any such
            // refresh has already run.
            WaitUntilIdle(creds);
            Assert.AreSame(previousState, creds.CurrentState, "AdvisoryUnreachable must suppress the background refresh");
            Assert.AreEqual(1, creds.AttemptCount, "AdvisoryUnreachable must suppress the background refresh");
            Assert.AreEqual(1, creds.GeneratedTokenCount);
        }

        [TestMethod] // An advisory instant strictly before 'now' is unreachable and clamped.
        public void AdvisoryUnreachable_BornInsideAdvisoryWindow_StrictlyPast_ClampsAndSuppresses()
        {
            // now=T, RawExpiration=T+3m: table(3m)=5m; corrected=4m; Expiration=T+2m; advisoryRefreshAt=T-2m < now.
            var creds = NewCreds(TimeSpan.FromMinutes(3));
            creds.GetCredentials();
            var s = creds.CurrentState;
            Assert.IsTrue(s.AdvisoryUnreachable, "advisory instant strictly before now must be unreachable");
            Assert.AreEqual(_baseTimeUtc, s.AdvisoryRefreshAt, "AdvisoryRefreshAt must be clamped to now, never the past");
        }

        #endregion

        #region Backoff log: source error and non-zero next-attempt delay

        // Backoff is the deterministic 7.5 min (450s) generator wired into TestRefreshingCredentials, so a
        // freshly-armed backoff always reports "...after 450 seconds" -- a positive, non-zero next-attempt
        // delay. LogRefreshBackoffArmed is the only producer of this line with the source error attached, so
        // filtering on both isolates the backoff-arm log from the other lifecycle logs. The minimum-lifetime
        // overloads do not apply the backoff (see CredentialRefreshCompatibilityTests), so they log no arm line.
        private const string BackoffArmLogMarker = "A refresh of these credentials will be attempted again after";

        // Returns the single backoff-arm log emitted for the given source error, asserting exactly one fired. The
        // failure is handled (the cached credentials are returned), so it is logged at Warn.
        private static LogCapture.Entry SingleBackoffArmLog(LogCapture log, Exception source)
        {
            var arms = log.Entries
                .Where(e => ReferenceEquals(e.Exception, source)
                            && e.Level == SdkLogLevel.Warn
                            && e.Message != null
                            && e.Message.Contains(BackoffArmLogMarker))
                .ToList();
            Assert.AreEqual(1, arms.Count,
                "exactly one backoff-arm log must fire for the source error after backoff is armed");
            return arms[0];
        }

        // Asserts the arm log carries the source error's message and the deterministic non-zero (450s) delay.
        private static void AssertArmLog(LogCapture.Entry arm, string sourceMessage)
        {
            StringAssert.Contains(arm.Message, "450"); // non-zero computed next-attempt delay (7.5 min backoff)
            StringAssert.Contains(arm.Message, sourceMessage);
        }

        [TestMethod] // A mandatory refresh (sync) failure arms backoff and logs the source error + delay.
        public void BackoffLog_MandatoryRefreshFailure_LogsSourceErrorAndNextAttemptDelay()
        {
            using (var log = new LogCapture())
            {
                var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15)); // built inside scope -> logger captured
                creds.GetCredentials(); // gen1 at t0
                var boom = new AmazonClientException("arm1-mandatory-sync");

                SetNow(59.5); // Mandatory
                creds.ThrowOnRefresh(boom);
                var served = creds.GetCredentials(); // static stability serves cached; backoff armed + logged
                Assert.IsNotNull(served);

                AssertArmLog(SingleBackoffArmLog(log, boom), "arm1-mandatory-sync");
            }
        }

        [TestMethod] // A mandatory refresh (async) failure arms backoff and logs the source error + delay.
        public async Task BackoffLog_MandatoryRefreshFailureAsync_LogsSourceErrorAndNextAttemptDelay()
        {
            using (var log = new LogCapture())
            {
                var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
                await creds.GetCredentialsAsync(); // gen1
                var boom = new AmazonClientException("arm2-mandatory-async");

                SetNow(59.5); // Mandatory
                creds.ThrowOnRefresh(boom);
                var served = await creds.GetCredentialsAsync(); // static stability serves cached
                Assert.IsNotNull(served);

                AssertArmLog(SingleBackoffArmLog(log, boom), "arm2-mandatory-async");
            }
        }

        [TestMethod] // A failed background (advisory) refresh arms backoff and logs the source error + delay.
        public void BackoffLog_BackgroundRefreshFailure_LogsSourceErrorAndNextAttemptDelay()
        {
            using (var log = new LogCapture())
            {
                var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
                creds.GetCredentials(); // gen1
                var boom = new AmazonClientException("arm3-background");

                SetNow(50); // Advisory: serve cached, dispatch a background refresh
                creds.ThrowOnRefresh(boom);
                creds.GetCredentials(); // dispatches the background refresh, which fails recoverably

                Assert.IsTrue(
                    SpinWait.SpinUntil(() => log.Entries.Any(e => ReferenceEquals(e.Exception, boom)
                                                                  && e.Message != null
                                                                  && e.Message.Contains(BackoffArmLogMarker)), WaitTimeout),
                    "the background backoff arm did not log");

                AssertArmLog(SingleBackoffArmLog(log, boom), "arm3-background");
            }
        }

        [TestMethod] // Control: a NON-recoverable error must NOT arm the backoff, so NO backoff-arm log fires.
        public void BackoffLog_NonRecoverableMandatoryFailure_NoBackoffLogged()
        {
            using (var log = new LogCapture())
            {
                var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
                creds.GetCredentials(); // gen1
                var nonRecoverable = new AmazonNonRecoverableCredentialsException("nonrecoverable-no-backoff");

                SetNow(59.5); // Mandatory
                creds.ThrowOnRefresh(nonRecoverable);
                Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());

                Assert.IsFalse(
                    log.Entries.Any(e => ReferenceEquals(e.Exception, nonRecoverable)
                                         && e.Message != null
                                         && e.Message.Contains(BackoffArmLogMarker)),
                    "a non-recoverable error must not arm or log the refresh backoff");
            }
        }

        #endregion

        #region Providers in scope for the refresh lifecycle (UsesManagedRefreshLifecycle)

        [TestMethod] // The base default is out of scope, so a provider that does not override the scope property (like a
                     // customer subclass) keeps the behavior of earlier versions of the SDK: a failed mandatory refresh
                     // rethrows, with no static-stability serve and no refresh backoff.
        public void BaseDefault_UnoverriddenProvider_MandatoryFailure_Rethrows_NoStaticStability_NoBackoff()
        {
            var creds = new UnscopedCredentials(_clock);
            creds.GetCredentials(); // gen1 succeeds
            SetNow(120);            // past raw expiration -> mandatory/expired

            creds.ThrowOnRefresh = new AmazonClientException("boom");
            // Out of scope: rethrow rather than serve cached (contrast StaticStability_ExpiredCredsFailingProvider_ReturnsExpired).
            Assert.ThrowsExactly<AmazonClientException>(() => creds.GetCredentials());

            var attempts = creds.AttemptCount;
            // No refresh backoff out of scope: the next call re-attempts the provider instead of being rate-limited
            // into serving cached.
            Assert.ThrowsExactly<AmazonClientException>(() => creds.GetCredentials());
            Assert.AreEqual(attempts + 1, creds.AttemptCount,
                "out-of-scope providers arm no refresh backoff, so the next call re-attempts");
        }

        [TestMethod] // An in-scope provider (the fake opts in, as the in-scope built-in providers do) keeps static
                     // stability: it serves cached expired credentials on refresh failure. Proves the property gates it.
        public void InScope_MandatoryFailure_StaticStabilityServesCached()
        {
            var creds = NewCreds(Lifetime60);
            creds.SetUsesManagedRefreshLifecycle(true);
            var gen1 = creds.GetCredentials();
            SetNow(120);
            creds.ThrowOnRefresh(new AmazonClientException("boom"));

            var served = creds.GetCredentials(); // in-scope + static stability -> cached, no throw
            Assert.AreEqual(gen1, served);
        }

        // Out-of-scope providers keep the background (preempt) refresh of earlier versions of the SDK; see
        // CredentialRefreshCompatibilityTests.

        [TestMethod] // Exactly the built-in providers the lifecycle covers opt in: IMDS, container, AssumeRole,
                     // AssumeRoleWithWebIdentity, SSO and Login (Cognito is checked in the CognitoIdentity tests).
                     // ProcessAWSCredentials and FederatedAWSCredentials keep the behavior of earlier versions, and so
                     // does the public URIBasedRefreshingCredentialHelper: it is the base class of the IMDS and container
                     // providers, and a class that an application derives from it is a customer-provided provider.
        public void InScopeProviders_AreExactlyTheBuiltInsTheLifecycleCovers()
        {
            Assert.IsNotNull(ScopeProperty, "RefreshingAWSCredentials.UsesManagedRefreshLifecycle was not found");
            var providerTypes = LoadableTypes(typeof(RefreshingAWSCredentials).Assembly)
                .Where(t => typeof(RefreshingAWSCredentials).IsAssignableFrom(t) && !t.IsAbstract && !t.ContainsGenericParameters)
                .ToList();

            var inScope = providerTypes.Where(IsInScope).Select(t => t.Name).ToList();
            var outOfScope = providerTypes.Where(t => !IsInScope(t)).Select(t => t.Name).ToList();

            CollectionAssert.AreEquivalent(new[]
            {
                "AssumeRoleAWSCredentials",
                "AssumeRoleWithWebIdentityCredentials",
                "DefaultInstanceProfileAWSCredentials",
                "GenericContainerCredentials",
                "InstanceProfileAWSCredentials",
                "LoginAWSCredentials",
                "SSOAWSCredentials",
            }, inScope, "in-scope providers: " + string.Join(", ", inScope));
            CollectionAssert.AreEquivalent(new[]
            {
                "FederatedAWSCredentials",
                "ProcessAWSCredentials",
                "URIBasedRefreshingCredentialHelper",
            }, outOfScope, "out-of-scope providers: " + string.Join(", ", outOfScope));
        }

        private static readonly PropertyInfo ScopeProperty = typeof(RefreshingAWSCredentials).GetProperty(
            "UsesManagedRefreshLifecycle", BindingFlags.Instance | BindingFlags.NonPublic);

        // Every override returns a constant, so an instance created without running its constructor answers correctly,
        // and no credential file, environment variable or IMDS endpoint is touched.
        private static bool IsInScope(Type providerType)
            => (bool)ScopeProperty.GetValue(CreateWithoutConstructor(providerType));

        private static object CreateWithoutConstructor(Type type)
        {
#if NET5_0_OR_GREATER
            return System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(type);
#else
            return System.Runtime.Serialization.FormatterServices.GetUninitializedObject(type);
#endif
        }

        private static IEnumerable<Type> LoadableTypes(Assembly assembly)
        {
            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                return e.Types.Where(t => t != null);
            }
        }

        #endregion

        #region Success publication and the cached error

        [TestMethod] // A successful fetch or refresh clears the cached non-recoverable error even while its (1-5s) cache
                     // duration is still running. The clock does not advance past that duration, so only the success
                     // path can have cleared it.
        public void SuccessfulPublish_ClearsLiveCachedError_WithoutWaitingForTtl()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));

            // No credentials yet + a LIVE cached non-recoverable error: a resolution short-circuits and
            // rethrows, proving the error is live and IS consulted on the resolution path. The clock does not
            // advance for the rest of the test, so the 3s cache duration stays live throughout.
            var boom = new AmazonNonRecoverableCredentialsException("token expired");
            creds.CacheNonRecoverableErrorPublic(boom);
            Assert.IsTrue(creds.HasCachedError, "precondition: a live cached error is seeded");
            Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());

            // A successful refresh funnels through the real production PublishRefreshSuccess. Only the success
            // path itself can clear the error here -- ClearRefreshBackoff zeroes only the backoff clock.
            creds.PublishRefreshSuccessPublic(creds.BuildFreshStateForTest());

            Assert.IsFalse(creds.HasCachedError,
                "a successful publish must clear the live cached error, not leave it to expire");

            // User-facing consequence: the next resolution returns the fresh credentials instead of rethrowing
            // the (now-cleared) stale error.
            var resolved = creds.GetCredentials();
            Assert.AreEqual(creds.AccessKey, resolved.AccessKey,
                "with the error cleared, the next caller gets fresh credentials, not the stale exception");
        }

        [TestMethod] // Valid credentials are returned without consulting a cached non-recoverable error: no refresh runs
                     // while credentials are valid, so an error cached then can only come from outside the lifecycle.
        public void CachedNonRecoverableError_WhileCredentialsValid_CachedCredentialsReturned()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            creds.CacheNonRecoverableErrorPublic(new AmazonNonRecoverableCredentialsException("cached while valid"));
            Assert.IsTrue(creds.HasCachedError, "precondition: a live cached error is seeded");

            SetNow(10); // Valid
            Assert.AreSame(initial, creds.GetCredentials());
            Assert.AreEqual(1, creds.AttemptCount);
        }

        #endregion

        #region A non-recoverable error from a background refresh reaches the next caller

        // A background (advisory) refresh that fails non-recoverably caches the error; the NEXT on-demand
        // GetCredentials() in the advisory window must surface that cached non-recoverable exception and must NOT
        // contact the source again (the cached error is raised before any background dispatch). Waits on the
        // HasCachedError observable, not on wall time.
        [TestMethod]
        public void AdvisoryGate_Sync_BackgroundNonRecoverableError_SurfacesOnNextCall_NoSourceContact()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            creds.GetCredentials(); // gen1 at t0

            SetNow(50); // Advisory (AdvisoryRefreshAt=t0+44, Expiration=t0+59)
            var bg = new AmazonNonRecoverableCredentialsException("advisory background non-recoverable");
            creds.ThrowOnRefresh(bg);

            creds.GetCredentials(); // serves cached, dispatches the background refresh (which fails non-recoverably)
            Assert.IsTrue(SpinWait.SpinUntil(() => creds.HasCachedError, WaitTimeout),
                "the failed background refresh must cache the non-recoverable error");
            WaitUntilIdle(creds);

            var attemptsAfterBackground = creds.AttemptCount; // 1 initial + 1 background attempt
            var thrown = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());

            Assert.AreSame(bg, thrown, "the exact cached background error must surface on the next on-demand call");
            Assert.AreEqual(attemptsAfterBackground, creds.AttemptCount,
                "surfacing the cached error must not contact the source again (the cached error is raised first)");
        }

        // The async mirror of the test above: GetCredentialsAsync() raises the cached error on its advisory path too.
        [TestMethod]
        public async Task AdvisoryGate_Async_BackgroundNonRecoverableError_SurfacesOnNextCall_NoSourceContact()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            await creds.GetCredentialsAsync(); // gen1

            SetNow(50); // Advisory
            var bg = new AmazonNonRecoverableCredentialsException("advisory background non-recoverable (async)");
            creds.ThrowOnRefresh(bg);

            await creds.GetCredentialsAsync(); // serves cached, dispatches the failing background refresh
            Assert.IsTrue(SpinWait.SpinUntil(() => creds.HasCachedError, WaitTimeout),
                "the failed background refresh must cache the non-recoverable error");
            WaitUntilIdle(creds);

            var attemptsAfterBackground = creds.AttemptCount;
            var thrown = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(
                async () => await creds.GetCredentialsAsync());

            Assert.AreSame(bg, thrown, "the exact cached background error must surface on the next async on-demand call");
            Assert.AreEqual(attemptsAfterBackground, creds.AttemptCount,
                "surfacing the cached error must not contact the source again");
        }

        // Static stability preserved. A RECOVERABLE background failure arms the refresh backoff (no cached error).
        // The next advisory call must NOT throw -- only NON-recoverable cached errors are raised -- and must serve the
        // cached credentials without a further source contact, because the backoff suppresses the background dispatch.
        [TestMethod]
        public void AdvisoryGate_RecoverableBackoffState_ServesCached_DoesNotThrow_NoSourceContact()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials(); // gen1 at t0

            SetNow(50); // Advisory
            creds.FailNextNRefreshes(1); // the background refresh fails RECOVERABLY -> arms backoff, no cached error

            creds.GetCredentials(); // serves cached, dispatches the background refresh
            Assert.IsTrue(SpinWait.SpinUntil(() => creds.AttemptCount >= 2, WaitTimeout),
                "the background refresh must run and fail recoverably");
            WaitUntilIdle(creds);
            Assert.IsFalse(creds.HasCachedError, "a recoverable failure must not cache a non-recoverable error");

            var attemptsAfterBackground = creds.AttemptCount;
            var served = creds.GetCredentials(); // advisory + armed backoff -> serve cached, no throw, no dispatch

            Assert.AreEqual(initial, served, "a recoverable/backoff state in the advisory window still serves cached");
            Assert.AreEqual(attemptsAfterBackground, creds.AttemptCount,
                "the armed backoff must suppress a further source contact");
        }

        // The lost-write race in the expiry clear. A caller observes an EXPIRED cached error E1 and, before clearing
        // it, a background refresh caches a FRESH non-recoverable error E2. The compare-and-swap clear nulls only the
        // exact E1 reference, so E2 survives and surfaces on the next call. Fully deterministic -- the interleaving is
        // injected at the exact race point via the production hook seam, not raced by thread timing. An unconditional
        // `_cachedError = null` would erase E2, and the next call would return without surfacing it.
        [TestMethod]
        public void ExpiryClear_RacesFreshCache_CompareAndSwapPreservesReplacement_SurfacesOnNextCall()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));

            // E1: cached at t0 with the deterministic 3s cache duration.
            var e1 = new AmazonNonRecoverableCredentialsException("E1 stale");
            creds.CacheNonRecoverableErrorPublic(e1);
            Assert.IsTrue(creds.HasCachedError, "precondition: E1 is cached");

            SetNow(6.0 / 60.0); // +6s: past E1's 3s cache duration, so the check takes the expiry-clear branch

            // In the exact window between observing expired E1 and clearing it, a background refresh caches a
            // fresh non-recoverable E2. E2's own 3s cache duration starts at now (+6s), so it is live for the assertions.
            var e2 = new AmazonNonRecoverableCredentialsException("E2 fresh");
            creds.CachedErrorExpiryClearHook = () => creds.CacheNonRecoverableErrorPublic(e2);

            // Drive the real check: E1 is expired so nothing throws here; the CAS runs against the stale E1 and
            // must fail because the hook replaced it with E2.
            creds.ThrowIfNonRecoverableErrorCachedPublic();

            Assert.IsTrue(creds.HasCachedError,
                "the fresh replacement (E2) must survive the compare-and-swap clear of the stale E1");

            var thrown = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials());
            Assert.AreSame(e2, thrown, "the surviving replacement E2 -- not the erased stale E1 -- must surface next");
        }

        #endregion

        #region Proactive (scheduled) refresh

        // StartProactiveRefresh starts a background refresh even while the cached credentials are Valid, for a provider
        // that refreshes on a schedule of its own (the default IMDS provider). It marks the background refresh as in
        // flight before it returns, so once the provider is idle any refresh it started has finished. Every
        // generation of TestRefreshingCredentials has the same access key and a new session token (token_1, token_2,
        // ...), so the token shows which generation is cached.

        [TestMethod]
        public void StartProactiveRefresh_ValidCredentials_ContactsSourceOnceAndReplacesThem()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            SetNow(10); // Valid: an on-demand call would not refresh
            var previousState = creds.CurrentState;
            creds.StartProactiveRefresh();
            WaitUntilIdle(creds);

            Assert.AreEqual(2, creds.AttemptCount, "the proactive refresh must contact the source exactly once");
            Assert.AreNotSame(previousState, creds.CurrentState, "the refreshed credentials must replace the cached ones");
            var refreshed = creds.GetCredentials();
            Assert.AreEqual("token_2", refreshed.Token);
            Assert.AreNotEqual(initial, refreshed);
            Assert.AreEqual(2, creds.AttemptCount, "the refreshed credentials are valid, so the call does not refresh again");
        }

        [TestMethod]
        public void StartProactiveRefresh_NothingCached_NoOp()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));

            creds.StartProactiveRefresh();
            WaitUntilIdle(creds);

            Assert.AreEqual(0, creds.AttemptCount, "with nothing cached the source must not be contacted");
            Assert.IsNull(creds.CurrentState);
        }

        [TestMethod]
        public void StartProactiveRefresh_DuringRefreshBackoff_NoOp()
        {
            var creds = ArmBackoffAtMandatory(); // backoff armed at t0+59.5, until t0+67
            var stateBefore = creds.CurrentState;
            SetNow(59.5 + 1.0);

            creds.StartProactiveRefresh();
            WaitUntilIdle(creds);

            Assert.AreEqual(2, creds.AttemptCount, "the refresh backoff must suppress the proactive refresh");
            Assert.AreSame(stateBefore, creds.CurrentState);
        }

        [TestMethod]
        public void StartProactiveRefresh_NonRecoverableErrorCached_NoOp()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            creds.GetCredentials();
            var stateBefore = creds.CurrentState;
            creds.CacheNonRecoverableErrorPublic(new AmazonNonRecoverableCredentialsException("cached"));
            Assert.IsTrue(creds.HasCachedError, "precondition: a live cached error is seeded");

            creds.StartProactiveRefresh(); // the clock does not move, so the 3s cache duration is still running
            WaitUntilIdle(creds);

            Assert.AreEqual(1, creds.AttemptCount, "a cached non-recoverable error must suppress the proactive refresh");
            Assert.AreSame(stateBefore, creds.CurrentState);
        }

        [TestMethod]
        public void StartProactiveRefresh_RecoverableFailure_KeepsCachedCredentialsAndArmsBackoff()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var initial = creds.GetCredentials();

            SetNow(10);
            creds.FailNextNRefreshes(1);
            creds.StartProactiveRefresh();
            WaitUntilIdle(creds);
            Assert.AreEqual(2, creds.AttemptCount, "the proactive refresh must have run and failed");
            Assert.IsFalse(creds.HasCachedError, "a recoverable failure must not cache an error");
            Assert.AreEqual(initial, creds.GetCredentials(), "the cached credentials must be kept");

            SetNow(10 + 7.0); // inside the backoff (7.5 min) the failure armed
            creds.StartProactiveRefresh();
            WaitUntilIdle(creds);
            Assert.AreEqual(2, creds.AttemptCount, "the failure must arm the refresh backoff");

            SetNow(18); // the backoff has elapsed (10 + 7.5)
            creds.StartProactiveRefresh();
            WaitUntilIdle(creds);
            Assert.AreEqual(3, creds.AttemptCount);
            Assert.AreEqual("token_2", creds.GetCredentials().Token, "a successful proactive refresh replaces the credentials");
        }

        // A non-recoverable failure of a proactive refresh arms no backoff and is surfaced by the next on-demand refresh,
        // where a caller is available (the SEP's Proactive Refresh rules). While the cached credentials are still Valid
        // no on-demand refresh runs, so callers keep getting them; in the advisory window the call refreshes while it
        // waits and raises the error if it recurs.
        [TestMethod]
        public void StartProactiveRefresh_NonRecoverableFailure_NoBackoff_SurfacedByNextOnDemandRefresh()
        {
            var creds = NewCreds(Lifetime60, TimeSpan.FromMinutes(15));
            var cached = creds.GetCredentials();

            SetNow(10); // Valid
            var error = new AmazonNonRecoverableCredentialsException("proactive refresh non-recoverable");
            creds.ThrowOnRefresh(error);
            creds.StartProactiveRefresh();
            WaitUntilIdle(creds);
            Assert.AreEqual(2, creds.AttemptCount, "the proactive refresh must have run and failed");
            Assert.IsTrue(creds.HasCachedError, "the non-recoverable error must be cached for the next on-demand refresh");

            Assert.AreSame(cached, creds.GetCredentials(), "Valid credentials need no on-demand refresh, so they are returned");
            Assert.AreEqual(2, creds.AttemptCount);

            // No refresh backoff was armed: once the error's 3s cache duration has passed, the next proactive refresh
            // contacts the source, which a backoff (at least 60 s) would have suppressed.
            _clock.CorrectedUtcNow += TimeSpan.FromSeconds(5);
            creds.StartProactiveRefresh();
            WaitUntilIdle(creds);
            Assert.AreEqual(3, creds.AttemptCount, "a non-recoverable failure must not arm the refresh backoff");

            // In the advisory window the call refreshes while it waits, because the last refresh failed
            // non-recoverably, and raises the error, which still occurs.
            SetNow(46);
            Assert.AreSame(error, Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => creds.GetCredentials()),
                "the next on-demand refresh must raise the non-recoverable error");
            Assert.AreEqual(4, creds.AttemptCount);

            creds.ClearThrowOnRefresh();
            SetNow(47);
            Assert.AreEqual("token_2", creds.GetCredentials().Token, "the source recovers and the next call refreshes");
        }

        #endregion

        #region Helpers

        // Waits until no refresh holds the lock and no background refresh is pending.
        private static void WaitUntilIdle(RefreshingAWSCredentials creds)
        {
            Assert.IsTrue(SpinWait.SpinUntil(() => RefreshingCredentialsTestProbes.IsIdle(creds), WaitTimeout),
                "the provider did not finish its refresh");
        }

        /// <summary>
        /// Calls GetCredentials() on its own thread. <see cref="Start"/> returns once that thread is waiting for the
        /// refresh lock, so a test can release the refresh that holds the lock knowing the caller is queued behind it.
        /// </summary>
        private sealed class BlockedCaller
        {
            private readonly Thread _thread;
            private ImmutableCredentials _result;
            private Exception _error;

            private BlockedCaller(RefreshingAWSCredentials creds)
            {
                _thread = new Thread(() =>
                {
                    try { _result = creds.GetCredentials(); }
                    catch (Exception e) { _error = e; }
                }) { IsBackground = true };
            }

            public static BlockedCaller Start(RefreshingAWSCredentials creds)
            {
                var caller = new BlockedCaller(creds);
                caller._thread.Start();
                Assert.IsTrue(SpinWait.SpinUntil(() => RefreshingCredentialsTestProbes.AreWaitingForRefreshLock(creds, caller._thread), WaitTimeout),
                    "the caller did not wait for the refresh lock");
                return caller;
            }

            public ImmutableCredentials Join()
            {
                Assert.IsTrue(_thread.Join(WaitTimeout), "the caller did not finish");
                if (_error != null)
                    throw new AssertFailedException("the caller failed: " + _error, _error);
                return _result;
            }
        }

        #endregion

        #region Test doubles

        /// <summary>
        /// Captures every message the SDK logger emits by registering a temporary
        /// <see cref="IAdaptorLoggerFactory"/> through the internal Logger.RegisterAdaptorLoggerFactory (the method
        /// that the public AdaptorLoggerFactoryRegistry forwards to). Registering clears the logger cache, so the
        /// <see cref="RefreshingAWSCredentials"/> under test MUST be constructed INSIDE the using-scope for its
        /// cached logger to include this capture. Thread-safe: the background (advisory) refresh logs from a ThreadPool
        /// thread.
        /// </summary>
        private sealed class LogCapture : IDisposable
        {
            public sealed class Entry
            {
                public SdkLogLevel Level { get; set; }
                public string Message { get; set; }
                public Exception Exception { get; set; }
            }

            private readonly string _factoryName;
            private readonly List<Entry> _entries = new List<Entry>();
            private readonly object _sync = new object();

            public LogCapture()
            {
                _factoryName = "credrefresh-test-capture-" + Guid.NewGuid().ToString("N");
                Logger.RegisterAdaptorLoggerFactory(new Factory(_factoryName, this));
            }

            // A snapshot copy, safe to enumerate while the background refresh may still be appending.
            public IReadOnlyList<Entry> Entries
            {
                get { lock (_sync) { return _entries.ToList(); } }
            }

            private void Add(SdkLogLevel level, string message, Exception ex)
            {
                lock (_sync) { _entries.Add(new Entry { Level = level, Message = message, Exception = ex }); }
            }

            public void Dispose()
            {
                Logger.DeregisterAdaptorLoggerFactory(_factoryName);
                Logger.ClearLoggerCache();
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
                // Records the formatted message: log lines that include an exception message pass it as an argument.
                public void Log(SdkLogLevel level, string message, Exception ex, params object[] parameters)
                    => _owner.Add(level, Format(message, parameters), ex);

                private static string Format(string message, object[] parameters)
                {
                    if (message == null || parameters == null || parameters.Length == 0)
                        return message;
                    try { return string.Format(System.Globalization.CultureInfo.InvariantCulture, message, parameters); }
                    catch (FormatException) { return message; }
                }
            }
        }

        private sealed class MockTimeProvider : ITimeProvider
        {
            public DateTime CorrectedUtcNow { get; set; }
        }

        /// <summary>
        /// A minimal <see cref="RefreshingAWSCredentials"/> that does NOT override
        /// <c>UsesManagedRefreshLifecycle</c>, so it inherits the base default (out of scope). Used to
        /// prove that a customer-authored provider keeps the behavior of earlier versions of the SDK by default.
        /// </summary>
        private sealed class UnscopedCredentials : RefreshingAWSCredentials
        {
            private int _attempts;
            public Exception ThrowOnRefresh;
            public int AttemptCount => _attempts;

            public UnscopedCredentials(ITimeProvider timeProvider) : base(timeProvider) { }

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                Interlocked.Increment(ref _attempts);
                if (ThrowOnRefresh != null)
                    throw ThrowOnRefresh;
                return new CredentialsRefreshState(
                    new ImmutableCredentials("AKIA_UNSCOPED", "secret", "token"),
                    _timeProvider.CorrectedUtcNow + TimeSpan.FromMinutes(60),
                    _timeProvider);
            }
        }

        /// <summary>
        /// A <see cref="RefreshingAWSCredentials"/> with deterministic jitter (unless <c>pinDurations</c> is false),
        /// injectable failures, and a gate that holds source calls. Every generation uses the same access key.
        /// </summary>
        private sealed class TestRefreshingCredentials : RefreshingAWSCredentials
        {
            private readonly TimeSpan _lifetime;
            private int _tokenCounter;
            private int _attemptCounter;
            private int _failuresRemaining;
            private Exception _throwOnRefresh;
            private bool _returnStaleOnce;
            private int _blockAsyncSynchronously;
            private bool _usesManagedRefreshLifecycle = true;
            private readonly ManualResetEventSlim _gate = new ManualResetEventSlim(initialState: true);
            private const string AccessKeyId = "AKIA_KEY_1";

            public TestRefreshingCredentials(TimeSpan lifetime, ITimeProvider timeProvider, bool pinDurations = true) : base(timeProvider)
            {
                _lifetime = lifetime;
                if (pinDurations)
                {
                    RefreshBackoffGenerator = () => Backoff;                         // deterministic (inside 60-600s)
                    NonRecoverableErrorCacheGenerator = () => TimeSpan.FromSeconds(3); // deterministic (inside 1-5s)
                }
            }

            public int GeneratedTokenCount => _tokenCounter;
            public int AttemptCount => Volatile.Read(ref _attemptCounter);
            public CredentialsRefreshState CurrentState => base.currentState;

            public void FailNextNRefreshes(int n) => Interlocked.Exchange(ref _failuresRemaining, n);
            public void ThrowOnRefresh(Exception e) => _throwOnRefresh = e;
            public void ClearThrowOnRefresh() => _throwOnRefresh = null;
            // Makes the next successful generation report Expiration == now (stale-at-now), which must be treated as a
            // failure.
            public void ReturnStaleCredentialsOnce() => _returnStaleOnce = true;
            public void OpenGate() => _gate.Set();
            public void CloseGate() => _gate.Reset();
            // When set, GenerateNewCredentialsAsync blocks synchronously on the gate BEFORE returning its Task --
            // simulating a customer override that does synchronous work up front. If the advisory path called it
            // inline, the caller's thread would block.
            public void MakeAsyncGenerationBlockSynchronously() => Interlocked.Exchange(ref _blockAsyncSynchronously, 1);

            // By default this fake stands in for an in-scope built-in provider, so these tests exercise the refresh
            // lifecycle. Setting false makes it out of scope (like ProcessAWSCredentials or a customer subclass).
            public void SetUsesManagedRefreshLifecycle(bool value) => _usesManagedRefreshLifecycle = value;
            protected override bool UsesManagedRefreshLifecycle => _usesManagedRefreshLifecycle;

            public string AccessKey => AccessKeyId;
            // Cached-error / success-funnel seams: all delegate to the real production methods.
            public bool HasCachedError => HasCachedErrorForTest;
            public void CacheNonRecoverableErrorPublic(Exception e) => CacheNonRecoverableErrorForTest(e);
            // Drives the real expiry-clear/rethrow check directly, and injects a fresh replacement error in the exact
            // window between observing an expired entry and clearing it.
            public void ThrowIfNonRecoverableErrorCachedPublic() => ThrowIfNonRecoverableErrorCachedForTest();
            public Action CachedErrorExpiryClearHook { set => _cachedErrorExpiryClearHookForTest = value; }
            // Exposes the non-recoverable classifier for direct assertion.
            public bool IsNonRecoverableErrorPublic(Exception e) => IsNonRecoverableError(e);
            public void PublishRefreshSuccessPublic(CredentialsRefreshState s) => PublishRefreshSuccessForTest(s);
            public CredentialsRefreshState BuildFreshStateForTest()
            {
                var n = Interlocked.Increment(ref _tokenCounter);
                var credentials = new ImmutableCredentials(AccessKeyId, "secret_access_key", "token_" + n);
                return new CredentialsRefreshState(credentials, _timeProvider.CorrectedUtcNow + _lifetime, _timeProvider);
            }

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                Interlocked.Increment(ref _attemptCounter);
                WaitForGate();

                if (_throwOnRefresh != null)
                    throw _throwOnRefresh;

                if (Interlocked.Decrement(ref _failuresRemaining) >= 0)
                    throw new AmazonClientException("Simulated transient refresh failure");

                var n = Interlocked.Increment(ref _tokenCounter);
                var credentials = new ImmutableCredentials(AccessKeyId, "secret_access_key", "token_" + n);
                DateTime expiration;
                if (_returnStaleOnce)
                {
                    _returnStaleOnce = false;
                    expiration = _timeProvider.CorrectedUtcNow; // Expiration == now -> stale
                }
                else
                {
                    expiration = _timeProvider.CorrectedUtcNow + _lifetime;
                }
                return new CredentialsRefreshState(credentials, expiration, _timeProvider);
            }

            protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
            {
                if (Volatile.Read(ref _blockAsyncSynchronously) == 1)
                    WaitForGate(); // block synchronously, before returning the Task
                return Task.Run(GenerateNewCredentials);
            }

            // Bounded, so a failed test does not leave a thread parked on the gate for the rest of the run.
            private void WaitForGate()
            {
                if (!_gate.Wait(GateTimeout))
                    throw new TimeoutException("The test did not open the gate.");
            }
        }

        #endregion
    }
}
