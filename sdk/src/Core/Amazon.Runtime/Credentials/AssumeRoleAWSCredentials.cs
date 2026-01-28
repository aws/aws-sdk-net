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
using Amazon.Util.Internal;
using System;
using System.Globalization;
using System.Net;

namespace Amazon.Runtime
{
    /// <summary>
    /// AWS Credentials that automatically refresh by calling AssumeRole on
    /// the Amazon Security Token Service.
    /// </summary>
    public class AssumeRoleAWSCredentials : RefreshingAWSCredentials
    {
        private RegionEndpoint DefaultSTSClientRegion = RegionEndpoint.USEast1;

        private Logger _logger = Logger.GetLogger(typeof(AssumeRoleAWSCredentials));

        /// <summary>
        /// The credentials of the user that will be used to call AssumeRole.
        /// </summary>
        public AWSCredentials SourceCredentials { get; private set; }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the role to assume.
        /// </summary>
        public string RoleArn { get; private set; }

        /// <summary>
        /// An identifier for the assumed role session.
        /// </summary>
        public string RoleSessionName { get; private set; }

        /// <summary>
        /// Options to be used in the call to AssumeRole.
        /// </summary>
        public AssumeRoleAWSCredentialsOptions Options { get; private set; }

        /// <summary>
        /// Constructs an AssumeRoleAWSCredentials object.
        /// </summary>
        /// <param name="sourceCredentials">The credentials of the user that will be used to call AssumeRole.</param>
        /// <param name="roleArn">The Amazon Resource Name (ARN) of the role to assume.</param>
        /// <param name="roleSessionName">An identifier for the assumed role session.</param>
        public AssumeRoleAWSCredentials(AWSCredentials sourceCredentials, string roleArn, string roleSessionName)
            : this(sourceCredentials, roleArn, roleSessionName, new AssumeRoleAWSCredentialsOptions())
        {
        }

        /// <summary>
        /// Constructs an AssumeRoleAWSCredentials object.
        /// </summary>
        /// <param name="sourceCredentials">The credentials of the user that will be used to call AssumeRole.</param>
        /// <param name="roleArn">The Amazon Resource Name (ARN) of the role to assume.</param>
        /// <param name="roleSessionName">An identifier for the assumed role session.</param>
        /// <param name="options">Options to be used in the call to AssumeRole.</param>
        public AssumeRoleAWSCredentials(AWSCredentials sourceCredentials, string roleArn, string roleSessionName, AssumeRoleAWSCredentialsOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            SourceCredentials = sourceCredentials;
            RoleArn = roleArn;
            RoleSessionName = roleSessionName;
            Options = options;

            // The minimum duration for AssumeRole is 15 minutes (900 seconds), and if that value
            // is requested a 15-minute preempt expiry time may cause the SDK to generate credentials
            // more frequently than needed (https://github.com/aws/aws-sdk-net/issues/4313).
            //
            // If customers request a duration shorter than 20 minutes (1200 seconds), use a smaller
            // preempt expiry time of 5 minutes.
            if (Options != null && Options.DurationSeconds.HasValue && Options.DurationSeconds.Value <= 1200)
            {
                PreemptExpiryTime = TimeSpan.FromMinutes(5);
            }
            else
            {
                // Otherwise, use the default of 15 minutes to make sure to fetch new credentials well before
                // the current credentials expire to avoid any request being made with expired credentials.
                PreemptExpiryTime = TimeSpan.FromMinutes(15);
            }
        }

#if NET8_0_OR_GREATER
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", 
            Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
#endif
        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            var region = FallbackRegionFactory.GetRegionEndpoint() ?? DefaultSTSClientRegion;
            ICoreAmazonSTS coreSTSClient = GlobalRuntimeDependencyRegistry.Instance.GetInstance<ICoreAmazonSTS>(ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME, 
                new CreateInstanceContext(new SecurityTokenServiceClientContext {Action = SecurityTokenServiceClientContext.ActionContext.AssumeRoleAWSCredentials, Region = region, ProxySettings = Options?.ProxySettings } ));

            if (coreSTSClient == null)
            {
                try
                {
                    var stsConfig = ServiceClientHelpers.CreateServiceConfig(ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CONFIG_NAME);
                    stsConfig.RegionEndpoint = region;

                    if (Options?.ProxySettings != null)
                    {
                        stsConfig.SetWebProxy(Options.ProxySettings);
                    }

                    coreSTSClient = ServiceClientHelpers.CreateServiceFromAssembly<ICoreAmazonSTS>(
                        ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME, SourceCredentials, stsConfig);
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
                    var exception = new InvalidOperationException(msg, e);
                    Logger.GetLogger(typeof(AssumeRoleAWSCredentials)).Error(exception, exception.Message);
                    throw exception;
                }
            }



            var credentials = coreSTSClient.CredentialsFromAssumeRoleAuthentication(RoleArn, RoleSessionName, Options);
            _logger.InfoFormat("New credentials created for assume role that expire at {0}", credentials.Expiration.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture));
            return new CredentialsRefreshState(credentials, credentials.Expiration);
        }
    }
}
