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
    /// In an <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_UpdateResolverEndpoint.html">UpdateResolverEndpoint</a>
    /// request, information about an IP address to update.
    /// </summary>
    public partial class IpAddressUpdate
    {
        private string _ip;
        private string _ipId;
        private string _ipv6;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// The new IPv4 address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=36)]
        public string Ip
        {
            get { return this._ip; }
            set { this._ip = value; }
        }

        // Check to see if Ip property is set
        internal bool IsSetIp()
        {
            return this._ip != null;
        }

        /// <summary>
        /// Gets and sets the property IpId. 
        /// <para>
        ///  <i>Only when removing an IP address from a Resolver endpoint</i>: The ID of the IP
        /// address that you want to remove. To get this ID, use <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverEndpoint.html">GetResolverEndpoint</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        ///  The new IPv6 address. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=39)]
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

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet that includes the IP address that you want to update. To get
        /// this ID, use <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverEndpoint.html">GetResolverEndpoint</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

    }
}