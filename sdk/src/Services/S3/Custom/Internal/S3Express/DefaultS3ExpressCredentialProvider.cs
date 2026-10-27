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
using System.Security.Cryptography;
using System.Text;
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
        private class SessionCredentialsLruItem
        {
            private const int DefaultExpirationTime = 60 * 5;

            public string BucketName { get; }
            public AWSCredentials Identity { get; }
            public SessionCredentials SessionCredentials { get; }
            public DateTime CreatedAt { get; }
            public DateTime ExpirationDate { get; }

            public SessionCredentialsLruItem(string bucketName, AWSCredentials identity, SessionCredentials sessionCredentials)
            {
                BucketName = bucketName;
                Identity = identity;
                SessionCredentials = sessionCredentials;
                CreatedAt = AWSSDKUtils.CorrectedUtcNow;
                ExpirationDate = sessionCredentials.Expiration.GetValueOrDefault().ToUniversalTime();
                if (AWSConfigs.ManualClockCorrection.HasValue)
                    ExpirationDate = ExpirationDate + AWSConfigs.ManualClockCorrection.Value;


            }
        }

        private readonly AmazonS3Client _s3Client;
        private readonly LruCache<string, SessionCredentialsLruItem> _cache;
        private readonly byte[] _cacheKeySecret = new byte[64];
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

            _cache = new LruCache<string, SessionCredentialsLruItem>(MaxCacheSize);
            using (var random = RandomNumberGenerator.Create())
                random.GetBytes(_cacheKeySecret);
            _refreshCredentialsTimer = new Timer(RefreshCredentials);
        }

        /// <summary>
        /// Resolves S3Express session credentials based on the bucket name.
        /// </summary>
        public SessionCredentials ResolveSessionCredentials(string bucketName)
        {
            return ResolveSessionCredentials(bucketName, _s3Client.ResolveCredentials());
        }

        internal SessionCredentials ResolveSessionCredentials(string bucketName, AWSCredentials identity)
        {
            var credentials = identity.GetCredentials();
            var cacheKey = GetCacheKey(bucketName, credentials);
            var sessionCredentials = GetSessionCredentialsFromCache(cacheKey);

            if (sessionCredentials == null)
            {
                _cacheLock.Wait();
                try
                {
                    //check again to see if while we were getting credentials from the cache, another thread
                    //filled the cache with the same credential already. In this case we don't want to make another
                    //create session call
                    if (_cache.TryGetValue(cacheKey, out var sessionCredentialsLruItem))
                    {
                        return sessionCredentialsLruItem.SessionCredentials;
                    }
                    else
                    {
                        var createSessionResponse = _s3Client.CreateSession(NewCreateSessionRequest(bucketName, credentials));
                        CacheSessionCredentials(cacheKey, bucketName, identity, createSessionResponse.Credentials);
                        return createSessionResponse.Credentials;
                    }
                }
                catch (NoSuchBucketException e)
                {
                    _logger.Error(e, $"Bucket: {bucketName} doesn't exist or was removed");
                    _cache.Evict(cacheKey);
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
            return ResolveSessionCredentialsAsync(bucketName, _s3Client.ResolveCredentials());
        }

        internal async Task<SessionCredentials> ResolveSessionCredentialsAsync(string bucketName, AWSCredentials identity)
        {
            var credentials = await identity.GetCredentialsAsync().ConfigureAwait(false);
            var cacheKey = GetCacheKey(bucketName, credentials);
            var sessionCredentials = GetSessionCredentialsFromCache(cacheKey);

            if (sessionCredentials == null)
            {
                await _cacheLock.WaitAsync().ConfigureAwait(false);
                try
                {
                    //check again to see if while we were getting credentials from the cache, another thread
                    //filled the cache with the same credential already. In this case we don't want to make another
                    //create session call
                    if (_cache.TryGetValue(cacheKey, out var sessionCredentialsLruItem))
                    {
                        return sessionCredentialsLruItem.SessionCredentials;
                    }
                    else
                    {
                        var createSessionResponse = await _s3Client.CreateSessionAsync(NewCreateSessionRequest(bucketName, credentials)).ConfigureAwait(false);
                        CacheSessionCredentials(cacheKey, bucketName, identity, createSessionResponse.Credentials);
                        return createSessionResponse.Credentials;
                    }
                }
                catch (NoSuchBucketException e)
                {
                    _logger.Error(e, $"Bucket: {bucketName} doesn't exist or was removed");
                    _cache.Evict(cacheKey);
                }
                finally
                {
                    _cacheLock.Release();
                }
            }
            return sessionCredentials;
        }

        private string GetCacheKey(string bucketName, ImmutableCredentials credentials)
        {
            var identity = Encoding.UTF8.GetBytes(credentials.AccessKey + credentials.SecretKey);
            var hash = CryptoUtilFactory.CryptoInstance.HMACSignBinary(identity, _cacheKeySecret, SigningAlgorithm.HmacSHA256);
            return AWSSDKUtils.ToHex(hash, true) + bucketName;
        }

        private static CreateSessionRequest NewCreateSessionRequest(string bucketName, ImmutableCredentials credentials)
        {
            return new CreateSessionRequest
            {
                BucketName = bucketName,
                SigningCredentials = credentials.UseToken
                    ? new SessionAWSCredentials(credentials.AccessKey, credentials.SecretKey, credentials.Token)
                    : new BasicAWSCredentials(credentials.AccessKey, credentials.SecretKey),
            };
        }

        private SessionCredentials GetSessionCredentialsFromCache(string cacheKey)
        {
            if (_cache.TryGetValue(cacheKey, out var item))
            {
                if (!IsExpiredSessionCredentials(item))
                    return item.SessionCredentials;
                else
                {
                    _cacheLock.Wait();
                    try
                    {
                        _cache.Evict(cacheKey);
                    }
                    finally
                    {
                        _cacheLock.Release();
                    }
                }
            }
            return null;
        }

        private void CacheSessionCredentials(string cacheKey, string bucketName, AWSCredentials identity, SessionCredentials credentials)
        {
            var credentialsLruItem = new SessionCredentialsLruItem(bucketName, identity, credentials);
            _cache.AddOrUpdate(cacheKey, credentialsLruItem);
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
                var keysToRefresh = new List<LruListItem<string, SessionCredentialsLruItem>>();
                _cacheLock.Wait();
                try
                {
                    var item = _cache.FindOldestItem();
                    while (item != null)
                    {
                        if (_lastRefreshedTime == DateTime.MinValue)
                        {
                            if (item.LastTouchedTimestamp > item.Value.CreatedAt.AddSeconds(RequestTime))
                                keysToRefresh.Add(item);
                        }
                        else
                        {
                            if (item.LastTouchedTimestamp > _lastRefreshedTime)
                                keysToRefresh.Add(item);
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
                    var bucketName = entry.Value.BucketName;
                    var baseCredentials = await entry.Value.Identity.GetCredentialsAsync().ConfigureAwait(false);
                    // Credentials changed since caching; let this entry expire.
                    if (GetCacheKey(bucketName, baseCredentials) != key)
                        continue;

                    CreateSessionResponse credentials = null;
                    try
                    {
                        credentials = await _s3Client.CreateSessionAsync(NewCreateSessionRequest(bucketName, baseCredentials)).ConfigureAwait(false);
                    }
                    catch (NoSuchBucketException e)
                    {
                        _logger.Error(e, $"Bucket: {bucketName} doesn't exist or was removed");
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

                    var credentialsLruItem = new SessionCredentialsLruItem(bucketName, entry.Value.Identity, credentials.Credentials);
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
