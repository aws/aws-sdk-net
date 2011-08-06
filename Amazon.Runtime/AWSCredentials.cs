using System;
using System.Collections.Generic;
using System.Text;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using System.Security;
using System.Runtime.InteropServices;

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
    public abstract class AWSCredentials
    {
        /// <summary>
        /// Returns a copy of ImmutableCredentials
        /// </summary>
        /// <returns></returns>
        public abstract ImmutableCredentials GetCredentials();
    }

    /// <summary>
    /// Basic set of credentials consisting of an AccessKey and SecretKey
    /// </summary>
    public class BasicAWSCredentials : AWSCredentials, IDisposable
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
        /// Returns an instance of ImmutableCredentials for the 
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            return _credentials.Copy();
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

    public class SessionAWSCredentials : AWSCredentials, IDisposable
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
        /// Returns an instance of ImmutableCredentials for the 
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            return _lastCredentials.Copy();
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
}
