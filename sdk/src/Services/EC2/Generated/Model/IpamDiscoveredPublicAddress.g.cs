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
    /// A public IP Address discovered by IPAM.
    /// </summary>
    public partial class IpamDiscoveredPublicAddress
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The IP address.
        /// </para>
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property AddressAllocationId. 
        /// <para>
        /// The allocation ID of the resource the IP address is assigned to.
        /// </para>
        /// </summary>
        public string AddressAllocationId { get; set; }

        /// <summary>
        /// Checks to see if the AddressAllocationId property is set.
        /// </summary>
        internal bool IsSetAddressAllocationId() => this.AddressAllocationId != null;

        /// <summary>
        /// Gets and sets the property AddressOwnerId. 
        /// <para>
        /// The ID of the owner of the resource the IP address is assigned to.
        /// </para>
        /// </summary>
        public string AddressOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the AddressOwnerId property is set.
        /// </summary>
        internal bool IsSetAddressOwnerId() => this.AddressOwnerId != null;

        /// <summary>
        /// Gets and sets the property AddressRegion. 
        /// <para>
        /// The Region of the resource the IP address is assigned to.
        /// </para>
        /// </summary>
        public string AddressRegion { get; set; }

        /// <summary>
        /// Checks to see if the AddressRegion property is set.
        /// </summary>
        internal bool IsSetAddressRegion() => this.AddressRegion != null;

        /// <summary>
        /// Gets and sets the property AddressType. 
        /// <para>
        /// The IP address type.
        /// </para>
        /// </summary>
        public IpamPublicAddressType AddressType { get; set; }

        /// <summary>
        /// Checks to see if the AddressType property is set.
        /// </summary>
        internal bool IsSetAddressType() => this.AddressType != null;

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// The association status.
        /// </para>
        /// </summary>
        public IpamPublicAddressAssociationStatus AssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssociationStatus property is set.
        /// </summary>
        internal bool IsSetAssociationStatus() => this.AssociationStatus != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID of the instance the assigned IP address is assigned to.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

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
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The Availability Zone (AZ) or Local Zone (LZ) network border group that the resource
        /// that the IP address is assigned to is in. Defaults to an AZ network border group.
        /// For more information on available Local Zones, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html#byoip-zone-avail">Local
        /// Zone availability</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup { get; set; }

        /// <summary>
        /// Checks to see if the NetworkBorderGroup property is set.
        /// </summary>
        internal bool IsSetNetworkBorderGroup() => this.NetworkBorderGroup != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceDescription. 
        /// <para>
        /// The description of the network interface that IP address is assigned to.
        /// </para>
        /// </summary>
        public string NetworkInterfaceDescription { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceDescription property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceDescription() => this.NetworkInterfaceDescription != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The network interface ID of the resource with the assigned IP address.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property PublicIpv4PoolId. 
        /// <para>
        /// The ID of the public IPv4 pool that the resource with the assigned IP address is from.
        /// </para>
        /// </summary>
        public string PublicIpv4PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpv4PoolId property is set.
        /// </summary>
        internal bool IsSetPublicIpv4PoolId() => this.PublicIpv4PoolId != null;

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
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// Security groups associated with the resource that the IP address is assigned to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamPublicAddressSecurityGroup> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<IpamPublicAddressSecurityGroup>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The Amazon Web Services service associated with the IP address.
        /// </para>
        /// </summary>
        public IpamPublicAddressAwsService Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property ServiceResource. 
        /// <para>
        /// The resource ARN or ID.
        /// </para>
        /// </summary>
        public string ServiceResource { get; set; }

        /// <summary>
        /// Checks to see if the ServiceResource property is set.
        /// </summary>
        internal bool IsSetServiceResource() => this.ServiceResource != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet that the resource with the assigned IP address is in.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the IP address.
        /// </para>
        /// </summary>
        public IpamPublicAddressTags Tags { get; set; }

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC that the resource with the assigned IP address is in.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
