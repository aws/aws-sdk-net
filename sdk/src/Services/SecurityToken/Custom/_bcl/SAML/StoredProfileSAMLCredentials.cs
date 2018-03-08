/*
 * Copyright 2010-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.SecurityToken.SAML
{
    /// <summary>
    /// Temporary credentials that are created following successful authentication with 
    /// a federated endpoint supporting SAML.
    /// </summary>
    /// <remarks>
    /// Currently only the SDK store supports profiles that contain the necessary data to support 
    /// authentication and role-based credential generation.
    /// </remarks>
    [Obsolete("This class is obsolete and will be removed in a future release. Please use Amazon.Runtime.FederatedAWSCredentials.  Visit http://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/net-dg-config-creds.html for further details.")]
    public class StoredProfileSAMLCredentials : RefreshingAWSCredentials
    {
        private const int MaxAuthenticationRetries = 3;
        private RegionEndpoint DefaultSTSClientRegion = RegionEndpoint.USEast1;

        private static readonly TimeSpan _preemptExpiryTime = TimeSpan.FromMinutes(5);
        private TimeSpan _credentialDuration = MaximumCredentialTimespan;

        /// <summary>
        /// Any custom state passed when a credential callback was registered.
        /// </summary>
        public object CustomCallbackState { get; set; }

        /// <summary>
        /// The minimum allowed timespan for generated credentials, per STS documentation.
        /// </summary>
        public static readonly TimeSpan MinimumCredentialTimespan = TimeSpan.FromMinutes(15);

        /// <summary>
        /// The maximum allowed timespan for generated credentials, per STS documentation.
        /// </summary>
        public static readonly TimeSpan MaximumCredentialTimespan = TimeSpan.FromHours(1);

        /// <summary>
        /// Callback signature for obtaining user credentials for authentication demands when 
        /// the role profile is configured to not use the default identity.
        /// </summary>
        /// <param name="args">
        /// Data about the credential demand including any custom state data that was supplied
        /// when the callback was registered.
        /// </param>
        /// <returns>
        /// The network credential to use in user authentication. Return null to signal the user
        /// declined to provide credentials and authentication should not proceed.
        /// </returns>
        public delegate NetworkCredential RequestUserCredential(CredentialCallbackArgs args);

        /// <summary>
        /// Registered callback for obtaining credentials to use in authentication. 
        /// Required to be set if the role profile is not configured to use the default 
        /// identity.
        /// </summary>
        public RequestUserCredential RequestUserCredentialCallback { get; set; }

        #region Public constructors

        /// <summary>
        /// Constructs an instance of StoredProfileSAMLCredentials. This constructor searches for details
        /// of the role to assume, and optional credentials to use with the endpoint, using the 
        /// profile name specified in the App.config.
        /// </summary>
        public StoredProfileSAMLCredentials()
            : this(AWSConfigs.AWSProfileName, null)
        {
        }

        /// <summary>
        /// <para>
        /// Constructs an instance of StoredProfileSAMLCredentials. After construction call one of the Authenticate
        /// methods to authenticate the user/process and obtain temporary AWS credentials. 
        /// </para>
        /// <para>
        /// For users who are domain joined (the role profile does not contain user identity information) the temporary 
        /// credentials will be refreshed automatically as needed. Non domain-joined users (those with user identity 
        /// data in the profile) are required to re-authenticate when credential refresh is required. An exception is
        /// thrown when attempt is made to refresh credentials in this scenario. The consuming code of this class 
        /// should catch the exception and prompt the user for credentials, then call Authenticate to re-initialize 
        /// with a new set of temporary AWS credentials.
        /// </para>
        /// </summary>
        /// <param name="profileName">
        /// The name of the profile holding the necessary role data to enable authentication and credential generation.
        /// </param>
        /// <param name="profilesLocation">Reserved for future use.</param>
        /// <remarks>The ini-format credentials file is not currently supported.</remarks>
        public StoredProfileSAMLCredentials(string profileName, string profilesLocation)
        {
            this.PreemptExpiryTime = _preemptExpiryTime;
            this.CustomCallbackState = null;

            var lookupName = string.IsNullOrEmpty(profileName)
                ? StoredProfileCredentials.DEFAULT_PROFILE_NAME
                : profileName;

            ProfileName = lookupName;
            ProfilesLocation = null;

            // If not overriding the credentials lookup location check the SDK Store for credentials. If an override 
            // is being used then assume the intent is to use the credentials file.
            if (string.IsNullOrEmpty(profilesLocation))
            {
                SAMLRoleProfile profileData;
                if (ProfileManager.TryGetProfile(lookupName, out profileData))
                {
                    ProfileData = profileData;
                    var logger = Logger.GetLogger(typeof(StoredProfileSAMLCredentials));
                    logger.InfoFormat("SAML role profile found using account name {0} and looking in SDK account store.", lookupName);
                }
            }

            // No credentials found so error out. We do not currently support the ini-format credentials
            // file to obtain SAML role profile data.
            if (ProfileData == null)
            {
                var msg = string.Format(CultureInfo.InvariantCulture, 
                                        "Profile '{0}' was not found or could not be loaded. Verify that the profile name and data are correct.", 
                                        profileName);
                throw new ArgumentException(msg);
            }
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Name of the profile being used.
        /// </summary>
        public string ProfileName { get; private set; }

        /// <summary>
        /// Location of the profiles, if used.
        /// </summary>
        public string ProfilesLocation { get; private set; }

        /// <summary>
        /// The data about the SAML endpoint and any required user credentials parsed from the
        /// profile.
        /// </summary>
        public SAMLRoleProfile ProfileData { get; private set; }

        #endregion

        /// <summary>
        /// If non-default credentials are to be used for authentication,
        /// validates that the authentication required callback has been
        /// populated.
        /// </summary>
        protected override void Validate()
        {
            if (!ProfileData.UseDefaultUserIdentity && RequestUserCredentialCallback == null)
                throw new CredentialCallbackRequiredException("RequestUserCredentialCallback must be set for profiles that do not use the default user identity for authentication.");
        }

        /// <summary>
        /// Refresh credentials after expiry. If the role profile is configured to not
        /// use the default user identity, an exception is thrown if the UserAuthenticationCallback
        /// property has not been set.
        /// </summary>
        /// <returns></returns>
        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            Validate();

            CredentialsRefreshState newState = null;
            var attempts = 0;
            do
            {
                try
                {
                    NetworkCredential userCredential = null;
                    if (!ProfileData.UseDefaultUserIdentity)
                    {
                        var callbackArgs = new CredentialCallbackArgs
                        {
                            UserIdentity = ProfileData.UserIdentity,
                            CustomState = CustomCallbackState,
                            PreviousAuthenticationFailed = attempts > 0
                        };

                        userCredential = RequestUserCredentialCallback(callbackArgs);

                        if (userCredential == null) // user declined to authenticate
                            throw new AuthenticationFailedException("No credentials supplied, credential refresh abandoned");
                    }

                    newState = Authenticate(userCredential, _credentialDuration);
                }
                catch (AuthenticationFailedException)
                {
                    if (attempts < MaxAuthenticationRetries)
                        attempts++;
                    else
                        throw;
                }
            } while (newState == null && attempts < MaxAuthenticationRetries);

            return newState;
        }

        private CredentialsRefreshState Authenticate(ICredentials userCredential, TimeSpan credentialDuration)
        {
            CredentialsRefreshState state;
            SAMLAssertion assertion;

            var configuredRegion = AWSConfigs.AWSRegion;
            var region = string.IsNullOrEmpty(configuredRegion)
                                ? DefaultSTSClientRegion
                                : RegionEndpoint.GetBySystemName(configuredRegion);

            try
            {
                assertion = new SAMLAuthenticationController().GetSAMLAssertion(ProfileData.EndpointSettings.Endpoint.ToString(),
                                                                                userCredential,
                                                                                ProfileData.EndpointSettings.AuthenticationType);
            }
            catch (Exception e)
            {
                throw new AuthenticationFailedException("Authentication failure, unable to obtain SAML assertion.", e);
            }

            try
            {
                using (var stsClient = new AmazonSecurityTokenServiceClient(new AnonymousAWSCredentials(), region))
                {
                    var credentials = assertion.GetRoleCredentials(stsClient, ProfileData.RoleArn, credentialDuration);
                    state = new CredentialsRefreshState(credentials, stsClient.Config.CorrectedUtcNow + credentialDuration);
                }
            }
            catch (Exception e)
            {
                var wrappedException = new AmazonClientException("Credential generation failed following successful authentication.", e);

                var logger = Logger.GetLogger(typeof(StoredProfileSAMLCredentials));
                logger.Error(wrappedException, wrappedException.Message);

                throw wrappedException;
            }

            return state;
        }
    }

    /// <summary>
    /// State class passed on callback to demand user credentials when authentication 
    /// is performed using a non-default identity.
    /// </summary>
    [Obsolete("This class is obsolete and will be removed in a future release. Please update your code to use the Amazon.Runtime.CredentialRequestCallbackArgs class instead.")]
    public class CredentialCallbackArgs
    {
        /// <summary>
        /// Contains the user identity that the user should supply a password
        /// for.
        /// </summary>
        public string UserIdentity { get; set; }

        /// <summary>
        /// Any custom state that was registered with the callback.
        /// </summary>
        public object CustomState { get; set; }

        /// <summary>
        /// Set if the callback was due to a failed authentication attempt.
        /// If false we are beginning to obtain or refresh credentials.
        /// </summary>
        public bool PreviousAuthenticationFailed { get; set; }
    }

    /// <summary>
    /// Exception thrown on validation of a StoredProfileSAMLCredentials instance if the role profile
    /// is configured to use a non-default user identity and the QueryUserCredentialCallback on the
    /// instance has not been set.
    /// </summary>
    [Obsolete("This class is obsolete and will be removed in a future release. Please update your code to use the Amazon.Runtime.CredentialRequestCallbackRequiredException class instead.")]
#if !PCL && !CORECLR
    [Serializable]
#endif
    public class CredentialCallbackRequiredException : Exception
    {
        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="msg"></param>
        public CredentialCallbackRequiredException(string msg)
            : base(msg)
        {
        }

        /// <summary>
        /// Initializes a new exception instance.        
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerException"></param>
        public CredentialCallbackRequiredException(string msg, Exception innerException)
            : base(msg, innerException)
        {
        }

        /// <summary>
        /// Initializes a new exception instance.        
        /// </summary>
        /// <param name="innerException"></param>
        public CredentialCallbackRequiredException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

#if !PCL && !CORECLR
        /// <summary>
        /// Constructs a new instance of the AdfsAuthenticationControllerException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected CredentialCallbackRequiredException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }

    /// <summary>
    /// Custom exception type thrown when authentication for a user against the 
    /// configured endpoint fails and a valid SAML assertion document could not be
    /// obtained.
    /// </summary>
    [Obsolete("This class is obsolete and will be removed in a future release. Please update your code to use the Amazon.Runtime.FederatedAuthenticationFailureException class instead.")]
#if !PCL && !CORECLR
    [Serializable]
#endif
    public class AuthenticationFailedException : Exception
    {
        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="msg"></param>
        public AuthenticationFailedException(string msg)
            : base(msg)
        {
        }

        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="inner"></param>
        public AuthenticationFailedException(string msg, Exception inner)
            : base(msg, inner)
        {
        }

#if !PCL && !CORECLR
        /// <summary>
        /// Constructs a new instance of the AuthenticationFailedException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected AuthenticationFailedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}
