/*
 * Copyright 2011-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

        private bool _ownStsClient;
        private AmazonSecurityTokenService _stsClient;
        private TimeSpan _preemptExpiryTime = TimeSpan.FromMinutes(15);

        #endregion


        #region Properties

        /// <summary>
        /// The time before actual expiration to expire the credentials.
        /// Default PreemptExpiryTime is 15 minutes.
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


        #region Constructors

        // Constructs refreshing credentials from STS client
        private RefreshingSessionAWSCredentials(AmazonSecurityTokenService stsClient, bool ownStsClient)
        {
            _stsClient = stsClient;
            _ownStsClient = ownStsClient;
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
                Expiration = sessionCredentials.Expiration - PreemptExpiryTime
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
}
