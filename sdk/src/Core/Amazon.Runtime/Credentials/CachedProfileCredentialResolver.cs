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
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.CredentialManagement;

namespace Amazon.Runtime.Credentials
{
    /// <summary>
    /// Resolves and caches credentials from a named profile specified in <see cref="IClientConfig.Profile"/>.
    /// <para />
    /// Each unique (ProfileName, Location) pair gets its own cache entry with a per-key semaphore
    /// to avoid redundant disk reads under concurrency. The cache is automatically invalidated when
    /// the backing credentials or config file is modified on disk.
    /// </summary>
    internal sealed class CachedProfileCredentialResolver : IDisposable
    {
        private readonly ConcurrentDictionary<(string ProfileName, string Location), ProfileCredentialEntry> _profileCredentialCache = new();
        private bool _disposed;

        /// <summary>
        /// Attempts to resolve credentials from the profile specified in <paramref name="clientConfig"/> synchronously.
        /// Returns null if no profile is configured, allowing the caller to fall back to other credential providers.
        /// </summary>
        public AWSCredentials TryResolveCredentials(IClientConfig clientConfig, CancellationToken cancellationToken)
        {
            var profile = clientConfig?.Profile;
            if (string.IsNullOrEmpty(profile?.Name)) return null;

            var key = (profile.Name, profile.Location ?? string.Empty);
            var entry = GetOrCreateEntry(key);

            // Fast path: valid cached credentials, no lock needed.
            var cached = entry.GetIfValid();
            if (cached != null) return cached;

            entry.ResolutionLock.Wait(cancellationToken);
            try
            {
                cached = entry.GetIfValid();
                if (cached != null) return cached;

                return ResolveAndCacheProfileCredentials(profile, entry);
            }
            // if we got here that means we were unable to find a profile with that name.
            // we must clean up the zombie entry that was added in GetOrCreateEntry above
            // so that we don't add semaphore overhead to every future call.
            catch (AmazonClientException)
            {
                _profileCredentialCache.TryRemove(key, out _);
                entry.Dispose();
                throw;
            }
            finally
            {
                try
                {
                    entry.ResolutionLock.Release();
                }
                // in multithreaded scenarios where a zombie entry was removed, releasing the lock
                // will throw an object disposed exception since the entry has been disposed.
                catch (ObjectDisposedException) { }
            }
        }

        /// <summary>
        /// Attempts to resolve credentials from the profile specified in <paramref name="clientConfig"/> asynchronously.
        /// Returns null if no profile is configured, allowing the caller to fall back to other credential providers.
        /// </summary>
        public async Task<AWSCredentials> TryResolveCredentialsAsync(IClientConfig clientConfig, CancellationToken cancellationToken)
        {
            var profile = clientConfig?.Profile;
            if (string.IsNullOrEmpty(profile?.Name)) return null;

            var key = (profile.Name, profile.Location ?? string.Empty);
            var entry = GetOrCreateEntry(key);

            // Fast path: valid cached credentials, no lock needed.
            var cached = entry.GetIfValid();
            if (cached != null) return cached;

            await entry.ResolutionLock.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                cached = entry.GetIfValid();
                if (cached != null) return cached;

                return ResolveAndCacheProfileCredentials(profile, entry);
            }
            // if we got here that means we were unable to find a profile with that name.
            // we must clean up the zombie entry that was added in GetOrCreateEntry above
            // so that we don't add semaphore overhead to every future call.
            catch (AmazonClientException)
            {
                _profileCredentialCache.TryRemove(key, out _);
                entry.Dispose();
                throw;
            }
            finally
            {
                try
                {
                    entry.ResolutionLock.Release();
                }
                // in multithreaded scenarios where a zombie entry was removed, releasing the lock
                // will throw an object disposed exception since the entry has been disposed.
                catch (ObjectDisposedException) { }
            }
        }

        /// <summary>
        /// Returns the <see cref="ProfileCredentialEntry"/> for the given key, creating it if absent.
        /// The entry owns the per-key <see cref="SemaphoreSlim"/> and the volatile cached snapshot.
        /// </summary>
        private ProfileCredentialEntry GetOrCreateEntry((string ProfileName, string Location) key)
            => _profileCredentialCache.GetOrAdd(key, _ => new ProfileCredentialEntry());

        /// <summary>
        /// Performs the actual disk read and updates the entry's cached snapshot.
        /// Must only be called while holding <paramref name="entry"/>.ResolutionLock.
        /// </summary>
        private static AWSCredentials ResolveAndCacheProfileCredentials(Profile profile, ProfileCredentialEntry entry)
        {
            var source = new CredentialProfileStoreChain(profile.Location);
            if (!source.TryGetProfile(profile.Name, out CredentialProfile storedProfile))
                throw new AmazonClientException($"Unable to find the \"{profile.Name}\" profile specified in the client configuration.");

            var credentials = storedProfile.GetAWSCredentials(source, true);
            entry.Update(credentials, source.ProfilesLocation);
            return credentials;
        }

        public void Dispose()
        {
            if (_disposed) return;
            foreach (var entry in _profileCredentialCache.Values)
                entry.Dispose();
            _disposed = true;
        }

        /// <summary>
        /// Holds the per-profile resolution lock and the volatile cached credential snapshot.
        /// The lock serialises re-resolution; the volatile field allows a lock-free fast path read.
        /// </summary>
        private sealed class ProfileCredentialEntry : IDisposable
        {
            public readonly SemaphoreSlim ResolutionLock = new SemaphoreSlim(1, 1);

            // Written only while holding ResolutionLock; read lock-free on the fast path.
            private volatile ProfileCredentialSnapshot _snapshot;

            /// <summary>Returns cached credentials if the backing files have not changed, otherwise null.</summary>
            public AWSCredentials GetIfValid()
            {
                var s = _snapshot;
                return s != null && !s.HasFileChanged() ? s.Credentials : null;
            }

            /// <summary>Replaces the cached snapshot. Must be called while holding <see cref="ResolutionLock"/>.</summary>
            public void Update(AWSCredentials credentials, string profilesLocation)
            {
                _snapshot = new ProfileCredentialSnapshot(credentials, profilesLocation);
            }

            public void Dispose() => ResolutionLock.Dispose();
        }

        /// <summary>
        /// Immutable snapshot of resolved credentials and the file timestamps captured at resolution time.
        /// </summary>
        private sealed class ProfileCredentialSnapshot
        {
            private readonly string _credentialsFilePath;
            private readonly string _configFilePath;
            private readonly DateTime _credentialsFileWriteTime;
            private readonly DateTime _configFileWriteTime;

            public AWSCredentials Credentials { get; }

            public ProfileCredentialSnapshot(AWSCredentials credentials, string profilesLocation)
            {
                Credentials = credentials;
                _credentialsFilePath = string.IsNullOrEmpty(profilesLocation)
                    ? SharedCredentialsFile.DefaultFilePath
                    : profilesLocation;
                _configFilePath = SharedCredentialsFile.DefaultConfigFilePath;
                _credentialsFileWriteTime = GetLastWriteTime(_credentialsFilePath);
                _configFileWriteTime = GetLastWriteTime(_configFilePath);
            }

            public bool HasFileChanged() =>
                GetLastWriteTime(_credentialsFilePath) != _credentialsFileWriteTime ||
                GetLastWriteTime(_configFilePath) != _configFileWriteTime;

            private static DateTime GetLastWriteTime(string path) =>
                string.IsNullOrEmpty(path) ? default : File.GetLastWriteTimeUtc(path);
        }
    }
}
