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
    /// Describes a NAT gateway.
    /// </summary>
    public partial class NatGateway
    {
        private List<NatGatewayAttachedAppliance> _attachedAppliances = AWSConfigs.InitializeCollections ? new List<NatGatewayAttachedAppliance>() : null;
        private AutoProvisionZonesState _autoProvisionZones;
        private AutoScalingIpsState _autoScalingIps;
        private AvailabilityMode _availabilityMode;
        private ConnectivityType _connectivityType;
        private DateTime? _createTime;
        private DateTime? _deleteTime;
        private string _failureCode;
        private string _failureMessage;
        private List<NatGatewayAddress> _natGatewayAddresses = AWSConfigs.InitializeCollections ? new List<NatGatewayAddress>() : null;
        private string _natGatewayId;
        private ProvisionedBandwidth _provisionedBandwidth;
        private string _routeTableId;
        private NatGatewayState _state;
        private string _subnetId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AttachedAppliances. 
        /// <para>
        /// The proxy appliances attached to the NAT Gateway for filtering and inspecting traffic
        /// to prevent data exfiltration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NatGatewayAttachedAppliance> AttachedAppliances
        {
            get { return this._attachedAppliances; }
            set { this._attachedAppliances = value; }
        }

        // Check to see if AttachedAppliances property is set
        internal bool IsSetAttachedAppliances()
        {
            return this._attachedAppliances != null && (this._attachedAppliances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoProvisionZones. 
        /// <para>
        /// For regional NAT gateways only: Indicates whether Amazon Web Services automatically
        /// manages AZ coverage. When enabled, the NAT gateway associates EIPs in all AZs where
        /// your VPC has subnets to handle outbound NAT traffic, expands to new AZs when you create
        /// subnets there, and retracts from AZs where you've removed all subnets. When disabled,
        /// you must manually manage which AZs the NAT gateway supports and their corresponding
        /// EIPs.
        /// </para>
        ///  
        /// <para>
        /// A regional NAT gateway is a single NAT Gateway that works across multiple availability
        /// zones (AZs) in your VPC, providing redundancy, scalability and availability across
        /// all the AZs in a Region.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/nat-gateways-regional.html">Regional
        /// NAT gateways for automatic multi-AZ expansion</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        public AutoProvisionZonesState AutoProvisionZones
        {
            get { return this._autoProvisionZones; }
            set { this._autoProvisionZones = value; }
        }

        // Check to see if AutoProvisionZones property is set
        internal bool IsSetAutoProvisionZones()
        {
            return this._autoProvisionZones != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingIps. 
        /// <para>
        /// For regional NAT gateways only: Indicates whether Amazon Web Services automatically
        /// allocates additional Elastic IP addresses (EIPs) in an AZ when the NAT gateway needs
        /// more ports due to increased concurrent connections to a single destination from that
        /// AZ.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/nat-gateways-regional.html">Regional
        /// NAT gateways for automatic multi-AZ expansion</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        public AutoScalingIpsState AutoScalingIps
        {
            get { return this._autoScalingIps; }
            set { this._autoScalingIps = value; }
        }

        // Check to see if AutoScalingIps property is set
        internal bool IsSetAutoScalingIps()
        {
            return this._autoScalingIps != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityMode. 
        /// <para>
        /// Indicates whether this is a zonal (single-AZ) or regional (multi-AZ) NAT gateway.
        /// </para>
        ///  
        /// <para>
        /// A zonal NAT gateway is a NAT Gateway that provides redundancy and scalability within
        /// a single availability zone. A regional NAT gateway is a single NAT Gateway that works
        /// across multiple availability zones (AZs) in your VPC, providing redundancy, scalability
        /// and availability across all the AZs in a Region.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/nat-gateways-regional.html">Regional
        /// NAT gateways for automatic multi-AZ expansion</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        public AvailabilityMode AvailabilityMode
        {
            get { return this._availabilityMode; }
            set { this._availabilityMode = value; }
        }

        // Check to see if AvailabilityMode property is set
        internal bool IsSetAvailabilityMode()
        {
            return this._availabilityMode != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectivityType. 
        /// <para>
        /// Indicates whether the NAT gateway supports public or private connectivity.
        /// </para>
        /// </summary>
        public ConnectivityType ConnectivityType
        {
            get { return this._connectivityType; }
            set { this._connectivityType = value; }
        }

        // Check to see if ConnectivityType property is set
        internal bool IsSetConnectivityType()
        {
            return this._connectivityType != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time the NAT gateway was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteTime. 
        /// <para>
        /// The date and time the NAT gateway was deleted, if applicable.
        /// </para>
        /// </summary>
        public DateTime? DeleteTime
        {
            get { return this._deleteTime; }
            set { this._deleteTime = value; }
        }

        // Check to see if DeleteTime property is set
        internal bool IsSetDeleteTime()
        {
            return this._deleteTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// If the NAT gateway could not be created, specifies the error code for the failure.
        /// (<c>InsufficientFreeAddressesInSubnet</c> | <c>Gateway.NotAttached</c> | <c>InvalidAllocationID.NotFound</c>
        /// | <c>Resource.AlreadyAssociated</c> | <c>InternalError</c> | <c>InvalidSubnetID.NotFound</c>)
        /// </para>
        /// </summary>
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// If the NAT gateway could not be created, specifies the error message for the failure,
        /// that corresponds to the error code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For InsufficientFreeAddressesInSubnet: "Subnet has insufficient free addresses to
        /// create this NAT gateway"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Gateway.NotAttached: "Network vpc-xxxxxxxx has no Internet gateway attached"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For InvalidAllocationID.NotFound: "Elastic IP address eipalloc-xxxxxxxx could not
        /// be associated with this NAT gateway"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Resource.AlreadyAssociated: "Elastic IP address eipalloc-xxxxxxxx is already associated"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For InternalError: "Network interface eni-xxxxxxxx, created and used internally by
        /// this NAT gateway is in an invalid state. Please try again."
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For InvalidSubnetID.NotFound: "The specified subnet subnet-xxxxxxxx does not exist
        /// or could not be found."
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property NatGatewayAddresses. 
        /// <para>
        /// Information about the IP addresses and network interface associated with the NAT gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NatGatewayAddress> NatGatewayAddresses
        {
            get { return this._natGatewayAddresses; }
            set { this._natGatewayAddresses = value; }
        }

        // Check to see if NatGatewayAddresses property is set
        internal bool IsSetNatGatewayAddresses()
        {
            return this._natGatewayAddresses != null && (this._natGatewayAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// The ID of the NAT gateway.
        /// </para>
        /// </summary>
        public string NatGatewayId
        {
            get { return this._natGatewayId; }
            set { this._natGatewayId = value; }
        }

        // Check to see if NatGatewayId property is set
        internal bool IsSetNatGatewayId()
        {
            return this._natGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedBandwidth. 
        /// <para>
        /// Reserved. If you need to sustain traffic greater than the <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html#vpc-limits-gateways">documented
        /// limits</a>, contact Amazon Web Services Support.
        /// </para>
        /// </summary>
        public ProvisionedBandwidth ProvisionedBandwidth
        {
            get { return this._provisionedBandwidth; }
            set { this._provisionedBandwidth = value; }
        }

        // Check to see if ProvisionedBandwidth property is set
        internal bool IsSetProvisionedBandwidth()
        {
            return this._provisionedBandwidth != null;
        }

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// For regional NAT gateways only, this is the ID of the NAT gateway.
        /// </para>
        /// </summary>
        public string RouteTableId
        {
            get { return this._routeTableId; }
            set { this._routeTableId = value; }
        }

        // Check to see if RouteTableId property is set
        internal bool IsSetRouteTableId()
        {
            return this._routeTableId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the NAT gateway.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>pending</c>: The NAT gateway is being created and is not ready to process traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c>: The NAT gateway could not be created. Check the <c>failureCode</c>
        /// and <c>failureMessage</c> fields for the reason.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: The NAT gateway is able to process traffic. This status remains
        /// until you delete the NAT gateway, and does not indicate the health of the NAT gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: The NAT gateway is in the process of being terminated and may still
        /// be processing traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The NAT gateway has been terminated and is no longer processing traffic.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NatGatewayState State
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
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in which the NAT gateway is located.
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
        /// The tags for the NAT gateway.
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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC in which the NAT gateway is located.
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