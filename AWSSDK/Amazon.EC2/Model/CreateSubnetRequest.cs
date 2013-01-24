/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Creates a subnet in an existing VPC.
    /// </summary>
    /// <remarks>
    /// You can create up to 20 subnets in a VPC. If you add more than one subnet to a
    /// VPC, they're set up in a star topology with a logical router in the middle.
    /// If you feel you need more than 20 subnets, you can request more by going
    /// to http://aws.amazon.com/contact-us/vpc-request/.
    /// 
    /// When you create each subnet, you provide the VPC ID and the CIDR block you
    /// want for the subnet. Once you create a subnet, you can't change its CIDR block.
    /// The subnet's CIDR block can be the same as the VPC's CIDR block (assuming you
    /// want only a single subnet in the VPC), or a subset of the VPC's CIDR block. If you
    /// create more than one subnet in a VPC, the subnets' CIDR blocks must not overlap.
    /// The smallest subnet (and VPC) you can create uses a /28 netmask (16 IP
    /// addresses), and the largest uses a /18 netmask (16,384 IP addresses).
    ///
    /// *Important*
    ///
    /// AWS reserves both the first four and the last IP address in each subnet's CIDR block.
    /// They're not available for use.
    ///
    /// AWS might delete any subnet you create with this operation if you leave it inactive
    /// for an extended period of time (inactive means that there are no running Amazon
    /// EC2 instances in the subnet).
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateSubnetRequest
    {    
        private string vpcIdField;
        private string cidrBlockField;
        private string availabilityZoneField;

        /// <summary>
        /// The ID of the VPC where you want to create the subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPC where you want to create the subnet.
        /// </summary>
        /// <param name="vpcId">The ID of the VPC where you want to create the
        /// subnet.</param>
        /// <returns>this instance</returns>
        public CreateSubnetRequest WithVpcId(string vpcId)
        {
            this.vpcIdField = vpcId;
            return this;
        }

        /// <summary>
        /// Checks if VpcId property is set
        /// </summary>
        /// <returns>true if VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return this.vpcIdField != null;
        }

        /// <summary>
        /// The CIDR block you want the subnet to cover.
        /// </summary>
        [XmlElementAttribute(ElementName = "CidrBlock")]
        public string CidrBlock
        {
            get { return this.cidrBlockField; }
            set { this.cidrBlockField = value; }
        }

        /// <summary>
        /// Sets the CIDR block you want the subnet to cover.
        /// </summary>
        /// <param name="cidrBlock">The CIDR block you want the subnet to cover.</param>
        /// <returns>this instance</returns>
        public CreateSubnetRequest WithCidrBlock(string cidrBlock)
        {
            this.cidrBlockField = cidrBlock;
            return this;
        }

        /// <summary>
        /// Checks if CidrBlock property is set
        /// </summary>
        /// <returns>true if CidrBlock property is set</returns>
        public bool IsSetCidrBlock()
        {
            return this.cidrBlockField != null;
        }

        /// <summary>
        /// The Availability Zone you want the subnet in.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the Availability Zone you want the subnet in.
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone you want the subnet in.</param>
        /// <returns>this instance</returns>
        public CreateSubnetRequest WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

    }
}
