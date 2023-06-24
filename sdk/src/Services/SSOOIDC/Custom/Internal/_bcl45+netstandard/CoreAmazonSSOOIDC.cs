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
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SSOOIDC.Model;
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.SSOOIDC.Internal
{
    public static class CoreAmazonSSOOIDC
    {
        private const string CreateTokenGrantType = "urn:ietf:params:oauth:grant-type:device_code";
        private const int DefaultPollingIntervalSeconds = 5;
        private const int PollingSlowdownIncrementSeconds = 5;

        private class GetSsoTokenContext : IGetSsoTokenContext
        {
            public void Sleep(int ms)
            {
                AWSSDKUtils.Sleep(ms);
            }
        }

#if BCL
        public static GetSsoTokenResponse GetSsoToken(IAmazonSSOOIDC client, GetSsoTokenRequest request)
        {
            return GetSsoToken(client, request, new GetSsoTokenContext());
        }

        public static GetSsoTokenResponse GetSsoToken(IAmazonSSOOIDC client, GetSsoTokenRequest request, IGetSsoTokenContext context)
        {
            var registerClientRequest = new RegisterClientRequest
            {
                ClientName = request.ClientName,
                ClientType = request.ClientType,
            };

            if (request.Scopes != null)
            {
                registerClientRequest.Scopes = new List<string>(request.Scopes);
            }

            InternalSDKUtils.ApplyValues(registerClientRequest, request.AdditionalProperties);

            var registerClientResponse = client.RegisterClient(registerClientRequest);


            var startDeviceAuthorizationRequest = new StartDeviceAuthorizationRequest
            {
                ClientSecret = registerClientResponse.ClientSecret,
                ClientId = registerClientResponse.ClientId,
                StartUrl = request.StartUrl,
            };
            InternalSDKUtils.ApplyValues(startDeviceAuthorizationRequest, request.AdditionalProperties);

            var startDeviceAuthorizationResponse = client.StartDeviceAuthorization(startDeviceAuthorizationRequest);


            // Spec: The expiration time must be calculated by adding the number of seconds 
            // returned by StartDeviceAuthorization (ExpiresIn) to the current time.
            DateTime deviceCodeExpiration = DateTime.UtcNow.AddSeconds(startDeviceAuthorizationResponse.ExpiresIn);

            request.SsoVerificationCallback(new SsoVerificationArguments
            {
                UserCode = startDeviceAuthorizationResponse.UserCode,
                VerificationUri = startDeviceAuthorizationResponse.VerificationUri,
                VerificationUriComplete = startDeviceAuthorizationResponse.VerificationUriComplete,
            });


            var createTokenRequest = new CreateTokenRequest
            {
                ClientId = registerClientResponse.ClientId,
                ClientSecret = registerClientResponse.ClientSecret,
                GrantType = CreateTokenGrantType,
                DeviceCode = startDeviceAuthorizationResponse.DeviceCode,
            };
            InternalSDKUtils.ApplyValues(request, request.AdditionalProperties);

            var ssoToken = PollForSsoToken(client,
                createTokenRequest,
                startDeviceAuthorizationResponse.Interval,
                deviceCodeExpiration,
                context);

            return new GetSsoTokenResponse
            {
                AccessToken = ssoToken.AccessToken,
                Region = client.Config.RegionEndpoint.SystemName,
                ClientId = registerClientResponse.ClientId,
                ClientSecret = registerClientResponse.ClientSecret,
                RefreshToken = ssoToken.RefreshToken,
                ExpiresAt = DateTime.UtcNow.AddSeconds(ssoToken.ExpiresIn),
                StartUrl = request.StartUrl
            };
        }
#endif

        public static Task<GetSsoTokenResponse> GetSsoTokenAsync(IAmazonSSOOIDC client, GetSsoTokenRequest request)
        {
            return GetSsoTokenAsync(client, request, new GetSsoTokenContext());
        }

        public static async Task<GetSsoTokenResponse> GetSsoTokenAsync(IAmazonSSOOIDC client, GetSsoTokenRequest request, IGetSsoTokenContext context)
        {
            var registerClientRequest = new RegisterClientRequest
            {
                ClientName = request.ClientName,
                ClientType = request.ClientType,
            };

            if (request.Scopes != null)
            {
                registerClientRequest.Scopes = new List<string>(request.Scopes);
            }

            InternalSDKUtils.ApplyValues(registerClientRequest, request.AdditionalProperties);

            var registerClientResponse = await client.RegisterClientAsync(registerClientRequest).ConfigureAwait(false);


            var startDeviceAuthorizationRequest = new StartDeviceAuthorizationRequest
            {
                ClientSecret = registerClientResponse.ClientSecret,
                ClientId = registerClientResponse.ClientId,
                StartUrl = request.StartUrl,
            };
            InternalSDKUtils.ApplyValues(startDeviceAuthorizationRequest, request.AdditionalProperties);

            var startDeviceAuthorizationResponse =
                await client.StartDeviceAuthorizationAsync(startDeviceAuthorizationRequest).ConfigureAwait(false);


            // Spec: The expiration time must be calculated by adding the number of seconds 
            // returned by StartDeviceAuthorization (ExpiresIn) to the current time.
            DateTime deviceCodeExpiration = DateTime.UtcNow.AddSeconds(startDeviceAuthorizationResponse.ExpiresIn);

            request.SsoVerificationCallback(new SsoVerificationArguments
            {
                UserCode = startDeviceAuthorizationResponse.UserCode,
                VerificationUri = startDeviceAuthorizationResponse.VerificationUri,
                VerificationUriComplete = startDeviceAuthorizationResponse.VerificationUriComplete,
            });


            var createTokenRequest = new CreateTokenRequest
            {
                ClientId = registerClientResponse.ClientId,
                ClientSecret = registerClientResponse.ClientSecret,
                GrantType = CreateTokenGrantType,
                DeviceCode = startDeviceAuthorizationResponse.DeviceCode,
            };
            InternalSDKUtils.ApplyValues(request, request.AdditionalProperties);

            var ssoToken = await PollForSsoTokenAsync(client,
                createTokenRequest,
                startDeviceAuthorizationResponse.Interval,
                deviceCodeExpiration,
                context).ConfigureAwait(false);

            return new GetSsoTokenResponse
            {
                AccessToken = ssoToken.AccessToken,
                Region = client.Config.RegionEndpoint.SystemName,
                ClientId = registerClientResponse.ClientId,
                ClientSecret = registerClientResponse.ClientSecret,
                RefreshToken = ssoToken.RefreshToken,
                ExpiresAt = DateTime.UtcNow.AddSeconds(ssoToken.ExpiresIn),
                StartUrl = request.StartUrl
            };
        }

#if BCL
        public static GetSsoTokenResponse RefreshToken(
            IAmazonSSOOIDC client,
            GetSsoTokenResponse previousResponse)
        {
            var ssoToken = client.CreateToken(new CreateTokenRequest
            {
                ClientId = previousResponse.ClientId,
                ClientSecret = previousResponse.ClientSecret,
                RefreshToken = previousResponse.RefreshToken,
                GrantType = "refresh_token"
            });

            return new GetSsoTokenResponse
            {
                AccessToken = ssoToken.AccessToken,
                ExpiresAt = AWSSDKUtils.CorrectedUtcNow.AddSeconds(ssoToken.ExpiresIn),
                RefreshToken = ssoToken.RefreshToken,
                Region = previousResponse.Region,
                RegistrationExpiresAt = previousResponse.RegistrationExpiresAt,
                ClientId = previousResponse.ClientId,
                ClientSecret = previousResponse.ClientSecret,
                StartUrl = previousResponse.StartUrl
            };
        }
#endif

        public static async Task<GetSsoTokenResponse> RefreshTokenAsync(
            IAmazonSSOOIDC client,
            GetSsoTokenResponse previousResponse)
        {
            var ssoToken = await client.CreateTokenAsync(new CreateTokenRequest
            {
                ClientId = previousResponse.ClientId,
                ClientSecret = previousResponse.ClientSecret,
                RefreshToken = previousResponse.RefreshToken,
                GrantType = "refresh_token"
            }).ConfigureAwait(false);

            return new GetSsoTokenResponse
            {
                AccessToken = ssoToken.AccessToken,
                ExpiresAt = AWSSDKUtils.CorrectedUtcNow.AddSeconds(ssoToken.ExpiresIn),
                RefreshToken = ssoToken.RefreshToken,
                Region = previousResponse.Region,
                RegistrationExpiresAt = previousResponse.RegistrationExpiresAt,
                ClientId = previousResponse.ClientId,
                ClientSecret = previousResponse.ClientSecret,                
                StartUrl = previousResponse.StartUrl
            };
        }

#if BCL
        private static CreateTokenResponse PollForSsoToken(IAmazonSSOOIDC client,
            CreateTokenRequest createTokenRequest,
            int pollingIntervalSeconds,
            DateTime deviceCodeExpiration, 
            IGetSsoTokenContext context)
        {
            var logger = Logger.GetLogger(typeof(CoreAmazonSSOOIDC));

            // Spec: If the Interval value is not returned as part of the StartDeviceAuthorization response,
            // a default Interval value of 5 seconds should be used.
            var intervalSec = pollingIntervalSeconds > 0 ? pollingIntervalSeconds : DefaultPollingIntervalSeconds;

            // Poll for Token until success, failure, or an error condition arises.
            while (true)
            {
                try
                {
                    var response = client.CreateToken(createTokenRequest);

                    // If we reach here, the user has completed the SSO Login authorization.
                    return response;
                }
                catch (AuthorizationPendingException e)
                {
                    // Service is still waiting for user to complete authorization.
                    // Repeat the loop after an interval.
                }
                catch (SlowDownException e)
                {
                    // Spec: Add 5 seconds to the polling interval
                    intervalSec += PollingSlowdownIncrementSeconds;
                }
                catch (ExpiredTokenException e)
                {
                    // Spec: An exception must be raised, indicating that the SSO login window expired 
                    // and the SSO login flow must be re-initiated.
                    throw new AmazonSSOOIDCException("Device code has expired while polling for SSO token, login flow must be re-initiated.", e);
                }
                catch (TimeoutException e)
                {
                    // Spec: If the call times out then the tool should double its polling interval and then retry.
                    intervalSec *= 2;
                }
                catch (Exception e)
                {
                    logger.Error(e, "Unexpected exception while polling for SSO Token.");
                    throw;
                }

                if (DateTime.UtcNow.AddSeconds(intervalSec) > deviceCodeExpiration)
                {
                    throw new AmazonSSOOIDCException("Device code has expired while polling for SSO token, login flow must be re-initiated.");
                }

                context.Sleep(intervalSec * 1000);
            } // while(polling)
        }
#endif

        private static async Task<CreateTokenResponse> PollForSsoTokenAsync(IAmazonSSOOIDC client,
            CreateTokenRequest createTokenRequest,
            int pollingIntervalSeconds,
            DateTime deviceCodeExpiration,
            IGetSsoTokenContext context)
        {
            var logger = Logger.GetLogger(typeof(CoreAmazonSSOOIDC));

            // Spec: If the Interval value is not returned as part of the StartDeviceAuthorization response,
            // a default Interval value of 5 seconds should be used.
            var intervalSec = pollingIntervalSeconds > 0 ? pollingIntervalSeconds : DefaultPollingIntervalSeconds;

            // Poll for Token until success, failure, or an error condition arises.
            while (true)
            {
                try
                {
                    var response = await client.CreateTokenAsync(createTokenRequest).ConfigureAwait(false);

                    // If we reach here, the user has completed the SSO Login authorization.
                    return response;
                }
                catch (AuthorizationPendingException e)
                {
                    // Service is still waiting for user to complete authorization.
                    // Repeat the loop after an interval.
                }
                catch (SlowDownException e)
                {
                    // Spec: Add 5 seconds to the polling interval
                    intervalSec += PollingSlowdownIncrementSeconds;
                }
                catch (ExpiredTokenException e)
                {
                    // Spec: An exception must be raised, indicating that the SSO login window expired 
                    // and the SSO login flow must be re-initiated.
                    throw new AmazonSSOOIDCException("Device code has expired while polling for SSO token, login flow must be re-initiated.", e);
                }
                catch (TimeoutException e)
                {
                    // Spec: If the call times out then the tool should double its polling interval and then retry.
                    intervalSec *= 2;
                }
                catch (Exception e)
                {
                    logger.Error(e, "Unexpected exception while polling for SSO Token.");
                    throw;
                }

                if (DateTime.UtcNow.AddSeconds(intervalSec) > deviceCodeExpiration)
                {
                    throw new AmazonSSOOIDCException("Device code has expired while polling for SSO token, login flow must be re-initiated.");
                }

                context.Sleep(intervalSec * 1000);
            } // while(polling)
        }
    }
}