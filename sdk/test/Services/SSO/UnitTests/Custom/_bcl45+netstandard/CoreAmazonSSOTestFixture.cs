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
using System.Linq.Expressions;
using System.Threading;
using Amazon.SSO;
using Amazon.SSO.Model;
using Amazon.Util;
using Moq;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Sets up a mock SSO client with some plumbing common to multiple tests, and sample
    /// requests/responses.
    /// SSO client is initialized with a success case.
    /// </summary>
    public class CoreAmazonSSOTestFixture : IDisposable
    {
        public readonly Mock<IAmazonSSO> SsoClient = new Mock<IAmazonSSO>();

        public const long SampleExpirationMsFromEpoch = 1599590914970;
        public static readonly DateTime SampleExpiration = AWSSDKUtils.ConvertFromUnixEpochMilliseconds(SampleExpirationMsFromEpoch);

        public readonly GetRoleCredentialsRequest GetRoleCredentialsRequest = new GetRoleCredentialsRequest()
        {
            AccountId = "account-id",
            AccessToken = "access-token",
            RoleName = "role-name",
        };

        public readonly GetRoleCredentialsResponse GetRoleCredentialsResponse = new GetRoleCredentialsResponse()
        {
            RoleCredentials = new RoleCredentials()
            {
                AccessKeyId = "access-key-id",
                SecretAccessKey = "secret-access-key",
                SessionToken = "session-token",
                Expiration = SampleExpirationMsFromEpoch,
            }
        };

        public CoreAmazonSSOTestFixture()
        {
            WithGetRoleCredentialsSuccess();
        }

        public CoreAmazonSSOTestFixture WithGetRoleCredentialsSuccess()
        {
#if BCL
            SsoClient.Setup(mock => mock.GetRoleCredentials(It.IsAny<GetRoleCredentialsRequest>()))
                .Returns(() => GetRoleCredentialsResponse);
#endif

#if ASYNC_AWAIT
            SsoClient.Setup(mock =>
                    mock.GetRoleCredentialsAsync(It.IsAny<GetRoleCredentialsRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => GetRoleCredentialsResponse);
#endif

            return this;
        }

#if BCL
        public void AssertGetRoleCredentialsRequest(GetRoleCredentialsRequest expectedRequest)
        {
            SsoClient.Verify(mock => mock.GetRoleCredentials(It.Is<GetRoleCredentialsRequest>(MatchesRequest(expectedRequest))), Times.Once);
        }
#endif

#if ASYNC_AWAIT
        public void AssertGetRoleCredentialsAsyncRequest(GetRoleCredentialsRequest expectedRequest)
        {
            SsoClient.Verify(
                mock => mock.GetRoleCredentialsAsync(
                    It.Is<GetRoleCredentialsRequest>(MatchesRequest(expectedRequest)),
                    It.IsAny<CancellationToken>()),
                Times.Once);
        }
#endif

        private static Expression<Func<GetRoleCredentialsRequest, bool>> MatchesRequest(
            GetRoleCredentialsRequest expectedRequest)
        {
            return
                request => request.AccountId == expectedRequest.AccountId &&
                           request.AccessToken == expectedRequest.AccessToken &&
                           request.RoleName == expectedRequest.RoleName;
        }

        public void Dispose() 
        {

        }
    }
}
