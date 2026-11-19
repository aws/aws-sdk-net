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
    /// Describes an Elastic IP address, or a carrier IP address.
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The ID representing the allocation of the address.
        /// </para>
        /// </summary>
        public string AllocationId { get; set; }

        /// <summary>
        /// Checks to see if the AllocationId property is set.
        /// </summary>
        internal bool IsSetAllocationId() => this.AllocationId != null;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID representing the association of the address with an instance.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property CarrierIp. 
        /// <para>
        /// The carrier IP address associated. This option is only available for network interfaces
        /// which reside in a subnet in a Wavelength Zone (for example an EC2 instance). 
        /// </para>
        /// </summary>
        public string CarrierIp { get; set; }

        /// <summary>
        /// Checks to see if the CarrierIp property is set.
        /// </summary>
        internal bool IsSetCarrierIp() => this.CarrierIp != null;

        /// <summary>
        /// Gets and sets the property CustomerOwnedIp. 
        /// <para>
        /// The customer-owned IP address.
        /// </para>
        /// </summary>
        public string CustomerOwnedIp { get; set; }

        /// <summary>
        /// Checks to see if the CustomerOwnedIp property is set.
        /// </summary>
        internal bool IsSetCustomerOwnedIp() => this.CustomerOwnedIp != null;

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// The ID of the customer-owned address pool.
        /// </para>
        /// </summary>
        public string CustomerOwnedIpv4Pool { get; set; }

        /// <summary>
        /// Checks to see if the CustomerOwnedIpv4Pool property is set.
        /// </summary>
        internal bool IsSetCustomerOwnedIpv4Pool() => this.CustomerOwnedIpv4Pool != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The network (<c>vpc</c>).
        /// </para>
        /// </summary>
        public DomainType Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance that the address is associated with (if any).
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The name of the unique set of Availability Zones, Local Zones, or Wavelength Zones
        /// from which Amazon Web Services advertises IP addresses.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup { get; set; }

        /// <summary>
        /// Checks to see if the NetworkBorderGroup property is set.
        /// </summary>
        internal bool IsSetNetworkBorderGroup() => this.NetworkBorderGroup != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceOwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceOwnerId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceOwnerId() => this.NetworkInterfaceOwnerId != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IP address associated with the Elastic IP address.
        /// </para>
        /// </summary>
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The Elastic IP address.
        /// </para>
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// Checks to see if the PublicIp property is set.
        /// </summary>
        internal bool IsSetPublicIp() => this.PublicIp != null;

        /// <summary>
        /// Gets and sets the property PublicIpv4Pool. 
        /// <para>
        /// The ID of an address pool.
        /// </para>
        /// </summary>
        public string PublicIpv4Pool { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpv4Pool property is set.
        /// </summary>
        internal bool IsSetPublicIpv4Pool() => this.PublicIpv4Pool != null;

        /// <summary>
        /// Gets and sets the property ServiceManaged. 
        /// <para>
        /// The service that manages the elastic IP address.
        /// </para>
        ///  <note> 
        /// <para>
        /// The only option supported today is <c>alb</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public ServiceManaged ServiceManaged { get; set; }

        /// <summary>
        /// Checks to see if the ServiceManaged property is set.
        /// </summary>
        internal bool IsSetServiceManaged() => this.ServiceManaged != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet where the IP address is allocated.
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
        /// Any tags assigned to the Elastic IP address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
