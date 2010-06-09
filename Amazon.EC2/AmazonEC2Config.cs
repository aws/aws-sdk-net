/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-30
 */

namespace Amazon.EC2
{
    /// <summary>
    /// Configuration for accessing Amazon EC2  service
    /// </summary>
    public class AmazonEC2Config
    {
        private string serviceVersion = "2009-11-30";
        private string serviceURL = "https://ec2.amazonaws.com";
        private string userAgent = Amazon.Util.AWSSDKUtils.SDKUserAgent;
        private string signatureVersion = "2";
        private string signatureMethod = "HmacSHA256";
        private string proxyHost = null;
        private int proxyPort = -1;
        private int maxErrorRetry = 3;

        /// <summary>
        /// Gets Service Version
        /// </summary>
        public string ServiceVersion
        {
            get { return this.serviceVersion; }
        }
        /// <summary>
        /// Gets and sets of the signatureMethod property.
        /// </summary>
        public string SignatureMethod
        {
            get { return this.signatureMethod; }
            set { this.signatureMethod = value; }
        }

        /// <summary>
        /// Sets the SignatureMethod property
        /// </summary>
        /// <param name="signatureMethod">SignatureMethod property</param>
        /// <returns>this instance</returns>
        public AmazonEC2Config WithSignatureMethod(string signatureMethod)
        {
            this.signatureMethod = signatureMethod;
            return this;
        }

        /// <summary>
        /// Checks if SignatureMethod property is set
        /// </summary>
        /// <returns>true if SignatureMethod property is set</returns>
        public bool IsSetSignatureMethod()
        {
            return this.signatureMethod != null;
        }
        /// <summary>
        /// Gets and sets of the SignatureVersion property.
        /// </summary>
        public string SignatureVersion
        {
            get { return this.signatureVersion ; }
            set { this.signatureVersion = value; }
        }

        /// <summary>
        /// Sets the SignatureVersion property
        /// </summary>
        /// <param name="signatureVersion">SignatureVersion property</param>
        /// <returns>this instance</returns>
        public AmazonEC2Config WithSignatureVersion(string signatureVersion)
        {
            this.signatureVersion = signatureVersion;
            return this;
        }

        /// <summary>
        /// Checks if SignatureVersion property is set
        /// </summary>
        /// <returns>true if SignatureVersion property is set</returns>
        public bool IsSetSignatureVersion()
        {
            return this.signatureVersion != null;
        }

        /// <summary>
        /// Gets and sets of the UserAgent property.
        /// </summary>
        public string UserAgent
        {
            get { return this.userAgent ; }
            set { this.userAgent = value; }
        }

        /// <summary>
        /// Sets the UserAgent property
        /// </summary>
        /// <param name="userAgent">UserAgent property</param>
        /// <returns>this instance</returns>
        public AmazonEC2Config WithUserAgent(string userAgent)
        {
            this.userAgent = userAgent;
            return this;
        }

        /// <summary>
        /// Checks if UserAgent property is set
        /// </summary>
        /// <returns>true if UserAgent property is set</returns>
        public bool IsSetUserAgent()
        {
            return this.userAgent != null;
        }

        /// <summary>
        /// Gets and sets of the ServiceURL property.
        /// </summary>
        public string ServiceURL
        {
            get { return this.serviceURL ; }
            set { this.serviceURL = value; }
        }

        /// <summary>
        /// Sets the ServiceURL property
        /// </summary>
        /// <param name="serviceURL">ServiceURL property</param>
        /// <returns>this instance</returns>
        public AmazonEC2Config WithServiceURL(string serviceURL)
        {
            this.serviceURL = serviceURL;
            return this;
        }

        /// <summary>
        /// Checks if ServiceURL property is set
        /// </summary>
        /// <returns>true if ServiceURL property is set</returns>
        public bool IsSetServiceURL()
        {
            return this.serviceURL != null;
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
        public AmazonEC2Config WithProxyHost(string proxyHost)
        {
            this.proxyHost = proxyHost;
            return this;
        }

        /// <summary>
        /// Checks if ProxyHost property is set
        /// </summary>
        /// <returns>true if ProxyHost property is set</returns>
        public bool IsSetProxyHost()
        {
            return this.proxyHost != null;
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
        public AmazonEC2Config WithProxyPort(int proxyPort)
        {
            this.proxyPort = proxyPort;
            return this;
        }

        /// <summary>
        /// Checks if ProxyPort property is set
        /// </summary>
        /// <returns>true if ProxyPort property is set</returns>
        public bool IsSetProxyPort()
        {
            return this.proxyPort >= 0;
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
        public AmazonEC2Config WithMaxErrorRetry(int maxErrorRetry)
        {
            this.maxErrorRetry = maxErrorRetry;
            return this;
        }

        /// <summary>
        /// Checks if MaxErrorRetry property is set
        /// </summary>
        /// <returns>true if MaxErrorRetry property is set</returns>
        public bool IsSetMaxErrorRetry()
        {
            return this.maxErrorRetry >= 0;
        }
    }
}
