/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Text;

using Amazon.Runtime.Internal.Auth;
using Amazon.Util;
using System.Configuration;
using System.Collections.Specialized;
using System.Net;

namespace Amazon.Runtime
{
    /// <summary>
    /// This class is the base class of all the configurations settings to connect
    /// to a service.
    /// </summary>
    public abstract class ClientConfig
    {
        private RegionEndpoint regionEndpoint;

        private string serviceURL = "https://elasticloadbalancing.amazonaws.com/";
        private string authRegion = null;
        private string authServiceName = null;
        private string userAgent = Amazon.Util.AWSSDKUtils.SDKUserAgent;
        private string signatureVersion = "2";
        private SigningAlgorithm signatureMethod = SigningAlgorithm.HmacSHA256;
        private string proxyHost;
        private int proxyPort = -1;
        private int maxErrorRetry = 4;
        private bool fUseSecureString = true;
        private string proxyUsername;
        private string proxyPassword;
        private bool readEntireResponse = false;
        private bool logResponse = false;
        private int? connectionLimit;
        private bool useNagleAlgorithm = false;
        private int bufferSize = Amazon.S3.Util.S3Constants.DefaultBufferSize;
        private bool resignRetries = false;
        private ICredentials proxyCredentials;
        private bool logMetrics = AWSConfigs.LogMetrics;
        private bool disableLogging = false;

        /// <summary>
        /// Gets Service Version
        /// </summary>
        public abstract string ServiceVersion
        {
            get;
        }

        /// <summary>
        /// Gets and sets of the signatureMethod property.
        /// </summary>
        public SigningAlgorithm SignatureMethod
        {
            get { return this.signatureMethod; }
            set { this.signatureMethod = value; }
        }

        /// <summary>
        /// Gets and sets of the SignatureVersion property.
        /// </summary>
        public string SignatureVersion
        {
            get { return this.signatureVersion; }
            set { this.signatureVersion = value; }
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
        /// Gets and sets the RegionEndpoint property.  The region constant to use that 
        /// determines the endpoint to use.  If this is not set
        /// then the client will fallback to the value of ServiceURL.
        /// </summary>
        public RegionEndpoint RegionEndpoint
        {
            get
            {
                return regionEndpoint;
            }
            set
            {
                this.regionEndpoint = value;
            }
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        internal abstract string RegionEndpointServiceName
        {
            get;
        }

        /// <summary>
        /// Gets and sets of the ServiceURL property.
        /// This is an optional property; change it
        /// only if you want to try a different service
        /// endpoint or want to switch between https and http.
        /// </summary>
        public string ServiceURL
        {
            get { return this.serviceURL; }
            set { this.serviceURL = value; }
        }

        internal string DetermineServiceURL()
        {
            string url;
            if (this.RegionEndpoint == null)
            {
                url = this.ServiceURL;
            }
            else
            {
                var endpoint = this.RegionEndpoint.GetEndpointForService(this.RegionEndpointServiceName);
                string protocol = endpoint.HTTPS ? "https://" : "http://";
                url = new Uri(string.Format("{0}{1}", protocol, endpoint.Hostname)).AbsoluteUri;
            }

            return url;
        }

        /// <summary>
        /// Gets and sets the AuthenticationRegion property.
        /// Used in AWS4 request signing, this is an optional property; 
        /// change it only if the region cannot be determined from the 
        /// service endpoint.
        /// </summary>
        public string AuthenticationRegion
        {
            get { return this.authRegion; }
            set { this.authRegion = value; }
        }

        /// <summary>
        /// Gets and sets the AuthenticationServiceName property.
        /// Used in AWS4 request signing, this is the short-form
        /// name of the service being called.
        /// </summary>
        public string AuthenticationServiceName
        {
            get { return this.authServiceName; }
            set { this.authServiceName = value; }
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
        /// Gets and sets of the ProxyPort property.
        /// </summary>
        public int ProxyPort
        {
            get { return this.proxyPort; }
            set { this.proxyPort = value; }
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
        /// Gets and Sets the UseSecureStringForAwsSecretKey property.
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
        /// Credentials to use with a proxy.
        /// </summary>
        public ICredentials ProxyCredentials
        {
            get
            {
                ICredentials credentials = this.proxyCredentials;
                if (credentials == null && !string.IsNullOrEmpty(this.proxyUsername))
                {
                    credentials = new NetworkCredential(this.proxyUsername, this.proxyPassword ?? String.Empty);
                }
                return credentials;
            }
            set { this.proxyCredentials = value; }
        }

        /// <summary>
        /// Gets and sets the LogResponse.
        /// If this property is set to true, the service response
        /// is read in its entirety and logged.
        /// </summary>
        public bool LogResponse
        {
            get { return this.logResponse; }
            set { this.logResponse = value; }
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

        /// <summary>
        /// Gets or sets a Boolean value that determines whether the Nagle algorithm is used on connections managed by the ServicePoint object used
        /// for requests to AWS.  This is defaulted to false for lower latency with responses that return small amount of data.  This is the opposite 
        /// default then ServicePoint.UseNagleAlgorithm which is optimized for large responses like web pages or images.
        /// </summary>
        public bool UseNagleAlgorithm
        {
            get { return this.useNagleAlgorithm; }
            set { this.useNagleAlgorithm = value; }
        }

        /// <summary>
        /// Gets and sets the ReadEntireResponse.
        /// If this property is set to true, the service response
        /// is read in its entirety before being processed.
        /// </summary>
        public bool ReadEntireResponse
        {
            get { return this.readEntireResponse; }
            set { this.readEntireResponse = value; }
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

        /// <summary>
        /// Flag on whether to resign requests on retry or not.
        /// </summary>
        internal bool ResignRetries
        {
            get { return this.resignRetries; }
            set { this.resignRetries = value; }
        }

        /// <summary>
        /// Flag on whether to log metrics for service calls.
        /// 
        /// This can be set in the application's configs, as below:
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSLogMetrics" value"true"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        public bool LogMetrics
        {
            get { return this.logMetrics; }
            set { this.logMetrics = value; }
        }

        /// <summary>
        /// Flag on whether to completely disable logging for this client or not.
        /// </summary>
        internal bool DisableLogging
        {
            get { return this.disableLogging; }
            set { this.disableLogging = value; }
        }
    }
}
