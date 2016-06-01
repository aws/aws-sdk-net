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
using System.Net;
using Amazon.Util;
using System.Globalization;

namespace Amazon.Runtime
{
    /// <summary>
    /// This class is the base class of all the configurations settings to connect
    /// to a service.
    /// </summary>    
    public abstract partial class ClientConfig
    {
        private string proxyHost;
        private int proxyPort = -1;
        private int? connectionLimit;
        private int? maxIdleTime;
        private bool useNagleAlgorithm = false;
        private TimeSpan? readWriteTimeout = null;
        
        private static RegionEndpoint GetDefaultRegionEndpoint()
        {
            return FallbackRegionFactory.GetRegionEndpoint();
        }

        /// <summary>
        /// Gets and sets of the ProxyHost property.
        /// </summary>
        public string ProxyHost
        {
            get 
            {
                if (string.IsNullOrEmpty(this.proxyHost))
                    return AWSConfigs.ProxyConfig.Host;

                return this.proxyHost; 
            }
            set { this.proxyHost = value; }
        }


        /// <summary>
        /// Gets and sets of the ProxyPort property.
        /// </summary>
        public int ProxyPort
        {
            get 
            {
                if (this.proxyPort <= 0)
                    return AWSConfigs.ProxyConfig.Port.GetValueOrDefault();

                return this.proxyPort; 
            }
            set { this.proxyPort = value; }
        }

        /// <summary>
        /// Returns a WebProxy instance configured to match the proxy settings
        /// in the client configuration.
        /// </summary>
        public WebProxy GetWebProxy()
        {
            WebProxy proxy = null;
            if (!string.IsNullOrEmpty(ProxyHost) && ProxyPort > 0)
            {
                proxy = new WebProxy(ProxyHost, ProxyPort);
            }
            if (proxy != null && ProxyCredentials != null)
            {
                proxy.Credentials = ProxyCredentials;
            }

            return proxy;
        }

        /// <summary>
        /// Unpacks the host, port and any credentials info into the instance's
        /// proxy-related fields.
        /// </summary>
        /// <param name="proxy">The proxy details</param>
        public void SetWebProxy(WebProxy proxy)
        {
            if (proxy == null)
                throw new ArgumentNullException("proxy");

            var address = proxy.Address;
            ProxyHost = string.Format(CultureInfo.InvariantCulture, "{0}://{1}", address.Scheme, address.Host);
            ProxyPort = address.Port;
            ProxyCredentials = proxy.Credentials;
        }

        /// <summary>
        /// Gets and sets the max idle time set on the ServicePoint for the WebRequest.
        /// Default value is 50 seconds (50,000 ms) unless ServicePointManager.MaxServicePointIdleTime is set,
        /// in which case ServicePointManager.MaxServicePointIdleTime will be used as the default.
        /// </summary>
        public int MaxIdleTime
        {
            get { return AWSSDKUtils.GetMaxIdleTime(this.maxIdleTime); }
            set { this.maxIdleTime = value; }
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
        /// for requests to AWS. This is defaulted to false for lower latency with responses that return small amount of data. This is the opposite
        /// default than ServicePoint.UseNagleAlgorithm which is optimized for large responses like web pages or images.
        /// </summary>
        public bool UseNagleAlgorithm
        {
            get { return this.useNagleAlgorithm; }
            set { this.useNagleAlgorithm = value; }
        }

        /// <summary>
        /// Overrides the default read-write timeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the value is set, the value is assigned to the ReadWriteTimeout property of the HTTPWebRequest/WebRequestHandler object used
        /// to send requests.
        /// </para>
        /// <exception cref="System.ArgumentNullException">The timeout specified is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not Infinite.</exception>
        /// </remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.Http.WebRequestHandler.ReadWriteTimeout"/>
        public TimeSpan? ReadWriteTimeout
        {
            get { return this.readWriteTimeout; }
            set
            {
                ValidateTimeout(value);
                this.readWriteTimeout = value;
            }
        }
    }
}
