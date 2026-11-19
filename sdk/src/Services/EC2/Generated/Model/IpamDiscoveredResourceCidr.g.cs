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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// An IPAM discovered resource CIDR. A discovered resource is a resource CIDR monitored
    /// under a resource discovery. The following resources can be discovered: VPCs, Public
    /// IPv4 pools, VPC subnets, and Elastic IP addresses. The discovered resource CIDR is
    /// the IP address range in CIDR notation that is associated with the resource.
    /// </summary>
    public partial class IpamDiscoveredResourceCidr
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property IpSource. 
        /// <para>
        /// The source that allocated the IP address space. <c>byoip</c> or <c>amazon</c> indicates
        /// public IP address space allocated by Amazon or space that you have allocated with
        /// Bring your own IP (BYOIP). <c>none</c> indicates private space.
        /// </para>
        /// </summary>
        public IpamResourceCidrIpSource IpSource { get; set; }

        /// <summary>
        /// Checks to see if the IpSource property is set.
        /// </summary>
        internal bool IsSetIpSource() => this.IpSource != null;

        /// <summary>
        /// Gets and sets the property IpUsage. 
        /// <para>
        /// The percentage of IP address space in use. To convert the decimal to a percentage,
        /// multiply the decimal by 100. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For resources that are VPCs, this is the percentage of IP address space in the VPC
        /// that's taken up by subnet CIDRs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For resources that are subnets, if the subnet has an IPv4 CIDR provisioned to it,
        /// this is the percentage of IPv4 address space in the subnet that's in use. If the subnet
        /// has an IPv6 CIDR provisioned to it, the percentage of IPv6 address space in use is
        /// not represented. The percentage of IPv6 address space in use cannot currently be calculated.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For resources that are public IPv4 pools, this is the percentage of IP address space
        /// in the pool that's been allocated to Elastic IP addresses (EIPs). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public double? IpUsage { get; set; }

        /// <summary>
        /// Checks to see if the IpUsage property is set.
        /// </summary>
        internal bool IsSetIpUsage() => this.IpUsage.HasValue;

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryId. 
        /// <para>
        /// The resource discovery ID.
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryId { get; set; }

        /// <summary>
        /// Checks to see if the IpamResourceDiscoveryId property is set.
        /// </summary>
        internal bool IsSetIpamResourceDiscoveryId() => this.IpamResourceDiscoveryId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceAttachmentStatus. 
        /// <para>
        /// For elastic network interfaces, this is the status of whether or not the elastic network
        /// interface is attached.
        /// </para>
        /// </summary>
        public IpamNetworkInterfaceAttachmentStatus NetworkInterfaceAttachmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceAttachmentStatus property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceAttachmentStatus() => this.NetworkInterfaceAttachmentStatus != null;

        /// <summary>
        /// Gets and sets the property ResourceCidr. 
        /// <para>
        /// The resource CIDR.
        /// </para>
        /// </summary>
        public string ResourceCidr { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCidr property is set.
        /// </summary>
        internal bool IsSetResourceCidr() => this.ResourceCidr != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// The resource owner ID.
        /// </para>
        /// </summary>
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerId() => this.ResourceOwnerId != null;

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The resource Region.
        /// </para>
        /// </summary>
        public string ResourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRegion property is set.
        /// </summary>
        internal bool IsSetResourceRegion() => this.ResourceRegion != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The resource tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<IpamResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        public IpamResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SampleTime. 
        /// <para>
        /// The last successful resource discovery time.
        /// </para>
        /// </summary>
        public DateTime? SampleTime { get; set; }

        /// <summary>
        /// Checks to see if the SampleTime property is set.
        /// </summary>
        internal bool IsSetSampleTime() => this.SampleTime.HasValue;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
