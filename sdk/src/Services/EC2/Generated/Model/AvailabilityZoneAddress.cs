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
    /// For regional NAT gateways only: The configuration specifying which Elastic IP address
    /// (EIP) to use for handling outbound NAT traffic from a specific Availability Zone.
    /// 
    /// 
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
    public partial class AvailabilityZoneAddress
    {
        private List<string> _allocationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _availabilityZone;
        private string _availabilityZoneId;

        /// <summary>
        /// Gets and sets the property AllocationIds. 
        /// <para>
        /// The allocation IDs of the Elastic IP addresses (EIPs) to be used for handling outbound
        /// NAT traffic in this specific Availability Zone.
        /// </para>
        /// </summary>
        public List<string> AllocationIds
        {
            get { return this._allocationIds; }
            set { this._allocationIds = value; }
        }

        // Check to see if AllocationIds property is set
        internal bool IsSetAllocationIds()
        {
            return this._allocationIds != null && (this._allocationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// For regional NAT gateways only: The Availability Zone where this specific NAT gateway
        /// configuration will be active. Each AZ in a regional NAT gateway has its own configuration
        /// to handle outbound NAT traffic from that AZ. 
        /// </para>
        ///  
        /// <para>
        /// A regional NAT gateway is a single NAT Gateway that works across multiple availability
        /// zones (AZs) in your VPC, providing redundancy, scalability and availability across
        /// all the AZs in a Region.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// For regional NAT gateways only: The ID of the Availability Zone where this specific
        /// NAT gateway configuration will be active. Each AZ in a regional NAT gateway has its
        /// own configuration to handle outbound NAT traffic from that AZ. Use this instead of
        /// AvailabilityZone for consistent identification of AZs across Amazon Web Services Regions.
        /// 
        /// </para>
        ///  
        /// <para>
        /// A regional NAT gateway is a single NAT Gateway that works across multiple availability
        /// zones (AZs) in your VPC, providing redundancy, scalability and availability across
        /// all the AZs in a Region.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

    }
}