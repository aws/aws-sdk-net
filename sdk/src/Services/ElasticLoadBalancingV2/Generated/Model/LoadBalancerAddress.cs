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
    /// Information about a static IP address for a load balancer.
    /// </summary>
    public partial class LoadBalancerAddress
    {
        private string _allocationId;
        private string _ipAddress;
        private string _iPv6Address;
        private string _privateIPv4Address;

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// [Network Load Balancers] The allocation ID of the Elastic IP address for an internal-facing
        /// load balancer.
        /// </para>
        /// </summary>
        public string AllocationId
        {
            get { return this._allocationId; }
            set { this._allocationId = value; }
        }

        // Check to see if AllocationId property is set
        internal bool IsSetAllocationId()
        {
            return this._allocationId != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The static IP address.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property IPv6Address. 
        /// <para>
        /// [Network Load Balancers] The IPv6 address.
        /// </para>
        /// </summary>
        public string IPv6Address
        {
            get { return this._iPv6Address; }
            set { this._iPv6Address = value; }
        }

        // Check to see if IPv6Address property is set
        internal bool IsSetIPv6Address()
        {
            return this._iPv6Address != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIPv4Address. 
        /// <para>
        /// [Network Load Balancers] The private IPv4 address for an internal load balancer.
        /// </para>
        /// </summary>
        public string PrivateIPv4Address
        {
            get { return this._privateIPv4Address; }
            set { this._privateIPv4Address = value; }
        }

        // Check to see if PrivateIPv4Address property is set
        internal bool IsSetPrivateIPv4Address()
        {
            return this._privateIPv4Address != null;
        }

    }
}