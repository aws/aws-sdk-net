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
using System.IO;
using System.Text;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// Cached Storage IO for SSO Tokens (<see cref="SsoToken"/>)
    /// </summary>
    public class SsoTokenCache
    {
        private readonly Logger _logger = Logger.GetLogger(typeof(SsoTokenCache));

        public string StartUrl { get; }

        /// <summary>
        /// Path to a token cache file. Caching is disabled when this is null.
        /// </summary>
        private readonly string _cachePath;

        /// <summary>
        /// Class constructor
        /// Caches SSO Tokens to disk under (user profile)/.aws/sso/cache/
        /// </summary>
        /// <param name="startUrl">The configured sso_start_url for the profile that credentials are being resolved for.</param>
        public SsoTokenCache(string startUrl)
            : this(
                GetDefaultSsoTokenCacheFolder(),
                startUrl)
        {
        }

        /// <summary>
        /// Overload used for unit testing (allows for custom storage location)
        /// </summary>
        /// <param name="cacheFolder">The folder containing Cached SSO Tokens. If this is null, caching is disabled.</param>
        /// <param name="startUrl">The configured sso_start_url for the profile that credentials are being resolved for.</param>
        public SsoTokenCache(string cacheFolder, string startUrl)
        {
            StartUrl = startUrl;
            
            var filename = GetCacheFilename(StartUrl);

            if (string.IsNullOrWhiteSpace(cacheFolder))
            {
                _cachePath = null;
                _logger.InfoFormat("SSO Token cache is disabled");
            }
            else
            {
                _cachePath = Path.Combine(cacheFolder, filename);
            }
        }

        /// <summary>
        /// Retrieves the SSO Token's AccessToken.
        /// </summary>
        /// <returns>
        /// SSO Token AccessToken.
        /// Returns null if the token has expired, or if the cache is invalid or does not exist.
        /// </returns>
        public string GetAccessToken()
        {
            var cache = Load();

            if (cache.IsExpired())
            {
                return null;
            }

            return cache.AccessToken;
        }

        /// <summary>
        /// Caches an SSO Token to disk.
        /// </summary>
        /// <param name="token">SSO Token to cache</param>
        public bool TrySave(SsoToken token)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_cachePath))
                {
                    return false;
                }

                if (token.StartUrl != StartUrl)
                {
                    throw new ArgumentException("StartUrl mismatch between cache and token", nameof(token));
                }

                var json = SsoTokenUtils.ToJson(token);
                Directory.CreateDirectory(Path.GetDirectoryName(_cachePath));
                File.WriteAllText(_cachePath, json);

                return true;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                _logger.Error(e, "Warning: Unable to save SSO Token Cache. Future retrieval will have to produce a token.");
                return false;
            }
        }

        /// <summary>
        /// Loads an SSO Token from cache
        /// </summary>
        /// <remarks>
        /// This method is private. The spec prohibits storing Tokens in memory. They are to be accessed to from disk
        /// when necessary.
        /// </remarks>
        /// <returns>Loaded SSO Token. Returns null if no cache exists, or is otherwise corrupt.</returns>
        private SsoToken Load()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_cachePath) || !File.Exists(_cachePath))
                {
                    _logger.InfoFormat("No SSO Token cache to load from");
                    return null;
                }

                var json = File.ReadAllText(_cachePath);
                var ssoToken = SsoTokenUtils.FromJson(json);
                _logger.InfoFormat("SSO Token loaded from cache");
                return ssoToken;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                _logger.Error(e, "Unable to load token cache for start url: {0}", StartUrl);
                return null;
            }
        }

        /// <summary>
        /// Determines the file name of the Token Cache, regardless of folder.
        /// </summary>
        /// <param name="startUrl">The Token's start url</param>
        /// <returns>The filename to be used for a Token representing <paramref name="startUrl"/></returns>
        public static string GetCacheFilename(string startUrl)
        {
            var startUrlSha = GenerateSha1Hash(startUrl);
            var filename = $"{startUrlSha}.json";
            return filename;
        }

        /// <summary>
        /// Produces the default SSO Token Cache Folder path [(user profile)/.aws/sso/cache/],
        /// returning null if this cannot be determined.
        /// </summary>
        /// <returns>Default path, null if unable to be determined</returns>
        public static string GetDefaultSsoTokenCacheFolder()
        {
            try
            {
                return Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    ".aws", "sso", "cache");
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                var logger = Logger.GetLogger(typeof(SsoTokenCache));
                logger.Error(e, "Failed to produce SSO Token Cache path, caching will be disabled");

                return null;
            }
        }

        /// <summary>
        /// Generate a SHA1 hash for the given text
        /// </summary>
        /// <param name="text">Text to generate a hash for</param>
        /// <returns>SHA1 hash for <paramref name="text"/></returns>
        private static string GenerateSha1Hash(string text)
        {
            var hash = CryptoUtilFactory.CryptoInstance.ComputeSHA1Hash(Encoding.UTF8.GetBytes(text));
            return AWSSDKUtils.ToHex(hash, true);
        }
    }
}
