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

using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal;
using System;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;

namespace Amazon.Runtime
{
    /// <summary>
    /// Abstract class for automatically refreshing AWS credentials
    /// </summary>
    public abstract class RefreshingAWSCredentials : AWSCredentials, IDisposable
    {
        private readonly Logger _logger = Logger.GetLogger(typeof(RefreshingAWSCredentials));
        protected readonly ITimeProvider _timeProvider;

        protected RefreshingAWSCredentials() : this(DefaultTimeProvider.Instance) { }

        protected RefreshingAWSCredentials(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider ?? DefaultTimeProvider.Instance;
            RefreshBackoffGenerator = () => CredentialRefreshPolicy.NextRefreshBackoff(RemainingLifetime());
        }

        /// <inheritdoc/>
        public override DateTime? Expiration
        {
            get
            {
                // Read the field once: ClearCredentials can set it to null at any time.
                var state = currentState;
                if (state == null)
                {
                    return null;
                }
                return state.ExpirationUtc;
            }
        }

        #region Refresh data

        /// <summary>
        /// Refresh state container consisting of credentials
        /// and the date of the their expiration
        /// </summary>
        public class CredentialsRefreshState
        {
            private readonly ITimeProvider _timeProvider;
            private DateTime _expiration;
            private DateTime _expirationUtc;

            public ImmutableCredentials Credentials { get; set; }

            public DateTime Expiration
            {
                get { return _expiration; }
                set
                {
                    _expiration = value;
                    _expirationUtc = value.ToUniversalTime();
                }
            }

            /// <summary>
            /// Expiration as reported by the credentials provider, as a UTC instant, before <see cref="ExpirationBuffer"/>
            /// is subtracted from <see cref="Expiration"/>. This is what distinguishes the mandatory refresh phase
            /// (inside the expiration buffer) from the expired phase (past the reported expiration).
            /// Defaults to <see cref="ExpirationUtc"/> until <see cref="CaptureRawExpiration"/> runs.
            /// </summary>
            internal DateTime RawExpiration { get; private set; }

            /// <summary>
            /// <see cref="RawExpiration"/> minus the time the windows were finalized -- the input to the
            /// advisory-window lifetime table. Zero when unknown.
            /// </summary>
            internal TimeSpan Lifetime { get; private set; }

            /// <summary>
            /// Instant at or after which a non-blocking advisory (background) refresh becomes due.
            /// </summary>
            internal DateTime AdvisoryRefreshAt { get; private set; }

            /// <summary>
            /// True when this credentials generation was born already at or inside its advisory window --
            /// i.e. the computed advisory refresh instant is at or before the time the windows were finalized.
            /// In that case a background (advisory) refresh would be due immediately and, because the window
            /// is fixed for the life of these credentials, would re-fire on every call until they reach the
            /// mandatory window. When set, <see cref="RefreshingAWSCredentials.TriggerBackgroundRefreshIfNeeded"/>
            /// suppresses the background refresh and lets the credentials fall through to the (blocking)
            /// mandatory path at <see cref="Expiration"/> instead.
            /// </summary>
            internal bool AdvisoryUnreachable { get; private set; }

            public CredentialsRefreshState() : this(null, default) { }

            public CredentialsRefreshState(ImmutableCredentials credentials, DateTime expiration) 
                : this (credentials, expiration, DefaultTimeProvider.Instance) { }

            public CredentialsRefreshState(ImmutableCredentials credentials, DateTime expiration, ITimeProvider timeProvider)
            {
                Credentials = credentials;
                Expiration = expiration;
                RawExpiration = ExpirationUtc;
                AdvisoryRefreshAt = ExpirationUtc;
                _timeProvider = timeProvider ?? DefaultTimeProvider.Instance;
            }

            /// <summary>
            /// <see cref="Expiration"/> as a UTC instant. Every refresh decision compares UTC instants, so an
            /// expiration with <see cref="DateTimeKind.Local"/> behaves exactly like the same instant expressed in
            /// UTC. As in earlier versions of the SDK, an expiration with <see cref="DateTimeKind.Unspecified"/> is
            /// treated as local time. Set together with <see cref="Expiration"/>, which keeps the kind the caller
            /// used.
            /// </summary>
            internal DateTime ExpirationUtc => _expirationUtc;

            /// <summary>
            /// Subtracts <paramref name="buffer"/> from the expiration. <see cref="ExpirationUtc"/> is reduced as a UTC
            /// instant, so it stays exact across a daylight saving time change. <see cref="Expiration"/> keeps the
            /// kind the credentials provider used and is reduced as in earlier versions of the SDK.
            /// </summary>
            internal void ApplyExpirationBuffer(TimeSpan buffer)
            {
                _expirationUtc -= buffer;
                _expiration -= buffer;
            }

            internal bool IsExpiredWithin(TimeSpan preemptExpiryTime)
            {
                var now = _timeProvider.CorrectedUtcNow;
                return now > ExpirationUtc - preemptExpiryTime;
            }

            /// <summary>
            /// True when these credentials are already stale as of now -- their expiration is at or before the
            /// current time. Distinct from <see cref="IsExpiredWithin"/>: this treats <c>Expiration == now</c>
            /// as stale (equality fails), because a source response whose expiration is exactly "now" cannot be
            /// safely used.
            /// </summary>
            internal bool IsStaleAsOfNow()
            {
                return _timeProvider.CorrectedUtcNow >= ExpirationUtc;
            }

            /// <summary>
            /// Records the provider-reported expiration, as a UTC instant, as <see cref="RawExpiration"/>. Must be
            /// called before <see cref="ExpirationBuffer"/> is subtracted from <see cref="Expiration"/>, so the
            /// pre-buffer instant is preserved for the "Expired" state.
            /// </summary>
            internal void CaptureRawExpiration()
            {
                RawExpiration = ExpirationUtc;
            }

            /// <summary>
            /// Freezes the derived refresh instants for this credentials generation. Called exactly once,
            /// at the end of ValidateGeneratedCredentials, after <see cref="ExpirationBuffer"/> has been
            /// applied to <see cref="Expiration"/> and <see cref="CaptureRawExpiration"/> has run. Freezing
            /// (rather than recomputing per read) guarantees every reader in a generation sees the same
            /// windows, which is what prevents "sometimes it refreshes twice" races.
            /// </summary>
            internal void FinalizeWindows(TimeSpan advisoryWindow, ITimeProvider timeProvider)
            {
                var provider = timeProvider ?? _timeProvider;
                var now = provider.CorrectedUtcNow;
                Lifetime = RawExpiration - now;

                var advisoryRefreshAt = ExpirationUtc - advisoryWindow;
                // Include equality (<=), not strict <: a credential born with its advisory instant exactly at
                // 'now' is still inside its advisory window and would otherwise start a background refresh on
                // every call. Counterexample: now=T, RawExpiration=T+5m, ExpirationBuffer=1m, no explicit
                // preempt -> advisoryRefreshAt=T, and T<T is false so a strict check would miss it.
                AdvisoryUnreachable = advisoryRefreshAt <= now;
                // Never schedule an advisory refresh in the past: short-lived credentials can be born
                // inside their own advisory window, and without this clamp every call would start a
                // background refresh (GitHub issue #4313).
                AdvisoryRefreshAt = advisoryRefreshAt < now ? now : advisoryRefreshAt;
            }

            /// <summary>
            /// Returns a NEW state carrying the same credentials but expired as of <paramref name="now"/>, so
            /// the next call performs a mandatory refresh while these credentials remain the static-stability
            /// fallback. Used by <see cref="RefreshingAWSCredentials.Invalidate"/>, which swaps the reference
            /// atomically. This never mutates the published instance: other threads read <see cref="Expiration"/>,
            /// <see cref="RawExpiration"/>, <see cref="AdvisoryRefreshAt"/> and <see cref="Lifetime"/> lock-free on
            /// the fast path, and a DateTime write is not atomic on 32-bit runtimes, so an in-place mutation could
            /// be observed torn.
            /// </summary>
            internal CredentialsRefreshState WithExpiredAt(DateTime now)
            {
                // The constructor sets Expiration = RawExpiration = AdvisoryRefreshAt = now and leaves
                // Lifetime at its TimeSpan.Zero default -- exactly the expired-fallback shape we want.
                return new CredentialsRefreshState(Credentials, now, _timeProvider);
            }
        }

        /// <summary>
        /// Represents the current state of the Credentials.
        /// </summary>
        /// <remarks>This can be cleared without synchronization.</remarks>
        protected volatile CredentialsRefreshState currentState;

        #region Private members

        private TimeSpan _expirationBuffer = TimeSpan.FromMinutes(1);

        // The message earlier versions of the SDK logged for a failed background refresh.
        private const string BackgroundRefreshFailedMessage = "Exception occurred performing background credentials refresh.";

        // The PreemptExpiryTime value a caller (customer or provider) has set, or null when it has not been set. When
        // null, the advisory-window lifetime table chooses the window for providers that opt in to the refresh
        // lifecycle, and other providers use zero. A value that is set always wins. One reference, written with
        // Volatile.Write and read with Volatile.Read, so a reader never sees that a value was set together with the
        // value from before the set, and the TimeSpan is never read torn on 32-bit runtimes.
        private ConfiguredTimeSpan _configuredPreemptExpiryTime;

        // Refresh backoff. Ticks of a UTC DateTime, or 0 for "no backoff in effect". A long written
        // through Interlocked rather than a DateTime? because DateTime is 8 bytes and not guaranteed to
        // be written atomically on 32-bit runtimes, and the read path here must stay lock-free.
        private long _nextRefreshAllowedAtTicks;

        // Non-recoverable error cache. Writers that hold the semaphore (CacheNonRecoverableError,
        // PublishRefreshSuccess) and ClearCredentials publish through Volatile.Write or Interlocked. The expiry clear in
        // GetLiveCachedError can run without the lock (advisory and pre-lock paths), so it uses
        // Interlocked.CompareExchange to null only the exact expired entry it observed: an unconditional write
        // could erase a fresh entry that a concurrent refresh cached in the meantime. Read lock-free via
        // Volatile.Read. A single reference field holding both the error and its expiry keeps the read atomic.
        // Not marked volatile: every access already goes through a Volatile or Interlocked helper.
        private CachedCredentialError _cachedError;

        // True when the most recent refresh attempt failed with a non-recoverable error. Set when the
        // error is cached, and cleared by a successful refresh, by a recoverable failure (which applies the refresh
        // backoff instead) and by ClearCredentials. Unlike the cached error it does not lapse after 1-5 seconds:
        // while it is set, a call in the advisory window refreshes while the caller waits instead of starting a
        // background refresh, so the caller sees the error if it recurs. Accessed through Volatile.Read/Write.
        private bool _lastRefreshFailedNonRecoverably;

        // Number of ClearCredentials calls. ClearCredentials runs without the lock, so a refresh attempt can still be
        // calling the source when it runs. Each attempt reads this count when it starts and, if the count has changed
        // by the time the attempt fails, does not record that failure (the cached non-recoverable error or the
        // refresh backoff): the failure belongs to the state that ClearCredentials discarded. A success is still
        // published, because a provider can call ClearCredentials from inside its own fetch (CognitoAWSCredentials
        // does when the identity changes). Accessed through Interlocked and Volatile.
        private int _clearCount;

        // Single-flight guard for the background (advisory) refresh: 1 while a background refresh has been
        // dispatched and not yet finished, 0 otherwise. Toggled with Interlocked so at most one background
        // refresh is ever in flight. This does NOT gate the mandatory path -- mutual exclusion of the actual
        // source call is enforced by _updateGeneratedCredentialsSemaphore.
        private int _backgroundRefreshInFlight;

        // The scope of the background refresh whose call to its credential source this logical call flow belongs to, or
        // null (see GenerateNewCredentialsInBackgroundAsync and IsBackgroundRefresh). Static, so that every provider that
        // the call reaches sees it, such as SSO credentials that the STS client of an AssumeRoleAWSCredentials resolves
        // as its source credentials. An AsyncLocal, so it is scoped to that flow: it is set inside an async method, so it
        // flows into the awaited source call and never back to the method's caller. Calls outside that flow see no
        // scope: calls on other threads, calls that wait for a refresh lock that this flow holds (each resumes in its own
        // execution context), and the refreshes that an application's call runs while it waits, including the in-line
        // refresh in the advisory window. Work that the source call starts inherits the scope, and some of that work can
        // outlive the call: a thread started during the call keeps the execution context it started with, for example
        // the thread that AWSSDKUtils.InvokeInBackground creates on first use and keeps for the life of the process. So
        // the refresh closes its scope when the source call ends, and such work sees false from then on. The background
        // refresh of a provider that the call reaches opens its own scope.
        private static readonly AsyncLocal<BackgroundRefreshScope> _backgroundRefreshScope = new AsyncLocal<BackgroundRefreshScope>();

        // The cached credentials whose background refresh ended because the refresh needs the caller (see
        // CredentialRefreshDeferredException), or null. While currentState is still this state, no further background
        // refresh starts; the credentials are refreshed when a call finds them at Expiration. Cleared when new
        // credentials are cached and by ClearCredentials. Accessed through Volatile.
        private CredentialsRefreshState _backgroundRefreshDeferredState;

        // Number of times the refresh backoff has been applied, and the value it had when the cached credentials were
        // last logged as served during the backoff. Every call made while the backoff lasts returns the cached
        // credentials; comparing the two logs that only once per backoff. Accessed through Interlocked and Volatile.
        private int _refreshBackoffCount;
        private int _refreshBackoffCountLogged;

        // Set by Dispose(bool) before it disposes the semaphore, and read without the lock by Invalidate.
        private volatile bool _disposed;

        // Calls StartProactiveRefresh on a schedule, for a provider that started one (see StartScheduledRefresh), or
        // null. Disposed by Dispose(bool).
        private Timer _scheduledRefreshTimer;

        private readonly SemaphoreSlim _updateGeneratedCredentialsSemaphore = new SemaphoreSlim(1, 1);

        /// <summary>
        /// The credential lifecycle phase, derived from the cached state and the current time.
        /// </summary>
        private enum RefreshPhase
        {
            /// <summary>No cached credentials -- a blocking initial fetch is required.</summary>
            NoCredentials,
            /// <summary>Cached credentials are valid and well before the advisory window.</summary>
            Valid,
            /// <summary>Inside the advisory window: serve cached, refresh in the background.</summary>
            Advisory,
            /// <summary>Past Expiration but before RawExpiration: inside our safety buffer, refresh blocking.</summary>
            Mandatory,
            /// <summary>Past RawExpiration: the service will reject these, refresh blocking.</summary>
            Expired,
        }

        /// <summary>
        /// An immutable holder for a <see cref="TimeSpan"/> setting, so that the setting is published as one reference.
        /// </summary>
        private sealed class ConfiguredTimeSpan
        {
            public ConfiguredTimeSpan(TimeSpan value)
            {
                Value = value;
            }

            public TimeSpan Value { get; }
        }

        /// <summary>
        /// A non-recoverable credential error together with the instant it stops being cached. The error is
        /// captured once, when it is cached, and every caller that receives it rethrows that same capture. Capturing
        /// again on each rethrow would append another stack-trace segment to the shared exception every time.
        /// </summary>
        private sealed class CachedCredentialError
        {
            public ExceptionDispatchInfo Error { get; }
            public DateTime CachedUntil { get; }

            public CachedCredentialError(Exception exception, DateTime cachedUntil)
            {
                Error = ExceptionDispatchInfo.Capture(exception);
                CachedUntil = cachedUntil;
            }
        }

        /// <summary>
        /// Marks one call of a background refresh to its credential source (see IsBackgroundRefresh). The call's flow,
        /// and work that the call starts, carry the scope; the refresh clears <see cref="Active"/> when the call ends.
        /// </summary>
        private sealed class BackgroundRefreshScope
        {
            // Read on every thread that carries the scope, hence volatile.
            internal volatile bool Active = true;
        }

        #endregion

        #endregion

        #region Properties

        /// <summary>
        /// If credentials are still valid but the expiration is within the Expiration minus PreemptExpiryTime a
        /// background refresh of the credentials will be triggered.
        /// <para />
        /// For the providers that use the credential refresh lifecycle (see
        /// <see cref="UsesManagedRefreshLifecycle"/>), when this property has not been set the window is
        /// chosen from the lifetime of each set of credentials when they are fetched (a lifetime of 20 minutes or less:
        /// 5 minutes; more than 20 and less than 90 minutes: 15 minutes; 90 minutes or more: 60 minutes), measured from
        /// the expiration that the credential source reported. Reading the property then returns the window chosen for
        /// the current credentials, or 5 minutes when no lifetime is known (for example, before the first fetch).
        /// Credentials that are already inside their window when they are fetched do not start a background refresh;
        /// they are refreshed when they reach <see cref="Expiration"/>.
        /// <para />
        /// For these providers, a value that is set is used instead of the lifetime table for credentials fetched after
        /// it is set; credentials that are already cached keep the window chosen when they were fetched. The value is
        /// measured from <see cref="Expiration"/>, which has <see cref="ExpirationBuffer"/> subtracted, as in earlier
        /// versions of the SDK. Assigning the value that was read back (<c>PreemptExpiryTime = PreemptExpiryTime</c>)
        /// is therefore not a no-op: later credentials no longer get a window chosen from their lifetime, and their
        /// background refresh starts <see cref="ExpirationBuffer"/> (1 minute by default) earlier than the window that
        /// was read.
        /// <para />
        /// For other providers, such as <see cref="ProcessAWSCredentials"/>, <see cref="FederatedAWSCredentials"/> and
        /// classes that derive directly from <see cref="RefreshingAWSCredentials"/> or
        /// <see cref="URIBasedRefreshingCredentialHelper"/>, the property keeps its earlier behavior: it returns the value
        /// set, which is zero (no background refresh) unless it is set, and a value that is set takes effect immediately,
        /// including for the credentials already cached.
        /// </summary>
        public TimeSpan PreemptExpiryTime
        {
            get
            {
                var configured = Volatile.Read(ref _configuredPreemptExpiryTime);
                if (configured != null)
                    return configured.Value;
                if (!UsesManagedRefreshLifecycle)
                    return TimeSpan.Zero;

                var state = currentState;
                return CredentialRefreshPolicy.AdvisoryWindowForLifetime(state?.Lifetime ?? TimeSpan.Zero);
            }
            set
            {
                if (value < TimeSpan.Zero)
                    throw new ArgumentOutOfRangeException("value", "PreemptExpiryTime cannot be negative");
                Volatile.Write(ref _configuredPreemptExpiryTime, new ConfiguredTimeSpan(value));
            }
        }

        /// <summary>
        /// Whether the SDK manages the refresh of this provider's credentials: when to refresh them, what to do when a
        /// refresh fails, and what to do when a service rejects them. Override this to return <c>true</c> to opt in;
        /// the default is <c>false</c>. The value is read on every call, so return the same value for the life of the
        /// instance.
        /// <para />
        /// A provider that opts in gets this behavior:
        /// <list type="bullet">
        /// <item><description>Refresh timing: unless <see cref="PreemptExpiryTime"/> is set, the background refresh
        /// window is chosen from the lifetime of each set of credentials when they are fetched. Credentials that are
        /// already inside their window when they are fetched are refreshed when they reach <see cref="Expiration"/>,
        /// not in the background on every call.</description></item>
        /// <item><description>Failed refreshes: the cached credentials are returned, even if they have expired, and
        /// <see cref="GetCredentials()"/> does not contact the credential source again until the refresh backoff has
        /// elapsed. The backoff is random, between 1 minute and half the time the cached credentials have left, at most
        /// 10 minutes and at least 1.5 minutes.</description></item>
        /// <item><description>Non-recoverable errors: an error for which <see cref="IsNonRecoverableError"/> returns
        /// <c>true</c> is raised immediately and never replaced by the cached credentials, and
        /// <see cref="GetCredentials()"/> raises it again without contacting the credential source for the next 1 to 5
        /// seconds.</description></item>
        /// <item><description>Rejected credentials: when a service rejects a request signed with these credentials with
        /// <c>ExpiredToken</c> or <c>ExpiredTokenException</c>, the SDK calls <see cref="Invalidate"/> and retries the request
        /// under the client's retry policy, signed with credentials resolved again. The retry counts toward the maximum
        /// number of attempts and uses retry quota.</description></item>
        /// </list>
        /// A provider that does not opt in keeps the behavior of earlier versions of the SDK: a failed refresh of expired
        /// credentials throws, with no refresh backoff and no fallback to the cached credentials; a background refresh
        /// starts when the credentials are within <see cref="PreemptExpiryTime"/> (zero unless set) of
        /// <see cref="Expiration"/> and is attempted again by the next such call if it fails; and a request that a
        /// service rejects is neither invalidated nor retried. For <see cref="GetCredentials(TimeSpan)"/>, see that
        /// method.
        /// <para />
        /// The SDK's EC2 instance metadata (<see cref="InstanceProfileAWSCredentials"/>, and the provider that the
        /// default credential chain uses), container (<see cref="GenericContainerCredentials"/>),
        /// <see cref="AssumeRoleAWSCredentials"/>, <see cref="AssumeRoleWithWebIdentityCredentials"/>,
        /// <see cref="SSOAWSCredentials"/>, <see cref="LoginAWSCredentials"/> and <c>CognitoAWSCredentials</c> providers
        /// opt in, and classes derived from them inherit that and cannot override it. <see cref="ProcessAWSCredentials"/>,
        /// <see cref="FederatedAWSCredentials"/>, and classes that derive directly from
        /// <see cref="RefreshingAWSCredentials"/> or from <see cref="URIBasedRefreshingCredentialHelper"/> (the base
        /// class of the instance metadata and container providers) do not.
        /// </summary>
        protected virtual bool UsesManagedRefreshLifecycle => false;

        /// <summary>
        /// Test-only seam producing the refresh backoff duration. Defaults to
        /// <see cref="CredentialRefreshPolicy.NextRefreshBackoff(TimeSpan)"/> for the remaining lifetime of the cached
        /// credentials. Overridden in unit tests to make backoff deterministic.
        /// </summary>
        internal Func<TimeSpan> RefreshBackoffGenerator { get; set; }

        // Time left until the cached credentials reach the expiration the credential source reported, or zero when
        // nothing is cached or they have expired. The refresh backoff scales with it.
        private TimeSpan RemainingLifetime()
        {
            var state = currentState;
            if (state == null)
                return TimeSpan.Zero;
            var remaining = state.RawExpiration - _timeProvider.CorrectedUtcNow;
            return remaining > TimeSpan.Zero ? remaining : TimeSpan.Zero;
        }

        /// <summary>
        /// Test-only seam producing the non-recoverable error cache duration. Defaults to a uniform random
        /// value in [1s, 5s]. Overridden in unit tests to make the cache window deterministic.
        /// </summary>
        internal Func<TimeSpan> NonRecoverableErrorCacheGenerator { get; set; } = CredentialRefreshPolicy.NextNonRecoverableErrorCacheDuration;


        /// <summary>
        /// The time subtracted from the expiration provided by the credentials provider and then used for determining 
        /// if the credentials are expired. This provides a buffer to avoid corner case issues of processing time
        /// on the client side before the credentials are actually used for signing and validation on the server side.
        /// </summary>
        public TimeSpan ExpirationBuffer
        {
            get { return _expirationBuffer; }
            set
            {
                if (value < TimeSpan.Zero)
                    throw new ArgumentOutOfRangeException("value", "ExpirationBuffer cannot be negative");
                _expirationBuffer = value;
            }
        }

        #endregion

        #region Override methods

        /// <summary>
        /// Returns the cached credentials, refreshing them first when needed. Credentials that are not yet inside their
        /// background refresh window (see <see cref="PreemptExpiryTime"/>) are returned without taking a lock. Inside
        /// that window the cached credentials are returned immediately and a background refresh may be started. Once
        /// the credentials reach <see cref="Expiration"/>, the call waits for a refresh, unless the refresh backoff is
        /// in effect, in which case the cached credentials are returned. The first call, when nothing is cached, waits
        /// for the initial fetch and throws if it fails. Users should not rely on the <see cref="Expiration"/> property
        /// before calling <see cref="GetCredentials()"/> because the <see cref="Expiration"/> could be updated.
        /// <para />
        /// For the providers that use the credential refresh lifecycle (see
        /// <see cref="UsesManagedRefreshLifecycle"/>), a failed refresh returns the cached credentials rather than
        /// throwing, so callers should not assume that the returned credentials have not expired. A non-recoverable
        /// error is thrown. If the most recent refresh failed with a non-recoverable error, a call inside the background
        /// refresh window refreshes while the caller waits, unless another caller is already refreshing, so that the
        /// error is raised if it recurs. Other providers throw when a refresh of expired credentials fails, as in
        /// earlier versions of the SDK.
        /// </summary>
        /// <returns>An instance of ImmutableCredentials</returns>
        public override sealed ImmutableCredentials GetCredentials()
        {
            // NOTICE: The synchronous and asynchronous entry points share the same lifecycle. See the
            // state model on ClassifyState and the helpers below. The five phases are:
            //   NoCredentials -> blocking initial fetch, throws on failure (no fallback exists).
            //   Valid         -> return cached, no lock.
            //   Advisory      -> return cached immediately; dispatch ONE non-blocking background refresh. If the
            //                    last refresh attempt failed with a non-recoverable error, refresh while the
            //                    caller waits instead, so the caller sees the error if it recurs; a caller that
            //                    finds another refresh in progress still returns cached immediately.
            //   Mandatory     -> blocking refresh; on recoverable failure return cached (static stability).
            //   Expired       -> as Mandatory; the service may reject these credentials.
            // Refresh backoff (60s to 600s, scaled with the remaining lifetime) suppresses refresh attempts after a recoverable failure: while it
            // lasts, Mandatory and Expired calls return cached without waiting for the lock. A cached non-recoverable
            // error short-circuits with the original exception for 1-5s. Providers that do not opt in to the refresh
            // lifecycle (UsesManagedRefreshLifecycle is false) keep the checks and background refresh
            // of earlier versions of the SDK (see ClassifyState and TriggerBackgroundRefreshIfNeeded) and never apply
            // the backoff.
            var tempState = currentState;
            var phase = ClassifyState(tempState);

            // Phase 1: lock-free fast path. The vast majority of calls return here without contending.
            if (phase == RefreshPhase.Valid)
                return tempState.Credentials;

            // Every other phase first raises a cached non-recoverable error that is still within its 1-5s cache
            // duration, without contacting the credential source. In the advisory window this is how an error
            // from a background refresh reaches the next on-demand caller. The lock-free Valid fast path above
            // deliberately does not check: no refresh runs while credentials are Valid, so no error can be cached
            // there, and a fresh-credential path must not throw.
            ThrowIfNonRecoverableErrorCached();

            if (phase == RefreshPhase.Advisory)
            {
                // Advisory: serve cached now and dispatch the single background refresh; no source call is made on
                // this caller's thread. The exception is when the last refresh attempt failed with a
                // non-recoverable error whose cache duration has elapsed: then this caller refreshes under the lock
                // below and sees the outcome, because a background attempt would only fail again with nobody to
                // report it to.
                if (!LastRefreshFailedNonRecoverably)
                {
                    TriggerBackgroundRefreshIfNeeded(tempState);
                    return tempState.Credentials;
                }

                // Only try to take the lock: the cached credentials are still valid, so a caller that finds another
                // refresh in progress returns them immediately instead of waiting for that refresh.
                if (!_updateGeneratedCredentialsSemaphore.Wait(TimeSpan.Zero))
                    return tempState.Credentials;
            }
            else
            {
                // While the refresh backoff lasts, return the cached credentials without waiting for the lock, so a
                // call during the backoff never waits for a refresh that another caller is running. The check is
                // repeated under the lock, where a refresh that failed while this caller waited may have applied the
                // backoff.
                if (phase != RefreshPhase.NoCredentials && IsRefreshRateLimited())
                    return ServeCachedDuringRefreshBackoff(tempState, phase);
                _updateGeneratedCredentialsSemaphore.Wait();
            }

            try
            {
                // Phase 2: recheck under the lock -- another thread may have refreshed while we waited.
                tempState = currentState;
                phase = ClassifyState(tempState);

                if (phase == RefreshPhase.NoCredentials)
                    return FetchInitialCredentials();

                if (phase == RefreshPhase.Mandatory || phase == RefreshPhase.Expired)
                    return AttemptMandatoryRefresh(tempState, phase);

                if (phase == RefreshPhase.Advisory && LastRefreshFailedNonRecoverably)
                    return AttemptAdvisoryRefresh(tempState);

                // Valid or Advisory now: another thread refreshed while we waited. Serve cached; if still in
                // the advisory window a subsequent (unlocked) call will dispatch the background refresh.
                return tempState.Credentials;
            }
            finally
            {
                _updateGeneratedCredentialsSemaphore.Release();
            }
        }

        /// <summary>
        /// Asynchronous version of <see cref="GetCredentials()"/>, with the same refresh behavior. Users should not
        /// rely on the <see cref="Expiration"/> property before calling <see cref="GetCredentialsAsync()"/> because the
        /// <see cref="Expiration"/> could be updated.
        /// <para />
        /// For the providers that use the credential refresh lifecycle (see
        /// <see cref="UsesManagedRefreshLifecycle"/>), a failed refresh returns the cached credentials rather than
        /// throwing, so callers should not assume that the returned credentials have not expired.
        /// </summary>
        /// <returns>A task whose result is an ImmutableCredentials instance.</returns>
        public override sealed async Task<ImmutableCredentials> GetCredentialsAsync()
        {
            var tempState = currentState;
            var phase = ClassifyState(tempState);

            if (phase == RefreshPhase.Valid)
                return tempState.Credentials;

            // Mirrors GetCredentials(): raise a cached non-recoverable error that is still within its cache
            // duration, then in the advisory window serve cached and dispatch the single non-blocking background
            // refresh, unless the last refresh attempt failed with a non-recoverable error. In that case only try
            // to take the lock, and serve cached if another refresh holds it.
            ThrowIfNonRecoverableErrorCached();

            if (phase == RefreshPhase.Advisory)
            {
                if (!LastRefreshFailedNonRecoverably)
                {
                    TriggerBackgroundRefreshIfNeeded(tempState);
                    return tempState.Credentials;
                }

                if (!await _updateGeneratedCredentialsSemaphore.WaitAsync(TimeSpan.Zero).ConfigureAwait(false))
                    return tempState.Credentials;
            }
            else
            {
                if (phase != RefreshPhase.NoCredentials && IsRefreshRateLimited())
                    return ServeCachedDuringRefreshBackoff(tempState, phase);
                await _updateGeneratedCredentialsSemaphore.WaitAsync().ConfigureAwait(false);
            }

            try
            {
                tempState = currentState;
                phase = ClassifyState(tempState);

                if (phase == RefreshPhase.NoCredentials)
                    return await FetchInitialCredentialsAsync().ConfigureAwait(false);

                if (phase == RefreshPhase.Mandatory || phase == RefreshPhase.Expired)
                    return await AttemptMandatoryRefreshAsync(tempState, phase).ConfigureAwait(false);

                if (phase == RefreshPhase.Advisory && LastRefreshFailedNonRecoverably)
                    return await AttemptAdvisoryRefreshAsync(tempState).ConfigureAwait(false);

                return tempState.Credentials;
            }
            finally
            {
                _updateGeneratedCredentialsSemaphore.Release();
            }
        }

        /// <summary>
        /// Classifies the lifecycle phase for <paramref name="state"/> against the current corrected time.
        /// </summary>
        private RefreshPhase ClassifyState(CredentialsRefreshState state)
        {
            if (state == null)
                return RefreshPhase.NoCredentials;

            // AdvisoryRefreshAt and RawExpiration are UTC; Expiration keeps the kind the source used, so compare
            // its UTC instant.
            var now = _timeProvider.CorrectedUtcNow;
            if (!UsesManagedRefreshLifecycle)
            {
                // Providers that do not opt in to the refresh lifecycle keep the checks of earlier versions of the SDK,
                // made on every call against the current Expiration and PreemptExpiryTime: the credentials are expired
                // once now is later than Expiration, and inside the preempt (background refresh) window once now is
                // later than Expiration minus PreemptExpiryTime.
                var expiration = state.ExpirationUtc;
                if (now > expiration)
                    return now < state.RawExpiration ? RefreshPhase.Mandatory : RefreshPhase.Expired;
                if (now > expiration - ConfiguredPreemptExpiryTimeOrZero)
                    return RefreshPhase.Advisory;
                return RefreshPhase.Valid;
            }

            // Expiration is compared first, so that a subclass that forces a refresh by setting currentState.Expiration
            // to an earlier time gets that refresh on the next call, as in earlier versions of the SDK. The order makes
            // no difference when Expiration was not changed after ValidateGeneratedCredentials: AdvisoryRefreshAt is
            // later than Expiration only for credentials that were already inside ExpirationBuffer when fetched, and
            // those are past Expiration at every later check.
            if (now >= state.ExpirationUtc)
                return now < state.RawExpiration ? RefreshPhase.Mandatory : RefreshPhase.Expired;
            if (now < state.AdvisoryRefreshAt)
                return RefreshPhase.Valid;
            return RefreshPhase.Advisory;
        }

        // Caller holds _updateGeneratedCredentialsSemaphore. Blocking; throws on failure because there are
        // no cached credentials to fall back on.
        private ImmutableCredentials FetchInitialCredentials()
        {
            // Callers that queued on the lock behind an attempt that failed with a non-recoverable error receive
            // that cached error rather than contacting the source again. Outside the try block, so the rethrow is
            // not cached a second time.
            ThrowIfNonRecoverableErrorCached();
            var clearCount = Volatile.Read(ref _clearCount);
            try
            {
                var newState = GenerateNewCredentials();
                if (TryPublishExpiredInitialCredentials(newState))
                    return newState.Credentials;
                ValidateGeneratedCredentials(newState);
                PublishRefreshSuccess(newState);
                return newState.Credentials;
            }
            catch (Exception e) when (FindRefreshDeferral(e) != null)
            {
                // This call is part of the background refresh of another provider that uses this one as its credential
                // source, and the refresh needs the caller (see CredentialRefreshDeferredException). That is not a
                // failure of this provider: it is passed on unchanged, before any classification, so that no error is
                // cached, no refresh backoff is applied, no cached credentials are returned in its place and no failure
                // is logged, and the background refresh that started the call ends without recording a failure. The
                // same applies on every path below that calls the credential source.
                throw;
            }
            catch (Exception e) when (IsNonRecoverableError(e))
            {
                var replacement = OnNonRecoverableRefreshFailure(e, clearCount); // cached for 1-5s, no backoff
                if (replacement == null)
                    throw;
                throw replacement;
            }
            catch (Exception)
            {
                // No backoff on the initial fetch: there is nothing to serve, so locking the provider out
                // for minutes would turn one transient failure into a guaranteed multi-minute outage.
                throw;
            }
        }

        private async Task<ImmutableCredentials> FetchInitialCredentialsAsync()
        {
            ThrowIfNonRecoverableErrorCached();
            var clearCount = Volatile.Read(ref _clearCount);
            try
            {
                var newState = await GenerateNewCredentialsAsync().ConfigureAwait(false);
                if (TryPublishExpiredInitialCredentials(newState))
                    return newState.Credentials;
                ValidateGeneratedCredentials(newState);
                PublishRefreshSuccess(newState);
                return newState.Credentials;
            }
            catch (Exception e) when (FindRefreshDeferral(e) != null)
            {
                throw;
            }
            catch (Exception e) when (IsNonRecoverableError(e))
            {
                var replacement = OnNonRecoverableRefreshFailure(e, clearCount);
                if (replacement == null)
                    throw;
                throw replacement;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Caller holds _updateGeneratedCredentialsSemaphore. Handles an initial fetch whose response has already
        // expired, for providers that use the refresh lifecycle: they are the only credentials available, so they are
        // cached and returned instead of failing the fetch. A credential source can keep serving its last credentials
        // while its own source is unavailable (IMDS does), and AWS services can still accept them. No refresh backoff is
        // applied: the cached state is expired, so the next call runs the mandatory refresh, and the backoff applies
        // only if that refresh fails too. Returns false without changing anything in every other case.
        private bool TryPublishExpiredInitialCredentials(CredentialsRefreshState newState)
        {
            if (!UsesManagedRefreshLifecycle || newState?.Credentials == null || !IsExpired(newState))
                return false;

            // A new state built from the reported expiration in UTC, so Expiration still reports when these
            // credentials expired and the state classifies as expired whatever DateTimeKind the source used.
            var expiration = newState.ExpirationUtc;
            PublishRefreshSuccess(new CredentialsRefreshState(newState.Credentials, expiration, _timeProvider));

            _logger.WarnFormat(
                "The credential source returned credentials that have already expired. Expiration time: {0}, Current time: {1}. " +
                "No other credentials are cached, so the SDK will use these credentials and refresh them on the next request for credentials.",
                expiration.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture),
                _timeProvider.CorrectedUtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture));
            return true;
        }

        // Caller holds the semaphore. tempState is non-null. Blocking refresh with static stability on failure.
        private ImmutableCredentials AttemptMandatoryRefresh(CredentialsRefreshState tempState, RefreshPhase phase)
        {
            // As in FetchInitialCredentials: a caller that waited for the lock behind a non-recoverable failure
            // receives the cached error instead of contacting the source again.
            ThrowIfNonRecoverableErrorCached();

            // A recent refresh failed and the refresh backoff has not elapsed: serve the cached credentials (expired or
            // not) without contacting the source.
            if (IsRefreshRateLimited())
                return ServeCachedDuringRefreshBackoff(tempState, phase);

            LogCredentialsExpired(tempState);
            var clearCount = Volatile.Read(ref _clearCount);
            try
            {
                var newState = GenerateNewCredentials();
                ValidateGeneratedCredentials(newState);
                PublishRefreshSuccess(newState);
                return newState.Credentials;
            }
            catch (Exception e) when (FindRefreshDeferral(e) != null)
            {
                // Passed on unchanged; see FetchInitialCredentials. The cached credentials are not returned in its
                // place, so the background refresh that made this call ends instead of using them.
                throw;
            }
            catch (Exception e) when (IsNonRecoverableError(e))
            {
                // Non-recoverable overrides static stability: serving credentials whose identity source is
                // gone only defers a guaranteed failure and hides its cause.
                var replacement = OnNonRecoverableRefreshFailure(e, clearCount);
                if (replacement == null)
                    throw;
                throw replacement;
            }
            catch (Exception e)
            {
                // Providers that do not opt in to the refresh lifecycle keep the behavior of earlier versions of the
                // SDK: the exception propagates, with no refresh backoff and no fallback to the cached credentials.
                if (!UsesManagedRefreshLifecycle)
                    throw;
                SetRefreshBackoff(clearCount);
                // Logged after the backoff is applied, so the message reports when the next attempt is allowed.
                LogRefreshBackoffArmed(e);
                return tempState.Credentials;
            }
        }

        private async Task<ImmutableCredentials> AttemptMandatoryRefreshAsync(CredentialsRefreshState tempState, RefreshPhase phase)
        {
            ThrowIfNonRecoverableErrorCached();

            if (IsRefreshRateLimited())
                return ServeCachedDuringRefreshBackoff(tempState, phase);

            LogCredentialsExpired(tempState);
            var clearCount = Volatile.Read(ref _clearCount);
            try
            {
                var newState = await GenerateNewCredentialsAsync().ConfigureAwait(false);
                ValidateGeneratedCredentials(newState);
                PublishRefreshSuccess(newState);
                return newState.Credentials;
            }
            catch (Exception e) when (FindRefreshDeferral(e) != null)
            {
                throw;
            }
            catch (Exception e) when (IsNonRecoverableError(e))
            {
                var replacement = OnNonRecoverableRefreshFailure(e, clearCount);
                if (replacement == null)
                    throw;
                throw replacement;
            }
            catch (Exception e)
            {
                if (!UsesManagedRefreshLifecycle)
                    throw;
                SetRefreshBackoff(clearCount);
                LogRefreshBackoffArmed(e);
                return tempState.Credentials;
            }
        }

        // Caller holds the semaphore. tempState is non-null and in the advisory window, and the last refresh
        // attempt failed with a non-recoverable error whose cache duration has elapsed. Refreshes while the caller
        // waits so the caller sees the outcome: a success replaces the credentials, a recurring non-recoverable
        // error is cached and raised, and any other failure is handled as a failed background refresh (see
        // HandleRecoverableFailureOfValidCredentials) and returns the cached credentials, which are still valid.
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "A failure other than a non-recoverable one is logged, the refresh backoff is applied, and the still-valid cached credentials are returned, as a background refresh does.")]
        private ImmutableCredentials AttemptAdvisoryRefresh(CredentialsRefreshState tempState)
        {
            ThrowIfNonRecoverableErrorCached();
            if (IsRefreshRateLimited())
                return tempState.Credentials;

            LogCredentialsPreemptExpiry(tempState);
            var clearCount = Volatile.Read(ref _clearCount);
            try
            {
                var newState = GenerateNewCredentials();
                ValidateGeneratedCredentials(newState);
                PublishRefreshSuccess(newState);
                return newState.Credentials;
            }
            catch (Exception e) when (FindRefreshDeferral(e) != null)
            {
                // Passed on unchanged; see FetchInitialCredentials. It is not handled as a failed background refresh,
                // and the record of the earlier non-recoverable failure is kept, so a call made for the caller, outside
                // a background refresh, still refreshes while it waits.
                throw;
            }
            catch (Exception e) when (IsNonRecoverableError(e))
            {
                var replacement = OnNonRecoverableRefreshFailure(e, clearCount);
                if (replacement == null)
                    throw;
                throw replacement;
            }
            catch (Exception e)
            {
                HandleRecoverableFailureOfValidCredentials(e, clearCount);
                return tempState.Credentials;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "A failure other than a non-recoverable one is logged, the refresh backoff is applied, and the still-valid cached credentials are returned, as a background refresh does.")]
        private async Task<ImmutableCredentials> AttemptAdvisoryRefreshAsync(CredentialsRefreshState tempState)
        {
            ThrowIfNonRecoverableErrorCached();
            if (IsRefreshRateLimited())
                return tempState.Credentials;

            LogCredentialsPreemptExpiry(tempState);
            var clearCount = Volatile.Read(ref _clearCount);
            try
            {
                var newState = await GenerateNewCredentialsAsync().ConfigureAwait(false);
                ValidateGeneratedCredentials(newState);
                PublishRefreshSuccess(newState);
                return newState.Credentials;
            }
            catch (Exception e) when (FindRefreshDeferral(e) != null)
            {
                throw;
            }
            catch (Exception e) when (IsNonRecoverableError(e))
            {
                var replacement = OnNonRecoverableRefreshFailure(e, clearCount);
                if (replacement == null)
                    throw;
                throw replacement;
            }
            catch (Exception e)
            {
                HandleRecoverableFailureOfValidCredentials(e, clearCount);
                return tempState.Credentials;
            }
        }

        /// <summary>
        /// Dispatches at most one non-blocking background (advisory) refresh. Never blocks the caller: the
        /// actual source call happens on a fire-and-forget task that try_acquires the semaphore. A no-op if a
        /// background refresh is already in flight, if the provider is in refresh backoff, or if a background refresh of
        /// these credentials ended because the refresh needs the caller (see
        /// <see cref="CredentialRefreshDeferredException"/>).
        /// </summary>
        private void TriggerBackgroundRefreshIfNeeded(CredentialsRefreshState state)
        {
            if (UsesManagedRefreshLifecycle)
            {
                // Born at or inside the advisory window: a background refresh would be due immediately and, because
                // the window is fixed for these credentials, would re-fire on every call. Suppress it and let the
                // credentials fall through to the blocking mandatory path at Expiration instead.
                if (state.AdvisoryUnreachable)
                    return;
                if (IsRefreshRateLimited())
                    return;
            }
            // A background refresh of these credentials already ended because the refresh needs the caller: they are
            // refreshed when a call finds them at Expiration.
            if (ReferenceEquals(state, Volatile.Read(ref _backgroundRefreshDeferredState)))
                return;
            // Providers that do not opt in to the refresh lifecycle keep the background refresh of earlier versions of
            // the SDK: it starts whenever their credentials are inside PreemptExpiryTime and no background refresh is
            // running, including for credentials fetched inside that window, and a failed one is started again by the
            // next such call. They never apply the refresh backoff.
            // Interlocked single-flight: only the thread that flips 0 -> 1 dispatches the refresh.
            if (Interlocked.CompareExchange(ref _backgroundRefreshInFlight, 1, 0) != 0)
                return;
            try
            {
                LogCredentialsPreemptExpiry(state);
                // Dispatch onto the ThreadPool rather than calling directly: SemaphoreSlim.WaitAsync(TimeSpan.Zero)
                // commonly returns an already-completed Task, so C# would continue synchronously into the
                // customer-overridable GenerateNewCredentialsAsync() on the GetCredentials() caller's thread and
                // block an advisory call that is contractually non-blocking. Task.Run guarantees the
                // whole fire-and-forget refresh runs off the caller's thread.
                _ = Task.Run(() => BackgroundCredentialsRefreshAsync());
            }
            catch
            {
                // The background refresh did not start (for example, a log adaptor that the application registered
                // threw), so it will not clear the single-flight guard. Clear it here, so that a later call can start
                // one.
                Interlocked.Exchange(ref _backgroundRefreshInFlight, 0);
                throw;
            }
        }

        /// <summary>
        /// Starts a background refresh of the cached credentials even though they are not inside their refresh window,
        /// for a provider that refreshes on a schedule of its own to pick up newer credentials from its source early.
        /// It never blocks the caller and follows the background refresh rules: it is a no-op when nothing is cached
        /// yet, while the refresh backoff or a cached non-recoverable error is in effect, while another refresh is
        /// running, or when a background refresh of these credentials needs the caller. A failure keeps the cached
        /// credentials and is handled as a failed background refresh.
        /// </summary>
        internal void StartProactiveRefresh()
        {
            if (!UsesManagedRefreshLifecycle || _disposed)
                return;
            var state = currentState;
            if (state == null || GetLiveCachedError() != null || IsRefreshRateLimited())
                return;
            if (ReferenceEquals(state, Volatile.Read(ref _backgroundRefreshDeferredState)))
                return;
            if (Interlocked.CompareExchange(ref _backgroundRefreshInFlight, 1, 0) != 0)
                return;
            try
            {
                _logger.DebugFormat("Starting a scheduled background refresh of credentials that expire at {0}.",
                    state.ExpirationUtc.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture));
                _ = Task.Run(() => BackgroundCredentialsRefreshAsync(proactive: true));
            }
            catch
            {
                Interlocked.Exchange(ref _backgroundRefreshInFlight, 0);
                throw;
            }
        }

        /// <summary>
        /// Starts a timer that calls <see cref="StartProactiveRefresh"/> every <paramref name="interval"/> until the
        /// provider is disposed. The timer holds the provider only weakly, so a provider that the application stops
        /// using without disposing it can still be collected; its timer then stops. Called once, from a constructor.
        /// </summary>
        internal void StartScheduledRefresh(TimeSpan interval)
        {
            _scheduledRefreshTimer = new Timer(OnScheduledRefresh, new WeakReference<RefreshingAWSCredentials>(this), interval, interval);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "A timer callback must not throw: an exception would end the process. The refresh it starts handles and logs its own failures.")]
        private static void OnScheduledRefresh(object state)
        {
            try
            {
                if (((WeakReference<RefreshingAWSCredentials>)state).TryGetTarget(out var provider))
                {
                    provider.StartProactiveRefresh();
                }
            }
            catch (Exception e)
            {
                Logger.GetLogger(typeof(RefreshingAWSCredentials)).Debug(e, "The scheduled credential refresh could not start.");
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Fire-and-forget background refresh must not rethrow (nothing awaits it, so a rethrow becomes an unobserved task exception); the failure is logged and, for providers that opt in to the refresh lifecycle, recorded as a cached non-recoverable error or as the refresh backoff.")]
        private async Task BackgroundCredentialsRefreshAsync(bool proactive = false)
        {
            // NOTICE: This runs fire-and-forget (see the Advisory branch in GetCredentials). It must never
            // rethrow -- nothing awaits it, so a rethrow would only surface as an unobserved task exception.
            // A failure is logged and, for providers that opt in to the refresh lifecycle, recorded as a cached
            // non-recoverable error or as the refresh backoff, which the next on-demand call acts on.
            try
            {
                // Single-flight against the mandatory path: try_acquire and hold the semaphore around the
                // ENTIRE source call. If a mandatory (or another) caller already holds it we skip -- they will
                // produce credentials at least as fresh as ours, and a second concurrent fetch would mean
                // duplicate provider traffic, a stale advisory result overwriting a fresh mandatory one, or a
                // late advisory failure re-arming backoff after a mandatory success.
                if (!await _updateGeneratedCredentialsSemaphore.WaitAsync(TimeSpan.Zero).ConfigureAwait(false))
                    return;
                var clearCount = Volatile.Read(ref _clearCount);
                CredentialsRefreshState state = null;
                try
                {
                    // Recheck under the lock: another path may have refreshed, cached a non-recoverable error, or
                    // applied the backoff while this task was being scheduled. A cached error is left for the next
                    // on-demand caller to receive; this task does not contact the source again.
                    state = currentState;
                    var phase = ClassifyState(state);
                    if ((phase == RefreshPhase.Valid && !proactive) || GetLiveCachedError() != null || IsRefreshRateLimited())
                        return;

                    var newState = await GenerateNewCredentialsInBackgroundAsync().ConfigureAwait(false);
                    ValidateGeneratedCredentials(newState);
                    PublishRefreshSuccess(newState);
                }
                catch (Exception e) when (FindRefreshDeferral(e) != null)
                {
                    // The refresh needs the caller, for example an interactive SSO sign-in. That is not a failure: no
                    // error is cached, no backoff is applied, and the credentials are refreshed on the caller's thread
                    // when a call finds them at Expiration.
                    DeferRefreshToCaller(state, FindRefreshDeferral(e));
                }
                catch (Exception e)
                {
                    // Publish the failure state (cached non-recoverable error or refresh backoff) while STILL
                    // holding the semaphore. If this ran after the finally released the lock, a mandatory
                    // waiter could acquire in the gap and attempt its own refresh without seeing the backoff
                    // this failure just produced. Writing it here closes that window.
                    if (!UsesManagedRefreshLifecycle)
                    {
                        // Providers that do not opt in to the refresh lifecycle: log the failure as earlier versions of
                        // the SDK did. The next call inside the preempt window starts another background refresh.
                        _logger.Error(e, BackgroundRefreshFailedMessage);
                    }
                    else if (IsNonRecoverableError(e))
                    {
                        // Surfaces on the next call, not on this fire-and-forget one.
                        var raised = CacheNonRecoverableFailure(e, clearCount);
                        _logger.Warn(raised,
                            "Credential refresh failed with an error that retrying cannot resolve: {0}. " +
                            "The next request for credentials will raise this error if it persists.",
                            raised.Message);
                    }
                    else
                    {
                        HandleRecoverableFailureOfValidCredentials(e, clearCount);
                    }
                }
                finally
                {
                    _updateGeneratedCredentialsSemaphore.Release();
                }
            }
            catch (Exception e)
            {
                // Last-resort guard so this fire-and-forget task never surfaces as an unobserved task
                // exception. Only non-source failures reach here (e.g. a dispose race on WaitAsync/Release);
                // those are not credential-source failures, so no backoff is armed. Logged at the same level as a
                // failed background refresh of the same provider: Warn with the refresh lifecycle, Error without it,
                // as in earlier versions of the SDK.
                if (UsesManagedRefreshLifecycle)
                    _logger.Warn(e, BackgroundRefreshFailedMessage);
                else
                    _logger.Error(e, BackgroundRefreshFailedMessage);
            }
            finally
            {
                // Clear the single-flight guard last, so the next advisory call can dispatch a fresh attempt.
                Interlocked.Exchange(ref _backgroundRefreshInFlight, 0);
            }
        }

        /// <summary>
        /// True while <see cref="GenerateNewCredentialsAsync"/> runs as the background refresh of any provider, and in
        /// every call it makes, including calls to other providers that it uses as its credential source, such as the
        /// source credentials of <see cref="AssumeRoleAWSCredentials"/>; false on every other path, including a refresh
        /// that an application's call of <see cref="GetCredentials()"/> or <see cref="GetCredentialsAsync()"/> runs while
        /// it waits (a call made outside any background refresh), on any thread, and work that the background refresh
        /// started and that is still running after that call of <see cref="GenerateNewCredentialsAsync"/> has ended. A
        /// credential source that would need the caller, such as <see cref="SSOAWSCredentials"/> when a new SSO token
        /// requires an interactive sign-in, reads this and throws <see cref="CredentialRefreshDeferredException"/>
        /// instead.
        /// </summary>
        internal static bool IsBackgroundRefresh => _backgroundRefreshScope.Value?.Active == true;

        // Calls the credential source for a background refresh, with IsBackgroundRefresh true in that call's flow until
        // the call ends. The scope is set inside this async method, so it flows into the awaited call and does not flow
        // back to the caller, and it is closed when the call ends, so work that the call started and that outlives it
        // sees false.
        private async Task<CredentialsRefreshState> GenerateNewCredentialsInBackgroundAsync()
        {
            var scope = new BackgroundRefreshScope();
            _backgroundRefreshScope.Value = scope;
            try
            {
                return await GenerateNewCredentialsAsync().ConfigureAwait(false);
            }
            finally
            {
                scope.Active = false;
            }
        }

        // Returns e, or the exception it wraps, that signals that the refresh needs the caller, or null. The chain is
        // walked because the signal can arrive wrapped: the STS client of AssumeRoleAWSCredentials wraps the exceptions
        // of its source credentials, and a derived provider can wrap the exceptions of its base class.
        private static CredentialRefreshDeferredException FindRefreshDeferral(Exception e)
        {
            for (var depth = 0; e != null && depth < CredentialRefreshPolicy.MaxInnerExceptionDepth; depth++, e = e.InnerException)
            {
                if (e is CredentialRefreshDeferredException deferral)
                    return deferral;
            }
            return null;
        }

        // Caller holds the semaphore and ran a background refresh of state, which ended because the refresh needs the
        // caller. Records that for state, so that no further background refresh starts for these credentials, and logs
        // it at Info. Nothing else changes: no error is cached, no refresh backoff is applied, and the record of an
        // earlier non-recoverable failure is left as it was.
        private void DeferRefreshToCaller(CredentialsRefreshState state, Exception e)
        {
            if (state == null)
                return;
            Volatile.Write(ref _backgroundRefreshDeferredState, state);
            _logger.InfoFormat(
                "The background credential refresh stopped without refreshing the credentials: {0} " +
                "The credentials will be refreshed when a request for credentials finds them expired, at {1}.",
                e.Message,
                state.ExpirationUtc.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture));
        }

        #endregion

        #region Private/protected credential update methods

        private void ValidateGeneratedCredentials(CredentialsRefreshState state)
        {
            // Check if the new credentials are already expired. Providers that do not opt in to the refresh lifecycle
            // keep the check of earlier versions of the SDK, which accepts credentials that expire exactly now.
            var alreadyExpired = UsesManagedRefreshLifecycle
                ? IsExpired(state)
                : state?.IsExpiredWithin(TimeSpan.Zero) ?? true;
            if (alreadyExpired)
            {
                string errorMessage;
                if (state == null)
                {
                    errorMessage = "Unable to generate temporary credentials";
                }
                else
                {
                    errorMessage = string.Format(CultureInfo.InvariantCulture,
                        "The retrieved credentials have already expired: Now = {0}, Credentials expiration = {1}",
                        _timeProvider.CorrectedUtcNow, state.Expiration);
                }

                throw new AmazonClientException(errorMessage);
            }

            // Preserve the provider-reported expiration (RawExpiration) before the buffer subtraction so the
            // "Expired" state remains expressible, compute the advisory window, subtract the buffer and freeze the
            // derived instants for this credentials generation. All of them are derived from the UTC instant, so
            // they are the same whatever DateTimeKind the source used.
            state.CaptureRawExpiration();
            var advisoryWindow = ResolveAdvisoryWindow(state);
            state.ApplyExpirationBuffer(ExpirationBuffer);
            state.FinalizeWindows(advisoryWindow, _timeProvider);
        }

        /// <summary>
        /// Resolves the advisory (background refresh) window for a freshly generated state: the explicitly set
        /// <see cref="PreemptExpiryTime"/> if a caller set one, otherwise the lifetime table. Providers that do not opt
        /// in to the refresh lifecycle always use <see cref="PreemptExpiryTime"/>, which is zero unless set.
        /// <para />
        /// For the table path the window is measured against the provider-reported (raw) expiration, but
        /// <see cref="CredentialsRefreshState.AdvisoryRefreshAt"/> is derived from <see cref="CredentialsRefreshState.Expiration"/>,
        /// which already has <see cref="ExpirationBuffer"/> subtracted. Subtracting <see cref="ExpirationBuffer"/>
        /// from the table value here cancels that out, so the advisory refresh fires at
        /// <c>RawExpiration - advisoryWindow</c> rather than a buffer's-width too early. Floored at zero.
        /// The explicit-property path is left exactly as the caller set it.
        /// </summary>
        private TimeSpan ResolveAdvisoryWindow(CredentialsRefreshState state)
        {
            var configured = Volatile.Read(ref _configuredPreemptExpiryTime);
            if (configured != null)
                return configured.Value;
            if (!UsesManagedRefreshLifecycle)
                return TimeSpan.Zero;

            var rawLifetime = state.RawExpiration - _timeProvider.CorrectedUtcNow;
            var window = CredentialRefreshPolicy.AdvisoryWindowForLifetime(rawLifetime) - ExpirationBuffer;
            return window < TimeSpan.Zero ? TimeSpan.Zero : window;
        }

        /// <summary>
        /// This property has been marked as Obsolete because it is no longer used for determining
        /// if credentials should be updated. The boolean ShouldUpdate property did not provide 
        /// enough information on whether credentials are expired or in the preempt expiry window.
        /// </summary>
        [Obsolete("Property is no longer used for determining if credentials should be updated.")]
        protected bool ShouldUpdate
        {
            get
            {
                return IsExpired(currentState);
            }
        }

        // The PreemptExpiryTime value that was set, or zero when none was set: the window that providers that do not opt
        // in to the refresh lifecycle use, as in earlier versions of the SDK.
        private TimeSpan ConfiguredPreemptExpiryTimeOrZero => Volatile.Read(ref _configuredPreemptExpiryTime)?.Value ?? TimeSpan.Zero;

        /// <summary>
        /// Test if the credentials are currently stale (expiration at or before now). Used to reject a source
        /// response that arrived already expired -- including the boundary case Expiration == now.
        /// </summary>
        private static bool IsExpired(CredentialsRefreshState state)
        {
            var isExpired = state?.IsStaleAsOfNow();
            return isExpired ?? true;
        }

        private void LogCredentialsExpired(CredentialsRefreshState state)
        {
            if (state == null)
            {
                return;
            }

            _logger.InfoFormat(
                "Determined refreshing credentials should update. Expiration time: {0}, Current time: {1}",
                state.ExpirationUtc.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture),
                _timeProvider.CorrectedUtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture)
            );
        }

        private void LogCredentialsPreemptExpiry(CredentialsRefreshState state)
        {
            if (state == null)
            {
                return;
            }

            // Providers that do not opt in to the refresh lifecycle compute the window from the current
            // PreemptExpiryTime on every call (see ClassifyState).
            var refreshAt = UsesManagedRefreshLifecycle
                ? state.AdvisoryRefreshAt
                : state.ExpirationUtc - ConfiguredPreemptExpiryTimeOrZero;
            _logger.InfoFormat(
                "Determined refreshing credentials are in window for preempt expiration. Advisory refresh time: {0}, Current time: {1}",
                refreshAt.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture),
                _timeProvider.CorrectedUtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture)
            );
        }

        /// <summary>
        /// Returns the cached credentials while the refresh backoff lasts. Logs that it does so at most once per
        /// backoff: every call made during the backoff comes here, and logging each one would flood the log. The
        /// message does not say why the backoff started: a failed refresh starts it, and so does an EC2 instance
        /// metadata provider that uses an already-expired response to its first fetch (see
        /// TryPublishExpiredInitialCredentials), which logs its own message.
        /// </summary>
        private ImmutableCredentials ServeCachedDuringRefreshBackoff(CredentialsRefreshState state, RefreshPhase phase)
        {
            var backoffCount = Volatile.Read(ref _refreshBackoffCount);
            var loggedCount = Volatile.Read(ref _refreshBackoffCountLogged);
            if (backoffCount != loggedCount
                && Interlocked.CompareExchange(ref _refreshBackoffCountLogged, backoffCount, loggedCount) == loggedCount)
            {
                _logger.WarnFormat(
                    "The credential refresh backoff is in effect, so the SDK is using the cached credentials until the refresh backoff ends. " +
                    "Phase: {0}, Credentials expiration: {1}, Current time: {2}. The next refresh attempt is allowed in {3} seconds. " +
                    "This message is logged once per refresh backoff.",
                    phase,
                    state.RawExpiration.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture),
                    _timeProvider.CorrectedUtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture),
                    SecondsUntilNextRefresh().ToString("F0", CultureInfo.InvariantCulture));
            }
            return state.Credentials;
        }

        /// <summary>
        /// Logs a recoverable refresh failure together with when the next refresh will be attempted. MUST be
        /// called AFTER <see cref="SetRefreshBackoff(int)"/> so <see cref="SecondsUntilNextRefresh"/> reflects the
        /// backoff just applied (zero if ClearCredentials ran during the attempt, in which case none was applied).
        /// Called only where the cached credentials are then returned: after a mandatory refresh with static
        /// stability, and after an advisory or background refresh. The message includes the source error, so it is
        /// passed as an argument rather than as the format string.
        /// </summary>
        private void LogRefreshBackoffArmed(Exception e)
        {
            _logger.Warn(e, "{0}", FormatRefreshFailureMessage(e, SecondsUntilNextRefresh()));
        }

        // A recoverable failure of an advisory or background refresh, made while the cached credentials are still
        // valid; the caller then returns those credentials. The refresh backoff is applied, so the next refresh is
        // attempted once it has elapsed.
        private void HandleRecoverableFailureOfValidCredentials(Exception e, int clearCount)
        {
            SetRefreshBackoff(clearCount);
            LogRefreshBackoffArmed(e);
        }

        /// <summary>
        /// Seconds from now until <see cref="_nextRefreshAllowedAtTicks"/>, or 0 when no backoff is armed or it
        /// has already elapsed. Read via Interlocked to match the lock-free writers.
        /// </summary>
        private double SecondsUntilNextRefresh()
        {
            var ticks = Interlocked.Read(ref _nextRefreshAllowedAtTicks);
            if (ticks == 0)
                return 0;
            var remaining = new DateTime(ticks, DateTimeKind.Utc) - _timeProvider.CorrectedUtcNow;
            return remaining > TimeSpan.Zero ? remaining.TotalSeconds : 0;
        }

        /// <summary>
        /// Builds the failed-refresh log line, in the wording the credential refresh specification recommends,
        /// including when the next refresh will be attempted. Extracted (and internal) so the exact format --
        /// specifically that it reports the seconds until the next retry -- is directly unit-testable without capturing
        /// log output. Used only where the cached credentials are returned after the failure.
        /// </summary>
        internal static string FormatRefreshFailureMessage(Exception error, double secondsUntilRetry)
        {
            return string.Format(CultureInfo.InvariantCulture,
                "Credential refresh failed: {0}. The SDK will continue using cached credentials. " +
                "A refresh of these credentials will be attempted again after {1:F0} seconds.",
                error?.Message, secondsUntilRetry);
        }

        #region Refresh backoff

        /// <summary>
        /// True if a recoverable refresh failure has put this provider into refresh backoff. Self-heals: once
        /// the backoff window elapses it clears the backoff and returns false.
        /// </summary>
        private bool IsRefreshRateLimited()
        {
            var ticks = Interlocked.Read(ref _nextRefreshAllowedAtTicks);
            if (ticks == 0)
                return false;
            if (_timeProvider.CorrectedUtcNow.Ticks < ticks)
                return true;
            // The backoff has elapsed. Clear it only if it still holds the value read above: the advisory path
            // calls this without the lock, and a refresh that failed in the meantime may have applied a new
            // backoff, which must not be erased.
            Interlocked.CompareExchange(ref _nextRefreshAllowedAtTicks, 0L, ticks);
            return false;
        }

        // Applies the refresh backoff after a recoverable failure. That failure is now the most recent outcome,
        // so it also clears the record of an earlier non-recoverable failure.
        private void SetRefreshBackoff()
        {
            var until = _timeProvider.CorrectedUtcNow + RefreshBackoffGenerator();
            Interlocked.Exchange(ref _nextRefreshAllowedAtTicks, until.Ticks);
            Interlocked.Increment(ref _refreshBackoffCount);
            Volatile.Write(ref _lastRefreshFailedNonRecoverably, false);
        }

        // Applies the refresh backoff after a recoverable failure of an attempt that read clearCount when it started,
        // unless ClearCredentials has run since then. The backoff is written before the count is checked, with a full
        // fence in between, so a ClearCredentials that the check does not see clears the backoff after it was written.
        private void SetRefreshBackoff(int clearCount)
        {
            SetRefreshBackoff();
            if (ClearedSince(clearCount))
                ClearRefreshBackoff();
        }

        // True when ClearCredentials has run since clearCount was read.
        private bool ClearedSince(int clearCount) => Volatile.Read(ref _clearCount) != clearCount;

        private void ClearRefreshBackoff()
        {
            Interlocked.Exchange(ref _nextRefreshAllowedAtTicks, 0L);
        }

        #endregion

        #region Non-recoverable error classification and cache

        /// <summary>
        /// When overridden in a derived class, returns true if <paramref name="exception"/> means retrying the
        /// credential fetch cannot succeed without external action (an expired SSO or Login token, an STS
        /// AccessDenied, a rejected claim). For the providers that use the credential refresh lifecycle (see
        /// <see cref="UsesManagedRefreshLifecycle"/>), a non-recoverable error is raised immediately
        /// and raised again for the next 1 to 5 seconds without
        /// contacting the credential source; it does not apply the refresh backoff or fall back to cached credentials.
        /// A non-recoverable error that reaches this class wrapped in a plain <see cref="AmazonClientException"/> is
        /// raised as an <see cref="AmazonNonRecoverableCredentialsException"/> with the same message and inner
        /// exception; any other exception is raised unchanged. Other providers raise the exception unchanged and do not
        /// cache it.
        /// <para />
        /// The default implementation inspects <paramref name="exception"/> and its inner exceptions, because the
        /// source error is often wrapped: the STS client wraps both an STS rejection such as AccessDenied and an
        /// <see cref="AmazonNonRecoverableCredentialsException"/> raised by the source credentials of an assume-role
        /// provider in an <see cref="AmazonClientException"/>. It returns true for an
        /// <see cref="AmazonNonRecoverableCredentialsException"/>, or for an <see cref="AmazonServiceException"/> with
        /// one of these error codes: the STS codes <c>AccessDenied</c>, <c>IDPRejectedClaim</c>,
        /// <c>InvalidIdentityToken</c>, <c>MalformedPolicyDocument</c>, <c>PackedPolicyTooLarge</c> and
        /// <c>RegionDisabledException</c>; the SSO <c>UnauthorizedException</c>; and the
        /// Sign-In errors <c>TOKEN_EXPIRED</c>, <c>USER_CREDENTIALS_CHANGED</c> and <c>INSUFFICIENT_PERMISSIONS</c>. The
        /// first service exception in the chain that has an error code decides. Network errors, throttling, and other
        /// service errors are recoverable.
        /// </summary>
        /// <param name="exception">The exception raised while retrieving credentials.</param>
        /// <returns>True if retrying the credential refresh cannot succeed without external action.</returns>
        protected virtual bool IsNonRecoverableError(Exception exception)
        {
            return CredentialRefreshPolicy.IsNonRecoverableError(exception);
        }

        /// <summary>
        /// True when the most recent refresh attempt failed with a non-recoverable error, even after that error's
        /// 1-5 second cache duration has elapsed. Cleared by a success, a recoverable failure, or ClearCredentials.
        /// </summary>
        private bool LastRefreshFailedNonRecoverably => Volatile.Read(ref _lastRefreshFailedNonRecoverably);

        /// <summary>
        /// Returns the cached non-recoverable error if it is still within its cache duration, otherwise null. An
        /// expired entry is removed. Safe to call without holding the semaphore.
        /// </summary>
        private CachedCredentialError GetLiveCachedError()
        {
            var cached = Volatile.Read(ref _cachedError);
            if (cached == null)
                return null;
            if (_timeProvider.CorrectedUtcNow < cached.CachedUntil)
                return cached;

            // Test-only interleaving seam: fires once, between observing the expired entry and clearing it, so a
            // test can cache a fresh replacement at exactly that point and prove the compare-and-swap below does
            // not erase it. Null in production.
            var expiryHook = _cachedErrorExpiryClearHookForTest;
            if (expiryHook != null)
            {
                _cachedErrorExpiryClearHookForTest = null;
                expiryHook();
            }

            // Null the cache only if it still holds the exact expired entry observed above. A refresh can cache a
            // fresh non-recoverable error between that read and this clear; an unconditional write would erase
            // it, and the next call would contact the source instead of raising it.
            Interlocked.CompareExchange(ref _cachedError, null, cached);
            return null;
        }

        private void ThrowIfNonRecoverableErrorCached()
        {
            // Rethrows the capture taken when the error was cached, which preserves the original stack trace and
            // keeps it from growing with every caller that receives the cached error.
            GetLiveCachedError()?.Error.Throw();
        }

        // Caches the non-recoverable error of an attempt that read clearCount when it started. If ClearCredentials has
        // run since then, the reset wins and the error is removed again. It is written before the count is checked,
        // with a full fence in between, so a ClearCredentials that the check does not see clears it after it was
        // written.
        private void CacheNonRecoverableError(Exception e, int clearCount)
        {
            var entry = new CachedCredentialError(e, _timeProvider.CorrectedUtcNow + NonRecoverableErrorCacheGenerator());
            Volatile.Write(ref _lastRefreshFailedNonRecoverably, true);
            Interlocked.Exchange(ref _cachedError, entry);
            if (ClearedSince(clearCount))
            {
                Volatile.Write(ref _lastRefreshFailedNonRecoverably, false);
                Interlocked.CompareExchange(ref _cachedError, null, entry);
            }
        }

        // Handles a refresh of a provider that opts in to the refresh lifecycle and failed with the non-recoverable
        // error e: caches the exception to raise (see AsNonRecoverableException) and returns it.
        private Exception CacheNonRecoverableFailure(Exception e, int clearCount)
        {
            var raised = AsNonRecoverableException(e);
            CacheNonRecoverableError(raised, clearCount);
            return raised;
        }

        // Handles an on-demand refresh (initial, mandatory or advisory) that failed with the non-recoverable error e,
        // and returns the exception the caller throws instead of e, or null when the caller rethrows e itself with
        // "throw;", which keeps its stack trace. Providers that opt in to the refresh lifecycle cache the exception to
        // raise (see CacheNonRecoverableFailure); other providers raise e unchanged and cache nothing.
        private Exception OnNonRecoverableRefreshFailure(Exception e, int clearCount)
        {
            if (!UsesManagedRefreshLifecycle)
                return null;
            var raised = CacheNonRecoverableFailure(e, clearCount);
            return ReferenceEquals(raised, e) ? null : raised;
        }

        /// <summary>
        /// Returns the exception to raise for a refresh that failed with the non-recoverable error
        /// <paramref name="e"/>. When the credential source wrapped the error in a plain
        /// <see cref="AmazonClientException"/> -- as the STS client does with an STS rejection such as AccessDenied,
        /// and with a non-recoverable error raised by the source credentials of an assume-role provider -- this is an
        /// <see cref="AmazonNonRecoverableCredentialsException"/> with the same message and the same inner exception,
        /// so the error can be caught by that type. It derives from <see cref="AmazonClientException"/>, so handlers
        /// for the wrapper still catch it. Any other exception, including a service exception that a provider
        /// classifies as non-recoverable, is returned unchanged.
        /// </summary>
        private static Exception AsNonRecoverableException(Exception e)
        {
            if (e.GetType() != typeof(AmazonClientException) || e.InnerException == null)
                return e;
            return new AmazonNonRecoverableCredentialsException(e.Message, e.InnerException);
        }

        #endregion

        #region Invalidate

        /// <summary>
        /// Whether the request pipeline calls <see cref="Invalidate"/> and retries the request when a service
        /// rejects these credentials with <c>ExpiredToken</c> or <c>ExpiredTokenException</c>. True only for providers that opt
        /// in to the refresh lifecycle (<see cref="UsesManagedRefreshLifecycle"/>); other providers keep
        /// their existing behavior for these errors.
        /// </summary>
        internal bool SupportsInvalidationOnAuthFailure => UsesManagedRefreshLifecycle;

        /// <summary>
        /// Marks the cached credentials as expired if they are the credentials that a service rejected, so the next
        /// call performs a mandatory refresh instead of returning them. The SDK calls this for the providers that use
        /// the credential refresh lifecycle (see <see cref="UsesManagedRefreshLifecycle"/>) when a
        /// service rejects a request with <c>ExpiredToken</c> or <c>ExpiredTokenException</c>. If you call it yourself, pass the
        /// credentials that were used to sign the rejected request, not credentials obtained afterwards, so that
        /// credentials that have already been refreshed are not invalidated.
        /// <para />
        /// This is best effort and does not wait. It does nothing if the refresh lock is held at that moment, for
        /// example by a refresh in progress, which usually replaces the credentials; if no credentials are cached; if
        /// the cached credentials have a different access key ID (they were already refreshed; only the access key ID
        /// is compared); if the cached credentials are cleared or replaced while this call runs; or if this instance
        /// has been disposed. It does not bypass the refresh backoff: while a backoff is in effect, the next call
        /// returns the same cached credentials. This implementation never throws.
        /// </summary>
        /// <param name="rejectedCredentials">The credentials that were used to sign the rejected request. A
        /// <c>null</c> value is ignored.</param>
        public virtual void Invalidate(ImmutableCredentials rejectedCredentials)
        {
            if (rejectedCredentials == null || _disposed)
                return;

            // try_acquire only. If a refresh already holds the lock it will produce credentials newer than the
            // rejected ones anyway, and blocking here would put credential work on an error path where the
            // caller never asked to wait. A rejection that arrives while the lock is held is dropped.
            bool acquired;
            try
            {
                acquired = _updateGeneratedCredentialsSemaphore.Wait(TimeSpan.Zero);
            }
            catch (ObjectDisposedException)
            {
                return; // disposed after the check above
            }
            if (!acquired)
                return;

            try
            {
                var state = currentState;
                if (state?.Credentials == null)
                    return;

                // Ordinal comparison: access key IDs are case-sensitive, and a culture-aware or
                // case-insensitive compare could wrongly invalidate freshly refreshed credentials.
                if (!string.Equals(state.Credentials.AccessKey, rejectedCredentials.AccessKey, StringComparison.Ordinal))
                    return; // already refreshed -- nothing to do

                // Swap in a NEW expired-at-now state rather than mutating the published instance: the fast path
                // reads its DateTime fields lock-free, and a DateTime write is not atomic on 32-bit runtimes, so
                // an in-place mutation could be observed torn. Invalidate() deliberately does NOT clear or bypass
                // the refresh backoff: routing to the mandatory path is enough; if backoff is active the next
                // GetCredentials() correctly returns cached credentials via the rate-limit gate.
                //
                // ClearCredentials, and a subclass that assigns currentState directly, write the field without
                // the lock. Replace the state only if it is still the one compared above, so credentials that
                // were cleared or replaced in the meantime are not brought back as an expired copy.
                var expired = state.WithExpiredAt(_timeProvider.CorrectedUtcNow);
                if (!ReferenceEquals(Interlocked.CompareExchange(ref currentState, expired, state), state))
                    return;
                _logger.InfoFormat(
                    "Credentials with access key ending {0} were rejected by the service; marking them expired so the next call refreshes.",
                    Redact(rejectedCredentials.AccessKey));
            }
            finally
            {
                try
                {
                    _updateGeneratedCredentialsSemaphore.Release();
                }
                catch (ObjectDisposedException)
                {
                    // Dispose ran while this call held the lock; there is nothing left to release.
                }
            }
        }

        private static string Redact(string accessKey)
        {
            if (string.IsNullOrEmpty(accessKey) || accessKey.Length <= 4)
                return "****";
            return "****" + accessKey.Substring(accessKey.Length - 4);
        }

        #endregion

        #region Success publication

        /// <summary>
        /// The single success funnel for a completed refresh. Every path that installs freshly generated
        /// credentials -- initial fetch, mandatory refresh, advisory and background refresh, and the
        /// minimum-lifetime overloads -- routes through here so the ordering below is identical everywhere. All
        /// callers hold <see cref="_updateGeneratedCredentialsSemaphore"/>.
        /// <para />
        /// A successful fetch or refresh clears the cached non-recoverable error, even while its 1-5 second cache
        /// duration is still running; otherwise the next caller could rethrow a stale error despite fresh
        /// credentials being cached. The error is cleared before <see cref="currentState"/> is replaced, so any
        /// thread that observes the fresh state (an acquiring read of the volatile field) also observes the cleared
        /// error. The refresh backoff is then cleared, and so is the record that a background refresh of the previous
        /// credentials needed the caller (see <see cref="CredentialRefreshDeferredException"/>). This method is
        /// intentionally not gated by <see cref="UsesManagedRefreshLifecycle"/>: installing fresh credentials on success
        /// is correct for every provider.
        /// </summary>
        private void PublishRefreshSuccess(CredentialsRefreshState newState)
        {
            Volatile.Write(ref _cachedError, null);
            Volatile.Write(ref _lastRefreshFailedNonRecoverably, false);
            currentState = newState;
            ClearRefreshBackoff();
            Volatile.Write(ref _backgroundRefreshDeferredState, null);
        }

        // Test-only seams for the cached-error / success-funnel interaction. All of them invoke the real
        // production methods, so a test observes production behavior rather than a reimplementation.
        internal bool HasCachedErrorForTest => Volatile.Read(ref _cachedError) != null;
        internal void CacheNonRecoverableErrorForTest(Exception e) => CacheNonRecoverableError(e, Volatile.Read(ref _clearCount));
        internal void PublishRefreshSuccessForTest(CredentialsRefreshState newState) => PublishRefreshSuccess(newState);

        // Test-only seam invoking the real expiry-clear/rethrow gate, so a test can exercise the compare-and-swap
        // expiry clear directly without driving a full resolution that would publish fresh credentials and clear
        // the cache first.
        internal void ThrowIfNonRecoverableErrorCachedForTest() => ThrowIfNonRecoverableErrorCached();

        // Test-only interleaving seam for the expiry clear. Null in production; fires once inside
        // GetLiveCachedError, after an expired entry is observed but before the compare-and-swap that clears it,
        // so a test can cache a fresh replacement in exactly that window.
        internal Action _cachedErrorExpiryClearHookForTest;

        #endregion

        /// <summary>
        /// When overridden in a derived class, generates new credentials and new expiration date.
        /// 
        /// Called on first credentials request and when expiration date is in the past.
        /// </summary>
        /// <returns></returns>
        protected virtual CredentialsRefreshState GenerateNewCredentials()
        {
            throw new NotImplementedException();
        }

        /// <summary> 
        /// When overridden in a derived class, generates new credentials and new expiration date.
        /// 
        /// Called on first credentials request and when expiration date is in the past.
        /// </summary>
        /// <returns></returns>
        protected virtual Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
        {
            return Task.Run(() => this.GenerateNewCredentials());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            // Set before the semaphore is disposed, so Invalidate, which checks this flag, stops using the
            // semaphore as early as possible. Invalidate also tolerates a Dispose that races past the check.
            _disposed = true;

            if (disposing)
            {
                _scheduledRefreshTimer?.Dispose();
                _updateGeneratedCredentialsSemaphore.Dispose();
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Clears currently-stored credentials, forcing the next GetCredentials call to generate new credentials.
        /// Also clears any cached non-recoverable error and refresh backoff, because a caller invoking this is
        /// explicitly asking to start over. A refresh that is already running when this is called and then fails
        /// does not cache its error or apply the refresh backoff.
        /// </summary>
        public virtual void ClearCredentials()
        {
            // Counted before anything is cleared: a refresh attempt that fails after this point either sees the new
            // count and records nothing, or recorded its failure before the fields below are cleared.
            Interlocked.Increment(ref _clearCount);
            currentState = null;
            Volatile.Write(ref _cachedError, null);
            Volatile.Write(ref _lastRefreshFailedNonRecoverably, false);
            ClearRefreshBackoff();
            Volatile.Write(ref _backgroundRefreshDeferredState, null);
        }

        /// <summary>
        /// Returns credentials that remain valid for at least <paramref name="minimumLifetime"/> when the credential
        /// provider can supply them, regenerating the current credentials if they would expire sooner. This lets callers
        /// such as the RDS and DSQL auth-token generators ensure the generated token stays valid for its full lifetime.
        /// If the regenerated credentials still expire within <paramref name="minimumLifetime"/> (for example, the
        /// requested lifetime exceeds the provider's maximum session duration), they are returned anyway and an
        /// informational message is logged. Exceptions thrown while regenerating the credentials propagate to the caller,
        /// except for the EC2 instance metadata providers, which behave as <see cref="GetCredentials()"/> (see below).
        /// <para />
        /// Except for the EC2 instance metadata providers (see below), this method is not limited by the refresh backoff
        /// and does not apply it: every call that finds the cached
        /// credentials too close to expiry contacts the credential source, and a failure is thrown to the caller rather
        /// than returning the cached credentials. A non-recoverable error is raised as <see cref="GetCredentials()"/>
        /// raises it, but it is not cached.
        /// <para />
        /// The EC2 instance metadata providers, such as <see cref="InstanceProfileAWSCredentials"/>, do not apply
        /// <paramref name="minimumLifetime"/>: the instance metadata service returns the same credentials until it rotates
        /// them, so it cannot supply longer-lived credentials on request. For these providers this method behaves exactly
        /// as <see cref="GetCredentials()"/>, including its background refresh, its refresh backoff, and the cached
        /// credentials it returns when a refresh fails, so the credentials it returns can expire within
        /// <paramref name="minimumLifetime"/>.
        /// </summary>
        public ImmutableCredentials GetCredentials(TimeSpan minimumLifetime)
        {
            if (minimumLifetime < TimeSpan.Zero)
                throw new ArgumentOutOfRangeException("minimumLifetime", "minimumLifetime cannot be negative");

            if (!SupportsMinimumLifetimeRefresh)
                return GetCredentials();

            // Lock-free fast path, mirroring GetCredentials: most calls will find credentials
            // that already satisfy the minimum lifetime.
            var tempState = currentState;
            if (tempState != null && !tempState.IsExpiredWithin(minimumLifetime))
                return tempState.Credentials;

            _updateGeneratedCredentialsSemaphore.Wait();
            try
            {
                // Re-check under the lock in case another thread refreshed first.
                tempState = currentState;
                if (tempState != null && !tempState.IsExpiredWithin(minimumLifetime))
                    return tempState.Credentials;

                var newState = GenerateNewCredentials();
                ValidateGeneratedCredentials(newState);
                LogCredentialsBelowMinimumLifetime(newState, minimumLifetime);

                // The background single-flight guard is intentionally not touched here: if a background
                // refresh is in flight it manages its own lifecycle and resets the guard when it completes.
                PublishRefreshSuccess(newState);
                return newState.Credentials;
            }
            catch (Exception e) when (FindRefreshDeferral(e) != null)
            {
                // Passed on unchanged, not raised as a non-recoverable error; see FetchInitialCredentials.
                throw;
            }
            catch (Exception e) when (UsesManagedRefreshLifecycle && IsNonRecoverableError(e))
            {
                // Raised as the same exception type as on the other paths. Not cached: this method contacts the
                // credential source on every call that needs a refresh, as in earlier versions of the SDK.
                var raised = AsNonRecoverableException(e);
                if (ReferenceEquals(raised, e))
                    throw;
                throw raised;
            }
            finally
            {
                _updateGeneratedCredentialsSemaphore.Release();
            }
        }

        /// <inheritdoc cref="GetCredentials(TimeSpan)"/>
        public async Task<ImmutableCredentials> GetCredentialsAsync(TimeSpan minimumLifetime)
        {
            if (minimumLifetime < TimeSpan.Zero)
                throw new ArgumentOutOfRangeException("minimumLifetime", "minimumLifetime cannot be negative");

            if (!SupportsMinimumLifetimeRefresh)
                return await GetCredentialsAsync().ConfigureAwait(false);

            // Lock-free fast path, mirroring GetCredentialsAsync: most calls will find credentials
            // that already satisfy the minimum lifetime.
            var tempState = currentState;
            if (tempState != null && !tempState.IsExpiredWithin(minimumLifetime))
                return tempState.Credentials;

            await _updateGeneratedCredentialsSemaphore.WaitAsync().ConfigureAwait(false);
            try
            {
                // Re-check under the lock in case another thread refreshed first.
                tempState = currentState;
                if (tempState != null && !tempState.IsExpiredWithin(minimumLifetime))
                    return tempState.Credentials;

                var newState = await GenerateNewCredentialsAsync().ConfigureAwait(false);
                ValidateGeneratedCredentials(newState);
                LogCredentialsBelowMinimumLifetime(newState, minimumLifetime);

                // The background single-flight guard is intentionally not touched here: if a background
                // refresh is in flight it manages its own lifecycle and resets the guard when it completes.
                PublishRefreshSuccess(newState);
                return newState.Credentials;
            }
            catch (Exception e) when (FindRefreshDeferral(e) != null)
            {
                throw;
            }
            catch (Exception e) when (UsesManagedRefreshLifecycle && IsNonRecoverableError(e))
            {
                var raised = AsNonRecoverableException(e);
                if (ReferenceEquals(raised, e))
                    throw;
                throw raised;
            }
            finally
            {
                _updateGeneratedCredentialsSemaphore.Release();
            }
        }

        /// <summary>
        /// False for providers whose credential source cannot supply longer-lived credentials on request. For them
        /// <see cref="GetCredentials(TimeSpan)"/> and <see cref="GetCredentialsAsync(TimeSpan)"/> behave exactly as
        /// <see cref="GetCredentials()"/> and <see cref="GetCredentialsAsync()"/>. The EC2 instance metadata (IMDS)
        /// providers return false: IMDS returns the same credentials until it rotates them, so asking it again for
        /// credentials that last longer only adds IMDS calls. Every other provider returns true.
        /// </summary>
        internal virtual bool SupportsMinimumLifetimeRefresh => true;

        private void LogCredentialsBelowMinimumLifetime(CredentialsRefreshState state, TimeSpan minimumLifetime)
        {
            if (!state.IsExpiredWithin(minimumLifetime))
            {
                return;
            }

            _logger.InfoFormat(
                "Newly generated credentials expire at {0}, which does not satisfy the requested minimum lifetime of {1}. " +
                "This typically means the requested lifetime exceeds the credential provider's maximum session duration.",
                state.ExpirationUtc.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture),
                minimumLifetime
            );
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}