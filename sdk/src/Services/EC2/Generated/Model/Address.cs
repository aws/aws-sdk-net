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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _allocationId;
        private string _associationId;
        private string _carrierIp;
        private string _customerOwnedIp;
        private string _customerOwnedIpv4Pool;
        private DomainType _domain;
        private string _instanceId;
        private string _networkBorderGroup;
        private string _networkInterfaceId;
        private string _networkInterfaceOwnerId;
        private string _privateIpAddress;
        private string _publicIp;
        private string _publicIpv4Pool;
        private ServiceManaged _serviceManaged;
        private string _subnetId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The ID representing the allocation of the address.
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
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID representing the association of the address with an instance.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property CarrierIp. 
        /// <para>
        /// The carrier IP address associated. This option is only available for network interfaces
        /// which reside in a subnet in a Wavelength Zone (for example an EC2 instance). 
        /// </para>
        /// </summary>
        public string CarrierIp
        {
            get { return this._carrierIp; }
            set { this._carrierIp = value; }
        }

        // Check to see if CarrierIp property is set
        internal bool IsSetCarrierIp()
        {
            return this._carrierIp != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerOwnedIp. 
        /// <para>
        /// The customer-owned IP address.
        /// </para>
        /// </summary>
        public string CustomerOwnedIp
        {
            get { return this._customerOwnedIp; }
            set { this._customerOwnedIp = value; }
        }

        // Check to see if CustomerOwnedIp property is set
        internal bool IsSetCustomerOwnedIp()
        {
            return this._customerOwnedIp != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// The ID of the customer-owned address pool.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// The network (<c>vpc</c>).
        /// </para>
        /// </summary>
        public DomainType Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance that the address is associated with (if any).
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The name of the unique set of Availability Zones, Local Zones, or Wavelength Zones
        /// from which Amazon Web Services advertises IP addresses.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup
        {
            get { return this._networkBorderGroup; }
            set { this._networkBorderGroup = value; }
        }

        // Check to see if NetworkBorderGroup property is set
        internal bool IsSetNetworkBorderGroup()
        {
            return this._networkBorderGroup != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceOwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceOwnerId
        {
            get { return this._networkInterfaceOwnerId; }
            set { this._networkInterfaceOwnerId = value; }
        }

        // Check to see if NetworkInterfaceOwnerId property is set
        internal bool IsSetNetworkInterfaceOwnerId()
        {
            return this._networkInterfaceOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IP address associated with the Elastic IP address.
        /// </para>
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this._privateIpAddress; }
            set { this._privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this._privateIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The Elastic IP address.
        /// </para>
        /// </summary>
        public string PublicIp
        {
            get { return this._publicIp; }
            set { this._publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this._publicIp != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIpv4Pool. 
        /// <para>
        /// The ID of an address pool.
        /// </para>
        /// </summary>
        public string PublicIpv4Pool
        {
            get { return this._publicIpv4Pool; }
            set { this._publicIpv4Pool = value; }
        }

        // Check to see if PublicIpv4Pool property is set
        internal bool IsSetPublicIpv4Pool()
        {
            return this._publicIpv4Pool != null;
        }

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
        public ServiceManaged ServiceManaged
        {
            get { return this._serviceManaged; }
            set { this._serviceManaged = value; }
        }

        // Check to see if ServiceManaged property is set
        internal bool IsSetServiceManaged()
        {
            return this._serviceManaged != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet where the IP address is allocated.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the Elastic IP address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

    }
}