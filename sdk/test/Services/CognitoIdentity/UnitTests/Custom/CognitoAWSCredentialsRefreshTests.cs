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
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoIdentity;
using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.SecurityToken;
using Amazon.Util;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for how <see cref="CognitoAWSCredentials"/> classifies refresh failures. A rejected identity or login
    /// (<see cref="NotAuthorizedException"/>) is non-recoverable and is raised to the caller at once; other failures
    /// are recoverable, so the cached credentials are served while refresh attempts back off. A class that overrides
    /// only the synchronous RefreshIdentity, as developer authenticated identities do, gets that override on the
    /// asynchronous path too, which the background refresh uses.
    /// </summary>
    [TestClass]
    public class CognitoAWSCredentialsRefreshTests
    {
        private const string TestIdentityPoolId = "us-east-1:00000000-0000-0000-0000-000000000000";
        private const string IdentityId = "us-east-1:11111111-1111-1111-1111-111111111111";
        private const string UnauthenticatedRoleArn = "arn:aws:iam::123456789012:role/cognito-unauthenticated";

        private sealed class ClassifierProbe : CognitoAWSCredentials
        {
            public ClassifierProbe()
                : base(null, TestIdentityPoolId, null, null, new Mock<IAmazonCognitoIdentity>().Object, null) { }

            public bool IsNonRecoverable(Exception e) => IsNonRecoverableError(e);
            public bool InScopeForRefreshLifecycle => UsesManagedRefreshLifecycle;
        }

        private static NotAuthorizedException ExpiredLogin() =>
            new NotAuthorizedException("Invalid login token. Token expired: 1700000000 >= 1690000000", null,
                ErrorType.Sender, "NotAuthorizedException", "req-id", HttpStatusCode.BadRequest);

        private static InternalErrorException ServiceFailure() =>
            new InternalErrorException("Internal error", null, ErrorType.Receiver, "InternalErrorException", "req-id",
                HttpStatusCode.InternalServerError);

        // A 30 second lifetime is shorter than the one minute expiration buffer, so the next call is a blocking
        // refresh that has cached credentials to fall back on.
        private static DateTime ShortExpiration() => AWSSDKUtils.CorrectedUtcNow.AddSeconds(30);

        [TestMethod]
        public void CognitoAWSCredentials_IsInScopeForTheRefreshLifecycle()
        {
            // CognitoAWSCredentials is one of the built-in providers the credential refresh lifecycle covers (static
            // stability, refresh backoff, non-recoverable error caching and invalidation).
            Assert.IsTrue(new ClassifierProbe().InScopeForRefreshLifecycle);
        }

        [TestMethod]
        public void NotAuthorizedException_IsNonRecoverable()
        {
            var probe = new ClassifierProbe();

            Assert.IsTrue(probe.IsNonRecoverable(ExpiredLogin()));
            Assert.IsTrue(probe.IsNonRecoverable(new NotAuthorizedException("Logins don't match.")));
        }

        [TestMethod]
        public void OtherErrors_KeepTheBaseClassification()
        {
            var probe = new ClassifierProbe();

            Assert.IsFalse(probe.IsNonRecoverable(ServiceFailure()));
            Assert.IsFalse(probe.IsNonRecoverable(new TooManyRequestsException("Rate exceeded")));
            Assert.IsFalse(probe.IsNonRecoverable(new System.IO.IOException("The connection was reset.")));
            Assert.IsTrue(probe.IsNonRecoverable(new AmazonNonRecoverableCredentialsException("reauthenticate")));
            Assert.IsTrue(probe.IsNonRecoverable(new AmazonServiceException("denied", ErrorType.Sender, "AccessDenied",
                "req-id", HttpStatusCode.Forbidden)), "an STS rejection in the role flow stays non-recoverable");
        }

        #region Enhanced flow (GetId + GetCredentialsForIdentity)

        private static Mock<IAmazonCognitoIdentity> CognitoWithPoolCredentials(Func<int, GetCredentialsForIdentityResponse> respond)
        {
            var cognito = new Mock<IAmazonCognitoIdentity>();
            var calls = 0;
            var getId = new GetIdResponse { IdentityId = IdentityId };
#if NETFRAMEWORK
            cognito.Setup(x => x.GetId(It.IsAny<GetIdRequest>())).Returns(getId);
            cognito.Setup(x => x.GetCredentialsForIdentity(It.IsAny<GetCredentialsForIdentityRequest>()))
                   .Returns(() => respond(Interlocked.Increment(ref calls)));
#endif
            cognito.Setup(x => x.GetIdAsync(It.IsAny<GetIdRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(getId);
            cognito.Setup(x => x.GetCredentialsForIdentityAsync(It.IsAny<GetCredentialsForIdentityRequest>(), It.IsAny<CancellationToken>()))
                   .Returns(() =>
                   {
                       try { return Task.FromResult(respond(Interlocked.Increment(ref calls))); }
                       catch (Exception e) { return Task.FromException<GetCredentialsForIdentityResponse>(e); }
                   });
            return cognito;
        }

        private static GetCredentialsForIdentityResponse PoolCredentials() => new GetCredentialsForIdentityResponse
        {
            IdentityId = IdentityId,
            Credentials = new Amazon.CognitoIdentity.Model.Credentials
            {
                AccessKeyId = "ASIACOGNITO",
                SecretKey = "secret",
                SessionToken = "token",
                Expiration = ShortExpiration()
            }
        };

        private static int CallsTo(Mock<IAmazonCognitoIdentity> cognito, string operation)
        {
            var count = 0;
            foreach (var invocation in cognito.Invocations)
            {
                if (invocation.Method.Name.StartsWith(operation, StringComparison.Ordinal))
                    count++;
            }
            return count;
        }

        [TestMethod]
        public void EnhancedFlow_NotAuthorizedOnRefresh_RaisedImmediately()
        {
            var expiredLogin = ExpiredLogin();
            var cognito = CognitoWithPoolCredentials(call => call == 1 ? PoolCredentials() : throw expiredLogin);
            var creds = new CognitoAWSCredentials(null, TestIdentityPoolId, null, null, cognito.Object, null);
            Assert.AreEqual("ASIACOGNITO", creds.GetCredentials().AccessKey);

            var ex = Assert.ThrowsExactly<NotAuthorizedException>(() => creds.GetCredentials());
            Assert.AreSame(expiredLogin, ex, "the Cognito error reaches the application instead of the cached credentials");

            // No refresh backoff: the error keeps surfacing instead of the cached credentials being served.
            Assert.ThrowsExactly<NotAuthorizedException>(() => creds.GetCredentials());
        }

        [TestMethod]
        public async Task EnhancedFlow_NotAuthorizedOnRefresh_RaisedImmediately_Async()
        {
            var expiredLogin = ExpiredLogin();
            var cognito = CognitoWithPoolCredentials(call => call == 1 ? PoolCredentials() : throw expiredLogin);
            var creds = new CognitoAWSCredentials(null, TestIdentityPoolId, null, null, cognito.Object, null);
            Assert.AreEqual("ASIACOGNITO", (await creds.GetCredentialsAsync()).AccessKey);

            var ex = await Assert.ThrowsExactlyAsync<NotAuthorizedException>(() => creds.GetCredentialsAsync());
            Assert.AreSame(expiredLogin, ex);

            await Assert.ThrowsExactlyAsync<NotAuthorizedException>(() => creds.GetCredentialsAsync());
        }

        [TestMethod]
        public void EnhancedFlow_ServiceFailureOnRefresh_ServesCachedCredentials_AndBacksOff()
        {
            var cognito = CognitoWithPoolCredentials(call => call == 1 ? PoolCredentials() : throw ServiceFailure());
            var creds = new CognitoAWSCredentials(null, TestIdentityPoolId, null, null, cognito.Object, null);
            var cached = creds.GetCredentials();

            Assert.AreEqual(cached, creds.GetCredentials());
            Assert.AreEqual(cached, creds.GetCredentials());
            Assert.AreEqual(2, CallsTo(cognito, "GetCredentialsForIdentity"), "the refresh backoff suppresses the next attempt");
        }

        [TestMethod]
        public async Task EnhancedFlow_ServiceFailureOnRefresh_ServesCachedCredentials_AndBacksOff_Async()
        {
            var cognito = CognitoWithPoolCredentials(call => call == 1 ? PoolCredentials() : throw ServiceFailure());
            var creds = new CognitoAWSCredentials(null, TestIdentityPoolId, null, null, cognito.Object, null);
            var cached = await creds.GetCredentialsAsync();

            Assert.AreEqual(cached, await creds.GetCredentialsAsync());
            Assert.AreEqual(cached, await creds.GetCredentialsAsync());
            Assert.AreEqual(2, CallsTo(cognito, "GetCredentialsForIdentity"));
        }

        #endregion

        #region Classic flow (GetOpenIdToken + STS AssumeRoleWithWebIdentity)

        /// <summary>
        /// Credentials for an unauthenticated role that start from a cached identity and cached, already expired
        /// credentials, as an application that persists them would. The first call is therefore a blocking refresh
        /// that has cached credentials to fall back on, and STS is not reached when GetOpenIdToken fails.
        /// </summary>
        private sealed class CachedRoleCredentials : CognitoAWSCredentials
        {
            public CachedRoleCredentials(IAmazonCognitoIdentity cognito)
                : base(null, TestIdentityPoolId, UnauthenticatedRoleArn, null, cognito, new Mock<IAmazonSecurityTokenService>().Object) { }

            public override string GetCachedIdentityId() => IdentityId;

            public override CredentialsRefreshState GetCachedCredentials() =>
                new CredentialsRefreshState(new ImmutableCredentials("ASIACACHED", "secret", "token"), AWSSDKUtils.CorrectedUtcNow.AddMinutes(-1));
        }

        private static Mock<IAmazonCognitoIdentity> CognitoWithOpenIdTokenError(Exception error)
        {
            var cognito = new Mock<IAmazonCognitoIdentity>();
#if NETFRAMEWORK
            cognito.Setup(x => x.GetOpenIdToken(It.IsAny<GetOpenIdTokenRequest>())).Throws(error);
#endif
            cognito.Setup(x => x.GetOpenIdTokenAsync(It.IsAny<GetOpenIdTokenRequest>(), It.IsAny<CancellationToken>()))
                   .ThrowsAsync(error);
            return cognito;
        }

        [TestMethod]
        public void ClassicFlow_NotAuthorizedOnRefresh_RaisedImmediately()
        {
            var expiredLogin = ExpiredLogin();
            var creds = new CachedRoleCredentials(CognitoWithOpenIdTokenError(expiredLogin).Object);

            var ex = Assert.ThrowsExactly<NotAuthorizedException>(() => creds.GetCredentials());
            Assert.AreSame(expiredLogin, ex, "the Cognito error reaches the application instead of the cached credentials");
            Assert.ThrowsExactly<NotAuthorizedException>(() => creds.GetCredentials());
        }

        [TestMethod]
        public async Task ClassicFlow_NotAuthorizedOnRefresh_RaisedImmediately_Async()
        {
            var expiredLogin = ExpiredLogin();
            var creds = new CachedRoleCredentials(CognitoWithOpenIdTokenError(expiredLogin).Object);

            var ex = await Assert.ThrowsExactlyAsync<NotAuthorizedException>(() => creds.GetCredentialsAsync());
            Assert.AreSame(expiredLogin, ex);
            await Assert.ThrowsExactlyAsync<NotAuthorizedException>(() => creds.GetCredentialsAsync());
        }

        [TestMethod]
        public void ClassicFlow_ServiceFailureOnRefresh_ServesCachedCredentials()
        {
            var creds = new CachedRoleCredentials(CognitoWithOpenIdTokenError(ServiceFailure()).Object);

            Assert.AreEqual("ASIACACHED", creds.GetCredentials().AccessKey);
        }

        [TestMethod]
        public async Task ClassicFlow_ServiceFailureOnRefresh_ServesCachedCredentials_Async()
        {
            var creds = new CachedRoleCredentials(CognitoWithOpenIdTokenError(ServiceFailure()).Object);

            Assert.AreEqual("ASIACACHED", (await creds.GetCredentialsAsync()).AccessKey);
        }

        #endregion

        #region Developer authenticated identities

        private const string DeveloperProvider = "login.example.com";
        private const string CognitoLoginKey = "cognito-identity.amazonaws.com";
        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(30);

        private static string DeveloperToken(int refreshIdentityCall) => "developer-token-" + refreshIdentityCall;

        /// <summary>
        /// Developer authenticated identities as the .NET documentation shows them: a class that overrides only the
        /// synchronous RefreshIdentity, which returns the identity with a new token for the developer provider each time.
        /// </summary>
        private sealed class DeveloperAuthenticatedCredentials : CognitoAWSCredentials
        {
            private int _refreshIdentityCalls;

            public DeveloperAuthenticatedCredentials(IAmazonCognitoIdentity cognito)
                : base(null, TestIdentityPoolId, null, null, cognito, null) { }

            public int RefreshIdentityCalls => Volatile.Read(ref _refreshIdentityCalls);

            protected override IdentityState RefreshIdentity()
            {
                var call = Interlocked.Increment(ref _refreshIdentityCalls);
                return new IdentityState(IdentityId, DeveloperProvider, DeveloperToken(call), false);
            }
        }

        /// <summary>
        /// Cognito that accepts GetCredentialsForIdentity only with the latest developer token under the
        /// cognito-identity.amazonaws.com login, and otherwise rejects it with NotAuthorizedException, as Cognito rejects
        /// a stale or missing developer token. Records the token of each request. The credentials expire 60 minutes after
        /// the SDK clock's current time.
        /// </summary>
        private static Mock<IAmazonCognitoIdentity> CognitoRequiringLatestDeveloperToken(Func<int> refreshIdentityCalls, List<string> sentTokens)
        {
            Func<GetCredentialsForIdentityRequest, GetCredentialsForIdentityResponse> respond = request =>
            {
                string token = null;
                request.Logins?.TryGetValue(CognitoLoginKey, out token);
                int sent;
                lock (sentTokens)
                {
                    sentTokens.Add(token);
                    sent = sentTokens.Count;
                }
                if (token != DeveloperToken(refreshIdentityCalls()))
                    throw new NotAuthorizedException("Invalid login token.");
                return new GetCredentialsForIdentityResponse
                {
                    IdentityId = IdentityId,
                    Credentials = new Amazon.CognitoIdentity.Model.Credentials
                    {
                        AccessKeyId = "ASIADEVELOPER" + sent,
                        SecretKey = "secret",
                        SessionToken = "token",
                        Expiration = AWSSDKUtils.CorrectedUtcNow.AddMinutes(60)
                    }
                };
            };

            var cognito = new Mock<IAmazonCognitoIdentity>();
#if NETFRAMEWORK
            cognito.Setup(x => x.GetCredentialsForIdentity(It.IsAny<GetCredentialsForIdentityRequest>())).Returns(respond);
#endif
            cognito.Setup(x => x.GetCredentialsForIdentityAsync(It.IsAny<GetCredentialsForIdentityRequest>(), It.IsAny<CancellationToken>()))
                   .Returns((GetCredentialsForIdentityRequest request, CancellationToken cancellationToken) =>
                   {
                       try { return Task.FromResult(respond(request)); }
                       catch (Exception e) { return Task.FromException<GetCredentialsForIdentityResponse>(e); }
                   });
            return cognito;
        }

        // An application that uses the synchronous API: the first fetch runs on the caller's thread, and the refresh
        // before the credentials expire runs in the background on the asynchronous path. Both use the override.
        [TestMethod]
        [DoNotParallelize]
        public void DeveloperAuthenticated_OnlySyncRefreshIdentityOverridden_BackgroundRefreshUsesTheOverride()
        {
            var now = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            using (new AWSConfigsDateFaker(() => now))
            {
                var sentTokens = new List<string>();
                DeveloperAuthenticatedCredentials creds = null;
                var cognito = CognitoRequiringLatestDeveloperToken(() => creds.RefreshIdentityCalls, sentTokens);
                creds = new DeveloperAuthenticatedCredentials(cognito.Object);

                var first = creds.GetCredentials();
                Assert.AreEqual(1, creds.RefreshIdentityCalls);
                var firstExpiration = creds.Expiration;

                // Inside the 15-minute background refresh window of the 60-minute credentials: the cached credentials
                // are returned and refreshed in the background.
                now = now.AddMinutes(50);
                Assert.AreEqual(first.AccessKey, creds.GetCredentials().AccessKey);
                Assert.IsTrue(SpinWait.SpinUntil(() => SentCount(sentTokens) >= 2, WaitTimeout), "the background refresh did not call Cognito");
                Assert.AreEqual(2, creds.RefreshIdentityCalls, "the background refresh must get the identity from the override");
                lock (sentTokens)
                    Assert.AreEqual(DeveloperToken(2), sentTokens[1], "the background refresh must send the token from the override");

                Assert.IsTrue(SpinWait.SpinUntil(() => creds.Expiration != firstExpiration, WaitTimeout), "the background refresh did not replace the credentials");
                Assert.AreEqual("ASIADEVELOPER2", creds.GetCredentials().AccessKey);
            }
        }

        [TestMethod]
        [DoNotParallelize]
        public async Task DeveloperAuthenticated_OnlySyncRefreshIdentityOverridden_AsyncMethodsUseTheOverride()
        {
            var sentTokens = new List<string>();
            DeveloperAuthenticatedCredentials creds = null;
            var cognito = CognitoRequiringLatestDeveloperToken(() => creds.RefreshIdentityCalls, sentTokens);
            creds = new DeveloperAuthenticatedCredentials(cognito.Object);

            Assert.AreEqual("ASIADEVELOPER1", (await creds.GetCredentialsAsync()).AccessKey);
            Assert.AreEqual(1, creds.RefreshIdentityCalls);
            lock (sentTokens)
                Assert.AreEqual(DeveloperToken(1), sentTokens[0]);
        }

        private static int SentCount(List<string> sentTokens)
        {
            lock (sentTokens)
                return sentTokens.Count;
        }

        #endregion
    }
}
