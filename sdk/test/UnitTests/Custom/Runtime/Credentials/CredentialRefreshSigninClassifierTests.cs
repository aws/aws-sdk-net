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
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Signin;
using Amazon.Signin.Model;
using Amazon.Util;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// The non-recoverable credential error classifier must read the Sign-In OAuth2 discriminator, which the service
    /// returns on <see cref="AccessDeniedException.Error"/> while the base wire <c>ErrorCode</c> is the generic type
    /// name "AccessDeniedException". These tests use the <b>real modeled</b>
    /// <see cref="Amazon.Signin.Model.AccessDeniedException"/> rather than a synthetic ErrorCode string, which a test
    /// built on a bare <see cref="AmazonServiceException"/> cannot cover.
    /// <para/>
    /// This file lives apart from CredentialRefreshBehaviorTests.cs because it takes a dependency on the Signin
    /// service package. The manually maintained AWSSDK.UnitTests.Core project (embedded in every service
    /// solution) may only reference S3/SecurityToken/SimpleNotificationService/DynamoDBv2, so it excludes this
    /// file; the full NetStandard/NetFramework unit-test projects glob-reference every service and run it.
    /// </summary>
    [TestClass]
    public sealed class CredentialRefreshSigninClassifierTests
    {
        /// <summary>
        /// Minimal concrete <see cref="RefreshingAWSCredentials"/> that exposes the protected
        /// <c>IsNonRecoverableError</c> classifier for direct assertion. Classification does not depend on whether the
        /// provider is in scope for the refresh lifecycle, so no other configuration is needed.
        /// </summary>
        private sealed class ClassifierProbe : RefreshingAWSCredentials
        {
            public bool IsNonRecoverable(Exception e) => IsNonRecoverableError(e);
        }

        private static AccessDeniedException RealSigninAccessDenied(OAuth2ErrorCode error)
        {
            // The real unmarshaller sets base ErrorCode = "AccessDeniedException" (the modeled type name) and
            // carries the OAuth2 discriminator on .Error -- reproduce that shape exactly.
            return new AccessDeniedException(
                "access denied", ErrorType.Sender, "AccessDeniedException", "req-id", HttpStatusCode.Forbidden)
            {
                Error = error
            };
        }

        [TestMethod]
        public void RealSigninAccessDenied_OAuthMembersRequiringReauthentication_NonRecoverable()
        {
            var probe = new ClassifierProbe();

            foreach (var member in new[]
            {
                OAuth2ErrorCode.TOKEN_EXPIRED,
                OAuth2ErrorCode.USER_CREDENTIALS_CHANGED,
                OAuth2ErrorCode.INSUFFICIENT_PERMISSIONS,
            })
            {
                var ex = RealSigninAccessDenied(member);
                Assert.IsTrue(
                    probe.IsNonRecoverable(ex),
                    $"real Sign-In AccessDeniedException with .Error={member.Value} must be non-recoverable");
            }
        }

        [TestMethod]
        public void RealSigninAccessDenied_AuthCodeExpired_Recoverable()
        {
            var probe = new ClassifierProbe();

            // AUTHCODE_EXPIRED is a real OAuth2 member but is deliberately recoverable.
            var ex = RealSigninAccessDenied(OAuth2ErrorCode.AUTHCODE_EXPIRED);
            Assert.IsFalse(
                probe.IsNonRecoverable(ex),
                "real Sign-In AccessDeniedException with .Error=AUTHCODE_EXPIRED must stay recoverable");
        }

        [TestMethod]
        public void RealSigninAccessDenied_UnrelatedOrEmptyError_Recoverable()
        {
            var probe = new ClassifierProbe();

            // An unrelated OAuth2 member falls outside the non-recoverable set.
            var unrelated = RealSigninAccessDenied(OAuth2ErrorCode.CONFLICT);
            Assert.IsFalse(
                probe.IsNonRecoverable(unrelated),
                "real Sign-In AccessDeniedException with an unrelated .Error must stay recoverable");

            // Error unset (null): the classifier falls back to the base ErrorCode "AccessDeniedException",
            // which is NOT in the set (bare type name is not auto-non-recoverable).
            var emptyError = new AccessDeniedException(
                "access denied", ErrorType.Sender, "AccessDeniedException", "req-id", HttpStatusCode.Forbidden);
            Assert.IsNull(emptyError.Error, "guard: .Error is expected to be unset for this case");
            Assert.IsFalse(
                probe.IsNonRecoverable(emptyError),
                "real Sign-In AccessDeniedException with no .Error must stay recoverable via ErrorCode fallback");
        }

        [TestMethod]
        public void StsAndPlainServiceExceptions_ClassifiedByErrorCode()
        {
            var probe = new ClassifierProbe();

            // A plain (non-Sign-In) AmazonServiceException has no OAuth2 Error member, so classification uses its
            // ErrorCode. STS AccessDenied is one of the STS error codes that the credential refresh specification lists
            // as non-recoverable.
            var stsAccessDenied = new AmazonServiceException(
                "denied", ErrorType.Sender, "AccessDenied", "req-id", HttpStatusCode.Forbidden);
            Assert.IsTrue(
                probe.IsNonRecoverable(stsAccessDenied),
                "STS AccessDenied is classified by its ErrorCode and is non-recoverable");

            // A transient STS-style error is recoverable.
            var throttling = new AmazonServiceException(
                "throttled", ErrorType.Sender, "ThrottlingException", "req-id", HttpStatusCode.ServiceUnavailable);
            Assert.IsFalse(
                probe.IsNonRecoverable(throttling),
                "a transient STS-style error must stay recoverable");
        }

        #region LoginTokenManager with real Sign-In errors

        private const string NonRecoverableLoginMessage = "Login Token has expired and failed to refresh. Please reauthenticate.";
        private const string RecoverableLoginMessage = "Login Token has expired and failed to refresh.";

        private static OAuth2ErrorCode SigninError(string value) => new OAuth2ErrorCode(value);

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

        private static LoginTokenManagerGetTokenOptions LoginOptions() =>
            new LoginTokenManagerGetTokenOptions { LoginSession = "signin-classifier-" + Guid.NewGuid().ToString("N") };

        private static async Task WithSdkCacheAsync(bool enabled, Func<Task> body)
        {
            var original = AWSConfigs.UseSdkCache;
            AWSConfigs.UseSdkCache = enabled;
            try { await body(); }
            finally { AWSConfigs.UseSdkCache = original; }
        }

        [TestMethod]
        [DataRow("TOKEN_EXPIRED")]
        [DataRow("USER_CREDENTIALS_CHANGED")]
        [DataRow("INSUFFICIENT_PERMISSIONS")]
        public async Task LoginTokenManager_ExpiredToken_SigninRejectsRefresh_ThrowsNonRecoverable_Async(string error)
        {
            await WithSdkCacheAsync(false, async () =>
            {
                var rejection = RealSigninAccessDenied(SigninError(error));
                var manager = new LoginTokenManager(SigninThrowing(rejection).Object,
                    LoginFileCacheReturning(RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(-5))).Object);

                var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(
                    () => manager.GetTokenAsync(LoginOptions()));

                Assert.AreEqual(NonRecoverableLoginMessage, ex.Message);
                Assert.AreSame(rejection, ex.InnerException);
            });
        }

        private static ValidationException RealSigninValidationException() => new ValidationException(
            "The provided authorization grant is invalid, expired, revoked, or malformed", ErrorType.Sender,
            "ValidationException", "req-id", HttpStatusCode.BadRequest);

        // Sign-In rejects the refresh token with a ValidationException: the session must be re-established, so the
        // error is non-recoverable.
        [TestMethod]
        public async Task LoginTokenManager_ExpiredToken_SigninValidationException_ThrowsNonRecoverable_Async()
        {
            await WithSdkCacheAsync(false, async () =>
            {
                var rejection = RealSigninValidationException();
                var manager = new LoginTokenManager(SigninThrowing(rejection).Object,
                    LoginFileCacheReturning(RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(-5))).Object);

                var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(
                    () => manager.GetTokenAsync(LoginOptions()));

                Assert.AreEqual(NonRecoverableLoginMessage, ex.Message);
                Assert.AreSame(rejection, ex.InnerException);
            });
        }

        // ValidationException is non-recoverable only for the Sign-In refresh: the classifier that every provider uses
        // keeps it recoverable, because other services use the same code for errors that are not about credentials.
        [TestMethod]
        public void GeneralClassifier_ValidationException_StaysRecoverable()
        {
            var probe = new ClassifierProbe();
            Assert.IsFalse(probe.IsNonRecoverable(RealSigninValidationException()));
            Assert.IsFalse(probe.IsNonRecoverable(new AmazonServiceException("invalid", null, ErrorType.Sender,
                "ValidationException", "req-id", HttpStatusCode.BadRequest)));
        }

        [TestMethod]
        [DataRow("AUTHCODE_EXPIRED")]
        [DataRow("server_error")]
        [DataRow(null)]
        public async Task LoginTokenManager_ExpiredToken_OtherSigninAccessDenied_ThrowsRecoverable_Async(string error)
        {
            await WithSdkCacheAsync(false, async () =>
            {
                var rejection = error == null
                    ? new AccessDeniedException("access denied", ErrorType.Sender, "AccessDeniedException", "req-id", HttpStatusCode.Forbidden)
                    : RealSigninAccessDenied(SigninError(error));
                var manager = new LoginTokenManager(SigninThrowing(rejection).Object,
                    LoginFileCacheReturning(RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(-5))).Object);

                var ex = await Assert.ThrowsExactlyAsync<AmazonClientException>(() => manager.GetTokenAsync(LoginOptions()));

                Assert.AreEqual(RecoverableLoginMessage + " " + ex.InnerException?.Message, ex.Message);
                Assert.AreSame(rejection, ex.InnerException);
            });
        }

        private const string NonRecoverableValidTokenLoginMessage = "Login Token failed to refresh. Please reauthenticate.";
        private const string CooldownValidTokenLoginMessage = "Login Token cannot be refreshed. Please reauthenticate.";

        // A non-recoverable rejection is raised even while the token has not expired, so the caller sees "Please
        // reauthenticate." at once. During the 30-second cooldown it is raised again without calling Sign-In.
        [TestMethod]
        public async Task LoginTokenManager_SigninRejectsRefreshBeforeExpiry_ThrowsNonRecoverable_NoSigninCallDuringCooldown_Async()
        {
            await WithSdkCacheAsync(true, async () =>
            {
                var now = AWSSDKUtils.CorrectedUtcNow;
                using (new AWSConfigsDateFaker(() => now))
                {
                    var t0 = now;
                    var token = RefreshableLoginToken(t0.AddMinutes(3)); // inside the refresh window, not expired
                    var rejection = RealSigninAccessDenied(OAuth2ErrorCode.TOKEN_EXPIRED);
                    var signin = SigninThrowing(rejection);
                    var manager = new LoginTokenManager(signin.Object, LoginFileCacheReturning(token).Object);
                    var options = LoginOptions();

                    var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => manager.GetTokenAsync(options));
                    Assert.AreEqual(NonRecoverableValidTokenLoginMessage, ex.Message);
                    Assert.AreSame(rejection, ex.InnerException);
                    Assert.AreEqual(1, signin.Invocations.Count);

                    now = t0.AddSeconds(10);
                    ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => manager.GetTokenAsync(options));
                    Assert.AreEqual(CooldownValidTokenLoginMessage, ex.Message);
                    Assert.AreEqual(1, signin.Invocations.Count, "no Sign-In call during the cooldown");

                    now = t0.AddSeconds(31);
                    ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => manager.GetTokenAsync(options));
                    Assert.AreEqual(NonRecoverableValidTokenLoginMessage, ex.Message);
                    Assert.AreEqual(2, signin.Invocations.Count, "the refresh is attempted again after the cooldown");
                }
            });
        }

        // A service rejected the token's credentials (Invalidate) while the token is outside its refresh window, and
        // Sign-In then rejects the refresh token: the error is raised instead of returning the rejected token.
        [TestMethod]
        public async Task LoginTokenManager_RejectedKey_ValidToken_SigninValidationException_ThrowsNonRecoverable_Async()
        {
            await WithSdkCacheAsync(true, async () =>
            {
                var token = RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(13));
                var rejection = RealSigninValidationException();
                var signin = SigninThrowing(rejection);
                var manager = new LoginTokenManager(signin.Object, LoginFileCacheReturning(token).Object);
                var options = LoginOptions();
                options.RejectedAccessKeyId = token.AccessToken.AccessKey;

                var ex = await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => manager.GetTokenAsync(options));

                Assert.AreEqual(NonRecoverableValidTokenLoginMessage, ex.Message);
                Assert.AreSame(rejection, ex.InnerException);
                Assert.AreEqual(1, signin.Invocations.Count);
            });
        }

        // The same with a transient Sign-In failure: it is raised as recoverable, so the credential provider keeps its
        // cached credentials and refreshes again after its backoff, instead of publishing the rejected token as new.
        [TestMethod]
        public async Task LoginTokenManager_RejectedKey_ValidToken_TransientFailure_ThrowsRecoverable_Async()
        {
            await WithSdkCacheAsync(true, async () =>
            {
                var token = RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(13));
                var throttled = new AmazonServiceException("Rate exceeded", null, ErrorType.Sender, "ThrottlingException", "req-id", (HttpStatusCode)429);
                var manager = new LoginTokenManager(SigninThrowing(throttled).Object, LoginFileCacheReturning(token).Object);
                var options = LoginOptions();
                options.RejectedAccessKeyId = token.AccessToken.AccessKey;

                var ex = await Assert.ThrowsExactlyAsync<AmazonClientException>(() => manager.GetTokenAsync(options));

                Assert.AreEqual("Login Token failed to refresh. Rate exceeded", ex.Message);
                Assert.AreSame(throttled, ex.InnerException);
            });
        }

#if NETFRAMEWORK
        // The synchronous LoginTokenManager.GetToken exists only on .NET Framework.
        private static void WithSdkCache(bool enabled, Action body)
        {
            var original = AWSConfigs.UseSdkCache;
            AWSConfigs.UseSdkCache = enabled;
            try { body(); }
            finally { AWSConfigs.UseSdkCache = original; }
        }

        [TestMethod]
        [DataRow("TOKEN_EXPIRED")]
        [DataRow("USER_CREDENTIALS_CHANGED")]
        [DataRow("INSUFFICIENT_PERMISSIONS")]
        public void LoginTokenManager_ExpiredToken_SigninRejectsRefresh_ThrowsNonRecoverable(string error)
        {
            WithSdkCache(false, () =>
            {
                var rejection = RealSigninAccessDenied(SigninError(error));
                var manager = new LoginTokenManager(SigninThrowing(rejection).Object,
                    LoginFileCacheReturning(RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(-5))).Object);

                var ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => manager.GetToken(LoginOptions()));

                Assert.AreEqual(NonRecoverableLoginMessage, ex.Message);
                Assert.AreSame(rejection, ex.InnerException);
            });
        }

        [TestMethod]
        public void LoginTokenManager_ExpiredToken_SigninValidationException_ThrowsNonRecoverable()
        {
            WithSdkCache(false, () =>
            {
                var rejection = RealSigninValidationException();
                var manager = new LoginTokenManager(SigninThrowing(rejection).Object,
                    LoginFileCacheReturning(RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(-5))).Object);

                var ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => manager.GetToken(LoginOptions()));

                Assert.AreEqual(NonRecoverableLoginMessage, ex.Message);
                Assert.AreSame(rejection, ex.InnerException);
            });
        }

        [TestMethod]
        [DataRow("AUTHCODE_EXPIRED")]
        [DataRow("server_error")]
        public void LoginTokenManager_ExpiredToken_OtherSigninAccessDenied_ThrowsRecoverable(string error)
        {
            WithSdkCache(false, () =>
            {
                var rejection = RealSigninAccessDenied(SigninError(error));
                var manager = new LoginTokenManager(SigninThrowing(rejection).Object,
                    LoginFileCacheReturning(RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(-5))).Object);

                var ex = Assert.ThrowsExactly<AmazonClientException>(() => manager.GetToken(LoginOptions()));

                Assert.AreEqual(RecoverableLoginMessage + " " + ex.InnerException?.Message, ex.Message);
                Assert.AreSame(rejection, ex.InnerException);
            });
        }

        [TestMethod]
        public void LoginTokenManager_SigninRejectsRefreshBeforeExpiry_ThrowsNonRecoverable_NoSigninCallDuringCooldown()
        {
            WithSdkCache(true, () =>
            {
                var now = AWSSDKUtils.CorrectedUtcNow;
                using (new AWSConfigsDateFaker(() => now))
                {
                    var t0 = now;
                    var token = RefreshableLoginToken(t0.AddMinutes(3));
                    var signin = SigninThrowing(RealSigninAccessDenied(OAuth2ErrorCode.TOKEN_EXPIRED));
                    var manager = new LoginTokenManager(signin.Object, LoginFileCacheReturning(token).Object);
                    var options = LoginOptions();

                    var ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => manager.GetToken(options));
                    Assert.AreEqual(NonRecoverableValidTokenLoginMessage, ex.Message);
                    Assert.AreEqual(1, signin.Invocations.Count);

                    now = t0.AddSeconds(10);
                    ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => manager.GetToken(options));
                    Assert.AreEqual(CooldownValidTokenLoginMessage, ex.Message);
                    Assert.AreEqual(1, signin.Invocations.Count);

                    now = t0.AddSeconds(31);
                    Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => manager.GetToken(options));
                    Assert.AreEqual(2, signin.Invocations.Count);
                }
            });
        }

        [TestMethod]
        public void LoginTokenManager_RejectedKey_ValidToken_SigninValidationException_ThrowsNonRecoverable()
        {
            WithSdkCache(true, () =>
            {
                var token = RefreshableLoginToken(AWSSDKUtils.CorrectedUtcNow.AddMinutes(13));
                var rejection = RealSigninValidationException();
                var manager = new LoginTokenManager(SigninThrowing(rejection).Object, LoginFileCacheReturning(token).Object);
                var options = LoginOptions();
                options.RejectedAccessKeyId = token.AccessToken.AccessKey;

                var ex = Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(() => manager.GetToken(options));

                Assert.AreEqual(NonRecoverableValidTokenLoginMessage, ex.Message);
                Assert.AreSame(rejection, ex.InnerException);
            });
        }
#endif

        #endregion
    }
}
