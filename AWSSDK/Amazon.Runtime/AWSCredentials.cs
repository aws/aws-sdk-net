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
using System.Configuration;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using ThirdParty.Json.LitJson;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
    /// <summary>
    /// Immutable representation of AWS credentials.
    /// </summary>
    public class ImmutableCredentials : IDisposable
    {
        #region Properties

        /// <summary>
        /// Gets the AccessKey property for the current credentials.
        /// </summary>
        public string AccessKey { get; private set; }

        /// <summary>
        /// Gets the ClearSecretKey property for the current credentials.
        /// </summary>
        public string ClearSecretKey { get; private set; }

        /// <summary>
        /// Gets the SecureSecretKey property for the current credentials.
        /// </summary>
        public SecureString SecureSecretKey { get; private set; }

        /// <summary>
        /// Gets the Token property for the current credentials.
        /// </summary>
        public string Token { get; private set; }


        /// <summary>
        /// Gets the UseToken property for the current credentials.
        /// Specifies if Token property is non-emtpy.
        /// </summary>
        public bool UseToken { get { return !string.IsNullOrEmpty(Token); } }

        /// <summary>
        /// Gets the UseSecureStringForSecretKey property for the current credentials.
        /// Specifies if secretKey is stored as SecureString or String.
        /// </summary>
        public bool UseSecureStringForSecretKey { get { return SecureSecretKey != null; } }

        #endregion


        #region Constructors

        /// <summary>
        /// Constructs an ImmutableCredentials object with supplied accessKey, secretKey,
        /// optional token and flag to determine if secretKey should be stored in a SecureString
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="token">Optional. Can be set to null or empty for non-session credentials.</param>
        /// <param name="useSecureStringForSecretKey">
        /// True if secretKey should be stored in SecureString. False if secretKey should be stored as clear string.
        /// </param>
        public ImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, bool useSecureStringForSecretKey)
        {
            if (string.IsNullOrEmpty(awsAccessKeyId)) throw new ArgumentNullException("awsAccessKeyId");
            if (string.IsNullOrEmpty(awsSecretAccessKey)) throw new ArgumentNullException("awsSecretAccessKey");

            AccessKey = awsAccessKeyId;
            if (useSecureStringForSecretKey)
            {
                SetSecretAccessKey(awsSecretAccessKey);
                ClearSecretKey = null;
            }
            else
            {
                ClearSecretKey = awsSecretAccessKey;
                SecureSecretKey = null;
            }
            Token = token ?? string.Empty;
        }

        /// <summary>
        /// Constructs an ImmutableCredentials object with supplied accessKey, secretKey as a SecureString
        /// and an optional session token.
        /// </summary>
        /// <param name="accessKey"></param>
        /// <param name="secretKey"></param>
        /// <param name="token">Optional. Can be set to null or empty for non-session credentials.</param>
        public ImmutableCredentials(string accessKey, SecureString secretKey, string token)
        {
            if (string.IsNullOrEmpty(accessKey)) throw new ArgumentNullException("accessKey");
            if (secretKey == null) throw new ArgumentNullException("secretKey");

            AccessKey = accessKey;
            ClearSecretKey = null;
            SecureSecretKey = secretKey.Copy();
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
                ClearSecretKey = this.ClearSecretKey,
                SecureSecretKey = (this.SecureSecretKey == null ? null : this.SecureSecretKey.Copy()),
                Token = this.Token,
            };
            return credentials;
        }

        #endregion


        #region Private methods

        // Sets SecureSecretKey equal to the passed-in string.
        private void SetSecretAccessKey(string secretAccessKey)
        {
            SecureSecretKey = new SecureString();
            foreach (char ch in secretAccessKey.ToCharArray())
            {
                SecureSecretKey.AppendChar(ch);
            }
            SecureSecretKey.MakeReadOnly();
        }

        #endregion


        #region IDisposable Members

        private bool _disposed = false;

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (SecureSecretKey != null)
                    {
                        SecureSecretKey.Dispose();
                        SecureSecretKey = null;
                    }
                }

                _disposed = true;
            }
        }

        #endregion
    }

    /// <summary>
    /// Abstract class that represents a credentials object for AWS services.
    /// </summary>
    public abstract class AWSCredentials : IDisposable
    {
        /// <summary>
        /// Returns a copy of ImmutableCredentials
        /// </summary>
        /// <returns></returns>
        public abstract ImmutableCredentials GetCredentials();

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        #endregion
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
        /// Constructs a BasicAWSCredentials object for the specified accessKey and secretKey
        /// SecretKey is stored as a clear string
        /// </summary>
        /// <param name="accessKey"></param>
        /// <param name="secretKey"></param>
        public BasicAWSCredentials(string accessKey, string secretKey)
            : this(accessKey, secretKey, false) { }

        /// <summary>
        /// Constructs a BasicAWSCredentials object for the specified accessKey and secretKey,
        /// with the useSecureString flag to signal if the secretKey should be stored as SecureString
        /// </summary>
        /// <param name="accessKey"></param>
        /// <param name="secretKey"></param>
        /// <param name="useSecureString">
        /// True if secretKey should be stored in SecureString. False if secretKey should be stored as clear string.
        /// </param>
        public BasicAWSCredentials(string accessKey, string secretKey, bool useSecureString)
        {
            _credentials = new ImmutableCredentials(accessKey, secretKey, null, useSecureString);
        }

        /// <summary>
        /// Constructs a BasicAWSCredentials object for the specified accessKey and secretKey
        /// SecretKey is stored in SecureString
        /// </summary>
        /// <param name="accessKey"></param>
        /// <param name="secretKey"></param>
        public BasicAWSCredentials(string accessKey, SecureString secretKey)
        {
            _credentials = new ImmutableCredentials(accessKey, secretKey, null);
        }

        #endregion


        #region Abstract class overrides

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            return _credentials.Copy();
        }

        #endregion


        #region IDisposable Members

        private bool _disposed = false;

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_credentials != null)
                    {
                        _credentials.Dispose();
                        _credentials = null;
                    }
                }

                _disposed = true;
            }
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
        /// Constructs a SessionAWSCredentials object for the specified accessKey, secretKey
        /// and session token. SecretKey is stored as clear string.
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="token"></param>
        public SessionAWSCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)
            : this(awsAccessKeyId, awsSecretAccessKey, token, false) { }

        /// <summary>
        /// Constructs a SessionAWSCredentials object for the specified accessKey, secretKey
        /// session token and flag to specify if secretKey should be stored in SecureString.
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="token"></param>
        /// <param name="useSecureString">
        /// True if secretKey should be stored in SecureString. False if secretKey should be stored as clear string.
        /// </param>
        public SessionAWSCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, bool useSecureString)
        {
            if (string.IsNullOrEmpty(awsAccessKeyId)) throw new ArgumentNullException("awsAccessKeyId");
            if (string.IsNullOrEmpty(awsSecretAccessKey)) throw new ArgumentNullException("awsSecretAccessKey");
            if (string.IsNullOrEmpty(token)) throw new ArgumentNullException("token");

            _lastCredentials = new ImmutableCredentials(awsAccessKeyId, awsSecretAccessKey, token, useSecureString);
        }

        /// <summary>
        /// Constructs a SessionAWSCredentials object for the specified accessKey, secretKey
        /// and session token. SecretKey is stored as clear string.
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="token"></param>
        public SessionAWSCredentials(string awsAccessKeyId, SecureString awsSecretAccessKey, string token)
        {
            if (string.IsNullOrEmpty(awsAccessKeyId)) throw new ArgumentNullException("awsAccessKeyId");
            if (awsSecretAccessKey == null) throw new ArgumentNullException("awsSecretAccessKey");
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


        #region IDisposable Members

        private bool _disposed = false;

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_lastCredentials != null)
                    {
                        _lastCredentials.Dispose();
                        _lastCredentials = null;
                    }
                }

                _disposed = true;
            }
        }

        #endregion
    }

    /// <summary>
    /// Credentials that are retrieved from ConfigurationManager.AppSettings
    /// </summary>
    public class EnvironmentAWSCredentials : AWSCredentials
    {
        #region Private members

        private const string ACCESSKEY = "AWSAccessKey";
        private const string SECRETKEY = "AWSSecretKey";

        private ImmutableCredentials _wrappedCredentials;

        #endregion


        #region Public constructors

        /// <summary>
        /// Constructs an instance of EnvironmentAWSCredentials and attempts
        /// to load AccessKey and SecretKey from ConfigurationManager.AppSettings
        /// </summary>
        public EnvironmentAWSCredentials()
        {
            NameValueCollection appConfig = ConfigurationManager.AppSettings;

            var accessKey = appConfig[ACCESSKEY];
            var secretKey = appConfig[SECRETKEY];

            if (string.IsNullOrEmpty(accessKey))
                throw new ArgumentException(string.Format("Access Key could not be found.  Add an appsetting to your App.config with the name {0} with a value of your access key.", ACCESSKEY));
            if (string.IsNullOrEmpty(secretKey))
                throw new ArgumentException(string.Format("Secret Key could not be found.  Add an appsetting to your App.config with the name {0} with a value of your secret key.", SECRETKEY));

            this._wrappedCredentials = new ImmutableCredentials(accessKey, secretKey, null, false);
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


        #region IDisposable Members

        private bool _disposed = false;

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_wrappedCredentials != null)
                    {
                        _wrappedCredentials.Dispose();
                        _wrappedCredentials = null;
                    }
                }

                _disposed = true;
            }
        }

        #endregion
    }


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
        protected class CredentialsRefreshState : IDisposable
        {
            public ImmutableCredentials Credentials { get; set; }
            public DateTime Expiration { get; set; }

            #region IDisposable Members

            public void Dispose()
            {
                if (Credentials != null)
                {
                    Credentials.Dispose();
                }
            }

            #endregion
        }


        private CredentialsRefreshState _currentState = null;
        private object _refreshLock = new object();
        #endregion

        #region Private members
        private static Logger _logger = Logger.GetLogger(typeof(RefreshingAWSCredentials));
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
                if (value < TimeSpan.Zero) throw new ArgumentOutOfRangeException("PreemptExpiryTime cannot be negative");
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
                    if (_currentState != null)
                    {
                        _currentState.Dispose();
                    }
                    _currentState = GenerateNewCredentials();

                    // Check if the new credentials are already expired
                    if (ShouldUpdate)
                    {
                        throw new AmazonClientException("The retrieved credentials have already expired");
                    }

                    // Offset the Expiration by PreemptExpiryTime
                    _currentState.Expiration -= PreemptExpiryTime;

                    if (ShouldUpdate)
                    {
                        // This should happen if the default value of PreemptExpiryTime is
                        // overriden and set too high such that ShouldUpdate returns true.
                        _logger.InfoFormat("The preempt expiry time is set too high: {0}.",
                            PreemptExpiryTime);
                    }
                }

                return _currentState.Credentials.Copy();
            }
        }

        #endregion


        #region Private/protected credential update methods

        // Test credentials existence and expiration time
        private bool ShouldUpdate
        {
            get
            {
                return
                    (                                                   // should update if:
                        _currentState == null ||                        //  credentials have not been loaded yet
                        DateTime.Now >= this._currentState.Expiration   //  past the expiration time
                    );
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

        #endregion


        #region IDisposable Members

        private bool _disposed = false;

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_currentState != null)
                    {
                        _currentState.Dispose();
                        _currentState = null;
                    }
                    if (_logger!=null)
                    {
                        _logger.Flush();
                    }
                }

                _disposed = true;
            }
        }

        #endregion
    }

    /// <summary>
    /// Session credentials retrieved and automatically refreshed from
    /// an instance of the AmazonSecurityTokenService
    /// </summary>
    public class RefreshingSessionAWSCredentials : RefreshingAWSCredentials
    {
        #region Private members

        private static TimeSpan _preemptExpiryTime = TimeSpan.FromMinutes(15);
        private bool _ownStsClient;
        private AmazonSecurityTokenService _stsClient;
 
        #endregion


        #region Properties

        internal string UniqueIdentifier
        {
            get
            {
                AmazonWebServiceClient baseClient = this._stsClient as AmazonWebServiceClient;
                if (baseClient == null)
                    return null;

                return string.Format("{0} - {1}", baseClient.Credentials.GetCredentials().AccessKey, baseClient.ServiceURL);
            }
        }

        #endregion


        #region Constructors

        // Constructs refreshing credentials from STS client
        private RefreshingSessionAWSCredentials(AmazonSecurityTokenService stsClient, bool ownStsClient)
        {
            _stsClient = stsClient;
            _ownStsClient = ownStsClient;
            this.PreemptExpiryTime = _preemptExpiryTime;
        }

        /// <summary>
        /// Constructs a RefreshingSessionAWSCredentials object.
        /// The passed-in AmazonSecurityTokenService is used to refresh credentials.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public RefreshingSessionAWSCredentials(string awsAccessKeyId, string awsSecretAccessKey)
            : this(ConstructSTSClient(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey))) { }

        /// <summary>
        /// Constructs a RefreshingSessionAWSCredentials object.
        /// The passed-in AmazonSecurityTokenService is used to refresh credentials.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="stsConfig">Config object used for the constructed AmazonSecurityTokenService.</param>
        public RefreshingSessionAWSCredentials(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityTokenServiceConfig stsConfig)
            : this(ConstructSTSClient(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), stsConfig)) { }

        /// <summary>
        /// Constructs a RefreshingSessionAWSCredentials object.
        /// The passed-in AmazonSecurityTokenService is used to refresh credentials.
        /// </summary>
        /// <param name="stsClient">STS client to use</param>
        public RefreshingSessionAWSCredentials(AmazonSecurityTokenService stsClient)
            : this(stsClient, false) { }

        /// <summary>
        /// Constructs a RefreshingSessionAWSCredentials object.
        /// AmazonSecurityTokenService is created from passed-in credentials and
        /// is used to refresh credentials.
        /// 
        /// Passed-in AWSCredentials cannot be session credentials.
        /// </summary>
        /// <param name="stsCredentials">Credentials to use to create STS client</param>
        public RefreshingSessionAWSCredentials(AWSCredentials stsCredentials)
            : this(ConstructSTSClient(stsCredentials), true) { }

        /// <summary>
        /// Constructs a RefreshingSessionAWSCredentials object.
        /// AmazonSecurityTokenService is created from passed-in credentials and
        /// config object and is used to refresh credentials.
        /// 
        /// Passed-in AWSCredentials cannot be session credentials.
        /// </summary>
        /// <param name="stsCredentials"></param>
        /// <param name="stsConfig">Config object used for the constructed AmazonSecurityTokenService.</param>
        public RefreshingSessionAWSCredentials(AWSCredentials stsCredentials, AmazonSecurityTokenServiceConfig stsConfig)
            : this(ConstructSTSClient(stsCredentials, stsConfig), true) { }

        /// <summary>
        /// Constructs a RefreshingSessionAWSCredentials object.
        /// AccessKey and SecretKey are taken from the app.config for the application.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        public RefreshingSessionAWSCredentials()
            : this(new EnvironmentAWSCredentials()) { }

        /// <summary>
        /// Constructs a RefreshingSessionAWSCredentials object.
        /// AccessKey and SecretKey are taken from the app.config for the application.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="stsConfig">Config object used for the constructed AmazonSecurityTokenService.</param>
        public RefreshingSessionAWSCredentials(AmazonSecurityTokenServiceConfig stsConfig)
            : this(new EnvironmentAWSCredentials(), stsConfig) { }

        #endregion


        #region Private methods

        private static AmazonSecurityTokenService ConstructSTSClient(AWSCredentials credentials)
        {
            return ConstructSTSClient(credentials, new AmazonSecurityTokenServiceConfig());
        }

        private static AmazonSecurityTokenService ConstructSTSClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig config)
        {
            using (ImmutableCredentials immmutableCredentials = credentials.GetCredentials())
            {
                if (immmutableCredentials.UseToken)
                    throw new ArgumentException("Session credentials cannot be used to create refreshing session credentials");

                AmazonSecurityTokenServiceClient stsClient;
                if (immmutableCredentials.UseSecureStringForSecretKey)
                {
                    stsClient = new AmazonSecurityTokenServiceClient(immmutableCredentials.AccessKey, GetClearSecretKey(immmutableCredentials.SecureSecretKey), config);
                }
                else
                {
                    stsClient = new AmazonSecurityTokenServiceClient(immmutableCredentials.AccessKey, immmutableCredentials.ClearSecretKey, config);
                }
                return stsClient;
            }
        }

        private static string GetClearSecretKey(SecureString secureSecretKey)
        {
            if (secureSecretKey == null)
                throw new ArgumentNullException("securePassword");

            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureSecretKey);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        #endregion


        #region Overrides

        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            var sessionCredentials = _stsClient.GetSessionToken(new GetSessionTokenRequest()).GetSessionTokenResult.Credentials;

            var state = new CredentialsRefreshState
            {
                Credentials = new ImmutableCredentials(sessionCredentials.AccessKeyId, sessionCredentials.SecretAccessKey, sessionCredentials.SessionToken, false),
                Expiration = sessionCredentials.Expiration
            };

            return state;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (_stsClient != null)
            {
                if (_ownStsClient)
                {
                    _stsClient.Dispose();
                }
                _stsClient = null;
            }
        }

        #endregion
    }

    /// <summary>
    /// Credentials that are retrieved from the Instance Profile service on an EC2 instance
    /// </summary>
    public class InstanceProfileAWSCredentials : RefreshingAWSCredentials
    {
        #region Private members

        // Set preempt expiry to 2 minutes. New access keys are available 5 minutes before expiry time.
        // http://aws.amazon.com/iam/faqs/#How_do_i_rotate_the_access_keys_on_the_EC2_instance 
        private static TimeSpan _preemptExpiryTime = TimeSpan.FromMinutes(2);

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
            CredentialsRefreshState state = GetRefreshState();
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
        private Uri InfoUri
        {
            get
            {
                return new Uri(Server + InfoPath);
            }
        }

        private CredentialsRefreshState GetRefreshState()
        {
            SecurityInfo info = GetServiceInfo();
            if (!string.IsNullOrEmpty(info.Message))
            {
                throw new AmazonServiceException(string.Format(
                    "Unable to retrieve credentials. Message = \"{1}\".",
                    info.Message));
            }
            SecurityCredentials credentials = GetRoleCredentials();

            CredentialsRefreshState refreshState = new CredentialsRefreshState
            {
                Credentials = new ImmutableCredentials(credentials.AccessKeyId, credentials.SecretAccessKey, credentials.Token, false),
                Expiration = credentials.Expiration
            };

            return refreshState;
        }

        private SecurityInfo GetServiceInfo()
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
                throw new AmazonServiceException(string.Format(
                    "Unable to retrieve credentials. Code = \"{0}\". Message = \"{1}\".",
                    response.Code, response.Message));
            }
        }

        private static string GetContents(Uri uri)
        {
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(uri) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
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
    internal static class FallbackCredentialsFactory
    {
        static FallbackCredentialsFactory()
        {
            Reset();
        }

        public delegate AWSCredentials CredentialsGenerator();
        public static List<CredentialsGenerator> CredentialsGenerators { get; set; }
        public static void Reset()
        {
            CredentialsGenerators = new List<CredentialsGenerator>
            {
                () => new EnvironmentAWSCredentials(),
                () => new InstanceProfileAWSCredentials()
            };
        }

        internal static AWSCredentials GetCredentials()
        {
            AWSCredentials credentials = null;
            List<Exception> errors = new List<Exception>();

            foreach (CredentialsGenerator generator in CredentialsGenerators)
            {
                try
                {
                    credentials = generator();
                }
                catch (Exception e)
                {
                    credentials = null;
                    errors.Add(e);
                }

                if (credentials != null)
                    return credentials;
            }

            if (credentials == null)
            {
                using (StringWriter writer = new StringWriter())
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

            return credentials;
        }
    }
}
