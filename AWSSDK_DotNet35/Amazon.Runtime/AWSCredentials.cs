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
using System.Net;
using System.Runtime.InteropServices;
using System.Security;

#if BCL
using System.Configuration;
#endif

using ThirdParty.Json.LitJson;
using Amazon.Runtime.Internal.Util;
using System.Globalization;

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
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Access Key could not be found.  Add an appsetting to your App.config with the name {0} with a value of your access key.", ACCESSKEY));
            if (string.IsNullOrEmpty(secretKey))
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Secret Key could not be found.  Add an appsetting to your App.config with the name {0} with a value of your secret key.", SECRETKEY));

            this._wrappedCredentials = new ImmutableCredentials(accessKey, secretKey, null);
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
        protected class CredentialsRefreshState
        {
            public ImmutableCredentials Credentials { get; set; }
            public DateTime Expiration { get; set; }
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

                    // Check if the new credentials are already expired
                    if (ShouldUpdate)
                    {
                        throw new AmazonClientException("The retrieved credentials have already expired");
                    }

                    // Offset the Expiration by PreemptExpiryTime
                    _currentState.Expiration -= PreemptExpiryTime;

                    if (ShouldUpdate)
                    {
                        // This could happen if the default value of PreemptExpiryTime is
                        // overriden and set too high such that ShouldUpdate returns true.
                        _logger.InfoFormat(
                            "The preempt expiry time is set too high: Current time = {0}, Credentials expiry time = {1}, Preempt expiry time = {2}.",
                            DateTime.Now,
                            _currentState.Expiration,
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
        private static Logger _logger = Logger.GetLogger(typeof(InstanceProfileAWSCredentials));

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
                _logger.InfoFormat("Error getting credentials from Instance Profile service: {0}", e);
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
            if (newExpiryTime > state.Expiration)
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
                    "Unable to retrieve credentials. Message = \"{1}\".",
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
#if BCL
                () => new EnvironmentAWSCredentials(),
#endif
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

            return credentials;
        }
    }
}
