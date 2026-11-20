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
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Logging;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Log messages of the <see cref="RefreshingAWSCredentials"/> refresh lifecycle:
    /// <list type="bullet">
    /// <item>A background refresh that a throwing log adaptor keeps from starting does not keep later background
    /// refreshes from starting.</item>
    /// <item>An already-expired first IMDS response does not start the refresh backoff; the refresh on the next call
    /// does when IMDS still returns expired credentials, and the cached credentials served during that backoff are
    /// logged once, at Warn.</item>
    /// <item>A background refresh that cannot start is logged at the level of a failed background refresh of the same
    /// provider: Warn for providers that use the refresh lifecycle, Error (as in earlier versions) for other providers.</item>
    /// </list>
    /// Time comes from a fake clock and no test sleeps.
    /// </summary>
    [TestClass]
    [DoNotParallelize]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class CredentialRefreshLogMessageTests
    {
        private static readonly DateTime T0 = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static readonly TimeSpan Lifetime = TimeSpan.FromMinutes(60);
        private static readonly TimeSpan Backoff = TimeSpan.FromMinutes(7.5);
        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(30);

        private const string BackoffServeText = "until the refresh backoff ends";
        private const string PreemptWindowText = "Determined refreshing credentials are in window for preempt expiration.";
        private const string BackgroundRefreshFailedText = "Exception occurred performing background credentials refresh.";

        private static DateTime At(double minutes) => T0 + TimeSpan.FromMinutes(minutes);

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task ExpiredFirstImdsResponse_NoBackoffUntilNextRefreshFails_BackoffServeMessageLoggedOnce(bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var clock = new TestClock(T0);
                var imds = new StubImds(clock) { ReturnExpired = true };
                var provider = NewImdsProvider(imds, clock);
                var cached = await Get(provider, useAsync);

                clock.Now = At(1); // no backoff after the expired first response: this call refreshes them
                Assert.AreSame(cached, await Get(provider, useAsync), "IMDS still returns expired credentials");
                Assert.AreEqual(2, imds.FetchCount, "the next call contacts IMDS again");
                Assert.IsFalse(log.Entries.Any(e => e.Message.Contains(BackoffServeText)), "nothing was served from a backoff yet");

                clock.Now = At(2); // inside the refresh backoff started by that failed refresh
                Assert.AreSame(cached, await Get(provider, useAsync));
                clock.Now = At(3);
                Assert.AreSame(cached, await Get(provider, useAsync));
                Assert.AreEqual(2, imds.FetchCount, "IMDS is not contacted while the refresh backoff lasts");

                var entry = log.Entries.Single(e => e.Message.Contains(BackoffServeText));
                Assert.AreEqual(SdkLogLevel.Warn, entry.Level);
                Assert.IsFalse(entry.Message.Contains("refresh failed"), "the message describes the backoff, not a failure: " + entry.Message);
            }
        }

        [TestMethod]
        [DataRow(true, false)]
        [DataRow(true, true)]
        [DataRow(false, false)]
        [DataRow(false, true)]
        public async Task BackgroundRefreshCannotStart_LoggedAtTheLevelOfAFailedBackgroundRefresh(bool usesLifecycle, bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var clock = new TestClock(T0);
                var creds = new TestCredentials(clock, usesLifecycle) { PreemptExpiryTime = TimeSpan.FromMinutes(15) };
                var gen1 = await Get(creds, useAsync);

                // The background refresh cannot take the refresh lock of a disposed provider. That failure is not a
                // credential source failure and reaches the last-resort handler of the background refresh.
                creds.Dispose();

                clock.Now = At(50); // inside the 15-minute background refresh window, before Expiration
                Assert.AreSame(gen1, await Get(creds, useAsync));
                Assert.IsTrue(SpinWait.SpinUntil(
                        () => IsBackgroundRefreshFinished(creds) && log.Entries.Any(e => e.Message == BackgroundRefreshFailedText),
                        WaitTimeout),
                    "the background refresh did not finish");

                var entry = log.Entries.Single(e => e.Message == BackgroundRefreshFailedText);
                Assert.IsInstanceOfType<ObjectDisposedException>(entry.Exception);
                Assert.AreEqual(usesLifecycle ? SdkLogLevel.Warn : SdkLogLevel.Error, entry.Level);
                Assert.AreEqual(1, creds.SourceCalls, "the credential source is not contacted");
            }
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task BackgroundRefresh_LogAdaptorThrowsBeforeItStarts_LaterCallStartsIt(bool useAsync)
        {
            var failure = new InvalidOperationException("The log adaptor failed.");
            using (var throwing = new ThrowingLogAdaptor(PreemptWindowText, failure))
            {
                var clock = new TestClock(T0);
                var creds = new TestCredentials(clock, usesLifecycle: true);
                var gen1 = await Get(creds, useAsync);

                // Inside the 15-minute background refresh window. The message logged before the background refresh is
                // started throws, so the call fails, as a throwing log adaptor fails any call that logs.
                clock.Now = At(50);
                if (useAsync)
                    Assert.AreSame(failure, await Assert.ThrowsExactlyAsync<InvalidOperationException>(() => creds.GetCredentialsAsync()));
                else
                    Assert.AreSame(failure, Assert.ThrowsExactly<InvalidOperationException>(() => creds.GetCredentials()));
                Assert.IsTrue(IsBackgroundRefreshFinished(creds), "the background refresh that did not start must not stay in flight");
                Assert.AreEqual(1, creds.SourceCalls);

                // With the log adaptor working again, the next call inside the window starts the background refresh.
                throwing.Enabled = false;
                Assert.AreSame(gen1, await Get(creds, useAsync));
                Assert.IsTrue(SpinWait.SpinUntil(() => creds.SourceCalls == 2 && IsBackgroundRefreshFinished(creds), WaitTimeout),
                    "the background refresh did not run");
                Assert.AreNotSame(gen1, await Get(creds, useAsync));
            }
        }

        #region Helpers

        private static Task<ImmutableCredentials> Get(RefreshingAWSCredentials creds, bool useAsync)
            => useAsync ? creds.GetCredentialsAsync() : Task.FromResult(creds.GetCredentials());

        private static DefaultInstanceProfileAWSCredentials NewImdsProvider(StubImds imds, ITimeProvider clock)
        {
            var provider = DefaultInstanceProfileAWSCredentials.CreateTestDefaultInstanceProfileAWSCredentials(imds, clock);
            provider.RefreshBackoffGenerator = () => Backoff;
            return provider;
        }

        private static bool IsBackgroundRefreshFinished(RefreshingAWSCredentials creds)
            => !RefreshingCredentialsTestProbes.IsBackgroundRefreshInFlight(creds);

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

            public DateTime CorrectedUtcNow => Now;
        }

        /// <summary>
        /// A <see cref="RefreshingAWSCredentials"/> that opts in to the refresh lifecycle or not, as the test chooses.
        /// Each generation has its own access key and is valid for 60 minutes from the fetch.
        /// </summary>
        private sealed class TestCredentials : RefreshingAWSCredentials
        {
            private readonly bool _usesLifecycle;
            private int _sourceCalls;

            public TestCredentials(ITimeProvider clock, bool usesLifecycle) : base(clock)
            {
                _usesLifecycle = usesLifecycle;
                RefreshBackoffGenerator = () => Backoff;
            }

            public int SourceCalls => Volatile.Read(ref _sourceCalls);

            protected override bool UsesManagedRefreshLifecycle => _usesLifecycle;

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                var n = Interlocked.Increment(ref _sourceCalls);
                return new CredentialsRefreshState(
                    new ImmutableCredentials("AKIA_LOG_" + n, "secret_" + n, "token_" + n),
                    _timeProvider.CorrectedUtcNow + Lifetime, _timeProvider);
            }
        }

        /// <summary>
        /// IMDS access stub. Each fetch returns a distinct access key (AK1, AK2, ...) that is either already expired or
        /// valid for 60 minutes, measured against the test clock.
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
            public int FetchCount => Volatile.Read(ref _fetchCount);

            public RefreshingAWSCredentials.CredentialsRefreshState FetchCredentials()
            {
                var n = Interlocked.Increment(ref _fetchCount);
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
        /// Registers a temporary <see cref="IAdaptorLoggerFactory"/> whose loggers throw <c>failure</c> for messages that
        /// start with <c>messagePrefix</c> while <see cref="Enabled"/> is true. Registering clears the logger cache, so
        /// credentials under test must be constructed inside the using scope.
        /// </summary>
        private sealed class ThrowingLogAdaptor : IDisposable
        {
            private readonly string _factoryName = "credential-log-message-throwing-" + Guid.NewGuid().ToString("N");
            private readonly string _messagePrefix;
            private readonly Exception _failure;
            private int _enabled = 1;

            public ThrowingLogAdaptor(string messagePrefix, Exception failure)
            {
                _messagePrefix = messagePrefix;
                _failure = failure;
                Logger.RegisterAdaptorLoggerFactory(new Factory(_factoryName, this));
            }

            /// <summary>
            /// Whether the loggers throw. A logger that was already created keeps its adaptors after the factory is
            /// deregistered, so a test stops the failures with this rather than by disposing.
            /// </summary>
            public bool Enabled
            {
                get => Volatile.Read(ref _enabled) != 0;
                set => Volatile.Write(ref _enabled, value ? 1 : 0);
            }

            public void Dispose()
            {
                Enabled = false;
                Logger.DeregisterAdaptorLoggerFactory(_factoryName);
                Logger.ClearLoggerCache();
            }

            private void Log(string message)
            {
                if (Enabled && message != null && message.StartsWith(_messagePrefix, StringComparison.Ordinal))
                    throw _failure;
            }

            private sealed class Factory : IAdaptorLoggerFactory
            {
                private readonly ThrowingLogAdaptor _owner;
                public Factory(string name, ThrowingLogAdaptor owner) { Name = name; _owner = owner; }
                public string Name { get; }
                public IAdaptorLogger CreateAdaptorLogger(Type type) => new Adaptor(_owner);
            }

            private sealed class Adaptor : IAdaptorLogger
            {
                private readonly ThrowingLogAdaptor _owner;
                public Adaptor(ThrowingLogAdaptor owner) { _owner = owner; }
                public bool IsEnabled(SdkLogLevel level) => true;
                public void Log(SdkLogLevel level, string message, Exception ex, params object[] parameters) => _owner.Log(message);
            }
        }

        /// <summary>
        /// Captures every message the SDK logger emits by registering a temporary <see cref="IAdaptorLoggerFactory"/>.
        /// Registering clears the logger cache, so credentials under test must be constructed inside the using scope.
        /// The message is formatted with <see cref="string.Format(IFormatProvider, string, object[])"/>, as the
        /// console logger does.
        /// </summary>
        private sealed class LogCapture : IDisposable
        {
            public sealed class Entry
            {
                public SdkLogLevel Level { get; set; }
                public string Message { get; set; }
                public Exception Exception { get; set; }
            }

            private readonly string _factoryName = "credential-log-message-capture-" + Guid.NewGuid().ToString("N");
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
