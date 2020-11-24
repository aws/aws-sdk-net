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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the SetSubnets operation.
    /// Enables the Availability Zones for the specified public subnets for the specified
    /// Application Load Balancer or Network Load Balancer. The specified subnets replace
    /// the previously enabled subnets.
    /// 
    ///  
    /// <para>
    /// When you specify subnets for a Network Load Balancer, you must include all subnets
    /// that were enabled previously, with their existing configurations, plus any additional
    /// subnets.
    /// </para>
    /// </summary>
    public partial class SetSubnetsRequest : AmazonElasticLoadBalancingV2Request
    {
        private IpAddressType _ipAddressType;
        private string _loadBalancerArn;
        private List<SubnetMapping> _subnetMappings = new List<SubnetMapping>();
        private List<string> _subnets = new List<string>();

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// [Network Load Balancers] The type of IP addresses used by the subnets for your load
        /// balancer. The possible values are <code>ipv4</code> (for IPv4 addresses) and <code>dualstack</code>
        /// (for IPv4 and IPv6 addresses). You can’t specify <code>dualstack</code> for a load
        /// balancer with a UDP or TCP_UDP listener. Internal load balancers must use <code>ipv4</code>.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoadBalancerArn
        {
            get { return this._loadBalancerArn; }
            set { this._loadBalancerArn = value; }
        }

        // Check to see if LoadBalancerArn property is set
        internal bool IsSetLoadBalancerArn()
        {
            return this._loadBalancerArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetMappings. 
        /// <para>
        /// The IDs of the public subnets. You can specify only one subnet per Availability Zone.
        /// You must specify either subnets or subnet mappings.
        /// </para>
        ///  
        /// <para>
        /// [Application Load Balancers] You must specify subnets from at least two Availability
        /// Zones. You cannot specify Elastic IP addresses for your subnets.
        /// </para>
        ///  
        /// <para>
        /// [Application Load Balancers on Outposts] You must specify one Outpost subnet.
        /// </para>
        ///  
        /// <para>
        /// [Application Load Balancers on Local Zones] You can specify subnets from one or more
        /// Local Zones.
        /// </para>
        ///  
        /// <para>
        /// [Network Load Balancers] You can specify subnets from one or more Availability Zones.
        /// You can specify one Elastic IP address per subnet if you need static IP addresses
        /// for your internet-facing load balancer. For internal load balancers, you can specify
        /// one private IP address per subnet from the IPv4 range of the subnet. For internet-facing
        /// load balancer, you can specify one IPv6 address per subnet.
        /// </para>
        /// </summary>
        public List<SubnetMapping> SubnetMappings
        {
            get { return this._subnetMappings; }
            set { this._subnetMappings = value; }
        }

        // Check to see if SubnetMappings property is set
        internal bool IsSetSubnetMappings()
        {
            return this._subnetMappings != null && this._subnetMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The IDs of the public subnets. You can specify only one subnet per Availability Zone.
        /// You must specify either subnets or subnet mappings.
        /// </para>
        ///  
        /// <para>
        /// [Application Load Balancers] You must specify subnets from at least two Availability
        /// Zones.
        /// </para>
        ///  
        /// <para>
        /// [Application Load Balancers on Outposts] You must specify one Outpost subnet.
        /// </para>
        ///  
        /// <para>
        /// [Application Load Balancers on Local Zones] You can specify subnets from one or more
        /// Local Zones.
        /// </para>
        ///  
        /// <para>
        /// [Network Load Balancers] You can specify subnets from one or more Availability Zones.
        /// </para>
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

    }
}