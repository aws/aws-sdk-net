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
    /// Describes the IP addresses and network interface associated with a NAT gateway.
    /// </summary>
    public partial class NatGatewayAddress
    {
        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// [Public NAT gateway only] The allocation ID of the Elastic IP address that's associated
        /// with the NAT gateway.
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
        /// [Public NAT gateway only] The association ID of the Elastic IP address that's associated
        /// with the NAT gateway.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where this Elastic IP address (EIP) is being used to handle
        /// outbound NAT traffic.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone where this Elastic IP address (EIP) is being used
        /// to handle outbound NAT traffic. Use this instead of AvailabilityZone for consistent
        /// identification of AZs across Amazon Web Services Regions.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// The address failure message.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property IsPrimary. 
        /// <para>
        /// Defines if the IP address is the primary address.
        /// </para>
        /// </summary>
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Checks to see if the IsPrimary property is set.
        /// </summary>
        internal bool IsSetIsPrimary() => this.IsPrimary.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface associated with the NAT gateway.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property PrivateIp. 
        /// <para>
        /// The private IP address associated with the NAT gateway.
        /// </para>
        /// </summary>
        public string PrivateIp { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIp property is set.
        /// </summary>
        internal bool IsSetPrivateIp() => this.PrivateIp != null;

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// [Public NAT gateway only] The Elastic IP address associated with the NAT gateway.
        /// </para>
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// Checks to see if the PublicIp property is set.
        /// </summary>
        internal bool IsSetPublicIp() => this.PublicIp != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The address status.
        /// </para>
        /// </summary>
        public NatGatewayAddressStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
