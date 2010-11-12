/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2006-03-01
 *
 */

using Amazon.S3.Model;
using Amazon.S3.Util;

namespace Amazon.S3
{
    /// <summary>
    /// Configuration for Amazon S3 Client.
    /// </summary>
    public class AmazonS3Config
    {
        #region Private Members

        private string serviceURL = S3Constants.S3DefaultEndpoint;
        private string userAgent = Amazon.Util.AWSSDKUtils.SDKUserAgent;
        private string proxyHost;
        private int proxyPort = -1;
        private string proxyUsername;
        private string proxyPassword;
        private int maxErrorRetry = 3;
        private Protocol protocol = Protocol.HTTPS;
        private bool fUseSecureString = true;
        private int bufferSize = S3Constants.DefaultBufferSize;

        #endregion

        /// <summary>
        /// Gets and sets the ServiceURL property.
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
        public AmazonS3Config WithServiceURL(string serviceURL)
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
        /// Gets and sets the UserAgent property.
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
        public AmazonS3Config WithUserAgent(string userAgent)
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
        /// Gets and sets the ProxyHost property.
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
        public AmazonS3Config WithProxyHost(string proxyHost)
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
        /// Gets and sets the ProxyPort property.
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
        public AmazonS3Config WithProxyPort(int proxyPort)
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
            return (ProxyPort > -1 && ProxyPort <= 65535);
        }

        /// <summary>
        /// Gets and sets the ProxyUsername property.
        /// Used in conjunction with the ProxyPassword
        /// property to authenticate requests with the
        /// specified Proxy server.
        /// </summary>
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
        public AmazonS3Config WithProxyUsername(string userName)
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
        public AmazonS3Config WithProxyPassword(string password)
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
        /// Gets and sets the MaxErrorRetry property.
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
        public AmazonS3Config WithMaxErrorRetry(int maxErrorRetry)
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
            return MaxErrorRetry > -1;
        }

        /// <summary>
        /// Gets and Sets the property that determines whether
        /// the HTTP or HTTPS protocol is used to make requests to the
        /// S3 service. By default Protocol.HTTPS is used to 
        /// communicate with S3.
        /// </summary>
        public Protocol CommunicationProtocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        /// <summary>
        /// Sets the Protocol property. Valid values are Protocol.HTTP 
        /// and Protocol.HTTPS. Default is Protocol.HTTPS.
        /// </summary>
        /// <param name="protocol">The protocol to use</param>
        /// <returns>this instance</returns>
        public AmazonS3Config WithCommunicationProtocol(Protocol protocol)
        {
            this.protocol = protocol;
            return this;
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
        public AmazonS3Config WithUseSecureStringForAwsSecretKey(bool fSecure)
        {
            fUseSecureString = fSecure;
            return this;
        }

        /// <summary>
        /// Gets and Sets the BufferSize property.
        /// The BufferSize controls the buffer used to read in from input streams and write 
        /// out to the request.
        /// </summary>
        public int BufferSize
        {
            get { return this.bufferSize; }
            set { this.bufferSize = value; }
        }
    }
}