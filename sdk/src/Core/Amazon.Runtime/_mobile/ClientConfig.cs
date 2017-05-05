/*
 * Copyright 2010-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Util;
using System.Net.Http;

namespace Amazon.Runtime
{
    /// <summary>
    /// This class is the base class of all the configurations settings to connect
    /// to a service.
    /// </summary>    
    public abstract partial class ClientConfig
    {
        private IWebProxy proxy = null;
        private string proxyHost;
        private int proxyPort = -1;

        private static RegionEndpoint GetDefaultRegionEndpoint()
        {
            return FallbackRegionFactory.GetRegionEndpoint();
        }

        /// <summary>
        /// Returns a WebProxy instance configured to match the proxy settings
        /// in the client configuration.
        /// </summary>
        public IWebProxy GetWebProxy()
        {
            return proxy;
        }

        /// <summary>
        /// Unpacks the host, port and any credentials info into the instance's
        /// proxy-related fields.
        /// Unlike the SetWebProxy implementation on .NET 3.5/4.5,the Host and the Port are not reconstructed from the 
        /// input proxyuri
        /// </summary>
        /// <param name="proxy">The proxy details</param>
        public void SetWebProxy(IWebProxy proxy)
        {
            this.proxy = proxy;
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
            set
            {
                this.proxyHost = value;
                if (this.ProxyPort>0)
                {
                    this.proxy = new Amazon.Runtime.Internal.Util.WebProxy(ProxyHost, ProxyPort);
                }
            }
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
            set
            {
                this.proxyPort = value;
                if (this.ProxyHost!=null)
                {
                    this.proxy = new Amazon.Runtime.Internal.Util.WebProxy(ProxyHost, ProxyPort);
                }
            }
        }

#if CORECLR
        /// <summary>
        /// Get or set the value to use for <see cref="HttpClientHandler.MaxConnectionsPerServer"/> on requests.
        /// If this property is null, <see cref="HttpClientHandler.MaxConnectionsPerServer"/>
        /// will be left at its default value of <see cref="int.MaxValue"/>.
        /// </summary>
        public int? MaxConnectionsPerServer
        {
            get;
            set;
        }
#endif
    }
}
