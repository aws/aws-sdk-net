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
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util;

namespace Amazon.Runtime.Credentials.Internal
{
    public interface ISSOTokenManager
    {
#if BCL
        SsoToken GetToken(SSOTokenManagerGetTokenOptions options);
#endif

#if AWS_ASYNC_API
        Task<SsoToken> GetTokenAsync(SSOTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default);
#endif
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

#if BCL || AWS_ASYNC_API

        private class RefreshState
        {
            public bool FailedLastRefreshAttempt { get; set; }
            public DateTime? BlockRefreshUntil { get; set; }

            public bool IsInRefreshCoolDown()
            {
                if (!BlockRefreshUntil.HasValue)
                    return false;

#pragma warning disable CS0618 // Type or member is obsolete
                return BlockRefreshUntil.Value < AWSSDKUtils.CorrectedUtcNow;
#pragma warning restore CS0618 // Type or member is obsolete
            }
        }

        private class CacheState
        {
            public SsoToken Token { get; set; }
            public RefreshState RefreshState { get; set; }
        }
#endif

#if BCL
        public SsoToken GetToken(SSOTokenManagerGetTokenOptions options)
        {
            CacheState inMemoryToken = null;

            if (AWSConfigs.UseSdkCache &&
                _inMemoryCache.TryGetValue(options, out inMemoryToken) &&
                !inMemoryToken.Token.NeedsRefresh())
            {
                _logger.InfoFormat($"In Memory cache has SSOToken for [{options.StartUrl}]");
                return inMemoryToken.Token;
            }

            if (_ssoTokenFileCache.TryGetSsoToken(options, options.CacheFolderLocation, out var ssoToken))
            {
                _logger.InfoFormat($"File cache has SSOToken for [{options.StartUrl}]");
                
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
                    _logger.InfoFormat($"File cache SSOToken for [{options.StartUrl}] needs refresh");

                    // only try and refresh an expired token once.  if we've already failed,
                    // don't try again.
                    if (true == inMemoryToken?.RefreshState.FailedLastRefreshAttempt &&
                        ssoToken.IsExpired())
                    {
                        throw new AmazonClientException("SSO Token has expired and can not be refreshed");
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
                        _logger.InfoFormat($"Refreshing SSOToken for [{options.StartUrl}]");

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
                        _logger.Error(ex, $"Refreshing SSOToken for [{options.StartUrl}] failed: {ex.Message}");
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

        private SsoToken GenerateNewToken(SSOTokenManagerGetTokenOptions options)
        {
            if (string.IsNullOrEmpty(options.ClientName))
            {
                throw new ArgumentNullException($"Options property cannot be empty: {nameof(options.ClientName)}");
            }

            if (options.SsoVerificationCallback == null)
            {
                throw new ArgumentNullException($"Options property cannot be empty: {nameof(options.SsoVerificationCallback)}");
            }

            var request = new GetSsoTokenRequest
            {
                ClientName = GetSsoClientName(options.ClientName),
                ClientType = options.ClientType,
                StartUrl = options.StartUrl,
                SsoVerificationCallback = options.SsoVerificationCallback,
                Scopes = options.Scopes
            };

            var response = _ssooidcClient.GetSsoToken(request);

            var token = MapGetSsoTokenResponseToSsoToken(response, options.Session);

            _ssoTokenFileCache.SaveSsoToken(token, options.CacheFolderLocation);

            return token;
        }
#endif

#if AWS_ASYNC_API
        public async Task<SsoToken> GetTokenAsync(SSOTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default)
        {
            CacheState inMemoryToken = null;

            if (AWSConfigs.UseSdkCache &&
                _inMemoryCache.TryGetValue(options, out inMemoryToken) &&
                !inMemoryToken.Token.NeedsRefresh())
            {
                _logger.InfoFormat($"In Memory cache has SSOToken for [{options.StartUrl}]");
                return inMemoryToken.Token;
            }

            var cachedToken = await _ssoTokenFileCache.TryGetSsoTokenAsync(
                    options,
                    options.CacheFolderLocation,
                    cancellationToken)
                .ConfigureAwait(false);

            if (cachedToken.Success)
            {
                _logger.InfoFormat($"File cache has SSOToken for [{options.StartUrl}]");

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
                    _logger.InfoFormat($"File cache SSOToken for [{options.StartUrl}] needs refresh");

                    // only try and refresh an expired token once.  if we've already failed,
                    // don't try again.
                    if (true == inMemoryToken?.RefreshState.FailedLastRefreshAttempt &&
                        ssoToken.IsExpired())
                    {
                        throw new AmazonClientException("SSO Token has expired and can not be refreshed");
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
                        _logger.InfoFormat($"Refreshing SSOToken for [{options.Session}]");

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
                        _logger.Error(ex, $"Refreshing SSOToken for [{options.Session}] failed: {ex.Message}");
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
        private async Task<SsoToken> GenerateNewTokenAsync(SSOTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(options.ClientName))
            {
                throw new ArgumentNullException($"Options property cannot be empty: {nameof(options.ClientName)}");
            }

            if (options.SsoVerificationCallback == null)
            {
                throw new ArgumentNullException($"Options property cannot be empty: {nameof(options.SsoVerificationCallback)}");
            }

            var request = new GetSsoTokenRequest
            {
                ClientName = GetSsoClientName(options.ClientName),
                ClientType = options.ClientType,
                StartUrl = options.StartUrl,
                SsoVerificationCallback = options.SsoVerificationCallback,
                Scopes = options.Scopes
            };

            var response = await _ssooidcClient.GetSsoTokenAsync(request).ConfigureAwait(false);

            var token = MapGetSsoTokenResponseToSsoToken(response, options.Session);

            await _ssoTokenFileCache.SaveSsoTokenAsync(token, options.CacheFolderLocation, cancellationToken).ConfigureAwait(false);

            return token;
        }
#endif
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
#pragma warning disable CS0618 // Type or member is obsolete
            var dateStamp = AWSSDKUtils.ConvertToUnixEpochSecondsString(AWSSDKUtils.CorrectedUtcNow);
#pragma warning restore CS0618 // Type or member is obsolete
            return $"{clientName}-{dateStamp}";
        }
    }
}