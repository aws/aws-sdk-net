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
        private IWebProxy _proxy;
        
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
            return this._proxy;
        }

        /// <summary>
        /// Unpacks the host, port and any credentials info into the instance's
        /// proxy-related fields.
        /// </summary>
        /// <param name="proxy">The proxy details</param>
        public void SetWebProxy(IWebProxy proxy)
        {
            this._proxy = proxy;
        }


    }
}
