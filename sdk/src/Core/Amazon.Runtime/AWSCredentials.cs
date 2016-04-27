/*
 * Copyright 2011-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;

#if BCL
using System.Configuration;
#endif

using ThirdParty.Json.LitJson;
using Amazon.Runtime.Internal.Util;
using System.Globalization;
using Amazon.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.SharedInterfaces;
using System.Text;

namespace Amazon.Runtime
{
    /// <summary>
    /// Immutable representation of AWS credentials.
    /// </summary>
    public class ImmutableCredentials
    {
        #region Properties

        /// <summary>
        /// Gets the AccessKey property for the current credentials.
        /// </summary>
        public string AccessKey { get; private set; }

        /// <summary>
        /// Gets the SecretKey property for the current credentials.
        /// </summary>
        public string SecretKey { get; private set; }

        /// <summary>
        /// Gets the Token property for the current credentials.
        /// </summary>
        public string Token { get; private set; }


        /// <summary>
        /// Gets the UseToken property for the current credentials.
        /// Specifies if Token property is non-emtpy.
        /// </summary>
        public bool UseToken { get { return !string.IsNullOrEmpty(Token); } }

        #endregion


        #region Constructors

        /// <summary>
        /// Constructs an ImmutableCredentials object with supplied accessKey, secretKey.
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="token">Optional. Can be set to null or empty for non-session credentials.</param>
        public ImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)
        {
            if (string.IsNullOrEmpty(awsAccessKeyId)) throw new ArgumentNullException("awsAccessKeyId");
            if (string.IsNullOrEmpty(awsSecretAccessKey)) throw new ArgumentNullException("awsSecretAccessKey");

            AccessKey = awsAccessKeyId;
            SecretKey = awsSecretAccessKey;

            Token = token ?? string.Empty;
        }

        private ImmutableCredentials() { }

        #endregion


        #region Public methods

        /// <summary>
        /// Returns a copy of the current credentials.
        /// </summary>
        /// <returns></returns>
        public ImmutableCredentials Copy()
        {
            ImmutableCredentials credentials = new ImmutableCredentials
            {
                AccessKey = this.AccessKey,
                SecretKey = this.SecretKey,
                Token = this.Token,
            };
            return credentials;
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return Hashing.Hash(AccessKey, SecretKey, Token);
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            ImmutableCredentials ic = obj as ImmutableCredentials;
            if (ic == null)
                return false;

            return AWSSDKUtils.AreEqual(
                new object[] { AccessKey, SecretKey, Token },
                new object[] { ic.AccessKey, ic.SecretKey, ic.Token });
        }

        #endregion
    }

    /// <summary>
    /// Immutable representation of AWS credentials obtained as a result of
    /// authenticating against a SAML-supporting federated identity provider.
    /// </summary>
    public class SAMLImmutableCredentials : ImmutableCredentials
    {
        #region Properties

        /// <summary>
        /// The expiry time of the credentials, obtained from the AssumeRoleWithSAML response.
        /// </summary>
        public DateTime Expires { get; private set; }

        /// <summary>
        /// The value of the NameID element in the Subject element of the SAML assertion, as returned in the
        /// AssumeRoleWithSAML response from the Security Token Service.
        /// </summary>
        public string Subject { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs an instance with supplied keys and SAML assertion data.
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="token"></param>
        /// <param name="expires"></param>
        /// <param name="subject"></param>
        public SAMLImmutableCredentials(string awsAccessKeyId,
                                        string awsSecretAccessKey,
                                        string token,
                                        DateTime expires,
                                        string subject)
            : base(awsAccessKeyId, awsSecretAccessKey, token)
        {
            Expires = expires;
            Subject = subject;
        }

        /// <summary>
        /// Constructs an instance with supplied keys and SAML assertion data.
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="subject"></param>
        /// <param name="expires"></param>
        public SAMLImmutableCredentials(ImmutableCredentials credentials,
                                        DateTime expires,
                                        string subject)
            : base(credentials.AccessKey, credentials.SecretKey, credentials.Token)
        {
            Expires = expires;
            Subject = subject;
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return Hashing.Hash(AccessKey, SecretKey, Token, Subject);
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            var ic = obj as SAMLImmutableCredentials;
            if (ic == null)
                return false;

            if (base.Equals(obj))
                return string.Equals(Subject, ic.Subject, StringComparison.Ordinal);

            return false;
        }

        #endregion

        #region Serialization

        const string AccessKeyProperty = "AccessKey";
        const string SecretKeyProperty = "SecretKey";
        const string TokenProperty = "Token";
        const string ExpiresProperty = "Expires";
        const string SubjectProperty = "Subject";

        /// <summary>
        /// Serializes the instance to a json-format string for external storage
        /// </summary>
        /// <returns>The serialized object in json</returns>
        internal string ToJson()
        {
            // don't need all data, and we want to be explicit on the datetime format
            var props = new Dictionary<string, string>();
            props.Add(AccessKeyProperty, AccessKey);
            props.Add(SecretKeyProperty, SecretKey);
            props.Add(TokenProperty, Token);

            props.Add(ExpiresProperty, Expires.ToString("u", CultureInfo.InvariantCulture));

            props.Add(SubjectProperty, Subject);

            return JsonMapper.ToJson(props);
        }

        /// <summary>
        /// Instantiates an instance from persisted json data
        /// </summary>
        /// <param name="json">The serialized data</param>
        /// <returns>Deserialized instance corresponding to the json data</returns>
        internal static SAMLImmutableCredentials FromJson(string json)
        {
            try
            {
                var o = JsonMapper.ToObject(json);

                // get the expiry first - if the credentials have expired we can then
                // ignore the data
                var expires = DateTime.Parse((string)o[ExpiresProperty], CultureInfo.InvariantCulture).ToUniversalTime();
                if (expires <= DateTime.UtcNow)
                {
                    Logger.GetLogger(typeof(SAMLImmutableCredentials)).InfoFormat("Skipping serialized credentials due to expiry.");
                    return null;
                }

                var accessKey = (string)o[AccessKeyProperty];
                var secretKey = (string)o[SecretKeyProperty];
                var token = (string)o[TokenProperty];
                var subject = (string)o[SubjectProperty];

                return new SAMLImmutableCredentials(accessKey, secretKey, token, expires, subject);
            }
            catch (Exception e)
            {
                Logger.GetLogger(typeof(SAMLImmutableCredentials)).Error(e, "Error during deserialization");
            }

            return null;
        }

        #endregion
    }

    /// <summary>
    /// Abstract class that represents a credentials object for AWS services.
    /// </summary>
    public abstract class AWSCredentials
    {
        /// <summary>
        /// Returns a copy of ImmutableCredentials
        /// </summary>
        /// <returns></returns>
        public abstract ImmutableCredentials GetCredentials();

        /// <summary>
        /// Called by AmazonServiceClient to validate the credential state
        /// on client construction.
        /// </summary>
        protected virtual void Validate() { }

#if AWS_ASYNC_API
        public virtual System.Threading.Tasks.Task<ImmutableCredentials> GetCredentialsAsync()
        {
            return System.Threading.Tasks.Task.Run<ImmutableCredentials>(() => this.GetCredentials());
        }
#endif
    }

    /// <summary>
    /// Basic set of credentials consisting of an AccessKey and SecretKey
    /// </summary>
    public class BasicAWSCredentials : AWSCredentials
    {
        #region Private members

        private ImmutableCredentials _credentials;

        #endregion


        #region Constructors


        /// <summary>
        /// Constructs a BasicAWSCredentials object for the specified accessKey and secretKey.
        /// </summary>
        /// <param name="accessKey"></param>
        /// <param name="secretKey"></param>
        public BasicAWSCredentials(string accessKey, string secretKey)
        {
            if (!string.IsNullOrEmpty(accessKey))
            {
                _credentials = new ImmutableCredentials(accessKey, secretKey, null);
            }
        }

        #endregion


        #region Abstract class overrides

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            if (this._credentials == null)
                return null;

            return _credentials.Copy();
        }

        #endregion

    }

    /// <summary>
    /// Session credentials consisting of AccessKey, SecretKey and Token
    /// </summary>
    public class SessionAWSCredentials : AWSCredentials
    {
        #region Public constructors

        /// <summary>
        /// Constructs a SessionAWSCredentials object for the specified accessKey, secretKey.
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="token"></param>
        public SessionAWSCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)
        {
            if (string.IsNullOrEmpty(awsAccessKeyId)) throw new ArgumentNullException("awsAccessKeyId");
            if (string.IsNullOrEmpty(awsSecretAccessKey)) throw new ArgumentNullException("awsSecretAccessKey");
            if (string.IsNullOrEmpty(token)) throw new ArgumentNullException("token");

            _lastCredentials = new ImmutableCredentials(awsAccessKeyId, awsSecretAccessKey, token);
        }

        #endregion


        #region Credentials data

        private ImmutableCredentials _lastCredentials;

        #endregion


        #region Abstract class overrides

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            return _lastCredentials.Copy();
        }

        #endregion

    }

#if BCL
    /// <summary>
    /// Helper routiners for AWS and Federated credential profiles. Probes the
    /// profile type for the supplied profile name and returns the appropriate profile 
    /// instance.
    /// </summary>
    public abstract class StoredProfileCredentials
    {
        public const string DEFAULT_PROFILE_NAME = "default";
        public const string SHARED_CREDENTIALS_FILE_ENVVAR = "AWS_SHARED_CREDENTIALS_FILE";
        public const string HOME_ENVVAR = "HOME";

        public const string DefaultSharedCredentialFilename = "credentials";
        public const string DefaultSharedCredentialLocation = ".aws/" + DefaultSharedCredentialFilename;

        /// <summary>
        /// Determines the type of the requested profile and returns the
        /// appropriate profile instance.
        /// </summary>
        /// <param name="profileName">The name of the profile (AWS or federated) to be loaded.</param>
        /// <returns>Instantiated profile type.</returns>
        public static AWSCredentials GetProfile(string profileName)
        {
            return GetProfile(profileName, AWSConfigs.AWSProfilesLocation);
        }

        /// <summary>
        /// Determines the type of the requested profile and returns the
        /// appropriate profile instance.
        /// </summary>
        /// <param name="profileName">The name of the profile (AWS or federated) to be loaded.</param>
        /// <param name="profileLocation">
        /// The location of the shared credentials (.ini) file, for profiles that are not stored in the
        /// SDK credential store.
        /// </param>
        /// <returns>Instantiated profile type.</returns>
        public static AWSCredentials GetProfile(string profileName, string profileLocation)
        {
            if (StoredProfileAWSCredentials.CanCreateFrom(profileName, profileLocation))
                return new StoredProfileAWSCredentials(profileName, profileLocation);

            if (StoredProfileFederatedCredentials.CanCreateFrom(profileName, profileLocation))
                return new StoredProfileFederatedCredentials(profileName, profileLocation);

            var sb = new StringBuilder();
            sb.AppendFormat(CultureInfo.InvariantCulture, "Profile {0} was not found in the SDK credential store", profileName);
            if (!string.IsNullOrEmpty(profileLocation))
                sb.AppendFormat(CultureInfo.InvariantCulture, " or at location '{0}'.", profileLocation);

            throw new ArgumentException(sb.ToString());
        }

        /// <summary>
        /// Probes for and returns the fully qualified name of the shared ini-format credentials
        /// file. 
        /// </summary>
        /// <param name="profileLocation">
        /// Contains the file or folder name of the credential file. If not specified, the 
        /// routine will first check the application configuration file for a setting indicating
        /// the file location or filename. If the configuration file does not yield a credential
        /// file location then an environment variable is examined. Finally the routine will 
        /// inspect the fallback default location beneath the user's home folder location.
        /// </param>
        /// <returns>
        /// The fully qualified name to the credential file that was located, or null
        /// if no credential file could be found.
        /// </returns>
        public static string ResolveSharedCredentialFileLocation(string profileLocation)
        {
            var logger = Logger.GetLogger(typeof(StoredProfileCredentials));

            string credentialFile = TestSharedCredentialFileExists(profileLocation);
            if (!string.IsNullOrEmpty(credentialFile))
            {
                logger.InfoFormat("Credentials file found at supplied location: {0}", credentialFile);
                return credentialFile;
            }

            credentialFile = TestSharedCredentialFileExists(AWSConfigs.AWSProfilesLocation);
            if (!string.IsNullOrEmpty(credentialFile))
            {
                logger.InfoFormat("Credentials file found using application configuration setting: {0}", credentialFile);
                return credentialFile;
            }

            credentialFile = TestSharedCredentialFileExists(Environment.GetEnvironmentVariable(SHARED_CREDENTIALS_FILE_ENVVAR));
            if (!string.IsNullOrEmpty(credentialFile))
            {
                logger.InfoFormat("Credentials file found using environment variable '{0}': {1}", SHARED_CREDENTIALS_FILE_ENVVAR, credentialFile);
                return credentialFile;
            }

            var homePath = Environment.GetEnvironmentVariable(HOME_ENVVAR);
            if (!string.IsNullOrEmpty(homePath))
            {
                credentialFile = TestSharedCredentialFileExists(Path.Combine(homePath, DefaultSharedCredentialLocation));
                if (!string.IsNullOrEmpty(credentialFile))
                {
                    logger.InfoFormat("Credentials file found using environment variable '{0}': {1}", HOME_ENVVAR, credentialFile);
                    return credentialFile;
                }
            }

#if !BCL35
            var profileFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (!string.IsNullOrEmpty(profileFolder))
            {
                credentialFile = TestSharedCredentialFileExists(Path.Combine(profileFolder, DefaultSharedCredentialLocation));
                if (!string.IsNullOrEmpty(credentialFile))
                {
                    logger.InfoFormat("Credentials file found in user profile location: {0}", credentialFile);
                    return credentialFile;
                }
            }
#else

            var profileFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (!string.IsNullOrEmpty(profileFolder))
            {
                var parent = Directory.GetParent(profileFolder);
                if (parent != null)
                {
                    credentialFile = TestSharedCredentialFileExists(Path.Combine(parent.FullName, DefaultSharedCredentialLocation));
                    if (!string.IsNullOrEmpty(credentialFile))
                    {
                        logger.InfoFormat("Credentials file found in user profile location: {0}", credentialFile);
                        return credentialFile;
                    }
                }
            }
#endif

            logger.InfoFormat("No credentials file found using location probing.");
            return null;
        }

        private static string TestSharedCredentialFileExists(string pathOrFilename)
        {
            if (!string.IsNullOrEmpty(pathOrFilename))
            {
                string testLocation = Directory.Exists(pathOrFilename)
                        ? Path.Combine(pathOrFilename, DefaultSharedCredentialFilename)
                        : pathOrFilename;

                if (File.Exists(testLocation))
                    return testLocation;
            }

            return null;
        }
    }

    /// <summary>
    /// <para>
    /// Credentials that are retrieved using a stored profile. 
    /// </para>
    /// <para>
    /// Unless otherwise specified priority is given to loading credentials from the SDK credential store 
    /// file which is shared between the SDK, PowerShell CLI and Toolkit. Credentials in profiles in this 
    /// file are encrypted and can only be used by the user account on the current machine that stored the 
    /// profile. Credentials can also be loaded from the plain-text ini-format credential file which is 
    /// shared with other AWS SDKs. This file is expected to exist in a '.aws' folder in the user's home 
    /// directory but alternate locations can be specified using either the AWSProfilesLocation setting in 
    /// the application configuration file, or by using the AWS_SHARED_CREDENTIALS_FILE environment variable.
    /// </para>
    /// <para>
    /// The profile name can be specified in the App.config using the AWSProfileName setting.
    /// </para>
    /// </summary>
    public class StoredProfileAWSCredentials : AWSCredentials
    {
        #region Private members

        private ImmutableCredentials _wrappedCredentials;

        #endregion

        #region Public constructors

        /// <summary>
        /// Constructs an instance for credentials stored in a profile. This constructor searches for credentials 
        /// using the account name specified using the AWSProfileName setting, if set, in the application configuration 
        /// file. If the configuration file setting is not set the SDK will attempt to locate a profile with the name 
        /// 'default'.
        /// </summary>
        public StoredProfileAWSCredentials()
            : this(AWSConfigs.AWSProfileName)
        {

        }

        /// <summary>
        /// Constructs an instance for credentials stored in a profile with the specified name. The SDK will
        /// check the SDK credential store file first before looking for the shared ini-format credentials
        /// file unless the application configuration file contains a setting for the 'AWSProfilesLocation' 
        /// indicating the search should be constrained to the shared credentials file at the specified
        /// location.
        /// </summary>
        /// <param name="profileName">The name of the profile in which the credentials were stored.</param>
        public StoredProfileAWSCredentials(string profileName)
            : this(profileName, AWSConfigs.AWSProfilesLocation)
        {

        }

        /// <summary>
        /// Constructs an instance for credentials stored in a profile with the specified name.
        /// </summary>
        /// <param name="profileName">The profile name to search for credentials for</param>
        /// <param name="profilesLocation">
        /// Optional; instructs the SDK to check for the profile in the shared credentials file at the 
        /// specified location. If not set, the SDK will inspect its own credential store file first before
        /// attempting to locate a shared credential file using either the default location beneath the user's
        /// home profile folder or the location specified in the AWS_SHARED_CREDENTIALS_FILE environment 
        /// variable.
        /// </param>
        /// <remarks>
        /// If credential materials cannot be read or are invalid due to missing data an InvalidDataException 
        /// is thrown. If no credentials can be located with the specified profile name, an ArgumentException 
        /// is thrown.
        /// </remarks>
        public StoredProfileAWSCredentials(string profileName, string profilesLocation)
        {
            NameValueCollection appConfig = ConfigurationManager.AppSettings;

            var lookupName = string.IsNullOrEmpty(profileName) 
                    ? StoredProfileCredentials.DEFAULT_PROFILE_NAME 
                    : profileName;

            ProfileName = lookupName;
            ProfilesLocation = null;

            // If not overriding the credentials lookup location check the SDK Store for credentials. If
            // an override location is specified, assume we should only use the shared credential file.
            if (string.IsNullOrEmpty(profilesLocation))
            {
                if (ProfileManager.IsProfileKnown(lookupName) && AWSCredentialsProfile.CanCreateFrom(lookupName))
                {
                    var credentials = ProfileManager.GetAWSCredentials(lookupName);
                    this._wrappedCredentials = credentials.GetCredentials();
                    var logger = Logger.GetLogger(typeof(StoredProfileAWSCredentials));
                    logger.InfoFormat("Credentials found using account name {0} and looking in SDK account store.", lookupName);
                }
            }

            // If credentials weren't found in the SDK store then search the shared credentials file.
            if (this._wrappedCredentials == null)
            {
                var credentialsFilePath = StoredProfileCredentials.ResolveSharedCredentialFileLocation(profilesLocation);
                if (!string.IsNullOrEmpty(credentialsFilePath))
                {
                    var parser = new CredentialsFileParser(credentialsFilePath);
                    var section = parser.FindSection(lookupName);
                    if (section != null)
                    {
                        section.Validate();
                        this._wrappedCredentials = section.Credentials;
                        var logger = Logger.GetLogger(typeof(StoredProfileAWSCredentials));
                        logger.InfoFormat("Credentials found using account name {0} and looking in {1}.", lookupName, credentialsFilePath);
                    }

                    ProfilesLocation = credentialsFilePath;
                }
            }

            // No credentials found so error out.
            if (this._wrappedCredentials == null)
            {
                throw new ArgumentException("App.config does not contain credentials information. Either add the AWSAccessKey and AWSSecretKey properties or the AWSProfileName property.");
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

        #endregion

        /// <summary>
        /// Tests if a profile has been registered in either the SDK store or the specified credential 
        /// file.
        /// </summary>
        /// <param name="profileName">The name of the profile to test</param>
        /// <param name="profilesLocation">
        /// Optional; instructs the SDK to check for the profile in the shared credentials file at the 
        /// specified location. If not set, the SDK will inspect its own credential store file first before
        /// attempting to locate a shared credential file using either the default location beneath the user's
        /// home profile folder or the location specified in the AWS_SHARED_CREDENTIALS_FILE environment 
        /// variable.
        /// </param>
        /// <returns>True if a profile with the specified name has been registered.</returns>
        public static bool IsProfileKnown(string profileName, string profilesLocation)
        {
            if (string.IsNullOrEmpty(profilesLocation) && ProfileManager.IsProfileKnown(profileName))
                return true;

            string sharedCredentialsFile = StoredProfileCredentials.ResolveSharedCredentialFileLocation(profilesLocation);
            if (!string.IsNullOrEmpty(sharedCredentialsFile))
            {
                var parser = new CredentialsFileParser(sharedCredentialsFile);
                var section = parser.FindSection(profileName);
                return section != null;
            }

            return false;
        }

        /// <summary>
        /// Tests if an instance can be created from the persisted profile data.
        /// If profilesLocation is null/empty, the SDK store is searched for the
        /// profile data before probing for the profile in the shared the ini-format
        /// credential file.
        /// </summary>
        /// <param name="profileName">The name of the profile to test</param>
        /// <param name="profilesLocation">
        /// If null/empty, the SDK store is searched for the named profile otherwise
        /// the ini-format credential file at the specified location is inspected.
        /// </param>
        /// <returns>True if the persisted data would yield a valid credentials instance.</returns>
        public static bool CanCreateFrom(string profileName, string profilesLocation)
        {
            if (string.IsNullOrEmpty(profilesLocation) && ProfileManager.IsProfileKnown(profileName))
                return AWSCredentialsProfile.CanCreateFrom(profileName);

            var credentialsFilePath = StoredProfileCredentials.ResolveSharedCredentialFileLocation(profilesLocation);
            if (!string.IsNullOrEmpty(credentialsFilePath))
            {
                var parser = new CredentialsFileParser(credentialsFilePath);
                var section = parser.FindSection(profileName);
                if (section != null)
                {
                    try
                    {
                        section.Validate();
                        return true;
                    }
                    catch (InvalidDataException)
                    {
                    }
                }
                else
                {
                    var logger = Logger.GetLogger(typeof(StoredProfileAWSCredentials));
                    logger.InfoFormat("Credentials file {0} does not contain profile {1}.", credentialsFilePath, profileName);
                }
            }
            else
            {
                var logger = Logger.GetLogger(typeof(StoredProfileAWSCredentials));
                logger.InfoFormat("Credentials file not found {0}.", credentialsFilePath);
            }

            return false;
        }

        private class CredentialsFileParser
        {
            private const string profileNamePrefix = "[";
            private const string profileNameSuffix = "]";
            private const string dataPrefix = "aws_";
            private const string keyValueSeparator = "=";
            private const string accessKeyName = "aws_access_key_id";
            private const string secretKeyName = "aws_secret_access_key";
            private const string tokenName = "aws_session_token";
            private List<CredentialsSection> Sections { get; set; }

            public CredentialsFileParser(string filePath)
            {
                var lines = File.ReadAllLines(filePath);
                Parse(lines);
            }

            private void Parse(string[] lines)
            {
                Sections = new List<CredentialsSection>();
                CredentialsSection currentSection = null;
                foreach (var l in lines)
                {
                    var line = l ?? string.Empty;
                    line = line.Trim();
                    if (string.IsNullOrEmpty(line))
                        continue;

                    if (line.StartsWith(profileNamePrefix, StringComparison.OrdinalIgnoreCase) &&
                        line.EndsWith(profileNameSuffix, StringComparison.OrdinalIgnoreCase))
                    {
                        if (currentSection != null)
                            Sections.Add(currentSection);

                        var profileName = GetProfileName(line);
                        currentSection = new CredentialsSection(profileName);
                    }
                    else if (line.StartsWith(dataPrefix, StringComparison.OrdinalIgnoreCase) && currentSection != null)
                    {
                        // split data into key-value pairs, store appropriately
                        var split = SplitData(line);
                        if (split.Count > 0)
                        {
                            var name = split[0];
                            var value = split.Count > 1 ? split[1] : null;

                            SetSectionValue(currentSection, name, value);
                        }
                    }
                }

                if (currentSection != null)
                    Sections.Add(currentSection);
            }
            private static List<string> SplitData(string line)
            {
                var split = line
                    .Split(new string[] { keyValueSeparator }, 2, StringSplitOptions.None)
                    .Select(s => s.Trim())
                    .Where(s => !string.IsNullOrEmpty(s))
                    .ToList();
                return split;
            }
            private static string GetProfileName(string line)
            {
                // get profile name by trimming off the [ and ] characters
                var profileName = line;
                profileName = profileName.Substring(profileNamePrefix.Length);
                profileName = profileName.Substring(0, profileName.Length - profileNameSuffix.Length);
                return profileName;
            }
            private static void SetSectionValue(CredentialsSection section, string name, string value)
            {
                if (string.Equals(accessKeyName, name, StringComparison.OrdinalIgnoreCase))
                    section.AccessKey = value;
                else if (string.Equals(secretKeyName, name, StringComparison.OrdinalIgnoreCase))
                    section.SecretKey = value;
                else if (string.Equals(tokenName, name, StringComparison.OrdinalIgnoreCase))
                    section.Token = value;
            }

            public CredentialsSection FindSection(string profileName)
            {
                foreach (var section in Sections)
                    if (string.Equals(section.ProfileName, profileName, StringComparison.Ordinal))
                        return section;
                return null;
            }

            public class CredentialsSection
            {
                public CredentialsSection(string profileName)
                {
                    ProfileName = profileName;
                }

                public string ProfileName { get; set; }
                public string AccessKey { get; set; }
                public string SecretKey { get; set; }
                public string Token { get; set; }

                public void Validate()
                {
                    if (!HasValidCredentials)
                        throw new InvalidDataException("Credential profile does not contain valid access and/or secret key materials.");
                }

                public bool HasValidCredentials
                {
                    get
                    {
                        return
                            !string.IsNullOrEmpty(AccessKey) &&
                            !string.IsNullOrEmpty(SecretKey);
                    }
                }
                public ImmutableCredentials Credentials
                {
                    get
                    {
                        return new ImmutableCredentials(AccessKey, SecretKey, Token);
                    }
                }
            }
        }

        #region Abstract class overrides

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            return this._wrappedCredentials.Copy();
        }

        #endregion
    }

    /// <summary>
    /// Uses aws credentials stored in environment variables to construct the credentials object.
    /// AWS_ACCESS_KEY_ID and AWS_SECRET_ACCESS_KEY are used for the access key id and secret key. 
    /// If the variable AWS_SESSION_TOKEN exists then it will be used to create temporary session 
    /// credentials.
    /// </summary>
    /// <remarks>
    /// For backwards compatibility the class will also attempt to discover the secret key from
    /// the AWS_SECRET_KEY variable, if a value cannot be obtained using the standard 
    /// AWS_SECRET_ACCESS_KEY variable.
    /// </remarks>
    public class EnvironmentVariablesAWSCredentials : AWSCredentials
    {
        // these variable names are standard across all AWS SDKs that support reading keys from
        // environment variables
        public const string ENVIRONMENT_VARIABLE_ACCESSKEY = "AWS_ACCESS_KEY_ID";
        public const string ENVIRONMENT_VARIABLE_SECRETKEY = "AWS_SECRET_ACCESS_KEY";
        public const string ENVIRONMENT_VARIABLE_SESSION_TOKEN = "AWS_SESSION_TOKEN";

        // this legacy key was used by previous versions of the AWS SDK for .NET and is
        // used if no value exists for the standard key for backwards compatibility.
        public const string LEGACY_ENVIRONMENT_VARIABLE_SECRETKEY = "AWS_SECRET_KEY";

        private ImmutableCredentials _wrappedCredentials;

    #region Public constructors

        /// <summary>
        /// Constructs an instance of EnvironmentVariablesAWSCredentials. If no credentials are found in 
        /// the environment variables then an InvalidOperationException is thrown.
        /// </summary>
        public EnvironmentVariablesAWSCredentials()
        {
            var logger = Logger.GetLogger(typeof(EnvironmentVariablesAWSCredentials));

            string accessKeyId = Environment.GetEnvironmentVariable(ENVIRONMENT_VARIABLE_ACCESSKEY);
            string secretKey = Environment.GetEnvironmentVariable(ENVIRONMENT_VARIABLE_SECRETKEY);
            if (string.IsNullOrEmpty(secretKey))
            {
                secretKey = Environment.GetEnvironmentVariable(LEGACY_ENVIRONMENT_VARIABLE_SECRETKEY);
                if (!string.IsNullOrEmpty(secretKey))
                    logger.InfoFormat("AWS secret key found using legacy and non-standard environment variable '{0}', consider updating to the cross-SDK standard variable '{1}'.",
                                      LEGACY_ENVIRONMENT_VARIABLE_SECRETKEY, ENVIRONMENT_VARIABLE_SECRETKEY);
            }

            if (string.IsNullOrEmpty(accessKeyId) || string.IsNullOrEmpty(secretKey))
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "The environment variables {0}/{1}/{2} were not set with AWS credentials.", 
                    ENVIRONMENT_VARIABLE_ACCESSKEY, ENVIRONMENT_VARIABLE_SECRETKEY, ENVIRONMENT_VARIABLE_SESSION_TOKEN));
            }

            string sessionToken = Environment.GetEnvironmentVariable(ENVIRONMENT_VARIABLE_SESSION_TOKEN);

            this._wrappedCredentials = new ImmutableCredentials(accessKeyId, secretKey, sessionToken);
            logger.InfoFormat("Credentials found using environment variables.");
        }

    #endregion

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            return this._wrappedCredentials.Copy();
        }
    }

    /// <summary>
    /// Credentials that are retrieved from ConfigurationManager.AppSettings
    /// </summary>
    [Obsolete("This class is obsolete and will be removed in a future release. Please update your code to use ApplicationConfigAWSCredentials instead.")]
    public class EnvironmentAWSCredentials : AWSCredentials
    {
        private const string ACCESSKEY = "AWSAccessKey";
        private const string SECRETKEY = "AWSSecretKey";

        private ImmutableCredentials _wrappedCredentials;

    #region Public constructors

        /// <summary>
        /// Constructs an instance of EnvironmentAWSCredentials and attempts
        /// to load AccessKey and SecretKey from ConfigurationManager.AppSettings
        /// </summary>
        public EnvironmentAWSCredentials()
        {
            NameValueCollection appConfig = ConfigurationManager.AppSettings;

            // Use hardcoded credentials
            if (!string.IsNullOrEmpty(appConfig[ACCESSKEY]) && !string.IsNullOrEmpty(appConfig[SECRETKEY]))
            {
                var accessKey = appConfig[ACCESSKEY];
                var secretKey = appConfig[SECRETKEY];
                this._wrappedCredentials = new ImmutableCredentials(accessKey, secretKey, null);
                var logger = Logger.GetLogger(typeof(EnvironmentAWSCredentials));
                logger.InfoFormat("Credentials found with {0} and {1} app settings", ACCESSKEY, SECRETKEY);
            }
            // Fallback to the StoredProfileAWSCredentials provider
            else
            {
                this._wrappedCredentials = new StoredProfileAWSCredentials().GetCredentials();
            }
        }

    #endregion

    #region Abstract class overrides

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            return this._wrappedCredentials.Copy();
        }

    #endregion
    }

    /// <summary>
    /// Obtains credentials from access key/secret key or AWSProfileName settings
    /// in the application's app.config or web.config file.
    /// </summary>
    public class AppConfigAWSCredentials : AWSCredentials
    {
        private const string ACCESSKEY = "AWSAccessKey";
        private const string SECRETKEY = "AWSSecretKey";

        private ImmutableCredentials _wrappedCredentials;

        #region Public constructors 

        public AppConfigAWSCredentials()
        {
            NameValueCollection appConfig = ConfigurationManager.AppSettings;
            var logger = Logger.GetLogger(typeof(AppConfigAWSCredentials));

            // Attempt hardcoded key credentials first, then look for an explicit profile name
            // in either the SDK credential store or the shared credentials file. When using a profile
            // name, if a location is not given the search will use the default locations and name for
            // the credential file (assuming the profile is not found in the SDK store first)
            if (!string.IsNullOrEmpty(appConfig[ACCESSKEY]) && !string.IsNullOrEmpty(appConfig[SECRETKEY]))
            {
                var accessKey = appConfig[ACCESSKEY];
                var secretKey = appConfig[SECRETKEY];
                this._wrappedCredentials = new ImmutableCredentials(accessKey, secretKey, null);
                logger.InfoFormat("Credentials found with {0} and {1} app settings", ACCESSKEY, SECRETKEY);
            }
            else
            {
                var profileName = AWSConfigs.AWSProfileName;
                var profilesLocation = AWSConfigs.AWSProfilesLocation;
                if (!string.IsNullOrEmpty(profileName) && StoredProfileAWSCredentials.CanCreateFrom(profileName, profilesLocation))
                {
                    this._wrappedCredentials = new StoredProfileAWSCredentials(profileName, profilesLocation).GetCredentials();
                    logger.InfoFormat("Credentials found with {0} app setting", AWSConfigs.AWSProfileNameKey);
                }
            }

            if (this._wrappedCredentials == null)
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                                                    "The app.config/web.config files for the application did not contain credential information"));
        }

        #endregion

        #region Abstract class overrides

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            return this._wrappedCredentials.Copy();
        }

        #endregion
    }

#endif

    /// <summary>
    /// Abstract class for automatically refreshing AWS credentials
    /// </summary>
    public abstract class RefreshingAWSCredentials : AWSCredentials
    {
        #region Refresh data

        /// <summary>
        /// Refresh state container consisting of credentials
        /// and the date of the their expiration
        /// </summary>
        public class CredentialsRefreshState
        {
            public ImmutableCredentials Credentials { get; set; }
            public DateTime Expiration { get; set; }

            public CredentialsRefreshState()
            { }
            public CredentialsRefreshState(ImmutableCredentials credentials, DateTime expiration)
            {
                Credentials = credentials;
                Expiration = expiration;
            }
        }


        protected CredentialsRefreshState _currentState = null;
        private object _refreshLock = new object();

        #endregion

        #region Private members

        private TimeSpan _preemptExpiryTime = TimeSpan.FromMinutes(0);

        #endregion

        #region Properties

        /// <summary>
        /// The time before actual expiration to expire the credentials.
        /// Property cannot be set to a negative TimeSpan.
        /// </summary>
        public TimeSpan PreemptExpiryTime
        {
            get { return _preemptExpiryTime; }
            set
            {
                if (value < TimeSpan.Zero) throw new ArgumentOutOfRangeException("value", "PreemptExpiryTime cannot be negative");
                _preemptExpiryTime = value;
            }
        }

        #endregion

        #region Override methods

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            lock (this._refreshLock)
            {
                // If credentials are expired, update
                if (ShouldUpdate)
                {
                    _currentState = GenerateNewCredentials();
                    UpdateToGeneratedCredentials(_currentState);
                }

                return _currentState.Credentials.Copy();
            }
        }

#if AWS_ASYNC_API
        public async override System.Threading.Tasks.Task<ImmutableCredentials> GetCredentialsAsync()
        {
            // If credentials are expired, update
            if (ShouldUpdate)
            {
                var state = await GenerateNewCredentialsAsync().ConfigureAwait(false);
                lock (this._refreshLock)
                {
                    _currentState = state;
                    UpdateToGeneratedCredentials(_currentState);
                }
            }

            return _currentState.Credentials.Copy();
        }
#endif

        #endregion


        #region Private/protected credential update methods

        private void UpdateToGeneratedCredentials(CredentialsRefreshState state)
        {
            // Check if the new credentials are already expired
            if (ShouldUpdate)
            {
                string errorMessage;
                if (state == null)
                    errorMessage = "Unable to generate temporary credentials";
                else
                    errorMessage = string.Format(CultureInfo.InvariantCulture,
                        "The retrieved credentials have already expired: Now = {0}, Credentials expiration = {1}",
                        DateTime.Now, state.Expiration);
                throw new AmazonClientException(errorMessage);
            }

            // Offset the Expiration by PreemptExpiryTime
            state.Expiration -= PreemptExpiryTime;

            if (ShouldUpdate)
            {
                // This could happen if the default value of PreemptExpiryTime is
                // overriden and set too high such that ShouldUpdate returns true.
                var logger = Logger.GetLogger(typeof(RefreshingAWSCredentials));
                logger.InfoFormat(
                    "The preempt expiry time is set too high: Current time = {0}, Credentials expiry time = {1}, Preempt expiry time = {2}.",
                    DateTime.Now,
                    _currentState.Expiration,
                    PreemptExpiryTime);
            }
        }

        // Test credentials existence and expiration time
        private bool ShouldUpdate
        {
            get
            {
                // should update if:

                //  credentials have not been loaded yet
                if (_currentState == null)
                    return true;

                //  it's past the expiration time
                var now = DateTime.UtcNow;
                var exp = _currentState.Expiration.ToUniversalTime();
                return (now > exp);
            }
        }

        /// <summary>
        /// When overridden in a derived class, generates new credentials and new expiration date.
        ///
        /// Called on first credentials request and when expiration date is in the past.
        /// </summary>
        /// <returns></returns>
        protected virtual CredentialsRefreshState GenerateNewCredentials()
        {
            throw new NotImplementedException();
        }

#if AWS_ASYNC_API
        /// <summary>
        /// When overridden in a derived class, generates new credentials and new expiration date.
        ///
        /// Called on first credentials request and when expiration date is in the past.
        /// </summary>
        /// <returns></returns>
        protected virtual System.Threading.Tasks.Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
        {
            return System.Threading.Tasks.Task.Run(() => this.GenerateNewCredentials());
        }
#endif

        /// <summary>
        /// Clears currently-stored credentials, forcing the next GetCredentials call to generate new credentials.
        /// </summary>
        public virtual void ClearCredentials()
        {
            _currentState = null;
        }

        #endregion
    }

    /// <summary>
    /// Credentials that are retrieved from the Instance Profile service on an EC2 instance
    /// </summary>
    public class InstanceProfileAWSCredentials : RefreshingAWSCredentials
    {
        #region Private members

        // Set preempt expiry to 15 minutes. New access keys are available at least 15 minutes before expiry time.
        // http://docs.aws.amazon.com/IAM/latest/UserGuide/role-usecase-ec2app.html
        private static TimeSpan _preemptExpiryTime = TimeSpan.FromMinutes(15);

        private CredentialsRefreshState _currentRefreshState = null;
        private static TimeSpan _refreshAttemptPeriod = TimeSpan.FromHours(1);

        #endregion

        #region Properties

        /// <summary>
        /// Role for which the credentials are retrieved
        /// </summary>
        public string Role { get; set; }

        #endregion


        #region Overrides

        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            CredentialsRefreshState newState = null;
            try
            {
                // Attempt to get early credentials. OK to fail at this point.
                newState = GetRefreshState();
            }
            catch (Exception e)
            {
                var logger = Logger.GetLogger(typeof(InstanceProfileAWSCredentials));
                logger.InfoFormat("Error getting credentials from Instance Profile service: {0}", e);
            }

            // If successful, save new credentials
            if (newState != null)
                _currentRefreshState = newState;

            // If still not successful (no credentials available at start), attempt once more to
            // get credentials, but now without swallowing exception
            if (_currentRefreshState == null)
                _currentRefreshState = GetRefreshState();

            // Return credentials that will expire in at most one hour
            CredentialsRefreshState state = GetEarlyRefreshState(_currentRefreshState);
            return state;
        }

        #endregion


        #region Constructors

        /// <summary>
        /// Constructs a InstanceProfileAWSCredentials object for specific role
        /// </summary>
        /// <param name="role">Role to use</param>
        public InstanceProfileAWSCredentials(string role)
        {
            Role = role;
            this.PreemptExpiryTime = _preemptExpiryTime;
        }

        /// <summary>
        /// Constructs a InstanceProfileAWSCredentials object for the first found role
        /// </summary>
        public InstanceProfileAWSCredentials()
            : this(GetFirstRole()) { }

        #endregion


        #region Public static methods

        /// <summary>
        /// Retrieves a list of all roles available through current InstanceProfile service
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAvailableRoles()
        {
            string allAliases = GetContents(RolesUri);
            if (string.IsNullOrEmpty(allAliases))
                yield break;

            string[] parts = allAliases.Split(AliasSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                var trim = part.Trim();
                if (!string.IsNullOrEmpty(trim))
                    yield return trim;
            }
        }

        #endregion


        #region Private members

        private static string[] AliasSeparators = new string[] { "<br/>" };
        private static string Server = "http://169.254.169.254";
        private static string RolesPath = "/latest/meta-data/iam/security-credentials/";
        private static string InfoPath = "/latest/meta-data/iam/info";
        private static string SuccessCode = "Success";

        private static Uri RolesUri
        {
            get
            {
                return new Uri(Server + RolesPath);
            }
        }
        private Uri CurrentRoleUri
        {
            get
            {
                return new Uri(Server + RolesPath + Role);
            }
        }
        private static Uri InfoUri
        {
            get
            {
                return new Uri(Server + InfoPath);
            }
        }

        private CredentialsRefreshState GetEarlyRefreshState(CredentialsRefreshState state)
        {
            // New expiry time = Now + _refreshAttemptPeriod + PreemptExpiryTime
            var newExpiryTime = DateTime.Now + _refreshAttemptPeriod + PreemptExpiryTime;
            // Use this only if the time is earlier than the default expiration time
            if (newExpiryTime.ToUniversalTime() > state.Expiration.ToUniversalTime())
                newExpiryTime = state.Expiration;

            return new CredentialsRefreshState
            {
                Credentials = state.Credentials.Copy(),
                Expiration = newExpiryTime
            };
        }

        private CredentialsRefreshState GetRefreshState()
        {
            SecurityInfo info = GetServiceInfo();
            if (!string.IsNullOrEmpty(info.Message))
            {
                throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture,
                    "Unable to retrieve credentials. Message = \"{0}\".",
                    info.Message));
            }
            SecurityCredentials credentials = GetRoleCredentials();

            CredentialsRefreshState refreshState = new CredentialsRefreshState
            {
                Credentials = new ImmutableCredentials(credentials.AccessKeyId, credentials.SecretAccessKey, credentials.Token),
                Expiration = credentials.Expiration
            };

            return refreshState;
        }

        private static SecurityInfo GetServiceInfo()
        {
            string json = GetContents(InfoUri);
            SecurityInfo info = JsonMapper.ToObject<SecurityInfo>(json);
            ValidateResponse(info);
            return info;
        }

        private SecurityCredentials GetRoleCredentials()
        {
            string json = GetContents(CurrentRoleUri);
            SecurityCredentials credentials = JsonMapper.ToObject<SecurityCredentials>(json);
            ValidateResponse(credentials);
            return credentials;
        }

        private static void ValidateResponse(SecurityBase response)
        {
            if (!string.Equals(response.Code, SuccessCode, StringComparison.OrdinalIgnoreCase))
            {
                throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture,
                    "Unable to retrieve credentials. Code = \"{0}\". Message = \"{1}\".",
                    response.Code, response.Message));
            }
        }

        private static string GetContents(Uri uri)
        {
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(uri) as HttpWebRequest;
                var asyncResult = request.BeginGetResponse(null, null);
                using (HttpWebResponse response = request.EndGetResponse(asyncResult) as HttpWebResponse)
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (WebException)
            {
                throw new AmazonServiceException("Unable to reach credentials server");
            }
        }

        private static string GetFirstRole()
        {
            IEnumerable<string> roles = GetAvailableRoles();
            foreach (string role in roles)
            {
                return role;
            }

            // no roles found
            throw new InvalidOperationException("No roles found");
        }

        #endregion


        #region Private serialization classes

        private class SecurityBase
        {
            public string Code { get; set; }
            public string Message { get; set; }
            public DateTime LastUpdated { get; set; }
        }

        private class SecurityInfo : SecurityBase
        {
            public string InstanceProfileArn { get; set; }
            public string InstanceProfileId { get; set; }
        }

        private class SecurityCredentials : SecurityBase
        {
            public string Type { get; set; }
            public string AccessKeyId { get; set; }
            public string SecretAccessKey { get; set; }
            public string Token { get; set; }
            public DateTime Expiration { get; set; }
        }

        #endregion
    }

#if BCL

    /// <summary>
    /// Temporary credentials that are created following successful authentication with
    /// a federated endpoint supporting SAML.
    /// </summary>
    /// <remarks>
    /// 1. Currently only the SDK store supports profiles that contain the necessary data to support
    /// authentication and role-based credential generation. The ini-format files used by the AWS CLI
    /// and some other SDKs are not supported at this time.
    /// <br/>
    /// 2. In order to use the StoredProfileFederatedCredentials class the AWSSDK.SecurityToken assembly
    /// must be available to your application at runtime.
    /// </remarks>
    public class StoredProfileFederatedCredentials : RefreshingAWSCredentials
    {
        #region Private data

        private object _synclock = new object();

        private RegionEndpoint DefaultSTSClientRegion = RegionEndpoint.USEast1;

        private const int MaxAuthenticationRetries = 3;

        private static readonly TimeSpan _preemptExpiryTime = TimeSpan.FromMinutes(5);
        private TimeSpan _credentialDuration = MaximumCredentialTimespan;

        private RequestUserCredential _credentialRequestCallback = null;
        private object _customCallbackState = null;

        private WebProxy _proxySettings = null;

        #endregion

        #region Public properties

        /// <summary>
        /// Custom state to return to the registered callback to handle credential requests.
        /// The data will be contained in the CredentialRequestCallbackArgs instance supplied 
        /// to the callback.
        /// </summary>
        public object CustomCallbackState
        {
            get
            {
                lock (_synclock)
                {
                    return _customCallbackState;
                }
            }
        }

        /// <summary>
        /// The minimum allowed timespan for generated credentials, per STS documentation.
        /// </summary>
        public static readonly TimeSpan MinimumCredentialTimespan = TimeSpan.FromMinutes(15);

        /// <summary>
        /// The maximum allowed timespan for generated credentials, per STS documentation.
        /// </summary>
        public static readonly TimeSpan MaximumCredentialTimespan = TimeSpan.FromHours(1);

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

        /// <summary>
        /// Callback signature for obtaining user credentials that may be needed for authentication.
        /// </summary>
        /// <param name="args">
        /// Data about the credential demand including any custom state data that was supplied
        /// when the callback was registered.
        /// </param>
        /// <returns>
        /// The network credential to use in user authentication. Return null to signal the user
        /// declined to provide credentials and authentication should not proceed.
        /// </returns>
        public delegate NetworkCredential RequestUserCredential(CredentialRequestCallbackArgs args);

        #endregion

        #region Public constructors

        /// <summary>
        /// Constructs an instance of StoredProfileFederatedCredentials using the profile name specified
        /// in the App.config. If no profile name is specified then the default credentials are used.
        /// </summary>
        public StoredProfileFederatedCredentials()
            : this(AWSConfigs.AWSProfileName)
        {

        }

        /// <summary>
        /// Constructs an instance of StoredProfileFederatedCredentials. Credentials will be searched
        /// for using the profileName parameter.
        /// </summary>
        /// <param name="profileName">The profile name to search for credentials for</param>
        public StoredProfileFederatedCredentials(string profileName)
            : this(profileName, AWSConfigs.AWSProfilesLocation)
        {

        }

        /// <summary>
        /// <para>
        /// Constructs an instance of StoredProfileFederatedCredentials. After construction call one of the Authenticate
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
        /// <remarks>
        /// The ini-format credentials file is not currently supported for SAML role profiles.
        /// </remarks>
        public StoredProfileFederatedCredentials(string profileName, string profilesLocation)
            : this(profileName, profilesLocation, null)
        {

        }

        /// <summary>
        /// <para>
        /// Constructs an instance of StoredProfileFederatedCredentials. After construction call one of the Authenticate
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
        /// <param name="proxySettings">
        /// Null or proxy settings to be used during the HHTPS authentication calls when generating credentials.
        /// /// </param>
        /// <remarks>The ini-format credentials file is not currently supported for SAML role profiles.</remarks>
        public StoredProfileFederatedCredentials(string profileName, string profilesLocation, WebProxy proxySettings)
        {
            this._proxySettings = proxySettings;
            this.PreemptExpiryTime = _preemptExpiryTime;

            var lookupName = string.IsNullOrEmpty(profileName)
                ? StoredProfileCredentials.DEFAULT_PROFILE_NAME
                : profileName;

            ProfileName = lookupName;
            ProfilesLocation = null;

            // If not overriding the credentials lookup location check the SDK Store for credentials. If
            // an override location is specified, assume we should only use the shared credential file.
            if (string.IsNullOrEmpty(profilesLocation))
            {
                if (ProfileManager.IsProfileKnown(lookupName) && SAMLRoleProfile.CanCreateFrom(lookupName))
                {
                    var profileData = ProfileManager.GetProfile<SAMLRoleProfile>(lookupName);
                    ProfileData = profileData;
                    var logger = Logger.GetLogger(typeof(StoredProfileFederatedCredentials));
                    logger.InfoFormat("SAML role profile found using account name {0} and looking in SDK account store.", lookupName);
                }
            }
            
            // we currently do not support the shared ini-format credential file for SAML role profile data
            // so end the search now if not found
            if (ProfileData == null)
            {
                var msg = string.Format(CultureInfo.InvariantCulture,
                                        "Profile '{0}' was not found or could not be loaded from the SDK credential store. Verify that the profile name and data are correct.",
                                        profileName);
                throw new ArgumentException(msg);
            }
        }

        #endregion

        /// <summary>
        /// <para>
        /// Registers a callback handler for scenarios where credentials need to be supplied
        /// during user authentication (primarily the non-domain-joined use case). Custom data,
        /// which will be supplied in the CredentialRequestCallbackArgs instance passed to the
        /// callback, can also be supplied.
        /// </para>
        /// <para>
        /// The callback will only be invoked if the underlying SAML role profile indicates it
        /// was set up for use with a specific identity. For profiles that do not contain any user
        /// identity the SDK will default to using the identity of the current process during
        /// authentication. Additionally, if the profile contain user identity information but no
        /// callback has been registered, the SDK will also attempt to use the current process
        /// identity during authentication.
        /// </para>
        /// </summary>
        /// <param name="callback">The handler to be called</param>
        /// <param name="customData">
        /// Custom state data to be supplied in the arguments to the callback.
        /// </param>
        /// <remarks>
        /// Only one callback handler can be registered. The call to the handler will be made on
        /// whatever thread is executing at the time a demand to provide AWS credentials is made.
        /// If the handler code requires that UI need to be displayed, the handler should 
        /// transition to the UI thread as appropriate.
        /// </remarks>
        public void SetCredentialCallbackData(RequestUserCredential callback, object customData)
        {
            lock (_synclock)
            {
                _credentialRequestCallback = callback;
                _customCallbackState = customData;
            }
        }

        /// <summary>
        /// Tests if an instance can be created from the persisted profile data.
        /// </summary>
        /// <param name="profileName">The name of the profile to test.</param>
        /// <param name="profilesLocation">The location of the shared ini-format credential file.</param>
        /// <returns>True if the persisted data would yield a valid credentials instance.</returns>
        /// <remarks>
        /// This profile type is currently only supported in the SDK credential store file.
        /// The shared ini-format file is not currently supported; any value supplied
        /// for the profilesLocation value is ignored.
        /// </remarks>
        public static bool CanCreateFrom(string profileName, string profilesLocation)
        {
            if (string.IsNullOrEmpty(profilesLocation) && ProfileManager.IsProfileKnown(profileName))
                return SAMLRoleProfile.CanCreateFrom(profileName);

            return false;
        }


        /// <summary>
        /// Performs any additional validation we may require on the profile content.
        /// </summary>
        protected override void Validate()
        {
        }

        /// <summary>
        /// Refresh credentials after expiry. If the role profile is configured with user identity
        /// information and a callback has been registered to obtain the user credential the callback
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
            lock(_synclock)
            {
                // If the profile indicates the user has already authenticated and received
                // credentials which are still valid, adopt them instead of requiring a fresh
                // authentication
                var currentSession = ProfileData.GetCurrentSession();
                if (currentSession != null)
                    return new CredentialsRefreshState(currentSession, currentSession.Expires);

                CredentialsRefreshState newState = null;
                var attempts = 0;
                do
                {
                    try
                    {
                        NetworkCredential userCredential = null;
                        if (!ProfileData.UseDefaultUserIdentity)
                        {
                            if (_credentialRequestCallback != null)
                            {
                                var callbackArgs = new CredentialRequestCallbackArgs
                                {
                                    ProfileName = ProfileData.Name,
                                    UserIdentity = ProfileData.UserIdentity,
                                    CustomState = CustomCallbackState,
                                    PreviousAuthenticationFailed = attempts > 0
                                };

                                userCredential = _credentialRequestCallback(callbackArgs);

                                if (userCredential == null) // user declined to authenticate
                                    throw new FederatedAuthenticationCancelledException("User cancelled credential request.");
                            }
                            else
                            {
                                var logger = Logger.GetLogger(typeof(StoredProfileFederatedCredentials));
                                logger.InfoFormat("Role profile {0} is configured for a specific user but no credential request callback registered; falling back to default identity.", ProfileName);
                            }
                        }

                        newState = Authenticate(userCredential, _credentialDuration);
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

        private CredentialsRefreshState Authenticate(ICredentials userCredential, TimeSpan credentialDuration)
        {
            CredentialsRefreshState state;

            var configuredRegion = AWSConfigs.AWSRegion;
            var region = string.IsNullOrEmpty(configuredRegion)
                                ? DefaultSTSClientRegion
                                : RegionEndpoint.GetBySystemName(configuredRegion);

            ICoreAmazonSTS coreSTSClient = null;

            try
            {
                var stsConfig = ServiceClientHelpers.CreateServiceConfig(ServiceClientHelpers.STS_ASSEMBLY_NAME,
                                                                         ServiceClientHelpers.STS_SERVICE_CONFIG_NAME);
                stsConfig.RegionEndpoint = region;
                if (_proxySettings != null)
                    stsConfig.SetWebProxy(_proxySettings);

                coreSTSClient
                    = ServiceClientHelpers.CreateServiceFromAssembly<ICoreAmazonSTS>(ServiceClientHelpers.STS_ASSEMBLY_NAME,
                                                                                     ServiceClientHelpers.STS_SERVICE_CLASS_NAME,
                                                                                     new AnonymousAWSCredentials(),
                                                                                     stsConfig);
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
                var credentials
                    = coreSTSClient.CredentialsFromSAMLAuthentication(ProfileData.EndpointSettings.Endpoint.ToString(),
                                                                      ProfileData.EndpointSettings.AuthenticationType,
                                                                      ProfileData.RoleArn,
                                                                      credentialDuration,
                                                                      userCredential);

                ProfileData.PersistSession(credentials);

                state = new CredentialsRefreshState(credentials, credentials.Expires);
            }
            catch (Exception e)
            {
                var wrappedException = new AmazonClientException("Credential generation from SAML authentication failed.", e);

                var logger = Logger.GetLogger(typeof(StoredProfileFederatedCredentials));
                logger.Error(wrappedException, wrappedException.Message);

                throw wrappedException;
            }

            return state;
        }
    }

    /// <summary>
    /// State class passed on callback to demand user credentials when authentication
    /// needs to be performed using a non-default identity.
    /// </summary>
    public class CredentialRequestCallbackArgs
    {
        /// <summary>
        /// Contains the name of the credential profile we are authenticating
        /// for. Use in display prompts to give the user some context as to
        /// why their credentials are being requested.
        /// </summary>
        public string ProfileName { get; internal set; }
        /// <summary>
        /// Contains the user identity that the user should supply a password
        /// for. The user can ignore if they choose and return credentials for
        /// an alternate account.
        /// </summary>
        public string UserIdentity { get; internal set; }

        /// <summary>
        /// Any custom state that was registered with the callback.
        /// </summary>
        public object CustomState { get; internal set; }

        /// <summary>
        /// Set if the callback was due to a failed authentication attempt.
        /// If false we are beginning to obtain or refresh credentials.
        /// </summary>
        public bool PreviousAuthenticationFailed { get; internal set; }
    }

    /// <summary>
    /// Exception thrown on validation of a StoredProfileFederatedCredentials instance if the role profile
    /// is configured to use a non-default user identity and the QueryUserCredentialCallback on the
    /// instance has not been set.
    /// </summary>
#if !PCL
    [Serializable]
#endif
    public class CredentialRequestCallbackRequiredException : Exception
    {
        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="msg"></param>
        public CredentialRequestCallbackRequiredException(string msg)
            : base(msg)
        {
        }

        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerException"></param>
        public CredentialRequestCallbackRequiredException(string msg, Exception innerException)
            : base(msg, innerException)
        {
        }

        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="innerException"></param>
        public CredentialRequestCallbackRequiredException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

#if !PCL
        /// <summary>
        /// Constructs a new instance of the CredentialRequestCallbackRequiredException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected CredentialRequestCallbackRequiredException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }

    /// <summary>
    /// Custom exception type thrown when authentication for a user fails due to
    /// invalid credentials.
    /// </summary>
#if !PCL
    [Serializable]
#endif
    public class FederatedAuthenticationFailureException : Exception
    {
        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="msg"></param>
        public FederatedAuthenticationFailureException(string msg)
            : base(msg)
        {
        }

        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="inner"></param>
        public FederatedAuthenticationFailureException(string msg, Exception inner)
            : base(msg, inner)
        {
        }

#if !PCL
        /// <summary>
        /// Constructs a new instance of the FederatedAuthenticationFailureException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected FederatedAuthenticationFailureException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }

    /// <summary>
    /// Custom exception type thrown when a role profile with user identity is used
    /// in conjunction with a credential request callback. This exception is thrown
    /// if the callback returns null, indicating the user declined to supply credentials.
    /// </summary>
#if !PCL
    [Serializable]
#endif
    public class FederatedAuthenticationCancelledException : Exception
    {
        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="msg"></param>
        public FederatedAuthenticationCancelledException(string msg)
            : base(msg)
        {
        }

        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="inner"></param>
        public FederatedAuthenticationCancelledException(string msg, Exception inner)
            : base(msg, inner)
        {
        }

#if !PCL
        /// <summary>
        /// Constructs a new instance of the FederatedAuthenticationCancelledException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected FederatedAuthenticationCancelledException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }

#endif

    /// <summary>
    /// Anonymous credentials.
    /// Using these credentials, the client does not sign the request.
    /// </summary>
    public class AnonymousAWSCredentials : AWSCredentials
    {
        #region Abstract class overrides

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            throw new NotSupportedException("AnonymousAWSCredentials do not support this operation");
        }

        #endregion
    }

    // Credentials fallback mechanism
    public static class FallbackCredentialsFactory
    {
        static FallbackCredentialsFactory()
        {
            Reset();
        }

        public delegate AWSCredentials CredentialsGenerator();
        public static List<CredentialsGenerator> CredentialsGenerators { get; set; }
        public static void Reset()
        {
            cachedCredentials = null;
            CredentialsGenerators = new List<CredentialsGenerator>
            {
#if BCL
                
                () => new AppConfigAWSCredentials(),            // test explicit keys/profile name first
                () => new StoredProfileAWSCredentials(),        // then attempt to load default profile        
                () => new StoredProfileFederatedCredentials(),  // if default/named profile didn't contain AWS credentials,
                                                                // was it a named or default federated role profile?
                () => new EnvironmentVariablesAWSCredentials(), // credentials set in environment vars?
#endif
                () => new InstanceProfileAWSCredentials()       // if we're running on an EC2 instance try and get credentials 
                                                                // from instance profile
            };
        }

        private static AWSCredentials cachedCredentials;
        public static AWSCredentials GetCredentials()
        {
            return GetCredentials(false);
        }

        public static AWSCredentials GetCredentials(bool fallbackToAnonymous)
        {
            if (cachedCredentials != null)
                return cachedCredentials;

            List<Exception> errors = new List<Exception>();

            foreach (CredentialsGenerator generator in CredentialsGenerators)
            {
                try
                {
                    cachedCredentials = generator();
                }
                catch (Exception e)
                {
                    cachedCredentials = null;
                    errors.Add(e);
                }

                if (cachedCredentials != null)
                    break;
            }

            if (cachedCredentials == null)
            {
                if (fallbackToAnonymous)
                {
                    return new AnonymousAWSCredentials();
                }

                using (StringWriter writer = new StringWriter(CultureInfo.InvariantCulture))
                {
                    writer.WriteLine("Unable to find credentials");
                    writer.WriteLine();
                    for (int i = 0; i < errors.Count; i++)
                    {
                        Exception e = errors[i];
                        writer.WriteLine("Exception {0} of {1}:", i + 1, errors.Count);
                        writer.WriteLine(e.ToString());
                        writer.WriteLine();
                    }

                    throw new AmazonServiceException(writer.ToString());
                }
            }

            return cachedCredentials;
        }
    }
}
