/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Creates a subnet in an existing VPC.
    /// 
    ///  
    /// <para>
    /// When you create each subnet, you provide the VPC ID and the CIDR block you want for
    /// the subnet. After you create a subnet, you can't change its CIDR block. The subnet's
    /// CIDR block can be the same as the VPC's CIDR block (assuming you want only a single
    /// subnet in the VPC), or a subset of the VPC's CIDR block. If you create more than one
    /// subnet in a VPC, the subnets' CIDR blocks must not overlap. The smallest subnet (and
    /// VPC) you can create uses a /28 netmask (16 IP addresses), and the largest uses a /16
    /// netmask (65,536 IP addresses).
    /// </para>
    ///  <important> 
    /// <para>
    /// AWS reserves both the first four and the last IP address in each subnet's CIDR block.
    /// They're not available for use.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you add more than one subnet to a VPC, they're set up in a star topology with a
    /// logical router in the middle.
    /// </para>
    ///  
    /// <para>
    /// If you launch an instance in a VPC using an Amazon EBS-backed AMI, the IP address
    /// doesn't change if you stop and restart the instance (unlike a similar instance launched
    /// outside a VPC, which gets a new IP address when restarted). It's therefore possible
    /// to have a subnet with no running instances (they're all stopped), but no remaining
    /// IP addresses available.
    /// </para>
    ///  
    /// <para>
    /// For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
    /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateSubnetRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private string _cidrBlock;
        private string _vpcId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateSubnetRequest() { }

        /// <summary>
        /// Instantiates CreateSubnetRequest with the parameterized properties
        /// </summary>
        /// <param name="vpcId">The ID of the VPC.</param>
        /// <param name="cidrBlock">The network range for the subnet, in CIDR notation. For example, <code>10.0.0.0/24</code>.</param>
        public CreateSubnetRequest(string vpcId, string cidrBlock)
        {
            _vpcId = vpcId;
            _cidrBlock = cidrBlock;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the subnet.
        /// </para>
        ///  
        /// <para>
        /// Default: Amazon EC2 selects one for you (recommended).
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
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The network range for the subnet, in CIDR notation. For example, <code>10.0.0.0/24</code>.
        /// </para>
        /// </summary>
        public string CidrBlock
        {
            get { return this._cidrBlock; }
            set { this._cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this._cidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
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