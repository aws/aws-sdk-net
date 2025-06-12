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
    /// Container for the parameters to the CreateLoadBalancer operation.
    /// Creates an Application Load Balancer, Network Load Balancer, or Gateway Load Balancer.
    /// 
    ///  
    /// <para>
    /// For more information, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/application-load-balancers.html">Application
    /// Load Balancers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/network-load-balancers.html">Network
    /// Load Balancers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/gateway-load-balancers.html">Gateway
    /// Load Balancers</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation is idempotent, which means that it completes at most one time. If you
    /// attempt to create multiple load balancers with the same settings, each call succeeds.
    /// </para>
    /// </summary>
    public partial class CreateLoadBalancerRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _customerOwnedIpv4Pool;
        private EnablePrefixForIpv6SourceNatEnum _enablePrefixForIpv6SourceNat;
        private IpAddressType _ipAddressType;
        private IpamPools _ipamPools;
        private string _name;
        private LoadBalancerSchemeEnum _scheme;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<SubnetMapping> _subnetMappings = AWSConfigs.InitializeCollections ? new List<SubnetMapping>() : null;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private LoadBalancerTypeEnum _type;

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// [Application Load Balancers on Outposts] The ID of the customer-owned address pool
        /// (CoIP pool).
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string CustomerOwnedIpv4Pool
        {
            get { return this._customerOwnedIpv4Pool; }
            set { this._customerOwnedIpv4Pool = value; }
        }

        // Check to see if CustomerOwnedIpv4Pool property is set
        internal bool IsSetCustomerOwnedIpv4Pool()
        {
            return this._customerOwnedIpv4Pool != null;
        }

        /// <summary>
        /// Gets and sets the property EnablePrefixForIpv6SourceNat. 
        /// <para>
        /// [Network Load Balancers with UDP listeners] Indicates whether to use an IPv6 prefix
        /// from each subnet for source NAT. The IP address type must be <c>dualstack</c>. The
        /// default value is <c>off</c>.
        /// </para>
        /// </summary>
        public EnablePrefixForIpv6SourceNatEnum EnablePrefixForIpv6SourceNat
        {
            get { return this._enablePrefixForIpv6SourceNat; }
            set { this._enablePrefixForIpv6SourceNat = value; }
        }

        // Check to see if EnablePrefixForIpv6SourceNat property is set
        internal bool IsSetEnablePrefixForIpv6SourceNat()
        {
            return this._enablePrefixForIpv6SourceNat != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type. Internal load balancers must use <c>ipv4</c>.
        /// </para>
        ///  
        /// <para>
        /// [Application Load Balancers] The possible values are <c>ipv4</c> (IPv4 addresses),
        /// <c>dualstack</c> (IPv4 and IPv6 addresses), and <c>dualstack-without-public-ipv4</c>
        /// (public IPv6 addresses and private IPv4 and IPv6 addresses).
        /// </para>
        ///  
        /// <para>
        /// [Network Load Balancers and Gateway Load Balancers] The possible values are <c>ipv4</c>
        /// (IPv4 addresses) and <c>dualstack</c> (IPv4 and IPv6 addresses).
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
        /// Gets and sets the property IpamPools. 
        /// <para>
        /// [Application Load Balancers] The IPAM pools to use with the load balancer.
        /// </para>
        /// </summary>
        public IpamPools IpamPools
        {
            get { return this._ipamPools; }
            set { this._ipamPools = value; }
        }

        // Check to see if IpamPools property is set
        internal bool IsSetIpamPools()
        {
            return this._ipamPools != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        ///  
        /// <para>
        /// This name must be unique per region per account, can have a maximum of 32 characters,
        /// must contain only alphanumeric characters or hyphens, must not begin or end with a
        /// hyphen, and must not begin with "internal-".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Scheme. 
        /// <para>
        /// The nodes of an Internet-facing load balancer have public IP addresses. The DNS name
        /// of an Internet-facing load balancer is publicly resolvable to the public IP addresses
        /// of the nodes. Therefore, Internet-facing load balancers can route requests from clients
        /// over the internet.
        /// </para>
        ///  
        /// <para>
        /// The nodes of an internal load balancer have only private IP addresses. The DNS name
        /// of an internal load balancer is publicly resolvable to the private IP addresses of
        /// the nodes. Therefore, internal load balancers can route requests only from clients
        /// with access to the VPC for the load balancer.
        /// </para>
        ///  
        /// <para>
        /// The default is an Internet-facing load balancer.
        /// </para>
        ///  
        /// <para>
        /// You can't specify a scheme for a Gateway Load Balancer.
        /// </para>
        /// </summary>
        public LoadBalancerSchemeEnum Scheme
        {
            get { return this._scheme; }
            set { this._scheme = value; }
        }

        // Check to see if Scheme property is set
        internal bool IsSetScheme()
        {
            return this._scheme != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// [Application Load Balancers and Network Load Balancers] The IDs of the security groups
        /// for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetMappings. 
        /// <para>
        /// The IDs of the subnets. You can specify only one subnet per Availability Zone. You
        /// must specify either subnets or subnet mappings, but not both.
        /// </para>
        ///  
        /// <para>
        /// [Application Load Balancers] You must specify subnets from at least two Availability
        /// Zones. You can't specify Elastic IP addresses for your subnets.
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
        ///  
        /// <para>
        /// [Gateway Load Balancers] You can specify subnets from one or more Availability Zones.
        /// You can't specify Elastic IP addresses for your subnets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubnetMapping> SubnetMappings
        {
            get { return this._subnetMappings; }
            set { this._subnetMappings = value; }
        }

        // Check to see if SubnetMappings property is set
        internal bool IsSetSubnetMappings()
        {
            return this._subnetMappings != null && (this._subnetMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The IDs of the subnets. You can specify only one subnet per Availability Zone. You
        /// must specify either subnets or subnet mappings, but not both. To specify an Elastic
        /// IP address, specify subnet mappings instead of subnets.
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
        /// [Network Load Balancers and Gateway Load Balancers] You can specify subnets from one
        /// or more Availability Zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of load balancer. The default is <c>application</c>.
        /// </para>
        /// </summary>
        public LoadBalancerTypeEnum Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}