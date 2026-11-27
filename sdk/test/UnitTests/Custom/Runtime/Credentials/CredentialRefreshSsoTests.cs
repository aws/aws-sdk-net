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
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Logging;
using Amazon.Runtime.SharedInterfaces;
using Amazon.RuntimeDependencies;
using Amazon.SecurityToken;
using Amazon.Util;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// A background refresh never starts an interactive sign-in:
    /// <list type="bullet">
    /// <item>When a background refresh of <see cref="SSOAWSCredentials"/> with SupportsGettingNewToken = true would need
    /// a new SSO token, it ends without calling SSO OIDC or the sign-in callback, without caching an error, applying the
    /// refresh backoff or logging a warning, and no further background refresh starts for those credentials. The next
    /// call that finds the credentials at their expiration starts the sign-in, on the caller's thread.</item>
    /// <item>A background refresh that can refresh the SSO token with its refresh token does so without any
    /// interaction.</item>
    /// <item><see cref="SSOTokenManager"/> does not start the sign-in on any of its paths when the request defers it.</item>
    /// <item><see cref="RefreshingAWSCredentials"/> ends a background refresh whose credential source needs the caller
    /// without recording a failure, for that set of credentials only, and marks only its background refresh as
    /// one.</item>
    /// <item>The same holds when the SSO credentials are the credential source of another provider, such as
    /// <see cref="AssumeRoleAWSCredentials"/>: that provider's background refresh does not start the sign-in either, and
    /// every provider it calls passes the signal on unchanged, without recording a failure. The call that finds that
    /// provider's credentials at their expiration signs in, on the caller's thread.</item>
    /// <item>The signal is scoped to the logical call flow of the background refresh and ends with its call to the
    /// credential source: a call on another thread while a background refresh runs, a call that waits for a refresh
    /// lock that the background refresh holds, the refresh that a call in the advisory window makes while it waits, and
    /// work that the background refresh started once that call has ended, still sign in.</item>
    /// </list>
    /// The SSO token manager and its token file cache are the real classes, over an in-memory file system and test
    /// doubles for SSO OIDC and SSO. The SSO token manager checks token expirations against the SDK clock, so tokens
    /// expire relative to the current time, and the fake clock of the credential lifecycle starts at the current time.
    /// A background refresh is awaited by polling for the provider to become idle, with a timeout that only elapses when
    /// a test fails; no test sleeps.
    /// </summary>
    [TestClass]
    [DoNotParallelize]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class CredentialRefreshSsoTests
    {
        private const string AccountId = "123456789012";
        private const string RoleName = "TestRole";
        private const string SsoRegion = "us-west-2";
        private const string StartUrl = "https://d-abc123.awsapps.com/start";
        private const string SignedInAccessToken = "signed-in-token";
        private const string DeferredSignInText = "requires an interactive sign-in";

        private static readonly TimeSpan RoleCredentialLifetime = TimeSpan.FromMinutes(60);
        // Longer than any interval in these tests, so a refresh backoff that was applied would still be in effect when a
        // test checks that the next refresh runs.
        private static readonly TimeSpan Backoff = TimeSpan.FromHours(3);
        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(30);

        #region SSOAWSCredentials

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task BackgroundRefresh_NewSsoTokenNeedsSignIn_EndsQuietly_AndTheCallAtExpirationSignsIn(bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var sso = new SsoHarness();
                // A token that expires in a few minutes and cannot be refreshed: it is used, and read from the token file
                // again on the next request, as a token that does not need a refresh would not be.
                sso.WriteToken(LegacyToken("session-1", DateTime.UtcNow.AddMinutes(3)));
                var creds = sso.NewCredentials();
                var cached = await Get(creds, useAsync); // expires at start + 60m; background refresh from start + 45m
                Assert.AreEqual(1, sso.TokenRequests.Count);

                sso.WriteToken(LegacyToken("session-1", ExpiredLongAgo)); // the SSO session has ended
                sso.Clock.Now = sso.At(50);
                Assert.AreSame(cached, await Get(creds, useAsync), "the cached credentials are returned while the refresh runs");
                WaitUntilIdle(creds);

                CollectionAssert.AreEqual(new[] { false, true }, sso.TokenRequests.ToList(),
                    "the second token request was made by the background refresh, which defers the sign-in");
                Assert.AreEqual(0, sso.SignInThreadIds.Count, "the background refresh did not start the sign-in");
                sso.Oidc.Verify(x => x.GetSsoTokenAsync(It.IsAny<GetSsoTokenRequest>()), Times.Never());
                Assert.AreEqual(1, sso.RoleCredentialRequests, "the background refresh ended before it asked SSO for credentials");
                Assert.IsFalse(creds.HasCachedErrorForTest, "no error is cached");
                Assert.IsFalse(log.Entries.Any(e => e.Level == SdkLogLevel.Warn || e.Level == SdkLogLevel.Error),
                    "nothing is logged as a failure: " + string.Join(" | ", log.Entries.Select(e => e.Message)));
                var deferral = log.Entries.Single(e => e.Message.Contains(DeferredSignInText));
                Assert.AreEqual(SdkLogLevel.Info, deferral.Level);

                sso.Clock.Now = sso.At(55); // still inside the background refresh window
                Assert.AreSame(cached, await Get(creds, useAsync));
                Assert.AreSame(cached, await Get(creds, useAsync));
                WaitUntilIdle(creds);
                Assert.AreEqual(2, sso.TokenRequests.Count, "no further background refresh starts for these credentials");

                // At Expiration the call waits for the refresh, which starts the sign-in on the caller's thread. A refresh
                // backoff, had one been applied at start + 50m, would still be in effect and return the cached credentials.
                sso.Clock.Now = sso.At(59.5);
                var callerThreadId = Thread.CurrentThread.ManagedThreadId;
                var refreshed = useAsync ? await creds.GetCredentialsAsync() : creds.GetCredentials();
                Assert.AreNotSame(cached, refreshed);
                Assert.AreEqual("AKIA_" + SignedInAccessToken, refreshed.AccessKey);
                CollectionAssert.AreEqual(new[] { callerThreadId }, sso.SignInThreadIds.ToList(),
                    "the sign-in callback ran once, on the caller's thread");
                Assert.IsFalse(sso.TokenRequests.Last(), "the call's token request does not defer the sign-in");
            }
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task BackgroundRefresh_SsoTokenRefreshedWithRefreshToken_WorksWithoutInteraction(bool useAsync)
        {
            var sso = new SsoHarness();
            // The access token has expired and the refresh token is valid. Each refresh returns an access token that
            // expires in a few minutes, so every request for a token refreshes it again with the refresh token.
            sso.WriteToken(RefreshableToken("cached-token", ExpiredLongAgo));
            var creds = sso.NewCredentials();
            var cached = await Get(creds, useAsync);
            Assert.AreEqual("AKIA_refreshed-1", cached.AccessKey);

            sso.Clock.Now = sso.At(50);
            Assert.AreSame(cached, await Get(creds, useAsync), "the cached credentials are returned while the refresh runs");
            WaitUntilIdle(creds);

            CollectionAssert.AreEqual(new[] { false, true }, sso.TokenRequests.ToList(), "the second token request is the background refresh's");
            Assert.AreEqual(2, sso.TokenRefreshes);
            var refreshed = await Get(creds, useAsync);
            Assert.AreEqual("AKIA_refreshed-2", refreshed.AccessKey, "the background refresh replaced the credentials");
            Assert.AreEqual(0, sso.SignInThreadIds.Count, "no sign-in was needed");
            sso.Oidc.Verify(x => x.GetSsoTokenAsync(It.IsAny<GetSsoTokenRequest>()), Times.Never());
        }

#if NETFRAMEWORK
        // On .NET Framework the synchronous refresh of SSOAWSCredentials requests its token through the synchronous
        // SSOTokenManager.GetToken. A derived class whose asynchronous refresh runs the synchronous one gets the same
        // behavior in a background refresh as the asynchronous path.
        [TestMethod]
        public void BackgroundRefresh_ThroughTheSynchronousRefresh_NewSsoTokenNeedsSignIn_EndsQuietly()
        {
            var sso = new SsoHarness();
            sso.WriteToken(LegacyToken("session-1", DateTime.UtcNow.AddMinutes(3)));
            var creds = sso.NewCredentials(refreshThroughTheSynchronousRefresh: true);
            var cached = creds.GetCredentials(); // expires at start + 60m; background refresh from start + 45m

            sso.WriteToken(LegacyToken("session-1", ExpiredLongAgo)); // the SSO session has ended
            sso.Clock.Now = sso.At(50);
            Assert.AreSame(cached, creds.GetCredentials(), "the cached credentials are returned while the refresh runs");
            WaitUntilIdle(creds);

            CollectionAssert.AreEqual(new[] { false, true }, sso.TokenRequests.ToList(),
                "the second token request was made by the background refresh, which defers the sign-in");
            Assert.AreEqual(0, sso.SignInThreadIds.Count, "the background refresh did not start the sign-in");
            sso.Oidc.Verify(x => x.GetSsoToken(It.IsAny<GetSsoTokenRequest>()), Times.Never());
            Assert.IsFalse(creds.HasCachedErrorForTest, "no error is cached");

            sso.Clock.Now = sso.At(59.5); // at Expiration the call signs in, on the caller's thread
            var callerThreadId = Thread.CurrentThread.ManagedThreadId;
            var refreshed = creds.GetCredentials();
            Assert.AreEqual("AKIA_" + SignedInAccessToken, refreshed.AccessKey);
            CollectionAssert.AreEqual(new[] { callerThreadId }, sso.SignInThreadIds.ToList(),
                "the sign-in callback ran once, on the caller's thread");
        }
#endif

        #endregion

        #region SSOTokenManager

        public enum SignInScenario
        {
            NoCachedToken,
            ExpiredTokenWithoutRefreshToken,
            ExpiredTokenWhoseRefreshFails,
            ClientRegistrationExpired,
        }

        // Every path on which the SSO token manager needs a new token. With the sign-in deferred it throws before it calls
        // SSO OIDC or the callback; without, the same request signs in, which shows that the scenario needs the sign-in.
        [TestMethod]
        [DataRow(SignInScenario.NoCachedToken)]
        [DataRow(SignInScenario.ExpiredTokenWithoutRefreshToken)]
        [DataRow(SignInScenario.ExpiredTokenWhoseRefreshFails)]
        [DataRow(SignInScenario.ClientRegistrationExpired)]
        public async Task SsoTokenManager_SignInDeferred_ThrowsWithoutStartingTheSignIn_Async(SignInScenario scenario)
        {
            var sso = new SsoHarness();
            sso.Arrange(scenario);

            var deferral = await Assert.ThrowsExactlyAsync<CredentialRefreshDeferredException>(
                () => sso.Manager.GetTokenAsync(sso.TokenOptions(deferInteractiveSignIn: true)));
            StringAssert.Contains(deferral.Message, DeferredSignInText);
            Assert.AreEqual(0, sso.SignInThreadIds.Count, "the sign-in callback was not called");
            sso.Oidc.Verify(x => x.GetSsoTokenAsync(It.IsAny<GetSsoTokenRequest>()), Times.Never());

            var token = await sso.Manager.GetTokenAsync(sso.TokenOptions(deferInteractiveSignIn: false));
            Assert.AreEqual(SignedInAccessToken, token.AccessToken);
            Assert.AreEqual(1, sso.SignInThreadIds.Count, "without the deferral the same request signs in");
        }

#if NETFRAMEWORK
        // The synchronous SSOTokenManager.GetToken exists only on .NET Framework.
        [TestMethod]
        [DataRow(SignInScenario.NoCachedToken)]
        [DataRow(SignInScenario.ExpiredTokenWithoutRefreshToken)]
        [DataRow(SignInScenario.ExpiredTokenWhoseRefreshFails)]
        [DataRow(SignInScenario.ClientRegistrationExpired)]
        public void SsoTokenManager_SignInDeferred_ThrowsWithoutStartingTheSignIn(SignInScenario scenario)
        {
            var sso = new SsoHarness();
            sso.Arrange(scenario);

            var deferral = Assert.ThrowsExactly<CredentialRefreshDeferredException>(
                () => sso.Manager.GetToken(sso.TokenOptions(deferInteractiveSignIn: true)));
            StringAssert.Contains(deferral.Message, DeferredSignInText);
            Assert.AreEqual(0, sso.SignInThreadIds.Count, "the sign-in callback was not called");
            sso.Oidc.Verify(x => x.GetSsoToken(It.IsAny<GetSsoTokenRequest>()), Times.Never());

            var token = sso.Manager.GetToken(sso.TokenOptions(deferInteractiveSignIn: false));
            Assert.AreEqual(SignedInAccessToken, token.AccessToken);
            Assert.AreEqual(1, sso.SignInThreadIds.Count, "without the deferral the same request signs in");
        }
#endif

        #endregion

        #region RefreshingAWSCredentials

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task BackgroundRefresh_SourceNeedsTheCaller_EndsWithoutRecordingAFailure_ForThoseCredentialsOnly(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CallerOnlyCredentials(clock) { NeedsCaller = true };
            var gen1 = await Get(creds, useAsync); // T0+60m; background refresh from T0+45m

            clock.Now = T0 + TimeSpan.FromMinutes(50);
            Assert.AreSame(gen1, await Get(creds, useAsync));
            WaitUntilIdle(creds);
            CollectionAssert.AreEqual(new[] { false, true }, creds.BackgroundFlags.ToList(),
                "only the background refresh runs as one");
            Assert.IsFalse(creds.HasCachedErrorForTest, "no error is cached");

            clock.Now = T0 + TimeSpan.FromMinutes(52);
            Assert.AreSame(gen1, await Get(creds, useAsync));
            WaitUntilIdle(creds);
            Assert.AreEqual(2, creds.BackgroundFlags.Count, "no further background refresh starts for these credentials");

            // At Expiration the call refreshes while it waits; no refresh backoff is in effect.
            clock.Now = T0 + TimeSpan.FromMinutes(59.5);
            var gen2 = await Get(creds, useAsync);
            Assert.AreNotSame(gen1, gen2);
            Assert.IsFalse(creds.BackgroundFlags.Last(), "the call's own refresh does not run as a background refresh");

            // New credentials get their own background refresh, which again ends because it needs the caller.
            clock.Now = T0 + TimeSpan.FromMinutes(59.5 + 50);
            Assert.AreSame(gen2, await Get(creds, useAsync));
            WaitUntilIdle(creds);
            CollectionAssert.AreEqual(new[] { false, true, false, true }, creds.BackgroundFlags.ToList());
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task BackgroundRefresh_SourceDoesNotNeedTheCaller_RefreshesInTheBackground(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CallerOnlyCredentials(clock) { NeedsCaller = false };
            var gen1 = await Get(creds, useAsync);
            Assert.IsFalse(RefreshingAWSCredentials.IsBackgroundRefresh, "false outside a refresh");

            clock.Now = T0 + TimeSpan.FromMinutes(50);
            Assert.AreSame(gen1, await Get(creds, useAsync));
            WaitUntilIdle(creds);
            CollectionAssert.AreEqual(new[] { false, true }, creds.BackgroundFlags.ToList());
            Assert.AreNotSame(gen1, await Get(creds, useAsync), "the background refresh replaced the credentials");
            Assert.IsFalse(RefreshingAWSCredentials.IsBackgroundRefresh, "the background refresh's value does not flow back to callers");
        }

        // After a background refresh failed with a non-recoverable error, a call in the advisory window refreshes while it
        // waits. That refresh runs for the caller, not as a background refresh, so a source that needs the caller works.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task AdvisoryCall_AfterANonRecoverableBackgroundError_RefreshesForTheCaller(bool useAsync)
        {
            var clock = new TestClock(T0);
            var creds = new CallerOnlyCredentials(clock) { NeedsCaller = true };
            creds.NonRecoverableErrorCacheGenerator = () => TimeSpan.FromSeconds(1);
            var gen1 = await Get(creds, useAsync); // T0+60m; background refresh from T0+45m

            creds.NextBackgroundError = new AmazonNonRecoverableCredentialsException("The session has ended.");
            clock.Now = T0 + TimeSpan.FromMinutes(50);
            Assert.AreSame(gen1, await Get(creds, useAsync));
            WaitUntilIdle(creds);
            Assert.IsTrue(creds.HasCachedErrorForTest, "the background refresh failed with a non-recoverable error");

            clock.Now = T0 + TimeSpan.FromMinutes(50) + TimeSpan.FromSeconds(2); // the error is no longer raised
            var gen2 = await Get(creds, useAsync);
            Assert.AreNotSame(gen1, gen2, "the call refreshed while it waited");
            CollectionAssert.AreEqual(new[] { false, true, false }, creds.BackgroundFlags.ToList(),
                "the call's refresh does not run as a background refresh");
        }

        // The background refresh signal belongs to the logical call flow of that refresh. While a background refresh of
        // one provider runs, a call on another thread that needs a new SSO token signs in.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task OnDemandCall_WhileAnotherProvidersBackgroundRefreshRuns_SignsIn(bool useAsync)
        {
            var clock = new TestClock(T0);
            using (var busy = new GatedCredentials(clock))
            {
                var busyCached = await Get(busy, useAsync); // T0+60m; background refresh from T0+45m
                clock.Now = T0 + TimeSpan.FromMinutes(50);
                Assert.AreSame(busyCached, await Get(busy, useAsync));
                Assert.IsTrue(busy.BackgroundRefreshStarted.Wait(WaitTimeout), "the background refresh did not start");
                try
                {
                    Assert.IsTrue(busy.RanAsBackgroundRefresh, "the other provider's refresh runs as a background refresh");
                    Assert.IsFalse(RefreshingAWSCredentials.IsBackgroundRefresh, "false on this thread");

                    var sso = new SsoHarness();
                    sso.WriteToken(LegacyToken("session-1", ExpiredLongAgo)); // the first call needs a new SSO token
                    var ssoCreds = sso.NewCredentials();
                    var callerThreadId = Thread.CurrentThread.ManagedThreadId;
                    var credentials = useAsync ? await ssoCreds.GetCredentialsAsync() : ssoCreds.GetCredentials();

                    Assert.AreEqual("AKIA_" + SignedInAccessToken, credentials.AccessKey);
                    CollectionAssert.AreEqual(new[] { callerThreadId }, sso.SignInThreadIds.ToList(),
                        "the sign-in callback ran once, on the caller's thread");
                    CollectionAssert.AreEqual(new[] { false }, sso.TokenRequests.ToList(), "the call's token request does not defer the sign-in");
                    Assert.IsTrue(RefreshingCredentialsTestProbes.IsBackgroundRefreshInFlight(busy),
                        "the other provider's background refresh was still running");
                }
                finally
                {
                    busy.Release.Set();
                }
                WaitUntilIdle(busy);
                Assert.AreNotSame(busyCached, await Get(busy, useAsync), "the other provider's background refresh then finished");
            }
        }

        // The signal ends when the background refresh's call to its credential source ends. Work that the call starts and
        // that outlives it, such as a thread that keeps the execution context it started with, sees the background refresh
        // only while the call runs: a call that it makes afterwards and that needs a new SSO token signs in.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task WorkThatOutlivesTheBackgroundRefresh_AfterTheSourceCallEnds_SignsIn(bool useAsync)
        {
            var clock = new TestClock(T0);
            var sso = new SsoHarness();
            sso.WriteToken(LegacyToken("session-1", ExpiredLongAgo)); // a call for the SSO credentials needs a new SSO token
            var ssoCreds = sso.NewCredentials();
            ImmutableCredentials workCredentials = null;
            using (var starter = new WorkStartingCredentials(clock) { AsyncSourceCall = useAsync })
            {
                starter.Work = () => workCredentials = useAsync
                    ? ssoCreds.GetCredentialsAsync().GetAwaiter().GetResult()
                    : ssoCreds.GetCredentials();
                var cached = await Get(starter, useAsync); // T0+60m; background refresh from T0+45m
                clock.Now = T0 + TimeSpan.FromMinutes(50);
                Assert.AreSame(cached, await Get(starter, useAsync));
                WaitUntilIdle(starter);

                var work = starter.WorkThread;
                Assert.IsNotNull(work, "the background refresh did not start the work");
                CollectionAssert.AreEqual(new[] { true }, starter.WorkFlags.ToList(),
                    "while the source call ran, the work saw the background refresh");
                Assert.AreNotSame(cached, await Get(starter, useAsync), "the background refresh replaced the credentials");

                starter.Release.Set();
                Assert.IsTrue(work.Join(WaitTimeout), "the work did not finish");
                CollectionAssert.AreEqual(new[] { true, false }, starter.WorkFlags.ToList(),
                    "after the source call ended, the work no longer sees the background refresh");
                Assert.IsNull(starter.WorkError, "the work's call failed: " + starter.WorkError);
                Assert.AreEqual("AKIA_" + SignedInAccessToken, workCredentials.AccessKey);
                CollectionAssert.AreEqual(new[] { work.ManagedThreadId }, sso.SignInThreadIds.ToList(),
                    "the sign-in callback ran once, on the work's thread");
                CollectionAssert.AreEqual(new[] { false }, sso.TokenRequests.ToList(), "the work's token request does not defer the sign-in");
            }
        }

        #endregion

        #region Providers that use other providers as their credential source

        private const string RoleArn = "arn:aws:iam::123456789012:role/sso-source-test";
        private const string RoleSessionName = "sso-source-test";

        // The credentials of the provider that uses the SSO credentials as its source are valid for 120 minutes, so its
        // background refresh starts 60 minutes after they are fetched, when the SSO credentials (60 minutes) have expired.
        private static readonly TimeSpan OuterCredentialLifetime = TimeSpan.FromMinutes(120);

        // An AssumeRoleAWSCredentials whose source credentials are SSO credentials with SupportsGettingNewToken = true. The
        // role's STS client is a real one, which resolves the SSO credentials to sign its request, answered in place of the
        // HTTP call, with its retries disabled or left at the default, as in the client that AssumeRoleAWSCredentials
        // creates. AssumeRoleAWSCredentials uses the SDK clock, which follows the test clock.
        [TestMethod]
        [DataRow(false, false)]
        [DataRow(true, false)]
        [DataRow(false, true)]
        [DataRow(true, true)]
        public async Task AssumeRoleOverSso_BackgroundRefresh_NewSsoTokenNeedsSignIn_EndsQuietly_AndTheCallAtExpirationSignsIn(bool useAsync, bool stsDefaultRetries)
        {
            using (var log = new LogCapture())
            {
                var sso = new SsoHarness();
                using (new SdkClockScope(sso.Clock))
                {
                    sso.WriteToken(LegacyToken("session-1", DateTime.UtcNow.AddMinutes(3)));
                    var ssoCreds = sso.NewCredentials(); // each set is valid for 60 minutes
                    using (var sts = new AnsweringStsClient(ssoCreds, sso.Clock, disableRetries: !stsDefaultRetries))
                    {
                        Assert.AreEqual(stsDefaultRetries, sts.Config.MaxErrorRetry > 0, "the STS client retries only with its default retries");
                        GlobalRuntimeDependencyRegistry.Instance.RegisterSecurityTokenServiceClient(sts);
                        try
                        {
                            var role = new AssumeRoleAWSCredentials(ssoCreds, RoleArn, RoleSessionName);
                            role.RefreshBackoffGenerator = () => Backoff;
                            var cached = await Get(role, useAsync); // expires at start + 120m; background refresh from start + 60m
                            CollectionAssert.AreEqual(new[] { "AKIA_session-1" }, sts.SignedWith.ToList(), "STS was called with the SSO credentials");

                            sso.WriteToken(LegacyToken("session-1", ExpiredLongAgo)); // the SSO session has ended
                            sso.Clock.Now = sso.At(65); // the SSO credentials have expired
                            Assert.AreSame(cached, await Get(role, useAsync), "the cached credentials are returned while the refresh runs");
                            WaitUntilIdle(role);

                            CollectionAssert.AreEqual(new[] { false, true }, sso.TokenRequests.ToList(),
                                "the SSO credentials were refreshed for the role's background refresh, which defers the sign-in");
                            Assert.AreEqual(0, sso.SignInThreadIds.Count, "the role's background refresh did not start the sign-in");
                            sso.Oidc.Verify(x => x.GetSsoTokenAsync(It.IsAny<GetSsoTokenRequest>()), Times.Never());
                            Assert.AreEqual(1, sts.SignedWith.Count, "the role's background refresh ended before STS was called");
                            Assert.IsFalse(role.HasCachedErrorForTest, "no error is cached for the role");
                            Assert.IsFalse(ssoCreds.HasCachedErrorForTest, "no error is cached for the SSO credentials");
                            AssertNoFailureLoggedByTheProviders(log.Entries);
                            Assert.AreEqual(1, log.Entries.Count(e => e.Level == SdkLogLevel.Info && e.Message.Contains(DeferredSignInText)),
                                "the role's background refresh logged that it stopped");
                            Assert.AreSame(cached, await Get(role, useAsync), "the role keeps its cached credentials");

                            sso.Clock.Now = sso.At(70); // still inside the role's background refresh window
                            Assert.AreSame(cached, await Get(role, useAsync));
                            WaitUntilIdle(role);
                            Assert.AreEqual(2, sso.TokenRequests.Count, "no further background refresh starts for the role's credentials");

                            // The STS client logs the AssumeRole request that stopped, once for these role credentials, and
                            // does not retry it, also with its default retries.
                            var requestErrors = log.Entries
                                .Where(e => e.Message.StartsWith("CredentialRefreshDeferredException making request", StringComparison.Ordinal))
                                .ToList();
                            Assert.AreEqual(1, requestErrors.Count,
                                "the STS client logs the request once: " + string.Join(" | ", requestErrors.Select(e => e.Message)));
                            Assert.AreEqual(SdkLogLevel.Error, requestErrors[0].Level);
                            StringAssert.EndsWith(requestErrors[0].Message, ". Attempt 1.");
                            Assert.IsFalse(log.Entries.Any(e => e.Message.Contains("Attempting retry")),
                                "the STS client did not retry the request: " + string.Join(" | ", log.Entries.Select(e => e.Message)));
                            Assert.AreEqual(1, log.Entries.Count(e => e.Level == SdkLogLevel.Error && e.Message.StartsWith("Error calling AssumeRole for role " + RoleArn, StringComparison.Ordinal)),
                                "the STS client logs its AssumeRole error once");

                            // At the role's Expiration the call waits for the refresh, which refreshes the SSO credentials
                            // and signs in on the caller's thread. A refresh backoff, had one been applied to either
                            // provider at start + 65m, would still be in effect.
                            sso.Clock.Now = sso.At(119.5);
                            var callerThreadId = Thread.CurrentThread.ManagedThreadId;
                            var refreshed = useAsync ? await role.GetCredentialsAsync() : role.GetCredentials();
                            Assert.AreNotSame(cached, refreshed);
                            CollectionAssert.AreEqual(new[] { callerThreadId }, sso.SignInThreadIds.ToList(),
                                "the sign-in callback ran once, on the caller's thread");
                            Assert.IsFalse(sso.TokenRequests.Last(), "the call's token request does not defer the sign-in");
                            CollectionAssert.AreEqual(new[] { "AKIA_session-1", "AKIA_" + SignedInAccessToken }, sts.SignedWith.ToList(),
                                "STS was called with the SSO credentials from the sign-in");
                        }
                        finally
                        {
                            // The registry has no way to unregister; a factory that returns null restores the default lookup.
                            GlobalRuntimeDependencyRegistry.Instance.RegisterSecurityTokenServiceClient((RuntimeDependencyFactory)(context => null));
                        }
                    }
                }
            }
        }

        // A provider that calls the SSO credentials from its own refresh, synchronously or asynchronously.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task ProviderOverSso_BackgroundRefresh_NewSsoTokenNeedsSignIn_EndsQuietly_AndTheCallAtExpirationSignsIn(bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var sso = new SsoHarness();
                sso.WriteToken(LegacyToken("session-1", DateTime.UtcNow.AddMinutes(3)));
                var ssoCreds = sso.NewCredentials(); // each set is valid for 60 minutes
                var outer = new SourceCallingCredentials(ssoCreds, sso.Clock, OuterCredentialLifetime) { AsyncSourceCall = useAsync };
                var cached = await Get(outer, useAsync); // expires at start + 120m; background refresh from start + 60m

                sso.WriteToken(LegacyToken("session-1", ExpiredLongAgo)); // the SSO session has ended
                sso.Clock.Now = sso.At(65); // the SSO credentials have expired
                Assert.AreSame(cached, await Get(outer, useAsync), "the cached credentials are returned while the refresh runs");
                WaitUntilIdle(outer);

                CollectionAssert.AreEqual(new[] { false, true }, sso.TokenRequests.ToList(),
                    "the SSO credentials were refreshed for the background refresh, which defers the sign-in");
                Assert.AreEqual(0, sso.SignInThreadIds.Count, "the background refresh did not start the sign-in");
                Assert.IsInstanceOfType(outer.SourceErrors.Single(), typeof(CredentialRefreshDeferredException),
                    "the SSO credentials passed the deferral on unchanged");
                Assert.IsFalse(outer.HasCachedErrorForTest, "no error is cached for the provider");
                Assert.IsFalse(ssoCreds.HasCachedErrorForTest, "no error is cached for the SSO credentials");
                Assert.IsFalse(log.Entries.Any(e => e.Level == SdkLogLevel.Warn || e.Level == SdkLogLevel.Error),
                    "nothing is logged as a failure: " + string.Join(" | ", log.Entries.Select(e => e.Message)));
                Assert.AreSame(cached, await Get(outer, useAsync), "the provider keeps its cached credentials");

                // At Expiration the call waits for the refresh, which signs in on the caller's thread. A refresh backoff,
                // had one been applied at start + 65m, would still be in effect.
                sso.Clock.Now = sso.At(119.5);
                var callerThreadId = Thread.CurrentThread.ManagedThreadId;
                var refreshed = useAsync ? await outer.GetCredentialsAsync() : outer.GetCredentials();
                Assert.AreNotSame(cached, refreshed);
                StringAssert.Contains(refreshed.AccessKey, "AKIA_" + SignedInAccessToken);
                CollectionAssert.AreEqual(new[] { callerThreadId }, sso.SignInThreadIds.ToList(),
                    "the sign-in callback ran once, on the caller's thread");
            }
        }

        // A call that waits for the refresh lock of the SSO credentials while another provider's background refresh holds
        // it runs its own refresh once that background refresh has deferred the sign-in and released the lock: the call
        // signs in, on its own flow, and receives no exception, and neither provider records a failure.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task CallWaitingForTheSsoRefreshLock_HeldByAnotherProvidersBackgroundRefresh_SignsIn(bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var sso = new SsoHarness();
                sso.WriteToken(LegacyToken("session-1", DateTime.UtcNow.AddMinutes(3)));
                var ssoCreds = sso.NewCredentials(); // each set is valid for 60 minutes
                var outer = new SourceCallingCredentials(ssoCreds, sso.Clock, OuterCredentialLifetime) { AsyncSourceCall = useAsync };
                var cached = await Get(outer, useAsync); // expires at start + 120m; background refresh from start + 60m

                sso.WriteToken(LegacyToken("session-1", ExpiredLongAgo)); // the SSO session has ended
                sso.Clock.Now = sso.At(65); // the SSO credentials have expired
                var gate = new ManualResetEventSlim();
                sso.DeferredTokenRequestGate = gate;
                ImmutableCredentials waiterCredentials;
                int? waiterThreadId = null;
                try
                {
                    Assert.AreSame(cached, await Get(outer, useAsync), "the cached credentials are returned while the refresh runs");
                    // The other provider's background refresh holds the refresh lock of the SSO credentials while it waits
                    // at its token request.
                    Assert.IsTrue(sso.DeferredTokenRequestHeld.Wait(WaitTimeout), "the background refresh did not request an SSO token");
                    Assert.AreEqual(0, RefreshingCredentialsTestProbes.RefreshLock(ssoCreds).CurrentCount,
                        "the background refresh holds the refresh lock of the SSO credentials");

                    if (useAsync)
                    {
                        // The call runs synchronously up to the lock, where it waits.
                        var call = ssoCreds.GetCredentialsAsync();
                        Assert.IsTrue(SpinWait.SpinUntil(() => RefreshingCredentialsTestProbes.IsAsyncCallWaitingForRefreshLock(ssoCreds), WaitTimeout),
                            "the call did not wait for the refresh lock");
                        Assert.IsFalse(call.IsCompleted, "the call waits for the refresh lock");
                        gate.Set();
                        waiterCredentials = await call;
                    }
                    else
                    {
                        ImmutableCredentials result = null;
                        Exception error = null;
                        var waiter = new Thread(() =>
                        {
                            try { result = ssoCreds.GetCredentials(); }
                            catch (Exception e) { error = e; }
                        }) { IsBackground = true };
                        waiter.Start();
                        Assert.IsTrue(SpinWait.SpinUntil(() => RefreshingCredentialsTestProbes.AreWaitingForRefreshLock(ssoCreds, waiter), WaitTimeout),
                            "the call did not wait for the refresh lock");
                        gate.Set();
                        Assert.IsTrue(waiter.Join(WaitTimeout), "the call did not finish");
                        Assert.IsNull(error, "the call failed: " + error);
                        waiterCredentials = result;
                        waiterThreadId = waiter.ManagedThreadId;
                    }
                }
                finally
                {
                    gate.Set();
                }
                WaitUntilIdle(outer);

                Assert.AreEqual("AKIA_" + SignedInAccessToken, waiterCredentials.AccessKey, "the call signed in");
                CollectionAssert.AreEqual(new[] { false, true, false }, sso.TokenRequests.ToList(),
                    "the background refresh's token request deferred the sign-in, and the call's did not");
                if (waiterThreadId.HasValue)
                    CollectionAssert.AreEqual(new[] { waiterThreadId.Value }, sso.SignInThreadIds.ToList(), "the sign-in callback ran once, on the call's thread");
                else
                    Assert.AreEqual(1, sso.SignInThreadIds.Count, "the sign-in callback ran once, for the call");
                Assert.IsInstanceOfType(outer.SourceErrors.Single(), typeof(CredentialRefreshDeferredException),
                    "the SSO credentials passed the deferral on to the other provider's background refresh");
                Assert.IsFalse(outer.HasCachedErrorForTest, "no error is cached for the provider");
                Assert.IsFalse(ssoCreds.HasCachedErrorForTest, "no error is cached for the SSO credentials");
                Assert.IsFalse(log.Entries.Any(e => e.Level == SdkLogLevel.Warn || e.Level == SdkLogLevel.Error),
                    "nothing is logged as a failure: " + string.Join(" | ", log.Entries.Select(e => e.Message)));
                Assert.AreEqual(1, log.Entries.Count(e => e.Level == SdkLogLevel.Info && e.Message.Contains(DeferredSignInText)),
                    "the other provider's background refresh logged that it stopped");
                Assert.AreSame(cached, await Get(outer, useAsync), "the provider keeps its cached credentials");
                Assert.AreSame(waiterCredentials, await Get(ssoCreds, useAsync), "the SSO credentials cached the call's credentials");

                // At Expiration the provider's call refreshes, with the SSO credentials that the call signed in for. A
                // refresh backoff, had one been applied at start + 65m, would still be in effect.
                sso.Clock.Now = sso.At(119.5);
                var refreshed = await Get(outer, useAsync);
                Assert.AreNotSame(cached, refreshed);
                StringAssert.Contains(refreshed.AccessKey, "AKIA_" + SignedInAccessToken);
                WaitUntilIdle(ssoCreds); // the SSO credentials are in their own background refresh window
                Assert.AreEqual(1, sso.SignInThreadIds.Count, "no other sign-in");
            }
        }

        /// <summary>The path on which a provider called by another provider's background refresh calls its source.</summary>
        public enum SourcePath
        {
            InitialFetch,
            MandatoryRefresh,
            AdvisoryRefreshAfterNonRecoverableError,
            MinimumLifetime,
        }

        // A provider called during another provider's background refresh passes a deferral from its own source on unchanged,
        // on every path that calls that source, and records nothing: no cached error, even when it classifies every error
        // as non-recoverable; no refresh backoff; no cached credentials returned in its place; nothing logged as a failure.
        [TestMethod]
        [DataRow(SourcePath.InitialFetch, false, false)]
        [DataRow(SourcePath.InitialFetch, false, true)]
        [DataRow(SourcePath.InitialFetch, true, false)]
        [DataRow(SourcePath.InitialFetch, true, true)]
        [DataRow(SourcePath.MandatoryRefresh, false, false)]
        [DataRow(SourcePath.MandatoryRefresh, false, true)]
        [DataRow(SourcePath.MandatoryRefresh, true, false)]
        [DataRow(SourcePath.MandatoryRefresh, true, true)]
        [DataRow(SourcePath.AdvisoryRefreshAfterNonRecoverableError, false, false)]
        [DataRow(SourcePath.AdvisoryRefreshAfterNonRecoverableError, false, true)]
        [DataRow(SourcePath.AdvisoryRefreshAfterNonRecoverableError, true, false)]
        [DataRow(SourcePath.AdvisoryRefreshAfterNonRecoverableError, true, true)]
        [DataRow(SourcePath.MinimumLifetime, false, false)]
        [DataRow(SourcePath.MinimumLifetime, false, true)]
        [DataRow(SourcePath.MinimumLifetime, true, false)]
        [DataRow(SourcePath.MinimumLifetime, true, true)]
        public async Task BackgroundRefresh_SourceProviderNeedsTheCaller_PassesItOnWithoutRecordingAFailure(
            SourcePath path, bool everyErrorIsNonRecoverable, bool useAsync)
        {
            using (var log = new LogCapture())
            {
                var clock = new TestClock(T0);
                var advisory = path == SourcePath.AdvisoryRefreshAfterNonRecoverableError;
                // On the advisory path both sets of credentials must be inside their background refresh windows at once:
                // the source's from T0+60m to T0+119m, the other provider's from T0+30m to T0+89m. On the other paths the
                // source's credentials (T0+60m) have expired when the other provider's window starts (T0+60m).
                var source = new DeferringSourceCredentials(clock, TimeSpan.FromMinutes(advisory ? 120 : 60))
                {
                    EveryErrorIsNonRecoverable = everyErrorIsNonRecoverable
                };
                source.NonRecoverableErrorCacheGenerator = () => TimeSpan.FromSeconds(1);
                var minimumLifetime = TimeSpan.FromMinutes(15);
                var outer = new SourceCallingCredentials(source, clock, TimeSpan.FromMinutes(advisory ? 90 : 120))
                {
                    AsyncSourceCall = useAsync,
                    SourceMinimumLifetime = path == SourcePath.MinimumLifetime ? minimumLifetime : (TimeSpan?)null
                };
                var cached = await Get(outer, useAsync);
                Assert.AreEqual(1, source.Generated);

                switch (path)
                {
                    case SourcePath.InitialFetch:
                        source.ClearCredentials(); // the source has no credentials when the other provider asks for them
                        clock.Now = T0 + TimeSpan.FromMinutes(65);
                        break;
                    case SourcePath.MandatoryRefresh:
                    case SourcePath.MinimumLifetime:
                        clock.Now = T0 + TimeSpan.FromMinutes(65); // the source's credentials have expired
                        break;
                    case SourcePath.AdvisoryRefreshAfterNonRecoverableError:
                        // The source's own background refresh fails with a non-recoverable error, so its next call in the
                        // window refreshes while it waits.
                        source.NextBackgroundError = new AmazonNonRecoverableCredentialsException("The session has ended.");
                        clock.Now = T0 + TimeSpan.FromMinutes(61);
                        await Get(source, useAsync);
                        WaitUntilIdle(source);
                        Assert.IsTrue(source.HasCachedErrorForTest);
                        clock.Now += TimeSpan.FromSeconds(2); // the error is no longer raised
                        break;
                }

                var logStart = log.Entries.Count;
                Assert.AreSame(cached, await Get(outer, useAsync), "the cached credentials are returned while the refresh runs");
                WaitUntilIdle(outer);

                Assert.AreSame(source.Deferrals.Single(), outer.SourceErrors.Single(),
                    "the source provider passed on the exception that its source threw, unchanged");
                Assert.AreEqual(1, source.Generated);
                Assert.AreSame(cached, await Get(outer, useAsync), "the other provider was not refreshed");
                Assert.IsFalse(source.HasCachedErrorForTest, "no error is cached for the source provider");
                Assert.IsFalse(outer.HasCachedErrorForTest, "no error is cached for the other provider");
                var entries = log.Entries.Skip(logStart).ToList();
                Assert.IsFalse(entries.Any(e => e.Level == SdkLogLevel.Warn || e.Level == SdkLogLevel.Error),
                    "nothing is logged as a failure: " + string.Join(" | ", entries.Select(e => e.Message)));
                Assert.AreEqual(1, entries.Count(e => e.Level == SdkLogLevel.Info && e.Message.StartsWith("The background credential refresh stopped", StringComparison.Ordinal)),
                    "the other provider's background refresh logged that it stopped");

                // The source provider recorded nothing: a call for the caller refreshes it at once. A refresh backoff would
                // return its cached credentials instead, and on the advisory path the call refreshes while it waits only
                // while the earlier non-recoverable error is still recorded.
                if (path == SourcePath.MinimumLifetime)
                    await (useAsync ? source.GetCredentialsAsync(minimumLifetime) : Task.FromResult(source.GetCredentials(minimumLifetime)));
                else
                    await Get(source, useAsync);
                Assert.AreEqual(2, source.Generated, "the call for the caller refreshed the source provider");
            }
        }

        // Fails when a credential provider logs a warning or an error. The STS client logs its own errors for every failed
        // call, including one that ends because its source credentials need the caller, as it does for any other failure
        // of its source credentials.
        private static void AssertNoFailureLoggedByTheProviders(IEnumerable<LogCapture.Entry> entries)
        {
            var failures = entries
                .Where(e => e.Level == SdkLogLevel.Warn || e.Level == SdkLogLevel.Error)
                .Where(e => !typeof(AmazonSecurityTokenServiceClient).IsAssignableFrom(e.Source))
                .ToList();
            Assert.AreEqual(0, failures.Count, "logged as a failure: " + string.Join(" | ", failures.Select(e => e.Source.Name + ": " + e.Message)));
        }

        #endregion

        #region Helpers

        private static readonly DateTime T0 = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static readonly DateTime ExpiredLongAgo = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private static Task<ImmutableCredentials> Get(RefreshingAWSCredentials creds, bool useAsync)
            => useAsync ? creds.GetCredentialsAsync() : Task.FromResult(creds.GetCredentials());

        // Waits for a background refresh that a call started: no refresh holds the lock and no background refresh is
        // pending. A call that starts one marks it pending before it returns. The timeout only elapses when a test fails.
        private static void WaitUntilIdle(RefreshingAWSCredentials creds)
        {
            Assert.IsTrue(SpinWait.SpinUntil(() => RefreshingCredentialsTestProbes.IsIdle(creds), WaitTimeout),
                "the background refresh did not finish");
        }

        // A token without a refresh token, as a legacy SSO profile caches it.
        private static SsoToken LegacyToken(string accessToken, DateTime expiresAt) => new SsoToken
        {
            AccessToken = accessToken,
            ExpiresAt = expiresAt,
            Region = SsoRegion,
            StartUrl = StartUrl
        };

        private static SsoToken RefreshableToken(string accessToken, DateTime expiresAt, string registrationExpiresAt = "3000-12-25T21:30:00Z")
            => new SsoToken
            {
                AccessToken = accessToken,
                ExpiresAt = expiresAt,
                RefreshToken = "refresh-token",
                ClientId = "client-id",
                ClientSecret = "client-secret",
                RegistrationExpiresAt = registrationExpiresAt,
                Region = SsoRegion,
                StartUrl = StartUrl
            };

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
        /// An SSO credentials setup: the real <see cref="SSOTokenManager"/> and token file cache over an in-memory file
        /// system, SSO OIDC and SSO test doubles, and a record of every token request and sign-in.
        /// </summary>
        private sealed class SsoHarness
        {
            private readonly MockFileSystem _fileSystem = new MockFileSystem();
            private readonly SSOTokenFileCache _fileCache;
            private readonly List<int> _signInThreadIds = new List<int>();
            private readonly List<bool> _tokenRequests = new List<bool>();
            private int _tokenRefreshes;
            private int _roleCredentialRequests;

            public SsoHarness()
            {
                var start = DateTime.UtcNow;
                Start = new DateTime(start.Ticks - start.Ticks % TimeSpan.TicksPerSecond, DateTimeKind.Utc);
                Clock = new TestClock(Start);
                _fileCache = new SSOTokenFileCache(CryptoUtilFactory.CryptoInstance, _fileSystem, _fileSystem);

                // A sign-in: SSO OIDC calls the verification callback, as the device authorization flow does, and returns
                // a new token once the user has signed in.
#if NETFRAMEWORK
                Oidc.Setup(x => x.GetSsoToken(It.IsAny<GetSsoTokenRequest>())).Returns((GetSsoTokenRequest request) => SignIn(request));
                Oidc.Setup(x => x.RefreshToken(It.IsAny<GetSsoTokenResponse>())).Returns((GetSsoTokenResponse previous) => RefreshToken(previous));
                Sso.Setup(x => x.CredentialsFromSsoAccessToken(AccountId, RoleName, It.IsAny<string>(), It.IsAny<IDictionary<string, object>>()))
                   .Returns((string account, string role, string accessToken, IDictionary<string, object> properties) => RoleCredentials(accessToken));
#endif
                Oidc.Setup(x => x.GetSsoTokenAsync(It.IsAny<GetSsoTokenRequest>())).Returns((GetSsoTokenRequest request) => Task.FromResult(SignIn(request)));
                Oidc.Setup(x => x.RefreshTokenAsync(It.IsAny<GetSsoTokenResponse>())).Returns((GetSsoTokenResponse previous) => Task.FromResult(RefreshToken(previous)));
                Sso.Setup(x => x.CredentialsFromSsoAccessTokenAsync(AccountId, RoleName, It.IsAny<string>(), It.IsAny<IDictionary<string, object>>()))
                   .Returns((string account, string role, string accessToken, IDictionary<string, object> properties) => Task.FromResult(RoleCredentials(accessToken)));

                Manager = new TestSsoTokenManager(Oidc.Object, _fileCache);
            }

            public DateTime Start { get; }
            public TestClock Clock { get; }
            public Mock<ICoreAmazonSSOOIDC> Oidc { get; } = new Mock<ICoreAmazonSSOOIDC>();
            public Mock<ICoreAmazonSSO> Sso { get; } = new Mock<ICoreAmazonSSO>();
            public SSOTokenManager Manager { get; }

            /// <summary>When set, a refresh with the refresh token fails with this error.</summary>
            public Exception RefreshFailure { get; set; }

            /// <summary>
            /// When set, a token request of SSOAWSCredentials that defers the sign-in sets
            /// <see cref="DeferredTokenRequestHeld"/> and waits until the test sets this before it is passed on.
            /// </summary>
            public ManualResetEventSlim DeferredTokenRequestGate { get; set; }

            /// <summary>Set when a token request that defers the sign-in waits at <see cref="DeferredTokenRequestGate"/>.</summary>
            public ManualResetEventSlim DeferredTokenRequestHeld { get; } = new ManualResetEventSlim();

            /// <summary>The managed thread ID of each call of the sign-in callback.</summary>
            public IReadOnlyList<int> SignInThreadIds { get { lock (_signInThreadIds) { return _signInThreadIds.ToList(); } } }

            /// <summary>For each token request that SSOAWSCredentials made, whether it deferred the sign-in.</summary>
            public IReadOnlyList<bool> TokenRequests { get { lock (_tokenRequests) { return _tokenRequests.ToList(); } } }

            public int TokenRefreshes => Volatile.Read(ref _tokenRefreshes);
            public int RoleCredentialRequests => Volatile.Read(ref _roleCredentialRequests);

            public DateTime At(double minutes) => Start + TimeSpan.FromMinutes(minutes);

            public void WriteToken(SsoToken token) => _fileCache.SaveSsoToken(token, null);

            public SSOAWSCredentials NewCredentials(bool refreshThroughTheSynchronousRefresh = false)
            {
                var options = new SSOAWSCredentialsOptions
                {
                    ClientName = "sso-test-client",
                    SupportsGettingNewToken = true,
                    SsoVerificationCallback = OnSignIn
                };
                var tokenManager = new RecordingSsoTokenManager(Manager, OnTokenRequest);
#if NETFRAMEWORK
                var creds = refreshThroughTheSynchronousRefresh
                    ? new SynchronousRefreshSsoCredentials(options, tokenManager, () => Sso.Object, Clock)
                    : new SSOAWSCredentials(AccountId, SsoRegion, RoleName, StartUrl, options, tokenManager, () => Sso.Object, Clock);
#else
                if (refreshThroughTheSynchronousRefresh)
                    throw new NotSupportedException("SSOAWSCredentials has a separate synchronous refresh only on .NET Framework.");
                var creds = new SSOAWSCredentials(AccountId, SsoRegion, RoleName, StartUrl, options, tokenManager, () => Sso.Object, Clock);
#endif
                creds.RefreshBackoffGenerator = () => Backoff;
                return creds;
            }

            public SSOTokenManagerGetTokenOptions TokenOptions(bool deferInteractiveSignIn) => new SSOTokenManagerGetTokenOptions
            {
                ClientName = "sso-test-client",
                Region = SsoRegion,
                StartUrl = StartUrl,
                SupportsGettingNewToken = true,
                SsoVerificationCallback = OnSignIn,
                DeferInteractiveSignIn = deferInteractiveSignIn
            };

            public void Arrange(SignInScenario scenario)
            {
                switch (scenario)
                {
                    case SignInScenario.NoCachedToken:
                        break;
                    case SignInScenario.ExpiredTokenWithoutRefreshToken:
                        WriteToken(LegacyToken("cached-token", ExpiredLongAgo));
                        break;
                    case SignInScenario.ExpiredTokenWhoseRefreshFails:
                        WriteToken(RefreshableToken("cached-token", ExpiredLongAgo));
                        RefreshFailure = new AmazonServiceException("The refresh token has expired.");
                        break;
                    case SignInScenario.ClientRegistrationExpired:
                        WriteToken(RefreshableToken("cached-token", ExpiredLongAgo, registrationExpiresAt: "2000-01-01T00:00:00Z"));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(scenario));
                }
            }

            private void OnTokenRequest(SSOTokenManagerGetTokenOptions options)
            {
                lock (_tokenRequests) { _tokenRequests.Add(options.DeferInteractiveSignIn); }
                var gate = DeferredTokenRequestGate;
                if (gate != null && options.DeferInteractiveSignIn)
                {
                    DeferredTokenRequestHeld.Set();
                    if (!gate.Wait(WaitTimeout))
                        throw new TimeoutException("The test did not release the token request.");
                }
            }

            private void OnSignIn(SsoVerificationArguments arguments)
            {
                lock (_signInThreadIds) { _signInThreadIds.Add(Thread.CurrentThread.ManagedThreadId); }
            }

            private GetSsoTokenResponse SignIn(GetSsoTokenRequest request)
            {
                request.SsoVerificationCallback(new SsoVerificationArguments
                {
                    UserCode = "ABCD-EFGH",
                    VerificationUri = "https://device.sso.us-west-2.amazonaws.com/",
                    VerificationUriComplete = "https://device.sso.us-west-2.amazonaws.com/?user_code=ABCD-EFGH"
                });
                return NewTokenResponse(SignedInAccessToken, DateTime.UtcNow.AddHours(8));
            }

            private GetSsoTokenResponse RefreshToken(GetSsoTokenResponse previous)
            {
                var failure = RefreshFailure;
                if (failure != null)
                    throw failure;
                var n = Interlocked.Increment(ref _tokenRefreshes);
                return NewTokenResponse("refreshed-" + n, DateTime.UtcNow.AddMinutes(3));
            }

            private static GetSsoTokenResponse NewTokenResponse(string accessToken, DateTime expiresAt) => new GetSsoTokenResponse
            {
                AccessToken = accessToken,
                ExpiresAt = expiresAt,
                RefreshToken = "refresh-token",
                ClientId = "client-id",
                ClientSecret = "client-secret",
                RegistrationExpiresAt = "3000-12-25T21:30:00Z",
                Region = SsoRegion,
                StartUrl = StartUrl
            };

            private ImmutableCredentials RoleCredentials(string accessToken)
            {
                Interlocked.Increment(ref _roleCredentialRequests);
                return new SSOImmutableCredentials("AKIA_" + accessToken, "secret", "session-token", Clock.Now + RoleCredentialLifetime);
            }
        }

        /// <summary>
        /// The real <see cref="SSOTokenManager"/>, without the SSO OIDC client that it would otherwise load for a sign-in
        /// at run time, so a sign-in goes to the <see cref="ICoreAmazonSSOOIDC"/> test double.
        /// </summary>
        private sealed class TestSsoTokenManager : SSOTokenManager
        {
            public TestSsoTokenManager(ICoreAmazonSSOOIDC ssooidcClient, ISSOTokenFileCache ssoTokenFileCache)
                : base(ssooidcClient, ssoTokenFileCache) { }

#if NETFRAMEWORK
            protected override ICoreAmazonSSOOIDC_V2 CreateSSOOIDC_V2Client(string region, WebProxy proxySettings = null) => null;
#else
            protected override ICoreAmazonSSOOIDC_V2 CreateSSOOIDC_V2Client(string region, IWebProxy proxySettings = null) => null;
#endif
        }

#if NETFRAMEWORK
        /// <summary>
        /// SSO credentials whose asynchronous refresh runs the synchronous refresh on a thread-pool thread, as a derived
        /// class can do.
        /// </summary>
        private sealed class SynchronousRefreshSsoCredentials : SSOAWSCredentials
        {
            public SynchronousRefreshSsoCredentials(SSOAWSCredentialsOptions options, ISSOTokenManager ssoTokenManager,
                Func<ICoreAmazonSSO> ssoClientFactory, ITimeProvider timeProvider)
                : base(CredentialRefreshSsoTests.AccountId, SsoRegion, CredentialRefreshSsoTests.RoleName,
                      CredentialRefreshSsoTests.StartUrl, options, ssoTokenManager, ssoClientFactory, timeProvider) { }

            protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
                => Task.Run(() => GenerateNewCredentials());
        }
#endif

        /// <summary>
        /// Reports each token request to the harness, which records whether it deferred the sign-in, and passes the
        /// request on.
        /// </summary>
        private sealed class RecordingSsoTokenManager : ISSOTokenManager
        {
            private readonly ISSOTokenManager _inner;
            private readonly Action<SSOTokenManagerGetTokenOptions> _onRequest;

            public RecordingSsoTokenManager(ISSOTokenManager inner, Action<SSOTokenManagerGetTokenOptions> onRequest)
            {
                _inner = inner;
                _onRequest = onRequest;
            }

            private void Record(SSOTokenManagerGetTokenOptions options) => _onRequest(options);

#if NETFRAMEWORK
            public SsoToken GetToken(SSOTokenManagerGetTokenOptions options)
            {
                Record(options);
                return _inner.GetToken(options);
            }

            public void Logout(string ssoCacheDirectory = null) => _inner.Logout(ssoCacheDirectory);
            public void Logout(SSOTokenManagerGetTokenOptions options) => _inner.Logout(options);
#endif

            public Task<SsoToken> GetTokenAsync(SSOTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default)
            {
                Record(options);
                return _inner.GetTokenAsync(options, cancellationToken);
            }

            public Task LogoutAsync(string ssoCacheDirectory = null, CancellationToken cancellationToken = default)
                => _inner.LogoutAsync(ssoCacheDirectory, cancellationToken);

            public Task LogoutAsync(SSOTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default)
                => _inner.LogoutAsync(options, cancellationToken);
        }

        /// <summary>
        /// A provider that uses the refresh lifecycle and records, for each call to its credential source, whether it ran
        /// as a background refresh. When <see cref="NeedsCaller"/> is set, a background refresh throws
        /// <see cref="CredentialRefreshDeferredException"/>, as a source that needs the caller does. Each set of
        /// credentials is valid for 60 minutes.
        /// </summary>
        private sealed class CallerOnlyCredentials : RefreshingAWSCredentials
        {
            private readonly List<bool> _backgroundFlags = new List<bool>();
            private int _generated;

            public CallerOnlyCredentials(ITimeProvider clock) : base(clock)
            {
                RefreshBackoffGenerator = () => Backoff;
            }

            public bool NeedsCaller { get; set; }

            /// <summary>When set, the next background refresh throws this error instead, once.</summary>
            public Exception NextBackgroundError { get; set; }

            public IReadOnlyList<bool> BackgroundFlags { get { lock (_backgroundFlags) { return _backgroundFlags.ToList(); } } }

            protected override bool UsesManagedRefreshLifecycle => true;

            // Not overriding GenerateNewCredentialsAsync: the default runs this on a thread-pool thread, so the background
            // refresh's value must flow there.
            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                var background = IsBackgroundRefresh;
                lock (_backgroundFlags) { _backgroundFlags.Add(background); }
                if (background && NextBackgroundError != null)
                {
                    var error = NextBackgroundError;
                    NextBackgroundError = null;
                    throw error;
                }
                if (NeedsCaller && background)
                    throw new CredentialRefreshDeferredException("The credential source needs the caller.");

                var n = Interlocked.Increment(ref _generated);
                return new CredentialsRefreshState(new ImmutableCredentials("AKIA_CALLER_" + n, "secret_" + n, "token_" + n),
                    _timeProvider.CorrectedUtcNow + RoleCredentialLifetime, _timeProvider);
            }
        }

        /// <summary>
        /// A provider that uses the refresh lifecycle and whose background refresh waits until the test sets
        /// <see cref="Release"/>. Each set of credentials is valid for 60 minutes.
        /// </summary>
        private sealed class GatedCredentials : RefreshingAWSCredentials
        {
            private int _generated;
            private int _ranAsBackgroundRefresh;

            public GatedCredentials(ITimeProvider clock) : base(clock)
            {
                RefreshBackoffGenerator = () => Backoff;
            }

            public ManualResetEventSlim BackgroundRefreshStarted { get; } = new ManualResetEventSlim();
            public ManualResetEventSlim Release { get; } = new ManualResetEventSlim();
            public bool RanAsBackgroundRefresh => Volatile.Read(ref _ranAsBackgroundRefresh) != 0;

            protected override bool UsesManagedRefreshLifecycle => true;

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                if (IsBackgroundRefresh)
                {
                    Volatile.Write(ref _ranAsBackgroundRefresh, 1);
                    BackgroundRefreshStarted.Set();
                    if (!Release.Wait(WaitTimeout))
                        throw new TimeoutException("The test did not release the background refresh.");
                }

                var n = Interlocked.Increment(ref _generated);
                return new CredentialsRefreshState(new ImmutableCredentials("AKIA_GATED_" + n, "secret_" + n, "token_" + n),
                    _timeProvider.CorrectedUtcNow + RoleCredentialLifetime, _timeProvider);
            }

            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    Release.Set();
                    BackgroundRefreshStarted.Dispose();
                    Release.Dispose();
                }
                base.Dispose(disposing);
            }
        }

        /// <summary>
        /// A provider that uses the refresh lifecycle and whose background refresh starts work that outlives it: a
        /// dedicated thread, which keeps the execution context it started with. The thread records
        /// <see cref="RefreshingAWSCredentials.IsBackgroundRefresh"/> before the background refresh returns, then waits
        /// until the test sets <see cref="Release"/>, records it again and runs <see cref="Work"/>. The background
        /// refresh starts the thread from <see cref="GenerateNewCredentials"/>, which the default asynchronous refresh
        /// runs on a thread-pool thread, or from its own asynchronous refresh when <see cref="AsyncSourceCall"/> is set.
        /// Each set of credentials is valid for 60 minutes.
        /// </summary>
        private sealed class WorkStartingCredentials : RefreshingAWSCredentials
        {
            private readonly object _sync = new object();
            private readonly List<bool> _workFlags = new List<bool>();
            private Thread _workThread;
            private Exception _workError;
            private int _generated;

            public WorkStartingCredentials(ITimeProvider clock) : base(clock)
            {
                RefreshBackoffGenerator = () => Backoff;
            }

            public bool AsyncSourceCall { get; set; }

            /// <summary>What the work does once the test sets <see cref="Release"/>.</summary>
            public Action Work { get; set; }

            public ManualResetEventSlim Release { get; } = new ManualResetEventSlim();

            /// <summary>The thread that runs the work, once a background refresh has started it.</summary>
            public Thread WorkThread { get { lock (_sync) { return _workThread; } } }

            /// <summary>The values of IsBackgroundRefresh that the work read, before and after it was released.</summary>
            public IReadOnlyList<bool> WorkFlags { get { lock (_sync) { return _workFlags.ToList(); } } }

            /// <summary>The exception that the work threw, or null.</summary>
            public Exception WorkError { get { lock (_sync) { return _workError; } } }

            protected override bool UsesManagedRefreshLifecycle => true;

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                if (IsBackgroundRefresh && !StartWork().Wait(WaitTimeout))
                    throw new TimeoutException("The work did not start.");
                return NewState();
            }

            protected override async Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
            {
                if (!AsyncSourceCall)
                    return await base.GenerateNewCredentialsAsync().ConfigureAwait(false);
                if (IsBackgroundRefresh)
                    await StartWork().ConfigureAwait(false);
                return NewState();
            }

            // Starts the work on a new thread. The task completes once the work has recorded the flag for the first time.
            private Task StartWork()
            {
                var recorded = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
                var thread = new Thread(() =>
                {
                    try
                    {
                        Record(IsBackgroundRefresh);
                        recorded.SetResult(true);
                        if (!Release.Wait(WaitTimeout))
                            throw new TimeoutException("The test did not release the work.");
                        Record(IsBackgroundRefresh);
                        Work?.Invoke();
                    }
                    catch (Exception e)
                    {
                        lock (_sync) { _workError = e; }
                    }
                }) { IsBackground = true };
                lock (_sync) { _workThread = thread; }
                thread.Start();
                return recorded.Task;
            }

            private void Record(bool background)
            {
                lock (_sync) { _workFlags.Add(background); }
            }

            private CredentialsRefreshState NewState()
            {
                var n = Interlocked.Increment(ref _generated);
                return new CredentialsRefreshState(new ImmutableCredentials("AKIA_WORK_" + n, "secret_" + n, "token_" + n),
                    _timeProvider.CorrectedUtcNow + RoleCredentialLifetime, _timeProvider);
            }

            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    Release.Set();
                    var thread = WorkThread;
                    if (thread == null || thread.Join(WaitTimeout))
                        Release.Dispose();
                }
                base.Dispose(disposing);
            }
        }

        /// <summary>
        /// A provider that uses the refresh lifecycle and gets its credentials from another provider, as
        /// <see cref="AssumeRoleAWSCredentials"/> does through its STS client: its refresh calls
        /// <see cref="AWSCredentials.GetCredentials()"/> of that provider, or <see cref="AWSCredentials.GetCredentialsAsync()"/>
        /// when <see cref="AsyncSourceCall"/> is set, or the minimum lifetime overloads when
        /// <see cref="SourceMinimumLifetime"/> is set. It records every exception from that call and passes it on.
        /// </summary>
        private sealed class SourceCallingCredentials : RefreshingAWSCredentials
        {
            private readonly RefreshingAWSCredentials _source;
            private readonly TimeSpan _lifetime;
            private readonly List<Exception> _sourceErrors = new List<Exception>();
            private int _generated;

            public SourceCallingCredentials(RefreshingAWSCredentials source, ITimeProvider clock, TimeSpan lifetime) : base(clock)
            {
                _source = source;
                _lifetime = lifetime;
                RefreshBackoffGenerator = () => Backoff;
            }

            public bool AsyncSourceCall { get; set; }
            public TimeSpan? SourceMinimumLifetime { get; set; }

            public IReadOnlyList<Exception> SourceErrors { get { lock (_sourceErrors) { return _sourceErrors.ToList(); } } }

            protected override bool UsesManagedRefreshLifecycle => true;

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                ImmutableCredentials sourceCredentials;
                try
                {
                    var minimumLifetime = SourceMinimumLifetime;
                    sourceCredentials = minimumLifetime.HasValue ? _source.GetCredentials(minimumLifetime.Value) : _source.GetCredentials();
                }
                catch (Exception e)
                {
                    lock (_sourceErrors) { _sourceErrors.Add(e); }
                    throw;
                }
                return NewState(sourceCredentials);
            }

            // Without AsyncSourceCall the default runs GenerateNewCredentials on a thread-pool thread.
            protected override async Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
            {
                if (!AsyncSourceCall)
                    return await base.GenerateNewCredentialsAsync().ConfigureAwait(false);

                ImmutableCredentials sourceCredentials;
                try
                {
                    var minimumLifetime = SourceMinimumLifetime;
                    sourceCredentials = minimumLifetime.HasValue
                        ? await _source.GetCredentialsAsync(minimumLifetime.Value).ConfigureAwait(false)
                        : await _source.GetCredentialsAsync().ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    lock (_sourceErrors) { _sourceErrors.Add(e); }
                    throw;
                }
                return NewState(sourceCredentials);
            }

            private CredentialsRefreshState NewState(ImmutableCredentials sourceCredentials)
            {
                var n = Interlocked.Increment(ref _generated);
                return new CredentialsRefreshState(
                    new ImmutableCredentials("OUTER_" + n + "_" + sourceCredentials.AccessKey, "secret_" + n, "token_" + n),
                    _timeProvider.CorrectedUtcNow + _lifetime, _timeProvider);
            }
        }

        /// <summary>
        /// A provider that uses the refresh lifecycle and whose own credential source needs the caller: a call made during
        /// a background refresh throws <see cref="CredentialRefreshDeferredException"/>, wrapped in an
        /// <see cref="AmazonClientException"/> as the STS client wraps the errors of its source credentials, and records
        /// it. <see cref="NextBackgroundError"/>, when set, is thrown instead, once.
        /// </summary>
        private sealed class DeferringSourceCredentials : RefreshingAWSCredentials
        {
            private readonly TimeSpan _lifetime;
            private readonly List<Exception> _deferrals = new List<Exception>();
            private int _generated;

            public DeferringSourceCredentials(ITimeProvider clock, TimeSpan lifetime) : base(clock)
            {
                _lifetime = lifetime;
                RefreshBackoffGenerator = () => Backoff;
            }

            /// <summary>When set, <see cref="IsNonRecoverableError"/> returns true for every error.</summary>
            public bool EveryErrorIsNonRecoverable { get; set; }

            public Exception NextBackgroundError { get; set; }

            public int Generated => Volatile.Read(ref _generated);

            public IReadOnlyList<Exception> Deferrals { get { lock (_deferrals) { return _deferrals.ToList(); } } }

            protected override bool UsesManagedRefreshLifecycle => true;

            protected override bool IsNonRecoverableError(Exception exception)
                => EveryErrorIsNonRecoverable || base.IsNonRecoverableError(exception);

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                if (IsBackgroundRefresh)
                {
                    var error = NextBackgroundError;
                    if (error != null)
                    {
                        NextBackgroundError = null;
                        throw error;
                    }

                    var deferral = new AmazonClientException("Error calling the credential source.",
                        new CredentialRefreshDeferredException("The credential source needs the caller."));
                    lock (_deferrals) { _deferrals.Add(deferral); }
                    throw deferral;
                }

                var n = Interlocked.Increment(ref _generated);
                return new CredentialsRefreshState(new ImmutableCredentials("AKIA_SOURCE_" + n, "secret_" + n, "token_" + n),
                    _timeProvider.CorrectedUtcNow + _lifetime, _timeProvider);
            }
        }

        /// <summary>
        /// A real STS client that resolves the given credentials to sign its requests, as the STS client of
        /// <see cref="AssumeRoleAWSCredentials"/> does with its source credentials, and answers AssumeRole in place of
        /// the HTTP call with credentials valid for <see cref="OuterCredentialLifetime"/>. Its retries are the default
        /// ones unless <c>disableRetries</c> is set.
        /// </summary>
        private sealed class AnsweringStsClient : AmazonSecurityTokenServiceClient
        {
            private readonly TestClock _clock;
            private readonly List<string> _signedWith = new List<string>();

            public AnsweringStsClient(AWSCredentials credentials, TestClock clock, bool disableRetries)
                : base(credentials, NewConfig(disableRetries))
            {
                _clock = clock;
            }

            private static AmazonSecurityTokenServiceConfig NewConfig(bool disableRetries)
            {
                var config = new AmazonSecurityTokenServiceConfig { RegionEndpoint = RegionEndpoint.USEast1 };
                if (disableRetries)
                    config.MaxErrorRetry = 0;
                return config;
            }

            /// <summary>The access key ID of the credentials that signed each AssumeRole request.</summary>
            public IReadOnlyList<string> SignedWith { get { lock (_signedWith) { return _signedWith.ToList(); } } }

            protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
            {
                base.CustomizeRuntimePipeline(pipeline);
                pipeline.AddHandlerAfter<ErrorHandler>(new AnswerHandler(this));
            }

            private AmazonWebServiceResponse Answer(IExecutionContext executionContext)
            {
                int n;
                lock (_signedWith)
                {
                    _signedWith.Add(((RequestContext)executionContext.RequestContext).ResolvedCredentials.AccessKey);
                    n = _signedWith.Count;
                }
                var response = new Amazon.SecurityToken.Model.AssumeRoleResponse
                {
                    Credentials = new Amazon.SecurityToken.Model.Credentials
                    {
                        AccessKeyId = "ASIA_ROLE_" + n,
                        SecretAccessKey = "role-secret",
                        SessionToken = "role-token",
                        Expiration = _clock.Now + OuterCredentialLifetime
                    }
                };
                executionContext.ResponseContext.Response = response;
                return response;
            }

            private sealed class AnswerHandler : PipelineHandler
            {
                private readonly AnsweringStsClient _owner;
                public AnswerHandler(AnsweringStsClient owner) { _owner = owner; }

                public override void InvokeSync(IExecutionContext executionContext) => _owner.Answer(executionContext);

                public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
                    => Task.FromResult((T)_owner.Answer(executionContext));
            }
        }

        /// <summary>
        /// Makes the SDK clock (<see cref="AWSSDKUtils.CorrectedUtcNow"/>), which <see cref="AssumeRoleAWSCredentials"/> and
        /// the SSO token manager use, follow a test clock, and restores it when disposed.
        /// </summary>
        private sealed class SdkClockScope : IDisposable
        {
            private readonly Func<DateTime> _savedUtcNowSource = AWSConfigs.utcNowSource;
            private readonly TimeSpan? _savedManualClockCorrection = AWSConfigs.ManualClockCorrection;

            public SdkClockScope(TestClock clock)
            {
                AWSConfigs.ManualClockCorrection = null;
                AWSConfigs.utcNowSource = () => clock.Now;
            }

            public void Dispose()
            {
                AWSConfigs.utcNowSource = _savedUtcNowSource;
                AWSConfigs.ManualClockCorrection = _savedManualClockCorrection;
            }
        }

        /// <summary>
        /// Captures every message the SDK logger emits by registering a temporary <see cref="IAdaptorLoggerFactory"/>.
        /// Registering clears the logger cache, so credentials under test must be constructed inside the using scope.
        /// </summary>
        private sealed class LogCapture : IDisposable
        {
            public sealed class Entry
            {
                public SdkLogLevel Level { get; set; }
                public string Message { get; set; }
                /// <summary>The type the logger was created for.</summary>
                public Type Source { get; set; }
            }

            private readonly string _factoryName = "credential-sso-capture-" + Guid.NewGuid().ToString("N");
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

            private void Add(SdkLogLevel level, string message, Type source)
            {
                lock (_sync) { _entries.Add(new Entry { Level = level, Message = message, Source = source }); }
            }

            private sealed class Factory : IAdaptorLoggerFactory
            {
                private readonly LogCapture _owner;
                public Factory(string name, LogCapture owner) { Name = name; _owner = owner; }
                public string Name { get; }
                public IAdaptorLogger CreateAdaptorLogger(Type type) => new Adaptor(_owner, type);
            }

            private sealed class Adaptor : IAdaptorLogger
            {
                private readonly LogCapture _owner;
                private readonly Type _source;
                public Adaptor(LogCapture owner, Type source) { _owner = owner; _source = source; }
                public bool IsEnabled(SdkLogLevel level) => true;
                public void Log(SdkLogLevel level, string message, Exception ex, params object[] parameters)
                    => _owner.Add(level, parameters == null || parameters.Length == 0
                        ? message
                        : string.Format(CultureInfo.CurrentCulture, message, parameters), _source);
            }
        }

        #endregion
    }
}
