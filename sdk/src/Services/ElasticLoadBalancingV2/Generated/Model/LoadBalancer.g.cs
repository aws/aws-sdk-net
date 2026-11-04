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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The subnets for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailabilityZone>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CanonicalHostedZoneId. 
        /// <para>
        /// The ID of the Amazon Route 53 hosted zone associated with the load balancer.
        /// </para>
        /// </summary>
        public string CanonicalHostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the CanonicalHostedZoneId property is set.
        /// </summary>
        internal bool IsSetCanonicalHostedZoneId() => this.CanonicalHostedZoneId != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time the load balancer was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// [Application Load Balancers on Outposts] The ID of the customer-owned address pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CustomerOwnedIpv4Pool { get; set; }

        /// <summary>
        /// Checks to see if the CustomerOwnedIpv4Pool property is set.
        /// </summary>
        internal bool IsSetCustomerOwnedIpv4Pool() => this.CustomerOwnedIpv4Pool != null;

        /// <summary>
        /// Gets and sets the property DNSName. 
        /// <para>
        /// The public DNS name of the load balancer.
        /// </para>
        /// </summary>
        public string DNSName { get; set; }

        /// <summary>
        /// Checks to see if the DNSName property is set.
        /// </summary>
        internal bool IsSetDNSName() => this.DNSName != null;

        /// <summary>
        /// Gets and sets the property EnablePrefixForIpv6SourceNat. 
        /// <para>
        /// [Network Load Balancers with UDP listeners] Indicates whether to use an IPv6 prefix
        /// from each subnet for source NAT. The IP address type must be <c>dualstack</c>. The
        /// default value is <c>off</c>.
        /// </para>
        /// </summary>
        public EnablePrefixForIpv6SourceNatEnum EnablePrefixForIpv6SourceNat { get; set; }

        /// <summary>
        /// Checks to see if the EnablePrefixForIpv6SourceNat property is set.
        /// </summary>
        internal bool IsSetEnablePrefixForIpv6SourceNat() => this.EnablePrefixForIpv6SourceNat != null;

        /// <summary>
        /// Gets and sets the property EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic. 
        /// <para>
        /// Indicates whether to evaluate inbound security group rules for traffic sent to a Network
        /// Load Balancer through Amazon Web Services PrivateLink.
        /// </para>
        /// </summary>
        public string EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic { get; set; }

        /// <summary>
        /// Checks to see if the EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic property is set.
        /// </summary>
        internal bool IsSetEnforceSecurityGroupInboundRulesOnPrivateLinkTraffic() => this.EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic != null;

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
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property IpamPools. 
        /// <para>
        /// [Application Load Balancers] The IPAM pool in use by the load balancer, if configured.
        /// </para>
        /// </summary>
        public IpamPools IpamPools { get; set; }

        /// <summary>
        /// Checks to see if the IpamPools property is set.
        /// </summary>
        internal bool IsSetIpamPools() => this.IpamPools != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerArn { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerArn property is set.
        /// </summary>
        internal bool IsSetLoadBalancerArn() => this.LoadBalancerArn != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerName property is set.
        /// </summary>
        internal bool IsSetLoadBalancerName() => this.LoadBalancerName != null;

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
        public LoadBalancerSchemeEnum Scheme { get; set; }

        /// <summary>
        /// Checks to see if the Scheme property is set.
        /// </summary>
        internal bool IsSetScheme() => this.Scheme != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The IDs of the security groups for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the load balancer.
        /// </para>
        /// </summary>
        public LoadBalancerState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of load balancer.
        /// </para>
        /// </summary>
        public LoadBalancerTypeEnum Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC for the load balancer.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
