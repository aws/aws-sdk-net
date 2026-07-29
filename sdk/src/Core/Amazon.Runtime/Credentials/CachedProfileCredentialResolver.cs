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
using Amazon.Runtime.Internal.Settings;
using Amazon.Util.Internal;

namespace Amazon.Runtime.Credentials
{
    /// <summary>
    /// Resolves and caches credentials from a named profile specified in <see cref="IClientConfig.Profile"/>.
    /// <para />
    /// Each unique (ProfileName, Location) pair gets its own cache entry with a per-key semaphore
    /// to avoid redundant disk reads under concurrency. The cache is automatically invalidated when
    /// the backing credentials or config file is modified on disk.
    /// <para />
    /// File system watchers are shared across all entries that depend on the same file path,
    /// minimizing kernel resource consumption (one watcher per unique file, not per profile).
    /// </summary>
    internal class CachedProfileCredentialResolver : IDisposable
    {
        private readonly ConcurrentDictionary<(string ProfileName, string Location), ProfileCredentialEntry> _profileCredentialCache = new();
        // key is the filePath
        private readonly ConcurrentDictionary<string, SharedFileWatcher> _fileWatchers = new();
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
            // If we got here that means we failed to find the profile and resolve credentials for that profile.
            // Remove the zombie entry from the dictionary so future callers don't pay
            // semaphore overhead, but do NOT dispose the entry: other threads may still
            // be blocked on entry.ResolutionLock.Wait/WaitAsync. They will wake up,
            // acquire the lock, fail to resolve, and re-throw. The orphaned entry
            // (and its SemaphoreSlim) will be garbage-collected once all references
            // are released — SemaphoreSlim has no unmanaged resources.
            catch (Exception ex) when (ex is AmazonClientException || ex is InvalidDataException || ex is InvalidOperationException)
            {
                _profileCredentialCache.TryRemove(key, out _);
                throw;
            }
            finally
            {
                entry.ResolutionLock.Release();
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
            // Same as the sync path: remove from dictionary but do NOT dispose.
            // See comment in TryResolveCredentials for rationale.
            catch (Exception ex) when (ex is AmazonClientException || ex is InvalidDataException || ex is InvalidOperationException)
            {
                _profileCredentialCache.TryRemove(key, out _);
                throw;
            }
            finally
            {
                entry.ResolutionLock.Release();
            }
        }

        /// <summary>
        /// Returns the <see cref="ProfileCredentialEntry"/> for the given key, creating it if absent.
        /// The entry owns the per-key <see cref="SemaphoreSlim"/> and the volatile cached credentials.
        /// </summary>
        private ProfileCredentialEntry GetOrCreateEntry((string ProfileName, string Location) key)
            => _profileCredentialCache.GetOrAdd(key, _ => new ProfileCredentialEntry());

        /// <summary>
        /// Gets or creates a shared file watcher for the given file path.
        /// Returns null if the path is null or empty.
        /// Multiple entries that depend on the same file path will share the same watcher,
        /// minimizing kernel resource usage.
        /// </summary>
        private SharedFileWatcher GetOrCreateFileWatcher(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) return null;
            return _fileWatchers.GetOrAdd(filePath, path => new SharedFileWatcher(path));
        }

        /// <summary>
        /// Performs the actual disk read and updates the entry's cached credentials.
        /// Must only be called while holding <paramref name="entry"/>.ResolutionLock.
        /// </summary>
        private AWSCredentials ResolveAndCacheProfileCredentials(Profile profile, ProfileCredentialEntry entry)
        {
            var source = new CredentialProfileStoreChain(profile.Location);
            if (!source.TryGetProfile(profile.Name, out CredentialProfile storedProfile))
                throw new AmazonClientException($"Unable to find the \"{profile.Name}\" profile specified in the client configuration.");

            var credentials = storedProfile.GetAWSCredentials(source, true);

            // Resolve file paths and obtain shared watchers.
            var credentialsFilePath = GetEffectiveCredentialsFilePath(source.ProfilesLocation);
            var configFilePath = SharedCredentialsFile.DefaultConfigFilePath;
            var netSdkCredentialsFilePath = GetNetSdkCredentialsFilePath(source.ProfilesLocation);

            var credentialsWatcher = GetOrCreateFileWatcher(credentialsFilePath);
            var configWatcher = GetOrCreateFileWatcher(configFilePath);
            var netSdkWatcher = GetOrCreateFileWatcher(netSdkCredentialsFilePath);

            entry.Update(credentials, credentialsWatcher, configWatcher, netSdkWatcher);

            return credentials;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                foreach (var entry in _profileCredentialCache.Values)
                    entry.Dispose();

                foreach (var watcher in _fileWatchers.Values)
                    watcher.Dispose();
            }
            _disposed = true;
        }

        /// <summary>
        /// Resolves the effective credentials file path using the same logic as
        /// <see cref="SharedCredentialsFile.SetUpFilePath"/>:
        /// 1. If <paramref name="profilesLocation"/> is provided, use it directly.
        /// 2. Else if <see cref="AWSConfigs.AWSProfilesLocation"/> is set, use that.
        /// 3. Else fall back to <see cref="SharedCredentialsFile.DefaultFilePath"/>.
        /// </summary>
        internal static string GetEffectiveCredentialsFilePath(string profilesLocation)
        {
            if (!string.IsNullOrEmpty(profilesLocation))
                return profilesLocation;

            if (!string.IsNullOrEmpty(AWSConfigs.AWSProfilesLocation))
                return AWSConfigs.AWSProfilesLocation;

            return SharedCredentialsFile.DefaultFilePath;
        }

        /// <summary>
        /// Returns the path to the .NET SDK credentials file (RegisteredAccounts.json)
        /// if the NetSDK store is applicable for this resolution, otherwise null.
        /// <para />
        /// The NetSDK store is only used when:
        /// 1. <paramref name="profilesLocation"/> is null or empty (no custom location override),
        /// 2. <see cref="UserCrypto.IsUserCryptAvailable"/> is true (Windows with DPAPI support), and
        /// 3. <see cref="AWSConfigs.DisableLegacyPersistenceStore"/> is false.
        /// This mirrors the same conditions used by <see cref="CredentialProfileStoreChain.TryGetProfile"/>.
        /// </summary>
        internal static string GetNetSdkCredentialsFilePath(string profilesLocation)
        {
            if (!string.IsNullOrEmpty(profilesLocation))
                return null;

            if (AWSConfigs.DisableLegacyPersistenceStore)
                return null;

            if (!UserCrypto.IsUserCryptAvailable)
                return null;

            var settingsFolder = PersistenceManager.GetSettingsStoreFolder();
            if (string.IsNullOrEmpty(settingsFolder))
                return null;

            return Path.Combine(settingsFolder, SettingsConstants.RegisteredProfiles + ".json");
        }

        /// <summary>
        /// Holds the per-profile resolution lock, cached credentials, and references to shared file watchers.
        /// Cache invalidation is purely push-based via <see cref="SharedFileWatcher"/> change tokens.
        /// Each entry stores the last-seen token for each watcher at the time credentials were resolved;
        /// staleness is determined by comparing stored tokens to current watcher tokens.
        /// </summary>
        private sealed class ProfileCredentialEntry : IDisposable
        {
            public readonly SemaphoreSlim ResolutionLock = new SemaphoreSlim(1, 1);

            // Cached credentials — written only while holding ResolutionLock; read lock-free on the fast path.
            private volatile AWSCredentials _cachedCredentials;

            // References to shared watchers.
            private SharedFileWatcher _credentialsWatcher;
            private SharedFileWatcher _configWatcher;
            private SharedFileWatcher _netSdkCredentialsWatcher;

            // Last-seen change tokens captured at the time credentials were resolved.
            // These are per-entry, so resolving one profile does not affect another.
            private long _lastSeenCredentialsToken;
            private long _lastSeenConfigToken;
            private long _lastSeenNetSdkToken;

            /// <summary>
            /// Returns cached credentials if the backing files have not changed, otherwise null.
            /// This is the lock-free fast path — purely in-memory, no I/O.
            /// </summary>
            public AWSCredentials GetIfValid()
            {
                var creds = _cachedCredentials;
                if (creds == null) return null;

                if (HasFileChanged()) return null;

                return creds;
            }

            /// <summary>
            /// Updates the cached credentials and captures the current change tokens from each watcher.
            /// Must be called while holding <see cref="ResolutionLock"/>.
            /// No shared state is reset — each entry independently tracks its own last-seen tokens.
            /// </summary>
            public void Update(
                AWSCredentials credentials,
                SharedFileWatcher credentialsWatcher, SharedFileWatcher configWatcher, SharedFileWatcher netSdkWatcher)
            {
                // Store shared watcher references.
                _credentialsWatcher = credentialsWatcher;
                _configWatcher = configWatcher;
                _netSdkCredentialsWatcher = netSdkWatcher;

                // Capture the current change tokens. These are compared on the fast path
                // to determine if the file has changed since this resolution.
                _lastSeenCredentialsToken = credentialsWatcher?.ChangeToken ?? 0;
                _lastSeenConfigToken = configWatcher?.ChangeToken ?? 0;
                _lastSeenNetSdkToken = netSdkWatcher?.ChangeToken ?? 0;

                // Store the new credentials last so concurrent readers on the fast path
                // see the captured tokens before they see the new credentials.
                _cachedCredentials = credentials;
            }

            /// <summary>
            /// Returns true if any of the backing credential files have changed since the
            /// last resolution. Compares per-entry last-seen tokens to current watcher tokens —
            /// purely in-memory, no I/O, and no shared state modification.
            /// </summary>
            private bool HasFileChanged()
            {
                if (_credentialsWatcher != null && _credentialsWatcher.ChangeToken != _lastSeenCredentialsToken)
                    return true;

                if (_configWatcher != null && _configWatcher.ChangeToken != _lastSeenConfigToken)
                    return true;

                if (_netSdkCredentialsWatcher != null && _netSdkCredentialsWatcher.ChangeToken != _lastSeenNetSdkToken)
                    return true;

                return false;
            }

            public void Dispose()
            {
                // Only dispose the semaphore — watchers are shared and owned by CachedProfileCredentialResolver.
                ResolutionLock.Dispose();
            }
        }
    }
}
