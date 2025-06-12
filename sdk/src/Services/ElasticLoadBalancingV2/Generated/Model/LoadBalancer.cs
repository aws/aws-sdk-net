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
    /// Information about a load balancer.
    /// </summary>
    public partial class LoadBalancer
    {
        private List<AvailabilityZone> _availabilityZones = AWSConfigs.InitializeCollections ? new List<AvailabilityZone>() : null;
        private string _canonicalHostedZoneId;
        private DateTime? _createdTime;
        private string _customerOwnedIpv4Pool;
        private string _dnsName;
        private EnablePrefixForIpv6SourceNatEnum _enablePrefixForIpv6SourceNat;
        private string _enforceSecurityGroupInboundRulesOnPrivateLinkTraffic;
        private IpAddressType _ipAddressType;
        private IpamPools _ipamPools;
        private string _loadBalancerArn;
        private string _loadBalancerName;
        private LoadBalancerSchemeEnum _scheme;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private LoadBalancerState _state;
        private LoadBalancerTypeEnum _type;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The subnets for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CanonicalHostedZoneId. 
        /// <para>
        /// The ID of the Amazon Route 53 hosted zone associated with the load balancer.
        /// </para>
        /// </summary>
        public string CanonicalHostedZoneId
        {
            get { return this._canonicalHostedZoneId; }
            set { this._canonicalHostedZoneId = value; }
        }

        // Check to see if CanonicalHostedZoneId property is set
        internal bool IsSetCanonicalHostedZoneId()
        {
            return this._canonicalHostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time the load balancer was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// [Application Load Balancers on Outposts] The ID of the customer-owned address pool.
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
        /// Gets and sets the property DNSName. 
        /// <para>
        /// The public DNS name of the load balancer.
        /// </para>
        /// </summary>
        public string DNSName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DNSName property is set
        internal bool IsSetDNSName()
        {
            return this._dnsName != null;
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
        /// Gets and sets the property EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic. 
        /// <para>
        /// Indicates whether to evaluate inbound security group rules for traffic sent to a Network
        /// Load Balancer through Amazon Web Services PrivateLink.
        /// </para>
        /// </summary>
        public string EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
        {
            get { return this._enforceSecurityGroupInboundRulesOnPrivateLinkTraffic; }
            set { this._enforceSecurityGroupInboundRulesOnPrivateLinkTraffic = value; }
        }

        // Check to see if EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic property is set
        internal bool IsSetEnforceSecurityGroupInboundRulesOnPrivateLinkTraffic()
        {
            return this._enforceSecurityGroupInboundRulesOnPrivateLinkTraffic != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The type of IP addresses used for public or private connections by the subnets attached
        /// to your load balancer.
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
        /// [Application Load Balancers] The IPAM pool in use by the load balancer, if configured.
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
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
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
        /// The IDs of the security groups for the load balancer.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the load balancer.
        /// </para>
        /// </summary>
        public LoadBalancerState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of load balancer.
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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC for the load balancer.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}