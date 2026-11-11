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
using System.Globalization;
using System.Threading;
using Amazon.S3.Model;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime;
using System.Threading.Tasks;

namespace Amazon.S3.Internal.S3Express
{
    internal class DefaultS3ExpressCredentialProvider : IS3ExpressCredentialProvider
    {
        // Sessions are cached per bucket and per set of base credentials, so a session created
        // with one identity is never returned for another.
        private sealed class SessionKey : IEquatable<SessionKey>
        {
            public SessionKey(string bucketName, ImmutableCredentials credentials)
            {
                BucketName = bucketName;
                Credentials = credentials;
            }

            public string BucketName { get; }

            // Null for anonymous clients.
            public ImmutableCredentials Credentials { get; }

            public bool Equals(SessionKey other) =>
                other != null &&
                string.Equals(BucketName, other.BucketName, StringComparison.Ordinal) &&
                Equals(Credentials, other.Credentials);

            public override bool Equals(object obj) => obj is SessionKey other && Equals(other);

            public override int GetHashCode() => Hashing.Hash(BucketName, Credentials);
        }

        private class SessionCredentialsLruItem
        {
            private const int DefaultExpirationTime = 60 * 5;

            public AWSCredentials Identity { get; }
            public SessionCredentials SessionCredentials { get; }
            public DateTime CreatedAt { get; }
            public DateTime ExpirationDate { get; }

            public SessionCredentialsLruItem(AWSCredentials identity, SessionCredentials sessionCredentials)
            {
                Identity = identity;
                SessionCredentials = sessionCredentials;
                CreatedAt = AWSSDKUtils.CorrectedUtcNow;
                ExpirationDate = sessionCredentials.Expiration.GetValueOrDefault().ToUniversalTime();
                if (AWSConfigs.ManualClockCorrection.HasValue)
                    ExpirationDate = ExpirationDate + AWSConfigs.ManualClockCorrection.Value;


            }
        }

        private readonly AmazonS3Client _s3Client;
        private readonly LruCache<SessionKey, SessionCredentialsLruItem> _cache;
        private DateTime _lastRefreshedTime;

        private readonly SemaphoreSlim _cacheLock = new SemaphoreSlim(1, 1);
        private readonly Timer _refreshCredentialsTimer;
        private bool _timerStarted;
        private Logger _logger;

        private static readonly TimeSpan _neverTimespan = TimeSpan.FromMilliseconds(-1);

        private const int MaxCacheSize = 25;
        private const int RequestTime = 15; // the buffer for the time it takes for a request
        private const int PrefetchTime = 60;


        public DefaultS3ExpressCredentialProvider(AmazonS3Client s3Client)
        {
            _s3Client = s3Client;
            _logger = Logger.GetLogger(typeof(DefaultS3ExpressCredentialProvider));

            _cache = new LruCache<SessionKey, SessionCredentialsLruItem>(MaxCacheSize);
            _refreshCredentialsTimer = new Timer(RefreshCredentials);
        }

        /// <summary>
        /// Resolves S3Express session credentials based on the bucket name.
        /// </summary>
        public SessionCredentials ResolveSessionCredentials(string bucketName)
        {
            return ResolveSessionCredentials(bucketName, _s3Client.ResolveCredentials());
        }

        /// <summary>
        /// Resolves S3Express session credentials for the bucket and the identity that signs the request.
        /// </summary>
        internal SessionCredentials ResolveSessionCredentials(string bucketName, AWSCredentials identity)
        {
            var key = new SessionKey(bucketName, identity?.GetCredentials());
            var sessionCredentials = GetSessionCredentialsFromCache(key);

            if (sessionCredentials == null)
            {
                _cacheLock.Wait();
                try
                {
                    //check again to see if while we were getting credentials from the cache, another thread
                    //filled the cache with the same credential already. In this case we don't want to make another
                    //create session call
                    if (_cache.TryGetValue(key, out var sessionCredentialsLruItem))
                    {
                        return sessionCredentialsLruItem.SessionCredentials;
                    }
                    else
                    {
                        var createSessionRequest = new CreateSessionRequest
                        {
                            BucketName = bucketName,
                        };

                        var createSessionResponse = _s3Client.CreateSession(createSessionRequest);
                        CacheSessionCredentials(key, identity, createSessionResponse.Credentials);
                        return createSessionResponse.Credentials;
                    }
                }
                catch (NoSuchBucketException e)
                {
                    _logger.Error(e, $"Bucket: {bucketName} doesn't exist or was removed");
                    _cache.Evict(key);
                }
                finally
                {
                    _cacheLock.Release();
                }
            }
            return sessionCredentials;
        }

        /// <summary>
        /// Resolves S3Express session credentials based on the bucket name.
        /// </summary>
        public Task<SessionCredentials> ResolveSessionCredentialsAsync(string bucketName, CancellationToken cancellationToken = default)
        {
            return ResolveSessionCredentialsAsync(bucketName, _s3Client.ResolveCredentials(), cancellationToken);
        }

        /// <summary>
        /// Resolves S3Express session credentials for the bucket and the identity that signs the request.
        /// </summary>
        internal async Task<SessionCredentials> ResolveSessionCredentialsAsync(string bucketName, AWSCredentials identity, CancellationToken cancellationToken = default)
        {
            var credentials = identity == null ? null : await identity.GetCredentialsAsync().ConfigureAwait(false);
            var key = new SessionKey(bucketName, credentials);
            var sessionCredentials = GetSessionCredentialsFromCache(key);

            if (sessionCredentials == null)
            {
                await _cacheLock.WaitAsync(cancellationToken).ConfigureAwait(false);
                try
                {
                    //check again to see if while we were getting credentials from the cache, another thread
                    //filled the cache with the same credential already. In this case we don't want to make another
                    //create session call
                    if (_cache.TryGetValue(key, out var sessionCredentialsLruItem))
                    {
                        return sessionCredentialsLruItem.SessionCredentials;
                    }
                    else
                    {
                        var createSessionRequest = new CreateSessionRequest
                        {
                            BucketName = bucketName,
                        };

                        var createSessionResponse = await _s3Client.CreateSessionAsync(createSessionRequest, cancellationToken).ConfigureAwait(false);
                        CacheSessionCredentials(key, identity, createSessionResponse.Credentials);
                        return createSessionResponse.Credentials;
                    }
                }
                catch (NoSuchBucketException e)
                {
                    _logger.Error(e, $"Bucket: {bucketName} doesn't exist or was removed");
                    _cache.Evict(key);
                }
                finally
                {
                    _cacheLock.Release();
                }
            }
            return sessionCredentials;
        }

        private SessionCredentials GetSessionCredentialsFromCache(SessionKey key)
        {
            if (_cache.TryGetValue(key, out var item))
            {
                if (!IsExpiredSessionCredentials(item))
                    return item.SessionCredentials;
                else
                {
                    _cacheLock.Wait();
                    try
                    {
                        _cache.Evict(key);
                    }
                    finally
                    {
                        _cacheLock.Release();
                    }
                }
            }
            return null;
        }

        private void CacheSessionCredentials(SessionKey key, AWSCredentials identity, SessionCredentials credentials)
        {
            var credentialsLruItem = new SessionCredentialsLruItem(identity, credentials);
            _cache.AddOrUpdate(key, credentialsLruItem);
            //The first call is guaranteed to set the timer since _timerStarted is false initially
            ResetCredentialsTimer(credentialsLruItem.ExpirationDate);
        }
        #region Refresh Timer Tasks
        // Refreshes credentials if recently used keys were found and resets the credentials timer.
        // While the list of keys to refresh is populated, this method blocks all other threads of the provider
        // to avoid keys being overwritten while the list is being populated. Once the list is populated
        // we only lock the cache when adding or updating items to allow other threads to resolve session
        // credentials.
        private async void RefreshCredentials(object _)
        {
            try
            {
                _logger.InfoFormat("Refreshing session credentials started in the background.");
                var keysToRefresh = new List<KeyValuePair<SessionKey, AWSCredentials>>();
                _cacheLock.Wait();
                try
                {
                    var item = _cache.FindOldestItem();
                    while (item != null)
                    {
                        if (_lastRefreshedTime == DateTime.MinValue)
                        {
                            if (item.LastTouchedTimestamp > item.Value.CreatedAt.AddSeconds(RequestTime))
                                keysToRefresh.Add(new KeyValuePair<SessionKey, AWSCredentials>(item.Key, item.Value.Identity));
                        }
                        else
                        {
                            if (item.LastTouchedTimestamp > _lastRefreshedTime)
                                keysToRefresh.Add(new KeyValuePair<SessionKey, AWSCredentials>(item.Key, item.Value.Identity));
                        }
                        //Since the oldest item is at the tail we must go to the previous item to get the next oldest item
                        item = item.Previous;
                    }
                }
                finally
                {
                    _cacheLock.Release();
                }
                DateTime resetTime = DateTime.MinValue;
                foreach (var entry in keysToRefresh)
                {
                    var key = entry.Key;
                    var identity = entry.Value;

                    ImmutableCredentials currentCredentials;
                    try
                    {
                        currentCredentials = identity == null ? null : await identity.GetCredentialsAsync().ConfigureAwait(false);
                    }
                    catch (AmazonClientException e)
                    {
                        _logger.Error(e, $"Could not resolve credentials to refresh the session for bucket: {key.BucketName}. The session will expire.");
                        continue;
                    }

                    // The credentials changed since the session was created. The session can no longer
                    // be looked up, so remove it instead of refreshing it.
                    if (!Equals(currentCredentials, key.Credentials))
                    {
                        _cacheLock.Wait();
                        try
                        {
                            _cache.Evict(key);
                        }
                        finally
                        {
                            _cacheLock.Release();
                        }
                        continue;
                    }

                    CreateSessionResponse credentials = null;
                    try
                    {
                        credentials = await _s3Client.CreateSessionAsync(new CreateSessionRequest { BucketName = key.BucketName }).ConfigureAwait(false);
                    }
                    catch (NoSuchBucketException e)
                    {
                        _logger.Error(e, $"Bucket: {key.BucketName} doesn't exist or was removed");
                        _cacheLock.Wait();
                        try
                        {
                            _cache.Evict(key);
                            continue;
                        }
                        finally
                        {
                            _cacheLock.Release();
                        }
                    }

                    var credentialsLruItem = new SessionCredentialsLruItem(identity, credentials.Credentials);
                    if (resetTime == DateTime.MinValue)
                    {
                        resetTime = credentials.Credentials.Expiration.GetValueOrDefault().ToUniversalTime();
                    }

                    _cacheLock.Wait();
                    try
                    {
                        _cache.AddOrUpdate(key, credentialsLruItem);
                    }
                    finally
                    {
                        _cacheLock.Release();
                    }
                }
                //Set timerStarted to false here, so after the 1st run we can reset the timer and refresh credentials again
                _timerStarted = false;
                if (resetTime == DateTime.MinValue)
                {
                    _logger.InfoFormat("Refreshing session credentials stopped since none were used recently.");
                    return;
                }

                _lastRefreshedTime = AWSSDKUtils.CorrectedUtcNow;
                ResetCredentialsTimer(resetTime);
            }
            catch (Exception e)
            {
                _logger.Error(e, "An unhandled exception occurred while trying to refresh session credentials.");
                _timerStarted = true;
                _refreshCredentialsTimer.Change(TimeSpan.FromSeconds(PrefetchTime), _neverTimespan);
                throw;
            }
        }
        #endregion
        private static bool IsExpiredSessionCredentials(SessionCredentialsLruItem sessionCredentialsLruItem)
        {
            // adding request time here so we don't send credentials that are just about to expire
            return AWSSDKUtils.CorrectedUtcNow > sessionCredentialsLruItem.ExpirationDate - TimeSpan.FromSeconds(RequestTime);
        }
        private void ResetCredentialsTimer(DateTime resetTime)
        {
            var timeToStart = resetTime.AddSeconds(-1 * PrefetchTime);
            if (_timerStarted)
                return;
            _refreshCredentialsTimer.Change(timeToStart - AWSSDKUtils.CorrectedUtcNow, _neverTimespan);
            _timerStarted = true;

        }
        #region IDisposable Support
        private bool _isDisposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    _refreshCredentialsTimer.Dispose();
                    _logger = null;
                }

                _isDisposed = true;
            }
        }

        /// <summary>
        /// Dispose this object and all related resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
