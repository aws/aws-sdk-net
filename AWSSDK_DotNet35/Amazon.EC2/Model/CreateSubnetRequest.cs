/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSubnet operation.
    /// <para> Creates a subnet in an existing VPC. You can create up to 20 subnets in a VPC. If you add more than one subnet to a VPC, they're set
    /// up in a star topology with a logical router in the middle. When you create each subnet, you provide the VPC ID and the CIDR block you want
    /// for the subnet. Once you create a subnet, you can't change its CIDR block. The subnet's CIDR block can be the same as the VPC's CIDR block
    /// (assuming you want only a single subnet in the VPC), or a subset of the VPC's CIDR block. If you create more than one subnet in a VPC, the
    /// subnets' CIDR blocks must not overlap. The smallest subnet (and VPC) you can create uses a <c>/28</c> netmask (16 IP addresses), and the
    /// largest uses a <c>/18</c> netmask (16,384 IP addresses). </para> <para><b>IMPORTANT:</b> AWS reserves both the first four and the last IP
    /// address in each subnet's CIDR block. They're not available for use. </para>
    /// </summary>
    public partial class CreateSubnetRequest : AmazonEC2Request
    {
        private string vpcId;
        private string cidrBlock;
        private string availabilityZone;


        /// <summary>
        /// The ID of the VPC to create the subnet in.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// The CIDR block the subnet is to cover.
        ///  
        /// </summary>
        public string CidrBlock
        {
            get { return this.cidrBlock; }
            set { this.cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this.cidrBlock != null;
        }

        /// <summary>
        /// The Availability Zone to create the subnet in.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

    }
}
    
