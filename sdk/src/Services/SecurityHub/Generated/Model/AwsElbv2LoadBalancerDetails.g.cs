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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a load balancer.
    /// </summary>
    public partial class AwsElbv2LoadBalancerDetails
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones for the load balancer.
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
        /// Indicates when the load balancer was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime != null;

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
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The type of IP addresses used by the subnets for your load balancer. The possible
        /// values are <c>ipv4</c> (for IPv4 addresses) and <c>dualstack</c> (for IPv4 and IPv6
        /// addresses).
        /// </para>
        /// </summary>
        public string IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerAttributes. 
        /// <para>
        /// Attributes of the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElbv2LoadBalancerAttribute> LoadBalancerAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsElbv2LoadBalancerAttribute>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancerAttributes property is set.
        /// </summary>
        internal bool IsSetLoadBalancerAttributes() => this.LoadBalancerAttributes != null && (this.LoadBalancerAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scheme. 
        /// <para>
        /// The nodes of an Internet-facing load balancer have public IP addresses.
        /// </para>
        /// </summary>
        public string Scheme { get; set; }

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
        public string Type { get; set; }

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
