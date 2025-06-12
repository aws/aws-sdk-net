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
    /// Information about an Availability Zone.
    /// </summary>
    public partial class AvailabilityZone
    {
        private List<LoadBalancerAddress> _loadBalancerAddresses = AWSConfigs.InitializeCollections ? new List<LoadBalancerAddress>() : null;
        private string _outpostId;
        private List<string> _sourceNatIpv6Prefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subnetId;
        private string _zoneName;

        /// <summary>
        /// Gets and sets the property LoadBalancerAddresses. 
        /// <para>
        /// [Network Load Balancers] If you need static IP addresses for your load balancer, you
        /// can specify one Elastic IP address per Availability Zone when you create an internal-facing
        /// load balancer. For internal load balancers, you can specify a private IP address from
        /// the IPv4 range of the subnet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoadBalancerAddress> LoadBalancerAddresses
        {
            get { return this._loadBalancerAddresses; }
            set { this._loadBalancerAddresses = value; }
        }

        // Check to see if LoadBalancerAddresses property is set
        internal bool IsSetLoadBalancerAddresses()
        {
            return this._loadBalancerAddresses != null && (this._loadBalancerAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// [Application Load Balancers on Outposts] The ID of the Outpost.
        /// </para>
        /// </summary>
        public string OutpostId
        {
            get { return this._outpostId; }
            set { this._outpostId = value; }
        }

        // Check to see if OutpostId property is set
        internal bool IsSetOutpostId()
        {
            return this._outpostId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceNatIpv6Prefixes. 
        /// <para>
        /// [Network Load Balancers with UDP listeners] The IPv6 prefixes to use for source NAT.
        /// For each subnet, specify an IPv6 prefix (/80 netmask) from the subnet CIDR block or
        /// <c>auto_assigned</c> to use an IPv6 prefix selected at random from the subnet CIDR
        /// block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceNatIpv6Prefixes
        {
            get { return this._sourceNatIpv6Prefixes; }
            set { this._sourceNatIpv6Prefixes = value; }
        }

        // Check to see if SourceNatIpv6Prefixes property is set
        internal bool IsSetSourceNatIpv6Prefixes()
        {
            return this._sourceNatIpv6Prefixes != null && (this._sourceNatIpv6Prefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet. You can specify one subnet per Availability Zone.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ZoneName. 
        /// <para>
        /// The name of the Availability Zone.
        /// </para>
        /// </summary>
        public string ZoneName
        {
            get { return this._zoneName; }
            set { this._zoneName = value; }
        }

        // Check to see if ZoneName property is set
        internal bool IsSetZoneName()
        {
            return this._zoneName != null;
        }

    }
}