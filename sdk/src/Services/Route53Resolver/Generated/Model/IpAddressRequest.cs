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
    /// In a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverEndpoint.html">CreateResolverEndpoint</a>
    /// request, the IP address that DNS queries originate from (for outbound endpoints) or
    /// that you forward DNS queries to (for inbound endpoints). <code>IpAddressRequest</code>
    /// also includes the ID of the subnet that contains the IP address.
    /// </summary>
    public partial class IpAddressRequest
    {
        private string _ip;
        private string _ipv6;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// The IPv4 address that you want to use for DNS queries.
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
        /// Gets and sets the property Ipv6. 
        /// <para>
        ///  The IPv6 address that you want to use for DNS queries. 
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
        /// The ID of the subnet that contains the IP address. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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