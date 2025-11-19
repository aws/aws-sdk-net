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

using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Credentials.Internal
{
    public interface ILoginTokenFileCache
    {
        /// <summary>
        /// Gets the Login Token from <paramref name="loginCacheDirectory"/> based on <paramref name="loginSession"/>.
        /// </summary>
        /// <param name="loginSession">Login Session value used to calculate cached token file name.</param>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        /// <param name="loginToken">Login Token that is retrieved from cache.</param>
        /// <returns>Flag to indicate if Login Token was found.</returns>
        bool TryGetLoginToken(string loginSession, string loginCacheDirectory, out LoginToken loginToken);

        /// <summary>
        /// Saves the Login Token to <paramref name="loginCacheDirectory"/>. It derives Login Token file name from <paramref name="loginSession"/>.
        /// </summary>
        /// <param name="loginSession">Login Session value used to calculate cached token file name.</param>
        /// <param name="token">Login Token to save in cache directory.</param>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        void SaveLoginToken(string loginSession, LoginToken token, string loginCacheDirectory);

        /// <summary>
        /// Deletes the Login Token from <paramref name="loginCacheDirectory"/> based on <paramref name="loginSession"/>.
        /// </summary>
        /// <param name="loginSession">Login Session value used to calculate cached token file name.</param>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        void DeleteLoginToken(string loginSession, string loginCacheDirectory);

        /// <summary>
        /// Scans <paramref name="loginCacheDirectory"/> for all Login Token json files and returns a list of LoginToken and the file path.
        /// </summary>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        /// <returns>List of LoginToken and the file path.</returns>
        List<LoginTokenFile> ScanLoginTokens(string loginCacheDirectory);

        /// <summary>
        /// Gets the Login Token from <paramref name="loginCacheDirectory"/> based on <paramref name="loginSession"/>.
        /// </summary>
        /// <param name="loginSession">Login Session value used to calculate cached token file name.</param>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns>Task object returning instance of TryResponse which encapsulates boolean flag to indicate if Login Token was found and Login Token itself.</returns>
        Task<TryResponse<LoginToken>> TryGetLoginTokenAsync(string loginSession, string loginCacheDirectory, CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves the Login Token to <paramref name="loginCacheDirectory"/>. It derives Login Token file name from <paramref name="loginSession"/>.
        /// </summary>
        /// <param name="loginSession">Login Session value used to calculate cached token file name.</param>
        /// <param name="token">Login Token to save in cache directory.</param>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns>Task object representing asynchronous operation.</returns>
        Task SaveLoginTokenAsync(string loginSession, LoginToken token, string loginCacheDirectory, CancellationToken cancellationToken = default);

        /// <summary>
        /// Scans <paramref name="loginCacheDirectory"/> for all Login Token json files and returns a list of LoginToken and the file path.
        /// </summary>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns>List of LoginToken and the file path.</returns>
        Task<List<LoginTokenFile>> ScanLoginTokensAsync(string loginCacheDirectory, CancellationToken cancellationToken = default);
    }

    [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Try methods intentionally suppress all Exceptions")]
    public class LoginTokenFileCache : ILoginTokenFileCache
    {
        private readonly Logger _logger = Logger.GetLogger(typeof(LoginTokenFileCache));

        private readonly ICryptoUtil _cryptoUtil;
        private readonly IFile _file;
        private readonly IDirectory _directory;
        private readonly string _defaultLoginCacheDirectory =
            (!string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("AWS_LOGIN_CACHE_DIRECTORY")) 
                && Directory.Exists(Environment.GetEnvironmentVariable("AWS_LOGIN_CACHE_DIRECTORY"))) ?
            Environment.GetEnvironmentVariable("AWS_LOGIN_CACHE_DIRECTORY") 
            : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".aws", "login", "cache");

        public LoginTokenFileCache(
            ICryptoUtil cryptoUtil,
            IFile file,
            IDirectory directory)
        {
            _cryptoUtil = cryptoUtil;
            _file = file;
            _directory = directory;
        }

        /// <summary>
        /// Gets the Login Token from <paramref name="loginCacheDirectory"/> based on <paramref name="loginSession"/>.
        /// </summary>
        /// <param name="loginSession">Login Session value used to calculate cached token file name.</param>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        /// <param name="loginToken">Login Token that is retrieved from cache.</param>
        /// <returns>Flag to indicate if Login Token was found.</returns>
        public bool TryGetLoginToken(string loginSession, string loginCacheDirectory, out LoginToken loginToken)
        {
            loginToken = null;

            try
            {
                if (string.IsNullOrWhiteSpace(loginSession))
                {
                    _logger.DebugFormat("Login Session is not specified.");
                    return false;
                }

                var cacheFilePath = BuildCacheFileFullPath(loginSession, loginCacheDirectory);

                if (string.IsNullOrWhiteSpace(cacheFilePath) || !_file.Exists(cacheFilePath))
                {
                    _logger.DebugFormat("No Login Token cache to load from.");
                    return false;
                }

                var json = _file.ReadAllText(cacheFilePath);
                loginToken = JsonSerializerHelper.Deserialize<LoginToken>(json, LoginTokenJsonSerializerContexts.Default);

                _logger.DebugFormat("Login Token loaded from cache.");

                return true;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Unable to load token cache for Login Session: {0}", loginSession);
                return false;
            }
        }

        /// <summary>
        /// Gets the Login Token from <paramref name="loginCacheDirectory"/> based on <paramref name="loginSession"/>.
        /// </summary>
        /// <param name="loginSession">Login Session value used to calculate cached token file name.</param>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns>Task object returning instance of TryResponse which encapsulates boolean flag to indicate if Login Token was found and Login Token itself.</returns>
        public async Task<TryResponse<LoginToken>> TryGetLoginTokenAsync(string loginSession, string loginCacheDirectory, CancellationToken cancellationToken = default)
        {
            var result = new TryResponse<LoginToken>
            {
                Success = false
            };

            try
            {
                if (string.IsNullOrWhiteSpace(loginSession))
                {
                    _logger.DebugFormat("Login Session is not specified.");
                    return result;
                }

                var cacheFilePath = BuildCacheFileFullPath(loginSession, loginCacheDirectory);
                if (string.IsNullOrWhiteSpace(cacheFilePath) || !_file.Exists(cacheFilePath))
                {
                    _logger.DebugFormat("No Login Token cache to load from.");
                    return result;
                }

                var json = await _file.ReadAllTextAsync(cacheFilePath, cancellationToken).ConfigureAwait(false);
                result.Value = JsonSerializerHelper.Deserialize<LoginToken>(json, LoginTokenJsonSerializerContexts.Default);
                result.Success = true;

                _logger.DebugFormat("Login Token loaded from cache.");

                return result;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Unable to load token cache for Login Session: {0}", loginSession);
                return result;
            }
        }

        /// <summary>
        /// Saves the Login Token to <paramref name="loginCacheDirectory"/>. It derives Login Token file name from <paramref name="loginSession"/>.
        /// </summary>
        /// <param name="loginSession">Login Session value used to calculate cached token file name.</param>
        /// <param name="token">Login Token to save in cache directory.</param>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        public void SaveLoginToken(string loginSession, LoginToken token, string loginCacheDirectory)
        {
            if (string.IsNullOrWhiteSpace(loginSession) || token == null)
                return;

            var cacheFilePath = BuildCacheFileFullPath(loginSession, loginCacheDirectory);

            try
            {
                if (string.IsNullOrWhiteSpace(cacheFilePath))
                {
                    return;
                }

#if NET8_0_OR_GREATER
                var json = JsonSerializerHelper.Serialize<LoginToken>(token, new LoginTokenJsonSerializerContexts(new System.Text.Json.JsonSerializerOptions { WriteIndented = true }));
#else
                var json = JsonSerializerHelper.Serialize<LoginToken>(token, new LoginTokenJsonSerializerContexts(new Amazon.Util.Internal.JsonSerializerOptions { WriteIndented = true }));

#endif
                _directory.CreateDirectory(Path.GetDirectoryName(cacheFilePath));
                _file.WriteAllText(cacheFilePath, json);
            }
            catch (Exception e)
            {
                _logger.Error(e, "Warning: Unable to save Login Token Cache. Future retrieval will have to produce a token.");
            }
        }

        /// <summary>
        /// Saves the Login Token to <paramref name="loginCacheDirectory"/>. It derives Login Token file name from <paramref name="loginSession"/>.
        /// </summary>
        /// <param name="loginSession">Login Session value used to calculate cached token file name.</param>
        /// <param name="token">Login Token to save in cache directory.</param>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns>Task object representing asynchronous operation.</returns>
        public async Task SaveLoginTokenAsync(string loginSession, LoginToken token, string loginCacheDirectory, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(loginSession) || token == null)
                return;

            var cacheFilePath = BuildCacheFileFullPath(loginSession, loginCacheDirectory);

            try
            {
                if (string.IsNullOrWhiteSpace(cacheFilePath))
                {
                    return;
                }

#if NET8_0_OR_GREATER
                var json = JsonSerializerHelper.Serialize<LoginToken>(token, new LoginTokenJsonSerializerContexts(new System.Text.Json.JsonSerializerOptions { WriteIndented = true }));
#else
                var json = JsonSerializerHelper.Serialize<LoginToken>(token, new LoginTokenJsonSerializerContexts(new Amazon.Util.Internal.JsonSerializerOptions { WriteIndented = true }));

#endif

                _directory.CreateDirectory(Path.GetDirectoryName(cacheFilePath));
                await _file.WriteAllTextAsync(cacheFilePath, json, cancellationToken).ConfigureAwait(false);
            }

            catch (Exception e)
            {
                _logger.Error(e, "Warning: Unable to save Login Token Cache. Future retrieval will have to produce a token.");
            }
        }

        /// <summary>
        /// Scans <paramref name="loginCacheDirectory"/> for all Login Token json files and returns a list of LoginToken and the file path.
        /// </summary>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        /// <returns>List of LoginToken and the file path.</returns>
        public List<LoginTokenFile> ScanLoginTokens(string loginCacheDirectory)
        {
            var result = new List<LoginTokenFile>();

            if (string.IsNullOrWhiteSpace(loginCacheDirectory))
            {
                loginCacheDirectory = _defaultLoginCacheDirectory;
            }

            var cachedFiles = _directory.GetFiles(_defaultLoginCacheDirectory, "*.json");
            foreach (var cacheFilePath in cachedFiles)
            {
                var json = _file.ReadAllText(cacheFilePath);
                LoginToken loginToken = null;
                try
                {
                    loginToken = JsonSerializerHelper.Deserialize<LoginToken>(json, LoginTokenJsonSerializerContexts.Default);
                }
                catch (Exception e)
                {
                    _logger.Error(e, "ScanLoginTokens: Unable to parse login token from file '{0}'. Skipping it.", cacheFilePath);
                }

                if (loginToken != null)
                {
                    result.Add(new LoginTokenFile { LoginToken = loginToken, LoginTokenFilePath = cacheFilePath });
                }
            }
            _logger.DebugFormat("Number of cached Login tokens {0}", result.Count);

            return result;
        }

        /// <summary>
        /// Scans <paramref name="loginCacheDirectory"/> for all Login Token json files and returns a list of LoginToken and the file path.
        /// </summary>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns>List of LoginToken and the file path.</returns>
        public async Task<List<LoginTokenFile>> ScanLoginTokensAsync(string loginCacheDirectory, CancellationToken cancellationToken = default)
        {
            var result = new List<LoginTokenFile>();

            if (string.IsNullOrWhiteSpace(loginCacheDirectory))
            {
                loginCacheDirectory = _defaultLoginCacheDirectory;
            }

            var cachedFiles = _directory.GetFiles(loginCacheDirectory, "*.json");
            foreach (var cacheFilePath in cachedFiles)
            {
                var json = await _file.ReadAllTextAsync(cacheFilePath, cancellationToken).ConfigureAwait(false);
                LoginToken loginToken = null;
                try
                {
                    loginToken = JsonSerializerHelper.Deserialize<LoginToken>(json, LoginTokenJsonSerializerContexts.Default);
                }
                catch (Exception e)
                {
                    _logger.Error(e, "ScanLoginTokensAsync: Unable to parse login token from file '{0}'. Skipping it.", cacheFilePath);
                }

                if (loginToken != null)
                {
                    result.Add(new LoginTokenFile { LoginToken = loginToken, LoginTokenFilePath = cacheFilePath });
                }
            }
            _logger.DebugFormat("Number of cached Login tokens {0}", result.Count);

            return result;
        }

        /// <summary>
        /// Deletes the Login Token from <paramref name="loginCacheDirectory"/> based on <paramref name="loginSession"/>.
        /// </summary>
        /// <param name="loginSession">Login Session value used to calculate cached token file name.</param>
        /// <param name="loginCacheDirectory">Login Token cache directory. Leave null/empty to default to value pointed by AWS_LOGIN_CACHE_DIRECTORY or (user profile)/.aws/sso/cache/</param>
        public void DeleteLoginToken(string loginSession, string loginCacheDirectory)
        {
            if (string.IsNullOrWhiteSpace(loginSession))
                return;

            var cacheFilePath = BuildCacheFileFullPath(loginSession, loginCacheDirectory);
            DeleteLoginToken(cacheFilePath);
        }

        /// <summary>
        /// Deletes Login Token specified by file path.
        /// </summary>
        /// <param name="filePath">Absolute file path to Login Token cached file.</param>
        private void DeleteLoginToken(string filePath)
        {
            try
            {
                if (!Path.IsPathRooted(filePath))
                {
                    throw new ArgumentException($"{nameof(filePath)} should be an absolute file path.");
                }

                _file.Delete(filePath);
            }
            catch (Exception e)
            {
                _logger.Error(e, "Unable to delete login token file {0}", filePath);
                throw;
            }
        }

        private string BuildCacheFileFullPath(string loginSession, string loginCacheDirectory)
        {
            if (string.IsNullOrWhiteSpace(loginCacheDirectory) || !Directory.Exists(loginCacheDirectory))
            {
                loginCacheDirectory = _defaultLoginCacheDirectory;
            }

            var cacheFile = GetCacheFilename(loginSession);

            return Path.Combine(loginCacheDirectory, cacheFile);
        }

        /// <summary>
        /// Determines the file name of the Token Cache, regardless of folder.
        /// </summary>
        /// <returns>
        /// The filename to be used for a <see cref="LoginToken"/>
        /// </returns>
        private string GetCacheFilename(string loginSession)
        {
            var fileSha = GenerateSha256Hash(loginSession.Trim());

            var filename = $"{fileSha}.json";
            return filename;
        }

        /// <summary>
        /// Generate a SHA256 hash for the given text
        /// </summary>
        /// <param name="text">Text to generate a hash for</param>
        /// <returns>
        /// SHA256 hash for <paramref name="text"/>
        /// </returns>
        private string GenerateSha256Hash(string text)
        {
            var hash = _cryptoUtil.ComputeSHA256Hash(Encoding.UTF8.GetBytes(text ?? string.Empty));
            return AWSSDKUtils.ToHex(hash, true);
        }
    }

    /// <summary>
    /// Class representing Login Token and it's absolute file path.
    /// </summary>
    public class LoginTokenFile
    {
        /// <summary>
        /// <see cref="LoginToken"/>
        /// </summary>
        public LoginToken LoginToken { get; set; }

        /// <summary>
        /// Login Token file path.
        /// </summary>
        public string LoginTokenFilePath { get; set; }
    }
}