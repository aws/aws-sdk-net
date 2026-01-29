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
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif

namespace Amazon.Runtime
{
    /// <summary>
    /// AWS Credentials that automatically refresh by calling AssumeRole on
    /// the Amazon Security Token Service.
    /// </summary>
    public partial class AssumeRoleWithWebIdentityCredentials : RefreshingAWSCredentials
    {
        private const int PREEMPT_EXPIRY_MINUTES = 15;
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

            // The minimum duration for AssumeRoleWithWebIdentity is 15 minutes (900 seconds), and if that value
            // is requested a 15-minute preempt expiry time may cause the SDK to generate credentials
            // more frequently than needed (https://github.com/aws/aws-sdk-net/issues/4313).
            //
            // If customers request a duration of 20 minutes (1200 seconds) or less, use a smaller
            // preempt expiry time of 5 minutes.
            if (_options != null && _options.DurationSeconds.HasValue && _options.DurationSeconds.Value <= 1200)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(5);
            }
            else
            {
                // Otherwise, use the default of 15 minutes to make sure to fetch new credentials well before
                // the current credentials expire to avoid any request being made with expired credentials.
                PreemptExpiryTime = TimeSpan.FromMinutes(PREEMPT_EXPIRY_MINUTES);
            }
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
            return new AssumeRoleWithWebIdentityCredentials(webIdentityTokenFile, roleArn, roleSessionName);
        }

        protected override CredentialsRefreshState GenerateNewCredentials()
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

            AssumeRoleImmutableCredentials credentials;
            using (var coreStsClient = CreateClient())
            {
                credentials = coreStsClient.CredentialsFromAssumeRoleWithWebIdentityAuthentication(token, RoleArn, RoleSessionName, _options); // Will retry InvalidIdentityToken and IDPCommunicationError
            }
            _logger.InfoFormat("New credentials created using assume role with web identity that expire at {0}", credentials.Expiration.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture));
            return new CredentialsRefreshState(credentials, credentials.Expiration);
        }

#if AWS_ASYNC_API
        protected override async Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
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

            AssumeRoleImmutableCredentials credentials;
            using (var coreStsClient = CreateClient())
            {
                credentials = await coreStsClient.CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(token, RoleArn, RoleSessionName, _options).ConfigureAwait(false); // Will retry InvalidIdentityToken and IDPCommunicationError
            }
            _logger.InfoFormat("New credentials created using assume role with web identity that expire at {0}", credentials.Expiration.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture));
            return new CredentialsRefreshState(credentials, credentials.Expiration);
        }
#endif

        /// <summary>
        /// Gets a client to be used for AssumeRoleWithWebIdentity requests.
        /// </summary>
        /// <returns>The STS client.</returns>
#if NET8_0_OR_GREATER
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026",
            Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
#endif
        protected virtual ICoreAmazonSTS_WebIdentity CreateClient()
        {
            var region = FallbackRegionFactory.GetRegionEndpoint() ?? _defaultSTSClientRegion;

            ICoreAmazonSTS_WebIdentity coreSTSClient = GlobalRuntimeDependencyRegistry.Instance.GetInstance<ICoreAmazonSTS_WebIdentity>(ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME,
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

                    coreSTSClient = ServiceClientHelpers.CreateServiceFromAssembly<ICoreAmazonSTS_WebIdentity>(
                                ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME, new AnonymousAWSCredentials(), region);
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
