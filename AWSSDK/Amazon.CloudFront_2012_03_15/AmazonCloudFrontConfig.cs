/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *
 */
using System;
using System.Net;
using Amazon.Util;

namespace Amazon.CloudFront_2012_03_15
{
    /// <summary>
    /// Configuration for Amazon CloudFront Client.
    /// </summary>
    [Obsolete("This version of the CloudFront SDK has been obsoleted but is kept around due to " +
            "breaking changes in the main Amazon.CloudFront namespace. No further updates will be made " +
            "to this version and applications should migrate to the Amazon.CloudFront namespace.")]
    public class AmazonCloudFrontConfig
    {
        #region Private Members

        private string serviceURL = "https://cloudfront.amazonaws.com";
        private string userAgent = Amazon.Util.AWSSDKUtils.SDKUserAgent + " v2012_03_15";
        private string proxyHost;
        private int proxyPort = -1;
        private int maxErrorRetry = 3;
        private bool fUseSecureString = true;
        private string proxyUsername;
        private string proxyPassword;
        private int? connectionLimit;
        private ICredentials proxyCredentials;

        #endregion

        /// <summary>
        /// Gets and sets of the ServiceURL property.
        /// </summary>
        public string ServiceURL
        {
            get { return this.serviceURL; }
            set { this.serviceURL = value; }
        }

        /// <summary>
        /// Sets the ServiceURL property
        /// </summary>
        /// <param name="serviceURL">ServiceURL property</param>
        /// <returns>this instance</returns>
        public AmazonCloudFrontConfig WithServiceURL(string serviceURL)
        {
            this.serviceURL = serviceURL;
            return this;
        }

        /// <summary>
        /// Checks if ServiceURL property is set
        /// </summary>
        /// <returns>true if ServiceURL property is set</returns>
        internal bool IsSetServiceURL()
        {
            return !System.String.IsNullOrEmpty(this.serviceURL);
        }

        /// <summary>
        /// Gets and sets of the UserAgent property.
        /// </summary>
        public string UserAgent
        {
            get { return this.userAgent; }
            set { this.userAgent = value; }
        }

        /// <summary>
        /// Sets the UserAgent property
        /// </summary>
        /// <param name="userAgent">UserAgent property</param>
        /// <returns>this instance</returns>
        public AmazonCloudFrontConfig WithUserAgent(string userAgent)
        {
            this.userAgent = userAgent;
            return this;
        }

        /// <summary>
        /// Checks if UserAgent property is set
        /// </summary>
        /// <returns>true if UserAgent property is set</returns>
        internal bool IsSetUserAgent()
        {
            return !System.String.IsNullOrEmpty(this.userAgent);
        }

        /// <summary>
        /// Gets and sets of the ProxyHost property.
        /// </summary>
        public string ProxyHost
        {
            get { return this.proxyHost; }
            set { this.proxyHost = value; }
        }

        /// <summary>
        /// Sets the ProxyHost property
        /// </summary>
        /// <param name="proxyHost">ProxyHost property</param>
        /// <returns>this instance</returns>
        public AmazonCloudFrontConfig WithProxyHost(string proxyHost)
        {
            this.proxyHost = proxyHost;
            return this;
        }

        /// <summary>
        /// Checks if ProxyHost property is set
        /// </summary>
        /// <returns>true if ProxyHost property is set</returns>
        internal bool IsSetProxyHost()
        {
            return !System.String.IsNullOrEmpty(this.proxyHost);
        }

        /// <summary>
        /// Gets and sets of the ProxyPort property.
        /// </summary>
        public int ProxyPort
        {
            get { return this.proxyPort; }
            set { this.proxyPort = value; }
        }

        /// <summary>
        /// Sets the ProxyPort property
        /// </summary>
        /// <param name="proxyPort">ProxyPort property</param>
        /// <returns>this instance</returns>
        public AmazonCloudFrontConfig WithProxyPort(int proxyPort)
        {
            this.proxyPort = proxyPort;
            return this;
        }

        /// <summary>
        /// Checks if ProxyPort property is set
        /// </summary>
        /// <returns>true if ProxyPort property is set</returns>
        internal bool IsSetProxyPort()
        {
            return this.proxyPort >= 0 && this.proxyPort <= 65535;
        }

        /// <summary>
        /// Credentials to use with a proxy.
        /// </summary>
        public ICredentials ProxyCredentials
        {
            get
            {
                ICredentials credentials = this.proxyCredentials;
                if (credentials == null && this.IsSetProxyUsername())
                {
                    credentials = new NetworkCredential(this.proxyUsername, this.proxyPassword ?? String.Empty);
                }
                return credentials;
            }
            set { this.proxyCredentials = value; }
        }

        /// <summary>
        /// Sets the ProxyCredentials property.
        /// </summary>
        /// <param name="proxyCredentials">ProxyCredentials property</param>
        /// <returns>this instance</returns>
        public AmazonCloudFrontConfig WithProxyCredentials(ICredentials proxyCredentials)
        {
            this.proxyCredentials = proxyCredentials;
            return this;
        }

        /// <summary>
        /// Checks if ProxyCredentials property is set
        /// </summary>
        /// <returns>true if ProxyCredentials property is set</returns>
        internal bool IsSetProxyCredentials()
        {
            return (this.ProxyCredentials != null);
        }

        /// <summary>
        /// Gets and sets of the MaxErrorRetry property.
        /// </summary>
        public int MaxErrorRetry
        {
            get { return this.maxErrorRetry; }
            set { this.maxErrorRetry = value; }
        }

        /// <summary>
        /// Sets the MaxErrorRetry property
        /// </summary>
        /// <param name="maxErrorRetry">MaxErrorRetry property</param>
        /// <returns>this instance</returns>
        public AmazonCloudFrontConfig WithMaxErrorRetry(int maxErrorRetry)
        {
            this.maxErrorRetry = maxErrorRetry;
            return this;
        }

        /// <summary>
        /// Checks if MaxErrorRetry property is set
        /// </summary>
        /// <returns>true if MaxErrorRetry property is set</returns>
        internal bool IsSetMaxErrorRetry()
        {
            return this.maxErrorRetry >= 0;
        }

        /// <summary>
        /// Gets and Sets the UseSecureString property. 
        /// By default, the AWS Secret Access Key is stored
        /// in a SecureString (true) - this is one of the secure
        /// ways to store a secret provided by the .NET Framework.
        /// But, the use of SecureStrings is not supported in Medium 
        /// Trust Windows Hosting environments. If you are building an
        /// ASP.NET application that needs to run with Medium Trust,
        /// set this property to false, and the client will
        /// not save your AWS Secret Key in a secure string. Changing
        /// the default to false can result in the Secret Key being
        /// vulnerable; please use this property judiciously.
        /// </summary>
        /// <remarks>Storing the AWS Secret Access Key is not
        /// recommended unless absolutely necessary.
        /// </remarks>
        /// <seealso cref="T:System.Security.SecureString"/>
        public bool UseSecureStringForAwsSecretKey
        {
            get { return this.fUseSecureString; }
            set { this.fUseSecureString = value; }
        }

        /// <summary>
        /// Sets the UseSecureString property. 
        /// By default, the AWS Secret Access Key is stored
        /// in a SecureString (true) - this is one of the secure
        /// ways to store a secret provided by the .NET Framework.
        /// But, the use of SecureStrings is not supported in Medium 
        /// Trust Windows Hosting environments. If you are building an
        /// ASP.NET application that needs to run with Medium Trust,
        /// set this property to false, and the client will
        /// not save your AWS Secret Key in a secure string. Changing
        /// the default to false can result in the Secret Key being
        /// vulnerable; please use this property judiciously.
        /// </summary>
        /// <param name="fSecure">
        /// Whether a secure string should be used or not.
        /// </param>
        /// <returns>The Config object with the property set</returns>
        /// <remarks>Storing the AWS Secret Access Key is not
        /// recommended unless absolutely necessary.
        /// </remarks>
        /// <seealso cref="T:System.Security.SecureString"/>
        public AmazonCloudFrontConfig WithUseSecureStringForAwsSecretKey(bool fSecure)
        {
            fUseSecureString = fSecure;
            return this;
        }

        /// <summary>
        /// Gets and sets the ProxyUsername property.
        /// Used in conjunction with the ProxyPassword
        /// property to authenticate requests with the
        /// specified Proxy server.
        /// </summary>
        [Obsolete("Use ProxyCredentials instead")]
        public string ProxyUsername
        {
            get { return this.proxyUsername; }
            set { this.proxyUsername = value; }
        }

        /// <summary>
        /// Sets the ProxyUsername property
        /// </summary>
        /// <param name="userName">Value for the ProxyUsername property</param>
        /// <returns>this instance</returns>
        [Obsolete("Use WithProxyCredentials instead")]
        public AmazonCloudFrontConfig WithProxyUsername(string userName)
        {
            this.proxyUsername = userName;
            return this;
        }

        /// <summary>
        /// Checks if ProxyUsername property is set
        /// </summary>
        /// <returns>true if ProxyUsername property is set</returns>
        internal bool IsSetProxyUsername()
        {
            return !System.String.IsNullOrEmpty(this.proxyUsername);
        }

        /// <summary>
        /// Gets and sets the ProxyPassword property.
        /// Used in conjunction with the ProxyUsername
        /// property to authenticate requests with the
        /// specified Proxy server.
        /// </summary>
        /// <remarks>
        /// If this property isn't set, String.Empty is used as
        /// the proxy password. This property isn't
        /// used if ProxyUsername is null or empty.
        /// </remarks>
        [Obsolete("Use ProxyCredentials instead")]
        public string ProxyPassword
        {
            get { return this.proxyPassword; }
            set { this.proxyPassword = value; }
        }

        /// <summary>
        /// Sets the ProxyPassword property.
        /// Used in conjunction with the ProxyUsername
        /// property to authenticate requests with the
        /// specified Proxy server.
        /// </summary>
        /// <remarks>
        /// If this property isn't set, String.Empty is used as
        /// the proxy password. This property isn't
        /// used if ProxyUsername is null or empty.
        /// </remarks>
        /// <param name="password">ProxyPassword property</param>
        /// <returns>this instance</returns>
        [Obsolete("Use WithProxyCredentials instead")]
        public AmazonCloudFrontConfig WithProxyPassword(string password)
        {
            this.proxyPassword = password;
            return this;
        }

        /// <summary>
        /// Checks if ProxyPassword property is set
        /// </summary>
        /// <returns>true if ProxyPassword property is set</returns>
        internal bool IsSetProxyPassword()
        {
            return !System.String.IsNullOrEmpty(this.proxyPassword);
        }

        /// <summary>
        /// Gets and sets the connection limit set on the ServicePoint for the WebRequest.
        /// Default value is 50 connections unless ServicePointManager.DefaultConnectionLimit is set in 
        /// which case ServicePointManager.DefaultConnectionLimit will be used as the default.
        /// </summary>
        public int ConnectionLimit
        {
            get { return AWSSDKUtils.GetConnectionLimit(this.connectionLimit); }
            set { this.connectionLimit = value; }
        }
    }
}