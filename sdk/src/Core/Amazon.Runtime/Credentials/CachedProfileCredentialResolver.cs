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
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal.Settings;

namespace Amazon.Runtime.Credentials
{
    /// <summary>
    /// Resolves and caches credentials from a named profile specified in <see cref="IClientConfig.Profile"/>.
    /// <para />
    /// Each unique (ProfileName, Location) pair gets its own cache entry with a per-key semaphore
    /// to avoid redundant disk reads under concurrency. The cache is automatically invalidated when
    /// the backing credentials or config file is modified on disk.
    /// </summary>
    internal class CachedProfileCredentialResolver : IDisposable
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
            }
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
                var oldSnapshot = _snapshot;
                _snapshot = new ProfileCredentialSnapshot(credentials, profilesLocation);
                oldSnapshot?.Dispose();
            }

            public void Dispose()
            {
                _snapshot?.Dispose();
                ResolutionLock.Dispose();
            }
        }

        /// <summary>
        /// Snapshot of resolved credentials that uses a dual invalidation strategy:
        /// <para />
        /// 1. <c>LastWriteTimeUtc</c> — provides immediate, synchronous detection on local file systems.
        /// 2. <see cref="FileSystemWatcher"/> — provides reliable, push-based detection on network
        /// file systems (SMB/CIFS) where <c>LastWriteTimeUtc</c> can return stale values due to
        /// client-side metadata caching (<c>FileInfoCacheLifetime</c>).
        /// Either signal is sufficient to invalidate the cache. This ensures tests pass without
        /// artificial delays (local FS timestamps update synchronously) while also being reliable
        /// in production network-storage environments.
        /// </summary>
        private sealed class ProfileCredentialSnapshot : IDisposable
        {
            // FileSystemWatcher sets this flag asynchronously via threadpool callbacks.
            private volatile bool _watcherDetectedChange;

            // LastWriteTime captured at snapshot creation — provides synchronous detection.
            private readonly string _credentialsFilePath;
            private readonly string _configFilePath;
            private readonly string _netSdkCredentialsFilePath;
            private readonly DateTime _credentialsFileWriteTime;
            private readonly DateTime _configFileWriteTime;
            private readonly DateTime _netSdkCredentialsFileWriteTime;

            private readonly FileSystemWatcher _credentialsWatcher;
            private readonly FileSystemWatcher _configWatcher;
            private readonly FileSystemWatcher _netSdkCredentialsWatcher;

            public AWSCredentials Credentials { get; }

            public ProfileCredentialSnapshot(AWSCredentials credentials, string profilesLocation)
            {
                Credentials = credentials;

                _credentialsFilePath = GetEffectiveCredentialsFilePath(profilesLocation);
                _configFilePath = SharedCredentialsFile.DefaultConfigFilePath;
                _netSdkCredentialsFilePath = GetNetSdkCredentialsFilePath(profilesLocation);

                // Capture current timestamps for synchronous detection.
                _credentialsFileWriteTime = GetLastWriteTime(_credentialsFilePath);
                _configFileWriteTime = GetLastWriteTime(_configFilePath);
                _netSdkCredentialsFileWriteTime = GetLastWriteTime(_netSdkCredentialsFilePath);

                // Set up watchers for async/network-storage detection.
                _credentialsWatcher = CreateWatcher(_credentialsFilePath);
                _configWatcher = CreateWatcher(_configFilePath);
                _netSdkCredentialsWatcher = CreateWatcher(_netSdkCredentialsFilePath);
            }

            /// <summary>
            /// Returns true if any of the backing credential files have changed since this
            /// snapshot was created. Uses two complementary signals:
            /// 1. <c>FileSystemWatcher</c> callback (async, reliable on network storage).
            /// 2. <c>LastWriteTimeUtc</c> comparison (sync, reliable on local file systems).
            /// </summary>
            public bool HasFileChanged()
            {
                // Fast path: watcher already detected a change — no I/O needed.
                if (_watcherDetectedChange)
                    return true;

                // Synchronous fallback: check timestamps (handles local FS and the case
                // where the watcher event hasn't been delivered yet on the threadpool).
                return GetLastWriteTime(_credentialsFilePath) != _credentialsFileWriteTime ||
                       GetLastWriteTime(_configFilePath) != _configFileWriteTime ||
                       GetLastWriteTime(_netSdkCredentialsFilePath) != _netSdkCredentialsFileWriteTime;
            }

            /// <summary>
            /// Creates a <see cref="FileSystemWatcher"/> that monitors a single file for changes.
            /// Returns null if the path is null/empty or the directory does not exist.
            /// </summary>
            private FileSystemWatcher CreateWatcher(string filePath)
            {
                if (string.IsNullOrEmpty(filePath))
                    return null;

                var directory = Path.GetDirectoryName(filePath);
                var fileName = Path.GetFileName(filePath);

                if (string.IsNullOrEmpty(directory) || !Directory.Exists(directory))
                    return null;

                try
                {
                    var watcher = new FileSystemWatcher(directory, fileName)
                    {
                        NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.FileName,
                        EnableRaisingEvents = true
                    };
                    watcher.Changed += OnFileEvent;
                    watcher.Created += OnFileEvent;
                    watcher.Deleted += OnFileEvent;
                    watcher.Renamed += OnFileRenamed;
                    // Treat buffer overflow as a change — fail safe rather than returning stale credentials.
                    watcher.Error += OnWatcherError;
                    return watcher;
                }
                catch (Exception ex) when (!(ex is OutOfMemoryException))
                {
                    // If we can't create a watcher (e.g., unsupported filesystem, invalid path,
                    // or I/O error), mark as changed so we always re-resolve — safe fallback.
                    _watcherDetectedChange = true;
                    return null;
                }
            }

            private void OnFileEvent(object sender, FileSystemEventArgs e) => _watcherDetectedChange = true;
            private void OnFileRenamed(object sender, RenamedEventArgs e) => _watcherDetectedChange = true;
            private void OnWatcherError(object sender, ErrorEventArgs e) => _watcherDetectedChange = true;

            /// <summary>
            /// Resolves the effective credentials file path using the same logic as
            /// <see cref="SharedCredentialsFile.SetUpFilePath"/>:
            /// 1. If <paramref name="profilesLocation"/> is provided, use it directly.
            /// 2. Else if <see cref="AWSConfigs.AWSProfilesLocation"/> is set, use that.
            /// 3. Else fall back to <see cref="SharedCredentialsFile.DefaultFilePath"/>.
            /// </summary>
            private static string GetEffectiveCredentialsFilePath(string profilesLocation)
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
            private static string GetNetSdkCredentialsFilePath(string profilesLocation)
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

            private static DateTime GetLastWriteTime(string path) =>
                string.IsNullOrEmpty(path) ? default : File.GetLastWriteTimeUtc(path);

            public void Dispose()
            {
                _credentialsWatcher?.Dispose();
                _configWatcher?.Dispose();
                _netSdkCredentialsWatcher?.Dispose();
            }
        }
    }
}
