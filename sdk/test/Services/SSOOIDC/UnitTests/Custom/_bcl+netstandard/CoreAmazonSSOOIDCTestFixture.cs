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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SSOOIDC;
using Amazon.SSOOIDC.Internal;
using Amazon.SSOOIDC.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Sets up a mock OIDC client with some plumbing common to multiple tests, and sample
    /// requests/responses.
    /// OIDC client is initialized with a success case.
    /// </summary>
    public class CoreAmazonSSOOIDCTestFixture : IDisposable
    {
        public int SsoVerificationCallbackCount { get; private set; }
        public readonly Mock<IAmazonSSOOIDC> OidcClient = new Mock<IAmazonSSOOIDC>();
        public readonly Mock<IGetSsoTokenContext> GetSsoTokenContext = new Mock<IGetSsoTokenContext>();

        public readonly GetSsoTokenRequest GetSsoTokenRequest;

        public readonly RegisterClientRequest RegisterClientRequest = new RegisterClientRequest()
        {
            ClientName = "client-name",
            ClientType = "client-type",
        };

        public readonly RegisterClientResponse RegisterClientResponse = new RegisterClientResponse()
        {
            ClientSecret = "client-secret",
            ClientId = "client-id",
        };

        public readonly StartDeviceAuthorizationRequest StartDeviceAuthorizationRequest = new StartDeviceAuthorizationRequest()
        {
            ClientSecret = "client-secret",
            ClientId = "client-id",
            StartUrl = "start-url",
        };

        public readonly StartDeviceAuthorizationResponse StartDeviceAuthorizationResponse = new StartDeviceAuthorizationResponse()
        {
            DeviceCode = "device-code",
            UserCode = "user-code",
            ExpiresIn = 1234,
            Interval = 5,
            VerificationUri = "https://someuri.example.com",
            VerificationUriComplete = "https://someuri.example.com/token",
        };

        public readonly CreateTokenRequest CreateTokenRequest = new CreateTokenRequest()
        {
            ClientId = "client-id",
            ClientSecret = "client-secret",
            GrantType = "urn:ietf:params:oauth:grant-type:device_code",
            DeviceCode = "device-code",
        };

        public readonly CreateTokenResponse CreateTokenResponse = new CreateTokenResponse()
        {
            AccessToken = "access-token",
            ExpiresIn = 30,
        };

        public CoreAmazonSSOOIDCTestFixture()
        {
            GetSsoTokenRequest = new GetSsoTokenRequest()
            {
                ClientType = "client-type",
                ClientName = "client-name",
                SsoVerificationCallback = SsoVerificationCallback,
                StartUrl = "start-url",
            };

            WithValidConfig();
            WithRegisterClientSuccess();
            WithStartDeviceAuthorizationSuccess();
            WithCreateTokenSuccess();
        }

        private void WithValidConfig()
        {
            OidcClient
                .Setup(x => x.Config)
                .Returns(new AmazonSSOOIDCConfig
                {
                    RegionEndpoint = RegionEndpoint.USWest2
                });
        }

        // Sets up RegisterClient calls to succeed
        public CoreAmazonSSOOIDCTestFixture WithRegisterClientSuccess()
        {
            OidcClient.Setup(mock => mock.RegisterClient(It.IsAny<RegisterClientRequest>()))
                .Returns(() => RegisterClientResponse);

            OidcClient.Setup(mock =>
                    mock.RegisterClientAsync(It.IsAny<RegisterClientRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => RegisterClientResponse);

            return this;
        }

        public void AssertRegisterClientRequest(RegisterClientRequest expectedRequest)
        {
            OidcClient.Verify(mock => mock.RegisterClient(It.Is<RegisterClientRequest>(MatchesRequest(expectedRequest))), Times.Once);
        }

        public void AssertRegisterClientAsyncRequest(RegisterClientRequest expectedRequest)
        {
            OidcClient.Verify(
                mock => mock.RegisterClientAsync(It.Is<RegisterClientRequest>(MatchesRequest(expectedRequest)),
                    It.IsAny<CancellationToken>()), Times.Once);
        }

        // Sets up StartDeviceAuthorization calls to succeed
        public CoreAmazonSSOOIDCTestFixture WithStartDeviceAuthorizationSuccess()
        {
            OidcClient.Setup(mock => mock.StartDeviceAuthorization(It.IsAny<StartDeviceAuthorizationRequest>()))
                .Returns(() => StartDeviceAuthorizationResponse);

            OidcClient.Setup(mock =>
                    mock.StartDeviceAuthorizationAsync(It.IsAny<StartDeviceAuthorizationRequest>(),
                        It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => StartDeviceAuthorizationResponse);

            return this;
        }

        public void AssertStartDeviceAuthorizationRequest(StartDeviceAuthorizationRequest expectedRequest)
        {
            OidcClient.Verify(mock => mock.StartDeviceAuthorization(It.Is<StartDeviceAuthorizationRequest>(MatchesRequest(expectedRequest))), Times.Once);
        }

        public void AssertStartDeviceAuthorizationAsyncRequest(StartDeviceAuthorizationRequest expectedRequest)
        {
            OidcClient.Verify(
                mock => mock.StartDeviceAuthorizationAsync(
                    It.Is<StartDeviceAuthorizationRequest>(MatchesRequest(expectedRequest)),
                    It.IsAny<CancellationToken>()), Times.Once);
        }

        // Sets up CreateToken calls to succeed
        public CoreAmazonSSOOIDCTestFixture WithCreateTokenSuccess()
        {
            OidcClient.Setup(mock => mock.CreateToken(It.IsAny<CreateTokenRequest>()))
                .Returns(() => CreateTokenResponse);

            OidcClient.Setup(mock =>
                    mock.CreateTokenAsync(It.IsAny<CreateTokenRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => CreateTokenResponse);

            return this;
        }

        public CoreAmazonSSOOIDCTestFixture WithCreateTokenExceptionThenSuccess(Exception exception)
        {
            OidcClient.SetupSequence(mock => mock.CreateToken(It.IsAny<CreateTokenRequest>()))
                .Throws(exception)
                .Returns(() => CreateTokenResponse);

            OidcClient.SetupSequence(mock =>
                    mock.CreateTokenAsync(It.IsAny<CreateTokenRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(exception)
                .ReturnsAsync(CreateTokenResponse);

            return this;
        }

        public CoreAmazonSSOOIDCTestFixture WithCreateTokenException(Exception exception)
        {
            OidcClient.Setup(mock => mock.CreateToken(It.IsAny<CreateTokenRequest>()))
                .Throws(exception);

            OidcClient.Setup(mock =>
                    mock.CreateTokenAsync(It.IsAny<CreateTokenRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(exception);

            return this;
        }

        public void AssertCreateTokenRequest(CreateTokenRequest expectedRequest, int timesCalled = 1)
        {
            OidcClient.Verify(mock => mock.CreateToken(It.Is<CreateTokenRequest>(MatchesRequest(expectedRequest))), Times.Exactly(timesCalled));
        }

        public void AssertCreateTokenAsyncRequest(CreateTokenRequest expectedRequest, int timesCalled = 1)
        {
            OidcClient.Verify(
                mock => mock.CreateTokenAsync(It.Is<CreateTokenRequest>(MatchesRequest(expectedRequest)),
                    It.IsAny<CancellationToken>()), Times.Exactly(timesCalled));
        }

        public void AssertSleepCalled(int millisecondsValue, int timesCalled = 1)
        {
            GetSsoTokenContext.Verify(mock => mock.Sleep(millisecondsValue), Times.Exactly(timesCalled));
        }

        private void SsoVerificationCallback(SsoVerificationArguments args)
        {
            SsoVerificationCallbackCount++;

            Assert.AreEqual(this.StartDeviceAuthorizationResponse.UserCode, args.UserCode);
            Assert.AreEqual(this.StartDeviceAuthorizationResponse.VerificationUri, args.VerificationUri);
            Assert.AreEqual(this.StartDeviceAuthorizationResponse.VerificationUriComplete, args.VerificationUriComplete);
        }

        private static Expression<Func<RegisterClientRequest, bool>> MatchesRequest(
            RegisterClientRequest expectedRequest)
        {
            return request => request.ClientName == expectedRequest.ClientName &&
                              request.ClientType == expectedRequest.ClientType;
        }

        private static Expression<Func<StartDeviceAuthorizationRequest, bool>> MatchesRequest(
            StartDeviceAuthorizationRequest expectedRequest)
        {
            return request => request.ClientSecret == expectedRequest.ClientSecret &&
                              request.ClientId == expectedRequest.ClientId &&
                              request.StartUrl == expectedRequest.StartUrl;
        }

        private static Expression<Func<CreateTokenRequest, bool>> MatchesRequest(CreateTokenRequest expectedRequest)
        {
            return request => request.ClientId == expectedRequest.ClientId &&
                              request.ClientSecret == expectedRequest.ClientSecret &&
                              request.GrantType == expectedRequest.GrantType &&
                              request.DeviceCode == expectedRequest.DeviceCode;
        }

        public void Dispose() 
        {

        }
    }
}
