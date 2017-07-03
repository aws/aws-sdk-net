/*
 * Copyright 2016-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace Amazon.Runtime
{
    /// <summary>
    /// Temporary credentials that are created following successful authentication with
    /// a federated endpoint supporting SAML.
    /// </summary>
    /// <remarks>
    /// In order to use the FederatedAWSCredentials class the AWSSDK.SecurityToken assembly
    /// must be available to your application at runtime.
    /// </remarks>
    public class FederatedAWSCredentials : RefreshingAWSCredentials
    {
        private const int MaxAuthenticationRetries = 3;
        private static readonly RegionEndpoint DefaultSTSClientRegion = RegionEndpoint.USEast1;
        private static readonly TimeSpan MaximumCredentialTimespan = TimeSpan.FromHours(1);
        private static readonly TimeSpan DefaultPreemptExpiryTime = TimeSpan.FromMinutes(5);

        private object syncLock = new object();
        private SAMLRoleSessionManager sessionManager = new SAMLRoleSessionManager();

        /// <summary>
        /// Constructs an instance of FederatedAWSCredentials. After construction call GetCredentials
        /// to authenticate the user/process and obtain temporary AWS credentials.
        /// </summary>
        /// <param name="samlEndpoint">The SAML endpoint used for authentication.</param>
        /// <param name="roleArn">The role ARN used for authentication.</param>
        public FederatedAWSCredentials(SAMLEndpoint samlEndpoint, string roleArn)
            :this(samlEndpoint, roleArn, new FederatedAWSCredentialsOptions())
        {
        }

        /// <summary>
        /// Constructs an instance of FederatedAWSCredentials. After construction call GetCredentials
        /// to authenticate the user/process and obtain temporary AWS credentials.
        /// </summary>
        /// <param name="samlEndpoint">The SAML endpoint used for authentication.</param>
        /// <param name="roleArn">The role ARN used for authentication.</param>
        /// <param name="options">The options used for authentication.
        /// See <see cref="FederatedAWSCredentialsOptions"/> for details about available options.</param>
        public FederatedAWSCredentials(SAMLEndpoint samlEndpoint, string roleArn, FederatedAWSCredentialsOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }
            if (samlEndpoint == null)
            {
                throw new ArgumentNullException("samlEndpoint");
            }
            if (string.IsNullOrEmpty(roleArn))
            {
                throw new ArgumentException("RoleArn must not be null or empty.");
            }

            Options = options;
            SAMLEndpoint = samlEndpoint;
            RoleArn = roleArn;
            PreemptExpiryTime = DefaultPreemptExpiryTime;
        }

        /// <summary>
        /// The SAML Endpoint used for authentication.
        /// </summary>
        public SAMLEndpoint SAMLEndpoint { get; private set; }

        /// <summary>
        /// The role ARN used for authentication.
        /// </summary>
        public string RoleArn { get; private set; }

        /// <summary>
        /// The options used for authentication.
        /// See <see cref="FederatedAWSCredentialsOptions"/> for details about available options.
        /// </summary>
        public FederatedAWSCredentialsOptions Options { get; private set; }

        /// <summary>
        /// Refresh credentials after expiry. If the role profile is configured with user identity
        /// information and a callback has been registered to obtain the user credential, the callback
        /// will be invoked ahead of authentication. For role profiles configured with user identity
        /// but no callback registration, the SDK will fall back to attempting to use the default
        /// user identity of the current process.
        /// </summary>
        /// <returns></returns>
        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            Validate();

            // lock across the entire process for generating credentials so multiple
            // threads don't attempt to invoke any registered callback at the same time
            // and if we do callback, we only do it once to get the user authentication
            // data
            lock (syncLock)
            {
                // If the profile indicates the user has already authenticated and received
                // credentials which are still valid, adopt them instead of requiring a fresh
                // authentication
                SAMLImmutableCredentials currentSession;
                if (TryGetRoleSession(out currentSession))
                {
                    return new CredentialsRefreshState(currentSession, currentSession.Expires);
                }

                CredentialsRefreshState newState = null;
                var attempts = 0;
                do
                {
                    try
                    {
                        NetworkCredential userCredential = null;
                        if (Options.UserIdentity != null)
                        {
                            if (Options.CredentialRequestCallback != null)
                            {
                                var callbackArgs = new CredentialRequestCallbackArgs
                                {
                                    ProfileName = Options.ProfileName,
                                    UserIdentity = Options.UserIdentity,
                                    CustomState = Options.CustomCallbackState,
                                    PreviousAuthenticationFailed = attempts > 0
                                };

                                userCredential = Options.CredentialRequestCallback(callbackArgs);

                                if (userCredential == null) // user declined to authenticate
                                {
                                    throw new FederatedAuthenticationCancelledException("User cancelled credential request.");
                                }
                            }
                            else
                            {
                                var logger = Logger.GetLogger(typeof(FederatedAWSCredentials));
                                logger.InfoFormat("FederatedAWSCredentials configured for a specific user but no credential request callback registered; falling back to default identity.");
                            }
                        }

                        newState = Authenticate(userCredential);
                    }
                    catch (FederatedAuthenticationFailureException)
                    {
                        if (attempts < MaxAuthenticationRetries)
                            attempts++;
                        else
                            throw;
                    }
                } while (newState == null && attempts < MaxAuthenticationRetries);

                return newState;
            }
        }

        private CredentialsRefreshState Authenticate(ICredentials userCredential)
        {
            CredentialsRefreshState state;

            var region = Options.STSRegion;
            if (region == null && !string.IsNullOrEmpty(AWSConfigs.AWSRegion))
                region = RegionEndpoint.GetBySystemName(AWSConfigs.AWSRegion);
            else
                region = DefaultSTSClientRegion;

            ICoreAmazonSTS coreSTSClient = null;
            try
            {
                var stsConfig = ServiceClientHelpers.CreateServiceConfig(
                    ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CONFIG_NAME);

                stsConfig.RegionEndpoint = region;
                if (Options.ProxySettings != null)
                {
                    stsConfig.SetWebProxy(Options.ProxySettings);
                }

                coreSTSClient = ServiceClientHelpers.CreateServiceFromAssembly<ICoreAmazonSTS>(
                    ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME,
                    new AnonymousAWSCredentials(), stsConfig);
            }
            catch (Exception e)
            {
                var msg = string.Format(CultureInfo.CurrentCulture,
                    "Assembly {0} could not be found or loaded. This assembly must be available at runtime to use this profile class.",
                    ServiceClientHelpers.STS_ASSEMBLY_NAME);
                throw new InvalidOperationException(msg, e);
            }

            try
            {
                var credentials = coreSTSClient.CredentialsFromSAMLAuthentication(SAMLEndpoint.EndpointUri.ToString(),
                    SAMLEndpoint.AuthenticationType.ToString(), RoleArn, MaximumCredentialTimespan, userCredential);

                RegisterRoleSession(credentials);

                state = new CredentialsRefreshState(credentials, credentials.Expires);
            }
            catch (Exception e)
            {
                var wrappedException = new AmazonClientException("Credential generation from SAML authentication failed.", e);

                var logger = Logger.GetLogger(typeof(FederatedAWSCredentials));
                logger.Error(wrappedException, wrappedException.Message);

                throw wrappedException;
            }

            return state;
        }

        private string GetRoleSessionName()
        {
            if (string.IsNullOrEmpty(Options.ProfileName))
            {
                return SAMLEndpoint.Name + "," + RoleArn + "," + Options.UserIdentity;
            }
            else
            {
                return Options.ProfileName;
            }
        }

        private bool TryGetRoleSession(out SAMLImmutableCredentials sessionCredentials)
        {
            if (SAMLRoleSessionManager.IsAvailable)
            {
                return sessionManager.TryGetRoleSession(GetRoleSessionName(), out sessionCredentials);
            }
            else
            {
                sessionCredentials = null;
                return false;
            }
        }

        private void RegisterRoleSession(SAMLImmutableCredentials sessionCredentials)
        {
            if (SAMLRoleSessionManager.IsAvailable)
            {
                sessionManager.RegisterRoleSession(GetRoleSessionName(), sessionCredentials);
            }
        }
    }
}
