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
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using Amazon.Runtime.CredentialManagement;
#if AWS_ASYNC_API
using System.Threading;
using System.Threading.Tasks;
#endif
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.Runtime.Credentials.Internal
{
    public interface ISSOTokenFileCache
    {
        /// <summary>
        /// Returns true if a cache entry exists for the <see cref="SsoToken"/> represented by
        /// <paramref name="options"/>.
        /// </summary>
        bool Exists(CredentialProfileOptions options);
        /// <inheritdoc cref="TryGetSsoTokenAsync"/>
        bool TryGetSsoToken(SSOTokenManagerGetTokenOptions getSsoTokenOptions, string ssoCacheDirectory, out SsoToken ssoToken);
        /// <inheritdoc cref="SaveSsoTokenAsync"/>
        void SaveSsoToken(SsoToken token, string ssoCacheDirectory);

#if AWS_ASYNC_API
        /// <summary>
        /// Tries to load a <see cref="SsoToken"/> from the SSO File Cache.
        /// </summary>
        /// <param name="getSsoTokenOptions">
        /// Options containing details needed to lookup the <see cref="SsoToken"/> in cache.
        /// </param>
        /// <param name="ssoCacheDirectory">
        /// Optional: Leave null/empty to default to (user profile)/.aws/sso/cache/
        /// </param>
        /// <param name="cancellationToken">
        /// Cancels the operation
        /// </param>
        /// <returns>
        /// A <see cref="TryResponse{T}"/> indicating if a <see cref="SsoToken"/> was retrieved from cache.
        /// </returns>
        Task<TryResponse<SsoToken>> TryGetSsoTokenAsync(SSOTokenManagerGetTokenOptions getSsoTokenOptions, string ssoCacheDirectory, CancellationToken cancellationToken = default);
        /// <summary>
        /// Saves <paramref name="token"/> to the SSO File Cache.
        /// </summary>
        /// <param name="token">
        /// <see cref="SsoToken"/> to persist to disk.
        /// </param>
        /// <param name="ssoCacheDirectory">
        /// Optional: Leave null/empty to default to (user profile)/.aws/sso/cache/
        /// </param>
        /// <param name="cancellationToken">
        /// Cancels the operation
        /// </param>
        Task SaveSsoTokenAsync(SsoToken token, string ssoCacheDirectory, CancellationToken cancellationToken = default);
#endif
    }

    [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Try methods intentionally suppress all Exceptions")]
    public class SSOTokenFileCache : ISSOTokenFileCache
    {
        private readonly Logger _logger = Logger.GetLogger(typeof(SSOTokenFileCache));

        private readonly ICryptoUtil _cryptoUtil;
        private readonly IFile _file;
        private readonly IDirectory _directory;

        public SSOTokenFileCache(
            ICryptoUtil cryptoUtil,
            IFile file,
            IDirectory directory)
        {
            _cryptoUtil = cryptoUtil;
            _file = file;
            _directory = directory;
        }

        public bool Exists(CredentialProfileOptions options)
        {
            var mappedOptions = new SSOTokenManagerGetTokenOptions
            {
                StartUrl = options.SsoStartUrl,
                Session = options.SsoSession
            };

            return TryGetSsoToken(mappedOptions, ssoCacheDirectory: null, out var _);
        }

        public bool TryGetSsoToken(SSOTokenManagerGetTokenOptions getSsoTokenOptions, string ssoCacheDirectory, out SsoToken ssoToken)
        {
            ssoToken = null;

            var cacheFilePath = BuildCacheFileFullPath(getSsoTokenOptions, ssoCacheDirectory);
            
            try
            {
                if (string.IsNullOrWhiteSpace(cacheFilePath) || !_file.Exists(cacheFilePath))
                {
                    _logger.InfoFormat("No SSO Token cache to load from");
                    return false;
                }

                var json = _file.ReadAllText(cacheFilePath);

                ssoToken = SsoTokenUtils.FromJson(json);

                _logger.InfoFormat("SSO Token loaded from cache");

                return true;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Unable to load token cache for start url: {0}", getSsoTokenOptions?.StartUrl);
                return false;
            }
        }

        public async Task<TryResponse<SsoToken>> TryGetSsoTokenAsync(SSOTokenManagerGetTokenOptions getSsoTokenOptions, string ssoCacheDirectory, CancellationToken cancellationToken = default)
        {
            var cacheFilePath = BuildCacheFileFullPath(getSsoTokenOptions, ssoCacheDirectory);

            var result = new TryResponse<SsoToken>
            {
                Success = false
            };

            try
            {
                if (string.IsNullOrWhiteSpace(cacheFilePath) || !_file.Exists(cacheFilePath))
                {
                    _logger.InfoFormat("No SSO Token cache to load from");
                    return result;
                }

                var json = await _file.ReadAllTextAsync(cacheFilePath, cancellationToken).ConfigureAwait(false);

                result.Value = SsoTokenUtils.FromJson(json);
                result.Success = true;
                
                _logger.InfoFormat("SSO Token loaded from cache");

                return result;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Unable to load token cache for start url: {0}", getSsoTokenOptions?.StartUrl);
                return result;
            }
        }

        public void SaveSsoToken(SsoToken token, string ssoCacheDirectory)
        {
            if (null == token)
                return;

            var cacheFilePath = BuildCacheFileFullPath(token, ssoCacheDirectory);

            try
            {
                if (string.IsNullOrWhiteSpace(cacheFilePath))
                {
                    return;
                }

                var json = SsoTokenUtils.ToJson(token);
                _directory.CreateDirectory(Path.GetDirectoryName(cacheFilePath));
                _file.WriteAllText(cacheFilePath, json);
            }
            catch (Exception e)
            {
                _logger.Error(e, "Warning: Unable to save SSO Token Cache. Future retrieval will have to produce a token.");
            }
        }

        public async Task SaveSsoTokenAsync(SsoToken token, string ssoCacheDirectory, CancellationToken cancellationToken = default)
        {
            if (null == token)
                return;

            var cacheFilePath = BuildCacheFileFullPath(token, ssoCacheDirectory);

            try
            {
                if (string.IsNullOrWhiteSpace(cacheFilePath))
                {
                    return;
                }
                
                var json = SsoTokenUtils.ToJson(token);
                _directory.CreateDirectory(Path.GetDirectoryName(cacheFilePath));
                await _file.WriteAllTextAsync(cacheFilePath, json, cancellationToken).ConfigureAwait(false);
            }

            catch (Exception e)
            {
                _logger.Error(e, "Warning: Unable to save SSO Token Cache. Future retrieval will have to produce a token.");
            }
        }

        private string BuildCacheFileFullPath(SsoToken token, string ssoCacheDirectory)
        {
            return BuildCacheFileFullPath(token.StartUrl, token.Session, ssoCacheDirectory);
        }

        private string BuildCacheFileFullPath(SSOTokenManagerGetTokenOptions getSsoTokenOptions, string ssoCacheDirectory)
        {
            return BuildCacheFileFullPath(getSsoTokenOptions.StartUrl, getSsoTokenOptions.Session, ssoCacheDirectory);
        }

        private string BuildCacheFileFullPath(string startUrl, string session, string ssoCacheDirectory)
        {
            if (string.IsNullOrWhiteSpace(ssoCacheDirectory))
            {
                ssoCacheDirectory =
                    Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                        ".aws", "sso", "cache");
            }

            var cacheFile = GetCacheFilename(startUrl, session);

            return Path.Combine(ssoCacheDirectory, cacheFile);
        }

        /// <summary>
        /// Determines the file name of the Token Cache, regardless of folder.
        /// If <see cref="SsoToken.Session"/> is set, than that will be used to calculate the filename,
        /// otherwise <see cref="SsoToken.StartUrl"/> is used.
        /// </summary>
        /// <returns>
        /// The filename to be used for a <see cref="SsoToken"/>
        /// </returns>
        private string GetCacheFilename(string startUrl, string session)
        {
            var fileSha =
                !string.IsNullOrEmpty(session)
                    ? GenerateSha1Hash(session)
                    : GenerateSha1Hash(startUrl);
            
            var filename = $"{fileSha}.json";
            return filename;
        }

        /// <summary>
        /// Generate a SHA1 hash for the given text
        /// </summary>
        /// <param name="text">Text to generate a hash for</param>
        /// <returns>
        /// SHA1 hash for <paramref name="text"/>
        /// </returns>
        private string GenerateSha1Hash(string text)
        {
            var hash = _cryptoUtil.ComputeSHA1Hash(Encoding.UTF8.GetBytes(text ?? ""));
            return AWSSDKUtils.ToHex(hash, true);
        }
    }
}