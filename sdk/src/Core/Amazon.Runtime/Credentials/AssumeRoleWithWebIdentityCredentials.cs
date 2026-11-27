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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.RuntimeDependencies;
using Amazon.Util;
using Amazon.Util.Internal;
using ThirdParty.RuntimeBackports;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.UserAgent;

namespace Amazon.Runtime
{
    /// <summary>
    /// AWS Credentials that automatically refresh by calling AssumeRole on
    /// the Amazon Security Token Service.
    /// </summary>
    public partial class AssumeRoleWithWebIdentityCredentials : RefreshingAWSCredentials
    {
        /// <inheritdoc/>
        protected sealed override bool UsesManagedRefreshLifecycle => true;

        private static readonly RegionEndpoint _defaultSTSClientRegion = RegionEndpoint.USEast1;
        private static readonly string _roleSessionNameDefault = Guid.NewGuid().ToString();

        /// <summary>
        /// As established by STS, the regex used to validate the role session names is a string of 2-64 characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@-
        /// </summary>
        public const string WebIdentityTokenFileEnvVariable = "AWS_WEB_IDENTITY_TOKEN_FILE";
        public const string RoleArnEnvVariable = "AWS_ROLE_ARN";
        public const string RoleSessionNameEnvVariable = "AWS_ROLE_SESSION_NAME";
        private const string RoleSessionNameRegexPattern = @"^[\w+=,.@-]{2,64}$";

#if NET8_0_OR_GREATER
        [GeneratedRegex(RoleSessionNameRegexPattern)]
        private static partial Regex RoleSessionNameRegex();
#else
        private static Regex RoleSessionNameRegex() => _roleSessionNameRegex;
        private static readonly Regex _roleSessionNameRegex = new Regex(RoleSessionNameRegexPattern, RegexOptions.Compiled);
#endif

        private readonly Logger _logger = Logger.GetLogger(typeof(AssumeRoleWithWebIdentityCredentials));

        /// <summary>
        /// Options to be used in the call to AssumeRole.
        /// </summary>
        private AssumeRoleWithWebIdentityCredentialsOptions _options;

        #region Properties
        
        /// <summary>
        /// The absolute path to the file on disk containing an OIDC token
        /// </summary>
        public string WebIdentityTokenFile { get; }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the role to assume.
        /// </summary>
        public string RoleArn { get; }

        /// <summary>
        /// An identifier for the assumed role session.
        /// </summary>
        public string RoleSessionName { get; }

        #endregion Properties

        /// <summary>
        /// Constructs an AssumeRoleWithWebIdentityCredentials object.
        /// </summary>
        /// <param name="webIdentityTokenFile">The absolute path to the file on disk containing an OIDC token.</param>
        /// <param name="roleArn">The Amazon Resource Name (ARN) of the role to assume.</param>
        /// <param name="roleSessionName">An identifier for the assumed role session.</param>
        public AssumeRoleWithWebIdentityCredentials(string webIdentityTokenFile, string roleArn, string roleSessionName)
        : this(webIdentityTokenFile, roleArn, roleSessionName, new AssumeRoleWithWebIdentityCredentialsOptions()) { }

        /// <summary>
        /// Constructs an AssumeRoleWithWebIdentityCredentials object.
        /// </summary>
        /// <param name="webIdentityTokenFile">The absolute path to the file on disk containing an OIDC token.</param>
        /// <param name="roleArn">The Amazon Resource Name (ARN) of the role to assume.</param>
        /// <param name="roleSessionName">An identifier for the assumed role session.</param>
        /// <param name="options">Options to be used in the call to AssumeRole.</param>
        public AssumeRoleWithWebIdentityCredentials(string webIdentityTokenFile, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
        {
            if (string.IsNullOrEmpty(webIdentityTokenFile))
            {
                throw new ArgumentNullException(nameof(webIdentityTokenFile), $"The {nameof(webIdentityTokenFile)} must be an absolute path.");
            }
            else if (!AWSSDKUtils.IsAbsolutePath(webIdentityTokenFile))
            {
                throw new ArgumentException($"The {nameof(webIdentityTokenFile)} must be an absolute path.", nameof(webIdentityTokenFile));
            }

            if (string.IsNullOrEmpty(roleArn))
            {
                throw new ArgumentNullException(nameof(roleArn), "The role ARN must be specified.");
            }

            if (!string.IsNullOrEmpty(roleSessionName) && !RoleSessionNameRegex().IsMatch(roleSessionName))
            {
                throw new ArgumentOutOfRangeException(nameof(roleSessionName), roleSessionName, $"The value must match the regex pattern @\"{RoleSessionNameRegex()}\".");
            }

            WebIdentityTokenFile = webIdentityTokenFile;
            RoleArn = roleArn;
            RoleSessionName = string.IsNullOrEmpty(roleSessionName) ? _roleSessionNameDefault : roleSessionName;
            _options = options;
            FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_STS_ASSUME_ROLE_WEB_ID);

            // PreemptExpiryTime is not set here. The base class chooses the background refresh window from the
            // lifetime of each set of credentials (5 minutes for a lifetime of 20 minutes or less), and it does not
            // start a background refresh for credentials that are already inside that window when they are fetched
            // (https://github.com/aws/aws-sdk-net/issues/4313). A value that the caller sets takes precedence.
        }

        /// <summary>
        /// Creates an instance of <see cref="AssumeRoleWithWebIdentityCredentials"/> from environment variables.
        /// </summary>
        /// <exception>Throws an <see cref="InvalidOperationException"/> if the needed environment variables are not set.</exception>
        /// <returns>The new credentials.</returns>
        public static AssumeRoleWithWebIdentityCredentials FromEnvironmentVariables()
        {
            var webIdentityTokenFile = Environment.GetEnvironmentVariable(WebIdentityTokenFileEnvVariable);
            var roleArn = Environment.GetEnvironmentVariable(RoleArnEnvVariable);
            var roleSessionName = Environment.GetEnvironmentVariable(RoleSessionNameEnvVariable);

            var credentials = new AssumeRoleWithWebIdentityCredentials(webIdentityTokenFile, roleArn, roleSessionName);
            credentials.FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_ENV_VARS_STS_WEB_ID_TOKEN);
            
            return credentials;
        }

        // The STS error code for an expired web identity token. The STS client wraps the service's
        // ExpiredTokenException in an AmazonClientException, and Core cannot reference the STS exception type, so the
        // error is matched by this code on the inner AmazonServiceException.
        private const string ExpiredWebIdentityTokenErrorCode = "ExpiredTokenException";

        // The wait before STS is called again after it rejected the web identity token as expired: 100, 400 and then
        // 1000 milliseconds, the waits of DefaultRetryPolicy.WaitBeforeRetry(retry, 1000).
        private static TimeSpan ExpiredTokenRetryDelay(int retry)
            => TimeSpan.FromMilliseconds(Math.Min(Math.Pow(4, retry) * 100, 1000));

        /// <summary>
        /// Waits before <see cref="GenerateNewCredentialsAsync"/> calls STS again after STS rejected the web identity
        /// token as expired. The wait does not block a thread. Replaced in unit tests so that they do not wait.
        /// </summary>
        internal Func<int, Task> WaitBeforeExpiredTokenRetryAsync { get; set; } = retry => Task.Delay(ExpiredTokenRetryDelay(retry));

        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            // Read the OIDC token file and call STS again when STS rejects the web identity token as expired, because
            // the OIDC provider may have written a rotated token to disk since the last read. Bounded by
            // DefaultMaxRetry (the initial attempt plus DefaultMaxRetry retries). The STS client's own
            // InvalidIdentityToken/IDPCommunicationError retries and the file-read retries still apply. On any other
            // error, or once these retries are exhausted, the error propagates and the base class handles it as a
            // failed refresh. One STS client is created for the refresh, after the token file is first read, and is
            // used for every attempt.
            ICoreAmazonSTS coreStsClient = null;
            for (var stsRetry = 0; ; stsRetry++)
            {
                var token = ReadTokenFromFile();
                if (coreStsClient == null)
                    coreStsClient = CreateClient();
                try
                {
                    AssumeRoleImmutableCredentials credentials = coreStsClient.CredentialsFromAssumeRoleWithWebIdentityAuthentication(token, RoleArn, RoleSessionName, _options); // Will retry InvalidIdentityToken and IDPCommunicationError
                    _logger.DebugFormat("New credentials created using assume role with web identity that expire at {0}", credentials.Expiration.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture));
                    return new CredentialsRefreshState(credentials, credentials.Expiration);
                }
                catch (Exception e) when (stsRetry < AWSSDKUtils.DefaultMaxRetry && IsExpiredWebIdentityTokenError(e))
                {
                    _logger.DebugFormat("The web identity token was rejected as expired by STS; reloading the WebIdentityTokenFile and retrying the STS call (attempt {0} of {1}).", stsRetry + 1, AWSSDKUtils.DefaultMaxRetry);
                    AWSSDKUtils.Sleep(ExpiredTokenRetryDelay(stsRetry));
                }
            }
        }

        protected override async Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
        {
            // Asynchronous counterpart of GenerateNewCredentials; see that method. The wait before each retry is
            // awaited, so it does not block a thread while the refresh lock is held.
            ICoreAmazonSTS coreStsClient = null;
            for (var stsRetry = 0; ; stsRetry++)
            {
                var token = await ReadTokenFromFileAsync().ConfigureAwait(false);
                if (coreStsClient == null)
                    coreStsClient = CreateClient();
                try
                {
                    AssumeRoleImmutableCredentials credentials = await coreStsClient.CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(token, RoleArn, RoleSessionName, _options).ConfigureAwait(false); // Will retry InvalidIdentityToken and IDPCommunicationError
                    _logger.DebugFormat("New credentials created using assume role with web identity that expire at {0}", credentials.Expiration.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture));
                    return new CredentialsRefreshState(credentials, credentials.Expiration);
                }
                catch (Exception e) when (stsRetry < AWSSDKUtils.DefaultMaxRetry && IsExpiredWebIdentityTokenError(e))
                {
                    _logger.DebugFormat("The web identity token was rejected as expired by STS; reloading the WebIdentityTokenFile and retrying the STS call (attempt {0} of {1}).", stsRetry + 1, AWSSDKUtils.DefaultMaxRetry);
                    await WaitBeforeExpiredTokenRetryAsync(stsRetry).ConfigureAwait(false);
                }
            }
        }

        /// <summary>
        /// Reads the OIDC token from <see cref="WebIdentityTokenFile"/>, retrying transient read failures up to
        /// <see cref="AWSSDKUtils.DefaultMaxRetry"/> times. Throws <see cref="InvalidOperationException"/> if the
        /// file cannot be read after the final retry.
        /// </summary>
        private string ReadTokenFromFile()
        {
            string token = null;
            for (var retry = 0; retry <= AWSSDKUtils.DefaultMaxRetry; retry++)
            {
                try
                {
                    using (var fileStream = new FileStream(WebIdentityTokenFile, FileMode.Open, FileAccess.Read)) // Using FileStream to support NetStandard 1.3
                    {
                        using (var streamReader = new StreamReader(fileStream))
                        {
                            token = streamReader.ReadToEnd();
                        }
                    }
                    break;
                }
                catch (Exception e)
                {
                    if (retry == AWSSDKUtils.DefaultMaxRetry)
                    {
                        _logger.Debug(e, $"A token could not be loaded from the WebIdentityTokenFile at {WebIdentityTokenFile}.");
                        throw new InvalidOperationException("A token could not be loaded from the WebIdentityTokenFile.", e);
                    }

                    DefaultRetryPolicy.WaitBeforeRetry(retry, 1000);
                }
            }

            return token;
        }

        /// <summary>
        /// Asynchronous counterpart of <see cref="ReadTokenFromFile"/>.
        /// </summary>
        private async Task<string> ReadTokenFromFileAsync()
        {
            string token = null;
            for (var retry = 0; retry <= AWSSDKUtils.DefaultMaxRetry; retry++)
            {
                try
                {
                    using (var fileStream = new FileStream(WebIdentityTokenFile, FileMode.Open, FileAccess.Read)) // Using FileStream to support NetStandard 1.3
                    {
                        using (var streamReader = new StreamReader(fileStream))
                        {
                            token = await streamReader.ReadToEndAsync().ConfigureAwait(false);
                        }
                    }
                    break;
                }
                catch (Exception e)
                {
                    if (retry == AWSSDKUtils.DefaultMaxRetry)
                    {
                        _logger.Debug(e, $"A token could not be loaded from the WebIdentityTokenFile at {WebIdentityTokenFile}.");
                        throw new InvalidOperationException("A token could not be loaded from the WebIdentityTokenFile.", e);
                    }

                    DefaultRetryPolicy.WaitBeforeRetry(retry, 1000);
                }
            }

            return token;
        }

        /// <summary>
        /// Returns true only when <paramref name="exception"/> (or an exception in its inner-exception chain) is an
        /// <see cref="AmazonServiceException"/> whose <see cref="AmazonServiceException.ErrorCode"/> is exactly the
        /// modeled STS expired-web-identity-token code. The chain is walked because the STS ICoreAmazonSTS extension
        /// wraps the modeled exception in an <see cref="AmazonClientException"/>. The match is on the exact error
        /// code so that other STS errors are not swallowed and still drive the base refresh backoff.
        /// </summary>
        private static bool IsExpiredWebIdentityTokenError(Exception exception)
        {
            for (var current = exception; current != null; current = current.InnerException)
            {
                if (current is AmazonServiceException serviceException &&
                    string.Equals(serviceException.ErrorCode, ExpiredWebIdentityTokenErrorCode, StringComparison.Ordinal))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets a client to be used for AssumeRoleWithWebIdentity requests.
        /// </summary>
        /// <returns>The STS client.</returns>
        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026",
            Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
        protected virtual ICoreAmazonSTS CreateClient()
        {
            var region = FallbackRegionFactory.GetRegionEndpoint() ?? _defaultSTSClientRegion;

            ICoreAmazonSTS coreSTSClient = GlobalRuntimeDependencyRegistry.Instance.GetInstance<ICoreAmazonSTS>(ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME,
                new CreateInstanceContext(new SecurityTokenServiceClientContext { Action = SecurityTokenServiceClientContext.ActionContext.AssumeRoleAWSCredentials, Region = region, ProxySettings = _options?.ProxySettings }));
            if(coreSTSClient == null)
            {
                try
                {
                    var stsConfig = ServiceClientHelpers.CreateServiceConfig(ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CONFIG_NAME);
                    stsConfig.RegionEndpoint = region;

                    if (_options?.ProxySettings != null)
                    {
                        stsConfig.SetWebProxy(_options.ProxySettings);
                    }

                    coreSTSClient = ServiceClientHelpers.CreateServiceFromAssembly<ICoreAmazonSTS>(
                                ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME, new AnonymousAWSCredentials(), stsConfig);
                }
                catch (Exception e)
                {
                    if (InternalSDKUtils.IsRunningNativeAot())
                    {
                        throw new MissingRuntimeDependencyException(ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME, nameof(GlobalRuntimeDependencyRegistry.RegisterSecurityTokenServiceClient));
                    }

                    var msg = string.Format(CultureInfo.CurrentCulture,
                        "Assembly {0} could not be found or loaded. This assembly must be available at runtime to use Amazon.Runtime.AssumeRoleAWSCredentials.",
                        ServiceClientHelpers.STS_ASSEMBLY_NAME);
                    throw new InvalidOperationException(msg, e);
                }
            }

            return coreSTSClient;
        }
    }
}
