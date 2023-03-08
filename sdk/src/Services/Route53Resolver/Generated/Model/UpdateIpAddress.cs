/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Provides information about the IP address type in response to <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_UpdateResolverEndpoint.html">UpdateResolverEndpoint</a>.
    /// </summary>
    public partial class UpdateIpAddress
    {
        private string _ipId;
        private string _ipv6;

        /// <summary>
        /// Gets and sets the property IpId. 
        /// <para>
        ///  The ID of the IP address, specified by the <code>ResolverEndpointId</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string IpId
        {
            get { return this._ipId; }
            set { this._ipId = value; }
        }

        // Check to see if IpId property is set
        internal bool IsSetIpId()
        {
            return this._ipId != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6. 
        /// <para>
        ///  The IPv6 address that you want to use for DNS queries. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=39)]
        public string Ipv6
        {
            get { return this._ipv6; }
            set { this._ipv6 = value; }
        }

        // Check to see if Ipv6 property is set
        internal bool IsSetIpv6()
        {
            return this._ipv6 != null;
        }

    }
}