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

using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// Interface representing <see cref="LoginTokenManager"/>
    /// </summary>
    public interface ILoginTokenManager
    {
#if BCL
        /// <summary>
        /// Gets Login token using <paramref name="options"/>. If token is expired, it makes service API call to refresh the token.
        /// </summary>
        /// <param name="options">Options to be used while getting Login Token.</param>
        /// <returns>Login Token instance.</returns>
        LoginToken GetToken(LoginTokenManagerGetTokenOptions options);

        /// <summary>
        /// Performs logout operation using <paramref name="options"/>
        /// </summary>
        /// <param name="options">Options to be used for logout operation.</param>
        void Logout(LoginTokenManagerGetTokenOptions options);

#endif
        /// <summary>
        /// Gets Login token using <paramref name="options"/>. If token is expired, it makes service API call to refresh the token.
        /// </summary>
        /// <param name="options">Options to be used while getting Login Token.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>Login Token instance encapsulated withing Task object representing asynchronous operation.</returns>
        Task<LoginToken> GetTokenAsync(LoginTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default);

        /// <summary>
        /// Performs logout operation using <paramref name="options"/>
        /// </summary>
        /// <param name="options">Options to be used for logout operation.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>Task object representing asynchronous operation.</returns>
        Task LogoutAsync(LoginTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Class used to retrieve Login Token from cache. If the token is expired, then it is refreshed using instance of Amazon Signin client
    /// </summary>
    public class LoginTokenManager : ILoginTokenManager
    {
        private readonly ILogger _logger = Logger.GetLogger(typeof(LoginTokenManager));
        private readonly ICoreAmazonSignin _amazonSigninClient;
        private readonly ILoginTokenFileCache _loginTokenFileCache;
        private readonly ConcurrentDictionary<string, LoginTokenManager.CacheState> _inMemoryCache =
                new ConcurrentDictionary<string, CacheState>();

        public LoginTokenManager(
            ICoreAmazonSignin amazonSigninClient,
            ILoginTokenFileCache loginTokenFileCache)
        {
            _amazonSigninClient = amazonSigninClient;
            _loginTokenFileCache = loginTokenFileCache;
        }

        private class RefreshState
        {
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
            public LoginToken Token { get; set; }
            public RefreshState RefreshState { get; set; }
        }

        /// <summary>
        /// This class is used to invoke CreateOAuth2Token with locking mechamism per login session to avoid throttling the service.
        /// </summary>
        [SuppressMessage("AWSSDKRules", "CR1003")]
        private static class LoginSessionLockManager
        {
            private static DateTime _lastCleanupTime = DateTime.UtcNow;
            private static readonly TimeSpan CleanupInterval = TimeSpan.FromMinutes(30);

            // Internal wrapper class to track lock usage time
            internal class SessionLockEntry
            {
                public SemaphoreSlim Semaphore { get; } = new SemaphoreSlim(1, 1);

                public DateTime LastAccessTimeUtc { get; set; } = DateTime.UtcNow;
            }

            private static readonly ConcurrentDictionary<string, SessionLockEntry> _loginSessionLocks =
                new ConcurrentDictionary<string, SessionLockEntry>();

            private const int DefaultTimeoutMs = 30000; // 30 seconds

            /// <summary>
            /// Handles synchronous parameterless actions
            /// </summary>
            public static bool ExecuteWithLock(string loginSession, Action action, int timeoutMs = DefaultTimeoutMs)
            {
                return ExecuteWithLockInternal(loginSession, action, timeoutMs);
            }

            /// <summary>
            /// // Handles synchronous actions with a single parameter T
            /// </summary>
            public static bool ExecuteWithLock<T>(string loginSession, Action<T> action, T parameter, int timeoutMs = DefaultTimeoutMs)
            {
                // Wrap the Action<T> call within a parameterless Action delegate for internal use
                return ExecuteWithLockInternal(loginSession, () => { action(parameter); }, timeoutMs);
            }

            /// <summary>
            /// Handles synchronous functions (with a return value TResult)
            /// </summary>
            public static (bool success, TResult result) ExecuteWithLock<TResult>(string loginSession, Func<TResult> func, int timeoutMs = DefaultTimeoutMs)
            {
                TResult result = default;
                bool success = ExecuteWithLockInternal(loginSession, () => {
                    result = func();
                }, timeoutMs);

                return (success, result);
            }

            /// <summary>
            /// Handles async actions (Func&lt;Task&gt;, parameterless)
            /// </summary>
            public static async Task<bool> ExecuteWithLockAsync(string loginSession, Func<Task> asyncAction, int timeoutMs = DefaultTimeoutMs)
            {
                return await ExecuteWithLockInternalAsync(loginSession, asyncAction, timeoutMs).ConfigureAwait(false);
            }

            /// <summary>
            /// // Handles async actions with a single parameter T (Func&lt;T, Task&gt;)
            /// </summary>
            public static async Task<bool> ExecuteWithLockAsync<T>(string loginSession, Func<T, Task> asyncAction, T parameter, int timeoutMs = DefaultTimeoutMs)
            {
                // Wrap the Func<T, Task> call within a parameterless Func<Task> delegate
                return await ExecuteWithLockInternalAsync(loginSession, async () => { await asyncAction(parameter).ConfigureAwait(false); }, timeoutMs).ConfigureAwait(false);
            }

            /// <summary>
            /// Performs periodic cleanup of stale locks.
            /// </summary>
            private static void PerformPeriodicCleanup()
            {
                var now = AWSSDKUtils.CorrectedUtcNow;
                if (now - _lastCleanupTime > CleanupInterval)
                {
                    CleanupStaleLocks(TimeSpan.FromMinutes(30)); // Inactivity timeout of 30 min
                    _lastCleanupTime = now;
                }
            }


            /// <summary>
            /// Removes locks that haven't been accessed within the specified timeout duration.
            /// </summary>
            private static void CleanupStaleLocks(TimeSpan inactivityTimeout)
            {
                var now = DateTime.UtcNow;
                var staleKeys = _loginSessionLocks.Where(kvp => (now - kvp.Value.LastAccessTimeUtc) > inactivityTimeout)
                                             .Select(kvp => kvp.Key)
                                             .ToList();

                foreach (var key in staleKeys)
                {
                    // Safely attempt to remove the item from the concurrent dictionary
                    if (_loginSessionLocks.TryRemove(key, out SessionLockEntry removedEntry))
                    {
                        // It's vital to dispose of the SemaphoreSlim when done with it.
                        removedEntry.Semaphore.Dispose();
                    }
                }
            }

            // Deletes the lock assoicated with the specified login session.
            public static void DeleteLock(string loginSession)
            {
                if (_loginSessionLocks.TryRemove(loginSession, out SessionLockEntry removedEntry))
                {
                    removedEntry.Semaphore.Dispose();
                }
            }

            /// <summary>
            /// Synchronous internal logic (using semaphore.Wait())
            /// </summary>
            private static bool ExecuteWithLockInternal(string loginSession, Action actionToExecute, int timeoutMs)
            {
                // Execute periodic cleanup.
                PerformPeriodicCleanup();

                SessionLockEntry entry = _loginSessionLocks.GetOrAdd(loginSession, new SessionLockEntry());
                bool lockTaken = false;
                try
                {
                    lockTaken = entry.Semaphore.Wait(timeoutMs);
                    if (lockTaken)
                    {
                        // Update the timestamp immediately after taking the lock
                        entry.LastAccessTimeUtc = DateTime.UtcNow;
                        actionToExecute();
                        return true;
                    }
                    else
                    {
                        return false; 
                    }
                }
                finally
                {
                    if (lockTaken)
                    {
                        entry.Semaphore.Release();
                    }
                }
            }

            /// <summary>
            /// Asynchronous internal logic (using semaphore.WaitAsync())
            /// </summary>
            private static async Task<bool> ExecuteWithLockInternalAsync(string sessionId, Func<Task> asyncActionToExecute, int timeoutMs)
            {
                // Execute periodic cleanup.
                PerformPeriodicCleanup();

                SessionLockEntry entry = _loginSessionLocks.GetOrAdd(sessionId, new SessionLockEntry());
                bool lockTaken = false;
                try
                {
                    lockTaken = await entry.Semaphore.WaitAsync(timeoutMs).ConfigureAwait(false);
                    if (lockTaken)
                    {
                        // Update the timestamp immediately after taking the lock
                        entry.LastAccessTimeUtc = DateTime.UtcNow;
                        await asyncActionToExecute().ConfigureAwait(false);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                finally
                {
                    if (lockTaken)
                    {
                        entry.Semaphore.Release();
                    }
                }
            }
        }

#if BCL
        /// <summary>
        /// Gets Login token using <paramref name="options"/>. If token is expired, it makes service API call to refresh the token.
        /// </summary>
        /// <param name="options">Options to be used while getting Login Token.</param>
        /// <returns>Login Token instance.</returns>
        public LoginToken GetToken(LoginTokenManagerGetTokenOptions options)
        {
            CacheState inMemoryToken = null;

            if (AWSConfigs.UseSdkCache &&
                _inMemoryCache.TryGetValue(options.LoginSession, out inMemoryToken) &&
                !inMemoryToken.Token.NeedsRefresh())
            {
                _logger.DebugFormat("In Memory cache has Login Token for login session [{0}]", options.LoginSession);
                return inMemoryToken.Token;
            }

            if (_loginTokenFileCache.TryGetLoginToken(options.LoginSession, options.CacheFolderLocation, out var loginToken))
            {
                _logger.DebugFormat("File cache has Login Token for login session [{0}]", options.LoginSession);

                // Token is not expired and doesn't need a refresh.
                if (!loginToken.NeedsRefresh())
                {
                    var newInMemoryToken = new CacheState
                    {
                        Token = loginToken,
                        RefreshState = new RefreshState()
                    };

                    if (AWSConfigs.UseSdkCache)
                        AddOrUpdateInMemoryCache(options.LoginSession, newInMemoryToken);

                    return loginToken;
                }
                // refresh token?
                else if (loginToken.CanRefresh())
                {
                    _logger.DebugFormat("File cache Login Token for login session [{0}] needs refresh.", options.LoginSession);

                    // Did we recently try to refresh the token?
                    if (true == inMemoryToken?.RefreshState.IsInRefreshCoolDown())
                    {
                        // If we can't refresh, but have a valid token, return the valid token. Else we've already tried to refresh and failed, nothing more can be done.
                        if (loginToken.IsExpired())
                        {
                            throw new AmazonClientException("Login Token has expired and cannot be refreshed. Please reauthenticate.");
                        }
                        else
                        {
                            return loginToken;
                        }
                    }

                    try
                    {
                        _logger.DebugFormat("Refreshing Login Token for login session [{0}]", options.LoginSession);
                        if (string.IsNullOrEmpty(loginToken.DPoPKey))
                        {
                            throw new ArgumentNullException(nameof(loginToken.DPoPKey), $"DPoP private key missing from the cached Login Token for login session [{options.LoginSession}]. Please reauthenticate.");
                        }

                        bool refreshTokenResult = LoginSessionLockManager.ExecuteWithLock<LoginToken>(
                            options.LoginSession,
                            (LoginToken loginToken) =>
                            {
                                // Re-check for new token when a new thread acquires the lock successfully. If it doesn't need refresh, then we don't make API call.
                                if (_loginTokenFileCache.TryGetLoginToken(
                                            options.LoginSession,
                                            options.CacheFolderLocation,
                                            out var tempNewToken) && !tempNewToken.NeedsRefresh())
                                {
                                    return;
                                }

                                var coreCreateOAuth2TokenRequest = new CoreCreateOAuth2TokenRequest()
                                {
                                    TokenInput = new CoreCreateOAuth2TokenRequestBody()
                                    {
                                        ClientId = loginToken.ClientId,
                                        GrantType = "refresh_token",
                                        RefreshToken = loginToken.RefreshToken
                                    }
                                };

                                // Token is now saved (cached) in AmazonSigninPostMarshallerHandler pipeline handler where it calculates DPoP proof as well.
                                _amazonSigninClient.CreateOAuth2Token(coreCreateOAuth2TokenRequest, false);
                            },
                            loginToken);

                        if (refreshTokenResult)
                        {

                            // Token is now saved (cached) in AmazonSigninPostMarshallerHandler pipeline handler where it calculates DPoP proof as well. We can try reading new token from file cache.
                            if (_loginTokenFileCache.TryGetLoginToken(
                                            options.LoginSession,
                                            options.CacheFolderLocation,
                                            out var newToken))
                            {
                                var newInMemoryToken = new CacheState
                                {
                                    Token = newToken,
                                    RefreshState = new RefreshState()
                                };

                                if (AWSConfigs.UseSdkCache)
                                    AddOrUpdateInMemoryCache(options.LoginSession, newInMemoryToken);

                                return newToken;
                            }
                            else
                            {
                                throw new AmazonClientException("Unable to get new refreshed token.");
                            }
                        }
                        else
                        {
                            throw new AmazonClientException("Unable to get new refreshed token.");
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.Error(ex, "Refreshing Login Token for login session [{0}] failed: {1}", options.LoginSession, ex.Message);

                        if (!loginToken.IsExpired())
                        {
                            var newInMemoryToken = new CacheState
                            {
                                Token = loginToken,
                                RefreshState = new RefreshState
                                {
                                    BlockRefreshUntil = AWSSDKUtils.CorrectedUtcNow.AddSeconds(30)
                                }
                            };

                            if (AWSConfigs.UseSdkCache)
                                AddOrUpdateInMemoryCache(options.LoginSession, newInMemoryToken);

                            return loginToken;
                        }
                        else
                        {
                            throw new AmazonClientException("Login Token has expired and failed to refresh.", ex);
                        }
                    }
                }
                else if (loginToken.IsExpired())
                {
                    throw new AmazonClientException("Login Token has expired and cannot be refreshed.");
                }
                else
                {
                    // Token was not refreshed, continue to use until it expires
                    return loginToken;
                }
            }
            // Can't find a token
            else
            {
                throw new AmazonClientException("No valid Login Token could be found.");
            }
        }

        /// <summary>
        /// Performs logout operation using <paramref name="options"/>
        /// </summary>
        /// <param name="options">Options to be used for logout operation.</param>
        public void Logout(LoginTokenManagerGetTokenOptions options)
        {
            if (_loginTokenFileCache.TryGetLoginToken(options.LoginSession, options.CacheFolderLocation, out var loginToken))
            {
                _logger.DebugFormat("File cache has Login Token for login session [{0}]", options.LoginSession);
                _loginTokenFileCache.DeleteLoginToken(options.LoginSession, options.CacheFolderLocation);

                // Clear login_session from internal inMemoryCache.
                _inMemoryCache.TryRemove(options.LoginSession, out var cachedTokenValue);

                // Clear SemaphoreSlim locks in LoginSessionLockManager.
                LoginSessionLockManager.DeleteLock(options.LoginSession);
            }
            else
            {
                _logger.DebugFormat("No cached Login Token found for login session [{0}]", options.LoginSession);
            }
        }
#endif

        private void AddOrUpdateInMemoryCache(string loginSession, CacheState newInMemoryToken, bool executeCleanup = true)
        {
            _inMemoryCache.AddOrUpdate(loginSession, newInMemoryToken, (x, y) => newInMemoryToken);

            if (executeCleanup)
            {
                // Find expired sessions in inMemoryCache and delete them. Also delete corresponding SemaphoreSlim locks in LoginSessionLockManager.
                var expiredLoginSessions = _inMemoryCache
                                            .Where(item => item.Value.Token.IsExpired())
                                            .Select(item => item.Key)
                                            .ToList();

                foreach (var session in expiredLoginSessions)
                {
                    // Try removing expired login session entry from inMemoryCache.
                    if (_inMemoryCache.TryRemove(session, out _))
                    {
                        // If removal was successful, delete SemaphoreSlim locks in LoginSessionLockManager
                        LoginSessionLockManager.DeleteLock(session);
                    }
                }
            }
        }

        /// <summary>
        /// Gets Login token using <paramref name="options"/>. If token is expired, it makes service API call to refresh the token.
        /// </summary>
        /// <param name="options">Options to be used while getting Login Token.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>Login Token instance encapsulated withing Task object representing asynchronous operation.</returns>
        public async Task<LoginToken> GetTokenAsync(LoginTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default)
        {
            CacheState inMemoryToken = null;

            if (AWSConfigs.UseSdkCache &&
                _inMemoryCache.TryGetValue(options.LoginSession, out inMemoryToken) &&
                !inMemoryToken.Token.NeedsRefresh())
            {
                _logger.DebugFormat("In Memory cache has Login Token for login session [{0}]", options.LoginSession);
                return inMemoryToken.Token;
            }

            var cachedToken = await _loginTokenFileCache.TryGetLoginTokenAsync(
                    options.LoginSession,
                    options.CacheFolderLocation,
                    cancellationToken)
                .ConfigureAwait(false);

            if (cachedToken.Success)
            {
                _logger.DebugFormat("File cache has Login Token for login session [{0}]", options.LoginSession);

                var loginToken = cachedToken.Value;

                // Token is not expired and doesn't need a refresh.
                if (!loginToken.NeedsRefresh())
                {
                    var newInMemoryToken = new CacheState
                    {
                        Token = loginToken,
                        RefreshState = new RefreshState()
                    };

                    if (AWSConfigs.UseSdkCache)
                        AddOrUpdateInMemoryCache(options.LoginSession, newInMemoryToken);

                    return loginToken;
                }
                // refresh token?
                else if (loginToken.CanRefresh())
                {
                    _logger.DebugFormat("File cache Login Token for login session [{0}] needs refresh.", options.LoginSession);

                    // Did we recently try to refresh the token?
                    if (true == inMemoryToken?.RefreshState.IsInRefreshCoolDown())
                    {
                        // If we can't refresh, but have a valid token, return the valid token. Else we've already tried to refresh and failed, nothing more can be done.
                        if (loginToken.IsExpired())
                        {
                            throw new AmazonClientException("Login Token has expired and cannot be refreshed. Please reauthenticate.");
                        }
                        else
                        {
                            return loginToken;
                        }
                    }

                    try
                    {
                        _logger.DebugFormat("Refreshing Login Token for login session [{0}]", options.LoginSession);
                        if (string.IsNullOrEmpty(loginToken.DPoPKey))
                        {
                            throw new ArgumentNullException(nameof(loginToken.DPoPKey), $"DPoP private key missing from the cached Login Token for login session [{options.LoginSession}]. Please reauthenticate.");
                        }

                        bool refreshTokenResult = await LoginSessionLockManager.ExecuteWithLockAsync(
                            options.LoginSession,
                            async (LoginToken loginToken) =>
                            {
                                // Re-check for new token when a new thread acquires the lock successfully. If it doesn't need refresh, then we don't make API call.
                                var tempNewToken = await _loginTokenFileCache.TryGetLoginTokenAsync(
                                    options.LoginSession,
                                    options.CacheFolderLocation,
                                    cancellationToken).ConfigureAwait(false);
                                if (tempNewToken.Success && !tempNewToken.Value.NeedsRefresh())
                                {
                                    return;
                                }
                                
                                var coreCreateOAuth2TokenRequest = new CoreCreateOAuth2TokenRequest()
                                {
                                    TokenInput = new CoreCreateOAuth2TokenRequestBody()
                                    {
                                        ClientId = loginToken.ClientId,
                                        GrantType = "refresh_token",
                                        RefreshToken = loginToken.RefreshToken
                                    }
                                };

                                // Token is now saved (cached) in AmazonSigninPostMarshallerHandler pipeline handler where it calculates DPoP proof as well.
                                await _amazonSigninClient.CreateOAuth2TokenAsync(coreCreateOAuth2TokenRequest, false, cancellationToken).ConfigureAwait(false);
                            },
                            loginToken).ConfigureAwait(false);

                        if (refreshTokenResult)
                        {
                            // Token is now saved (cached) in AmazonSigninPostMarshallerHandler pipeline handler where it calculates DPoP proof as well. We can try reading new token from file cache.
                            var newToken = await _loginTokenFileCache.TryGetLoginTokenAsync(
                                                options.LoginSession,
                                                options.CacheFolderLocation,
                                                cancellationToken)
                                            .ConfigureAwait(false);

                            if (newToken.Success)
                            {
                                var newInMemoryToken = new CacheState
                                {
                                    Token = newToken.Value,
                                    RefreshState = new RefreshState()
                                };

                                if (AWSConfigs.UseSdkCache)
                                    AddOrUpdateInMemoryCache(options.LoginSession, newInMemoryToken);

                                return newToken.Value;
                            }
                            else
                            {
                                throw new AmazonClientException("Unable to get new refreshed token.");
                            }
                        }
                        else
                        {
                            throw new AmazonClientException("Unable to get new refreshed token.");
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.Error(ex, "Refreshing Login Token for login session [{0}] failed: {1}", options.LoginSession, ex.Message);

                        if (!loginToken.IsExpired())
                        {
                            var newInMemoryToken = new CacheState
                            {
                                Token = loginToken,
                                RefreshState = new RefreshState
                                {
                                    BlockRefreshUntil = AWSSDKUtils.CorrectedUtcNow.AddSeconds(30)
                                }
                            };

                            if (AWSConfigs.UseSdkCache)
                                AddOrUpdateInMemoryCache(options.LoginSession, newInMemoryToken);

                            return loginToken;
                        }
                        else
                        {
                            throw new AmazonClientException("Login Token has expired and failed to refresh.", ex);
                        }
                    }
                }
                else if (loginToken.IsExpired())
                {
                    throw new AmazonClientException("Login Token has expired and cannot be refreshed.");
                }
                else
                {
                    // Token was not refreshed, continue to use until it expires
                    return loginToken;
                }
            }
            // Can't find a token
            else
            {
                throw new AmazonClientException("No valid Login Token could be found.");
            }
        }

        /// <summary>
        /// Performs logout operation using <paramref name="options"/>
        /// </summary>
        /// <param name="options">Options to be used for logout operation.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>Task object representing asynchronous operation.</returns>
        public async Task LogoutAsync(LoginTokenManagerGetTokenOptions options, CancellationToken cancellationToken = default)
        {
            var cachedToken = await _loginTokenFileCache.TryGetLoginTokenAsync(
                 options.LoginSession,
                 options.CacheFolderLocation,
                 cancellationToken).ConfigureAwait(false);

            if (cachedToken.Success)
            {
                _logger.DebugFormat("File cache has Login Token for login session [{0}]", options.LoginSession);
                var loginToken = cachedToken.Value;
                _loginTokenFileCache.DeleteLoginToken(options.LoginSession, options.CacheFolderLocation);

                // Clear login_session from internal inMemoryCache.
                _inMemoryCache.TryRemove(options.LoginSession, out var cachedTokenValue);

                // Clear SemaphoreSlim locks in LoginSessionLockManager.
                LoginSessionLockManager.DeleteLock(options.LoginSession);
            }
            else
            {
                _logger.DebugFormat("No cached Login Token found for login session [{0}]", options.LoginSession);
            }
        }
    }
}