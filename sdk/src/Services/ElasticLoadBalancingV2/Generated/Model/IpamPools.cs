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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// An IPAM pool is a collection of IP address CIDRs. IPAM pools enable you to organize
    /// your IP addresses according to your routing and security needs.
    /// </summary>
    public partial class IpamPools
    {
        private string _ipv4IpamPoolId;

        /// <summary>
        /// Gets and sets the property Ipv4IpamPoolId. 
        /// <para>
        /// The ID of the IPv4 IPAM pool.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Ipv4IpamPoolId
        {
            get { return this._ipv4IpamPoolId; }
            set { this._ipv4IpamPoolId = value; }
        }

        // Check to see if Ipv4IpamPoolId property is set
        internal bool IsSetIpv4IpamPoolId()
        {
            return this._ipv4IpamPoolId != null;
        }

    }
}