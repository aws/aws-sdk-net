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
using Amazon.CognitoIdentity;
using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Cognito errors that require a change by the application or to the identity pool before credentials can be
    /// obtained: a deleted identity pool or identity (<see cref="ResourceNotFoundException"/>) and an identity pool
    /// whose role cannot be used (<see cref="InvalidIdentityPoolConfigurationException"/>). Earlier versions of the SDK
    /// raised them to the caller on every refresh, so they are non-recoverable: raised immediately instead of the
    /// cached credentials being served while refresh attempts back off.
    /// </summary>
    [TestClass]
    public class CognitoCredentialRefreshCompatibilityTests
    {
        private const string TestIdentityPoolId = "us-east-1:00000000-0000-0000-0000-000000000000";
        private const string IdentityId = "us-east-1:11111111-1111-1111-1111-111111111111";

        private sealed class ClassifierProbe : CognitoAWSCredentials
        {
            public ClassifierProbe()
                : base(null, TestIdentityPoolId, null, null, new Mock<IAmazonCognitoIdentity>().Object, null) { }

            public bool IsNonRecoverable(Exception e) => IsNonRecoverableError(e);
        }

        // Built as the service's unmarshallers build them: the modeled type with its wire error code.
        private static AmazonCognitoIdentityException CognitoError(string errorCode)
        {
            switch (errorCode)
            {
                case "ResourceNotFoundException":
                    return new ResourceNotFoundException("Identity 'us-east-1:1111' not found.", null, ErrorType.Sender,
                        errorCode, "req-id", HttpStatusCode.BadRequest);
                case "InvalidIdentityPoolConfigurationException":
                    return new InvalidIdentityPoolConfigurationException("Invalid identity pool configuration. Check assigned IAM roles for this pool.",
                        null, ErrorType.Sender, errorCode, "req-id", HttpStatusCode.BadRequest);
                default:
                    throw new ArgumentOutOfRangeException(nameof(errorCode));
            }
        }

        [TestMethod]
        [DataRow("ResourceNotFoundException")]
        [DataRow("InvalidIdentityPoolConfigurationException")]
        public void CustomerActionRequiredErrors_AreNonRecoverable(string errorCode)
        {
            Assert.IsTrue(new ClassifierProbe().IsNonRecoverable(CognitoError(errorCode)));
        }

        [TestMethod]
        public void OtherCognitoErrors_StayRecoverable()
        {
            var probe = new ClassifierProbe();
            Assert.IsFalse(probe.IsNonRecoverable(new InternalErrorException("Internal error")));
            Assert.IsFalse(probe.IsNonRecoverable(new TooManyRequestsException("Rate exceeded")));
            Assert.IsFalse(probe.IsNonRecoverable(new ExternalServiceException("The identity provider is unavailable.")));
            Assert.IsFalse(probe.IsNonRecoverable(new ResourceConflictException("Conflict")));
        }

        private static Mock<IAmazonCognitoIdentity> CognitoFailingAfterFirstCall(Exception error)
        {
            var cognito = new Mock<IAmazonCognitoIdentity>();
            var calls = 0;
            var getId = new GetIdResponse { IdentityId = IdentityId };
            Func<GetCredentialsForIdentityResponse> respond = () =>
            {
                if (Interlocked.Increment(ref calls) > 1)
                    throw error;
                return new GetCredentialsForIdentityResponse
                {
                    IdentityId = IdentityId,
                    Credentials = new Amazon.CognitoIdentity.Model.Credentials
                    {
                        AccessKeyId = "ASIACOGNITO",
                        SecretKey = "secret",
                        SessionToken = "token",
                        // Shorter than the one minute expiration buffer, so the next call is a blocking refresh that
                        // has cached credentials to fall back on.
                        Expiration = AWSSDKUtils.CorrectedUtcNow.AddSeconds(30)
                    }
                };
            };
#if NETFRAMEWORK
            cognito.Setup(x => x.GetId(It.IsAny<GetIdRequest>())).Returns(getId);
            cognito.Setup(x => x.GetCredentialsForIdentity(It.IsAny<GetCredentialsForIdentityRequest>())).Returns(respond);
#endif
            cognito.Setup(x => x.GetIdAsync(It.IsAny<GetIdRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(getId);
            cognito.Setup(x => x.GetCredentialsForIdentityAsync(It.IsAny<GetCredentialsForIdentityRequest>(), It.IsAny<CancellationToken>()))
                   .Returns(() =>
                   {
                       try { return Task.FromResult(respond()); }
                       catch (Exception e) { return Task.FromException<GetCredentialsForIdentityResponse>(e); }
                   });
            return cognito;
        }

        [TestMethod]
        [DataRow("ResourceNotFoundException")]
        [DataRow("InvalidIdentityPoolConfigurationException")]
        public void CustomerActionRequiredErrorOnRefresh_RaisedImmediately(string errorCode)
        {
            var error = CognitoError(errorCode);
            var creds = new CognitoAWSCredentials(null, TestIdentityPoolId, null, null, CognitoFailingAfterFirstCall(error).Object, null);
            Assert.AreEqual("ASIACOGNITO", creds.GetCredentials().AccessKey);

            Exception raised = null;
            try { creds.GetCredentials(); }
            catch (Exception e) { raised = e; }
            Assert.AreSame(error, raised, "the Cognito error reaches the application instead of the cached credentials");
        }

        [TestMethod]
        [DataRow("ResourceNotFoundException")]
        [DataRow("InvalidIdentityPoolConfigurationException")]
        public async Task CustomerActionRequiredErrorOnRefresh_RaisedImmediately_Async(string errorCode)
        {
            var error = CognitoError(errorCode);
            var creds = new CognitoAWSCredentials(null, TestIdentityPoolId, null, null, CognitoFailingAfterFirstCall(error).Object, null);
            Assert.AreEqual("ASIACOGNITO", (await creds.GetCredentialsAsync()).AccessKey);

            Exception raised = null;
            try { await creds.GetCredentialsAsync(); }
            catch (Exception e) { raised = e; }
            Assert.AreSame(error, raised, "the Cognito error reaches the application instead of the cached credentials");
        }
    }
}
