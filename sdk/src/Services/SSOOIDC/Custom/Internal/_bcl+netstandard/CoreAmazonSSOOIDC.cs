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
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.UserAgent;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SSOOIDC.Model;
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.SSOOIDC.Internal
{
    /// <summary>
    /// Utilities methods for SSO OIDC
    /// </summary>
    public static class CoreAmazonSSOOIDC
    {
        private const string CreateTokenDefaultGrantType = "urn:ietf:params:oauth:grant-type:device_code";
        private const string CreateTokenPKCEGrantType = "authorization_code";
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
        /// <summary>
        /// Get SSO token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static GetSsoTokenResponse GetSsoToken(IAmazonSSOOIDC client, GetSsoTokenRequest request)
        {
            return GetSsoToken(client, request, new GetSsoTokenContext());
        }

        /// <summary>
        /// Get SSO Token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static GetSsoTokenResponse GetSsoToken(IAmazonSSOOIDC client, GetSsoTokenRequest request, IGetSsoTokenContext context)
        {
            // PkceFlowOptions is a newer property that must be specified when using the PKCE flow. If it's null, we'll default to the device code flow.
            var useDeviceCodeFlow = request.PkceFlowOptions == null;
            var featureId = useDeviceCodeFlow ? UserAgentFeatureId.SSO_LOGIN_DEVICE : UserAgentFeatureId.SSO_LOGIN_AUTH;

            // Identity Center supports using the start URL as the issuer URL (if one was not provided).
            var issuerUrl = request.PkceFlowOptions?.IssuerUrl ?? request.StartUrl;

            CreateTokenRequest createTokenRequest;
            CreateTokenResponse createTokenResponse;
            string codeVerifier = null;

            var registerClientRequest = new RegisterClientRequest
            {
                ClientName = request.ClientName,
                ClientType = request.ClientType,
                IssuerUrl = issuerUrl,
            };

            if (request.Scopes != null)
            {
                registerClientRequest.Scopes = new List<string>(request.Scopes);
            }

            if (request.PkceFlowOptions?.GrantTypes != null)
            {
                registerClientRequest.GrantTypes = new List<string>(request.PkceFlowOptions.GrantTypes);
            }

            if (request.PkceFlowOptions?.RedirectUri != null)
            {
                // Even though the API allows multiple redirect URIs, we can only specify one when calling CreateToken.
                registerClientRequest.RedirectUris = new List<string> { request.PkceFlowOptions.RedirectUri };
            }

            InternalSDKUtils.ApplyValuesV2(registerClientRequest, request.AdditionalProperties);
            var registerClientResponse = client.RegisterClient(registerClientRequest);

            if (useDeviceCodeFlow)
            {
                var startDeviceAuthorizationRequest = new StartDeviceAuthorizationRequest
                {
                    ClientSecret = registerClientResponse.ClientSecret,
                    ClientId = registerClientResponse.ClientId,
                    StartUrl = request.StartUrl,
                };
                InternalSDKUtils.ApplyValuesV2(startDeviceAuthorizationRequest, request.AdditionalProperties);
                ((IAmazonWebServiceRequest)startDeviceAuthorizationRequest).UserAgentDetails.AddFeature(featureId);

                var startDeviceAuthorizationResponse = client.StartDeviceAuthorization(startDeviceAuthorizationRequest);

                // Spec: The expiration time must be calculated by adding the number of seconds 
                // returned by StartDeviceAuthorization (ExpiresIn) to the current time.
                DateTime deviceCodeExpiration = DateTime.UtcNow.AddSeconds(startDeviceAuthorizationResponse.ExpiresIn.Value);

                request.SsoVerificationCallback(new SsoVerificationArguments
                {
                    UserCode = startDeviceAuthorizationResponse.UserCode,
                    VerificationUri = startDeviceAuthorizationResponse.VerificationUri,
                    VerificationUriComplete = startDeviceAuthorizationResponse.VerificationUriComplete,
                });

                createTokenRequest = new CreateTokenRequest
                {
                    ClientId = registerClientResponse.ClientId,
                    ClientSecret = registerClientResponse.ClientSecret,
                    GrantType = CreateTokenDefaultGrantType,
                    DeviceCode = startDeviceAuthorizationResponse.DeviceCode,
                };
                InternalSDKUtils.ApplyValuesV2(createTokenRequest, request.AdditionalProperties);

                createTokenResponse = PollForSsoToken(client, createTokenRequest, startDeviceAuthorizationResponse.Interval.Value, deviceCodeExpiration, context);
            }
            else
            {
                codeVerifier = GenerateCodeVerifier();

                // In order to get an authorization code, we must create an URL using the client metadata and PKCE flow parameters.
                // The hostname is the OIDC service endpoint, so we'll use DetermineServiceOperationEndpoint to find the correct region.
                var oidcEndpoint = client.DetermineServiceOperationEndpoint(registerClientRequest);
                var url = BuildAuthorizationUrl(registerClientResponse.ClientId, oidcEndpoint.URL, request.PkceFlowOptions.RedirectUri, codeVerifier);
                var authorizationCode = request.PkceFlowOptions.RetrieveAuthorizationCodeCallback(url);

                createTokenRequest = new CreateTokenRequest
                {
                    ClientId = registerClientResponse.ClientId,
                    ClientSecret = registerClientResponse.ClientSecret,
                    GrantType = CreateTokenPKCEGrantType,
                    RedirectUri = request.PkceFlowOptions.RedirectUri,
                    Code = authorizationCode,
                    CodeVerifier = codeVerifier,
                };
                InternalSDKUtils.ApplyValuesV2(createTokenRequest, request.AdditionalProperties);
                ((IAmazonWebServiceRequest)createTokenRequest).UserAgentDetails.AddFeature(featureId);

                createTokenResponse = client.CreateToken(createTokenRequest);
            }

            var clientSecretExpiresAtString = XmlConvert.ToString(AWSSDKUtils.ConvertFromUnixEpochSeconds((int)registerClientResponse.ClientSecretExpiresAt), XmlDateTimeSerializationMode.Utc);
            return new GetSsoTokenResponse
            {
                AccessToken = createTokenResponse.AccessToken,
                Region = client.Config.RegionEndpoint.SystemName,
                ClientId = registerClientResponse.ClientId,
                ClientSecret = registerClientResponse.ClientSecret,
                RegistrationExpiresAt = clientSecretExpiresAtString,
                RefreshToken = createTokenResponse.RefreshToken,
                ExpiresAt = DateTime.UtcNow.AddSeconds(createTokenResponse.ExpiresIn.Value),
                StartUrl = request.StartUrl,
                CodeVerifier = codeVerifier
            };
        }
#endif

        /// <summary>
        /// Get SSO Token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static Task<GetSsoTokenResponse> GetSsoTokenAsync(IAmazonSSOOIDC client, GetSsoTokenRequest request)
        {
            return GetSsoTokenAsync(client, request, new GetSsoTokenContext());
        }

        /// <summary>
        /// Get SSO Token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<GetSsoTokenResponse> GetSsoTokenAsync(IAmazonSSOOIDC client, GetSsoTokenRequest request, CancellationToken cancellationToken)
        {
            return GetSsoTokenAsync(client, request, new GetSsoTokenContext(), cancellationToken);
        }

        /// <summary>
        /// Get SSO Token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<GetSsoTokenResponse> GetSsoTokenAsync(IAmazonSSOOIDC client, GetSsoTokenRequest request, IGetSsoTokenContext context)
        {
            return await GetSsoTokenAsync(client, request, context, cancellationToken: default).ConfigureAwait(false);
        }

        /// <summary>
        /// Get SSO Token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<GetSsoTokenResponse> GetSsoTokenAsync(IAmazonSSOOIDC client, GetSsoTokenRequest request, IGetSsoTokenContext context, CancellationToken cancellationToken)
        {
            // PkceFlowOptions is a newer property that must be specified when using the PKCE flow. If it's null, we'll default to the device code flow.
            var useDeviceCodeFlow = request.PkceFlowOptions == null;
            var featureId = useDeviceCodeFlow ? UserAgentFeatureId.SSO_LOGIN_DEVICE : UserAgentFeatureId.SSO_LOGIN_AUTH;

            // Identity Center supports using the start URL as the issuer URL (if one was not provided).
            var issuerUrl = request.PkceFlowOptions?.IssuerUrl ?? request.StartUrl;

            CreateTokenRequest createTokenRequest;
            CreateTokenResponse createTokenResponse;
            string codeVerifier = null;

            var registerClientRequest = new RegisterClientRequest
            {
                ClientName = request.ClientName,
                ClientType = request.ClientType,
                IssuerUrl = issuerUrl,
            };

            if (request.Scopes != null)
            {
                registerClientRequest.Scopes = new List<string>(request.Scopes);
            }

            if (request.PkceFlowOptions?.GrantTypes != null)
            {
                registerClientRequest.GrantTypes = new List<string>(request.PkceFlowOptions.GrantTypes);
            }

            if (request.PkceFlowOptions?.RedirectUri != null)
            {
                // Even though the API allows multiple redirect URIs, we can only specify one when calling CreateToken.
                registerClientRequest.RedirectUris = new List<string> { request.PkceFlowOptions.RedirectUri };
            }

            InternalSDKUtils.ApplyValuesV2(registerClientRequest, request.AdditionalProperties);
            var registerClientResponse = await client.RegisterClientAsync(registerClientRequest, cancellationToken).ConfigureAwait(false);

            if (useDeviceCodeFlow)
            {
                var startDeviceAuthorizationRequest = new StartDeviceAuthorizationRequest
                {
                    ClientSecret = registerClientResponse.ClientSecret,
                    ClientId = registerClientResponse.ClientId,
                    StartUrl = request.StartUrl,
                };
                InternalSDKUtils.ApplyValuesV2(startDeviceAuthorizationRequest, request.AdditionalProperties);
                ((IAmazonWebServiceRequest)startDeviceAuthorizationRequest).UserAgentDetails.AddFeature(featureId);

                var startDeviceAuthorizationResponse =
                    await client.StartDeviceAuthorizationAsync(startDeviceAuthorizationRequest, cancellationToken).ConfigureAwait(false);

                // Spec: The expiration time must be calculated by adding the number of seconds 
                // returned by StartDeviceAuthorization (ExpiresIn) to the current time.
                DateTime deviceCodeExpiration = DateTime.UtcNow.AddSeconds(startDeviceAuthorizationResponse.ExpiresIn.Value);

                request.SsoVerificationCallback(new SsoVerificationArguments
                {
                    UserCode = startDeviceAuthorizationResponse.UserCode,
                    VerificationUri = startDeviceAuthorizationResponse.VerificationUri,
                    VerificationUriComplete = startDeviceAuthorizationResponse.VerificationUriComplete,
                });

                createTokenRequest = new CreateTokenRequest
                {
                    ClientId = registerClientResponse.ClientId,
                    ClientSecret = registerClientResponse.ClientSecret,
                    GrantType = CreateTokenDefaultGrantType,
                    DeviceCode = startDeviceAuthorizationResponse.DeviceCode,
                };
                InternalSDKUtils.ApplyValuesV2(createTokenRequest, request.AdditionalProperties);

                createTokenResponse = await PollForSsoTokenAsync(
                    client,
                    createTokenRequest,
                    startDeviceAuthorizationResponse.Interval.Value,
                    deviceCodeExpiration,
                    context,
                    cancellationToken
                ).ConfigureAwait(false);
            }
            else
            {
                codeVerifier = GenerateCodeVerifier();

                // In order to get an authorization code, we must create an URL using the client metadata and PKCE flow parameters.
                // The hostname is the OIDC service endpoint, so we'll use DetermineServiceOperationEndpoint to find the correct region.
                var oidcEndpoint = client.DetermineServiceOperationEndpoint(registerClientRequest);
                var url = BuildAuthorizationUrl(registerClientResponse.ClientId, oidcEndpoint.URL, request.PkceFlowOptions.RedirectUri, codeVerifier);

                var authorizationCode = await request.PkceFlowOptions
                    .RetrieveAuthorizationCodeCallbackAsync(url, cancellationToken)
                    .ConfigureAwait(false);

                createTokenRequest = new CreateTokenRequest
                {
                    ClientId = registerClientResponse.ClientId,
                    ClientSecret = registerClientResponse.ClientSecret,
                    GrantType = CreateTokenPKCEGrantType,
                    RedirectUri = request.PkceFlowOptions.RedirectUri,
                    Code = authorizationCode,
                    CodeVerifier = codeVerifier,
                };
                InternalSDKUtils.ApplyValuesV2(createTokenRequest, request.AdditionalProperties);
                ((IAmazonWebServiceRequest)createTokenRequest).UserAgentDetails.AddFeature(featureId);

                createTokenResponse = await client.CreateTokenAsync(createTokenRequest, cancellationToken).ConfigureAwait(false);
            }

            var clientSecretExpiresAtString = XmlConvert.ToString(AWSSDKUtils.ConvertFromUnixEpochSeconds((int)registerClientResponse.ClientSecretExpiresAt), XmlDateTimeSerializationMode.Utc);
            return new GetSsoTokenResponse
            {
                AccessToken = createTokenResponse.AccessToken,
                Region = client.Config.RegionEndpoint.SystemName,
                ClientId = registerClientResponse.ClientId,
                ClientSecret = registerClientResponse.ClientSecret,
                RegistrationExpiresAt = clientSecretExpiresAtString,
                RefreshToken = createTokenResponse.RefreshToken,
                ExpiresAt = DateTime.UtcNow.AddSeconds(createTokenResponse.ExpiresIn.Value),
                StartUrl = request.StartUrl,
                CodeVerifier = codeVerifier
            };
        }

#if BCL
        /// <summary>
        /// Refresh SSO Token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="previousResponse"></param>
        /// <returns></returns>
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
                ExpiresAt = AWSSDKUtils.CorrectedUtcNow.AddSeconds(ssoToken.ExpiresIn.Value),
                RefreshToken = ssoToken.RefreshToken,
                Region = previousResponse.Region,
                RegistrationExpiresAt = previousResponse.RegistrationExpiresAt,
                ClientId = previousResponse.ClientId,
                ClientSecret = previousResponse.ClientSecret,
                StartUrl = previousResponse.StartUrl
            };
        }
#endif
        /// <summary>
        /// Refresh SSO Token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="previousResponse"></param>
        /// <returns></returns>
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
                ExpiresAt = AWSSDKUtils.CorrectedUtcNow.AddSeconds(ssoToken.ExpiresIn.Value),
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
                catch (AuthorizationPendingException)
                {
                    // Service is still waiting for user to complete authorization.
                    // Repeat the loop after an interval.
                }
                catch (SlowDownException)
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
                catch (TimeoutException)
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
            IGetSsoTokenContext context,
            CancellationToken cancellationToken)
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
                    var response = await client.CreateTokenAsync(createTokenRequest, cancellationToken).ConfigureAwait(false);

                    // If we reach here, the user has completed the SSO Login authorization.
                    return response;
                }
                catch (AuthorizationPendingException)
                {
                    // Service is still waiting for user to complete authorization.
                    // Repeat the loop after an interval.
                }
                catch (SlowDownException)
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
                catch (TimeoutException)
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


        /// <summary>
        /// Generates a high-entropy cryptographic random string using the following characters: <c>[A-Z] / [a-z] / [0-9] / "-" / "." / "_" / "~"</c>
        /// </summary>
        /// <remarks>Based on https://stackoverflow.com/a/1344255</remarks>
        private static string GenerateCodeVerifier()
        {
            const int codeLength = 100;
            var allowedValues = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890-._~".ToCharArray();

            var data = new byte[4 * codeLength];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(data);
            }

            var result = new StringBuilder(codeLength);
            for (int i = 0; i < codeLength; i++)
            {
                var rnd = BitConverter.ToUInt32(data, i * 4);
                var idx = rnd % allowedValues.Length;

                result.Append(allowedValues[idx]);
            }

            return result.ToString();
        }

        /// <summary>
        /// Creates a code challenge by performing a SHA256 hash and Base64 encoding the provided code verifier.
        /// </summary>
        private static string GenerateCodeChallenge(string codeVerifier)
        {
            using (var sha256 = SHA256.Create())
            {
                var hash = sha256.ComputeHash(Encoding.ASCII.GetBytes(codeVerifier));

                // The code challenge must be safe to use in URLs, so we'll replace / remove invalid characters.
                return Convert.ToBase64String(hash)
                    .Replace('+', '-')
                    .Replace('/', '_')
                    .TrimEnd('=');
            }
        }

        private static Uri BuildAuthorizationUrl(string clientId, string oidcUrl, string redirectUri, string codeVerifier)
        {
            var encodedRedirectUri = Uri.EscapeDataString(redirectUri);
            var codeChallenge = GenerateCodeChallenge(codeVerifier);

            // From RFC: opaque value used by the client to maintain state between the request and callback (used for preventing cross-site request forgery).
            var state = Guid.NewGuid().ToString("N");

            var queryString = new StringBuilder();
            queryString.Append("response_type=code");
            queryString.Append("&client_id=").Append(clientId);
            queryString.Append("&redirect_uri=").Append(encodedRedirectUri);
            queryString.Append("&state=").Append(state);
            queryString.Append("&code_challenge=").Append(codeChallenge);
            queryString.Append("&code_challenge_method=S256");

            var builder = new UriBuilder(oidcUrl)
            {
                Path = "/authorize",
                Query = queryString.ToString()
            };

            return builder.Uri;
        }
    }
}