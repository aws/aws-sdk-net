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
    /// Describes a NAT gateway.
    /// </summary>
    public partial class NatGateway
    {
        /// <summary>
        /// Gets and sets the property AttachedAppliances. 
        /// <para>
        /// The proxy appliances attached to the NAT Gateway for filtering and inspecting traffic
        /// to prevent data exfiltration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NatGatewayAttachedAppliance> AttachedAppliances { get; set; } = AWSConfigs.InitializeCollections ? new List<NatGatewayAttachedAppliance>() : null;

        /// <summary>
        /// Checks to see if the AttachedAppliances property is set.
        /// </summary>
        internal bool IsSetAttachedAppliances() => this.AttachedAppliances != null && (this.AttachedAppliances.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public AutoProvisionZonesState AutoProvisionZones { get; set; }

        /// <summary>
        /// Checks to see if the AutoProvisionZones property is set.
        /// </summary>
        internal bool IsSetAutoProvisionZones() => this.AutoProvisionZones != null;

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
        public AutoScalingIpsState AutoScalingIps { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingIps property is set.
        /// </summary>
        internal bool IsSetAutoScalingIps() => this.AutoScalingIps != null;

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
        public AvailabilityMode AvailabilityMode { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityMode property is set.
        /// </summary>
        internal bool IsSetAvailabilityMode() => this.AvailabilityMode != null;

        /// <summary>
        /// Gets and sets the property ConnectivityType. 
        /// <para>
        /// Indicates whether the NAT gateway supports public or private connectivity.
        /// </para>
        /// </summary>
        public ConnectivityType ConnectivityType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectivityType property is set.
        /// </summary>
        internal bool IsSetConnectivityType() => this.ConnectivityType != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time the NAT gateway was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteTime. 
        /// <para>
        /// The date and time the NAT gateway was deleted, if applicable.
        /// </para>
        /// </summary>
        public DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Checks to see if the DeleteTime property is set.
        /// </summary>
        internal bool IsSetDeleteTime() => this.DeleteTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// If the NAT gateway could not be created, specifies the error code for the failure.
        /// (<c>InsufficientFreeAddressesInSubnet</c> | <c>Gateway.NotAttached</c> | <c>InvalidAllocationID.NotFound</c>
        /// | <c>Resource.AlreadyAssociated</c> | <c>InternalError</c> | <c>InvalidSubnetID.NotFound</c>)
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

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
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property NatGatewayAddresses. 
        /// <para>
        /// Information about the IP addresses and network interface associated with the NAT gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NatGatewayAddress> NatGatewayAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<NatGatewayAddress>() : null;

        /// <summary>
        /// Checks to see if the NatGatewayAddresses property is set.
        /// </summary>
        internal bool IsSetNatGatewayAddresses() => this.NatGatewayAddresses != null && (this.NatGatewayAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// The ID of the NAT gateway.
        /// </para>
        /// </summary>
        public string NatGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the NatGatewayId property is set.
        /// </summary>
        internal bool IsSetNatGatewayId() => this.NatGatewayId != null;

        /// <summary>
        /// Gets and sets the property ProvisionedBandwidth. 
        /// <para>
        /// Reserved. If you need to sustain traffic greater than the <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html#vpc-limits-gateways">documented
        /// limits</a>, contact Amazon Web Services Support.
        /// </para>
        /// </summary>
        public ProvisionedBandwidth ProvisionedBandwidth { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedBandwidth property is set.
        /// </summary>
        internal bool IsSetProvisionedBandwidth() => this.ProvisionedBandwidth != null;

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// For regional NAT gateways only, this is the ID of the NAT gateway.
        /// </para>
        /// </summary>
        public string RouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableId property is set.
        /// </summary>
        internal bool IsSetRouteTableId() => this.RouteTableId != null;

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
        public NatGatewayState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in which the NAT gateway is located.
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
        /// The tags for the NAT gateway.
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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC in which the NAT gateway is located.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
