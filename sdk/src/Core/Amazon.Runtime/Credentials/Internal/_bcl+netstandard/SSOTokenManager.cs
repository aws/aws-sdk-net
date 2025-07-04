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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util;

namespace Amazon.Runtime.Credentials.Internal
{
    public interface ISSOTokenManager
    {
#if BCL
        SsoToken GetToken(SSOTokenManagerGetTokenOptions options);
        void Logout(string ssoCacheDirectory = null);
        void Logout(SSOTokenManagerGetTokenOptions options);

#endif

        Task<SsoToken> GetTokenAsync(SSOTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default);
        Task LogoutAsync(string ssoCacheDirectory = null, CancellationToken cancellationToken = default);
        Task LogoutAsync(SSOTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default);
    }
    public class SSOTokenManager : ISSOTokenManager
    {
        private readonly ILogger _logger = Logger.GetLogger(typeof(SSOTokenManager));
        private readonly ICoreAmazonSSOOIDC _ssooidcClient;
        private readonly ISSOTokenFileCache _ssoTokenFileCache;
        private readonly InMemoryCache _inMemoryCache;

        public SSOTokenManager(
            ICoreAmazonSSOOIDC ssooidcClient,
            ISSOTokenFileCache ssoTokenFileCache)
        {
            _ssooidcClient = ssooidcClient;
            _ssoTokenFileCache = ssoTokenFileCache;

            _inMemoryCache = new InMemoryCache();
        }

        protected virtual ICoreAmazonSSO_Logout CreateSSOLogoutClient(string region,

#if BCL
            WebProxy proxySettings = null
#elif NETSTANDARD
            IWebProxy proxySettings = null
#endif
        )
        {
            return SSOServiceClientHelpers.BuildSSOLogoutClient(RegionEndpoint.GetBySystemName(region), proxySettings);
        }

        protected virtual ICoreAmazonSSOOIDC_V2 CreateSSOOIDC_V2Client(string region,

#if BCL
            WebProxy proxySettings = null
#elif NETSTANDARD
            IWebProxy proxySettings = null
#endif
        )
        {
            return SSOServiceClientHelpers.BuildSSOIDC_V2Client(RegionEndpoint.GetBySystemName(region), proxySettings);
        }

        private class InMemoryCache
        {
            private readonly ConcurrentDictionary<string, SSOTokenManager.CacheState> _inMemoryCache =
                new ConcurrentDictionary<string, CacheState>();

            public bool TryGetValue(SSOTokenManagerGetTokenOptions options, out CacheState inMemoryToken)
            {
                var cacheKey = BuildCacheKey(options);

                return _inMemoryCache.TryGetValue(cacheKey, out inMemoryToken);
            }

            public void AddOrUpdate(SSOTokenManagerGetTokenOptions options, CacheState newInMemoryToken)
            {
                var cacheKey = BuildCacheKey(options);

                _inMemoryCache.AddOrUpdate(cacheKey, newInMemoryToken, (x, y) => newInMemoryToken);
            }

            private static string BuildCacheKey(SSOTokenManagerGetTokenOptions options)
            {
                return !string.IsNullOrEmpty(options.Session) ? options.Session : options.StartUrl;
            }
        }

        private class RefreshState
        {
            public bool FailedLastRefreshAttempt { get; set; }
            public DateTime? BlockRefreshUntil { get; set; }

            public bool IsInRefreshCoolDown()
            {
                if (!BlockRefreshUntil.HasValue)
                    return false;

                return BlockRefreshUntil.Value < AWSSDKUtils.CorrectedUtcNow;
            }
        }

        private class CacheState
        {
            public SsoToken Token { get; set; }
            public RefreshState RefreshState { get; set; }
        }

#if BCL
        public SsoToken GetToken(SSOTokenManagerGetTokenOptions options)
        {
            CacheState inMemoryToken = null;

            if (AWSConfigs.UseSdkCache &&
                _inMemoryCache.TryGetValue(options, out inMemoryToken) &&
                !inMemoryToken.Token.NeedsRefresh())
            {
                _logger.DebugFormat($"In Memory cache has SSOToken for [{options.StartUrl}]");
                return inMemoryToken.Token;
            }

            if (_ssoTokenFileCache.TryGetSsoToken(options, options.CacheFolderLocation, out var ssoToken))
            {
                _logger.DebugFormat($"File cache has SSOToken for [{options.StartUrl}]");

                // token is not expired and doesn't need a refresh
                if (!ssoToken.NeedsRefresh())
                {
                    var newInMemoryToken = new CacheState
                    {
                        Token = ssoToken,
                        RefreshState = new RefreshState()
                    };

                    if (AWSConfigs.UseSdkCache)
                        _inMemoryCache.AddOrUpdate(options, newInMemoryToken);

                    return ssoToken;
                }
                // refresh token?
                else if (ssoToken.CanRefresh())
                {
                    _logger.DebugFormat($"File cache SSOToken for [{options.StartUrl}] needs refresh");

                    // only try and refresh an expired token once.  if we've already failed,
                    // don't try again.
                    if (true == inMemoryToken?.RefreshState.FailedLastRefreshAttempt &&
                        ssoToken.IsExpired())
                    {
                        throw new AmazonClientException("SSO Token has expired and can not be refreshed");
                    }
                    //if registration is within 5 minutes of expiration, generate a new token
                    if (ssoToken.RegisteredClientExpired() && options.SupportsGettingNewToken)
                    {
                        return GenerateNewToken(options);
                    }
                    // did we recently try to refresh the token?
                    if (true == inMemoryToken?.RefreshState.IsInRefreshCoolDown())
                    {
                        // if we can't refresh, but have a valid token, return the valid token
                        if (!ssoToken.IsExpired())
                        {
                            return ssoToken;
                        }
                        // if we can't refresh, but can generate a new token, do that
                        else if (options.SupportsGettingNewToken)
                        {
                            return GenerateNewToken(options);
                        }
                        // we've already tried to refresh and failed, nothing more can be done.
                        else
                        {
                            throw new AmazonClientException("SSO Token has expired and can not be refreshed");
                        }
                    }

                    try
                    {
                        _logger.DebugFormat($"Refreshing SSOToken for [{options.StartUrl}]");

                        var response = _ssooidcClient.RefreshToken(MapSsoTokenToGetSsoTokenResponse(ssoToken));

                        var newToken = MapGetSsoTokenResponseToSsoToken(response, options.Session);

                        _ssoTokenFileCache.SaveSsoToken(newToken, options.CacheFolderLocation);

                        var newInMemoryToken = new CacheState
                        {
                            Token = newToken,
                            RefreshState = new RefreshState()
                        };

                        if (AWSConfigs.UseSdkCache)
                            _inMemoryCache.AddOrUpdate(options, newInMemoryToken);

                        return newToken;
                    }
                    catch (Exception ex)
                    {
                        // Exception message from SSOIDC client has text along with HTTP Body as JSON string.
                        _logger.Error(ex, $"Refreshing SSOToken for [{options.StartUrl}] failed: {ex.Message.Replace("{", "{{").Replace("}", "}}")}");
                        //if refreshing the token failed that means the refresh token was expired.
                        //if the refresh token is expired and access token is expired and if the user specifies a callback with 
                        //option.SupportsGettingNewToken is true then we will generate a new token.
                        if (ssoToken.IsExpired() && options.SupportsGettingNewToken)
                        {
                            return GenerateNewToken(options);
                        }
                        else if (!ssoToken.IsExpired())
                        {
                            var newInMemoryToken = new CacheState
                            {
                                Token = ssoToken,
                                RefreshState = new RefreshState
                                {
                                    FailedLastRefreshAttempt = true,
                                    BlockRefreshUntil = AWSSDKUtils.CorrectedUtcNow.AddSeconds(30)
                                }
                            };

                            if (AWSConfigs.UseSdkCache)
                                _inMemoryCache.AddOrUpdate(options, newInMemoryToken);

                            return ssoToken;
                        }
                        else
                        {
                            throw new AmazonClientException("SSO Token has expired and failed to refresh", ex);
                        }
                    }

                }
                else if (ssoToken.IsExpired())
                {
                    if (options.SupportsGettingNewToken)
                    {
                        return GenerateNewToken(options);
                    }
                    else
                    {
                        throw new AmazonClientException("SSO Token has expired and can not be refreshed");
                    }
                }
                else
                {
                    // Token was not refreshed, continue to use until it expires
                    return ssoToken;
                }
            }

            // if no token found on disk, create one if we can
            else if (options.SupportsGettingNewToken)
            {
                return GenerateNewToken(options);
            }
            // can't find a token and can't create one
            else
            {
                throw new AmazonClientException("No valid SSO Token could be found.");
            }
        }

        public void Logout(string ssoCacheDirectory = null)
        {
            var cachedFileTokens = _ssoTokenFileCache.ScanSsoTokens(ssoCacheDirectory);
#pragma warning disable CA1031 // Do not catch general exception types.
            // specific exceptions cannot be caught here since the exception types exist in Amazon.SSO.Model namespace
            // and are not accessible in Core.
            foreach (var cachedFileToken in cachedFileTokens)
            {
                _ssoTokenFileCache.DeleteSsoToken(cachedFileToken.SsoTokenFilePath);

                if (cachedFileToken.SsoToken.Region != null)
                {
                    // Per the SSO Login Token Flow SEP,
                    // If the region to be used is not present in cached token for any reason the tool
                    // SHOULD gracefully handle this by skipping the Logout API call.
                    try
                    {
                        // create a new sso client using the region from the cached token.
                        var _ssoClient = CreateSSOLogoutClient(cachedFileToken.SsoToken.Region);
                        _ssoClient.Logout(cachedFileToken.SsoToken.AccessToken);
                    }
                    catch (Exception ex)
                    {
                        // Per the SSO Login Token Flow SEP,
                        // If the Logout API call fails due to a service error the error SHOULD be logged and
                        // the tool MUST gracefully continue the logout of any other cached tokens.
                        _logger.Error(ex, "Unable to Logout cached sso token from {0}", cachedFileToken.SsoTokenFilePath);
                    }
                }
            }
#pragma warning restore CA1031 // Do not catch general exception types
        }

        public void Logout(SSOTokenManagerGetTokenOptions options)
        {
            if (_ssoTokenFileCache.TryGetSsoToken(options, options.CacheFolderLocation, out var ssoToken))
            {
                _logger.DebugFormat($"File cache has SSOToken for [{options.StartUrl}]");

                _ssoTokenFileCache.DeleteSsoToken(options, options.CacheFolderLocation);
#pragma warning disable CA1031 // Do not catch general exception types.
                // specific exceptions cannot be caught here since the exception types exist in Amazon.SSO.Model namespace
                // and are not accessible in Core.
                try
                {
                    // create a new sso client using the region from the cached file.
                    var _ssoClient = CreateSSOLogoutClient(options.Region);
                    _ssoClient.Logout(ssoToken.AccessToken);
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, $"Unable to Logout cached sso token for [{options.StartUrl}]");
                }
#pragma warning restore CA1031 // Do not catch general exception types
            }
            else
            {
                _logger.DebugFormat($"No cached sso token found for [{options.StartUrl}]");
            }
        }

        private SsoToken GenerateNewToken(SSOTokenManagerGetTokenOptions options)
        {
            if (string.IsNullOrEmpty(options.ClientName))
            {
                throw new ArgumentNullException($"Options property cannot be empty: {nameof(options.ClientName)}");
            }

            if (options.PkceFlowOptions == null)
            {
                if (options.SsoVerificationCallback == null)
                {
                    throw new ArgumentNullException($"Options property cannot be empty: {nameof(options.SsoVerificationCallback)}");
                }
            }
            else
            {
                if (options.PkceFlowOptions.RetrieveAuthorizationCodeCallback == null)
                {
                    throw new ArgumentNullException($"Options property cannot be empty: {nameof(options.PkceFlowOptions.RetrieveAuthorizationCodeCallback)}");
                }
            }

            var request = new GetSsoTokenRequest
            {
                ClientName = GetSsoClientName(options.ClientName),
                ClientType = options.ClientType,
                StartUrl = options.StartUrl,
                SsoVerificationCallback = options.SsoVerificationCallback,
                Scopes = options.Scopes,
                PkceFlowOptions = options.PkceFlowOptions,
            };

            var response = _ssooidcClient.GetSsoToken(request);
            var token = MapGetSsoTokenResponseToSsoToken(response, options.Session);

            _ssoTokenFileCache.SaveSsoToken(token, options.CacheFolderLocation);

            return token;
        }

#endif

        public async Task<SsoToken> GetTokenAsync(SSOTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default)
        {
            CacheState inMemoryToken = null;

            if (AWSConfigs.UseSdkCache &&
                _inMemoryCache.TryGetValue(options, out inMemoryToken) &&
                !inMemoryToken.Token.NeedsRefresh())
            {
                _logger.DebugFormat($"In Memory cache has SSOToken for [{options.StartUrl}]");
                return inMemoryToken.Token;
            }

            var cachedToken = await _ssoTokenFileCache.TryGetSsoTokenAsync(
                    options,
                    options.CacheFolderLocation,
                    cancellationToken)
                .ConfigureAwait(false);

            if (cachedToken.Success)
            {
                _logger.DebugFormat($"File cache has SSOToken for [{options.StartUrl}]");

                var ssoToken = cachedToken.Value;

                // token is not expired and doesn't need a refresh
                if (!ssoToken.NeedsRefresh())
                {
                    var newInMemoryToken = new CacheState
                    {
                        Token = ssoToken,
                        RefreshState = new RefreshState()
                    };

                    if (AWSConfigs.UseSdkCache)
                        _inMemoryCache.AddOrUpdate(options, newInMemoryToken);

                    return ssoToken;
                }
                // refresh token?
                else if (ssoToken.CanRefresh())
                {
                    _logger.DebugFormat($"File cache SSOToken for [{options.StartUrl}] needs refresh");

                    // only try and refresh an expired token once.  if we've already failed,
                    // don't try again.
                    if (true == inMemoryToken?.RefreshState.FailedLastRefreshAttempt &&
                        ssoToken.IsExpired())
                    {
                        throw new AmazonClientException("SSO Token has expired and can not be refreshed");
                    }
                    //if registration is within 5 minutes of expiration, generate a new token
                    if (ssoToken.RegisteredClientExpired() && options.SupportsGettingNewToken)
                    {
                        return await GenerateNewTokenAsync(options, cancellationToken).ConfigureAwait(false);
                    }
                    // did we recently try to refresh the token?
                    if (true == inMemoryToken?.RefreshState.IsInRefreshCoolDown())
                    {
                        // if we can't refresh, but have a valid token, return the valid token
                        if (!ssoToken.IsExpired())
                        {
                            return ssoToken;
                        }
                        // if we can't refresh, but can generate a new token, do that
                        else if (options.SupportsGettingNewToken)
                        {
                            return await GenerateNewTokenAsync(options, cancellationToken).ConfigureAwait(false);
                        }
                        // we've already tried to refresh and failed, nothing more can be done.
                        else
                        {
                            throw new AmazonClientException("SSO Token has expired and can not be refreshed");
                        }
                    }

                    try
                    {
                        _logger.DebugFormat($"Refreshing SSOToken for [{options.Session}]");

                        var response = await _ssooidcClient.RefreshTokenAsync(MapSsoTokenToGetSsoTokenResponse(ssoToken)).ConfigureAwait(false);

                        var newToken = MapGetSsoTokenResponseToSsoToken(response, options.Session);

                        await _ssoTokenFileCache.SaveSsoTokenAsync(newToken, options.CacheFolderLocation, cancellationToken).ConfigureAwait(false);

                        var newInMemoryToken = new CacheState
                        {
                            Token = newToken,
                            RefreshState = new RefreshState()
                        };

                        if (AWSConfigs.UseSdkCache)
                            _inMemoryCache.AddOrUpdate(options, newInMemoryToken);

                        return newToken;
                    }
                    catch (Exception ex)
                    {
                        // Exception message from SSOIDC client has text along with HTTP Body as JSON string.
                        _logger.Error(ex, $"Refreshing SSOToken for [{options.Session}] failed: {ex.Message.Replace("{", "{{").Replace("}", "}}")}");
                        if (ssoToken.IsExpired() && options.SupportsGettingNewToken)
                        {
                            return await GenerateNewTokenAsync(options, cancellationToken).ConfigureAwait(false);
                        }
                        else if (!ssoToken.IsExpired())
                        {
                            var newInMemoryToken = new CacheState
                            {
                                Token = ssoToken,
                                RefreshState = new RefreshState
                                {
                                    FailedLastRefreshAttempt = true,
                                    BlockRefreshUntil = AWSSDKUtils.CorrectedUtcNow.AddSeconds(30)
                                }
                            };

                            if (AWSConfigs.UseSdkCache)
                                _inMemoryCache.AddOrUpdate(options, newInMemoryToken);

                            return ssoToken;
                        }
                        else
                        {
                            throw new AmazonClientException("SSO Token has expired and failed to refresh", ex);
                        }
                    }

                }
                else if (ssoToken.IsExpired())
                {
                    if (options.SupportsGettingNewToken)
                    {
                        return await GenerateNewTokenAsync(options, cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        throw new AmazonClientException("SSO Token has expired and can not be refreshed");
                    }
                }
                else
                {
                    // Token was not refreshed, continue to use until it expires
                    return ssoToken;
                }
            }

            // if no token found on disk, create one if we can
            else if (options.SupportsGettingNewToken)
            {
                return await GenerateNewTokenAsync(options, cancellationToken).ConfigureAwait(false);
            }
            // can't find a token and can't create one
            else
            {
                throw new AmazonClientException("No valid SSO Token could be found.");
            }
        }

        public async Task LogoutAsync(string ssoCacheDirectory = null, CancellationToken cancellationToken = default)
        {
            var cachedFileTokens = await _ssoTokenFileCache.ScanSsoTokensAsync(ssoCacheDirectory, cancellationToken).ConfigureAwait(false);
#pragma warning disable CA1031 // Do not catch general exception types.
            // specific exceptions cannot be caught here since the exception types exist in Amazon.SSO.Model namespace
            // and are not accessible in Core.
            foreach (var cachedFileToken in cachedFileTokens)
            {
                _ssoTokenFileCache.DeleteSsoToken(cachedFileToken.SsoTokenFilePath);

                if (cachedFileToken.SsoToken.Region != null)
                {
                    // Per the SSO Login Token Flow SEP,
                    // If the region to be used is not present in cached token for any reason the tool
                    // SHOULD gracefully handle this by skipping the Logout API call.
                    try
                    {
                        // create a new sso client using the region from the cached token.
                        var _ssoClient = CreateSSOLogoutClient(cachedFileToken.SsoToken.Region);
                        await _ssoClient.LogoutAsync(cachedFileToken.SsoToken.AccessToken, cancellationToken).ConfigureAwait(false);
                    }
                    catch (Exception ex)
                    {
                        // Per the SSO Login Token Flow SEP,
                        // If the Logout API call fails due to a service error the error SHOULD be logged and
                        // the tool MUST gracefully continue the logout of any other cached tokens.
                        _logger.Error(ex, "Unable to Logout cached sso token from {0}", cachedFileToken.SsoTokenFilePath);
                    }
                }
            }
#pragma warning restore CA1031 // Do not catch general exception types
        }

        public async Task LogoutAsync(SSOTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default)
        {
            var cachedToken = await _ssoTokenFileCache.TryGetSsoTokenAsync(
                 options,
                 options.CacheFolderLocation,
                 cancellationToken)
             .ConfigureAwait(false);

            if (cachedToken.Success)
            {
                _logger.DebugFormat($"File cache has SSOToken for [{options.StartUrl}]");
                var ssoToken = cachedToken.Value;
                _ssoTokenFileCache.DeleteSsoToken(options, options.CacheFolderLocation);
#pragma warning disable CA1031 // Do not catch general exception types.
                // specific exceptions cannot be caught here since the exception types exist in Amazon.SSO.Model namespace
                // and are not accessible in Core.
                try
                {
                    // create a new sso client using the region from the cached file.
                    var _ssoClient = CreateSSOLogoutClient(options.Region);
                    await _ssoClient.LogoutAsync(ssoToken.AccessToken, cancellationToken).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, $"Unable to Logout cached sso token for [{options.StartUrl}]");
                }
#pragma warning restore CA1031 // Do not catch general exception types
            }
            else
            {
                _logger.DebugFormat($"No cached sso token found for [{options.StartUrl}]");
            }
        }

        private async Task<SsoToken> GenerateNewTokenAsync(SSOTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default)
        {
            var emptyProperties = GetEmptySSOTokenOptions(options);

            if (emptyProperties.Count > 0)
            {
                throw new AmazonClientException($"Error generating new SSO token. Options properties cannot be empty: {string.Join(", ", emptyProperties)}");
            }

            var request = new GetSsoTokenRequest
            {
                ClientName = GetSsoClientName(options.ClientName),
                ClientType = options.ClientType,
                StartUrl = options.StartUrl,
                SsoVerificationCallback = options.SsoVerificationCallback,
                Scopes = options.Scopes,
                PkceFlowOptions = options.PkceFlowOptions,
            };

            // The SSO OIDC client used throughout this class does not propagate the cancellation token to the service operations.
            // ICoreAmazonSSOOIDC_V2 was created to allow cancellations, but it will only be available if customers update both their
            // Core and service packages.
            GetSsoTokenResponse response;
            var ssooidc_V2Client = CreateSSOOIDC_V2Client(options.Region);

            // If only Core was updated, trying to retrieve ICoreAmazonSSOOIDC_V2 will fail and we must fallback to the
            // original client (which still works, but will not allow the GetSsoTokenAsync operation to be cancelled).
            if (ssooidc_V2Client != null)
            {
                response = await ssooidc_V2Client.GetSsoTokenAsync(request, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                response = await _ssooidcClient.GetSsoTokenAsync(request).ConfigureAwait(false);
            }

            var token = MapGetSsoTokenResponseToSsoToken(response, options.Session);
            await _ssoTokenFileCache.SaveSsoTokenAsync(token, options.CacheFolderLocation, cancellationToken).ConfigureAwait(false);

            return token;
        }

        private static List<string> GetEmptySSOTokenOptions(SSOTokenManagerGetTokenOptions options)
        {
            var emptyProperties = new List<string>();

            if (string.IsNullOrEmpty(options.ClientName))
            {
                emptyProperties.Add(nameof(options.ClientName));
            }

            if (options.PkceFlowOptions == null)
            {
                if (options.SsoVerificationCallback == null)
                {
                    emptyProperties.Add(nameof(options.SsoVerificationCallback));
                }
            }
            else
            {
                if (options.PkceFlowOptions.RetrieveAuthorizationCodeCallbackAsync == null)
                {
                    emptyProperties.Add(nameof(options.PkceFlowOptions.RetrieveAuthorizationCodeCallbackAsync));
                }
            }

            return emptyProperties;
        }

        private static SsoToken MapGetSsoTokenResponseToSsoToken(GetSsoTokenResponse response, string session)
        {
            return new SsoToken
            {
                AccessToken = response.AccessToken,
                Region = response.Region,
                RefreshToken = response.RefreshToken,
                ClientId = response.ClientId,
                ClientSecret = response.ClientSecret,
                RegistrationExpiresAt = response.RegistrationExpiresAt,
                ExpiresAt = response.ExpiresAt,
                StartUrl = response.StartUrl,
                Session = session
            };
        }

        private static GetSsoTokenResponse MapSsoTokenToGetSsoTokenResponse(SsoToken token)
        {
            return new GetSsoTokenResponse
            {
                AccessToken = token.AccessToken,
                Region = token.Region,
                RefreshToken = token.RefreshToken,
                ClientId = token.ClientId,
                ClientSecret = token.ClientSecret,
                RegistrationExpiresAt = token.RegistrationExpiresAt,
                ExpiresAt = token.ExpiresAt,
                StartUrl = token.StartUrl
            };
        }

        /// <summary>
        /// Produces a client name watermarked with a timestamp for use in this provider's SSO Flow.
        /// </summary>
        /// <example>
        /// "sometool" -> "sometool-1599153467"
        /// </example>
        /// <returns>A Client Name to use in the internal SSO flow</returns>
        private static string GetSsoClientName(string clientName)
        {
            var dateStamp = AWSSDKUtils.ConvertToUnixEpochSecondsString(AWSSDKUtils.CorrectedUtcNow);
            return $"{clientName}-{dateStamp}";
        }
    }
}