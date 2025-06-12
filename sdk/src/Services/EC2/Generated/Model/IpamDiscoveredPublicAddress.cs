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
    /// A public IP Address discovered by IPAM.
    /// </summary>
    public partial class IpamDiscoveredPublicAddress
    {
        private string _address;
        private string _addressAllocationId;
        private string _addressOwnerId;
        private string _addressRegion;
        private IpamPublicAddressType _addressType;
        private IpamPublicAddressAssociationStatus _associationStatus;
        private string _instanceId;
        private string _ipamResourceDiscoveryId;
        private string _networkBorderGroup;
        private string _networkInterfaceDescription;
        private string _networkInterfaceId;
        private string _publicIpv4PoolId;
        private DateTime? _sampleTime;
        private List<IpamPublicAddressSecurityGroup> _securityGroups = AWSConfigs.InitializeCollections ? new List<IpamPublicAddressSecurityGroup>() : null;
        private IpamPublicAddressAwsService _service;
        private string _serviceResource;
        private string _subnetId;
        private IpamPublicAddressTags _tags;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The IP address.
        /// </para>
        /// </summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property AddressAllocationId. 
        /// <para>
        /// The allocation ID of the resource the IP address is assigned to.
        /// </para>
        /// </summary>
        public string AddressAllocationId
        {
            get { return this._addressAllocationId; }
            set { this._addressAllocationId = value; }
        }

        // Check to see if AddressAllocationId property is set
        internal bool IsSetAddressAllocationId()
        {
            return this._addressAllocationId != null;
        }

        /// <summary>
        /// Gets and sets the property AddressOwnerId. 
        /// <para>
        /// The ID of the owner of the resource the IP address is assigned to.
        /// </para>
        /// </summary>
        public string AddressOwnerId
        {
            get { return this._addressOwnerId; }
            set { this._addressOwnerId = value; }
        }

        // Check to see if AddressOwnerId property is set
        internal bool IsSetAddressOwnerId()
        {
            return this._addressOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property AddressRegion. 
        /// <para>
        /// The Region of the resource the IP address is assigned to.
        /// </para>
        /// </summary>
        public string AddressRegion
        {
            get { return this._addressRegion; }
            set { this._addressRegion = value; }
        }

        // Check to see if AddressRegion property is set
        internal bool IsSetAddressRegion()
        {
            return this._addressRegion != null;
        }

        /// <summary>
        /// Gets and sets the property AddressType. 
        /// <para>
        /// The IP address type.
        /// </para>
        /// </summary>
        public IpamPublicAddressType AddressType
        {
            get { return this._addressType; }
            set { this._addressType = value; }
        }

        // Check to see if AddressType property is set
        internal bool IsSetAddressType()
        {
            return this._addressType != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// The association status.
        /// </para>
        /// </summary>
        public IpamPublicAddressAssociationStatus AssociationStatus
        {
            get { return this._associationStatus; }
            set { this._associationStatus = value; }
        }

        // Check to see if AssociationStatus property is set
        internal bool IsSetAssociationStatus()
        {
            return this._associationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID of the instance the assigned IP address is assigned to.
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
        /// Gets and sets the property IpamResourceDiscoveryId. 
        /// <para>
        /// The resource discovery ID.
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryId
        {
            get { return this._ipamResourceDiscoveryId; }
            set { this._ipamResourceDiscoveryId = value; }
        }

        // Check to see if IpamResourceDiscoveryId property is set
        internal bool IsSetIpamResourceDiscoveryId()
        {
            return this._ipamResourceDiscoveryId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The Availability Zone (AZ) or Local Zone (LZ) network border group that the resource
        /// that the IP address is assigned to is in. Defaults to an AZ network border group.
        /// For more information on available Local Zones, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html#byoip-zone-avail">Local
        /// Zone availability</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Gets and sets the property NetworkInterfaceDescription. 
        /// <para>
        /// The description of the network interface that IP address is assigned to.
        /// </para>
        /// </summary>
        public string NetworkInterfaceDescription
        {
            get { return this._networkInterfaceDescription; }
            set { this._networkInterfaceDescription = value; }
        }

        // Check to see if NetworkInterfaceDescription property is set
        internal bool IsSetNetworkInterfaceDescription()
        {
            return this._networkInterfaceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The network interface ID of the resource with the assigned IP address.
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
        /// Gets and sets the property PublicIpv4PoolId. 
        /// <para>
        /// The ID of the public IPv4 pool that the resource with the assigned IP address is from.
        /// </para>
        /// </summary>
        public string PublicIpv4PoolId
        {
            get { return this._publicIpv4PoolId; }
            set { this._publicIpv4PoolId = value; }
        }

        // Check to see if PublicIpv4PoolId property is set
        internal bool IsSetPublicIpv4PoolId()
        {
            return this._publicIpv4PoolId != null;
        }

        /// <summary>
        /// Gets and sets the property SampleTime. 
        /// <para>
        /// The last successful resource discovery time.
        /// </para>
        /// </summary>
        public DateTime? SampleTime
        {
            get { return this._sampleTime; }
            set { this._sampleTime = value; }
        }

        // Check to see if SampleTime property is set
        internal bool IsSetSampleTime()
        {
            return this._sampleTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// Security groups associated with the resource that the IP address is assigned to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamPublicAddressSecurityGroup> SecurityGroups
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
        /// Gets and sets the property Service. 
        /// <para>
        /// The Amazon Web Services service associated with the IP address.
        /// </para>
        /// </summary>
        public IpamPublicAddressAwsService Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceResource. 
        /// <para>
        /// The resource ARN or ID.
        /// </para>
        /// </summary>
        public string ServiceResource
        {
            get { return this._serviceResource; }
            set { this._serviceResource = value; }
        }

        // Check to see if ServiceResource property is set
        internal bool IsSetServiceResource()
        {
            return this._serviceResource != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet that the resource with the assigned IP address is in.
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
        /// Tags associated with the IP address.
        /// </para>
        /// </summary>
        public IpamPublicAddressTags Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC that the resource with the assigned IP address is in.
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